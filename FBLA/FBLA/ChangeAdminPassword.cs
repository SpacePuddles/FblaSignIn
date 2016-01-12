using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBLA
{
    public partial class ChangeAdminPassword : MetroFramework.Forms.MetroForm
    {
        public ChangeAdminPassword() {
            InitializeComponent();
        }

        private void ChangeAdminPassword_Load(object sender, EventArgs e) {
            this.Text = "Change Password";

            
        }

        private void metroButton1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            if (textBox1.Text != metroTextBox1.Text)
                MessageBox.Show("New passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader reader;
            string sql;
            string currentHash = "";

            // Check if current password is correct
            sql = "SELECT [password] FROM Admins WHERE username = " + "test;";

            con = new SqlConnection();

            cmd = new SqlCommand(sql);

            // Set connection string later when I have it
            con.ConnectionString = "";
            con.Open();
              

            reader = cmd.ExecuteReader();
            while (reader.Read()) {
                currentHash = reader.GetValue(0).ToString();
            }

            con.Close();

            if (currentHash == Password.HashPassword(metroTextBox2.Text)) {
                MessageBox.Show("Password Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            } else {
                MessageBox.Show("Password Incorrect!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
