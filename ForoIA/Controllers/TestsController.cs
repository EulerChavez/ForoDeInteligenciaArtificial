using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ForoIA.Models.Db;
using ForoIA.ViewModel.Test;

namespace ForoIA.Controllers {

    [Authorize]
    public class TestsController : Controller {

        private ForoDbContext db = new ForoDbContext();

        // GET: Tests
        public ActionResult Index() {

            return View();

        }

        // GET: Tests/ConfigurarPrueba
        public ActionResult ConfigurarPrueba() {

            return View();

        }

        // POST: Tests/ConfigurarPrueba
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ConfigurarPrueba(ConfigurationTestViewModel config) {

            // Se obtienen las unidades seleccionadas
            List<int> unidades = new List<int>() {
                config.Unidad1 ? 1 : 0,
                config.Unidad2 ? 2 : 0,
                config.Unidad3 ? 3 : 0,
                config.Unidad4 ? 4 : 0,
                config.Unidad5 ? 5 : 0
            };


            if (unidades.All(u => u == 0)) {

                ModelState.AddModelError("unidades", "Se debe seleccionar al menos una unidad para ser evaluado.");

                return View();

            }

            // Se obtiene la dificultad seleccionada
            var dificultad = config.Dificultad;

            if (dificultad <= 0) {

                ModelState.AddModelError("dificultad", "Se debe seleccionar la dificultad con la que se evaluará.");

                return View();

            }

            // Se crea el registro de la configuración del test
            var configuration = new ConfigurationTest() {

                DificultyId = config.Dificultad,
                StartDate = DateTime.Now,
                Username = User.Identity.Name,
                Dificulty = db.Dificulty.First(d => d.Id == config.Dificultad)

            };

            // Se inserta el registro en la BD
            db.ConfigurationTest.Add(configuration);
            db.SaveChanges();

            List<TestAnswer> preguntas = new List<TestAnswer>();

            List<Test> preguntasObtenidas = null;

            // Obtener las preguntas aleatorias de acuerdo a los topicos seleccionados y la dificultad
            // Se seleccionarán 6 preguntas por cada tópico
            foreach (var topic in unidades) {

                // Con dificultad: Facil, Medio y Dificil

                if (dificultad < 4) {

                    // Se obtienen las preguntas de forma aleatoria
                    // dependiendo de la dificultad y de las unidades seleccionadas
                    preguntasObtenidas = db.Test.Include(t => t.Answers)
                                           .OrderBy(t => Guid.NewGuid())
                                           .Where(t => t.TopicId == topic && t.DificultId == dificultad)
                                           .Take(6)
                                           .ToList();

                } else { // Con dificultad de un poco de todo

                    // Se obtienen las preguntas de forma aleatoria
                    // dependiendo de la dificultad y de las unidades seleccionadas
                    preguntasObtenidas = db.Test.Include(t => t.Answers)
                                           .OrderBy(t => Guid.NewGuid())
                                           .Where(t => t.TopicId == topic)
                                           .Take(6)
                                           .ToList();

                }

                // De las preguntas obtenidas, se "meapean" ciertas propiedades al modelo TestAnswer
                foreach (var test in preguntasObtenidas) {

                    var testAnswer = new TestAnswer() {

                        ConfigurationTestId = configuration.Id,
                        TestId = test.Id,

                    };

                    preguntas.Add(testAnswer);

                }

            }

            // Se realiza el registro en la BD
            db.TestAnswer.AddRange(preguntas);
            db.SaveChanges();

            return RedirectToAction("IniciarPrueba");

        }

        // GET: Tests/IniciarPrueba
        public ActionResult IniciarPrueba() {

            // Se obtiene el nombre del usuaario
            var userName = User.Identity.Name;

            // Obtenemos la configuracion del usuario
            var testConfiguration = db.ConfigurationTest
                                      .First(t => t.Username.Equals(userName));

            // Se obtiene la primera pregunta
            var primeraPregunta = db.TestAnswer
                                    .Include(ta => ta.Test)
                                    .Where(ta => ta.ConfigurationTestId == testConfiguration.Id)
                                    .AsEnumerable()
                                    .Select(ta => new QuestionViewModel() {

                                        Id = ta.Id,
                                        Question = ta.Test.Question,
                                        QuestionType = ta.Test.QuestionTypeId,
                                        Answers = ta.Test.Answers.ToList().Select(a => new KeyValuePair<int, string>(a.Id, a.Description))

                                    })
                                    .First();

            return View("Question", primeraPregunta);

        }

