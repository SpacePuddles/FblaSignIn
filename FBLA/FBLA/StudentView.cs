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
    public partial class StudentView : MetroFramework.Forms.MetroForm {
        public StudentView() {
            InitializeComponent();
        }

        private void StudentView_Load(object sender, EventArgs e) {
            this.Text = "Student View";
        }

        private void metroButton3_Click(object sender, EventArgs e) {
            this.Close();
        }
        
        // We could use this to populate a database looking list. If we need it, anyway.
        private void populate() {
            SqlCommand cmd;
            SqlDataReader reader;
            string sql;
            List<Student> tmp_ppl = new List<Student>();
            
            using (SqlConnection con = new SqlConnection()) {
                Student tmp;
                string id, fname, lname, grade, studentid, fblaid, teamstring, eventstring, altstring;
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
                    altstring = reader["Alternates"].ToString();

                    tmp = new Student(Int32.Parse(id), fname, lname, studentid, fblaid, Int32.Parse(grade));
                    tmp.EventString = eventstring;
                    tmp.TeamString = teamstring;
                    tmp.AltString = altstring;

                    tmp_ppl.Add(tmp);
                }

                con.Close();
                
            }

            // Add stuff to a view here.
        }
    }
}
