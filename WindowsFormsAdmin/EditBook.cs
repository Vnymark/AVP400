﻿using System;
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
            ServiceReference.Service1Client Client = new ServiceReference.Service1Client();
            try
            {
                id = Int16.Parse(textBox1.Text);
                
            }
            catch (Exception)
            {
                message = "Couldn't parse the book id successfully.";
                Logging.log(message);
                MessageBox.Show(message);
            }
            try
            {
                text4 = short.Parse(textBox5.Text);
            }
            catch (Exception)
            {
                message = "Couldn't parse the visibility successfully.";
                Logging.log(message);
                MessageBox.Show(message);
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
                    message = "Couldn't parse the author id successfully.";
                    Logging.log(message);
                    MessageBox.Show(message);
                }
            }
            if (message == "Couldn't parse the book id successfully." || message == "Couldn't parse the visibility successfully." || message == "Couldn't parse the author id successfully.")
            {
                
            }
            else
            {
                message = Client.EditBook(id, textBox2.Text, textBox3.Text, textBox4.Text, text4, author);
                MessageBox.Show(message);
            }



        }
    }
}
