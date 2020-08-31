namespace connection_status
{
    partial class DataUsage
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
            this.btnopen = new System.Windows.Forms.Button();
            this.btnclosed = new System.Windows.Forms.Button();
            this.btnconnection = new System.Windows.Forms.Button();
            this.btnevaluate = new System.Windows.Forms.TabControl();
            this.tabcheck = new System.Windows.Forms.TabPage();
            this.tablist = new System.Windows.Forms.TabPage();
            this.btntab2listview = new System.Windows.Forms.Button();
            this.btntab2datagridview = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.namesurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.graduationdepartment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.militarystatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.englishknowledge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.csharpknowledge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabdataadd = new System.Windows.Forms.TabPage();
            this.btnadddata = new System.Windows.Forms.Button();
            this.chkcsharp = new System.Windows.Forms.CheckBox();
            this.chkenglish = new System.Windows.Forms.CheckBox();
            this.chkmilitary = new System.Windows.Forms.CheckBox();
            this.txtgraduation = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtnamesurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabdatadel = new System.Windows.Forms.TabPage();
            this.chkcsharppp = new System.Windows.Forms.CheckBox();
            this.chkengg = new System.Windows.Forms.CheckBox();
            this.chkmilitaryyy = new System.Windows.Forms.CheckBox();
            this.txtgraduationdep = new System.Windows.Forms.TextBox();
            this.txtagee = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btndataupdate = new System.Windows.Forms.Button();
            this.btndatadelete = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnviewevaluate = new System.Windows.Forms.Button();
            this.dataevaluation = new System.Windows.Forms.DataGridView();
            this.damlaaksuDataSet = new connection_status.damlaaksuDataSet();
            this.applicantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicantsTableAdapter = new connection_status.damlaaksuDataSetTableAdapters.applicantsTableAdapter();
            this.btnevaluate.SuspendLayout();
            this.tabcheck.SuspendLayout();
            this.tablist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabdataadd.SuspendLayout();
            this.tabdatadel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataevaluation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.damlaaksuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(52, 29);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(106, 22);
            this.btnopen.TabIndex = 0;
            this.btnopen.Text = "Open Connection";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclosed
            // 
            this.btnclosed.Location = new System.Drawing.Point(228, 27);
            this.btnclosed.Name = "btnclosed";
            this.btnclosed.Size = new System.Drawing.Size(137, 24);
            this.btnclosed.TabIndex = 1;
            this.btnclosed.Text = "Close Connection";
            this.btnclosed.UseVisualStyleBackColor = true;
            this.btnclosed.Click += new System.EventHandler(this.btnclosed_Click);
            // 
            // btnconnection
            // 
            this.btnconnection.Location = new System.Drawing.Point(133, 67);
            this.btnconnection.Name = "btnconnection";
            this.btnconnection.Size = new System.Drawing.Size(155, 24);
            this.btnconnection.TabIndex = 2;
            this.btnconnection.Text = "Check Connection";
            this.btnconnection.UseVisualStyleBackColor = true;
            this.btnconnection.Click += new System.EventHandler(this.btnconnection_Click);
            // 
            // btnevaluate
            // 
            this.btnevaluate.Controls.Add(this.tabcheck);
            this.btnevaluate.Controls.Add(this.tablist);
            this.btnevaluate.Controls.Add(this.tabdataadd);
            this.btnevaluate.Controls.Add(this.tabdatadel);
            this.btnevaluate.Controls.Add(this.tabPage1);
            this.btnevaluate.Location = new System.Drawing.Point(12, 12);
            this.btnevaluate.Name = "btnevaluate";
            this.btnevaluate.SelectedIndex = 0;
            this.btnevaluate.Size = new System.Drawing.Size(721, 392);
            this.btnevaluate.TabIndex = 3;
            // 
            // tabcheck
            // 
            this.tabcheck.Controls.Add(this.btnclosed);
            this.tabcheck.Controls.Add(this.btnconnection);
            this.tabcheck.Controls.Add(this.btnopen);
            this.tabcheck.Location = new System.Drawing.Point(4, 22);
            this.tabcheck.Name = "tabcheck";
            this.tabcheck.Padding = new System.Windows.Forms.Padding(3);
            this.tabcheck.Size = new System.Drawing.Size(713, 366);
            this.tabcheck.TabIndex = 0;
            this.tabcheck.Text = "Connection Status Check";
            this.tabcheck.UseVisualStyleBackColor = true;
            // 
            // tablist
            // 
            this.tablist.Controls.Add(this.btntab2listview);
            this.tablist.Controls.Add(this.btntab2datagridview);
            this.tablist.Controls.Add(this.listView1);
            this.tablist.Controls.Add(this.dataGridView1);
            this.tablist.Location = new System.Drawing.Point(4, 22);
            this.tablist.Name = "tablist";
            this.tablist.Padding = new System.Windows.Forms.Padding(3);
            this.tablist.Size = new System.Drawing.Size(713, 366);
            this.tablist.TabIndex = 1;
            this.tablist.Text = "Data Listing";
            this.tablist.UseVisualStyleBackColor = true;
            // 
            // btntab2listview
            // 
            this.btntab2listview.Location = new System.Drawing.Point(470, 330);
            this.btntab2listview.Name = "btntab2listview";
            this.btntab2listview.Size = new System.Drawing.Size(140, 29);
            this.btntab2listview.TabIndex = 3;
            this.btntab2listview.Text = "List wia ListView";
            this.btntab2listview.UseVisualStyleBackColor = true;
            this.btntab2listview.Click += new System.EventHandler(this.btntab2listview_Click);
            // 
            // btntab2datagridview
            // 
            this.btntab2datagridview.Location = new System.Drawing.Point(82, 330);
            this.btntab2datagridview.Name = "btntab2datagridview";
            this.btntab2datagridview.Size = new System.Drawing.Size(141, 29);
            this.btntab2datagridview.TabIndex = 2;
            this.btntab2datagridview.Text = "List wia DataGridView";
            this.btntab2datagridview.UseVisualStyleBackColor = true;
            this.btntab2datagridview.Click += new System.EventHandler(this.btntab2datagridview_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.namesurname,
            this.age,
            this.graduationdepartment,
            this.militarystatus,
            this.englishknowledge,
            this.csharpknowledge});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(385, 15);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(310, 309);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // namesurname
            // 
            this.namesurname.Text = "name and surname";
            this.namesurname.Width = 76;
            // 
            // age
            // 
            this.age.Text = "age";
            // 
            // graduationdepartment
            // 
            this.graduationdepartment.Text = "graduation department";
            // 
            // militarystatus
            // 
            this.militarystatus.Text = "military status";
            // 
            // englishknowledge
            // 
            this.englishknowledge.Text = "english knowledge";
            // 
            // csharpknowledge
            // 
            this.csharpknowledge.Text = "c# knowledge";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(312, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabdataadd
            // 
            this.tabdataadd.Controls.Add(this.btnadddata);
            this.tabdataadd.Controls.Add(this.chkcsharp);
            this.tabdataadd.Controls.Add(this.chkenglish);
            this.tabdataadd.Controls.Add(this.chkmilitary);
            this.tabdataadd.Controls.Add(this.txtgraduation);
            this.tabdataadd.Controls.Add(this.txtage);
            this.tabdataadd.Controls.Add(this.txtnamesurname);
            this.tabdataadd.Controls.Add(this.label6);
            this.tabdataadd.Controls.Add(this.label5);
            this.tabdataadd.Controls.Add(this.label4);
            this.tabdataadd.Controls.Add(this.label3);
            this.tabdataadd.Controls.Add(this.label2);
            this.tabdataadd.Controls.Add(this.label1);
            this.tabdataadd.Location = new System.Drawing.Point(4, 22);
            this.tabdataadd.Name = "tabdataadd";
            this.tabdataadd.Padding = new System.Windows.Forms.Padding(3);
            this.tabdataadd.Size = new System.Drawing.Size(713, 366);
            this.tabdataadd.TabIndex = 2;
            this.tabdataadd.Text = "Data Adding";
            this.tabdataadd.UseVisualStyleBackColor = true;
            // 
            // btnadddata
            // 
            this.btnadddata.Location = new System.Drawing.Point(61, 186);
            this.btnadddata.Name = "btnadddata";
            this.btnadddata.Size = new System.Drawing.Size(152, 30);
            this.btnadddata.TabIndex = 12;
            this.btnadddata.Text = "Add Data Source";
            this.btnadddata.UseVisualStyleBackColor = true;
            this.btnadddata.Click += new System.EventHandler(this.btnadddata_Click);
            // 
            // chkcsharp
            // 
            this.chkcsharp.AutoSize = true;
            this.chkcsharp.Location = new System.Drawing.Point(148, 144);
            this.chkcsharp.Name = "chkcsharp";
            this.chkcsharp.Size = new System.Drawing.Size(48, 17);
            this.chkcsharp.TabIndex = 11;
            this.chkcsharp.Text = "Exist";
            this.chkcsharp.UseVisualStyleBackColor = true;
            // 
            // chkenglish
            // 
            this.chkenglish.AutoSize = true;
            this.chkenglish.Location = new System.Drawing.Point(148, 121);
            this.chkenglish.Name = "chkenglish";
            this.chkenglish.Size = new System.Drawing.Size(48, 17);
            this.chkenglish.TabIndex = 10;
            this.chkenglish.Text = "Exist";
            this.chkenglish.UseVisualStyleBackColor = true;
            // 
            // chkmilitary
            // 
            this.chkmilitary.AutoSize = true;
            this.chkmilitary.Location = new System.Drawing.Point(148, 96);
            this.chkmilitary.Name = "chkmilitary";
            this.chkmilitary.Size = new System.Drawing.Size(52, 17);
            this.chkmilitary.TabIndex = 9;
            this.chkmilitary.Text = "Done";
            this.chkmilitary.UseVisualStyleBackColor = true;
            // 
            // txtgraduation
            // 
            this.txtgraduation.Location = new System.Drawing.Point(148, 69);
            this.txtgraduation.Name = "txtgraduation";
            this.txtgraduation.Size = new System.Drawing.Size(100, 20);
            this.txtgraduation.TabIndex = 8;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(148, 43);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(100, 20);
            this.txtage.TabIndex = 7;
            // 
            // txtnamesurname
            // 
            this.txtnamesurname.Location = new System.Drawing.Point(148, 13);
            this.txtnamesurname.Name = "txtnamesurname";
            this.txtnamesurname.Size = new System.Drawing.Size(100, 20);
            this.txtnamesurname.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "C# Knowledge";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "English Knowledge";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Military Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Graduation Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name and Surname";
            // 
            // tabdatadel
            // 
            this.tabdatadel.Controls.Add(this.chkcsharppp);
            this.tabdatadel.Controls.Add(this.chkengg);
            this.tabdatadel.Controls.Add(this.chkmilitaryyy);
            this.tabdatadel.Controls.Add(this.txtgraduationdep);
            this.tabdatadel.Controls.Add(this.txtagee);
            this.tabdatadel.Controls.Add(this.txtname);
            this.tabdatadel.Controls.Add(this.label12);
            this.tabdatadel.Controls.Add(this.label11);
            this.tabdatadel.Controls.Add(this.label10);
            this.tabdatadel.Controls.Add(this.label9);
            this.tabdatadel.Controls.Add(this.label8);
            this.tabdatadel.Controls.Add(this.label7);
            this.tabdatadel.Controls.Add(this.btndataupdate);
            this.tabdatadel.Controls.Add(this.btndatadelete);
            this.tabdatadel.Controls.Add(this.listView2);
            this.tabdatadel.Location = new System.Drawing.Point(4, 22);
            this.tabdatadel.Name = "tabdatadel";
            this.tabdatadel.Padding = new System.Windows.Forms.Padding(3);
            this.tabdatadel.Size = new System.Drawing.Size(713, 366);
            this.tabdatadel.TabIndex = 3;
            this.tabdatadel.Text = "Data Delete and Update";
            this.tabdatadel.UseVisualStyleBackColor = true;
            // 
            // chkcsharppp
            // 
            this.chkcsharppp.AutoSize = true;
            this.chkcsharppp.Location = new System.Drawing.Point(587, 145);
            this.chkcsharppp.Name = "chkcsharppp";
            this.chkcsharppp.Size = new System.Drawing.Size(48, 17);
            this.chkcsharppp.TabIndex = 23;
            this.chkcsharppp.Text = "Exist";
            this.chkcsharppp.UseVisualStyleBackColor = true;
            // 
            // chkengg
            // 
            this.chkengg.AutoSize = true;
            this.chkengg.Location = new System.Drawing.Point(587, 122);
            this.chkengg.Name = "chkengg";
            this.chkengg.Size = new System.Drawing.Size(48, 17);
            this.chkengg.TabIndex = 22;
            this.chkengg.Text = "Exist";
            this.chkengg.UseVisualStyleBackColor = true;
            // 
            // chkmilitaryyy
            // 
            this.chkmilitaryyy.AutoSize = true;
            this.chkmilitaryyy.Location = new System.Drawing.Point(587, 97);
            this.chkmilitaryyy.Name = "chkmilitaryyy";
            this.chkmilitaryyy.Size = new System.Drawing.Size(52, 17);
            this.chkmilitaryyy.TabIndex = 21;
            this.chkmilitaryyy.Text = "Done";
            this.chkmilitaryyy.UseVisualStyleBackColor = true;
            // 
            // txtgraduationdep
            // 
            this.txtgraduationdep.Location = new System.Drawing.Point(587, 71);
            this.txtgraduationdep.Name = "txtgraduationdep";
            this.txtgraduationdep.Size = new System.Drawing.Size(100, 20);
            this.txtgraduationdep.TabIndex = 20;
            // 
            // txtagee
            // 
            this.txtagee.Location = new System.Drawing.Point(587, 45);
            this.txtagee.Name = "txtagee";
            this.txtagee.Size = new System.Drawing.Size(100, 20);
            this.txtagee.TabIndex = 19;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(587, 18);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(464, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "C# Knowledge";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(464, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "English Knowledge";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(464, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Military Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(464, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Graduation Department";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(464, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(464, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Name and Surname";
            // 
            // btndataupdate
            // 
            this.btndataupdate.Location = new System.Drawing.Point(531, 192);
            this.btndataupdate.Name = "btndataupdate";
            this.btndataupdate.Size = new System.Drawing.Size(104, 24);
            this.btndataupdate.TabIndex = 4;
            this.btndataupdate.Text = "Update Data";
            this.btndataupdate.UseVisualStyleBackColor = true;
            this.btndataupdate.Click += new System.EventHandler(this.btndataupdate_Click);
            // 
            // btndatadelete
            // 
            this.btndatadelete.Location = new System.Drawing.Point(6, 320);
            this.btndatadelete.Name = "btndatadelete";
            this.btndatadelete.Size = new System.Drawing.Size(75, 23);
            this.btndatadelete.TabIndex = 3;
            this.btndatadelete.Text = "Delete Data";
            this.btndatadelete.UseVisualStyleBackColor = true;
            this.btndatadelete.Click += new System.EventHandler(this.btndatadelete_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(6, 5);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(381, 309);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "name and surname";
            this.columnHeader1.Width = 76;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "age";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "graduation department";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "military status";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "english knowledge";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "c# knowledge";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnviewevaluate);
            this.tabPage1.Controls.Add(this.dataevaluation);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(713, 366);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Evaluate the Candidate";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnviewevaluate
            // 
            this.btnviewevaluate.Location = new System.Drawing.Point(251, 315);
            this.btnviewevaluate.Name = "btnviewevaluate";
            this.btnviewevaluate.Size = new System.Drawing.Size(163, 28);
            this.btnviewevaluate.TabIndex = 1;
            this.btnviewevaluate.Text = "Evaluate the Candidates";
            this.btnviewevaluate.UseVisualStyleBackColor = true;
            this.btnviewevaluate.Click += new System.EventHandler(this.btnviewevaluate_Click);
            // 
            // dataevaluation
            // 
            this.dataevaluation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataevaluation.Location = new System.Drawing.Point(18, 33);
            this.dataevaluation.Name = "dataevaluation";
            this.dataevaluation.Size = new System.Drawing.Size(639, 276);
            this.dataevaluation.TabIndex = 0;
            // 
            // damlaaksuDataSet
            // 
            this.damlaaksuDataSet.DataSetName = "damlaaksuDataSet";
            this.damlaaksuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applicantsBindingSource
            // 
            this.applicantsBindingSource.DataMember = "applicants";
            this.applicantsBindingSource.DataSource = this.damlaaksuDataSet;
            // 
            // applicantsTableAdapter
            // 
            this.applicantsTableAdapter.ClearBeforeFill = true;
            // 
            // DataUsage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 436);
            this.Controls.Add(this.btnevaluate);
            this.Name = "DataUsage";
            this.Text = "Data usage";
            this.Load += new System.EventHandler(this.DataUsage_Load);
            this.btnevaluate.ResumeLayout(false);
            this.tabcheck.ResumeLayout(false);
            this.tablist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabdataadd.ResumeLayout(false);
            this.tabdataadd.PerformLayout();
            this.tabdatadel.ResumeLayout(false);
            this.tabdatadel.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataevaluation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.damlaaksuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button btnclosed;
        private System.Windows.Forms.Button btnconnection;
        private System.Windows.Forms.TabControl btnevaluate;
        private System.Windows.Forms.TabPage tabcheck;
        private System.Windows.Forms.TabPage tablist;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btntab2listview;
        private System.Windows.Forms.Button btntab2datagridview;
        private System.Windows.Forms.ColumnHeader namesurname;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.ColumnHeader graduationdepartment;
        private System.Windows.Forms.ColumnHeader militarystatus;
        private System.Windows.Forms.ColumnHeader englishknowledge;
        private System.Windows.Forms.ColumnHeader csharpknowledge;
        private System.Windows.Forms.TabPage tabdataadd;
        private System.Windows.Forms.Button btnadddata;
        private System.Windows.Forms.CheckBox chkcsharp;
        private System.Windows.Forms.CheckBox chkenglish;
        private System.Windows.Forms.CheckBox chkmilitary;
        private System.Windows.Forms.TextBox txtgraduation;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtnamesurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabdatadel;
        private System.Windows.Forms.Button btndatadelete;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btndataupdate;
        private System.Windows.Forms.CheckBox chkcsharppp;
        private System.Windows.Forms.CheckBox chkengg;
        private System.Windows.Forms.CheckBox chkmilitaryyy;
        private System.Windows.Forms.TextBox txtgraduationdep;
        private System.Windows.Forms.TextBox txtagee;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnviewevaluate;
        private System.Windows.Forms.DataGridView dataevaluation;
        private damlaaksuDataSet damlaaksuDataSet;
        private System.Windows.Forms.BindingSource applicantsBindingSource;
        private damlaaksuDataSetTableAdapters.applicantsTableAdapter applicantsTableAdapter;
    }
}

