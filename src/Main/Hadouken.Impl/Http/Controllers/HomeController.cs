﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Hadouken.Http;

namespace Hadouken.Impl.Http.Handlers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("/")]
        public ActionResult Index()
        {
            return View("index.html");
        }
    }
}
