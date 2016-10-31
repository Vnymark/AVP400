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
        int iId;
        short iText4;
        string sText1 = "", sText2 = "", sText3 = "", sMessage;
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
            sText1 = textBox2.Text;
            sText2 = textBox3.Text;
            sText3 = textBox4.Text;
            try
            {
                iText4 = short.Parse(textBox5.Text);
                    
            }
            catch (Exception)
            {
                sMessage = "Couldn't parse the visibility successfully.";
            }

            ServiceReference.Service1Client Client = new ServiceReference.Service1Client();
            sMessage = Client.EditBook(iId, sText1, sText2, sText3, iText4);
            MessageBox.Show(sMessage);
        }
    }
}
