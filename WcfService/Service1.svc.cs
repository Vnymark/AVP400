using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string AddBook(string name, string description, string url, short visability)
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                Book newBook = new Book();
                newBook.Name = name;
                newBook.Description = description;
                newBook.URL = url;
                newBook.Visability = visability;
                db.Book.Add(newBook);
                db.SaveChanges();
                string message = "Successfully added a book.";
                return message;
            }
        }
    }
}
