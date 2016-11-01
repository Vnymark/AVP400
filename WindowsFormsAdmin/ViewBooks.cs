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
    public partial class ViewBooks : Form
    {
        
        public ViewBooks()
        {
            InitializeComponent();
            ServiceReference.Service1Client Client = new ServiceReference.Service1Client();
            List<ServiceReference.Book> Books = Client.GetBooks().ToList();
            listBox1.DataSource = Books;
            //listBox1.ValueMember = "Id";
            listBox1.DisplayMember = "Name";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddBook myForm = new AddBook();
            myForm.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //iBookId = listBox1.SelectedIndex; Future functions, if wanted.
            EditBook myForm = new EditBook();
            myForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
