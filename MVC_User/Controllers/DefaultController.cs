using MVC_User.ServiceReference;
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
        public ActionResult Books()
        {
            ServiceReference.Service1Client Client = new ServiceReference.Service1Client();
            MasterViewModel mymodel = new MasterViewModel();
            mymodel.PublicBook = Client.GetPublicBooks();
            return View(mymodel);
        }
    }
}