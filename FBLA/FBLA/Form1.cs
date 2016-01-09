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

        // Login Button
        private void button1_Click(object sender, EventArgs e) {
            new Admin().Show();
            
        }

        // Register Button
        private void button2_Click(object sender, EventArgs e) {
            //new Register().Show();
        }
    }
}
