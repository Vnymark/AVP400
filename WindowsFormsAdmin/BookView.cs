using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAdmin
{
    public partial class BookView : Form
    {
        public BookView()
        {
            InitializeComponent();
            ServiceReference.Service1Client Client = new ServiceReference.Service1Client();
            List<ServiceReference.Book> Books = Client.GetBooks().ToList();
            dataGridView1.DataSource = Books;
            
        }

        private void bookBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            
        }
        
    }
}
