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
            this.roomBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dayBox = new System.Windows.Forms.ComboBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.roomListView = new System.Windows.Forms.ListView();
            this.savedButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Room Name";
            // 
            // roomBox
            // 
            this.roomBox.FormattingEnabled = true;
            this.roomBox.Location = new System.Drawing.Point(40, 79);
            this.roomBox.Margin = new System.Windows.Forms.Padding(4);
            this.roomBox.Name = "roomBox";
            this.roomBox.Size = new System.Drawing.Size(160, 24);
            this.roomBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Which Day?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "What time?";
            // 
            // dayBox
            // 
            this.dayBox.FormattingEnabled = true;
            this.dayBox.Location = new System.Drawing.Point(40, 169);
            this.dayBox.Margin = new System.Windows.Forms.Padding(4);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(164, 24);
            this.dayBox.TabIndex = 5;
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
            this.roomListView.Location = new System.Drawing.Point(311, 69);
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
            this.dateTimePicker.Location = new System.Drawing.Point(39, 257);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowUpDown = true;
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 12;
            //this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 582);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.savedButton);
            this.Controls.Add(this.roomListView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox roomBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox dayBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListView roomListView;
        private System.Windows.Forms.Button savedButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}