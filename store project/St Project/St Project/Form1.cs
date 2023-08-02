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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void usernameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void roleBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void QuitBTN_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void usernameText_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         //   MessageBox.Show("Check Your GMAIL .");
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoginBTN_Click_1(object sender, EventArgs e)
        {

        }

        private void LoginBTN_Click_2(object sender, EventArgs e)
        {

        }

        private void LoginBTN_Click_3(object sender, EventArgs e)
        {
            usernamelabel.Text = string.Empty;
            passwordlabel.Text = string.Empty;
            rolelabel.Text = string.Empty;
            bool flag = false;
            if (usernameText.Text == "")
            {
                usernamelabel.ForeColor = System.Drawing.Color.Maroon;
                usernamelabel.Text = "Enter a Username.";
                flag = true;
            }
            if (passwordText.Text == "")
            {
                passwordlabel.ForeColor = System.Drawing.Color.Maroon;
                passwordlabel.Text = "Enter a Password.";
                flag = true;
            }
            if (roleBox.Text == "")
            {
                rolelabel.ForeColor = System.Drawing.Color.Maroon;
                rolelabel.Text = "Select a Role.";
                flag = true;
            }

        }

        private void usernamelabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordlabel_Click(object sender, EventArgs e)
        {

        }

        private void rolelabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(passwordText.PasswordChar == 'x')
            {
                passwordText.PasswordChar = '\0';
                pictureBox2.Image = eyepic.Image;
                
            }
            else
            {
                passwordText.PasswordChar = 'x';
                pictureBox2.Image = swpic.Image;
            }
      
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            this.Visible = false;
            newForm.Show();   
               string userInputValue = newForm.TextBoxValue;
            newForm.FormClosed += (s, args) =>
            {
                this.Visible = true;
            };

        }
    }
}
