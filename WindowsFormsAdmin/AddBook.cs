using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfService;

namespace WindowsFormsAdmin
{
    public partial class AddBook : Form
    {
        int author;
        short text4;
        string message;
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
                text4 = short.Parse(textBox4.Text);
            }
            catch (Exception)
            {
                message = "Couldn't parse the visibility successfully.";
                Loggning.log(message);
            }
            try
            {
                author = int.Parse(textBox5.Text);
            }
            catch (Exception)
            {
                message = "Couldn't parse the author successfully.";
                Loggning.log(message);
            }
            ServiceReference.Service1Client Client = new ServiceReference.Service1Client();
            message = Client.AddBook(textBox1.Text, textBox2.Text, textBox3.Text, text4, author);
            MessageBox.Show(message);
        }
    }
}
