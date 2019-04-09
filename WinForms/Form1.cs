using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WinForms.ServiceReference.Service1Client client 
                = new ServiceReference.Service1Client();
            MessageBox.Show(client.HelloResponse(textBox1.Text));
            client.Close();
        }
    }
}
