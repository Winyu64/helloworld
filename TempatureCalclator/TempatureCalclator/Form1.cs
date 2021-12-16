using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempatureCalclator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            // input
            // นี่คือคอมเม้นท์
            //textBoxC.Text = "Hello";
            // get input fom textbox
            string input = textBoxC.Text;
            // comvert to f
            // f = c * 9/5 + 32
            double c = Convert.ToDouble(input);
            double f = c * 9 / 5 + 32;

            // show ingut to textbox
            textBoxF.Text = f.ToString();

        }

        private void buttonConvert2_Click(object sender, EventArgs e)
        {
            string input = textBoxF.Text;
            double f = Convert.ToDouble(input);
            double c = (f - 32) * 5/9;
            textBoxC.Text = c.ToString();
        }
    }
}
