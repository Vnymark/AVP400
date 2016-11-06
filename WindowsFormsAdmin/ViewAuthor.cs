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
    public partial class ViewAuthor : Form
    {
        public ViewAuthor()
        {
            InitializeComponent();
            ServiceReference.Service1Client Client = new ServiceReference.Service1Client();
            List<ServiceReference.Author> Authors = Client.GetAuthor().ToList();
            dataGridView1.DataSource = Authors;
        }

        private void AuthorBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
