﻿using System;
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
        short iText4;
        string sText1 = "", sText2 = "", sText3 = "", sMessage;
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sText1 = textBox1.ToString();
            sText2 = textBox2.ToString();
            sText3 = textBox3.ToString();
            if (textBox4 != null)
            {
                try
                {
                    iText4 = Int16.Parse(textBox4.ToString());
                    short a = iText4;
                }
                catch (Exception)
                {
                    sMessage = "Couldn't parse successfully.";

                }
            }
            else
            {
                iText4 = 1;
            }
            ServiceReference.Service1Client Client = new ServiceReference.Service1Client();
            Client.AddBook(sText1, sText2, sText3, iText4);
        }
    }
}
