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
    public partial class EditBook : Form
    {
        int id, author;
        short text4;
        string message;
        public EditBook()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                id = Int16.Parse(textBox1.Text);
            }
            catch (Exception)
            {
                message = "Couldn't parse the id successfully.";
                Loggning.log(message);
            }
            try
            {
                text4 = short.Parse(textBox5.Text);
            }
            catch (Exception)
            {
                message = "Couldn't parse the visibility successfully.";
                Loggning.log(message);
            }
            if (textBox6.Text == null) {
                author = 0;
            }
            else
            {
                try
                {
                    author = int.Parse(textBox6.Text);
                }
                catch (Exception)
                {
                    message = "Couldn't parse the author successfully.";
                    Loggning.log(message);
                }
            }

            ServiceReference.Service1Client Client = new ServiceReference.Service1Client();
            message = Client.EditBook(id, textBox2.Text, textBox3.Text, textBox4.Text, text4, author);
            MessageBox.Show(message);
        }
    }
}
