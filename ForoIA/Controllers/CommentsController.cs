using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ForoIA.Models.Db;

namespace ForoIA.Controllers {

    public class CommentsController : Controller {

        private ForoDbContext db = new ForoDbContext();

        // GET: Comments
        public ActionResult Index() {

            var comment = db.Comment.Include(c => c.Post);

            return View(comment.ToList());

        }

        // GET: Comments/Details/5
        public ActionResult Details(int? id) {

            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Comment comment = db.Comment.Find(id);

            if (comment == null) {
                return HttpNotFound();
            }

            return View(comment);

        }

        // GET: Comments/PartialUserComments
        [Authorize]
        [ChildActionOnly]
        public PartialViewResult PartialUserPosts() {

            var userName = User.Identity.Name;

            var viewModel = db.Comment
                              .Include(c => c.Post)
                              .Where(p => p.UserName.Equals(userName))
                              .ToList();

            return PartialView("Index", viewModel);

        }

        // GET: Comments/Create
        public ActionResult Create() {

            ViewBag.PostId = new SelectList(db.Post, "Id", "Title");

            return View();

        }

        // POST: Comments/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,PostId,UserName,CommentTime,Content")] Comment comment) {

        //    if (ModelState.IsValid) {

        //        db.Comment.Add(comment);

        //        db.SaveChanges();

        //        return RedirectToAction("Index");

        //    }

        //    ViewBag.PostId = new SelectList(db.Post, "Id", "Title", comment.PostId);

        //    return View(comment);

        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(string content, int ID, string userName) {

            if (!User.Identity.IsAuthenticated) {

                ModelState.AddModelError("indentity", "Debes de inciar sesión para dejar tu comentario.");

                TempData["ModelState"] = ModelState;

            } else if (string.IsNullOrWhiteSpace(content)) {

                ModelState.AddModelError("content", "El campo de comentarios no debe estar vacio.");

                TempData["ModelState"] = ModelState;

            } else {

                db.Comment.Add(new Models.Db.Comment() {

                    PostId = ID,
                    CommentTime = DateTime.Now,
                    UserName = userName,
                    Content = content

                });

                db.SaveChanges();

            }

            return RedirectToAction("Details", "Posts", new { id = ID });

        }

        // GET: Comments/Edit/5
        public ActionResult Edit(int? id) {

            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Comment comment = db.Comment.Find(id);

            if (comment == null) {
                return HttpNotFound();
            }

            ViewBag.PostId = new SelectList(db.Post, "Id", "Title", comment.PostId);

            return View(comment);

        }

        // POST: Comments/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PostId,UserName,CommentTime,Content")] Comment comment) {

            if (ModelState.IsValid) {

                db.Entry(comment).State = EntityState.Modified;

                db.SaveChanges();

                return RedirectToAction("Index");

            }

            ViewBag.PostId = new SelectList(db.Post, "Id", "Title", comment.PostId);

            return View(comment);

        }

        // GET: Comments/Delete/5
        public ActionResult Delete(int? id) {

            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Comment comment = db.Comment.Find(id);

            if (comment == null) {
                return HttpNotFound();
            }

            return View(comment);

        }

        // POST: Comments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id) {

            Comment comment = db.Comment.Find(id);

            db.Comment.Remove(comment);

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
