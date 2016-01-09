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
    public partial class StudentView : MetroFramework.Forms.MetroForm {
        public StudentView() {
            InitializeComponent();
        }

        private void StudentView_Load(object sender, EventArgs e) {

        }

        private void metroButton3_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
