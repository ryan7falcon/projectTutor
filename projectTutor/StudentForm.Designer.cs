namespace projectTutor
{
    partial class StudentForm
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
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameStudentFormLabel = new System.Windows.Forms.Label();
            this.programStudentFormLabel = new System.Windows.Forms.Label();
            this.startDateStudentFormLabel = new System.Windows.Forms.Label();
            this.nameStudentFormMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.programStudentFormMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveStudenFormButton = new System.Windows.Forms.Button();
            this.deleteStudentFormButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentToolStripMenuItem,
            this.tutorToolStripMenuItem,
            this.roomToolStripMenuItem,
            this.reservedToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(686, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // tutorToolStripMenuItem
            // 
            this.tutorToolStripMenuItem.Name = "tutorToolStripMenuItem";
            this.tutorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.tutorToolStripMenuItem.Text = "Tutor";
            // 
            // roomToolStripMenuItem
            // 
            this.roomToolStripMenuItem.Name = "roomToolStripMenuItem";
            this.roomToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.roomToolStripMenuItem.Text = "Room";
            // 
            // reservedToolStripMenuItem
            // 
            this.reservedToolStripMenuItem.Name = "reservedToolStripMenuItem";
            this.reservedToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.reservedToolStripMenuItem.Text = "Reserved";
            // 
            // nameStudentFormLabel
            // 
            this.nameStudentFormLabel.AutoSize = true;
            this.nameStudentFormLabel.Location = new System.Drawing.Point(24, 50);
            this.nameStudentFormLabel.Name = "nameStudentFormLabel";
            this.nameStudentFormLabel.Size = new System.Drawing.Size(35, 13);
            this.nameStudentFormLabel.TabIndex = 1;
            this.nameStudentFormLabel.Text = "Name";
            // 
            // programStudentFormLabel
            // 
            this.programStudentFormLabel.AutoSize = true;
            this.programStudentFormLabel.Location = new System.Drawing.Point(25, 120);
            this.programStudentFormLabel.Name = "programStudentFormLabel";
            this.programStudentFormLabel.Size = new System.Drawing.Size(46, 13);
            this.programStudentFormLabel.TabIndex = 2;
            this.programStudentFormLabel.Text = "Program";
            // 
            // startDateStudentFormLabel
            // 
            this.startDateStudentFormLabel.AutoSize = true;
            this.startDateStudentFormLabel.Location = new System.Drawing.Point(25, 193);
            this.startDateStudentFormLabel.Name = "startDateStudentFormLabel";
            this.startDateStudentFormLabel.Size = new System.Drawing.Size(55, 13);
            this.startDateStudentFormLabel.TabIndex = 3;
            this.startDateStudentFormLabel.Text = "Start Date";
            // 
            // nameStudentFormMaskedBox
            // 
            this.nameStudentFormMaskedBox.Location = new System.Drawing.Point(28, 66);
            this.nameStudentFormMaskedBox.Name = "nameStudentFormMaskedBox";
            this.nameStudentFormMaskedBox.Size = new System.Drawing.Size(100, 20);
            this.nameStudentFormMaskedBox.TabIndex = 4;
            // 
            // programStudentFormMaskedBox
            // 
            this.programStudentFormMaskedBox.Location = new System.Drawing.Point(28, 136);
            this.programStudentFormMaskedBox.Name = "programStudentFormMaskedBox";
            this.programStudentFormMaskedBox.Size = new System.Drawing.Size(100, 20);
            this.programStudentFormMaskedBox.TabIndex = 5;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(28, 215);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(382, 66);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(258, 311);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // saveStudenFormButton
            // 
            this.saveStudenFormButton.Location = new System.Drawing.Point(28, 412);
            this.saveStudenFormButton.Name = "saveStudenFormButton";
            this.saveStudenFormButton.Size = new System.Drawing.Size(75, 23);
            this.saveStudenFormButton.TabIndex = 8;
            this.saveStudenFormButton.Text = "SAVE";
            this.saveStudenFormButton.UseVisualStyleBackColor = true;
            // 
            // deleteStudentFormButton
            // 
            this.deleteStudentFormButton.Location = new System.Drawing.Point(159, 412);
            this.deleteStudentFormButton.Name = "deleteStudentFormButton";
            this.deleteStudentFormButton.Size = new System.Drawing.Size(75, 23);
            this.deleteStudentFormButton.TabIndex = 9;
            this.deleteStudentFormButton.Text = "DELETE";
            this.deleteStudentFormButton.UseVisualStyleBackColor = true;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 467);
            this.Controls.Add(this.deleteStudentFormButton);
            this.Controls.Add(this.saveStudenFormButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.programStudentFormMaskedBox);
            this.Controls.Add(this.nameStudentFormMaskedBox);
            this.Controls.Add(this.startDateStudentFormLabel);
            this.Controls.Add(this.programStudentFormLabel);
            this.Controls.Add(this.nameStudentFormLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservedToolStripMenuItem;
        private System.Windows.Forms.Label nameStudentFormLabel;
        private System.Windows.Forms.Label programStudentFormLabel;
        private System.Windows.Forms.Label startDateStudentFormLabel;
        private System.Windows.Forms.MaskedTextBox nameStudentFormMaskedBox;
        private System.Windows.Forms.MaskedTextBox programStudentFormMaskedBox;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button saveStudenFormButton;
        private System.Windows.Forms.Button deleteStudentFormButton;
    }
}