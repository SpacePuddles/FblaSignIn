using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBLASignIn
{
    public partial class LogIn : Form
    {
        //The Universal Password
        String UniPassword;
        //Array of Usernames 
        String[] UserIds; 
        //Correct Username and Password correlation 

        public LogIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(500,300);
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // this is the userid
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // this is the password
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String password = maskedTextBox1.Text; 
            String userid = maskedTextBox2.Text; 
            Boolean idreal = false;
            if (UserIds != null)
            {
                {
                    //Is this IdReal?
                    for (int i = 0; i <= UserIds.Length; i++)
                    {
                        if (UserIds[i] == userid.Trim())
                        {
                            idreal = true;
                        }
                    }
                    //Log In Button -- > Logs in, or doesnt
                    if (password == UniPassword && idreal)
                    {
                        this.Hide();
                        new StudentMain(userid).Show();
                    }
                    else
                    {
                        if (!idreal)
                        {
                            MessageBox.Show(this, "Incorrect Username");
                        }
                        else if (password != UniPassword)
                        {
                            MessageBox.Show(this, "Incorrect Password");
                        }
                        else
                        {
                            MessageBox.Show(this, "Error");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "No Username Array Available"); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Sign Up Button -- > creates Sign Up Form
            this.Hide(); 
            new SignUp().Show(); 
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //labeling password
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            //labeling username
        }

        
    }
}
