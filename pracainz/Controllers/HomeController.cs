﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pracainz.Models;

namespace pracainz.Controllers
{
    public class HomeController : Controller
    {
        private ERP_DB ctx;

        public HomeController()
        {
            ctx = new ERP_DB();
        }

        protected override void Dispose(bool disposing)
        {
            ctx.Dispose();
        }

        public ViewResult Index()
        {
            var zlecenie = GetZlecenie();
            return View(zlecenie);
        }

        public ViewResult Login() => View();
        public ViewResult BigInput() => View();
        public ViewResult Magazyn() => View();

        private Zlecenie GetZlecenie() => ctx.Zlecenie.FirstOrDefault(z => z.ID == 1);
    }
}