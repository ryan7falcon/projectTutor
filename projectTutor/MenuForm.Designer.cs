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
            this.studentMainMenuLabel = new System.Windows.Forms.Label();
            this.studentMainMenuRichBox = new System.Windows.Forms.RichTextBox();
            this.tutorMainMenuLabel = new System.Windows.Forms.Label();
            this.tutorMainMenuRichBox = new System.Windows.Forms.RichTextBox();
            this.reservedMainMenuLabel = new System.Windows.Forms.Label();
            this.reservedMainMenuRichBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentMainMenuItem,
            this.tutorMainMenuItem,
            this.roomMainMenuItem,
            this.reservationMainMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(758, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentMainMenuItem
            // 
            this.studentMainMenuItem.Name = "studentMainMenuItem";
            this.studentMainMenuItem.Size = new System.Drawing.Size(60, 20);
            this.studentMainMenuItem.Text = "Student";
            // 
            // tutorMainMenuItem
            // 
            this.tutorMainMenuItem.Name = "tutorMainMenuItem";
            this.tutorMainMenuItem.Size = new System.Drawing.Size(48, 20);
            this.tutorMainMenuItem.Text = "Tutor";
            // 
            // roomMainMenuItem
            // 
            this.roomMainMenuItem.Name = "roomMainMenuItem";
            this.roomMainMenuItem.Size = new System.Drawing.Size(51, 20);
            this.roomMainMenuItem.Text = "Room";
            // 
            // reservationMainMenuItem
            // 
            this.reservationMainMenuItem.Name = "reservationMainMenuItem";
            this.reservationMainMenuItem.Size = new System.Drawing.Size(80, 20);
            this.reservationMainMenuItem.Text = "Reservation";
            // 
            // studentMainMenuLabel
            // 
            this.studentMainMenuLabel.AutoSize = true;
            this.studentMainMenuLabel.Location = new System.Drawing.Point(42, 73);
            this.studentMainMenuLabel.Name = "studentMainMenuLabel";
            this.studentMainMenuLabel.Size = new System.Drawing.Size(44, 13);
            this.studentMainMenuLabel.TabIndex = 1;
            this.studentMainMenuLabel.Text = "Student";
            // 
            // studentMainMenuRichBox
            // 
            this.studentMainMenuRichBox.Location = new System.Drawing.Point(56, 101);
            this.studentMainMenuRichBox.Name = "studentMainMenuRichBox";
            this.studentMainMenuRichBox.Size = new System.Drawing.Size(140, 212);
            this.studentMainMenuRichBox.TabIndex = 2;
            this.studentMainMenuRichBox.Text = "";
            // 
            // tutorMainMenuLabel
            // 
            this.tutorMainMenuLabel.AutoSize = true;
            this.tutorMainMenuLabel.Location = new System.Drawing.Point(302, 73);
            this.tutorMainMenuLabel.Name = "tutorMainMenuLabel";
            this.tutorMainMenuLabel.Size = new System.Drawing.Size(32, 13);
            this.tutorMainMenuLabel.TabIndex = 3;
            this.tutorMainMenuLabel.Text = "Tutor";
            // 
            // tutorMainMenuRichBox
            // 
            this.tutorMainMenuRichBox.Location = new System.Drawing.Point(308, 99);
            this.tutorMainMenuRichBox.Name = "tutorMainMenuRichBox";
            this.tutorMainMenuRichBox.Size = new System.Drawing.Size(140, 212);
            this.tutorMainMenuRichBox.TabIndex = 4;
            this.tutorMainMenuRichBox.Text = "";
            // 
            // reservedMainMenuLabel
            // 
            this.reservedMainMenuLabel.AutoSize = true;
            this.reservedMainMenuLabel.Location = new System.Drawing.Point(547, 73);
            this.reservedMainMenuLabel.Name = "reservedMainMenuLabel";
            this.reservedMainMenuLabel.Size = new System.Drawing.Size(53, 13);
            this.reservedMainMenuLabel.TabIndex = 5;
            this.reservedMainMenuLabel.Text = "Reserved";
            // 
            // reservedMainMenuRichBox
            // 
            this.reservedMainMenuRichBox.Location = new System.Drawing.Point(554, 101);
            this.reservedMainMenuRichBox.Name = "reservedMainMenuRichBox";
            this.reservedMainMenuRichBox.Size = new System.Drawing.Size(140, 212);
            this.reservedMainMenuRichBox.TabIndex = 6;
            this.reservedMainMenuRichBox.Text = "";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 487);
            this.Controls.Add(this.reservedMainMenuRichBox);
            this.Controls.Add(this.reservedMainMenuLabel);
            this.Controls.Add(this.tutorMainMenuRichBox);
            this.Controls.Add(this.tutorMainMenuLabel);
            this.Controls.Add(this.studentMainMenuRichBox);
            this.Controls.Add(this.studentMainMenuLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuForm";
            this.Text = "MenuForm";
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
        private System.Windows.Forms.Label studentMainMenuLabel;
        private System.Windows.Forms.RichTextBox studentMainMenuRichBox;
        private System.Windows.Forms.Label tutorMainMenuLabel;
        private System.Windows.Forms.RichTextBox tutorMainMenuRichBox;
        private System.Windows.Forms.Label reservedMainMenuLabel;
        private System.Windows.Forms.RichTextBox reservedMainMenuRichBox;
    }
}