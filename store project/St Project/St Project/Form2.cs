using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace St_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public string TextBoxValue
        {
            get { return textBox1.Text; }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text== "sss")
            {
              //  this.Close();
                newpass newForm2 = new newpass();
                this.Visible = false;
                newForm2.Show();
                newForm2.FormClosed += (s, args) =>
                {
                    this.Visible = true;
                };
                


            }
            else
            {
                label3.Text = "Invalid code";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
