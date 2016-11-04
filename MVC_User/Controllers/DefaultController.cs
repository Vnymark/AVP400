﻿using MVC_User.ServiceReference;
using MVC_User.ViewModels;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVC_User.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            ServiceReference.Service1Client Client = new ServiceReference.Service1Client();
            MasterViewModel mymodel = new MasterViewModel();
            mymodel.BookAuthor = Client.GetBookAuthor();
            return View(mymodel);
        }
        public ActionResult Books()
        {
            ServiceReference.Service1Client Client = new ServiceReference.Service1Client();
            MasterViewModel mymodel = new MasterViewModel();
            mymodel.BookAuthor = Client.GetBookAuthor();
            return View(mymodel);
        }
    }
}