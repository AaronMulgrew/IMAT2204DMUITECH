namespace BackEnd
{
    partial class frmAddOrder
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
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.lblServiceType = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.ddlServiceType = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.ddlDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ctrlTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ddlService = new System.Windows.Forms.ComboBox();
            this.lblAsterisk = new System.Windows.Forms.Label();
            this.btnExisting = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnMainMenu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMainMenu.Location = new System.Drawing.Point(16, 10);
            this.btnMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(90, 43);
            this.btnMainMenu.TabIndex = 0;
            this.btnMainMenu.Text = "Close";
            this.btnMainMenu.UseVisualStyleBackColor = false;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // lblServiceType
            // 
            this.lblServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblServiceType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblServiceType.Location = new System.Drawing.Point(16, 68);
            this.lblServiceType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServiceType.Name = "lblServiceType";
            this.lblServiceType.Size = new System.Drawing.Size(166, 26);
            this.lblServiceType.TabIndex = 3;
            this.lblServiceType.Text = "*Service Type:\r\n";
            // 
            // lblService
            // 
            this.lblService.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblService.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblService.Location = new System.Drawing.Point(16, 116);
            this.lblService.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(107, 35);
            this.lblService.TabIndex = 5;
            this.lblService.Text = "*Service:";
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
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "*Date:";
            // 
            // ddlServiceType
            // 
            this.ddlServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlServiceType.FormattingEnabled = true;
            this.ddlServiceType.Location = new System.Drawing.Point(204, 68);
            this.ddlServiceType.Margin = new System.Windows.Forms.Padding(2);
            this.ddlServiceType.Name = "ddlServiceType";
            this.ddlServiceType.Size = new System.Drawing.Size(173, 21);
            this.ddlServiceType.TabIndex = 13;
            this.ddlServiceType.SelectedIndexChanged += new System.EventHandler(this.ddlServiceType_SelectedIndexChanged);
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
            this.lblInfo.TabIndex = 18;
            this.lblInfo.Text = "Additional Info:";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(204, 164);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(2);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(299, 75);
            this.txtInfo.TabIndex = 19;
            // 
            // ddlDatePicker
            // 
            this.ddlDatePicker.CustomFormat = "\"\"";
            this.ddlDatePicker.Location = new System.Drawing.Point(204, 262);
            this.ddlDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.ddlDatePicker.Name = "ddlDatePicker";
            this.ddlDatePicker.Size = new System.Drawing.Size(173, 20);
            this.ddlDatePicker.TabIndex = 20;
            this.ddlDatePicker.ValueChanged += new System.EventHandler(this.ddlDatePicker_ValueChanged);
            // 
            // ctrlTimePicker
            // 
            this.ctrlTimePicker.AllowDrop = true;
            this.ctrlTimePicker.CustomFormat = "";
            this.ctrlTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ctrlTimePicker.Location = new System.Drawing.Point(204, 308);
            this.ctrlTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlTimePicker.Name = "ctrlTimePicker";
            this.ctrlTimePicker.ShowUpDown = true;
            this.ctrlTimePicker.Size = new System.Drawing.Size(173, 20);
            this.ctrlTimePicker.TabIndex = 21;
            this.ctrlTimePicker.ValueChanged += new System.EventHandler(this.ctrlTimePicker_ValueChanged);
            // 
            // ddlService
            // 
            this.ddlService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlService.FormattingEnabled = true;
            this.ddlService.Location = new System.Drawing.Point(204, 116);
            this.ddlService.Margin = new System.Windows.Forms.Padding(2);
            this.ddlService.Name = "ddlService";
            this.ddlService.Size = new System.Drawing.Size(173, 21);
            this.ddlService.TabIndex = 24;
            this.ddlService.SelectedIndexChanged += new System.EventHandler(this.ddlService_SelectedIndexChanged);
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
            this.lblAsterisk.TabIndex = 25;
            this.lblAsterisk.Text = "*Fields with asterisks are compulsory";
            // 
            // btnExisting
            // 
            this.btnExisting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnExisting.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnExisting.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExisting.Location = new System.Drawing.Point(16, 398);
            this.btnExisting.Margin = new System.Windows.Forms.Padding(2);
            this.btnExisting.Name = "btnExisting";
            this.btnExisting.Size = new System.Drawing.Size(111, 39);
            this.btnExisting.TabIndex = 26;
            this.btnExisting.Text = "Existing Customer";
            this.btnExisting.UseVisualStyleBackColor = false;
            this.btnExisting.Click += new System.EventHandler(this.btnExisting_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnNew.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNew.Location = new System.Drawing.Point(167, 398);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(99, 37);
            this.btnNew.TabIndex = 27;
            this.btnNew.Text = "New Customer";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            this.lblTime.TabIndex = 28;
            this.lblTime.Text = "*Time:";
            // 
            // frmAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(527, 452);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnExisting);
            this.Controls.Add(this.lblAsterisk);
            this.Controls.Add(this.ddlService);
            this.Controls.Add(this.ctrlTimePicker);
            this.Controls.Add(this.ddlDatePicker);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.ddlServiceType);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lblServiceType);
            this.Controls.Add(this.btnMainMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAddOrder";
            this.Text = "Create Service Order";
            this.Load += new System.EventHandler(this.frmAddOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label lblServiceType;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox ddlServiceType;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.DateTimePicker ddlDatePicker;
        private System.Windows.Forms.DateTimePicker ctrlTimePicker;
        private System.Windows.Forms.ComboBox ddlService;
        private System.Windows.Forms.Label lblAsterisk;
        private System.Windows.Forms.Button btnExisting;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblTime;
    }
}