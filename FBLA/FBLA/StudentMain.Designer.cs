namespace FBLASignIn
{
    partial class StudentMain
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
            this.Logout = new System.Windows.Forms.Button();
            this.addevent = new System.Windows.Forms.Button();
            this.editevent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(12, 12);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 23);
            this.Logout.TabIndex = 0;
            this.Logout.Text = "Log Out";
            this.Logout.UseVisualStyleBackColor = true;
            // 
            // addevent
            // 
            this.addevent.Location = new System.Drawing.Point(351, 242);
            this.addevent.Name = "addevent";
            this.addevent.Size = new System.Drawing.Size(75, 23);
            this.addevent.TabIndex = 1;
            this.addevent.Text = "Add Event";
            this.addevent.UseVisualStyleBackColor = true;
            // 
            // editevent
            // 
            this.editevent.Location = new System.Drawing.Point(481, 242);
            this.editevent.Name = "editevent";
            this.editevent.Size = new System.Drawing.Size(75, 23);
            this.editevent.TabIndex = 2;
            this.editevent.Text = "Edit Event";
            this.editevent.UseVisualStyleBackColor = true;
            // 
            // StudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 295);
            this.Controls.Add(this.editevent);
            this.Controls.Add(this.addevent);
            this.Controls.Add(this.Logout);
            this.Name = "StudentMain";
            this.Text = "NewStudent";
            this.Load += new System.EventHandler(this.StudentMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button addevent;
        private System.Windows.Forms.Button editevent;
    }
}
