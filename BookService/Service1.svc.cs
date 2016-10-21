using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BookService
{
    
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IBook
    {
        
        public void DeleteBook()
        {
            throw new NotImplementedException();
        }

        public void EditBook()
        {
            throw new NotImplementedException();
        }

        public string AddBook(string name, string url, string description, short visability)
        {
            List<Books> returnBooks = new List<Books>();
            using (Model db = new Model())
            {
                var dbBookList = db.Books.ToList();
                { foreach (var rowInDatabase in dbBookList)
                    {
                        Books newBook = 
                    }
            }
            
                var DB = from Books in Model.
            string message = "";
            Books Book1 = new Books(name, url, description, visability);
            return message;
            
        }
    }
}
