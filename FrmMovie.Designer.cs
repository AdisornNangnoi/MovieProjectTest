namespace MovieProjectTest
{
    partial class FrmMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMovie));
            this.btExit = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSaveAddEdit = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btSelectImg2 = new System.Windows.Forms.Button();
            this.btSelectImg1 = new System.Windows.Forms.Button();
            this.pcbDirMovie = new System.Windows.Forms.PictureBox();
            this.pcbMovieImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMovieDetail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbMovieId = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbMovieName = new System.Windows.Forms.TextBox();
            this.tbMovieDVDPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbMovieType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpMovieDateSale = new System.Windows.Forms.DateTimePicker();
            this.tbMovieDVDTotal = new System.Windows.Forms.TextBox();
            this.nudMovieHour = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nudMovieMinute = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btMovieSearch = new System.Windows.Forms.Button();
            this.tbMovieSearch = new System.Windows.Forms.TextBox();
            this.rdMovieName = new System.Windows.Forms.RadioButton();
            this.rdMovieId = new System.Windows.Forms.RadioButton();
            this.lsMovieShow = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dgvMovieShowAll = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDirMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMovieImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMovieHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMovieMinute)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieShowAll)).BeginInit();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.Image = ((System.Drawing.Image)(resources.GetObject("btExit.Image")));
            this.btExit.Location = new System.Drawing.Point(749, 384);
            this.btExit.Margin = new System.Windows.Forms.Padding(2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(56, 120);
            this.btExit.TabIndex = 50;
            this.btExit.Text = "Exit";
            this.btExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btCancel
            // 
            this.btCancel.Image = ((System.Drawing.Image)(resources.GetObject("btCancel.Image")));
            this.btCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCancel.Location = new System.Drawing.Point(749, 296);
            this.btCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(56, 50);
            this.btCancel.TabIndex = 49;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSaveAddEdit
            // 
            this.btSaveAddEdit.Image = ((System.Drawing.Image)(resources.GetObject("btSaveAddEdit.Image")));
            this.btSaveAddEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSaveAddEdit.Location = new System.Drawing.Point(749, 230);
            this.btSaveAddEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btSaveAddEdit.Name = "btSaveAddEdit";
            this.btSaveAddEdit.Size = new System.Drawing.Size(56, 50);
            this.btSaveAddEdit.TabIndex = 48;
            this.btSaveAddEdit.Text = "บันทึก";
            this.btSaveAddEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSaveAddEdit.UseVisualStyleBackColor = true;
            this.btSaveAddEdit.Click += new System.EventHandler(this.btSaveAddEdit_Click);
            // 
            // btDel
            // 
            this.btDel.Image = ((System.Drawing.Image)(resources.GetObject("btDel.Image")));
            this.btDel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btDel.Location = new System.Drawing.Point(749, 166);
            this.btDel.Margin = new System.Windows.Forms.Padding(2);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(56, 50);
            this.btDel.TabIndex = 47;
            this.btDel.Text = "ลบ";
            this.btDel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btEdit
            // 
            this.btEdit.Image = ((System.Drawing.Image)(resources.GetObject("btEdit.Image")));
            this.btEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEdit.Location = new System.Drawing.Point(749, 101);
            this.btEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(56, 50);
            this.btEdit.TabIndex = 46;
            this.btEdit.Text = "แก้ไข";
            this.btEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAdd.Location = new System.Drawing.Point(749, 36);
            this.btAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(56, 50);
            this.btAdd.TabIndex = 45;
            this.btAdd.Text = "เพิ่ม";
            this.btAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(43, 356);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(202, 19);
            this.label14.TabIndex = 41;
            this.label14.Text = "ภาพยนต์ทั้งหมด";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.btSelectImg2);
            this.groupBox2.Controls.Add(this.btSelectImg1);
            this.groupBox2.Controls.Add(this.pcbDirMovie);
            this.groupBox2.Controls.Add(this.pcbMovieImg);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbMovieDetail);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lbMovieId);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbMovieName);
            this.groupBox2.Controls.Add(this.tbMovieDVDPrice);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cbbMovieType);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dtpMovieDateSale);
            this.groupBox2.Controls.Add(this.tbMovieDVDTotal);
            this.groupBox2.Controls.Add(this.nudMovieHour);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.nudMovieMinute);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(259, 29);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(460, 317);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ข้อมูลภาพยนต์";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(311, 24);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 19);
            this.label16.TabIndex = 26;
            this.label16.Text = "รูปตัวอย่างภาพยนต์";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(311, 172);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 19);
            this.label15.TabIndex = 25;
            this.label15.Text = "รูปผู้กำกับภาพยนต์";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btSelectImg2
            // 
            this.btSelectImg2.Location = new System.Drawing.Point(421, 280);
            this.btSelectImg2.Margin = new System.Windows.Forms.Padding(2);
            this.btSelectImg2.Name = "btSelectImg2";
            this.btSelectImg2.Size = new System.Drawing.Size(22, 19);
            this.btSelectImg2.TabIndex = 24;
            this.btSelectImg2.Text = "...";
            this.btSelectImg2.UseVisualStyleBackColor = true;
            this.btSelectImg2.Click += new System.EventHandler(this.btSelectImg2_Click);
            // 
            // btSelectImg1
            // 
            this.btSelectImg1.Location = new System.Drawing.Point(421, 135);
            this.btSelectImg1.Margin = new System.Windows.Forms.Padding(2);
            this.btSelectImg1.Name = "btSelectImg1";
            this.btSelectImg1.Size = new System.Drawing.Size(22, 19);
            this.btSelectImg1.TabIndex = 23;
            this.btSelectImg1.Text = "...";
            this.btSelectImg1.UseVisualStyleBackColor = true;
            this.btSelectImg1.Click += new System.EventHandler(this.btSelectImg1_Click);
            // 
            // pcbDirMovie
            // 
            this.pcbDirMovie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbDirMovie.Location = new System.Drawing.Point(314, 193);
            this.pcbDirMovie.Margin = new System.Windows.Forms.Padding(2);
            this.pcbDirMovie.Name = "pcbDirMovie";
            this.pcbDirMovie.Size = new System.Drawing.Size(96, 106);
            this.pcbDirMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDirMovie.TabIndex = 22;
            this.pcbDirMovie.TabStop = false;
            // 
            // pcbMovieImg
            // 
            this.pcbMovieImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbMovieImg.InitialImage = null;
            this.pcbMovieImg.Location = new System.Drawing.Point(314, 48);
            this.pcbMovieImg.Margin = new System.Windows.Forms.Padding(2);
            this.pcbMovieImg.Name = "pcbMovieImg";
            this.pcbMovieImg.Size = new System.Drawing.Size(96, 106);
            this.pcbMovieImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMovieImg.TabIndex = 21;
            this.pcbMovieImg.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "รหัสภาพยนต์";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อภาพยนต์";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "วันที่วางขาย";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbMovieDetail
            // 
            this.tbMovieDetail.Location = new System.Drawing.Point(101, 84);
            this.tbMovieDetail.Margin = new System.Windows.Forms.Padding(2);
            this.tbMovieDetail.Multiline = true;
            this.tbMovieDetail.Name = "tbMovieDetail";
            this.tbMovieDetail.Size = new System.Drawing.Size(189, 56);
            this.tbMovieDetail.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "ความยาว";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(8, 84);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 19);
            this.label13.TabIndex = 19;
            this.label13.Text = "รายละเอียด";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMovieId
            // 
            this.lbMovieId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbMovieId.Location = new System.Drawing.Point(101, 27);
            this.lbMovieId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMovieId.Name = "lbMovieId";
            this.lbMovieId.Size = new System.Drawing.Size(188, 19);
            this.lbMovieId.TabIndex = 4;
            this.lbMovieId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(254, 280);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 19);
            this.label11.TabIndex = 18;
            this.label11.Text = "บาท";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbMovieName
            // 
            this.tbMovieName.Location = new System.Drawing.Point(101, 55);
            this.tbMovieName.Margin = new System.Windows.Forms.Padding(2);
            this.tbMovieName.Name = "tbMovieName";
            this.tbMovieName.Size = new System.Drawing.Size(189, 20);
            this.tbMovieName.TabIndex = 5;
            // 
            // tbMovieDVDPrice
            // 
            this.tbMovieDVDPrice.Location = new System.Drawing.Point(104, 280);
            this.tbMovieDVDPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbMovieDVDPrice.Name = "tbMovieDVDPrice";
            this.tbMovieDVDPrice.Size = new System.Drawing.Size(146, 20);
            this.tbMovieDVDPrice.TabIndex = 17;
            this.tbMovieDVDPrice.Text = "0.00";
            this.tbMovieDVDPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMovieDVDPrice_KeyPress);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "หมวดหมู่";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(8, 280);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 19);
            this.label12.TabIndex = 16;
            this.label12.Text = "ราคา DVD";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbMovieType
            // 
            this.cbbMovieType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMovieType.FormattingEnabled = true;
            this.cbbMovieType.Location = new System.Drawing.Point(104, 218);
            this.cbbMovieType.Margin = new System.Windows.Forms.Padding(2);
            this.cbbMovieType.Name = "cbbMovieType";
            this.cbbMovieType.Size = new System.Drawing.Size(187, 21);
            this.cbbMovieType.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(140, 250);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 19);
            this.label10.TabIndex = 15;
            this.label10.Text = "แผ่น";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpMovieDateSale
            // 
            this.dtpMovieDateSale.Location = new System.Drawing.Point(101, 154);
            this.dtpMovieDateSale.Margin = new System.Windows.Forms.Padding(2);
            this.dtpMovieDateSale.Name = "dtpMovieDateSale";
            this.dtpMovieDateSale.Size = new System.Drawing.Size(189, 20);
            this.dtpMovieDateSale.TabIndex = 8;
            // 
            // tbMovieDVDTotal
            // 
            this.tbMovieDVDTotal.Location = new System.Drawing.Point(104, 250);
            this.tbMovieDVDTotal.Margin = new System.Windows.Forms.Padding(2);
            this.tbMovieDVDTotal.Name = "tbMovieDVDTotal";
            this.tbMovieDVDTotal.Size = new System.Drawing.Size(33, 20);
            this.tbMovieDVDTotal.TabIndex = 14;
            this.tbMovieDVDTotal.Text = "0";
            this.tbMovieDVDTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMovieDVDTotal_KeyPress);
            // 
            // nudMovieHour
            // 
            this.nudMovieHour.Location = new System.Drawing.Point(104, 185);
            this.nudMovieHour.Margin = new System.Windows.Forms.Padding(2);
            this.nudMovieHour.Name = "nudMovieHour";
            this.nudMovieHour.Size = new System.Drawing.Size(41, 20);
            this.nudMovieHour.TabIndex = 9;
            this.nudMovieHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudMovieHour_KeyPress);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(8, 250);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 19);
            this.label9.TabIndex = 13;
            this.label9.Text = "จำนวน DVD";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudMovieMinute
            // 
            this.nudMovieMinute.Location = new System.Drawing.Point(194, 185);
            this.nudMovieMinute.Margin = new System.Windows.Forms.Padding(2);
            this.nudMovieMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMovieMinute.Name = "nudMovieMinute";
            this.nudMovieMinute.Size = new System.Drawing.Size(41, 20);
            this.nudMovieMinute.TabIndex = 10;
            this.nudMovieMinute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudMovieMinute_KeyPress);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(241, 184);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "นาที";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(147, 187);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "ชั่วโมง";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btMovieSearch);
            this.groupBox1.Controls.Add(this.tbMovieSearch);
            this.groupBox1.Controls.Add(this.rdMovieName);
            this.groupBox1.Controls.Add(this.rdMovieId);
            this.groupBox1.Controls.Add(this.lsMovieShow);
            this.groupBox1.Location = new System.Drawing.Point(45, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(200, 317);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ค้นหาภาพยนต์";
            // 
            // btMovieSearch
            // 
            this.btMovieSearch.Location = new System.Drawing.Point(123, 56);
            this.btMovieSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btMovieSearch.Name = "btMovieSearch";
            this.btMovieSearch.Size = new System.Drawing.Size(56, 19);
            this.btMovieSearch.TabIndex = 22;
            this.btMovieSearch.Text = "ค้นหา";
            this.btMovieSearch.UseVisualStyleBackColor = true;
            this.btMovieSearch.Click += new System.EventHandler(this.btMovieSearch_Click);
            // 
            // tbMovieSearch
            // 
            this.tbMovieSearch.Location = new System.Drawing.Point(16, 56);
            this.tbMovieSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbMovieSearch.Name = "tbMovieSearch";
            this.tbMovieSearch.Size = new System.Drawing.Size(104, 20);
            this.tbMovieSearch.TabIndex = 21;
            // 
            // rdMovieName
            // 
            this.rdMovieName.AutoSize = true;
            this.rdMovieName.Location = new System.Drawing.Point(111, 30);
            this.rdMovieName.Margin = new System.Windows.Forms.Padding(2);
            this.rdMovieName.Name = "rdMovieName";
            this.rdMovieName.Size = new System.Drawing.Size(80, 17);
            this.rdMovieName.TabIndex = 2;
            this.rdMovieName.Text = "ชื่อภาพยนต์";
            this.rdMovieName.UseVisualStyleBackColor = true;
            this.rdMovieName.Click += new System.EventHandler(this.rdMovieName_Click);
            // 
            // rdMovieId
            // 
            this.rdMovieId.AutoSize = true;
            this.rdMovieId.Checked = true;
            this.rdMovieId.Location = new System.Drawing.Point(19, 30);
            this.rdMovieId.Margin = new System.Windows.Forms.Padding(2);
            this.rdMovieId.Name = "rdMovieId";
            this.rdMovieId.Size = new System.Drawing.Size(86, 17);
            this.rdMovieId.TabIndex = 1;
            this.rdMovieId.TabStop = true;
            this.rdMovieId.Text = "รหัสภาพยนต์";
            this.rdMovieId.UseVisualStyleBackColor = true;
            this.rdMovieId.Click += new System.EventHandler(this.rdMovieId_Click);
            // 
            // lsMovieShow
            // 
            this.lsMovieShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsMovieShow.FullRowSelect = true;
            this.lsMovieShow.GridLines = true;
            this.lsMovieShow.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsMovieShow.HideSelection = false;
            this.lsMovieShow.Location = new System.Drawing.Point(16, 84);
            this.lsMovieShow.Margin = new System.Windows.Forms.Padding(2);
            this.lsMovieShow.Name = "lsMovieShow";
            this.lsMovieShow.Size = new System.Drawing.Size(164, 214);
            this.lsMovieShow.TabIndex = 0;
            this.lsMovieShow.UseCompatibleStateImageBehavior = false;
            this.lsMovieShow.View = System.Windows.Forms.View.Details;
            this.lsMovieShow.SelectedIndexChanged += new System.EventHandler(this.lsMovieShow_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ลำดับ";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ชื่อภาพยนต์";
            this.columnHeader2.Width = 150;
            // 
            // dgvMovieShowAll
            // 
            this.dgvMovieShowAll.AllowUserToAddRows = false;
            this.dgvMovieShowAll.AllowUserToDeleteRows = false;
            this.dgvMovieShowAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovieShowAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvMovieShowAll.Location = new System.Drawing.Point(45, 384);
            this.dgvMovieShowAll.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMovieShowAll.Name = "dgvMovieShowAll";
            this.dgvMovieShowAll.ReadOnly = true;
            this.dgvMovieShowAll.RowTemplate.Height = 24;
            this.dgvMovieShowAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMovieShowAll.Size = new System.Drawing.Size(675, 120);
            this.dgvMovieShowAll.TabIndex = 42;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "รหัสภาพยนต์";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ชื่อภาพยนต์";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "รายละเอียด";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 300;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "วันที่วางขาย";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "หมวดหมู่";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // FrmMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 542);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSaveAddEdit);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvMovieShowAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "จัดการข้อมูลภาพยนต์";
            this.Load += new System.EventHandler(this.FrmMovie_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDirMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMovieImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMovieHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMovieMinute)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovieShowAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSaveAddEdit;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btSelectImg2;
        private System.Windows.Forms.Button btSelectImg1;
        private System.Windows.Forms.PictureBox pcbDirMovie;
        private System.Windows.Forms.PictureBox pcbMovieImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMovieDetail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbMovieId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbMovieName;
        private System.Windows.Forms.TextBox tbMovieDVDPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbbMovieType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpMovieDateSale;
        private System.Windows.Forms.TextBox tbMovieDVDTotal;
        private System.Windows.Forms.NumericUpDown nudMovieHour;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudMovieMinute;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btMovieSearch;
        private System.Windows.Forms.TextBox tbMovieSearch;
        private System.Windows.Forms.RadioButton rdMovieName;
        private System.Windows.Forms.RadioButton rdMovieId;
        private System.Windows.Forms.ListView lsMovieShow;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.DataGridView dgvMovieShowAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}