using System;
using System.Collections.Generic;
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
            return View();
        }

        public ActionResult Books()
        {
            ServiceReference.Service1Client Client = new ServiceReference.Service1Client();
            List<ServiceReference.Book> Books = Client.GetBooks().ToList();
            return View(Books);
        }
    }
}