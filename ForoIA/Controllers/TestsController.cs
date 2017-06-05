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
using System.Diagnostics;
using System.Text;

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

            // Se valida si el usuario ya cuenta con un examen en progreso
            var configTest = db.ConfigurationTest.FirstOrDefault(c => c.Username.Equals(User.Identity.Name));

            // Si no es null, ya hay examen
            if (configTest != null) {

                // Se obtiene la pregunta
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
                                        .FirstOrDefault();

                // Si no es null, aún hay preguntas por responder
                if (siguientePregunta != null) {

                    return View("Question", siguientePregunta);

                }

                return RedirectToAction("PruebaFinalizada");

            }

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
                                    .FirstOrDefault();

            ModelState.Clear();

            // Aun hay preguntas por responder
            if (siguientePregunta != null) {

                return View("Question", siguientePregunta);

            }

            return RedirectToAction("PruebaFinalizada");

        }

        public ActionResult PruebaFinalizada() {

            var userName = User.Identity.Name;

            // Se obtiene la configuración y las respuestas del test
            var configTest = db.ConfigurationTest
                               .Include(c => c.TestAnswer)
                               .FirstOrDefault(c => c.Username.Equals(userName));

            // Se obtienen los Id's de las respuestas cerradas constestadas
            var answersIdSelected = configTest.TestAnswer
                                              .Select(ta => ta.AnwserIdSelected)
                                              .ToList();

            // Se obtienen las respuestas
            var answers = db.Answer
                            .Where(a => answersIdSelected.Contains(a.Id))
                            .ToList();

            // Se cuentan las respuestas correctas
            var correctas = answers.Count(a => a.IsCorrect == true);

            // Se obtienen los Id's de las preguntas abiertas contestadas
            var openQuestions = configTest.TestAnswer
                                          .Where(ta => !string.IsNullOrEmpty(ta.TextAnswer) && ta.AnwserIdSelected == 0)
                                          .Select(ta => ta.TestId)
                                          .ToList();

            // Se itera si hay preguntas abiertas
            foreach (var questionId in openQuestions) {

                // Se obtiene la respuesta de la BD
                var answer = db.Answer
                               .Where(a => a.QuestionId == questionId)
                               .FirstOrDefault();

                // Se obtiene el texto respondido
                var answered = configTest.TestAnswer
                                     .FirstOrDefault(ta => ta.TestId == questionId);

                // Se hace la comparativa del texto
                var text1 = new StringBuilder(answer.Description.ToLower());
                var text2 = new StringBuilder(answered.TextAnswer.ToLower());

                text1.Replace(" la ", " ");
                text1.Replace(" las ", " ");
                text1.Replace(" el ", " ");
                text1.Replace(" ellos ", " ");
                text1.Replace(" los ", " ");
                text1.Replace(" por ", " ");
                text1.Replace(" es ", " ");
                text1.Replace(" a ", " ");
                text1.Replace(" de ", " ");
                text1.Replace(" y ", " ");
                text1.Replace(" que ", " ");
                text1.Replace(" o ", " ");
                text1.Replace(" si ", " ");
                text1.Replace(" sus ", " ");
                text1.Replace(";", " ");
                text1.Replace(".", " ");
                text1.Replace(",", " ");

                text2.Replace(" la ", " ");
                text2.Replace(" las ", " ");
                text2.Replace(" el ", " ");
                text2.Replace(" ellos ", " ");
                text2.Replace(" los ", " ");
                text2.Replace(" por ", " ");
                text2.Replace(" es ", " ");
                text2.Replace(" a ", " ");
                text2.Replace(" de ", " ");
                text2.Replace(" y ", " ");
                text2.Replace(" que ", " ");
                text2.Replace(" o ", " ");
                text2.Replace(" si ", " ");
                text2.Replace(" sus ", " ");
                text2.Replace(";", " ");
                text2.Replace(".", " ");
                text2.Replace(",", " ");

                var answerText = text1.ToString();
                var words = answerText.Split(' ').Where(t => !string.IsNullOrWhiteSpace(t)).ToList();

                var newText = text2.ToString().Split(' ').Where(t => !string.IsNullOrWhiteSpace(t)).ToList();

                int coincidencias = 0;

                foreach (var word in newText) {

                    if (answerText.Contains(word)) {

                        coincidencias++;

                        answerText = answerText.Replace(word, " ");

                    }

                }

                if ((double)(coincidencias * 100) / words.Count() >= 50) {

                    correctas++;

                }

            }

            ViewBag.Calificacion = String.Format("{0:0.0}", ((double)correctas / configTest.TestAnswer.Count) * 10.0);

            return View();

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
