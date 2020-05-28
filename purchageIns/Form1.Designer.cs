namespace purchageIns
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dt_regDate = new System.Windows.Forms.DateTimePicker();
            this.cb_payMethod = new System.Windows.Forms.ComboBox();
            this.txt_checkNo = new System.Windows.Forms.TextBox();
            this.cb_payee = new System.Windows.Forms.ComboBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_gst = new System.Windows.Forms.TextBox();
            this.cb_category = new System.Windows.Forms.ComboBox();
            this.txt_etc = new System.Windows.Forms.TextBox();
            this.lbl_regDate = new System.Windows.Forms.Label();
            this.lbl_payMethod = new System.Windows.Forms.Label();
            this.lbl_checkNo = new System.Windows.Forms.Label();
            this.lbl_payee = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_gst = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_etc = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_list = new System.Windows.Forms.Button();
            this.btn_searchMonth01 = new System.Windows.Forms.Button();
            this.btn_searchMonth02 = new System.Windows.Forms.Button();
            this.btn_searchMonth03 = new System.Windows.Forms.Button();
            this.btn_searchMonth04 = new System.Windows.Forms.Button();
            this.btn_searchMonth05 = new System.Windows.Forms.Button();
            this.btn_searchMonth06 = new System.Windows.Forms.Button();
            this.btn_searchMonth07 = new System.Windows.Forms.Button();
            this.btn_searchMonth08 = new System.Windows.Forms.Button();
            this.btn_searchMonth09 = new System.Windows.Forms.Button();
            this.btn_searchMonth10 = new System.Windows.Forms.Button();
            this.btn_serchMonth11 = new System.Windows.Forms.Button();
            this.btn_searchMonth12 = new System.Windows.Forms.Button();
            this.ckl_searchPayee = new System.Windows.Forms.CheckedListBox();
            this.cb_searchYYYY_01 = new System.Windows.Forms.ComboBox();
            this.cb_searchMM_01 = new System.Windows.Forms.ComboBox();
            this.cb_searchMM_02 = new System.Windows.Forms.ComboBox();
            this.cb_searchYYYY_02 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.btn_backToCreate = new System.Windows.Forms.Button();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.btn_delete = new System.Windows.Forms.Button();
            this.purchaseId = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.buttonExcel = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GroupByPayMethod = new System.Windows.Forms.Button();
            this.GroupByCategory = new System.Windows.Forms.Button();
            this.GroupByPayee = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_gst_sum = new System.Windows.Forms.Label();
            this.lbl_total_sum = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.searchPayMethod = new System.Windows.Forms.ComboBox();
            this.searchCategory = new System.Windows.Forms.ComboBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btn_yearAll = new System.Windows.Forms.Button();
            this.cmb_year = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_regDate
            // 
            this.dt_regDate.Location = new System.Drawing.Point(84, 13);
            this.dt_regDate.Name = "dt_regDate";
            this.dt_regDate.Size = new System.Drawing.Size(200, 22);
            this.dt_regDate.TabIndex = 0;
            // 
            // cb_payMethod
            // 
            this.cb_payMethod.FormattingEnabled = true;
            this.cb_payMethod.Location = new System.Drawing.Point(382, 13);
            this.cb_payMethod.Name = "cb_payMethod";
            this.cb_payMethod.Size = new System.Drawing.Size(200, 21);
            this.cb_payMethod.TabIndex = 1;
            // 
            // txt_checkNo
            // 
            this.txt_checkNo.Location = new System.Drawing.Point(685, 8);
            this.txt_checkNo.Name = "txt_checkNo";
            this.txt_checkNo.Size = new System.Drawing.Size(200, 22);
            this.txt_checkNo.TabIndex = 2;
            // 
            // cb_payee
            // 
            this.cb_payee.FormattingEnabled = true;
            this.cb_payee.Location = new System.Drawing.Point(84, 51);
            this.cb_payee.Name = "cb_payee";
            this.cb_payee.Size = new System.Drawing.Size(200, 21);
            this.cb_payee.TabIndex = 3;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(382, 51);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(200, 22);
            this.txt_total.TabIndex = 4;
            this.txt_total.TextChanged += new System.EventHandler(this.txt_total_TextChanged);
            this.txt_total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_total_KeyPress_1);
            // 
            // txt_gst
            // 
            this.txt_gst.Location = new System.Drawing.Point(685, 51);
            this.txt_gst.Name = "txt_gst";
            this.txt_gst.Size = new System.Drawing.Size(200, 22);
            this.txt_gst.TabIndex = 5;
            this.txt_gst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gst_KeyPress_1);
            // 
            // cb_category
            // 
            this.cb_category.FormattingEnabled = true;
            this.cb_category.Location = new System.Drawing.Point(17, 89);
            this.cb_category.Name = "cb_category";
            this.cb_category.Size = new System.Drawing.Size(269, 21);
            this.cb_category.TabIndex = 6;
            // 
            // txt_etc
            // 
            this.txt_etc.Location = new System.Drawing.Point(386, 89);
            this.txt_etc.Multiline = true;
            this.txt_etc.Name = "txt_etc";
            this.txt_etc.Size = new System.Drawing.Size(196, 44);
            this.txt_etc.TabIndex = 7;
            // 
            // lbl_regDate
            // 
            this.lbl_regDate.AutoSize = true;
            this.lbl_regDate.Location = new System.Drawing.Point(14, 13);
            this.lbl_regDate.Name = "lbl_regDate";
            this.lbl_regDate.Size = new System.Drawing.Size(35, 14);
            this.lbl_regDate.TabIndex = 8;
            this.lbl_regDate.Text = "날짜";
            // 
            // lbl_payMethod
            // 
            this.lbl_payMethod.AutoSize = true;
            this.lbl_payMethod.Location = new System.Drawing.Point(312, 16);
            this.lbl_payMethod.Name = "lbl_payMethod";
            this.lbl_payMethod.Size = new System.Drawing.Size(63, 14);
            this.lbl_payMethod.TabIndex = 9;
            this.lbl_payMethod.Text = "결제방법";
            // 
            // lbl_checkNo
            // 
            this.lbl_checkNo.AutoSize = true;
            this.lbl_checkNo.Location = new System.Drawing.Point(613, 16);
            this.lbl_checkNo.Name = "lbl_checkNo";
            this.lbl_checkNo.Size = new System.Drawing.Size(71, 14);
            this.lbl_checkNo.TabIndex = 10;
            this.lbl_checkNo.Text = "Check No";
            // 
            // lbl_payee
            // 
            this.lbl_payee.AutoSize = true;
            this.lbl_payee.Location = new System.Drawing.Point(14, 49);
            this.lbl_payee.Name = "lbl_payee";
            this.lbl_payee.Size = new System.Drawing.Size(49, 14);
            this.lbl_payee.TabIndex = 11;
            this.lbl_payee.Text = "Payee";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(312, 51);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(39, 14);
            this.lbl_total.TabIndex = 12;
            this.lbl_total.Text = "Total";
            // 
            // lbl_gst
            // 
            this.lbl_gst.AutoSize = true;
            this.lbl_gst.Location = new System.Drawing.Point(615, 48);
            this.lbl_gst.Name = "lbl_gst";
            this.lbl_gst.Size = new System.Drawing.Size(36, 14);
            this.lbl_gst.TabIndex = 13;
            this.lbl_gst.Text = "GST";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(14, 72);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(66, 14);
            this.lbl_category.TabIndex = 14;
            this.lbl_category.Text = "Category";
            // 
            // lbl_etc
            // 
            this.lbl_etc.AutoSize = true;
            this.lbl_etc.Location = new System.Drawing.Point(314, 89);
            this.lbl_etc.Name = "lbl_etc";
            this.lbl_etc.Size = new System.Drawing.Size(28, 14);
            this.lbl_etc.TabIndex = 15;
            this.lbl_etc.Text = "Etc";
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(616, 89);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 16;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(697, 88);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 17;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(221, 210);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1261, 576);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btn_list
            // 
            this.btn_list.Location = new System.Drawing.Point(778, 89);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(75, 23);
            this.btn_list.TabIndex = 19;
            this.btn_list.Text = "List";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_searchMonth01
            // 
            this.btn_searchMonth01.Location = new System.Drawing.Point(10, 62);
            this.btn_searchMonth01.Name = "btn_searchMonth01";
            this.btn_searchMonth01.Size = new System.Drawing.Size(75, 23);
            this.btn_searchMonth01.TabIndex = 21;
            this.btn_searchMonth01.Text = "Jan";
            this.btn_searchMonth01.UseVisualStyleBackColor = true;
            this.btn_searchMonth01.Click += new System.EventHandler(this.btn_searchMonth01_Click);
            // 
            // btn_searchMonth02
            // 
            this.btn_searchMonth02.Location = new System.Drawing.Point(91, 62);
            this.btn_searchMonth02.Name = "btn_searchMonth02";
            this.btn_searchMonth02.Size = new System.Drawing.Size(75, 23);
            this.btn_searchMonth02.TabIndex = 22;
            this.btn_searchMonth02.Text = "Feb";
            this.btn_searchMonth02.UseVisualStyleBackColor = true;
            this.btn_searchMonth02.Click += new System.EventHandler(this.btn_searchMonth01_Click);
            // 
            // btn_searchMonth03
            // 
            this.btn_searchMonth03.Location = new System.Drawing.Point(172, 62);
            this.btn_searchMonth03.Name = "btn_searchMonth03";
            this.btn_searchMonth03.Size = new System.Drawing.Size(75, 23);
            this.btn_searchMonth03.TabIndex = 23;
            this.btn_searchMonth03.Text = "Mar";
            this.btn_searchMonth03.UseVisualStyleBackColor = true;
            this.btn_searchMonth03.Click += new System.EventHandler(this.btn_searchMonth01_Click);
            // 
            // btn_searchMonth04
            // 
            this.btn_searchMonth04.Location = new System.Drawing.Point(253, 62);
            this.btn_searchMonth04.Name = "btn_searchMonth04";
            this.btn_searchMonth04.Size = new System.Drawing.Size(75, 23);
            this.btn_searchMonth04.TabIndex = 24;
            this.btn_searchMonth04.Text = "Apr";
            this.btn_searchMonth04.UseVisualStyleBackColor = true;
            this.btn_searchMonth04.Click += new System.EventHandler(this.btn_searchMonth01_Click);
            // 
            // btn_searchMonth05
            // 
            this.btn_searchMonth05.Location = new System.Drawing.Point(334, 62);
            this.btn_searchMonth05.Name = "btn_searchMonth05";
            this.btn_searchMonth05.Size = new System.Drawing.Size(75, 23);
            this.btn_searchMonth05.TabIndex = 25;
            this.btn_searchMonth05.Text = "May";
            this.btn_searchMonth05.UseVisualStyleBackColor = true;
            this.btn_searchMonth05.Click += new System.EventHandler(this.btn_searchMonth01_Click);
            // 
            // btn_searchMonth06
            // 
            this.btn_searchMonth06.Location = new System.Drawing.Point(415, 62);
            this.btn_searchMonth06.Name = "btn_searchMonth06";
            this.btn_searchMonth06.Size = new System.Drawing.Size(75, 23);
            this.btn_searchMonth06.TabIndex = 26;
            this.btn_searchMonth06.Text = "Jun";
            this.btn_searchMonth06.UseVisualStyleBackColor = true;
            this.btn_searchMonth06.Click += new System.EventHandler(this.btn_searchMonth01_Click);
            // 
            // btn_searchMonth07
            // 
            this.btn_searchMonth07.Location = new System.Drawing.Point(10, 94);
            this.btn_searchMonth07.Name = "btn_searchMonth07";
            this.btn_searchMonth07.Size = new System.Drawing.Size(75, 23);
            this.btn_searchMonth07.TabIndex = 27;
            this.btn_searchMonth07.Text = "July";
            this.btn_searchMonth07.UseVisualStyleBackColor = true;
            this.btn_searchMonth07.Click += new System.EventHandler(this.btn_searchMonth01_Click);
            // 
            // btn_searchMonth08
            // 
            this.btn_searchMonth08.Location = new System.Drawing.Point(91, 94);
            this.btn_searchMonth08.Name = "btn_searchMonth08";
            this.btn_searchMonth08.Size = new System.Drawing.Size(75, 23);
            this.btn_searchMonth08.TabIndex = 28;
            this.btn_searchMonth08.Text = "Aug";
            this.btn_searchMonth08.UseVisualStyleBackColor = true;
            this.btn_searchMonth08.Click += new System.EventHandler(this.btn_searchMonth01_Click);
            // 
            // btn_searchMonth09
            // 
            this.btn_searchMonth09.Location = new System.Drawing.Point(172, 94);
            this.btn_searchMonth09.Name = "btn_searchMonth09";
            this.btn_searchMonth09.Size = new System.Drawing.Size(75, 23);
            this.btn_searchMonth09.TabIndex = 29;
            this.btn_searchMonth09.Text = "Sept";
            this.btn_searchMonth09.UseVisualStyleBackColor = true;
            this.btn_searchMonth09.Click += new System.EventHandler(this.btn_searchMonth01_Click);
            // 
            // btn_searchMonth10
            // 
            this.btn_searchMonth10.Location = new System.Drawing.Point(253, 94);
            this.btn_searchMonth10.Name = "btn_searchMonth10";
            this.btn_searchMonth10.Size = new System.Drawing.Size(75, 23);
            this.btn_searchMonth10.TabIndex = 30;
            this.btn_searchMonth10.Text = "Oct";
            this.btn_searchMonth10.UseVisualStyleBackColor = true;
            this.btn_searchMonth10.Click += new System.EventHandler(this.btn_searchMonth01_Click);
            // 
            // btn_serchMonth11
            // 
            this.btn_serchMonth11.Location = new System.Drawing.Point(334, 94);
            this.btn_serchMonth11.Name = "btn_serchMonth11";
            this.btn_serchMonth11.Size = new System.Drawing.Size(75, 23);
            this.btn_serchMonth11.TabIndex = 31;
            this.btn_serchMonth11.Text = "Nov";
            this.btn_serchMonth11.UseVisualStyleBackColor = true;
            this.btn_serchMonth11.Click += new System.EventHandler(this.btn_searchMonth01_Click);
            // 
            // btn_searchMonth12
            // 
            this.btn_searchMonth12.Location = new System.Drawing.Point(415, 91);
            this.btn_searchMonth12.Name = "btn_searchMonth12";
            this.btn_searchMonth12.Size = new System.Drawing.Size(75, 23);
            this.btn_searchMonth12.TabIndex = 32;
            this.btn_searchMonth12.Text = "Dec";
            this.btn_searchMonth12.UseVisualStyleBackColor = true;
            this.btn_searchMonth12.Click += new System.EventHandler(this.btn_searchMonth01_Click);
            // 
            // ckl_searchPayee
            // 
            this.ckl_searchPayee.CheckOnClick = true;
            this.ckl_searchPayee.FormattingEnabled = true;
            this.ckl_searchPayee.Location = new System.Drawing.Point(14, 37);
            this.ckl_searchPayee.Name = "ckl_searchPayee";
            this.ckl_searchPayee.Size = new System.Drawing.Size(194, 497);
            this.ckl_searchPayee.TabIndex = 33;
            this.ckl_searchPayee.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ckl_searchPayee_ItemCheck);
            // 
            // cb_searchYYYY_01
            // 
            this.cb_searchYYYY_01.FormattingEnabled = true;
            this.cb_searchYYYY_01.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "All"});
            this.cb_searchYYYY_01.Location = new System.Drawing.Point(58, 21);
            this.cb_searchYYYY_01.Name = "cb_searchYYYY_01";
            this.cb_searchYYYY_01.Size = new System.Drawing.Size(109, 21);
            this.cb_searchYYYY_01.TabIndex = 34;
            // 
            // cb_searchMM_01
            // 
            this.cb_searchMM_01.FormattingEnabled = true;
            this.cb_searchMM_01.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cb_searchMM_01.Location = new System.Drawing.Point(173, 21);
            this.cb_searchMM_01.Name = "cb_searchMM_01";
            this.cb_searchMM_01.Size = new System.Drawing.Size(109, 21);
            this.cb_searchMM_01.TabIndex = 35;
            // 
            // cb_searchMM_02
            // 
            this.cb_searchMM_02.FormattingEnabled = true;
            this.cb_searchMM_02.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cb_searchMM_02.Location = new System.Drawing.Point(173, 61);
            this.cb_searchMM_02.Name = "cb_searchMM_02";
            this.cb_searchMM_02.Size = new System.Drawing.Size(109, 21);
            this.cb_searchMM_02.TabIndex = 37;
            // 
            // cb_searchYYYY_02
            // 
            this.cb_searchYYYY_02.FormattingEnabled = true;
            this.cb_searchYYYY_02.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "All"});
            this.cb_searchYYYY_02.Location = new System.Drawing.Point(58, 61);
            this.cb_searchYYYY_02.Name = "cb_searchYYYY_02";
            this.cb_searchYYYY_02.Size = new System.Drawing.Size(109, 21);
            this.cb_searchYYYY_02.TabIndex = 36;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(288, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 14);
            this.label1.TabIndex = 39;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 14);
            this.label2.TabIndex = 40;
            this.label2.Text = "To:";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(101, 15);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(103, 14);
            this.linkLabel2.TabIndex = 42;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "None_checked";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.btn_backToCreate);
            this.panel1.Controls.Add(this.radioButton5);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.purchaseId);
            this.panel1.Controls.Add(this.lbl_id);
            this.panel1.Controls.Add(this.dt_regDate);
            this.panel1.Controls.Add(this.cb_payMethod);
            this.panel1.Controls.Add(this.txt_checkNo);
            this.panel1.Controls.Add(this.cb_payee);
            this.panel1.Controls.Add(this.txt_total);
            this.panel1.Controls.Add(this.txt_gst);
            this.panel1.Controls.Add(this.lbl_regDate);
            this.panel1.Controls.Add(this.lbl_payMethod);
            this.panel1.Controls.Add(this.lbl_checkNo);
            this.panel1.Controls.Add(this.lbl_payee);
            this.panel1.Controls.Add(this.lbl_total);
            this.panel1.Controls.Add(this.lbl_gst);
            this.panel1.Controls.Add(this.lbl_category);
            this.panel1.Controls.Add(this.cb_category);
            this.panel1.Controls.Add(this.txt_etc);
            this.panel1.Controls.Add(this.lbl_etc);
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.btn_list);
            this.panel1.Controls.Add(this.btn_create);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 448);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1515, 206);
            this.panel1.TabIndex = 43;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(1218, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 24);
            this.button1.TabIndex = 40;
            this.button1.Text = "테스트 기능";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(999, 55);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(86, 18);
            this.radioButton4.TabIndex = 39;
            this.radioButton4.Text = "신고 제외";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // btn_backToCreate
            // 
            this.btn_backToCreate.AutoSize = true;
            this.btn_backToCreate.Location = new System.Drawing.Point(940, 89);
            this.btn_backToCreate.Name = "btn_backToCreate";
            this.btn_backToCreate.Size = new System.Drawing.Size(115, 24);
            this.btn_backToCreate.TabIndex = 24;
            this.btn_backToCreate.Text = "Back to Create";
            this.btn_backToCreate.UseVisualStyleBackColor = true;
            this.btn_backToCreate.Visible = false;
            this.btn_backToCreate.Click += new System.EventHandler(this.btn_backToCreate_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Location = new System.Drawing.Point(930, 54);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(53, 18);
            this.radioButton5.TabIndex = 38;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "신고";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(859, 89);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 23;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Visible = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // purchaseId
            // 
            this.purchaseId.Location = new System.Drawing.Point(987, 8);
            this.purchaseId.Name = "purchaseId";
            this.purchaseId.ReadOnly = true;
            this.purchaseId.ShortcutsEnabled = false;
            this.purchaseId.Size = new System.Drawing.Size(200, 22);
            this.purchaseId.TabIndex = 20;
            this.purchaseId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(915, 16);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(20, 14);
            this.lbl_id.TabIndex = 21;
            this.lbl_id.Text = "ID";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(616, 89);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 22;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.linkLabel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.ckl_searchPayee);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1517, 656);
            this.panel2.TabIndex = 44;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.buttonExcel);
            this.panel8.Location = new System.Drawing.Point(933, 151);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(434, 53);
            this.panel8.TabIndex = 55;
            // 
            // buttonExcel
            // 
            this.buttonExcel.AutoSize = true;
            this.buttonExcel.Location = new System.Drawing.Point(9, 18);
            this.buttonExcel.Name = "buttonExcel";
            this.buttonExcel.Size = new System.Drawing.Size(101, 24);
            this.buttonExcel.TabIndex = 0;
            this.buttonExcel.TabStop = false;
            this.buttonExcel.Text = "export Excel";
            this.buttonExcel.UseVisualStyleBackColor = true;
            this.buttonExcel.Click += new System.EventHandler(this.buttonExcel_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.GroupByPayMethod);
            this.panel7.Controls.Add(this.GroupByCategory);
            this.panel7.Controls.Add(this.GroupByPayee);
            this.panel7.Location = new System.Drawing.Point(410, 151);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(516, 53);
            this.panel7.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Info;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(8, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Search";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(8, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Search";
            // 
            // GroupByPayMethod
            // 
            this.GroupByPayMethod.AutoSize = true;
            this.GroupByPayMethod.Location = new System.Drawing.Point(368, 14);
            this.GroupByPayMethod.Name = "GroupByPayMethod";
            this.GroupByPayMethod.Size = new System.Drawing.Size(137, 31);
            this.GroupByPayMethod.TabIndex = 2;
            this.GroupByPayMethod.Text = "PayMethod Group";
            this.GroupByPayMethod.UseVisualStyleBackColor = true;
            this.GroupByPayMethod.Click += new System.EventHandler(this.btn_searchMonth01_Click);
            // 
            // GroupByCategory
            // 
            this.GroupByCategory.AutoSize = true;
            this.GroupByCategory.Location = new System.Drawing.Point(241, 15);
            this.GroupByCategory.Name = "GroupByCategory";
            this.GroupByCategory.Size = new System.Drawing.Size(121, 31);
            this.GroupByCategory.TabIndex = 1;
            this.GroupByCategory.Text = "Category Group";
            this.GroupByCategory.UseVisualStyleBackColor = true;
            this.GroupByCategory.Click += new System.EventHandler(this.btn_searchMonth01_Click);
            // 
            // GroupByPayee
            // 
            this.GroupByPayee.Location = new System.Drawing.Point(121, 15);
            this.GroupByPayee.Name = "GroupByPayee";
            this.GroupByPayee.Size = new System.Drawing.Size(104, 31);
            this.GroupByPayee.TabIndex = 0;
            this.GroupByPayee.Text = "Payee Group";
            this.GroupByPayee.UseVisualStyleBackColor = true;
            this.GroupByPayee.Click += new System.EventHandler(this.btn_searchMonth01_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.lbl_gst_sum);
            this.panel6.Controls.Add(this.lbl_total_sum);
            this.panel6.Location = new System.Drawing.Point(221, 151);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(182, 53);
            this.panel6.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 14);
            this.label3.TabIndex = 44;
            this.label3.Text = "금액:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 14);
            this.label4.TabIndex = 45;
            this.label4.Text = "GST:";
            // 
            // lbl_gst_sum
            // 
            this.lbl_gst_sum.AutoSize = true;
            this.lbl_gst_sum.Location = new System.Drawing.Point(59, 27);
            this.lbl_gst_sum.Name = "lbl_gst_sum";
            this.lbl_gst_sum.Size = new System.Drawing.Size(15, 14);
            this.lbl_gst_sum.TabIndex = 47;
            this.lbl_gst_sum.Text = "0";
            // 
            // lbl_total_sum
            // 
            this.lbl_total_sum.AutoSize = true;
            this.lbl_total_sum.Location = new System.Drawing.Point(58, 11);
            this.lbl_total_sum.Name = "lbl_total_sum";
            this.lbl_total_sum.Size = new System.Drawing.Size(15, 14);
            this.lbl_total_sum.TabIndex = 48;
            this.lbl_total_sum.Text = "0";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.searchPayMethod);
            this.panel5.Controls.Add(this.searchCategory);
            this.panel5.Location = new System.Drawing.Point(221, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(182, 129);
            this.panel5.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 14);
            this.label5.TabIndex = 25;
            this.label5.Text = "pay Method";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 14);
            this.label6.TabIndex = 25;
            this.label6.Text = "Category";
            // 
            // searchPayMethod
            // 
            this.searchPayMethod.FormattingEnabled = true;
            this.searchPayMethod.Location = new System.Drawing.Point(3, 21);
            this.searchPayMethod.Name = "searchPayMethod";
            this.searchPayMethod.Size = new System.Drawing.Size(176, 21);
            this.searchPayMethod.TabIndex = 50;
            // 
            // searchCategory
            // 
            this.searchCategory.FormattingEnabled = true;
            this.searchCategory.Location = new System.Drawing.Point(3, 71);
            this.searchCategory.Name = "searchCategory";
            this.searchCategory.Size = new System.Drawing.Size(176, 21);
            this.searchCategory.TabIndex = 51;
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(11, 15);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(84, 14);
            this.linkLabel3.TabIndex = 49;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "All_checked";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cb_searchMM_02);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.cb_searchYYYY_01);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cb_searchMM_01);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.cb_searchYYYY_02);
            this.panel4.Location = new System.Drawing.Point(932, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(435, 129);
            this.panel4.TabIndex = 43;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.radioButton3);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.btn_yearAll);
            this.panel3.Controls.Add(this.cmb_year);
            this.panel3.Controls.Add(this.btn_searchMonth03);
            this.panel3.Controls.Add(this.btn_searchMonth01);
            this.panel3.Controls.Add(this.btn_searchMonth02);
            this.panel3.Controls.Add(this.btn_searchMonth04);
            this.panel3.Controls.Add(this.btn_searchMonth05);
            this.panel3.Controls.Add(this.btn_searchMonth06);
            this.panel3.Controls.Add(this.btn_searchMonth07);
            this.panel3.Controls.Add(this.btn_searchMonth08);
            this.panel3.Controls.Add(this.btn_searchMonth09);
            this.panel3.Controls.Add(this.btn_searchMonth12);
            this.panel3.Controls.Add(this.btn_searchMonth10);
            this.panel3.Controls.Add(this.btn_serchMonth11);
            this.panel3.Location = new System.Drawing.Point(409, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 129);
            this.panel3.TabIndex = 0;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(155, 45);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(86, 18);
            this.radioButton3.TabIndex = 37;
            this.radioButton3.Tag = "3";
            this.radioButton3.Text = "신고 제외";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(155, 25);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 18);
            this.radioButton2.TabIndex = 36;
            this.radioButton2.Tag = "2";
            this.radioButton2.Text = "신고";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(155, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 18);
            this.radioButton1.TabIndex = 35;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "1";
            this.radioButton1.Text = "전체";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btn_yearAll
            // 
            this.btn_yearAll.Location = new System.Drawing.Point(415, 23);
            this.btn_yearAll.Name = "btn_yearAll";
            this.btn_yearAll.Size = new System.Drawing.Size(75, 23);
            this.btn_yearAll.TabIndex = 34;
            this.btn_yearAll.Text = "Search";
            this.btn_yearAll.UseVisualStyleBackColor = true;
            this.btn_yearAll.Click += new System.EventHandler(this.btn_searchMonth01_Click);
            // 
            // cmb_year
            // 
            this.cmb_year.FormattingEnabled = true;
            this.cmb_year.Location = new System.Drawing.Point(10, 25);
            this.cmb_year.Name = "cmb_year";
            this.cmb_year.Size = new System.Drawing.Size(121, 21);
            this.cmb_year.TabIndex = 33;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1384, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 56;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1517, 656);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt_regDate;
        private System.Windows.Forms.ComboBox cb_payMethod;
        private System.Windows.Forms.TextBox txt_checkNo;
        private System.Windows.Forms.ComboBox cb_payee;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_gst;
        private System.Windows.Forms.ComboBox cb_category;
        private System.Windows.Forms.TextBox txt_etc;
        private System.Windows.Forms.Label lbl_regDate;
        private System.Windows.Forms.Label lbl_payMethod;
        private System.Windows.Forms.Label lbl_checkNo;
        private System.Windows.Forms.Label lbl_payee;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_gst;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_etc;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.Button btn_searchMonth01;
        private System.Windows.Forms.Button btn_searchMonth02;
        private System.Windows.Forms.Button btn_searchMonth03;
        private System.Windows.Forms.Button btn_searchMonth04;
        private System.Windows.Forms.Button btn_searchMonth05;
        private System.Windows.Forms.Button btn_searchMonth06;
        private System.Windows.Forms.Button btn_searchMonth07;
        private System.Windows.Forms.Button btn_searchMonth08;
        private System.Windows.Forms.Button btn_searchMonth09;
        private System.Windows.Forms.Button btn_searchMonth10;
        private System.Windows.Forms.Button btn_serchMonth11;
        private System.Windows.Forms.Button btn_searchMonth12;
        private System.Windows.Forms.CheckedListBox ckl_searchPayee;
        private System.Windows.Forms.ComboBox cb_searchYYYY_01;
        private System.Windows.Forms.ComboBox cb_searchMM_01;
        private System.Windows.Forms.ComboBox cb_searchMM_02;
        private System.Windows.Forms.ComboBox cb_searchYYYY_02;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_gst_sum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_total_sum;
        private System.Windows.Forms.ComboBox cmb_year;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.TextBox purchaseId;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_backToCreate;
        private System.Windows.Forms.Button btn_yearAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox searchCategory;
        private System.Windows.Forms.ComboBox searchPayMethod;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button GroupByPayMethod;
        private System.Windows.Forms.Button GroupByCategory;
        private System.Windows.Forms.Button GroupByPayee;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Button buttonExcel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

