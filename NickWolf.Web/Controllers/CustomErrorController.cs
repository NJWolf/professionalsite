﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomErrorsDemo.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error/NotFound
        public ActionResult NotFound()
        {
            Response.StatusCode = 404;
            return View();
        }

        // GET: Error/Error
        public ActionResult Error()
        {
            Response.StatusCode = 500;
            return View();
        }
    }
}