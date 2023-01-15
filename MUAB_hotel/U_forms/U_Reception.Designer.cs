﻿using System.Windows.Forms;

namespace MUAB_hotel
{
    partial class U_Reception
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(U_Reception));
            this.lbHome = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.btnChIn = new System.Windows.Forms.Button();
            this.btnChOut = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.X = new System.Windows.Forms.DataGridViewImageColumn();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pBl = new System.Windows.Forms.PictureBox();
            this.pBsearch = new System.Windows.Forms.PictureBox();
            this.pBX = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBsearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBX)).BeginInit();
            this.SuspendLayout();
            // 
            // lbHome
            // 
            this.lbHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHome.AutoSize = true;
            this.lbHome.Font = new System.Drawing.Font("Century Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHome.ForeColor = System.Drawing.Color.White;
            this.lbHome.Location = new System.Drawing.Point(423, 0);
            this.lbHome.Name = "lbHome";
            this.lbHome.Size = new System.Drawing.Size(434, 93);
            this.lbHome.TabIndex = 2;
            this.lbHome.Text = "Reception";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(77, 152);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(441, 32);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // lbFirstName
            // 
            this.lbFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.ForeColor = System.Drawing.Color.White;
            this.lbFirstName.Location = new System.Drawing.Point(71, 118);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(301, 31);
            this.lbFirstName.TabIndex = 10;
            this.lbFirstName.Text = "BookID / Name /Room Nr";
            // 
            // btnChIn
            // 
            this.btnChIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChIn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChIn.ForeColor = System.Drawing.Color.Green;
            this.btnChIn.Location = new System.Drawing.Point(704, 158);
            this.btnChIn.Name = "btnChIn";
            this.btnChIn.Size = new System.Drawing.Size(137, 42);
            this.btnChIn.TabIndex = 11;
            this.btnChIn.Text = "Check in";
            this.btnChIn.UseVisualStyleBackColor = true;
            this.btnChIn.Click += new System.EventHandler(this.btnChIn_Click);
            // 
            // btnChOut
            // 
            this.btnChOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChOut.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChOut.ForeColor = System.Drawing.Color.Red;
            this.btnChOut.Location = new System.Drawing.Point(879, 158);
            this.btnChOut.Name = "btnChOut";
            this.btnChOut.Size = new System.Drawing.Size(137, 42);
            this.btnChOut.TabIndex = 11;
            this.btnChOut.Text = "Check out";
            this.btnChOut.UseVisualStyleBackColor = true;
            this.btnChOut.Click += new System.EventHandler(this.btnChOut_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            this.dataGridView3.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView3.ColumnHeadersHeight = 60;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.X,
            this.Select});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.Location = new System.Drawing.Point(3, 244);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 40;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            this.dataGridView3.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView3.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView3.RowTemplate.Height = 40;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(1296, 309);
            this.dataGridView3.TabIndex = 17;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "edit.png");
            // 
            // Edit
            // 
            this.Edit.FillWeight = 186.6882F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
            // 
            // X
            // 
            this.X.FillWeight = 100.503F;
            this.X.HeaderText = "X";
            this.X.Image = ((System.Drawing.Image)(resources.GetObject("X.Image")));
            this.X.Name = "X";
            // 
            // Select
            // 
            this.Select.FillWeight = 62.04747F;
            this.Select.HeaderText = "";
            this.Select.Name = "Select";
            // 
            // pBl
            // 
            this.pBl.BackColor = System.Drawing.Color.White;
            this.pBl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBl.Image = ((System.Drawing.Image)(resources.GetObject("pBl.Image")));
            this.pBl.Location = new System.Drawing.Point(476, 158);
            this.pBl.Name = "pBl";
            this.pBl.Size = new System.Drawing.Size(22, 20);
            this.pBl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBl.TabIndex = 18;
            this.pBl.TabStop = false;
            this.pBl.Click += new System.EventHandler(this.pBX_Click);
            // 
            // pBsearch
            // 
            this.pBsearch.BackColor = System.Drawing.Color.White;
            this.pBsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBsearch.Image = ((System.Drawing.Image)(resources.GetObject("pBsearch.Image")));
            this.pBsearch.Location = new System.Drawing.Point(491, 158);
            this.pBsearch.Name = "pBsearch";
            this.pBsearch.Size = new System.Drawing.Size(22, 20);
            this.pBsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBsearch.TabIndex = 18;
            this.pBsearch.TabStop = false;
            this.pBsearch.Click += new System.EventHandler(this.pBsearch_Click);
            // 
            // pBX
            // 
            this.pBX.BackColor = System.Drawing.Color.White;
            this.pBX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pBX.Image = ((System.Drawing.Image)(resources.GetObject("pBX.Image")));
            this.pBX.Location = new System.Drawing.Point(461, 158);
            this.pBX.Name = "pBX";
            this.pBX.Size = new System.Drawing.Size(22, 20);
            this.pBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBX.TabIndex = 18;
            this.pBX.TabStop = false;
            this.pBX.Click += new System.EventHandler(this.pBX_Click);
            // 
            // U_Reception
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.Controls.Add(this.pBX);
            this.Controls.Add(this.pBsearch);
            this.Controls.Add(this.pBl);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnChOut);
            this.Controls.Add(this.btnChIn);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.lbHome);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "U_Reception";
            this.Size = new System.Drawing.Size(1302, 707);
            this.Load += new System.EventHandler(this.U_Reception_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBsearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHome;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Button btnChIn;
        private System.Windows.Forms.Button btnChOut;
        private DataGridView dataGridView3;
        private ImageList imageList1;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn X;
        private DataGridViewCheckBoxColumn Select;
        private PictureBox pBl;
        private PictureBox pBsearch;
        private PictureBox pBX;
    }
}
