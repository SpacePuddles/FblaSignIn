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
        
        // We could use this to populate a database looking list. If we need it anyway.
        private void populate() {
            SqlCommand cmd;
            SqlReader reader;
            string sql;
            
            using (SqlConnection con = new SqlConnection()) {
                string id, fname, lname, grade, studentid, fblaid, teamstring, eventstring;
                sql = "SELECT * FROM DBO.Users;";
                cmd = new SqlCommand(sql);
                
                con.ConnectionString = "";
                con.Open();
                
                reader = cmd.ExecuteReader();
                while(reader.Read()) {
                    id = reader["ID"].ToString();
                    fname = reader["[First Name]"].ToString();
                    lname = reader["[Last Name]"].ToString();
                    grade = reader["Grade"].ToString();
                    studentid = reader["[Student ID]"].ToString();
                    fblaid = reader["[FBLA ID]"].ToString();
                    teamstring = reader["[Team IDs]"].ToString();
                    eventstring = reader["[Event IDs]"].ToString();
                }
                
                //Close con and make student later
            }
        }
    }
}
