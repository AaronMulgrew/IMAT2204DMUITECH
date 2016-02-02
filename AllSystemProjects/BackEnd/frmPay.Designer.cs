namespace BackEnd
{
    partial class frmPay
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
            this.btnConfirmation = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblSortCode = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblSecurity = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtSortCode = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtSecurity = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            // btnConfirmation
            // 
            this.btnConfirmation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnConfirmation.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmation.Location = new System.Drawing.Point(16, 394);
            this.btnConfirmation.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmation.Name = "btnConfirmation";
            this.btnConfirmation.Size = new System.Drawing.Size(145, 39);
            this.btnConfirmation.TabIndex = 1;
            this.btnConfirmation.Text = "Confirmation";
            this.btnConfirmation.UseVisualStyleBackColor = false;
            this.btnConfirmation.Click += new System.EventHandler(this.btnConfirmation_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblType.Location = new System.Drawing.Point(16, 74);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(118, 26);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Card Type:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblName.Location = new System.Drawing.Point(16, 116);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(130, 26);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Card Name:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNumber.Location = new System.Drawing.Point(16, 152);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(149, 26);
            this.lblNumber.TabIndex = 4;
            this.lblNumber.Text = "Card Number:";
            // 
            // lblSortCode
            // 
            this.lblSortCode.AutoSize = true;
            this.lblSortCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblSortCode.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSortCode.Location = new System.Drawing.Point(16, 194);
            this.lblSortCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSortCode.Name = "lblSortCode";
            this.lblSortCode.Size = new System.Drawing.Size(116, 26);
            this.lblSortCode.TabIndex = 5;
            this.lblSortCode.Text = "Sort Code:";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblAccount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAccount.Location = new System.Drawing.Point(16, 238);
            this.lblAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(181, 26);
            this.lblAccount.TabIndex = 6;
            this.lblAccount.Text = "Account Number:";
            // 
            // lblSecurity
            // 
            this.lblSecurity.AutoSize = true;
            this.lblSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblSecurity.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSecurity.Location = new System.Drawing.Point(16, 280);
            this.lblSecurity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSecurity.Name = "lblSecurity";
            this.lblSecurity.Size = new System.Drawing.Size(155, 26);
            this.lblSecurity.TabIndex = 7;
            this.lblSecurity.Text = "Security Code:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(226, 116);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 20);
            this.txtName.TabIndex = 8;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(226, 155);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(173, 20);
            this.txtNumber.TabIndex = 9;
            // 
            // txtSortCode
            // 
            this.txtSortCode.Location = new System.Drawing.Point(226, 194);
            this.txtSortCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtSortCode.Name = "txtSortCode";
            this.txtSortCode.Size = new System.Drawing.Size(173, 20);
            this.txtSortCode.TabIndex = 10;
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(226, 244);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(2);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(173, 20);
            this.txtAccount.TabIndex = 11;
            // 
            // txtSecurity
            // 
            this.txtSecurity.Location = new System.Drawing.Point(226, 286);
            this.txtSecurity.Margin = new System.Windows.Forms.Padding(2);
            this.txtSecurity.Name = "txtSecurity";
            this.txtSecurity.Size = new System.Drawing.Size(173, 20);
            this.txtSecurity.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Visa",
            "Solo",
            "Mastercard"});
            this.comboBox1.Location = new System.Drawing.Point(226, 74);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // frmPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(527, 452);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtSecurity);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.txtSortCode);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSecurity);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblSortCode);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.btnConfirmation);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPay";
            this.Text = "Service Order Payment";
            this.Load += new System.EventHandler(this.frmPay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConfirmation;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblSortCode;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblSecurity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtSortCode;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtSecurity;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}