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
    public partial class AddEventIndv : Form
    {
        public AddEventIndv()
        {
            InitializeComponent();
            this.CenterToScreen(); 
        }

        private void AddEventIndv_Load(object sender, EventArgs e)
        {
            String[] Tests = { "None", "Accounting 1", "Accounting 2", "Agribusiness", "Business Calculations", "Business Communication", "Computer Problem Solving", "Cyber Security", "Economics", "FBLA Principles and Procedures", "Health Care Administration", "Insurance and Risk Management", "Introduction to Business", "Introduction to Business Procedure", "Introduction to Financial Math", "Introduction to Financial Math", "Introduction to Information Technology", "Introduction to Parilamentary Procedure", "Microsoft Office Specialist: Excel", "Microsoft Office Specialist: Word", "Networking Concepts", "Personal Finance", "Securities and Investments" };
            String[] Event = {"None", "Client Desk", "Help Desk", "Computer Applications", "Database Design and Application", "Spreadsheet Applications", "Word Processing", "Creed", "Impromptu Speaking", "Public Speaking I", "Public Speaking II", "Future Business Leader", "Job Interview",};
            //Individual or Team
            String[] SpecEvents = { "Business Ethics", "Emerging Business Issues", "Introduction to Business Presentation", "Sales Presentation", "3D Animation", "Business Financial Plan", "Business Plan", "Community Service Project", "Computer Game Simulation and Programing", "Desktop Application Programming", "Digital Video Production", "E-Business", "Electronic Career Portfolio", "Graphic Design", " Local Chapter Annual Business Report", "Mobile Application Development", "Partnership With Business Project", "Public Service Project", "Publication Design", "Social Media Campaign", "Website Design"};
         
                //need to change so if student grade != 9 will not be an option 

            //adding tests
            for (int i = 0; i <= Tests.Length; i++)
            {
                NotTests.Items.Add(new {Text = Tests[i], Value = Tests[i].Trim() });
            }

            //adding events
            for (int i = 0; i <= SpecEvents.Length; i++)
            {
                Events.Items.Add(new { Text = SpecEvents[i], Value = SpecEvents[i].Trim()});
            }
            for (int i = 0; i <= Event.Length; i++)
            {
                Events.Items.Add(new { Text = Event[i], Value = Event[i].Trim() });
            }
        }

        private void NotTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tests
        }

        private void Events_SelectedIndexChanged(object sender, EventArgs e)
        {
            //events
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
            new StudentMain(null).Show();
        }
    }
}
