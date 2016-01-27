using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FBLA {
    public partial class SignUp : MetroFramework.Forms.MetroForm {


        public SignUp() {
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Sign Up";
            // this.StartPosition = FormStartPosition.Manual;
            //this.Location = new Point(400, 100);
        }


        private void label2_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }


        private void SignUp_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            Signup();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
            new LogIn().Show();
        }

        private void first_name_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {
            //first name value
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {
            //last name value
        }


        private void student_id_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {
            //student id value
        }

        private void fbla_id_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {
            //fbla id value
        }

        private void N_Grd_CheckedChanged(object sender, EventArgs e) {
            //9th grader
        }

        private void T_Grd_CheckedChanged(object sender, EventArgs e) {
            //10th grader
        }

        private void E_Grd_CheckedChanged(object sender, EventArgs e) {
            //11th grader
        }

        private void Tw_Grd_CheckedChanged(object sender, EventArgs e) {
            //12th grader
        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private void Signup() {
            // all the variables
            String firstname = first_name.Text;
            String lastname = last_name.Text;
            String studentid = student_id.Text;
            String fblaid = fbla_id.Text;
            int grade = 0;

            // what grade 
            /*if (N_Grd.Checked || T_Grd.Checked || E_Grd.Checked || Tw_Grd.Checked)
            {
                if (N_Grd.Checked && !T_Grd.Checked && !E_Grd.Checked && !Tw_Grd.Checked)
                {
                    grade = 9; 
                }
                else if (T_Grd.Checked && !N_Grd.Checked && !E_Grd.Checked && !Tw_Grd.Checked)
                {
                    grade = 10;
                }
                else if (E_Grd.Checked && !N_Grd.Checked && !T_Grd.Checked && !Tw_Grd.Checked)
                {
                    grade = 11;
                }
                else if(Tw_Grd.Checked && !N_Grd.Checked && !T_Grd.Checked && !E_Grd.Checked)
                {
                    grade = 12;
                }
            }*/


            // Above was a bit redundant. 
            if (N_Grd.Checked == true)
                grade = 9;
            else if (T_Grd.Checked == true)
                grade = 10;
            else if (E_Grd.Checked == true)
                grade = 11;
            else if (Tw_Grd.Checked == true)
                grade = 12;

            if (firstname != null && lastname != null && student_id != null && fblaid != null && grade != 0) {
                //create new student here

                this.Close();
                new LogIn().Show();
            } else {
                MessageBox.Show("Unfilled field, please fill out all fields");
            }
        }
    }
}
