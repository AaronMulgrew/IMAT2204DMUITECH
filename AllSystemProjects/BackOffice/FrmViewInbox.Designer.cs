namespace BackOffice
{
    partial class FrmViewInbox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewInbox));
            this.dataGridViewInbox = new System.Windows.Forms.DataGridView();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateSent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInbox = new System.Windows.Forms.Label();
            this.btnShowMoreEmails = new System.Windows.Forms.Button();
            this.btnViewEmail = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnArchiveEmail = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblLoading = new System.Windows.Forms.Label();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.picBxSpinning = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxSpinning)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewInbox
            // 
            this.dataGridViewInbox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInbox.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewInbox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.dataGridViewInbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInbox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.From,
            this.Subject,
            this.DateSent});
            this.dataGridViewInbox.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.dataGridViewInbox.Location = new System.Drawing.Point(96, 82);
            this.dataGridViewInbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewInbox.Name = "dataGridViewInbox";
            this.dataGridViewInbox.Size = new System.Drawing.Size(1196, 305);
            this.dataGridViewInbox.TabIndex = 0;
            // 
            // From
            // 
            this.From.HeaderText = "From";
            this.From.Name = "From";
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            // 
            // DateSent
            // 
            this.DateSent.HeaderText = "DateSent";
            this.DateSent.Name = "DateSent";
            // 
            // lblInbox
            // 
            this.lblInbox.AutoSize = true;
            this.lblInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInbox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblInbox.Location = new System.Drawing.Point(96, 20);
            this.lblInbox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInbox.Name = "lblInbox";
            this.lblInbox.Size = new System.Drawing.Size(104, 40);
            this.lblInbox.TabIndex = 1;
            this.lblInbox.Text = "Inbox";
            // 
            // btnShowMoreEmails
            // 
            this.btnShowMoreEmails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnShowMoreEmails.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnShowMoreEmails.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowMoreEmails.Location = new System.Drawing.Point(583, 410);
            this.btnShowMoreEmails.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnShowMoreEmails.Name = "btnShowMoreEmails";
            this.btnShowMoreEmails.Size = new System.Drawing.Size(300, 100);
            this.btnShowMoreEmails.TabIndex = 2;
            this.btnShowMoreEmails.Text = "Show More Emails";
            this.btnShowMoreEmails.UseVisualStyleBackColor = false;
            this.btnShowMoreEmails.Click += new System.EventHandler(this.btnShowMoreEmails_Click);
            // 
            // btnViewEmail
            // 
            this.btnViewEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnViewEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnViewEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewEmail.Location = new System.Drawing.Point(103, 410);
            this.btnViewEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewEmail.Name = "btnViewEmail";
            this.btnViewEmail.Size = new System.Drawing.Size(300, 100);
            this.btnViewEmail.TabIndex = 3;
            this.btnViewEmail.Text = "View Email";
            this.btnViewEmail.UseVisualStyleBackColor = false;
            this.btnViewEmail.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(992, 541);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(300, 100);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnArchiveEmail
            // 
            this.btnArchiveEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnArchiveEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnArchiveEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnArchiveEmail.Location = new System.Drawing.Point(992, 410);
            this.btnArchiveEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnArchiveEmail.Name = "btnArchiveEmail";
            this.btnArchiveEmail.Size = new System.Drawing.Size(300, 100);
            this.btnArchiveEmail.TabIndex = 5;
            this.btnArchiveEmail.Text = "Archive Email";
            this.btnArchiveEmail.UseVisualStyleBackColor = false;
            this.btnArchiveEmail.Click += new System.EventHandler(this.btnDeleteEmail_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblError.Location = new System.Drawing.Point(96, 573);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 37);
            this.lblError.TabIndex = 6;
            // 
            // lblLoading
            // 
            this.lblLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Transparent;
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.White;
            this.lblLoading.Location = new System.Drawing.Point(40, 20);
            this.lblLoading.MinimumSize = new System.Drawing.Size(1400, 700);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(1400, 700);
            this.lblLoading.TabIndex = 7;
            this.lblLoading.Text = "Just Loading...";
            // 
            // timerLoading
            // 
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // picBxSpinning
            // 
            this.picBxSpinning.Image = global::BackOffice.Properties.Resources.spinninggif2;
            this.picBxSpinning.Location = new System.Drawing.Point(275, 202);
            this.picBxSpinning.Name = "picBxSpinning";
            this.picBxSpinning.Size = new System.Drawing.Size(664, 454);
            this.picBxSpinning.TabIndex = 8;
            this.picBxSpinning.TabStop = false;
            // 
            // FrmViewInbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1478, 844);
            this.Controls.Add(this.picBxSpinning);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnArchiveEmail);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnViewEmail);
            this.Controls.Add(this.btnShowMoreEmails);
            this.Controls.Add(this.lblInbox);
            this.Controls.Add(this.dataGridViewInbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmViewInbox";
            this.Text = "FrmViewInbox";
            this.Load += new System.EventHandler(this.FrmViewInbox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxSpinning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewInbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateSent;
        private System.Windows.Forms.Label lblInbox;
        private System.Windows.Forms.Button btnShowMoreEmails;
        private System.Windows.Forms.Button btnViewEmail;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnArchiveEmail;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.PictureBox picBxSpinning;
    }
}