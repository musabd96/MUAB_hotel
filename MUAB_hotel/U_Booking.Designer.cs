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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlSelectRoom = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.txtChOut = new System.Windows.Forms.TextBox();
            this.txtChIn = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.txtRoomNr = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalNght = new System.Windows.Forms.TextBox();
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
            this.lbBooking.Font = new System.Drawing.Font("Century Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBooking.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbBooking.Location = new System.Drawing.Point(491, 13);
            this.lbBooking.Name = "lbBooking";
            this.lbBooking.Size = new System.Drawing.Size(354, 93);
            this.lbBooking.TabIndex = 2;
            this.lbBooking.Text = "Booking";
            // 
            // lbAdult
            // 
            this.lbAdult.AutoSize = true;
            this.lbAdult.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdult.Location = new System.Drawing.Point(198, 294);
            this.lbAdult.Name = "lbAdult";
            this.lbAdult.Size = new System.Drawing.Size(83, 31);
            this.lbAdult.TabIndex = 6;
            this.lbAdult.Text = "Adult:";
            // 
            // btnAdultMinus
            // 
            this.btnAdultMinus.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdultMinus.Location = new System.Drawing.Point(307, 294);
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
            this.lbAdultCount.Location = new System.Drawing.Point(370, 300);
            this.lbAdultCount.Name = "lbAdultCount";
            this.lbAdultCount.Size = new System.Drawing.Size(28, 31);
            this.lbAdultCount.TabIndex = 6;
            this.lbAdultCount.Text = "0";
            // 
            // btnAdultPlus
            // 
            this.btnAdultPlus.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdultPlus.Location = new System.Drawing.Point(415, 294);
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
            this.label2.Location = new System.Drawing.Point(165, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Children:";
            // 
            // btnChilNeg
            // 
            this.btnChilNeg.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChilNeg.Location = new System.Drawing.Point(308, 358);
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
            this.lbChildrenCount.Location = new System.Drawing.Point(369, 364);
            this.lbChildrenCount.Name = "lbChildrenCount";
            this.lbChildrenCount.Size = new System.Drawing.Size(28, 31);
            this.lbChildrenCount.TabIndex = 6;
            this.lbChildrenCount.Text = "0";
            // 
            // btnChilPlus
            // 
            this.btnChilPlus.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChilPlus.Location = new System.Drawing.Point(416, 358);
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
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(167, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ages 0 - 17";
            // 
            // cBRoomTy
            // 
            this.cBRoomTy.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBRoomTy.FormattingEnabled = true;
            this.cBRoomTy.Items.AddRange(new object[] {
            "-Select  room type-",
            "Double",
            "King",
            "Balcony",
            "Ocean View",
            "Garden View",
            "Single",
            "Family"});
            this.cBRoomTy.Location = new System.Drawing.Point(307, 219);
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
            this.lbRT.Location = new System.Drawing.Point(112, 218);
            this.lbRT.Name = "lbRT";
            this.lbRT.Size = new System.Drawing.Size(169, 33);
            this.lbRT.TabIndex = 6;
            this.lbRT.Text = "Room Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(710, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 31);
            this.label8.TabIndex = 6;
            this.label8.Text = "Check-in:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(845, 221);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(189, 39);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2022, 12, 26, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(695, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 31);
            this.label5.TabIndex = 6;
            this.label5.Text = "Check-out:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(846, 294);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(183, 39);
            this.dateTimePicker2.TabIndex = 9;
            this.dateTimePicker2.Value = new System.DateTime(2022, 12, 26, 0, 0, 0, 0);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(472, 479);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(154, 61);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(773, 479);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(154, 61);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlSelectRoom
            // 
            this.pnlSelectRoom.Controls.Add(this.btnCancel);
            this.pnlSelectRoom.Controls.Add(this.btnBook);
            this.pnlSelectRoom.Controls.Add(this.txtChOut);
            this.pnlSelectRoom.Controls.Add(this.txtChIn);
            this.pnlSelectRoom.Controls.Add(this.txtPrice);
            this.pnlSelectRoom.Controls.Add(this.txtTotalNght);
            this.pnlSelectRoom.Controls.Add(this.txtRoomType);
            this.pnlSelectRoom.Controls.Add(this.txtBookId);
            this.pnlSelectRoom.Controls.Add(this.txtRoomNr);
            this.pnlSelectRoom.Controls.Add(this.label11);
            this.pnlSelectRoom.Controls.Add(this.label10);
            this.pnlSelectRoom.Controls.Add(this.label9);
            this.pnlSelectRoom.Controls.Add(this.label6);
            this.pnlSelectRoom.Controls.Add(this.label7);
            this.pnlSelectRoom.Controls.Add(this.label12);
            this.pnlSelectRoom.Controls.Add(this.label3);
            this.pnlSelectRoom.Controls.Add(this.label1);
            this.pnlSelectRoom.Controls.Add(this.dataGridView1);
            this.pnlSelectRoom.Location = new System.Drawing.Point(0, 684);
            this.pnlSelectRoom.Name = "pnlSelectRoom";
            this.pnlSelectRoom.Size = new System.Drawing.Size(1302, 20);
            this.pnlSelectRoom.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1133, 431);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(149, 63);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBook
            // 
            this.btnBook.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(928, 431);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(149, 63);
            this.btnBook.TabIndex = 4;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            // 
            // txtChOut
            // 
            this.txtChOut.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChOut.Location = new System.Drawing.Point(1041, 367);
            this.txtChOut.Name = "txtChOut";
            this.txtChOut.Size = new System.Drawing.Size(241, 32);
            this.txtChOut.TabIndex = 3;
            // 
            // txtChIn
            // 
            this.txtChIn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChIn.Location = new System.Drawing.Point(1041, 323);
            this.txtChIn.Name = "txtChIn";
            this.txtChIn.Size = new System.Drawing.Size(241, 32);
            this.txtChIn.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(1041, 280);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(241, 32);
            this.txtPrice.TabIndex = 3;
            // 
            // txtRoomType
            // 
            this.txtRoomType.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomType.Location = new System.Drawing.Point(1041, 195);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(241, 32);
            this.txtRoomType.TabIndex = 3;
            // 
            // txtBookId
            // 
            this.txtBookId.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookId.Location = new System.Drawing.Point(1041, 111);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(241, 32);
            this.txtBookId.TabIndex = 3;
            // 
            // txtRoomNr
            // 
            this.txtRoomNr.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNr.Location = new System.Drawing.Point(1041, 152);
            this.txtRoomNr.Name = "txtRoomNr";
            this.txtRoomNr.Size = new System.Drawing.Size(241, 32);
            this.txtRoomNr.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(908, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 23);
            this.label11.TabIndex = 2;
            this.label11.Text = "Check out:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(920, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "Check In:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(950, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(897, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Room Type:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(914, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 23);
            this.label12.TabIndex = 2;
            this.label12.Text = "Book ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(914, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room Nr:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a Room inthe table";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Location = new System.Drawing.Point(19, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.Size = new System.Drawing.Size(857, 497);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(890, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total Nights:";
            // 
            // txtTotalNght
            // 
            this.txtTotalNght.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNght.Location = new System.Drawing.Point(1041, 235);
            this.txtTotalNght.Name = "txtTotalNght";
            this.txtTotalNght.Size = new System.Drawing.Size(241, 32);
            this.txtTotalNght.TabIndex = 3;
            // 
            // U_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Controls.Add(this.pnlSelectRoom);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
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
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbAdult);
            this.Controls.Add(this.lbBooking);
            this.Name = "U_Booking";
            this.Size = new System.Drawing.Size(1302, 707);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlSelectRoom;
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}
