namespace BackOffice
{
    partial class FrmSavedSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSavedSearch));
            this.lblSavedSearch = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.NumUpDwnAgeMin = new System.Windows.Forms.NumericUpDown();
            this.NumUpDownAgeMax = new System.Windows.Forms.NumericUpDown();
            this.lblAgeTo = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtBxLocation = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDwnAgeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownAgeMax)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSavedSearch
            // 
            this.lblSavedSearch.AutoSize = true;
            this.lblSavedSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblSavedSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSavedSearch.Location = new System.Drawing.Point(91, 80);
            this.lblSavedSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSavedSearch.Name = "lblSavedSearch";
            this.lblSavedSearch.Size = new System.Drawing.Size(270, 46);
            this.lblSavedSearch.TabIndex = 2;
            this.lblSavedSearch.Text = "Saved Search";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAge.Location = new System.Drawing.Point(109, 241);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(122, 46);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Ages:";
            // 
            // NumUpDwnAgeMin
            // 
            this.NumUpDwnAgeMin.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.NumUpDwnAgeMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.NumUpDwnAgeMin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NumUpDwnAgeMin.Location = new System.Drawing.Point(270, 243);
            this.NumUpDwnAgeMin.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.NumUpDwnAgeMin.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.NumUpDwnAgeMin.Name = "NumUpDwnAgeMin";
            this.NumUpDwnAgeMin.Size = new System.Drawing.Size(120, 53);
            this.NumUpDwnAgeMin.TabIndex = 4;
            this.NumUpDwnAgeMin.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // NumUpDownAgeMax
            // 
            this.NumUpDownAgeMax.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.NumUpDownAgeMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.NumUpDownAgeMax.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NumUpDownAgeMax.Location = new System.Drawing.Point(604, 243);
            this.NumUpDownAgeMax.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.NumUpDownAgeMax.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.NumUpDownAgeMax.Name = "NumUpDownAgeMax";
            this.NumUpDownAgeMax.Size = new System.Drawing.Size(120, 53);
            this.NumUpDownAgeMax.TabIndex = 5;
            this.NumUpDownAgeMax.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // lblAgeTo
            // 
            this.lblAgeTo.AutoSize = true;
            this.lblAgeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeTo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAgeTo.Location = new System.Drawing.Point(442, 243);
            this.lblAgeTo.Name = "lblAgeTo";
            this.lblAgeTo.Size = new System.Drawing.Size(67, 46);
            this.lblAgeTo.TabIndex = 6;
            this.lblAgeTo.Text = "To";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLocation.Location = new System.Drawing.Point(37, 351);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(184, 46);
            this.lblLocation.TabIndex = 7;
            this.lblLocation.Text = "Location:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtBxLocation
            // 
            this.txtBxLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.txtBxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxLocation.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBxLocation.Location = new System.Drawing.Point(260, 351);
            this.txtBxLocation.Multiline = true;
            this.txtBxLocation.Name = "txtBxLocation";
            this.txtBxLocation.Size = new System.Drawing.Size(464, 46);
            this.txtBxLocation.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(942, 688);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(437, 102);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirm.Location = new System.Drawing.Point(45, 688);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(437, 102);
            this.btnConfirm.TabIndex = 14;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblError.Location = new System.Drawing.Point(45, 616);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 46);
            this.lblError.TabIndex = 15;
            // 
            // FrmSavedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1478, 844);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtBxLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblAgeTo);
            this.Controls.Add(this.NumUpDownAgeMax);
            this.Controls.Add(this.NumUpDwnAgeMin);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblSavedSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSavedSearch";
            this.Text = "FrmSavedSearch";
            this.Load += new System.EventHandler(this.FrmSavedSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDwnAgeMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownAgeMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSavedSearch;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.NumericUpDown NumUpDwnAgeMin;
        private System.Windows.Forms.NumericUpDown NumUpDownAgeMax;
        private System.Windows.Forms.Label lblAgeTo;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtBxLocation;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblError;
    }
}