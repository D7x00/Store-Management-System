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
    public partial class newpass : Form
    {
        public newpass()
        {
            InitializeComponent();
        }
      
        public string newpasswdvalue
        {
            get { return textBox1.Text; }
        }
       
        private void newpass_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if( textBox1.Text != textBox2.Text )
            {
                label3.Text = "Incorrect Password";
                  
            }
            else if(textBox1.Text.Length < 8)
            {
                label3.Text = "At least 8 letters";
            }
            else
            {
               this.Close();
                // to close form2 and return to log in form
                Form form2 = Application.OpenForms["Form2"] as Form;
                if (form2 != null)
                {
                    form2.Close();
                }
            }
            
           
        }
       
    }
}
