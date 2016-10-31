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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookView myForm = new BookView();
            myForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddBook myForm = new AddBook();
            myForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditBook myForm = new EditBook();
            myForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteBook myForm = new DeleteBook();
            myForm.Show();
        }
    }
}
