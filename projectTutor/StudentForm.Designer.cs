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
            this.saveStudenFormButton = new System.Windows.Forms.Button();
            this.deleteStudentFormButton = new System.Windows.Forms.Button();
            this.startDateFormMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.nameStudentFormMaskedBox.BeepOnError = true;
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
            // saveStudenFormButton
            // 
            this.saveStudenFormButton.Location = new System.Drawing.Point(28, 412);
            this.saveStudenFormButton.Name = "saveStudenFormButton";
            this.saveStudenFormButton.Size = new System.Drawing.Size(75, 23);
            this.saveStudenFormButton.TabIndex = 8;
            this.saveStudenFormButton.Text = "SAVE";
            this.saveStudenFormButton.UseVisualStyleBackColor = true;
            this.saveStudenFormButton.Click += new System.EventHandler(this.saveStudenFormButton_Click);
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
            // startDateFormMaskedBox
            // 
            this.startDateFormMaskedBox.Location = new System.Drawing.Point(28, 209);
            this.startDateFormMaskedBox.Name = "startDateFormMaskedBox";
            this.startDateFormMaskedBox.Size = new System.Drawing.Size(100, 20);
            this.startDateFormMaskedBox.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(343, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(268, 282);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 467);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.startDateFormMaskedBox);
            this.Controls.Add(this.deleteStudentFormButton);
            this.Controls.Add(this.saveStudenFormButton);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button saveStudenFormButton;
        private System.Windows.Forms.Button deleteStudentFormButton;
        private System.Windows.Forms.MaskedTextBox startDateFormMaskedBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}