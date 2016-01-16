namespace FBLA
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.last_name = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.label3 = new MetroFramework.Controls.MetroLabel();
            this.label4 = new MetroFramework.Controls.MetroLabel();
            this.student_id = new MetroFramework.Controls.MetroTextBox();
            this.first_name = new MetroFramework.Controls.MetroTextBox();
            this.fbla_id = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new MetroFramework.Controls.MetroLabel();
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.N_Grd = new MetroFramework.Controls.MetroRadioButton();
            this.T_Grd = new MetroFramework.Controls.MetroRadioButton();
            this.E_Grd = new MetroFramework.Controls.MetroRadioButton();
            this.Tw_Grd = new MetroFramework.Controls.MetroRadioButton();
            this.button2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // last_name
            // 
            this.last_name.CustomBackground = true;
            this.last_name.Location = new System.Drawing.Point(94, 108);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(172, 20);
            this.last_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Student ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Grade";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // student_id
            // 
            this.student_id.CustomBackground = true;
            this.student_id.Location = new System.Drawing.Point(94, 195);
            this.student_id.Name = "student_id";
            this.student_id.Size = new System.Drawing.Size(172, 20);
            this.student_id.TabIndex = 7;
            // 
            // first_name
            // 
            this.first_name.CustomBackground = true;
            this.first_name.Location = new System.Drawing.Point(94, 72);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(172, 20);
            this.first_name.TabIndex = 8;
            // 
            // fbla_id
            // 
            this.fbla_id.CustomBackground = true;
            this.fbla_id.Location = new System.Drawing.Point(95, 229);
            this.fbla_id.Name = "fbla_id";
            this.fbla_id.Size = new System.Drawing.Size(172, 20);
            this.fbla_id.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "FBLA ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "Create User";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // N_Grd
            // 
            this.N_Grd.AutoSize = true;
            this.N_Grd.Location = new System.Drawing.Point(94, 144);
            this.N_Grd.Name = "N_Grd";
            this.N_Grd.Size = new System.Drawing.Size(74, 15);
            this.N_Grd.TabIndex = 12;
            this.N_Grd.TabStop = true;
            this.N_Grd.Text = "9th Grade";
            this.N_Grd.UseVisualStyleBackColor = true;
            this.N_Grd.CheckedChanged += new System.EventHandler(this.N_Grd_CheckedChanged);
            // 
            // T_Grd
            // 
            this.T_Grd.AutoSize = true;
            this.T_Grd.Location = new System.Drawing.Point(185, 144);
            this.T_Grd.Name = "T_Grd";
            this.T_Grd.Size = new System.Drawing.Size(80, 15);
            this.T_Grd.TabIndex = 13;
            this.T_Grd.TabStop = true;
            this.T_Grd.Text = "10th Grade";
            this.T_Grd.UseVisualStyleBackColor = true;
            this.T_Grd.CheckedChanged += new System.EventHandler(this.T_Grd_CheckedChanged);
            // 
            // E_Grd
            // 
            this.E_Grd.AutoSize = true;
            this.E_Grd.Location = new System.Drawing.Point(95, 167);
            this.E_Grd.Name = "E_Grd";
            this.E_Grd.Size = new System.Drawing.Size(80, 15);
            this.E_Grd.TabIndex = 14;
            this.E_Grd.TabStop = true;
            this.E_Grd.Text = "11th Grade";
            this.E_Grd.UseVisualStyleBackColor = true;
            this.E_Grd.CheckedChanged += new System.EventHandler(this.E_Grd_CheckedChanged);
            // 
            // Tw_Grd
            // 
            this.Tw_Grd.AutoSize = true;
            this.Tw_Grd.Location = new System.Drawing.Point(186, 166);
            this.Tw_Grd.Name = "Tw_Grd";
            this.Tw_Grd.Size = new System.Drawing.Size(80, 15);
            this.Tw_Grd.TabIndex = 15;
            this.Tw_Grd.TabStop = true;
            this.Tw_Grd.Text = "12th Grade";
            this.Tw_Grd.UseVisualStyleBackColor = true;
            this.Tw_Grd.CheckedChanged += new System.EventHandler(this.Tw_Grd_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancel";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 319);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Tw_Grd);
            this.Controls.Add(this.E_Grd);
            this.Controls.Add(this.T_Grd);
            this.Controls.Add(this.N_Grd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fbla_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.first_name);
            this.Controls.Add(this.student_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.last_name);
            this.Name = "SignUp";
            this.Resizable = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox last_name;
        private MetroFramework.Controls.MetroTextBox student_id;
        private MetroFramework.Controls.MetroTextBox first_name;
        private MetroFramework.Controls.MetroTextBox fbla_id;
        private MetroFramework.Controls.MetroLabel label1;
        private MetroFramework.Controls.MetroLabel label2;
        private MetroFramework.Controls.MetroLabel label3;
        private MetroFramework.Controls.MetroLabel label4;
        private MetroFramework.Controls.MetroLabel label5;
        private MetroFramework.Controls.MetroButton button1;
        private MetroFramework.Controls.MetroRadioButton N_Grd;
        private MetroFramework.Controls.MetroRadioButton T_Grd;
        private MetroFramework.Controls.MetroRadioButton E_Grd;
        private MetroFramework.Controls.MetroRadioButton Tw_Grd;
        private MetroFramework.Controls.MetroButton button2;
    }
}