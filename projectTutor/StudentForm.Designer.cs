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
            this.nameStudentFormLabel = new System.Windows.Forms.Label();
            this.programStudentFormLabel = new System.Windows.Forms.Label();
            this.startDateStudentFormLabel = new System.Windows.Forms.Label();
            this.nameStudentFormMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.programStudentFormMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.saveStudenFormButton = new System.Windows.Forms.Button();
            this.deleteStudentFormButton = new System.Windows.Forms.Button();
            this.startDateFormMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.studentListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // nameStudentFormLabel
            // 
            this.nameStudentFormLabel.AutoSize = true;
            this.nameStudentFormLabel.Location = new System.Drawing.Point(32, 62);
            this.nameStudentFormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameStudentFormLabel.Name = "nameStudentFormLabel";
            this.nameStudentFormLabel.Size = new System.Drawing.Size(45, 17);
            this.nameStudentFormLabel.TabIndex = 1;
            this.nameStudentFormLabel.Text = "Name";
            // 
            // programStudentFormLabel
            // 
            this.programStudentFormLabel.AutoSize = true;
            this.programStudentFormLabel.Location = new System.Drawing.Point(33, 148);
            this.programStudentFormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.programStudentFormLabel.Name = "programStudentFormLabel";
            this.programStudentFormLabel.Size = new System.Drawing.Size(62, 17);
            this.programStudentFormLabel.TabIndex = 2;
            this.programStudentFormLabel.Text = "Program";
            // 
            // startDateStudentFormLabel
            // 
            this.startDateStudentFormLabel.AutoSize = true;
            this.startDateStudentFormLabel.Location = new System.Drawing.Point(33, 238);
            this.startDateStudentFormLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startDateStudentFormLabel.Name = "startDateStudentFormLabel";
            this.startDateStudentFormLabel.Size = new System.Drawing.Size(72, 17);
            this.startDateStudentFormLabel.TabIndex = 3;
            this.startDateStudentFormLabel.Text = "Start Date";
            // 
            // nameStudentFormMaskedBox
            // 
            this.nameStudentFormMaskedBox.BeepOnError = true;
            this.nameStudentFormMaskedBox.Location = new System.Drawing.Point(37, 81);
            this.nameStudentFormMaskedBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameStudentFormMaskedBox.Name = "nameStudentFormMaskedBox";
            this.nameStudentFormMaskedBox.Size = new System.Drawing.Size(132, 22);
            this.nameStudentFormMaskedBox.TabIndex = 4;
            this.nameStudentFormMaskedBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.nameStudentFormMaskedBox_MaskInputRejected);
            // 
            // programStudentFormMaskedBox
            // 
            this.programStudentFormMaskedBox.Location = new System.Drawing.Point(37, 167);
            this.programStudentFormMaskedBox.Margin = new System.Windows.Forms.Padding(4);
            this.programStudentFormMaskedBox.Name = "programStudentFormMaskedBox";
            this.programStudentFormMaskedBox.Size = new System.Drawing.Size(132, 22);
            this.programStudentFormMaskedBox.TabIndex = 5;
            // 
            // saveStudenFormButton
            // 
            this.saveStudenFormButton.Location = new System.Drawing.Point(37, 507);
            this.saveStudenFormButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveStudenFormButton.Name = "saveStudenFormButton";
            this.saveStudenFormButton.Size = new System.Drawing.Size(100, 28);
            this.saveStudenFormButton.TabIndex = 8;
            this.saveStudenFormButton.Text = "SAVE";
            this.saveStudenFormButton.UseVisualStyleBackColor = true;
            this.saveStudenFormButton.Click += new System.EventHandler(this.saveStudenFormButton_Click);
            // 
            // deleteStudentFormButton
            // 
            this.deleteStudentFormButton.Location = new System.Drawing.Point(212, 507);
            this.deleteStudentFormButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteStudentFormButton.Name = "deleteStudentFormButton";
            this.deleteStudentFormButton.Size = new System.Drawing.Size(100, 28);
            this.deleteStudentFormButton.TabIndex = 9;
            this.deleteStudentFormButton.Text = "DELETE";
            this.deleteStudentFormButton.UseVisualStyleBackColor = true;
            this.deleteStudentFormButton.Click += new System.EventHandler(this.deleteStudentFormButton_Click);
            // 
            // startDateFormMaskedBox
            // 
            this.startDateFormMaskedBox.Location = new System.Drawing.Point(37, 257);
            this.startDateFormMaskedBox.Margin = new System.Windows.Forms.Padding(4);
            this.startDateFormMaskedBox.Name = "startDateFormMaskedBox";
            this.startDateFormMaskedBox.Size = new System.Drawing.Size(132, 22);
            this.startDateFormMaskedBox.TabIndex = 10;
            // 
            // studentListView
            // 
            this.studentListView.FullRowSelect = true;
            this.studentListView.GridLines = true;
            this.studentListView.Location = new System.Drawing.Point(355, 81);
            this.studentListView.Margin = new System.Windows.Forms.Padding(4);
            this.studentListView.Name = "studentListView";
            this.studentListView.Size = new System.Drawing.Size(476, 315);
            this.studentListView.TabIndex = 0;
            this.studentListView.UseCompatibleStateImageBehavior = false;
            this.studentListView.View = System.Windows.Forms.View.List;
            this.studentListView.SelectedIndexChanged += new System.EventHandler(this.studentListView_SelectedIndexChanged);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 575);
            this.Controls.Add(this.studentListView);
            this.Controls.Add(this.startDateFormMaskedBox);
            this.Controls.Add(this.deleteStudentFormButton);
            this.Controls.Add(this.saveStudenFormButton);
            this.Controls.Add(this.programStudentFormMaskedBox);
            this.Controls.Add(this.nameStudentFormMaskedBox);
            this.Controls.Add(this.startDateStudentFormLabel);
            this.Controls.Add(this.programStudentFormLabel);
            this.Controls.Add(this.nameStudentFormLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameStudentFormLabel;
        private System.Windows.Forms.Label programStudentFormLabel;
        private System.Windows.Forms.Label startDateStudentFormLabel;
        private System.Windows.Forms.MaskedTextBox nameStudentFormMaskedBox;
        private System.Windows.Forms.MaskedTextBox programStudentFormMaskedBox;
        private System.Windows.Forms.Button saveStudenFormButton;
        private System.Windows.Forms.Button deleteStudentFormButton;
        private System.Windows.Forms.MaskedTextBox startDateFormMaskedBox;
        private System.Windows.Forms.ListView studentListView;
    }
}