
using WcfService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_User.ViewModels
{
    public class MasterViewModel
    {
        public IEnumerable<Author> allAuthors { get; set; }
        public IEnumerable<Book> allBooks { get; set; }

        public IEnumerable<BookAuthor> BookAuthor { get; set; }
    }
}
