﻿namespace BackOffice
{
    partial class FrmComposeEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmComposeEmail));
            this.lblTo = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtBxTo = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtBxSubject = new System.Windows.Forms.TextBox();
            this.lblMainBody = new System.Windows.Forms.Label();
            this.txtBxMainBody = new System.Windows.Forms.TextBox();
            this.buttonAttachments = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.txtBxAttachmentPath = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTo.Location = new System.Drawing.Point(135, 170);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(64, 37);
            this.lblTo.TabIndex = 0;
            this.lblTo.Text = "To:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtBxTo
            // 
            this.txtBxTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxTo.Location = new System.Drawing.Point(292, 170);
            this.txtBxTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBxTo.Multiline = true;
            this.txtBxTo.Name = "txtBxTo";
            this.txtBxTo.Size = new System.Drawing.Size(1036, 86);
            this.txtBxTo.TabIndex = 3;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSubject.Location = new System.Drawing.Point(101, 292);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(132, 37);
            this.lblSubject.TabIndex = 4;
            this.lblSubject.Text = "Subject:";
            // 
            // txtBxSubject
            // 
            this.txtBxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxSubject.Location = new System.Drawing.Point(292, 292);
            this.txtBxSubject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBxSubject.Name = "txtBxSubject";
            this.txtBxSubject.Size = new System.Drawing.Size(1036, 44);
            this.txtBxSubject.TabIndex = 5;
            // 
            // lblMainBody
            // 
            this.lblMainBody.AutoSize = true;
            this.lblMainBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainBody.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMainBody.Location = new System.Drawing.Point(80, 358);
            this.lblMainBody.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMainBody.Name = "lblMainBody";
            this.lblMainBody.Size = new System.Drawing.Size(176, 37);
            this.lblMainBody.TabIndex = 6;
            this.lblMainBody.Text = "Main Body:";
            // 
            // txtBxMainBody
            // 
            this.txtBxMainBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxMainBody.Location = new System.Drawing.Point(292, 358);
            this.txtBxMainBody.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBxMainBody.Multiline = true;
            this.txtBxMainBody.Name = "txtBxMainBody";
            this.txtBxMainBody.Size = new System.Drawing.Size(1036, 166);
            this.txtBxMainBody.TabIndex = 7;
            // 
            // buttonAttachments
            // 
            this.buttonAttachments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.buttonAttachments.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAttachments.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonAttachments.Location = new System.Drawing.Point(13, 550);
            this.buttonAttachments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAttachments.Name = "buttonAttachments";
            this.buttonAttachments.Size = new System.Drawing.Size(254, 105);
            this.buttonAttachments.TabIndex = 9;
            this.buttonAttachments.Text = "Add Attachments";
            this.buttonAttachments.UseVisualStyleBackColor = false;
            this.buttonAttachments.Click += new System.EventHandler(this.buttonAttachments_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonSend.Location = new System.Drawing.Point(292, 756);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(284, 64);
            this.buttonSend.TabIndex = 10;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(113)))), ((int)(((byte)(152)))));
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonClose.Location = new System.Drawing.Point(1044, 756);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(284, 64);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMainTitle.Location = new System.Drawing.Point(85, 29);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(0, 40);
            this.lblMainTitle.TabIndex = 12;
            // 
            // txtBxAttachmentPath
            // 
            this.txtBxAttachmentPath.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtBxAttachmentPath.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtBxAttachmentPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBxAttachmentPath.Location = new System.Drawing.Point(292, 550);
            this.txtBxAttachmentPath.Multiline = true;
            this.txtBxAttachmentPath.Name = "txtBxAttachmentPath";
            this.txtBxAttachmentPath.ReadOnly = true;
            this.txtBxAttachmentPath.Size = new System.Drawing.Size(1036, 105);
            this.txtBxAttachmentPath.TabIndex = 13;
            this.txtBxAttachmentPath.TabStop = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblError.Location = new System.Drawing.Point(135, 674);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 40);
            this.lblError.TabIndex = 14;
            // 
            // FrmComposeEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(56)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1478, 844);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtBxAttachmentPath);
            this.Controls.Add(this.lblMainTitle);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonAttachments);
            this.Controls.Add(this.txtBxMainBody);
            this.Controls.Add(this.lblMainBody);
            this.Controls.Add(this.txtBxSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.txtBxTo);
            this.Controls.Add(this.lblTo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmComposeEmail";
            this.Text = "Compose Email";
            this.Load += new System.EventHandler(this.FrmComposeEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtBxTo;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtBxSubject;
        private System.Windows.Forms.Label lblMainBody;
        private System.Windows.Forms.TextBox txtBxMainBody;
        private System.Windows.Forms.Button buttonAttachments;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.TextBox txtBxAttachmentPath;
        private System.Windows.Forms.Label lblError;
    }
}