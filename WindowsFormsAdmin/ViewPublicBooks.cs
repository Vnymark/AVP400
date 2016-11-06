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
    public partial class ViewPublicBooks : Form
    {
        public ViewPublicBooks()
        {
            InitializeComponent();
            ServiceReference.Service1Client Client = new ServiceReference.Service1Client();
            List<ServiceReference.BookAuthor> Books = Client.GetBookAuthor().ToList();
            dataGridView1.DataSource = Books;
            
        }

        private void bookBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            
        }
        
    }
}
