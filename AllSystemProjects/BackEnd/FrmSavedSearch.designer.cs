namespace BackEnd
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDwnAgeMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownAgeMax)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSavedSearch
            // 
            this.lblSavedSearch.AutoSize = true;
            this.lblSavedSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblSavedSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSavedSearch.Location = new System.Drawing.Point(121, 100);
            this.lblSavedSearch.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSavedSearch.Name = "lblSavedSearch";
            this.lblSavedSearch.Size = new System.Drawing.Size(365, 63);
            this.lblSavedSearch.TabIndex = 2;
            this.lblSavedSearch.Text = "Saved Search";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAge.Location = new System.Drawing.Point(145, 301);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(165, 63);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Ages:";
            // 
            // NumUpDwnAgeMin
            // 
            this.NumUpDwnAgeMin.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.NumUpDwnAgeMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.NumUpDwnAgeMin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.NumUpDwnAgeMin.Location = new System.Drawing.Point(360, 304);
            this.NumUpDwnAgeMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.NumUpDwnAgeMin.Size = new System.Drawing.Size(160, 68);
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
            this.NumUpDownAgeMax.Location = new System.Drawing.Point(805, 304);
            this.NumUpDownAgeMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.NumUpDownAgeMax.Size = new System.Drawing.Size(160, 68);
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
            this.lblAgeTo.Location = new System.Drawing.Point(589, 304);
            this.lblAgeTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAgeTo.Name = "lblAgeTo";
            this.lblAgeTo.Size = new System.Drawing.Size(90, 63);
            this.lblAgeTo.TabIndex = 6;
            this.lblAgeTo.Text = "To";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLocation.Location = new System.Drawing.Point(49, 439);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(247, 63);
            this.lblLocation.TabIndex = 7;
            this.lblLocation.Text = "Location:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(86, 4);
            // 
            // txtBxLocation
            // 
            this.txtBxLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.txtBxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxLocation.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtBxLocation.Location = new System.Drawing.Point(347, 439);
            this.txtBxLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBxLocation.Multiline = true;
            this.txtBxLocation.Name = "txtBxLocation";
            this.txtBxLocation.Size = new System.Drawing.Size(617, 56);
            this.txtBxLocation.TabIndex = 9;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirm.Location = new System.Drawing.Point(60, 860);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(583, 128);
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
            this.lblError.Location = new System.Drawing.Point(60, 770);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 63);
            this.lblError.TabIndex = 15;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(1256, 860);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(583, 128);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmSavedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1971, 1055);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnClose;
    }
}