namespace projectTutor
{
    partial class MenuForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.studentMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationMainMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentMainMenuItem,
            this.tutorMainMenuItem,
            this.roomMainMenuItem,
            this.reservationMainMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1011, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentMainMenuItem
            // 
            this.studentMainMenuItem.Name = "studentMainMenuItem";
            this.studentMainMenuItem.Size = new System.Drawing.Size(72, 24);
            this.studentMainMenuItem.Text = "Student";
            this.studentMainMenuItem.Click += new System.EventHandler(this.studentMainMenuItem_Click);
            // 
            // tutorMainMenuItem
            // 
            this.tutorMainMenuItem.Name = "tutorMainMenuItem";
            this.tutorMainMenuItem.Size = new System.Drawing.Size(56, 24);
            this.tutorMainMenuItem.Text = "Tutor";
            this.tutorMainMenuItem.Click += new System.EventHandler(this.tutorMainMenuItem_Click_1);
            // 
            // roomMainMenuItem
            // 
            this.roomMainMenuItem.Name = "roomMainMenuItem";
            this.roomMainMenuItem.Size = new System.Drawing.Size(61, 24);
            this.roomMainMenuItem.Text = "Room";
            this.roomMainMenuItem.Click += new System.EventHandler(this.roomMainMenuItem_Click);
            // 
            // reservationMainMenuItem
            // 
            this.reservationMainMenuItem.Name = "reservationMainMenuItem";
            this.reservationMainMenuItem.Size = new System.Drawing.Size(98, 24);
            this.reservationMainMenuItem.Text = "Reservation";
            this.reservationMainMenuItem.Click += new System.EventHandler(this.reservationMainMenuItem_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 599);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomMainMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationMainMenuItem;
    }
}