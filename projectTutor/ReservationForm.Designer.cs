namespace projectTutor
{
    partial class ReservationForm
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
            this.btnBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmStuId = new System.Windows.Forms.Button();
            this.nStuId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nStuId)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(36, 334);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 23);
            this.btnBook.TabIndex = 0;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Id";
            // 
            // btnConfirmStuId
            // 
            this.btnConfirmStuId.Location = new System.Drawing.Point(243, 28);
            this.btnConfirmStuId.Name = "btnConfirmStuId";
            this.btnConfirmStuId.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmStuId.TabIndex = 3;
            this.btnConfirmStuId.Text = "Confirm";
            this.btnConfirmStuId.UseVisualStyleBackColor = true;
            this.btnConfirmStuId.Click += new System.EventHandler(this.btnConfirmStuId_Click);
            // 
            // nStuId
            // 
            this.nStuId.Location = new System.Drawing.Point(105, 31);
            this.nStuId.Name = "nStuId";
            this.nStuId.Size = new System.Drawing.Size(120, 20);
            this.nStuId.TabIndex = 4;
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 404);
            this.Controls.Add(this.nStuId);
            this.Controls.Add(this.btnConfirmStuId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBook);
            this.Name = "ReservationForm";
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this.nStuId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmStuId;
        private System.Windows.Forms.NumericUpDown nStuId;
    }
}

