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

    public class PostsController : Controller {

        private ForoDbContext db = new ForoDbContext();

        // GET: Posts
        public ActionResult Index() {

            var post = db.Post
                         .Include(p => p.Category)
                         .OrderByDescending(p => p.Date);

            return View(post.ToList());

        }

        // GET: Posts/Details/5
        public ActionResult Details(int? id) {

            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Post post = db.Post.Find(id);
            db.Entry(post).Collection(p => p.Commments).Load();

            if (post == null) {
                return HttpNotFound();
            }

            if (TempData["ModelState"] != null && !ModelState.Equals(TempData["ModelState"]))
                ModelState.Merge((ModelStateDictionary)TempData["ModelState"]);

            return View(post);

        }

        // GET: Post/Category/id
        public ActionResult Category(int id) {

            Category category = db.Category.Find(id);

            if (category == null) {
                return HttpNotFound();
            }

            var posts = db.Post
                          .Include(p => p.Category)
                          .Where(p => p.CategoryId == id)
                          .Take(5)
                          .ToList();

            return View("Index", posts);

        }

        // GET: Posts/User/userName
        public ActionResult UserPosts(string userName) {

            if (string.IsNullOrWhiteSpace(userName)) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var viewModel = db.Post
                              .Where(p => p.UserName.Equals(userName))
                              .ToList();

            return View("Index", viewModel);

        }

        // It could be <<User>> not <<PartialUserPosts>>
        // GET: Posts/User/
        [Authorize]
        [ChildActionOnly]
        public PartialViewResult PartialUserPosts() {

            var userName = User.Identity.Name;

            var viewModel = db.Post
                              .Where(p => p.UserName.Equals(userName))
                              .ToList();

            return PartialView("_UserPosts", viewModel);

        }

        // GET: Posts/Create
        public ActionResult Create() {

            ViewBag.CategoryId = new SelectList(db.Category, "Id", "Name");

            return View();

        }

        // POST: Posts/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Title,UserName,Date,CategoryId,Review,Content")] Post post) {

            if (ModelState.IsValid) {

                db.Post.Add(post);

                db.SaveChanges();

                return RedirectToAction("Index");

            }

            ViewBag.CategoryId = new SelectList(db.Category, "Id", "Name", post.CategoryId);

            return View(post);

        }

        // GET: Posts/Edit/5
        public ActionResult Edit(int? id) {

            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Post post = db.Post.Find(id);

            if (post == null) {
                return HttpNotFound();
            }

            ViewBag.CategoryId = new SelectList(db.Category, "Id", "Name", post.CategoryId);

            return View(post);

        }

        // POST: Posts/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,UserName,Date,CategoryId,Review,Content")] Post post) {

            if (ModelState.IsValid) {

                db.Entry(post).State = EntityState.Modified;

                db.SaveChanges();

                return RedirectToAction("Index");

            }

            ViewBag.CategoryId = new SelectList(db.Category, "Id", "Name", post.CategoryId);

            return View(post);

        }

        // GET: Posts/Delete/5
        public ActionResult Delete(int? id) {

            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Post post = db.Post.Find(id);

            if (post == null) {
                return HttpNotFound();
            }

            return View(post);

        }

        // POST: Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id) {

            Post post = db.Post.Find(id);
            //db.Entry(post).Collection(p => p.Commments).Load();

            //db.Comment.RemoveRange(post.Commments);
            db.Post.Remove(post);

            db.SaveChanges();

            return RedirectToAction("Index");

        }

        // POST: Posts/Search/param
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Search(string param) {

            var viewModel = db.Post
                              .Where(p =>
                                          p.Title.Contains(param) ||
                                          p.Review.Contains(param) ||
                                          p.Content.Contains(param) ||
                                          p.UserName.Contains(param)
                                          );


            return View("Index", viewModel);

        }

        protected override void Dispose(bool disposing) {

            if (disposing) {
                db.Dispose();
            }

            base.Dispose(disposing);

        }

    }

}
