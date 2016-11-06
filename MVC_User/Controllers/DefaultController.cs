using MVC_User.ViewModels;
using System.Web.Mvc;


namespace MVC_User.Controllers
{
    public class DefaultController : Controller
    {
        //Description - MVC
        //A Viewmodel is created and the array of PublicBooks are added to that.
        //The model is then sent to the view.
        //If the need for more data is needed in the future, the code is made to work with several arrays sent to the view.
        //In an earlier version two kind of arrays were used, but later the data needed got filtered in the service instead.
        //Inspiration from: http://www.c-sharpcorner.com/UploadFile/ff2f08/multiple-models-in-single-view-in-mvc/
        public ActionResult Books()
        {
            ServiceReference.Service1Client Client = new ServiceReference.Service1Client();
            MasterViewModel mymodel = new MasterViewModel();
            mymodel.PublicBook = Client.GetPublicBooks();
            return View(mymodel);
        }
    }
}