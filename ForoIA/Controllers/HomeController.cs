using ForoIA.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using ForoIA.ViewModel.Home;

namespace ForoIA.Controllers {

    public class HomeController : Controller {

        private ForoDbContext db = new ForoDbContext();

        public ActionResult Index() {

            var viewModel = db.Category
                              .Include(c => c.Posts)
                              .GroupBy(c => c.Id)
                              .SelectMany(c => c)
                              .Select(c => new IndexViewModel { Category = c.Name, CategoryId = c.Id, TotalPosts = c.Posts.Count})
                              .ToList();

            var categorieIds = db.Category
                                .Select(c => c.Id)
                                .ToList();

            //var posts = db.Post
            //              .OrderByDescending(p => p.Date)
            //              .Where(p => categorieIds.Contains(p.CategoryId));

            //List<Post> latest = new List<Post>();

            //foreach (var id in categorieIds) {
            //    latest.Add(posts.FirstOrDefault(p => p.CategoryId == id));
            //}

            //viewModel = viewModel.Join(latest, vm => vm.CategoryId, j => j == null ? 0 : j.CategoryId, (vm, j) => new IndexViewModel { Category = vm.Category, CategoryId = vm.CategoryId, TotalPosts = vm.TotalPosts, Date = j == null ? DateTime.MinValue : j.Date,  UserName = j == null ? null : j.UserName, PostId = j == null ? 0 : j.Id }).ToList();

            return View(viewModel);

        }

        protected override void Dispose(bool disposing) {

            if (disposing) {
                db.Dispose();
            }

            base.Dispose(disposing);

        }

    }

}