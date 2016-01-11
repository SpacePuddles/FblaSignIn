using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;

namespace FBLA {
    public partial class Form1 : MetroFramework.Forms.MetroForm {
        public Form1() {
            InitializeComponent();
            this.Text = "FBLA Login";
        }

        private void Form1_Load(object sender, EventArgs e) {
            
        }

        private void button1_Click(object sender, EventArgs e) {
            // Hides the login form so multiple windows can't be opened.
            this.Hide();
            new Admin().ShowDialog();
            this.Show();
        }
    }
}
