﻿namespace projectTutor
{
    partial class TutorForm
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
            this.components = new System.ComponentModel.Container();
            this.Save = new System.Windows.Forms.Button();
            this.UniqueID = new System.Windows.Forms.Button();
            this.TutorIdL = new System.Windows.Forms.Label();
            this.TutorNameL = new System.Windows.Forms.Label();
            this.TutorSL = new System.Windows.Forms.Label();
            this.TutorLevelL = new System.Windows.Forms.Label();
            this.TutorRateL = new System.Windows.Forms.Label();
            this.Availbitiy = new System.Windows.Forms.Label();
            this.DayL = new System.Windows.Forms.Label();
            this.AvailTimeL = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.MaskedTextBox();
            this.level = new System.Windows.Forms.NumericUpDown();
            this.TutorID = new System.Windows.Forms.NumericUpDown();
            this.TutorName = new System.Windows.Forms.TextBox();
            this.Day = new System.Windows.Forms.NumericUpDown();
            this.Time = new System.Windows.Forms.MaskedTextBox();
            this.Subjects = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.TutorIDC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TutorNameC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubjectsC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LevelC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HourlyRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.AvailIDL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DayofWeek = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TutorIDR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AvailIDLabel = new System.Windows.Forms.Label();
            this.AvailTutorIDL = new System.Windows.Forms.Label();
            this.AvailTutorID = new System.Windows.Forms.NumericUpDown();
            this.Delete = new System.Windows.Forms.Button();
            this.DeleteAvail = new System.Windows.Forms.Button();
            this.AvailID = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.level)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TutorID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvailTutorID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvailID)).BeginInit();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(12, 494);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 28);
            this.Save.TabIndex = 0;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // UniqueID
            // 
            this.UniqueID.Location = new System.Drawing.Point(292, 16);
            this.UniqueID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UniqueID.Name = "UniqueID";
            this.UniqueID.Size = new System.Drawing.Size(100, 28);
            this.UniqueID.TabIndex = 1;
            this.UniqueID.Text = "UniqueId";
            this.UniqueID.UseVisualStyleBackColor = true;
            this.UniqueID.Click += new System.EventHandler(this.UniqueID_Click);
            // 
            // TutorIdL
            // 
            this.TutorIdL.AutoSize = true;
            this.TutorIdL.Location = new System.Drawing.Point(16, 22);
            this.TutorIdL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TutorIdL.Name = "TutorIdL";
            this.TutorIdL.Size = new System.Drawing.Size(53, 17);
            this.TutorIdL.TabIndex = 2;
            this.TutorIdL.Text = "TutorId";
            // 
            // TutorNameL
            // 
            this.TutorNameL.AutoSize = true;
            this.TutorNameL.Location = new System.Drawing.Point(8, 74);
            this.TutorNameL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TutorNameL.Name = "TutorNameL";
            this.TutorNameL.Size = new System.Drawing.Size(79, 17);
            this.TutorNameL.TabIndex = 3;
            this.TutorNameL.Text = "TutorName";
            this.TutorNameL.Click += new System.EventHandler(this.label2_Click);
            // 
            // TutorSL
            // 
            this.TutorSL.AutoSize = true;
            this.TutorSL.Location = new System.Drawing.Point(16, 114);
            this.TutorSL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TutorSL.Name = "TutorSL";
            this.TutorSL.Size = new System.Drawing.Size(62, 17);
            this.TutorSL.TabIndex = 4;
            this.TutorSL.Text = "Subjects";
            // 
            // TutorLevelL
            // 
            this.TutorLevelL.AutoSize = true;
            this.TutorLevelL.Location = new System.Drawing.Point(16, 162);
            this.TutorLevelL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TutorLevelL.Name = "TutorLevelL";
            this.TutorLevelL.Size = new System.Drawing.Size(42, 17);
            this.TutorLevelL.TabIndex = 5;
            this.TutorLevelL.Text = "Level";
            // 
            // TutorRateL
            // 
            this.TutorRateL.AutoSize = true;
            this.TutorRateL.Location = new System.Drawing.Point(4, 220);
            this.TutorRateL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TutorRateL.Name = "TutorRateL";
            this.TutorRateL.Size = new System.Drawing.Size(83, 17);
            this.TutorRateL.TabIndex = 6;
            this.TutorRateL.Text = "Hourly Rate";
            // 
            // Availbitiy
            // 
            this.Availbitiy.AutoSize = true;
            this.Availbitiy.Location = new System.Drawing.Point(96, 282);
            this.Availbitiy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Availbitiy.Name = "Availbitiy";
            this.Availbitiy.Size = new System.Drawing.Size(69, 17);
            this.Availbitiy.TabIndex = 7;
            this.Availbitiy.Text = "Availibility";
            // 
            // DayL
            // 
            this.DayL.AutoSize = true;
            this.DayL.Location = new System.Drawing.Point(16, 347);
            this.DayL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DayL.Name = "DayL";
            this.DayL.Size = new System.Drawing.Size(33, 17);
            this.DayL.TabIndex = 8;
            this.DayL.Text = "Day";
            // 
            // AvailTimeL
            // 
            this.AvailTimeL.AutoSize = true;
            this.AvailTimeL.Location = new System.Drawing.Point(16, 405);
            this.AvailTimeL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AvailTimeL.Name = "AvailTimeL";
            this.AvailTimeL.Size = new System.Drawing.Size(39, 17);
            this.AvailTimeL.TabIndex = 9;
            this.AvailTimeL.Text = "Time";
            this.AvailTimeL.Click += new System.EventHandler(this.label8_Click);
            // 
            // rate
            // 
            this.rate.Location = new System.Drawing.Point(100, 217);
            this.rate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rate.Mask = "00.00";
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(132, 22);
            this.rate.TabIndex = 11;
            // 
            // level
            // 
            this.level.Location = new System.Drawing.Point(100, 162);
            this.level.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.level.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.level.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(160, 22);
            this.level.TabIndex = 12;
            this.level.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TutorID
            // 
            this.TutorID.Location = new System.Drawing.Point(100, 20);
            this.TutorID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TutorID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TutorID.Name = "TutorID";
            this.TutorID.Size = new System.Drawing.Size(160, 22);
            this.TutorID.TabIndex = 13;
            this.TutorID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TutorName
            // 
            this.TutorName.Location = new System.Drawing.Point(100, 70);
            this.TutorName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TutorName.Name = "TutorName";
            this.TutorName.Size = new System.Drawing.Size(159, 22);
            this.TutorName.TabIndex = 14;
            this.TutorName.Validating += new System.ComponentModel.CancelEventHandler(this.TutorName_Validating);
            // 
            // Day
            // 
            this.Day.Location = new System.Drawing.Point(100, 347);
            this.Day.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Day.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.Day.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(160, 22);
            this.Day.TabIndex = 15;
            this.Day.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(100, 405);
            this.Time.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Time.Mask = "90:00";
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(132, 22);
            this.Time.TabIndex = 16;
            this.Time.ValidatingType = typeof(System.DateTime);
            // 
            // Subjects
            // 
            this.Subjects.Location = new System.Drawing.Point(100, 111);
            this.Subjects.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Subjects.Name = "Subjects";
            this.Subjects.Size = new System.Drawing.Size(159, 22);
            this.Subjects.TabIndex = 18;
            this.Subjects.Validating += new System.ComponentModel.CancelEventHandler(this.Subjects_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TutorIDC,
            this.TutorNameC,
            this.SubjectsC,
            this.LevelC,
            this.HourlyRate});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(400, 16);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(571, 473);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            this.listView1.Leave += new System.EventHandler(this.listView1_Leave);
            // 
            // TutorIDC
            // 
            this.TutorIDC.Text = "TutorID";
            this.TutorIDC.Width = 50;
            // 
            // TutorNameC
            // 
            this.TutorNameC.Text = "Name";
            this.TutorNameC.Width = 140;
            // 
            // SubjectsC
            // 
            this.SubjectsC.Text = "Subjects";
            this.SubjectsC.Width = 120;
            // 
            // LevelC
            // 
            this.LevelC.Text = "Level";
            this.LevelC.Width = 50;
            // 
            // HourlyRate
            // 
            this.HourlyRate.Text = "Rate";
            this.HourlyRate.Width = 50;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AvailIDL,
            this.DayofWeek,
            this.TimeL,
            this.TutorIDR});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView2.Location = new System.Drawing.Point(1021, 15);
            this.listView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(420, 473);
            this.listView2.TabIndex = 20;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.Click += new System.EventHandler(this.listView2_Click);
            // 
            // AvailIDL
            // 
            this.AvailIDL.Text = "AvailID";
            // 
            // DayofWeek
            // 
            this.DayofWeek.Text = "DayofWeek";
            this.DayofWeek.Width = 88;
            // 
            // TimeL
            // 
            this.TimeL.Text = "Time";
            this.TimeL.Width = 100;
            // 
            // TutorIDR
            // 
            this.TutorIDR.Text = "TutorID";
            // 
            // AvailIDLabel
            // 
            this.AvailIDLabel.AutoSize = true;
            this.AvailIDLabel.Location = new System.Drawing.Point(-1, 304);
            this.AvailIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AvailIDLabel.Name = "AvailIDLabel";
            this.AvailIDLabel.Size = new System.Drawing.Size(91, 17);
            this.AvailIDLabel.TabIndex = 22;
            this.AvailIDLabel.Text = "Availability ID";
            this.AvailIDLabel.Click += new System.EventHandler(this.AvailIDLabel_Click);
            // 
            // AvailTutorIDL
            // 
            this.AvailTutorIDL.AutoSize = true;
            this.AvailTutorIDL.Location = new System.Drawing.Point(4, 454);
            this.AvailTutorIDL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AvailTutorIDL.Name = "AvailTutorIDL";
            this.AvailTutorIDL.Size = new System.Drawing.Size(95, 17);
            this.AvailTutorIDL.TabIndex = 24;
            this.AvailTutorIDL.Text = "TutorID(Avail)";
            // 
            // AvailTutorID
            // 
            this.AvailTutorID.Location = new System.Drawing.Point(100, 446);
            this.AvailTutorID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AvailTutorID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AvailTutorID.Name = "AvailTutorID";
            this.AvailTutorID.Size = new System.Drawing.Size(160, 22);
            this.AvailTutorID.TabIndex = 25;
            this.AvailTutorID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(133, 494);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(100, 28);
            this.Delete.TabIndex = 26;
            this.Delete.Text = "DeleteTutor";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // DeleteAvail
            // 
            this.DeleteAvail.Location = new System.Drawing.Point(241, 494);
            this.DeleteAvail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteAvail.Name = "DeleteAvail";
            this.DeleteAvail.Size = new System.Drawing.Size(151, 28);
            this.DeleteAvail.TabIndex = 27;
            this.DeleteAvail.Text = "Delete Availability";
            this.DeleteAvail.UseVisualStyleBackColor = true;
            this.DeleteAvail.Click += new System.EventHandler(this.DeleteAvail_Click);
            // 
            // AvailID
            // 
            this.AvailID.Location = new System.Drawing.Point(100, 304);
            this.AvailID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AvailID.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.AvailID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AvailID.Name = "AvailID";
            this.AvailID.Size = new System.Drawing.Size(160, 22);
            this.AvailID.TabIndex = 28;
            this.AvailID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TutorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 537);
            this.Controls.Add(this.AvailID);
            this.Controls.Add(this.DeleteAvail);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.AvailTutorID);
            this.Controls.Add(this.AvailTutorIDL);
            this.Controls.Add(this.AvailIDLabel);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Subjects);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.TutorName);
            this.Controls.Add(this.TutorID);
            this.Controls.Add(this.level);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.AvailTimeL);
            this.Controls.Add(this.DayL);
            this.Controls.Add(this.Availbitiy);
            this.Controls.Add(this.TutorRateL);
            this.Controls.Add(this.TutorLevelL);
            this.Controls.Add(this.TutorSL);
            this.Controls.Add(this.TutorNameL);
            this.Controls.Add(this.TutorIdL);
            this.Controls.Add(this.UniqueID);
            this.Controls.Add(this.Save);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TutorForm";
            this.Text = "TutorForm";
            this.Load += new System.EventHandler(this.Tutor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.level)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TutorID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvailTutorID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvailID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button UniqueID;
        private System.Windows.Forms.Label TutorIdL;
        private System.Windows.Forms.Label TutorNameL;
        private System.Windows.Forms.Label TutorSL;
        private System.Windows.Forms.Label TutorLevelL;
        private System.Windows.Forms.Label TutorRateL;
        private System.Windows.Forms.Label Availbitiy;
        private System.Windows.Forms.Label DayL;
        private System.Windows.Forms.Label AvailTimeL;
        private System.Windows.Forms.MaskedTextBox rate;
        private System.Windows.Forms.NumericUpDown level;
        private System.Windows.Forms.NumericUpDown TutorID;
        private System.Windows.Forms.TextBox TutorName;
        private System.Windows.Forms.NumericUpDown Day;
        private System.Windows.Forms.MaskedTextBox Time;
        private System.Windows.Forms.TextBox Subjects;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader TutorIDC;
        private System.Windows.Forms.ColumnHeader TutorNameC;
        private System.Windows.Forms.ColumnHeader SubjectsC;
        private System.Windows.Forms.ColumnHeader LevelC;
        private System.Windows.Forms.ColumnHeader HourlyRate;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader AvailIDL;
        private System.Windows.Forms.ColumnHeader DayofWeek;
        private System.Windows.Forms.ColumnHeader TimeL;
        private System.Windows.Forms.ColumnHeader TutorIDR;
        private System.Windows.Forms.Label AvailIDLabel;
        private System.Windows.Forms.NumericUpDown AvailTutorID;
        private System.Windows.Forms.Label AvailTutorIDL;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button DeleteAvail;
        private System.Windows.Forms.NumericUpDown AvailID;
    }

        #endregion
    }
