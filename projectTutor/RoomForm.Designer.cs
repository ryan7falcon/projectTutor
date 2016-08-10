namespace projectTutor
{
    partial class RoomForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.roomListView = new System.Windows.Forms.ListView();
            this.savedButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.roomBox = new System.Windows.Forms.MaskedTextBox();
            this.uniqueButton = new System.Windows.Forms.Button();
            this.dayBox = new System.Windows.Forms.ListBox();
            this.idBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Which Day?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 375);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "What time?";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(165, 463);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 28);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // roomListView
            // 
            this.roomListView.Location = new System.Drawing.Point(357, 59);
            this.roomListView.Name = "roomListView";
            this.roomListView.Size = new System.Drawing.Size(525, 422);
            this.roomListView.TabIndex = 0;
            this.roomListView.UseCompatibleStateImageBehavior = false;
            this.roomListView.View = System.Windows.Forms.View.List;
            this.roomListView.SelectedIndexChanged += new System.EventHandler(this.roomListView_SelectedIndexChanged);
            // 
            // savedButton
            // 
            this.savedButton.Location = new System.Drawing.Point(39, 463);
            this.savedButton.Margin = new System.Windows.Forms.Padding(4);
            this.savedButton.Name = "savedButton";
            this.savedButton.Size = new System.Drawing.Size(100, 28);
            this.savedButton.TabIndex = 11;
            this.savedButton.Text = "SAVE";
            this.savedButton.UseVisualStyleBackColor = true;
            this.savedButton.Click += new System.EventHandler(this.savedButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "hh:mm tt";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(40, 396);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 12;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // roomBox
            // 
            this.roomBox.Location = new System.Drawing.Point(39, 141);
            this.roomBox.Name = "roomBox";
            this.roomBox.Size = new System.Drawing.Size(165, 22);
            this.roomBox.TabIndex = 13;
            this.roomBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.roomBox_MaskInputRejected);
            // 
            // uniqueButton
            // 
            this.uniqueButton.Location = new System.Drawing.Point(213, 68);
            this.uniqueButton.Margin = new System.Windows.Forms.Padding(4);
            this.uniqueButton.Name = "uniqueButton";
            this.uniqueButton.Size = new System.Drawing.Size(137, 25);
            this.uniqueButton.TabIndex = 14;
            this.uniqueButton.Text = "Set Unique Id";
            this.uniqueButton.UseVisualStyleBackColor = true;
            this.uniqueButton.Click += new System.EventHandler(this.uniqueButton_Click);
            // 
            // dayBox
            // 
            this.dayBox.FormattingEnabled = true;
            this.dayBox.ItemHeight = 16;
            this.dayBox.Location = new System.Drawing.Point(40, 218);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(164, 84);
            this.dayBox.TabIndex = 15;
            this.dayBox.SelectedIndexChanged += new System.EventHandler(this.dayBox_SelectedIndexChanged_1);
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(41, 69);
            this.idBox.Mask = "00000";
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(165, 22);
            this.idBox.TabIndex = 16;
            this.idBox.ValidatingType = typeof(int);
            this.idBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.idBox_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Id";
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 582);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.uniqueButton);
            this.Controls.Add(this.roomBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.savedButton);
            this.Controls.Add(this.roomListView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListView roomListView;
        private System.Windows.Forms.Button savedButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.MaskedTextBox roomBox;
        private System.Windows.Forms.Button uniqueButton;
        private System.Windows.Forms.ListBox dayBox;
        private System.Windows.Forms.MaskedTextBox idBox;
        private System.Windows.Forms.Label label4;
    }
}