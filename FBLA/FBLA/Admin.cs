﻿using System;
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
    }
}