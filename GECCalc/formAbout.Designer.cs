namespace GECCalc
{
    partial class formAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAbout));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAboutHeader = new System.Windows.Forms.Label();
            this.linklblMailTo = new System.Windows.Forms.LinkLabel();
            this.lblText = new System.Windows.Forms.Label();
            this.lblLicense = new System.Windows.Forms.Label();
            this.linklblLicense = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GECCalc.Properties.Resources.StartScreen;
            this.pictureBox1.Location = new System.Drawing.Point(12, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(0, 20);
            this.Label1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(10, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 24);
            this.label3.TabIndex = 93;
            this.label3.Text = "Structural calculation of geo encased sand columns acc. to EBGEO 2. edition.\r\nDev" +
    "eloped by Simon Schonhöft M.Eng.";
            // 
            // lblAboutHeader
            // 
            this.lblAboutHeader.AutoSize = true;
            this.lblAboutHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutHeader.Location = new System.Drawing.Point(18, 9);
            this.lblAboutHeader.Name = "lblAboutHeader";
            this.lblAboutHeader.Size = new System.Drawing.Size(198, 20);
            this.lblAboutHeader.TabIndex = 94;
            this.lblAboutHeader.Text = "G.E.C. Calc Version 1.1";
            // 
            // linklblMailTo
            // 
            this.linklblMailTo.AutoSize = true;
            this.linklblMailTo.Location = new System.Drawing.Point(9, 322);
            this.linklblMailTo.Name = "linklblMailTo";
            this.linklblMailTo.Size = new System.Drawing.Size(95, 13);
            this.linklblMailTo.TabIndex = 95;
            this.linklblMailTo.TabStop = true;
            this.linklblMailTo.Text = "GECCalc@gmx.de";
            this.linklblMailTo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(9, 287);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(378, 26);
            this.lblText.TabIndex = 96;
            this.lblText.Text = "Thank you for choosing G.E.C. Calc. If you have any questions or suggestions,\r\npl" +
    "ease send us an email at:";
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Location = new System.Drawing.Point(9, 352);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(7, 26);
            this.lblLicense.TabIndex = 97;
            this.lblLicense.Text = "\r\n\r\n";
            // 
            // linklblLicense
            // 
            this.linklblLicense.AutoSize = true;
            this.linklblLicense.Location = new System.Drawing.Point(9, 398);
            this.linklblLicense.Name = "linklblLicense";
            this.linklblLicense.Size = new System.Drawing.Size(44, 13);
            this.linklblLicense.TabIndex = 98;
            this.linklblLicense.TabStop = true;
            this.linklblLicense.Text = "License";
            this.linklblLicense.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLicense_LinkClicked);
            // 
            // formAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 469);
            this.Controls.Add(this.linklblLicense);
            this.Controls.Add(this.lblLicense);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.linklblMailTo);
            this.Controls.Add(this.lblAboutHeader);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formAbout";
            this.Load += new System.EventHandler(this.formAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label lblAboutHeader;
        private System.Windows.Forms.LinkLabel linklblMailTo;
        private System.Windows.Forms.Label lblText;
        internal System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.LinkLabel linklblLicense;
    }
}