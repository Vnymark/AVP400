using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfService
{
    using System;
    using System.Collections.Generic;

    public partial class BookAuthor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public Nullable<short> Visability { get; set; }
        public string AuthorName { get; set; }
        
    }
}
