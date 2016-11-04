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
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Books()
        {
            ServiceReference.Service1Client Client = new ServiceReference.Service1Client();
            List<WcfService.Book> Books = Client.GetBooks().ToList();
            
            return View(Books);

        }

        public ActionResult Test()
        {
            ServiceReference.Service1Client Client = new ServiceReference.Service1Client();
            MasterViewModel mymodel = new MasterViewModel();
            mymodel.allAuthors = Client.GetAuthor();
            mymodel.allBooks = Client.GetBooks();
            return View(mymodel);
        }
    }
}