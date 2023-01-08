namespace MUAB_hotel
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.lbUname = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlAccNr = new System.Windows.Forms.Panel();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.pnlPass = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pBView = new System.Windows.Forms.PictureBox();
            this.pBHide = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlAccNr.SuspendLayout();
            this.pnlPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(157, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // lbUname
            // 
            this.lbUname.AutoSize = true;
            this.lbUname.ForeColor = System.Drawing.Color.DimGray;
            this.lbUname.Location = new System.Drawing.Point(77, 102);
            this.lbUname.Name = "lbUname";
            this.lbUname.Size = new System.Drawing.Size(84, 21);
            this.lbUname.TabIndex = 3;
            this.lbUname.Text = "Username";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.ForeColor = System.Drawing.Color.DimGray;
            this.lbPass.Location = new System.Drawing.Point(77, 169);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(84, 21);
            this.lbPass.TabIndex = 3;
            this.lbPass.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Green;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(81, 262);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(246, 35);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlAccNr
            // 
            this.pnlAccNr.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlAccNr.Controls.Add(this.txtUname);
            this.pnlAccNr.ForeColor = System.Drawing.Color.White;
            this.pnlAccNr.Location = new System.Drawing.Point(81, 125);
            this.pnlAccNr.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAccNr.Name = "pnlAccNr";
            this.pnlAccNr.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.pnlAccNr.Size = new System.Drawing.Size(246, 25);
            this.pnlAccNr.TabIndex = 1;
            // 
            // txtUname
            // 
            this.txtUname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.txtUname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUname.ForeColor = System.Drawing.Color.White;
            this.txtUname.Location = new System.Drawing.Point(0, 0);
            this.txtUname.Margin = new System.Windows.Forms.Padding(2);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(246, 22);
            this.txtUname.TabIndex = 1;
            this.txtUname.TextChanged += new System.EventHandler(this.txtUname_TextChanged);
            // 
            // pnlPass
            // 
            this.pnlPass.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlPass.Controls.Add(this.txtPass);
            this.pnlPass.ForeColor = System.Drawing.Color.White;
            this.pnlPass.Location = new System.Drawing.Point(81, 205);
            this.pnlPass.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPass.Name = "pnlPass";
            this.pnlPass.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.pnlPass.Size = new System.Drawing.Size(246, 25);
            this.pnlPass.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.White;
            this.txtPass.Location = new System.Drawing.Point(0, 0);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(246, 22);
            this.txtPass.TabIndex = 2;
            this.txtPass.Tag = "";
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // pBView
            // 
            this.pBView.Image = ((System.Drawing.Image)(resources.GetObject("pBView.Image")));
            this.pBView.Location = new System.Drawing.Point(332, 190);
            this.pBView.Name = "pBView";
            this.pBView.Size = new System.Drawing.Size(24, 24);
            this.pBView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBView.TabIndex = 5;
            this.pBView.TabStop = false;
            this.pBView.Click += new System.EventHandler(this.pBView_Click);
            // 
            // pBHide
            // 
            this.pBHide.Image = ((System.Drawing.Image)(resources.GetObject("pBHide.Image")));
            this.pBHide.Location = new System.Drawing.Point(332, 190);
            this.pBHide.Name = "pBHide";
            this.pBHide.Size = new System.Drawing.Size(24, 24);
            this.pBHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBHide.TabIndex = 5;
            this.pBHide.TabStop = false;
            this.pBHide.Click += new System.EventHandler(this.pBHide_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(433, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbError.ForeColor = System.Drawing.Color.Red;
            this.lbError.Location = new System.Drawing.Point(133, 69);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(0, 15);
            this.lbError.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(483, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Copyright © 2023 MUAB™ Hotel";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(794, 353);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pBHide);
            this.Controls.Add(this.pBView);
            this.Controls.Add(this.pnlPass);
            this.Controls.Add(this.pnlAccNr);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbUname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnlAccNr.ResumeLayout(false);
            this.pnlAccNr.PerformLayout();
            this.pnlPass.ResumeLayout(false);
            this.pnlPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUname;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlAccNr;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.Panel pnlPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.PictureBox pBView;
        private System.Windows.Forms.PictureBox pBHide;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label label2;
    }
}