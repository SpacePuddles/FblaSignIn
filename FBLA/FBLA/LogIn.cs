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


namespace FBLA {
    public partial class LogIn : MetroFramework.Forms.MetroForm {
        public LogIn() {
            InitializeComponent();
            this.CenterToScreen();

            this.Text = "Login";
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {
            // this is the userid
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {
            // this is the password
        }
        private void button1_Click(object sender, EventArgs e) {
            Login();
        }

        private void button2_Click(object sender, EventArgs e) {
            // Sign Up Button -- > creates Sign Up Form
            this.Hide();
            new SignUp().ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e) {
            //labeling password
        }

        private void LogIn_Load(object sender, EventArgs e) {
            maskedTextBox2.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void Login() {
            string pword = getPassword();
            Boolean exists = UserExists();

            if (maskedTextBox2.Text == pword && exists) {
                this.Hide();
                new StudentView().Show();
            } else {
                MessageBox.Show("Username or password incorrect!", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string getPassword() {
            string password = String.Empty;

            var connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afrea\\Documents\\GitHub\\FblaSignIn\\FBLA\\FBLA\\fbla.mdf;Integrated Security=True");
            connection.Open();

            using (var command = new SqlCommand("@UNI_PASSWORD", connection))
            using (var reader = command.ExecuteReader()) {
                  password = reader.GetValue(0).ToString();
            }

            return password;
        }

        private Boolean UserExists() {
            string sql;
            int userCount;
            SqlCommand cmd;

            using (SqlConnection con = new SqlConnection()) {
                sql = "SELECT COUNT(*) FROM DBO.Users WHERE [Student ID] LIKE @studentid;";
                cmd = new SqlCommand(sql);
                cmd.Connection = con;
                con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\afrea\\Documents\\GitHub\\FblaSignIn\\FBLA\\FBLA\\fbla.mdf;Integrated Security=True";
                
                con.Open();

                cmd.Parameters.AddWithValue("@studentid", maskedTextBox1.Text);
                userCount = (int)cmd.ExecuteScalar();

                con.Close();
            }

            if (userCount < 1)
                return false;

            return true;
        }
    }
}
            //String password = maskedTextBox1.Text;
            //String userid = maskedTextBox2.Text;
            //Boolean idreal = false;
            //Boolean isAdmin = false;
            //if (UserIds != null) {
            //    {
            //        //Is this IdReal?
            //        for (int i = 0; i <= UserIds.Length - 1; i++) {
            //            if (UserIds[i] == userid.Trim()) {
            //                idreal = true;
            //            }

            //        }
            //        for (int i = 0; i <= Admins.Length - 1; i++) {
            //            if (Admins[i] == userid.Trim()) {
            //                idreal = true;
            //                isAdmin = true;
            //            }
            //        }
            //        //Log In Button -- > Logs in, or doesnt
            //        if (password == UniPassword && idreal && !isAdmin) {
            //            this.Hide();
            //            new StudentMain(userid).Show();
            //        } else if (password == AdminPassword && idreal && isAdmin) {
            //            this.Hide();
            //            new Admin().ShowDialog();
            //            this.Show();
            //        } else {
            //            if (!idreal) {
            //                MessageBox.Show(this, "Incorrect Username");
            //            } else if (password != UniPassword) {
            //                MessageBox.Show(this, "Incorrect Password");
            //            } else {
            //                MessageBox.Show(this, "Error");
            //            }
            //        }
            //    }
            //} else {
            //    MessageBox.Show(this, "No Username Array Available");
            //}