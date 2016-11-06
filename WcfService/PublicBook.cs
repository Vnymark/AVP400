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

    public partial class PublicBook
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //For making the link clickable in the MVC view.
        //Inspiration from: http://www.codeproject.com/Articles/781804/ASP-Net-MVC-Hyperlinks-Open-the-page-in-a-new-brow
        [DataType(DataType.Url)] 
        public string URL { get; set; }
        public string AuthorName { get; set; }
    }
}
