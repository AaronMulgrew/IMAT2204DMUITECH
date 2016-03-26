namespace BackEnd
{
    partial class frmConfirmation
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.lblEmailMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(16, 10);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 43);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.AutoSize = true;
            this.lblConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblConfirmation.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblConfirmation.Location = new System.Drawing.Point(16, 97);
            this.lblConfirmation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(470, 26);
            this.lblConfirmation.TabIndex = 1;
            this.lblConfirmation.Text = "The customer\'s Service Order has been placed.";
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblOrderNo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblOrderNo.Location = new System.Drawing.Point(16, 150);
            this.lblOrderNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(300, 26);
            this.lblOrderNo.TabIndex = 2;
            this.lblOrderNo.Text = "Service Order No: 122099201";
            // 
            // lblEmailMsg
            // 
            this.lblEmailMsg.AutoSize = true;
            this.lblEmailMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblEmailMsg.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEmailMsg.Location = new System.Drawing.Point(16, 207);
            this.lblEmailMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailMsg.Name = "lblEmailMsg";
            this.lblEmailMsg.Size = new System.Drawing.Size(492, 22);
            this.lblEmailMsg.TabIndex = 3;
            this.lblEmailMsg.Text = "An email confirmation has been sent to the customer\'s email.";
            this.lblEmailMsg.Click += new System.EventHandler(this.lblEmailMsg_Click);
            // 
            // frmConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(527, 452);
            this.Controls.Add(this.lblEmailMsg);
            this.Controls.Add(this.lblOrderNo);
            this.Controls.Add(this.lblConfirmation);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmConfirmation";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Confirmation";
            this.Load += new System.EventHandler(this.frmConfirmation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblConfirmation;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.Label lblEmailMsg;
    }
}