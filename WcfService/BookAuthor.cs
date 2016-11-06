using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfService
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class BookAuthor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Url)] //For making the link clickable in the MVC view.
        public string URL { get; set; }
        public string AuthorName { get; set; }
    }
}
