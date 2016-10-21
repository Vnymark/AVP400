
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using System.Text;

namespace BookService
{

    [ServiceContract]
    public interface IBook
    {

        [OperationContract]
        string AddBook(string name, string url, string description, short visability);

        [OperationContract]
        void EditBook();

        [OperationContract]
        void DeleteBook();



        // TODO: Add your service operations here
    }
    [DataContract]
    public partial class Books
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string URL { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public short Visability { get; set; }

        public Books(string name, string url, string description, short visability)
        {
            Name = name;
            URL = url;
            Description = description;
            Visability = visability;
        }
    }
}

    
