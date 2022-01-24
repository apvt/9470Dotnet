using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24jan_sampleapplcation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
           private void listCity_SelectedIndexChanged(object sender,EventArgs e)
            { 
            string text=listCity.GetItemText(listCity.SelectedItem);
                MessageBox.Show(text);
             }
        private void btnSUBMIT_Click_1(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string address =textBox2.Text;
            MessageBox.Show(name + address);
        }
    }
}
