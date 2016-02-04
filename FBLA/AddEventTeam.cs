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
    public partial class AddEventTeam : Form
    {
        public AddEventTeam()
        {
            InitializeComponent();
            this.CenterToScreen(); 
        }

        private void AddEventTeam_Load(object sender, EventArgs e)
        {
            String[] Tests = { "Null", "Banking and Financial Systems", "Entrepreneurship", "Global Business", "Hospitality Management", "Management Decision Making", "Management Information Systems", "Marketing", "Network Design", "Parlimentary Procedure", "Sports and Entertainment Management" };

            //Individual or Team
            String[] SpecEvents = {"Null", "Business Ethics", "Emerging Business Issues", "Introduction to Business Presentation", "Sales Presentation", "3D Animation", "Business Financial Plan", "Business Plan", "Community Service Project", "Computer Game Simulation and Programing", "Desktop Application Programming", "Digital Video Production", "E-Business", "Electronic Career Portfolio", "Graphic Design", " Local Chapter Annual Business Report", "Mobile Application Development", "Partnership With Business Project", "Public Service Project", "Publication Design", "Social Media Campaign", "Website Design" };

           

                 
            //adding events

                for(int i = 0; i <= SpecEvents.Length; i++)
                {
                    Events.Items.Add(new { Text = Tests[i], Value = Tests[i].Trim()}); 
                 }
            //adding tests
                for (int i = 0; i <= Tests.Length; i++)
                {
                    NotEvents.Items.Add(new { Text = Tests[i], Value = Tests[i].Trim() });
                }  
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            new StudentMain(null).Show(); 
        }
    }
}
