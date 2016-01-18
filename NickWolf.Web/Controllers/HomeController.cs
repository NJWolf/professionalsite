using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NickWolf.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        //GET: Pdf
        public FileResult DisplayPDF()
        {
            return File("~/Content/files/resume.pdf", "application/pdf");
        }
    }
}