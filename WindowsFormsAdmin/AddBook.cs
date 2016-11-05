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
    public partial class AddBook : Form
    {
        int iAuthor;
        short iText4;
        string sMessage;
        public AddBook()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                iText4 = short.Parse(textBox4.Text);
            }
            catch (Exception)
            {
                sMessage = "Couldn't parse the visibility successfully.";
            }
            try
            {
                iAuthor = int.Parse(textBox5.Text);
            }
            catch (Exception)
            {
                sMessage = "Couldn't parse the author successfully.";
            }
            ServiceReference.Service1Client Client = new ServiceReference.Service1Client();
            sMessage = Client.AddBook(textBox1.Text, textBox2.Text, textBox3.Text, iText4, iAuthor);
            MessageBox.Show(sMessage);
        }
    }
}
