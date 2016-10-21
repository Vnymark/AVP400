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
        
        
        public Book[] GetBooks()
        {
            List<Book> ListBooks = new List<Book>();
            using (DatabaseEntities db = new DatabaseEntities())
            {
                var dbBookList = db.Book.ToList();
                foreach (var rowInDatabase in dbBookList)
                {
                    Book newBook = new Book();
                    newBook.Id = rowInDatabase.Id;
                    newBook.Name = rowInDatabase.Name;
                    newBook.Description = rowInDatabase.Description;
                    newBook.URL = rowInDatabase.URL;
                    newBook.Visability = rowInDatabase.Visability;
                    ListBooks.Add(newBook);
                }
            }
            return ListBooks.ToArray();
        }

        public string AddBook(string name, string description, string url, short visability)
        {
            string message = "";
            using (DatabaseEntities db = new DatabaseEntities())
            {
                try
                {
                    Book newBook = new Book();
                    newBook.Name = name;
                    newBook.Description = description;
                    newBook.URL = url;
                    newBook.Visability = visability;
                    db.Book.Add(newBook);
                    db.SaveChanges();
                    message = "Book added successfully.";
                    
                }
                catch (Exception)
                {
                    message = "Could not add book.";
                    throw;
                }
                return message;
            }
        }

        public string EditBook(int id, string name, string description, string url, short visability)
        {
            string message = "";
            using (DatabaseEntities db = new DatabaseEntities())
            {
                var dbBookList = db.Book.ToList();
                foreach (var rowInDatabase in dbBookList)
                {
                    if(rowInDatabase.Id == id)
                    {
                        try
                        {
                            rowInDatabase.Name = name;
                            rowInDatabase.Description = description;
                            rowInDatabase.URL = url;
                            rowInDatabase.Visability = visability;
                            db.SaveChanges();
                            message = "Book edited successfully.";
                        }
                        catch (Exception)
                        {
                            message = "Could not edit book.";
                            throw;
                        }
                    }
                    else
                    {
                        message = "That book does not exist.";
                    }
                }
                return message;
            }
        }

        public string DeleteBook(int id)
        {
            string message = "";
            using (DatabaseEntities db = new DatabaseEntities())
            {
                var dbBookList = db.Book.ToList();
                foreach (var rowInDatabase in dbBookList)
                {
                    if (rowInDatabase.Id == id)
                    {
                        try
                        {
                            db.Book.Remove(rowInDatabase);
                            db.SaveChanges();
                            message = "Book deleted successfully.";
                        }
                        catch (Exception)
                        {
                            message = "Could not delete book.";
                            throw;
                        }
                    }
                    else
                    {
                        message = "That book does not exist.";
                    }
                }
                return message;
            }
        }
    }
}
