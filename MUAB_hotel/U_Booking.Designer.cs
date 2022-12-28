namespace MUAB_hotel
{
    partial class U_Booking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbBooking = new System.Windows.Forms.Label();
            this.lbAdult = new System.Windows.Forms.Label();
            this.btnAdultMinus = new System.Windows.Forms.Button();
            this.lbAdultCount = new System.Windows.Forms.Label();
            this.btnAdultPlus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChilNeg = new System.Windows.Forms.Button();
            this.lbChildrenCount = new System.Windows.Forms.Label();
            this.btnChilPlus = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cBRoomTy = new System.Windows.Forms.ComboBox();
            this.lbRT = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtCheckin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtCheckout = new System.Windows.Forms.DateTimePicker();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlSelectRoom = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.txtChOut = new System.Windows.Forms.TextBox();
            this.txtChIn = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTotalNght = new System.Windows.Forms.TextBox();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.txtCusId = new System.Windows.Forms.TextBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.txtRoomNr = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNr = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.pnlSelectRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBooking
            // 
            this.lbBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbBooking.AutoSize = true;
            this.lbBooking.Font = new System.Drawing.Font("Times New Roman", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBooking.ForeColor = System.Drawing.Color.White;
            this.lbBooking.Location = new System.Drawing.Point(491, 13);
            this.lbBooking.Name = "lbBooking";
            this.lbBooking.Size = new System.Drawing.Size(320, 90);
            this.lbBooking.TabIndex = 2;
            this.lbBooking.Text = "Booking";
            // 
            // lbAdult
            // 
            this.lbAdult.AutoSize = true;
            this.lbAdult.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdult.ForeColor = System.Drawing.Color.White;
            this.lbAdult.Location = new System.Drawing.Point(195, 389);
            this.lbAdult.Name = "lbAdult";
            this.lbAdult.Size = new System.Drawing.Size(83, 31);
            this.lbAdult.TabIndex = 6;
            this.lbAdult.Text = "Adult:";
            // 
            // btnAdultMinus
            // 
            this.btnAdultMinus.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdultMinus.Location = new System.Drawing.Point(332, 385);
            this.btnAdultMinus.Name = "btnAdultMinus";
            this.btnAdultMinus.Size = new System.Drawing.Size(40, 39);
            this.btnAdultMinus.TabIndex = 7;
            this.btnAdultMinus.Text = "-";
            this.btnAdultMinus.UseVisualStyleBackColor = true;
            this.btnAdultMinus.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // lbAdultCount
            // 
            this.lbAdultCount.AutoSize = true;
            this.lbAdultCount.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdultCount.ForeColor = System.Drawing.Color.White;
            this.lbAdultCount.Location = new System.Drawing.Point(395, 391);
            this.lbAdultCount.Name = "lbAdultCount";
            this.lbAdultCount.Size = new System.Drawing.Size(28, 31);
            this.lbAdultCount.TabIndex = 6;
            this.lbAdultCount.Text = "0";
            // 
            // btnAdultPlus
            // 
            this.btnAdultPlus.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdultPlus.Location = new System.Drawing.Point(440, 385);
            this.btnAdultPlus.Name = "btnAdultPlus";
            this.btnAdultPlus.Size = new System.Drawing.Size(40, 39);
            this.btnAdultPlus.TabIndex = 7;
            this.btnAdultPlus.Text = "+";
            this.btnAdultPlus.UseVisualStyleBackColor = true;
            this.btnAdultPlus.Click += new System.EventHandler(this.btnAdultPlus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(162, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Children:";
            // 
            // btnChilNeg
            // 
            this.btnChilNeg.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChilNeg.Location = new System.Drawing.Point(333, 449);
            this.btnChilNeg.Name = "btnChilNeg";
            this.btnChilNeg.Size = new System.Drawing.Size(40, 39);
            this.btnChilNeg.TabIndex = 7;
            this.btnChilNeg.Text = "-";
            this.btnChilNeg.UseVisualStyleBackColor = true;
            this.btnChilNeg.Click += new System.EventHandler(this.btnChilNeg_Click);
            // 
            // lbChildrenCount
            // 
            this.lbChildrenCount.AutoSize = true;
            this.lbChildrenCount.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChildrenCount.ForeColor = System.Drawing.Color.White;
            this.lbChildrenCount.Location = new System.Drawing.Point(394, 455);
            this.lbChildrenCount.Name = "lbChildrenCount";
            this.lbChildrenCount.Size = new System.Drawing.Size(28, 31);
            this.lbChildrenCount.TabIndex = 6;
            this.lbChildrenCount.Text = "0";
            // 
            // btnChilPlus
            // 
            this.btnChilPlus.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChilPlus.Location = new System.Drawing.Point(441, 449);
            this.btnChilPlus.Name = "btnChilPlus";
            this.btnChilPlus.Size = new System.Drawing.Size(40, 39);
            this.btnChilPlus.TabIndex = 7;
            this.btnChilPlus.Text = "+";
            this.btnChilPlus.UseVisualStyleBackColor = true;
            this.btnChilPlus.Click += new System.EventHandler(this.btnChilPlus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(164, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ages 0 - 17";
            // 
            // cBRoomTy
            // 
            this.cBRoomTy.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBRoomTy.FormattingEnabled = true;
            this.cBRoomTy.ItemHeight = 31;
            this.cBRoomTy.Items.AddRange(new object[] {
            "-Select  room type-",
            "Double",
            "King",
            "Balcony",
            "Ocean View",
            "Garden View",
            "Single",
            "Family"});
            this.cBRoomTy.Location = new System.Drawing.Point(304, 314);
            this.cBRoomTy.Name = "cBRoomTy";
            this.cBRoomTy.Size = new System.Drawing.Size(242, 39);
            this.cBRoomTy.TabIndex = 8;
            this.cBRoomTy.Text = "-Select  room type-";
            this.cBRoomTy.Click += new System.EventHandler(this.cBRoomTy_Click);
            // 
            // lbRT
            // 
            this.lbRT.AutoSize = true;
            this.lbRT.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRT.ForeColor = System.Drawing.Color.White;
            this.lbRT.Location = new System.Drawing.Point(109, 313);
            this.lbRT.Name = "lbRT";
            this.lbRT.Size = new System.Drawing.Size(169, 33);
            this.lbRT.TabIndex = 6;
            this.lbRT.Text = "Room Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(630, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 31);
            this.label8.TabIndex = 6;
            this.label8.Text = "Check-in:";
            // 
            // dtCheckin
            // 
            this.dtCheckin.CustomFormat = "yyyy-MM-dd";
            this.dtCheckin.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCheckin.Location = new System.Drawing.Point(775, 316);
            this.dtCheckin.Name = "dtCheckin";
            this.dtCheckin.Size = new System.Drawing.Size(228, 39);
            this.dtCheckin.TabIndex = 5;
            this.dtCheckin.Value = new System.DateTime(2022, 12, 27, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(615, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Check-out:";
            // 
            // dtCheckout
            // 
            this.dtCheckout.CustomFormat = "yyyy-MM-dd";
            this.dtCheckout.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCheckout.Location = new System.Drawing.Point(776, 389);
            this.dtCheckout.Name = "dtCheckout";
            this.dtCheckout.Size = new System.Drawing.Size(227, 39);
            this.dtCheckout.TabIndex = 6;
            this.dtCheckout.Value = new System.DateTime(2022, 12, 27, 0, 0, 0, 0);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(412, 525);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(154, 61);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(713, 525);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSearch.Size = new System.Drawing.Size(154, 61);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlSelectRoom
            // 
            this.pnlSelectRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSelectRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.pnlSelectRoom.Controls.Add(this.label14);
            this.pnlSelectRoom.Controls.Add(this.dataGridView1);
            this.pnlSelectRoom.Controls.Add(this.checkBox1);
            this.pnlSelectRoom.Controls.Add(this.btnCancel);
            this.pnlSelectRoom.Controls.Add(this.btnBook);
            this.pnlSelectRoom.Controls.Add(this.txtChOut);
            this.pnlSelectRoom.Controls.Add(this.txtChIn);
            this.pnlSelectRoom.Controls.Add(this.txtPrice);
            this.pnlSelectRoom.Controls.Add(this.txtTotalNght);
            this.pnlSelectRoom.Controls.Add(this.txtRoomType);
            this.pnlSelectRoom.Controls.Add(this.txtCusId);
            this.pnlSelectRoom.Controls.Add(this.txtBookId);
            this.pnlSelectRoom.Controls.Add(this.txtRoomNr);
            this.pnlSelectRoom.Controls.Add(this.label11);
            this.pnlSelectRoom.Controls.Add(this.label10);
            this.pnlSelectRoom.Controls.Add(this.label9);
            this.pnlSelectRoom.Controls.Add(this.label6);
            this.pnlSelectRoom.Controls.Add(this.label13);
            this.pnlSelectRoom.Controls.Add(this.label7);
            this.pnlSelectRoom.Controls.Add(this.label12);
            this.pnlSelectRoom.Controls.Add(this.label3);
            this.pnlSelectRoom.Controls.Add(this.label1);
            this.pnlSelectRoom.Location = new System.Drawing.Point(0, 700);
            this.pnlSelectRoom.Name = "pnlSelectRoom";
            this.pnlSelectRoom.Size = new System.Drawing.Size(1302, 10);
            this.pnlSelectRoom.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(491, -332);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(320, 90);
            this.label14.TabIndex = 7;
            this.label14.Text = "Booking";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(64, -120);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 40;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(836, 446);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(956, 193);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Padding = new System.Windows.Forms.Padding(20);
            this.checkBox1.Size = new System.Drawing.Size(148, 67);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "I AGREE";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1114, 289);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 37);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBook
            // 
            this.btnBook.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBook.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(957, 289);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(106, 37);
            this.btnBook.TabIndex = 4;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // txtChOut
            // 
            this.txtChOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtChOut.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.txtChOut.Location = new System.Drawing.Point(1074, 153);
            this.txtChOut.Name = "txtChOut";
            this.txtChOut.Size = new System.Drawing.Size(146, 32);
            this.txtChOut.TabIndex = 3;
            // 
            // txtChIn
            // 
            this.txtChIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtChIn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.txtChIn.Location = new System.Drawing.Point(1074, 115);
            this.txtChIn.Name = "txtChIn";
            this.txtChIn.Size = new System.Drawing.Size(146, 32);
            this.txtChIn.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrice.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.txtPrice.Location = new System.Drawing.Point(1074, 77);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(146, 32);
            this.txtPrice.TabIndex = 3;
            // 
            // txtTotalNght
            // 
            this.txtTotalNght.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotalNght.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNght.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.txtTotalNght.Location = new System.Drawing.Point(1074, 39);
            this.txtTotalNght.Name = "txtTotalNght";
            this.txtTotalNght.Size = new System.Drawing.Size(146, 32);
            this.txtTotalNght.TabIndex = 3;
            // 
            // txtRoomType
            // 
            this.txtRoomType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRoomType.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.txtRoomType.Location = new System.Drawing.Point(1074, 1);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(146, 32);
            this.txtRoomType.TabIndex = 3;
            // 
            // txtCusId
            // 
            this.txtCusId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCusId.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.txtCusId.Location = new System.Drawing.Point(1074, -112);
            this.txtCusId.Name = "txtCusId";
            this.txtCusId.Size = new System.Drawing.Size(146, 32);
            this.txtCusId.TabIndex = 3;
            // 
            // txtBookId
            // 
            this.txtBookId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBookId.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.txtBookId.Location = new System.Drawing.Point(1074, -74);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(146, 32);
            this.txtBookId.TabIndex = 3;
            // 
            // txtRoomNr
            // 
            this.txtRoomNr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRoomNr.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.txtRoomNr.Location = new System.Drawing.Point(1074, -37);
            this.txtRoomNr.Name = "txtRoomNr";
            this.txtRoomNr.Size = new System.Drawing.Size(146, 32);
            this.txtRoomNr.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(958, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 23);
            this.label11.TabIndex = 2;
            this.label11.Text = "Check out:";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(970, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "Check In:";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1000, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "Price:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(940, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total Nights:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(920, -103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 23);
            this.label13.TabIndex = 2;
            this.label13.Text = "Customers ID:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(947, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Room Type:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(964, -70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 23);
            this.label12.TabIndex = 2;
            this.label12.Text = "Book ID:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(964, -33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room Nr:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(303, -178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a Room inthe table";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.ForeColor = System.Drawing.Color.White;
            this.lbFirstName.Location = new System.Drawing.Point(159, 198);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(139, 31);
            this.lbFirstName.TabIndex = 6;
            this.lbFirstName.Text = "First Name:";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastName.ForeColor = System.Drawing.Color.White;
            this.lbLastName.Location = new System.Drawing.Point(159, 251);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(136, 31);
            this.lbLastName.TabIndex = 6;
            this.lbLastName.Text = "Last Name:";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.ForeColor = System.Drawing.Color.White;
            this.lbAddress.Location = new System.Drawing.Point(630, 251);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(94, 31);
            this.lbAddress.TabIndex = 6;
            this.lbAddress.Text = "Adress:";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.ForeColor = System.Drawing.Color.White;
            this.lbPhone.Location = new System.Drawing.Point(630, 198);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(124, 31);
            this.lbPhone.TabIndex = 6;
            this.lbPhone.Text = "Phone Nr:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(776, 251);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(227, 29);
            this.txtAddress.TabIndex = 4;
            // 
            // txtPhoneNr
            // 
            this.txtPhoneNr.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNr.Location = new System.Drawing.Point(775, 193);
            this.txtPhoneNr.Name = "txtPhoneNr";
            this.txtPhoneNr.Size = new System.Drawing.Size(227, 29);
            this.txtPhoneNr.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(304, 200);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(243, 29);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(303, 248);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(243, 29);
            this.txtLastname.TabIndex = 2;
            // 
            // U_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.Controls.Add(this.pnlSelectRoom);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtPhoneNr);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dtCheckout);
            this.Controls.Add(this.dtCheckin);
            this.Controls.Add(this.cBRoomTy);
            this.Controls.Add(this.btnChilPlus);
            this.Controls.Add(this.btnAdultPlus);
            this.Controls.Add(this.lbChildrenCount);
            this.Controls.Add(this.lbAdultCount);
            this.Controls.Add(this.btnChilNeg);
            this.Controls.Add(this.btnAdultMinus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbRT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbAdult);
            this.Controls.Add(this.lbBooking);
            this.Name = "U_Booking";
            this.Size = new System.Drawing.Size(1302, 707);
            this.Load += new System.EventHandler(this.U_Booking_Load);
            this.pnlSelectRoom.ResumeLayout(false);
            this.pnlSelectRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBooking;
        private System.Windows.Forms.Label lbAdult;
        private System.Windows.Forms.Button btnAdultMinus;
        private System.Windows.Forms.Label lbAdultCount;
        private System.Windows.Forms.Button btnAdultPlus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChilNeg;
        private System.Windows.Forms.Label lbChildrenCount;
        private System.Windows.Forms.Button btnChilPlus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBRoomTy;
        private System.Windows.Forms.Label lbRT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtCheckin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtCheckout;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlSelectRoom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.TextBox txtChOut;
        private System.Windows.Forms.TextBox txtChIn;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.TextBox txtRoomNr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalNght;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtCusId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNr;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label14;
    }
}
