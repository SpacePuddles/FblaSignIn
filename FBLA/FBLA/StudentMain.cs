using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace FBLASignIn
{
    public partial class StudentMain : Form
    {
        int Events = 0; 
        String Studentid; 
        public StudentMain(String userid)
        {
            this.CenterToScreen(); 
            InitializeComponent();
            Studentid = userid; 
        }        

        private void StudentMain_Load(object sender, EventArgs e)
        {
            //loads information into SQL database

            //this.studentsTableAdapter.Fill(this.studentDataDataSet.Students);
            //button1.Enabled = false;
            //studentsBindingSource.Filter = "id = " + Studentid;
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            //matches button3
            Studentid = null;
            this.Close();
            new LogIn().Show(); 
        }

        private void addevent_Click(object sender, EventArgs e)
        {
            //add new event 
            //matches button1 
            this.Hide();
            new AddEvent(Studentid).Show(); 
        }

        private void editevent_Click(object sender, EventArgs e)
        {
            //edit event
            //matches button2
            if (Events != 0)
            {
                this.Hide(); 
                new EditEvent().Show();
            }
            else
            {
                MessageBox.Show("You have no Events yet! Add Event first");
            }
        }

        private void MessageBoxIcon(string p)
        {
            throw new NotImplementedException();
        }
    }
}

