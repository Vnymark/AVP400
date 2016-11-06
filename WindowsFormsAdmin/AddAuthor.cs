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
    public partial class AddAuthor : Form
    {
        string message;
        public AddAuthor()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference.Service1Client Client = new ServiceReference.Service1Client();
            message = Client.AddAuthor(textBox1.Text);
            MessageBox.Show(message);
        }
    }
}
