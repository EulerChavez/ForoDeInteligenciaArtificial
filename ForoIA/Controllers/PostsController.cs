using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ForoIA.Models.Db;
using ForoIA.ViewModel.Post;

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
                              .Select(p => new UserPostsViewModel() {

                                  Id = p.Id,
                                  Title = p.Title,
                                  Category = p.Category.Name,
                                  Date = p.Date

                              })
                              .ToList();

            return PartialView("_UserPosts", viewModel);

        }

        // GET: Posts/Create
        public ActionResult Create() {

            ViewBag.CategoryId = new SelectList(db.Category, "Id", "Name");

            return View();

        }

        // POST: Posts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Title,CategoryId,Review,Content")] CreatePostViewModel viewModel) {

            if (ModelState.IsValid) {

                var post = new Post() {

                    Title = viewModel.Title,
                    CategoryId = viewModel.CategoryId,
                    Review = viewModel.Review,
                    Content = viewModel.Content,
                    UserName = User.Identity.Name,
                    Date = DateTime.Now,

                };

                db.Post.Add(post);

                db.SaveChanges();

                return RedirectToAction("Index");

            }

            ViewBag.CategoryId = new SelectList(db.Category, "Id", "Name", viewModel.CategoryId);

            return View(viewModel);

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

            var viewModel = new EditPostViewModel() {

                Id = post.Id,
                Title = post.Title,
                Review = post.Review,
                CategoryId = post.CategoryId,
                Content = post.Content

            };

            ViewBag.CategoryId = new SelectList(db.Category, "Id", "Name", viewModel.CategoryId);

            return View(viewModel);

        }

        // POST: Posts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Title,CategoryId,Review,Content")] EditPostViewModel viewModel) {

            if (ModelState.IsValid) {

                var post = db.Post.Find(viewModel.Id);

                post.Title = viewModel.Title;
                post.CategoryId = viewModel.CategoryId;
                post.Review = viewModel.Review;
                post.Content = viewModel.Content;

                db.Entry(post).State = EntityState.Modified;

                db.SaveChanges();

                return RedirectToAction("Index");

            }

            ViewBag.CategoryId = new SelectList(db.Category, "Id", "Name", viewModel.CategoryId);

            return View(viewModel);

        }

        // GET: Posts/Delete/5
        public ActionResult Delete(int? id) {

            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var viewModel = db.Post
                              .Where(p => p.UserName.Equals(User.Identity.Name) && p.Id == id)
                              .Select(p => new UserPostsViewModel() {

                                  Id = p.Id,
                                  Title = p.Title,
                                  Category = p.Category.Name,
                                  Date = p.Date

                              })
                              .FirstOrDefault();

            if (viewModel == null) {
                return HttpNotFound();
            }

            return View(viewModel);

        }

        // POST: Posts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id) {

            Post post = db.Post.Find(id);

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
