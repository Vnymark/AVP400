using System;
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
        //Description - GetBooks
        //Creates a list of all books in the database and adds them to an array.
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
                    newBook.Visibility = rowInDatabase.Visibility;
                    newBook.AuthorId = rowInDatabase.AuthorId;
                    ListBooks.Add(newBook);
                }
            }
            return ListBooks.ToArray();
        }

        //Description - AddBook
        //Creates a list of all bookss in the database and checks if there already is a book with the same name.
        //If not it creates a new book and saves the changes to the database.
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
                            message = "That book already exists";
                            break;
                        }
                    }
                    if (message != "That book already exists")
                    {
                        Book newBook = new Book();
                        newBook.Name = name;
                        newBook.Description = description;
                        newBook.URL = url;
                        newBook.Visibility = visability;
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
                Logging.log(message);
                return message;
            }
        }

        //Description - EditBook
        //Creates a list of all books in the database and checks for a match compared to the id.
        //Then it changes the fields to the new information and saves the changes.
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
                            rowInDatabase.Visibility = visability;
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
                Logging.log(message);
                return message;
            }
        }

        //Description - DeleteBook
        //Creates a list of all books in the database and checks for a match compared to the id.
        //Then it deletes the row in the database and saves the changes.
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
                        }
                        break;
                    }
                    else
                    {
                        message = "That book does not exist.";
                    }
                }
                Logging.log(message);
                return message;
            }
        }
        //Description - GetAuthor
        //Creates a list of all authors in the database and adds them to an array.
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

        //Description - AddAuthor
        //Creates a list of all authors in the database and checks if there already is an author with the same name.
        //If not it creates a new author and saves the changes to the database.
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
            Logging.log(message);
            return message;
        }

        //Description - EditAuthor
        //Creates a list of all authors in the database and checks for a match compared to the id.
        //Then it changes the fields to the new information and saves the changes.
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
                Logging.log(message);
                return message;
            }
        }

        //Description - DeleteAuthor
        //Creates a list of all authors in the database and checks for a match compared to the id.
        //Then it deletes the row in the database and saves the changes.
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
                Logging.log(message);
                return message;
            }
        }
        //GetPublicBooks - Description
        //Used to create a list of books with visability set to 1.
        //It also sets the name of the author instead of the authorId, with the help of GetAuthorName().
        //This list is published to the user through MVC and also for the admin in WinForms.
        public PublicBook[] GetPublicBooks()
        {
            List<PublicBook> ListBooks = new List<PublicBook>();
            using (DB_connection db = new DB_connection())
            {
                var dbBookList = db.Book.ToList();
                foreach (var rowInDatabase in dbBookList)
                {
                    if(rowInDatabase.Visibility == 1)
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

        //GetAuthorName - Description
        //Used when creating the list of PublicBooks, to match "Book.AuthorId" with the "Author.Name".
        public string GetAuthorName(int? id) 
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

        //ImportFile() - Description
        //The file is pure txt with names of authors seperated by ",".
        //At import, the file is read and authors are created and saved to the database.
        //The AddAuthor filters out if it already exists an author with the same name in the database, so the file doesn't need to be "cleaned".
        //Inspiration from: http://stackoverflow.com/questions/39628974/how-to-import-text-file-and-save-data-into-database
        public void ImportFile()
        {
            string readText = File.ReadAllText(@"C:\import.txt");
            List<string> txtList = new List<string>();
            txtList = readText.Split(new string[] { Environment.NewLine }, StringSplitOptions.None).ToList();
            string[] authors = txtList.SelectMany(s => s.Split(',')).ToArray();
            foreach (string i in authors)
            {
                AddAuthor(i);
            }
        }

        //Timer - Description
        //A timer is created when the service is started and runs for 60 seconds.
        //After 60 seconds it calls the ImportFile() and creates a new timer.
        //Inspiration from: http://stackoverflow.com/questions/4614358/wcf-service-application-timer
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
