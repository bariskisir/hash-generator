namespace hash_generator
{
    partial class frmMain
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
            this.txtString = new System.Windows.Forms.TextBox();
            this.btnGenerateHash = new System.Windows.Forms.Button();
            this.lblMd5 = new System.Windows.Forms.Label();
            this.txtMd5 = new System.Windows.Forms.TextBox();
            this.lblSha1 = new System.Windows.Forms.Label();
            this.txtSha1 = new System.Windows.Forms.TextBox();
            this.lblSha256 = new System.Windows.Forms.Label();
            this.txtSha256 = new System.Windows.Forms.TextBox();
            this.lblSha384 = new System.Windows.Forms.Label();
            this.txtSha384 = new System.Windows.Forms.TextBox();
            this.lblSha512 = new System.Windows.Forms.Label();
            this.txtSha512 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(12, 12);
            this.txtString.Multiline = true;
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(260, 100);
            this.txtString.TabIndex = 0;
            // 
            // btnGenerateHash
            // 
            this.btnGenerateHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGenerateHash.Location = new System.Drawing.Point(12, 118);
            this.btnGenerateHash.Name = "btnGenerateHash";
            this.btnGenerateHash.Size = new System.Drawing.Size(260, 50);
            this.btnGenerateHash.TabIndex = 1;
            this.btnGenerateHash.Text = "Generate Hash";
            this.btnGenerateHash.UseVisualStyleBackColor = true;
            this.btnGenerateHash.Click += new System.EventHandler(this.btnGenerateHash_Click);
            // 
            // lblMd5
            // 
            this.lblMd5.AutoSize = true;
            this.lblMd5.Location = new System.Drawing.Point(9, 171);
            this.lblMd5.Name = "lblMd5";
            this.lblMd5.Size = new System.Drawing.Size(30, 13);
            this.lblMd5.TabIndex = 2;
            this.lblMd5.Text = "MD5";
            // 
            // txtMd5
            // 
            this.txtMd5.Location = new System.Drawing.Point(12, 187);
            this.txtMd5.Name = "txtMd5";
            this.txtMd5.ReadOnly = true;
            this.txtMd5.Size = new System.Drawing.Size(257, 20);
            this.txtMd5.TabIndex = 3;
            this.txtMd5.Click += new System.EventHandler(this.txtMd5_Click);
            // 
            // lblSha1
            // 
            this.lblSha1.AutoSize = true;
            this.lblSha1.Location = new System.Drawing.Point(9, 210);
            this.lblSha1.Name = "lblSha1";
            this.lblSha1.Size = new System.Drawing.Size(35, 13);
            this.lblSha1.TabIndex = 2;
            this.lblSha1.Text = "SHA1";
            // 
            // txtSha1
            // 
            this.txtSha1.Location = new System.Drawing.Point(12, 226);
            this.txtSha1.Name = "txtSha1";
            this.txtSha1.ReadOnly = true;
            this.txtSha1.Size = new System.Drawing.Size(257, 20);
            this.txtSha1.TabIndex = 3;
            this.txtSha1.Click += new System.EventHandler(this.txtSha1_Click);
            // 
            // lblSha256
            // 
            this.lblSha256.AutoSize = true;
            this.lblSha256.Location = new System.Drawing.Point(9, 249);
            this.lblSha256.Name = "lblSha256";
            this.lblSha256.Size = new System.Drawing.Size(47, 13);
            this.lblSha256.TabIndex = 2;
            this.lblSha256.Text = "SHA256";
            // 
            // txtSha256
            // 
            this.txtSha256.Location = new System.Drawing.Point(12, 265);
            this.txtSha256.Name = "txtSha256";
            this.txtSha256.ReadOnly = true;
            this.txtSha256.Size = new System.Drawing.Size(257, 20);
            this.txtSha256.TabIndex = 3;
            this.txtSha256.Click += new System.EventHandler(this.txtSha256_Click);
            // 
            // lblSha384
            // 
            this.lblSha384.AutoSize = true;
            this.lblSha384.Location = new System.Drawing.Point(9, 288);
            this.lblSha384.Name = "lblSha384";
            this.lblSha384.Size = new System.Drawing.Size(47, 13);
            this.lblSha384.TabIndex = 2;
            this.lblSha384.Text = "SHA384";
            // 
            // txtSha384
            // 
            this.txtSha384.Location = new System.Drawing.Point(12, 304);
            this.txtSha384.Name = "txtSha384";
            this.txtSha384.ReadOnly = true;
            this.txtSha384.Size = new System.Drawing.Size(257, 20);
            this.txtSha384.TabIndex = 3;
            this.txtSha384.Click += new System.EventHandler(this.txtSha384_Click);
            // 
            // lblSha512
            // 
            this.lblSha512.AutoSize = true;
            this.lblSha512.Location = new System.Drawing.Point(9, 327);
            this.lblSha512.Name = "lblSha512";
            this.lblSha512.Size = new System.Drawing.Size(47, 13);
            this.lblSha512.TabIndex = 2;
            this.lblSha512.Text = "SHA512";
            // 
            // txtSha512
            // 
            this.txtSha512.Location = new System.Drawing.Point(12, 343);
            this.txtSha512.Name = "txtSha512";
            this.txtSha512.ReadOnly = true;
            this.txtSha512.Size = new System.Drawing.Size(257, 20);
            this.txtSha512.TabIndex = 3;
            this.txtSha512.Click += new System.EventHandler(this.txtSha512_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 371);
            this.Controls.Add(this.txtSha512);
            this.Controls.Add(this.txtSha384);
            this.Controls.Add(this.txtSha256);
            this.Controls.Add(this.txtSha1);
            this.Controls.Add(this.txtMd5);
            this.Controls.Add(this.lblSha512);
            this.Controls.Add(this.lblSha384);
            this.Controls.Add(this.lblSha256);
            this.Controls.Add(this.lblSha1);
            this.Controls.Add(this.lblMd5);
            this.Controls.Add(this.btnGenerateHash);
            this.Controls.Add(this.txtString);
            this.Name = "frmMain";
            this.Text = "Hash Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Button btnGenerateHash;
        private System.Windows.Forms.Label lblMd5;
        private System.Windows.Forms.TextBox txtMd5;
        private System.Windows.Forms.Label lblSha1;
        private System.Windows.Forms.TextBox txtSha1;
        private System.Windows.Forms.Label lblSha256;
        private System.Windows.Forms.TextBox txtSha256;
        private System.Windows.Forms.Label lblSha384;
        private System.Windows.Forms.TextBox txtSha384;
        private System.Windows.Forms.Label lblSha512;
        private System.Windows.Forms.TextBox txtSha512;
    }
}

