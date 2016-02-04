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
    public partial class AddEvent : Form
    {

        String Studentid;
        public AddEvent(String Studentid)
        {
            this.CenterToScreen();
            InitializeComponent();
            Studentid = this.Studentid;
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // individual button
            this.Close();
            new AddEventIndv().Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // team button
            this.Close();
            new AddEventTeam().Show(); 
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
            new StudentMain(Studentid).Show(); 
        }

    }
}
