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
    public partial class AdminAccount : MetroFramework.Forms.MetroForm {
        public AdminAccount() {
            InitializeComponent();
        }

        private void AdminAccount_Load(object sender, EventArgs e) {

        }

        // Close button
        private void metroButton2_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.Close();
            new ChangeAdminPassword().ShowDialog();
            this.Show();
        }
    }
}
