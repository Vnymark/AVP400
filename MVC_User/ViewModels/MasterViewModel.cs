
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
        public IEnumerable<BookAuthor> BookAuthor { get; set; }
    }
}