        // POST: Tests/Siguiente/{AnswerId}/{AnswerText}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Siguiente(int AnswerId, string AnswerText) {
            
            // Se obtiene el nombre del usuaario
            var userName = User.Identity.Name;

            // Se cobtiene el la configuracion del Test del usuario
            var configTest = db.ConfigurationTest.First(c => c.Username.Equals(userName));

            // Se obtiene el registro de la pregunta que se ha respondido
            var testAnswer = db.TestAnswer.First(ta => ta.ConfigurationTestId == configTest.Id && ta.IsAnswered == false);

            // Se actualizan los campos
            testAnswer.AnwserIdSelected = AnswerId;
            testAnswer.IsAnswered = true;
            testAnswer.TextAnswer = AnswerText;

            // Se guardan los cambios en la BD
            db.Entry(testAnswer).State = EntityState.Modified;
            db.SaveChanges();

            // Se obtiene la siguiente pregunta
            var siguientePregunta = db.TestAnswer
                                    .Include(ta => ta.Test)
                                    .Where(ta => ta.ConfigurationTestId == configTest.Id && ta.IsAnswered == false)
                                    .AsEnumerable()
                                    .Select(ta => new QuestionViewModel() {

                                        Id = ta.Id,
                                        Question = ta.Test.Question,
                                        QuestionType = ta.Test.QuestionTypeId,
                                        Answers = ta.Test.Answers.ToList().Select(a => new KeyValuePair<int, string>(a.Id, a.Description))

                                    })
                                    .First();

            ModelState.Clear();

            return View("Question", siguientePregunta);

        }

        // GET: Tests/Details/5
        public ActionResult Details(int? id) {

            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Test test = db.Test.Find(id);

            if (test == null) {
                return HttpNotFound();
            }

            return View(test);

        }

        // GET: Tests/Create
        public ActionResult Create() {

            ViewBag.DificultId = new SelectList(db.Dificulty, "Id", "Name");

            ViewBag.QuestionTypeId = new SelectList(db.QuestionType, "Id", "Description");

            return View();

        }

        // POST: Tests/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Question,DificultId,QuestionTypeId")] Test test) {

            if (ModelState.IsValid) {

                db.Test.Add(test);

                db.SaveChanges();

                return RedirectToAction("Index");

            }

            ViewBag.DificultId = new SelectList(db.Dificulty, "Id", "Name", test.DificultId);

            ViewBag.QuestionTypeId = new SelectList(db.QuestionType, "Id", "Description", test.QuestionTypeId);

            return View(test);

        }

        // GET: Tests/Edit/5
        public ActionResult Edit(int? id) {

            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Test test = db.Test.Find(id);

            if (test == null) {
                return HttpNotFound();
            }

            ViewBag.DificultId = new SelectList(db.Dificulty, "Id", "Name", test.DificultId);

            ViewBag.QuestionTypeId = new SelectList(db.QuestionType, "Id", "Description", test.QuestionTypeId);

            return View(test);

        }

        // POST: Tests/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Question,DificultId,QuestionTypeId")] Test test) {

            if (ModelState.IsValid) {

                db.Entry(test).State = EntityState.Modified;

                db.SaveChanges();

                return RedirectToAction("Index");

            }

            ViewBag.DificultId = new SelectList(db.Dificulty, "Id", "Name", test.DificultId);

            ViewBag.QuestionTypeId = new SelectList(db.QuestionType, "Id", "Description", test.QuestionTypeId);

            return View(test);

        }

        // GET: Tests/Delete/5
        public ActionResult Delete(int? id) {

            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Test test = db.Test.Find(id);

            if (test == null) {
                return HttpNotFound();
            }

            return View(test);

        }

        // POST: Tests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id) {

            Test test = db.Test.Find(id);

            db.Test.Remove(test);

            db.SaveChanges();

            return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing) {

            if (disposing) {
                db.Dispose();
            }

            base.Dispose(disposing);

        }

    }

}
