﻿using System;
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
            using (DB_connection db = new DB_connection())
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
                    newBook.AuthorId = rowInDatabase.AuthorId;
                    ListBooks.Add(newBook);
                }
            }
            return ListBooks.ToArray();
        }

        public string AddBook(string name, string description, string url, short visability, int author)
        {
            string message = "";
            using (DB_connection db = new DB_connection())
            {
                try
                {
                    Book newBook = new Book();
                   
                    newBook.Name = name;
                    newBook.Description = description;
                    newBook.URL = url;
                    newBook.Visability = visability;
                    newBook.AuthorId = author;
                    db.Book.Add(newBook);
                    db.SaveChanges();
                    message = "Book added successfully.";
                    
                }
                catch (Exception)
                {
                    message = "Could not add book.";
                    
                }
                return message;
            }
        }

        public string EditBook(int id, string name, string description, string url, short visability, int author)
        {
            string message = "";
            using (DB_connection db = new DB_connection())
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
                            rowInDatabase.AuthorId = author;
                            db.SaveChanges();
                            message = "Book edited successfully.";
                        }
                        catch (Exception)
                        {
                            message = "Could not edit book.";
                            throw;
                        }
                        break;
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
            using (DB_connection db = new DB_connection())
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
                        break;
                    }
                    else
                    {
                        message = "That book does not exist.";
                    }
                }
                return message;
            }
        }

        public Author[] GetAuthor()
        {
            List<Author> ListAuthor = new List<Author>();
            using (DB_connection db = new DB_connection())
            {
                var dbAuthorList = db.Author.ToList();
                foreach (var rowInDatabase in dbAuthorList)
                {
                    Author newAuthor = new Author();
                    newAuthor.Id = rowInDatabase.Id;
                    newAuthor.Name = rowInDatabase.Name;
                    ListAuthor.Add(newAuthor);
                }
            }
            return ListAuthor.ToArray();
        }

        public string AddAuthor(string name)
        {
            string message = "";
            using (DB_connection db = new DB_connection())
            {
                try
                {
                    Author newAuthor = new Author();
                    newAuthor.Name = name;
                    db.Author.Add(newAuthor);
                    db.SaveChanges();
                    message = "Author added successfully.";
                }
                catch (Exception)
                {
                    message = "Could not add author.";

                }
                return message;
            }
        }

        public string EditAuthor(int id, string name)
        {
            string message = "";
            using (DB_connection db = new DB_connection())
            {
                var dbAuthorList = db.Author.ToList();
                foreach (var rowInDatabase in dbAuthorList)
                {
                    if (rowInDatabase.Id == id)
                    {
                        try
                        {
                            rowInDatabase.Name = name;
                            db.SaveChanges();
                            message = "Author edited successfully.";
                        }
                        catch (Exception)
                        {
                            message = "Could not edit author.";
                            
                        }
                        break;
                    }
                    else
                    {
                        message = "That author does not exist.";
                    }
                }
                return message;
            }
        }

        public string DeleteAuthor(int id)
        {
            string message = "";
            using (DB_connection db = new DB_connection())
            {
                var dbAuthorList = db.Author.ToList();
                foreach (var rowInDatabase in dbAuthorList)
                {
                    if (rowInDatabase.Id == id)
                    {
                        try
                        {
                            db.Author.Remove(rowInDatabase);
                            db.SaveChanges();
                            message = "Author deleted successfully.";
                        }
                        catch (Exception)
                        {
                            message = "Could not delete author.";
                            throw;
                        }
                        break;
                    }
                    else
                    {
                        message = "That author does not exist.";
                    }
                }
                return message;
            }
        }
    }
}
