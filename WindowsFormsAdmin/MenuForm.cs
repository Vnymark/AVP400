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

        //Description - Menu
        //Every menu option needed different designs( different number of buttons etc.)
        //Because of that there is alot of different forms, instead of instances of the same one.
        private void button1_Click(object sender, EventArgs e)
        {
            ViewPublicBooks myForm = new ViewPublicBooks();
            myForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddAuthor myForm = new AddAuthor();
            myForm.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            EditAuthor myForm = new EditAuthor();
            myForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DeleteAuthor myForm = new DeleteAuthor();
            myForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddBook myForm = new AddBook();
            myForm.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            EditBook myForm = new EditBook();
            myForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DeleteBook myForm = new DeleteBook();
            myForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ViewAuthor myForm = new ViewAuthor();
            myForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ViewBooks myForm = new ViewBooks();
            myForm.Show();
        }
    }
}
