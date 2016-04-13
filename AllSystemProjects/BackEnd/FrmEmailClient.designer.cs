namespace BackEnd
{
    partial class FrmEmailClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmailClient));
            this.LstBxSavedSearch = new System.Windows.Forms.ListBox();
            this.btnProceed = new System.Windows.Forms.Button();
            this.btnCompose = new System.Windows.Forms.Button();
            this.buttonViewInbox = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblEmailClient = new System.Windows.Forms.Label();
            this.lblSavedSearches = new System.Windows.Forms.Label();
            this.btnViewArchive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstBxSavedSearch
            // 
            this.LstBxSavedSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(78)))), ((int)(((byte)(123)))));
            this.LstBxSavedSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LstBxSavedSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstBxSavedSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.LstBxSavedSearch.FormattingEnabled = true;
            this.LstBxSavedSearch.ItemHeight = 46;
            this.LstBxSavedSearch.Items.AddRange(new object[] {
            "Age(s) 20-20 Location Leicester",
            "Age(s) 45-50 Location Loughborough"});
            this.LstBxSavedSearch.Location = new System.Drawing.Point(989, 154);
            this.LstBxSavedSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.LstBxSavedSearch.Name = "LstBxSavedSearch";
            this.LstBxSavedSearch.Size = new System.Drawing.Size(917, 416);
            this.LstBxSavedSearch.TabIndex = 2;
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnProceed.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProceed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProceed.Location = new System.Drawing.Point(1640, 638);
            this.btnProceed.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(267, 62);
            this.btnProceed.TabIndex = 4;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // btnCompose
            // 
            this.btnCompose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnCompose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCompose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCompose.Location = new System.Drawing.Point(49, 479);
            this.btnCompose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCompose.Name = "btnCompose";
            this.btnCompose.Size = new System.Drawing.Size(583, 128);
            this.btnCompose.TabIndex = 5;
            this.btnCompose.Text = "Compose Individual Email";
            this.btnCompose.UseVisualStyleBackColor = false;
            this.btnCompose.Click += new System.EventHandler(this.btnCompose_Click);
            // 
            // buttonViewInbox
            // 
            this.buttonViewInbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.buttonViewInbox.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonViewInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewInbox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonViewInbox.Location = new System.Drawing.Point(49, 165);
            this.buttonViewInbox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonViewInbox.Name = "buttonViewInbox";
            this.buttonViewInbox.Size = new System.Drawing.Size(583, 128);
            this.buttonViewInbox.TabIndex = 6;
            this.buttonViewInbox.Text = "View Inbox";
            this.buttonViewInbox.UseVisualStyleBackColor = false;
            this.buttonViewInbox.Click += new System.EventHandler(this.buttonViewInbox_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.Location = new System.Drawing.Point(1324, 844);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(583, 128);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblError.Location = new System.Drawing.Point(84, 844);
            this.lblError.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 46);
            this.lblError.TabIndex = 8;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEdit.Location = new System.Drawing.Point(1324, 738);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(267, 62);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(1640, 738);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(267, 62);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Location = new System.Drawing.Point(989, 738);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(267, 62);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblEmailClient
            // 
            this.lblEmailClient.AutoSize = true;
            this.lblEmailClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblEmailClient.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEmailClient.Location = new System.Drawing.Point(39, 36);
            this.lblEmailClient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmailClient.Name = "lblEmailClient";
            this.lblEmailClient.Size = new System.Drawing.Size(467, 63);
            this.lblEmailClient.TabIndex = 12;
            this.lblEmailClient.Text = "Email Client Menu";
            // 
            // lblSavedSearches
            // 
            this.lblSavedSearches.AutoSize = true;
            this.lblSavedSearches.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblSavedSearches.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSavedSearches.Location = new System.Drawing.Point(979, 36);
            this.lblSavedSearches.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSavedSearches.Name = "lblSavedSearches";
            this.lblSavedSearches.Size = new System.Drawing.Size(422, 63);
            this.lblSavedSearches.TabIndex = 14;
            this.lblSavedSearches.Text = "Saved Searches";
            // 
            // btnViewArchive
            // 
            this.btnViewArchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.btnViewArchive.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnViewArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewArchive.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnViewArchive.Location = new System.Drawing.Point(49, 322);
            this.btnViewArchive.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnViewArchive.Name = "btnViewArchive";
            this.btnViewArchive.Size = new System.Drawing.Size(583, 128);
            this.btnViewArchive.TabIndex = 15;
            this.btnViewArchive.Text = "View Archive";
            this.btnViewArchive.UseVisualStyleBackColor = false;
            this.btnViewArchive.Click += new System.EventHandler(this.btnViewArchive_Click);
            // 
            // FrmEmailClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1971, 1055);
            this.Controls.Add(this.btnViewArchive);
            this.Controls.Add(this.lblSavedSearches);
            this.Controls.Add(this.lblEmailClient);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.buttonViewInbox);
            this.Controls.Add(this.btnCompose);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.LstBxSavedSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmEmailClient";
            this.Text = "Email Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstBxSavedSearch;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.Button btnCompose;
        private System.Windows.Forms.Button buttonViewInbox;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblEmailClient;
        private System.Windows.Forms.Label lblSavedSearches;
        private System.Windows.Forms.Button btnViewArchive;

    }
}