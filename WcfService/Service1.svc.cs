﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Timers;

namespace WcfService
{
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
                    var dbBookList = db.Book.ToList();
                    foreach (var rowInDatabase in dbBookList)
                    {
                        if (rowInDatabase.Name == name)
                        {
                            message = "That name already exists";
                            break;
                        }
                    }
                    if (message != "That name already exists")
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
                    if (rowInDatabase.Id == id)
                    {
                        try
                        {
                            rowInDatabase.Name = name;
                            rowInDatabase.Description = description;
                            rowInDatabase.URL = url;
                            rowInDatabase.Visability = visability;
                            if (author == 0) {
                                rowInDatabase.AuthorId = null;
                            }
                            else {
                                rowInDatabase.AuthorId = author;
                            }
                            db.SaveChanges();
                            message = "Book edited successfully.";
                        }
                        catch (Exception)
                        {
                            message = "Could not edit book.";

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
                    var dbAuthorList = db.Author.ToList();
                    foreach (var rowInDatabase in dbAuthorList)
                    {
                        if (rowInDatabase.Name == name)
                        {
                            message = "Author already exists";
                            break;
                        }
                    }
                    if (message != "Author already exists")
                    {
                        Author newAuthor = new Author();
                        newAuthor.Name = name;
                        db.Author.Add(newAuthor);
                        db.SaveChanges();
                        message = "Author added successfully.";
                    }

                }
                catch (Exception)
                {
                    message = "Could not add author.";
                }
            }
            return message;
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

        public PublicBook[] GetPublicBooks()
        {
            List<PublicBook> ListBooks = new List<PublicBook>();
            using (DB_connection db = new DB_connection())
            {
                var dbBookList = db.Book.ToList();
                foreach (var rowInDatabase in dbBookList)
                {
                    if(rowInDatabase.Visability == 1)
                    { 
                        PublicBook newBook = new PublicBook();
                        newBook.Id = rowInDatabase.Id;
                        newBook.Name = rowInDatabase.Name;
                        newBook.Description = rowInDatabase.Description;
                        newBook.URL = rowInDatabase.URL;
                        newBook.AuthorName = GetAuthorName(rowInDatabase.AuthorId);
                        ListBooks.Add(newBook);
                    }
                }
            }
            return ListBooks.ToArray();
        }
        public string GetAuthorName(int? id) //Used when creating the list of PublicBooks.
        {
            string AuthorName = "";
            using (DB_connection db = new DB_connection())
            {
                var dbAuthorList = db.Author.ToList();
                foreach (var rowInDatabase in dbAuthorList)
                {
                    if (rowInDatabase.Id == id)
                    {
                        AuthorName = rowInDatabase.Name;
                    }
                }
            }
            return AuthorName;
        }

        public void ImportFile()
        {
            //The file is pure txt with names of authors seperated by ",".
            //At import, the file is read and authors are and saved to the database.
            //The AddAuthor filters out if there already exists an author with the same name, so the file doesn't need to be "cleaned".
            string readText = File.ReadAllText(@"C:\import.txt");
            List<string> txtList = new List<string>();
            txtList = readText.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).ToList();
            string[] authors = txtList.SelectMany(s => s.Split(',')).ToArray();
            foreach (string i in authors)
            {
                AddAuthor(i);
            }
        }

        private Timer timer;
        public Service1()
        {
            this.timer = new System.Timers.Timer(1000 * 60); //Runs every minute.
            this.timer.Elapsed += OnTimerElapsed;
            this.timer.Start();
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            ImportFile();
        }
    }
}
