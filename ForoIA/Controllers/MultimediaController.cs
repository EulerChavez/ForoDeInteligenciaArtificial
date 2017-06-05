using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ForoIA.Controllers {

    public class MultimediaController : Controller {

        public ActionResult Index() {

            List<string> urls = new List<string>() {

                "https://www.youtube.com/embed/3IjP29wNAfE",
                "https://www.youtube.com/embed/eoIQmWd8LTQ",
                "https://www.youtube.com/embed/gCuPx9shWT0",
                "https://www.youtube.com/embed/cUeScCtTng4",
                "https://www.youtube.com/embed/qv6UVOQ0F44"

            };


            return View(urls);

        }

        public ActionResult Chapter(string fileName) {

            var fileStream = new FileStream(Server.MapPath(@"~/Files/" + fileName), FileMode.Open, FileAccess.Read);

            var fsResult = new FileStreamResult(fileStream, "application/pdf");

            return fsResult;

        }

    }

}