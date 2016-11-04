using System;
using WcfService;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_User.Models
{
    class BookClass
    {
        public partial class Book
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string URL { get; set; }
            public Nullable<short> Visability { get; set; }
            public Nullable<int> AuthorId { get; set; }
        }
    }
}
