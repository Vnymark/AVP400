using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        Book[] GetBooks();

        [OperationContract]
        string AddBook(string name, string description, string url, short visability, int author);

        [OperationContract]
        string EditBook(int id, string name, string description, string url, short visability, int author);

        [OperationContract]
        string DeleteBook(int id);

        [OperationContract]
        Author[] GetAuthor();

        [OperationContract]
        string AddAuthor(string name);

        [OperationContract]
        string EditAuthor(int id, string name);

        [OperationContract]
        string DeleteAuthor(int id);

        [OperationContract]
        PublicBook[] GetBookAuthor();

        [OperationContract]
        string GetAuthorName(int? id);

        [OperationContract]
        void ImportFile();
        
    }
}
