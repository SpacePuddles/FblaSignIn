using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBLA {
    public partial class Admin : MetroFramework.Forms.MetroForm {
        public Admin() {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e) {
            this.Text = "Admin Menu";
        }

        private void button1_Click(object sender, EventArgs e) {

        }

        // Takes the person to the student management thing
        private void metroTile2_Click(object sender, EventArgs e) {
            new StudentView().Show();
        }

        // Closes the window. Returns to login screen.
        private void metroButton2_Click(object sender, EventArgs e) {
            this.Close();
        }

        // Takes user to account thing to change password and do other things.
        private void button2_Click(object sender, EventArgs e) {
            new AdminAccount().Show();
        }
    }
}
