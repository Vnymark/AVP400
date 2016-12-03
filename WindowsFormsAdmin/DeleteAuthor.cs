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
    public partial class DeleteAuthor : Form
    {
        int id;
        string message;
        public DeleteAuthor()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference.Service1Client Client = new ServiceReference.Service1Client();
            try
            {
                id = Int16.Parse(textBox1.Text);
                message = Client.DeleteAuthor(id);
                MessageBox.Show(message);
            }
            catch (Exception)
            {
                message = "Couldn't parse the author id successfully.";
                Logging.log(message);
                MessageBox.Show(message);
            }
        }
    }
}
