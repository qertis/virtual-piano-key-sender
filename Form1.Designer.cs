namespace KeySender
{
    partial class Form1
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
            this.btnOk = new System.Windows.Forms.Button();
            this.listBoxSpeed = new System.Windows.Forms.ListBox();
            this.linkLabelUrl = new System.Windows.Forms.LinkLabel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.AutoSize = true;
            this.btnOk.Location = new System.Drawing.Point(161, 231);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(113, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Начать!";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxSpeed
            // 
            this.listBoxSpeed.FormattingEnabled = true;
            this.listBoxSpeed.Items.AddRange(new object[] {
            "VeryFast",
            "Fast",
            "Medium",
            "Slow",
            "VerySlow"});
            this.listBoxSpeed.Location = new System.Drawing.Point(12, 30);
            this.listBoxSpeed.Name = "listBoxSpeed";
            this.listBoxSpeed.Size = new System.Drawing.Size(60, 69);
            this.listBoxSpeed.TabIndex = 2;
            // 
            // linkLabelUrl
            // 
            this.linkLabelUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelUrl.AutoSize = true;
            this.linkLabelUrl.Location = new System.Drawing.Point(13, 236);
            this.linkLabelUrl.Name = "linkLabelUrl";
            this.linkLabelUrl.Size = new System.Drawing.Size(142, 13);
            this.linkLabelUrl.TabIndex = 3;
            this.linkLabelUrl.TabStop = true;
            this.linkLabelUrl.Text = "http://www.virtualpiano.net/";
            this.linkLabelUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.DetectUrls = false;
            this.richTextBox.Location = new System.Drawing.Point(79, 12);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(195, 207);
            this.richTextBox.TabIndex = 4;
            this.richTextBox.Text = "";
            this.richTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseClick);
            this.richTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(12, 9);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(55, 13);
            this.labelSpeed.TabIndex = 5;
            this.labelSpeed.Text = "Скорость";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.linkLabelUrl);
            this.Controls.Add(this.listBoxSpeed);
            this.Controls.Add(this.btnOk);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "Form1";
            this.Text = "virtualpiano.net Automatic";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ListBox listBoxSpeed;
        private System.Windows.Forms.LinkLabel linkLabelUrl;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label labelSpeed;
    }
}

