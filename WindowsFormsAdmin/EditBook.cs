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
    public partial class EditBook : Form
    {
        int iId, iAuthor;
        short iText4;
        string sMessage;
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
                iId = Int16.Parse(textBox1.Text);
            }
            catch (Exception)
            {
                sMessage = "Couldn't parse the id successfully.";
            }
            try
            {
                iText4 = short.Parse(textBox5.Text);
            }
            catch (Exception)
            {
                sMessage = "Couldn't parse the visibility successfully.";
            }
            if (textBox6.Text == null) {
                iAuthor = 0;
            }
            else
            {
                try
                {
                    iAuthor = int.Parse(textBox6.Text);
                }
                catch (Exception)
                {
                    sMessage = "Couldn't parse the author successfully.";
                }
            }

            ServiceReference.Service1Client Client = new ServiceReference.Service1Client();
            sMessage = Client.EditBook(iId, textBox2.Text, textBox3.Text, textBox4.Text, iText4, iAuthor);
            MessageBox.Show(sMessage);
        }
    }
}
