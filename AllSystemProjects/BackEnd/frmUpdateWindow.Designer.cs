namespace Invoice
{
    partial class frmUpdateWindow
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
            this.comboBoxInvoiceName = new System.Windows.Forms.ComboBox();
            this.butttonOK = new System.Windows.Forms.Button();
            this.textBoxInvoiceDate = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxInvoiceNo = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelInvoiceDate = new System.Windows.Forms.Label();
            this.labelInvoiceName = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelInvoiceNo = new System.Windows.Forms.Label();
            this.labelCustomerInvoiceList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxInvoiceName
            // 
            this.comboBoxInvoiceName.FormattingEnabled = true;
            this.comboBoxInvoiceName.Items.AddRange(new object[] {
            "Sales",
            "Repairs"});
            this.comboBoxInvoiceName.Location = new System.Drawing.Point(205, 290);
            this.comboBoxInvoiceName.Name = "comboBoxInvoiceName";
            this.comboBoxInvoiceName.Size = new System.Drawing.Size(106, 21);
            this.comboBoxInvoiceName.TabIndex = 66;
            // 
            // butttonOK
            // 
            this.butttonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(102)))));
            this.butttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butttonOK.ForeColor = System.Drawing.SystemColors.Control;
            this.butttonOK.Location = new System.Drawing.Point(111, 377);
            this.butttonOK.Name = "butttonOK";
            this.butttonOK.Size = new System.Drawing.Size(124, 51);
            this.butttonOK.TabIndex = 65;
            this.butttonOK.Text = "OK";
            this.butttonOK.UseVisualStyleBackColor = false;
            this.butttonOK.Click += new System.EventHandler(this.butttonOK_Click);
            // 
            // textBoxInvoiceDate
            // 
            this.textBoxInvoiceDate.Location = new System.Drawing.Point(205, 329);
            this.textBoxInvoiceDate.Name = "textBoxInvoiceDate";
            this.textBoxInvoiceDate.Size = new System.Drawing.Size(106, 20);
            this.textBoxInvoiceDate.TabIndex = 64;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(205, 246);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(106, 20);
            this.textBoxAmount.TabIndex = 63;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(205, 210);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(106, 20);
            this.textBoxAddress.TabIndex = 62;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(205, 172);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(106, 20);
            this.textBoxLastName.TabIndex = 61;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(205, 134);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(106, 20);
            this.textBoxFirstName.TabIndex = 60;
            // 
            // textBoxInvoiceNo
            // 
            this.textBoxInvoiceNo.Enabled = false;
            this.textBoxInvoiceNo.Location = new System.Drawing.Point(205, 93);
            this.textBoxInvoiceNo.Name = "textBoxInvoiceNo";
            this.textBoxInvoiceNo.Size = new System.Drawing.Size(106, 20);
            this.textBoxInvoiceNo.TabIndex = 59;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAddress.Location = new System.Drawing.Point(38, 208);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(72, 20);
            this.labelAddress.TabIndex = 58;
            this.labelAddress.Text = "Address:";
            // 
            // labelInvoiceDate
            // 
            this.labelInvoiceDate.AutoSize = true;
            this.labelInvoiceDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelInvoiceDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelInvoiceDate.Location = new System.Drawing.Point(38, 329);
            this.labelInvoiceDate.Name = "labelInvoiceDate";
            this.labelInvoiceDate.Size = new System.Drawing.Size(102, 20);
            this.labelInvoiceDate.TabIndex = 57;
            this.labelInvoiceDate.Text = "Invoice Date:";
            // 
            // labelInvoiceName
            // 
            this.labelInvoiceName.AutoSize = true;
            this.labelInvoiceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelInvoiceName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelInvoiceName.Location = new System.Drawing.Point(38, 288);
            this.labelInvoiceName.Name = "labelInvoiceName";
            this.labelInvoiceName.Size = new System.Drawing.Size(109, 20);
            this.labelInvoiceName.TabIndex = 56;
            this.labelInvoiceName.Text = "Invoice Name:";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAmount.Location = new System.Drawing.Point(38, 246);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(69, 20);
            this.labelAmount.TabIndex = 55;
            this.labelAmount.Text = "Amount:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelLastName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLastName.Location = new System.Drawing.Point(38, 170);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(90, 20);
            this.labelLastName.TabIndex = 54;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFirstName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFirstName.Location = new System.Drawing.Point(38, 132);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(90, 20);
            this.labelFirstName.TabIndex = 53;
            this.labelFirstName.Text = "First Name:";
            // 
            // labelInvoiceNo
            // 
            this.labelInvoiceNo.AutoSize = true;
            this.labelInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelInvoiceNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelInvoiceNo.Location = new System.Drawing.Point(38, 93);
            this.labelInvoiceNo.Name = "labelInvoiceNo";
            this.labelInvoiceNo.Size = new System.Drawing.Size(87, 20);
            this.labelInvoiceNo.TabIndex = 52;
            this.labelInvoiceNo.Text = "Invoice No:";
            // 
            // labelCustomerInvoiceList
            // 
            this.labelCustomerInvoiceList.AutoSize = true;
            this.labelCustomerInvoiceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerInvoiceList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCustomerInvoiceList.Location = new System.Drawing.Point(82, 23);
            this.labelCustomerInvoiceList.Name = "labelCustomerInvoiceList";
            this.labelCustomerInvoiceList.Size = new System.Drawing.Size(192, 39);
            this.labelCustomerInvoiceList.TabIndex = 51;
            this.labelCustomerInvoiceList.Text = "Update List";
            // 
            // frmUpdateWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(354, 468);
            this.Controls.Add(this.comboBoxInvoiceName);
            this.Controls.Add(this.butttonOK);
            this.Controls.Add(this.textBoxInvoiceDate);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxInvoiceNo);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelInvoiceDate);
            this.Controls.Add(this.labelInvoiceName);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelInvoiceNo);
            this.Controls.Add(this.labelCustomerInvoiceList);
            this.Name = "frmUpdateWindow";
            this.Text = "UpdateWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxInvoiceName;
        private System.Windows.Forms.Button butttonOK;
        private System.Windows.Forms.TextBox textBoxInvoiceDate;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxInvoiceNo;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelInvoiceDate;
        private System.Windows.Forms.Label labelInvoiceName;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelInvoiceNo;
        private System.Windows.Forms.Label labelCustomerInvoiceList;
    }
}