namespace BackEnd
{
    partial class frmEditUpdate
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
            this.btnContinue = new System.Windows.Forms.Button();
            this.ddlServiceType = new System.Windows.Forms.ComboBox();
            this.ddlService = new System.Windows.Forms.ComboBox();
            this.ddlDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ctrlTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.lblAsterisk = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblServiceType = new System.Windows.Forms.Label();
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
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnContinue.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnContinue.Location = new System.Drawing.Point(16, 398);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(2);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(111, 39);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // ddlServiceType
            // 
            this.ddlServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlServiceType.FormattingEnabled = true;
            this.ddlServiceType.Location = new System.Drawing.Point(204, 68);
            this.ddlServiceType.Margin = new System.Windows.Forms.Padding(2);
            this.ddlServiceType.Name = "ddlServiceType";
            this.ddlServiceType.Size = new System.Drawing.Size(173, 21);
            this.ddlServiceType.TabIndex = 9;
            this.ddlServiceType.SelectedIndexChanged += new System.EventHandler(this.ddlServiceType_SelectedIndexChanged);
            // 
            // ddlService
            // 
            this.ddlService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlService.FormattingEnabled = true;
            this.ddlService.Items.AddRange(new object[] {
            "Keyboard"});
            this.ddlService.Location = new System.Drawing.Point(204, 116);
            this.ddlService.Margin = new System.Windows.Forms.Padding(2);
            this.ddlService.Name = "ddlService";
            this.ddlService.Size = new System.Drawing.Size(173, 21);
            this.ddlService.TabIndex = 10;
            this.ddlService.SelectedIndexChanged += new System.EventHandler(this.ddlService_SelectedIndexChanged);
            // 
            // ddlDatePicker
            // 
            this.ddlDatePicker.Location = new System.Drawing.Point(204, 262);
            this.ddlDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.ddlDatePicker.Name = "ddlDatePicker";
            this.ddlDatePicker.Size = new System.Drawing.Size(173, 20);
            this.ddlDatePicker.TabIndex = 11;
            // 
            // ctrlTimePicker
            // 
            this.ctrlTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ctrlTimePicker.Location = new System.Drawing.Point(204, 308);
            this.ctrlTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlTimePicker.Name = "ctrlTimePicker";
            this.ctrlTimePicker.ShowUpDown = true;
            this.ctrlTimePicker.Size = new System.Drawing.Size(173, 20);
            this.ctrlTimePicker.TabIndex = 12;
            this.ctrlTimePicker.Value = new System.DateTime(2016, 1, 14, 13, 0, 0, 0);
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(204, 164);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(2);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(299, 75);
            this.txtInfo.TabIndex = 13;
            // 
            // lblAsterisk
            // 
            this.lblAsterisk.AutoSize = true;
            this.lblAsterisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAsterisk.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAsterisk.Location = new System.Drawing.Point(16, 359);
            this.lblAsterisk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAsterisk.Name = "lblAsterisk";
            this.lblAsterisk.Size = new System.Drawing.Size(267, 20);
            this.lblAsterisk.TabIndex = 7;
            this.lblAsterisk.Text = "*Fields with asterisks are compulsory";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTime.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTime.Location = new System.Drawing.Point(16, 308);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(75, 26);
            this.lblTime.TabIndex = 6;
            this.lblTime.Text = "*Time:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDate.Location = new System.Drawing.Point(16, 262);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(73, 26);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "*Date:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblInfo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblInfo.Location = new System.Drawing.Point(16, 164);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(156, 26);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "Additional Info:";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblService.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblService.Location = new System.Drawing.Point(16, 116);
            this.lblService.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(100, 26);
            this.lblService.TabIndex = 3;
            this.lblService.Text = "*Service:";
            // 
            // lblServiceType
            // 
            this.lblServiceType.AutoSize = true;
            this.lblServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblServiceType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblServiceType.Location = new System.Drawing.Point(16, 68);
            this.lblServiceType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(153, 26);
            this.lblServiceType.TabIndex = 2;
            this.lblServiceType.Text = "*Service Type:";
            // 
            // frmEditUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(527, 452);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.ctrlTimePicker);
            this.Controls.Add(this.ddlDatePicker);
            this.Controls.Add(this.ddlService);
            this.Controls.Add(this.ddlServiceType);
            this.Controls.Add(this.lblAsterisk);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblServiceType);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEditUpdate";
            this.Text = "Update Details";
            this.Load += new System.EventHandler(this.frmEditUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.ComboBox ddlServiceType;
        private System.Windows.Forms.ComboBox ddlService;
        private System.Windows.Forms.DateTimePicker ddlDatePicker;
        private System.Windows.Forms.DateTimePicker ctrlTimePicker;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label lblAsterisk;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblServiceType;
    }
}