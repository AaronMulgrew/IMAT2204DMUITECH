namespace BackEnd
{
    partial class frmContactList
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
            this.lblSelectContact = new System.Windows.Forms.Label();
            this.CboEmail = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lblSelectContact
            // 
            this.lblSelectContact.AutoSize = true;
            this.lblSelectContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectContact.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSelectContact.Location = new System.Drawing.Point(108, 104);
            this.lblSelectContact.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSelectContact.Name = "lblSelectContact";
            this.lblSelectContact.Size = new System.Drawing.Size(571, 51);
            this.lblSelectContact.TabIndex = 1;
            this.lblSelectContact.Text = "Please Select Your Contacts";
            // 
            // CboEmail
            // 
            this.CboEmail.FormattingEnabled = true;
            this.CboEmail.Location = new System.Drawing.Point(117, 201);
            this.CboEmail.Name = "CboEmail";
            this.CboEmail.Size = new System.Drawing.Size(121, 33);
            this.CboEmail.TabIndex = 2;
            // 
            // frmContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(736, 774);
            this.Controls.Add(this.CboEmail);
            this.Controls.Add(this.lblSelectContact);
            this.Name = "frmContactList";
            this.Text = "frmContactList";
            this.Load += new System.EventHandler(this.frmContactList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectContact;
        private System.Windows.Forms.ComboBox CboEmail;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}