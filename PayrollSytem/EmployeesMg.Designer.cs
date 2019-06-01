namespace PayrollSytem
{
    partial class EmployeesMg
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesMg));
            this.btndelete = new System.Windows.Forms.Button();
            this.Label46 = new System.Windows.Forms.Label();
            this.dtgemplist = new System.Windows.Forms.DataGridView();
            this.TabPage7 = new System.Windows.Forms.TabPage();
            this.btn_edit = new System.Windows.Forms.Button();
            this.txtempsearch = new System.Windows.Forms.TextBox();
            this.btnempnew = new System.Windows.Forms.Button();
            this.btnempsave = new System.Windows.Forms.Button();
            this.txtbplace = new System.Windows.Forms.RichTextBox();
            this.txtaddress = new System.Windows.Forms.RichTextBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.dtpdbirth = new System.Windows.Forms.DateTimePicker();
            this.Label22 = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.GroupBox9 = new System.Windows.Forms.GroupBox();
            this.Label23 = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.txtmname = new System.Windows.Forms.TextBox();
            this.rdofemale = new System.Windows.Forms.RadioButton();
            this.txtemerg = new System.Windows.Forms.TextBox();
            this.rdomale = new System.Windows.Forms.RadioButton();
            this.Label25 = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label27 = new System.Windows.Forms.Label();
            this.txtstatus = new System.Windows.Forms.ComboBox();
            this.Label28 = new System.Windows.Forms.Label();
            this.Label29 = new System.Windows.Forms.Label();
            this.Label30 = new System.Windows.Forms.Label();
            this.Label31 = new System.Windows.Forms.Label();
            this.txtpmethod = new System.Windows.Forms.ComboBox();
            this.TabControl2 = new System.Windows.Forms.TabControl();
            this.TabPage6 = new System.Windows.Forms.TabPage();
            this.btnempupdate = new System.Windows.Forms.Button();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.Label20 = new System.Windows.Forms.Label();
            this.GroupBox10 = new System.Windows.Forms.GroupBox();
            this.txtworkstatus = new System.Windows.Forms.ComboBox();
            this.Label37 = new System.Windows.Forms.Label();
            this.Label36 = new System.Windows.Forms.Label();
            this.Label35 = new System.Windows.Forms.Label();
            this.Label34 = new System.Windows.Forms.Label();
            this.Label33 = new System.Windows.Forms.Label();
            this.txtposition = new System.Windows.Forms.TextBox();
            this.txtdrate = new System.Windows.Forms.TextBox();
            this.dtpdhired = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgemplist)).BeginInit();
            this.TabPage7.SuspendLayout();
            this.GroupBox9.SuspendLayout();
            this.TabControl2.SuspendLayout();
            this.TabPage6.SuspendLayout();
            this.GroupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.btndelete.Location = new System.Drawing.Point(825, 454);
            this.btndelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(150, 28);
            this.btndelete.TabIndex = 22;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Label46
            // 
            this.Label46.AutoSize = true;
            this.Label46.Location = new System.Drawing.Point(729, 71);
            this.Label46.Name = "Label46";
            this.Label46.Size = new System.Drawing.Size(55, 16);
            this.Label46.TabIndex = 3;
            this.Label46.Text = "Search :";
            // 
            // dtgemplist
            // 
            this.dtgemplist.AllowUserToAddRows = false;
            this.dtgemplist.AllowUserToDeleteRows = false;
            this.dtgemplist.AllowUserToResizeColumns = false;
            this.dtgemplist.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.dtgemplist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgemplist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgemplist.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgemplist.BackgroundColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgemplist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgemplist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgemplist.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgemplist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgemplist.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtgemplist.Location = new System.Drawing.Point(3, 98);
            this.dtgemplist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgemplist.Name = "dtgemplist";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgemplist.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgemplist.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.dtgemplist.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgemplist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgemplist.ShowCellToolTips = false;
            this.dtgemplist.Size = new System.Drawing.Size(975, 348);
            this.dtgemplist.TabIndex = 0;
            // 
            // TabPage7
            // 
            this.TabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(30)))), ((int)(((byte)(102)))));
            this.TabPage7.Controls.Add(this.btn_edit);
            this.TabPage7.Controls.Add(this.btndelete);
            this.TabPage7.Controls.Add(this.Label46);
            this.TabPage7.Controls.Add(this.txtempsearch);
            this.TabPage7.Controls.Add(this.dtgemplist);
            this.TabPage7.Location = new System.Drawing.Point(4, 25);
            this.TabPage7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabPage7.Name = "TabPage7";
            this.TabPage7.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabPage7.Size = new System.Drawing.Size(980, 540);
            this.TabPage7.TabIndex = 1;
            this.TabPage7.Text = "Employee\'s List";
            // 
            // btn_edit
            // 
            this.btn_edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.btn_edit.Location = new System.Drawing.Point(667, 454);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(150, 28);
            this.btn_edit.TabIndex = 23;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txtempsearch
            // 
            this.txtempsearch.Location = new System.Drawing.Point(785, 66);
            this.txtempsearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtempsearch.Name = "txtempsearch";
            this.txtempsearch.Size = new System.Drawing.Size(189, 23);
            this.txtempsearch.TabIndex = 2;
            this.txtempsearch.TextChanged += new System.EventHandler(this.txtempsearch_TextChanged);
            // 
            // btnempnew
            // 
            this.btnempnew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(60)))), ((int)(((byte)(106)))));
            this.btnempnew.Location = new System.Drawing.Point(568, 455);
            this.btnempnew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnempnew.Name = "btnempnew";
            this.btnempnew.Size = new System.Drawing.Size(87, 39);
            this.btnempnew.TabIndex = 15;
            this.btnempnew.Text = "New";
            this.btnempnew.UseVisualStyleBackColor = true;
            this.btnempnew.Click += new System.EventHandler(this.btnempnew_Click);
            // 
            // btnempsave
            // 
            this.btnempsave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(60)))), ((int)(((byte)(106)))));
            this.btnempsave.Location = new System.Drawing.Point(379, 455);
            this.btnempsave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnempsave.Name = "btnempsave";
            this.btnempsave.Size = new System.Drawing.Size(87, 39);
            this.btnempsave.TabIndex = 16;
            this.btnempsave.Text = "Save";
            this.btnempsave.UseVisualStyleBackColor = true;
            this.btnempsave.Click += new System.EventHandler(this.btnempsave_Click);
            // 
            // txtbplace
            // 
            this.txtbplace.Location = new System.Drawing.Point(99, 156);
            this.txtbplace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbplace.Name = "txtbplace";
            this.txtbplace.Size = new System.Drawing.Size(193, 66);
            this.txtbplace.TabIndex = 17;
            this.txtbplace.Text = "";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(99, 75);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(193, 66);
            this.txtaddress.TabIndex = 17;
            this.txtaddress.Text = "";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(3, 160);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(83, 16);
            this.Label21.TabIndex = 14;
            this.Label21.Text = "Place of Birth";
            // 
            // dtpdbirth
            // 
            this.dtpdbirth.CalendarForeColor = System.Drawing.Color.PeachPuff;
            this.dtpdbirth.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(60)))), ((int)(((byte)(105)))));
            this.dtpdbirth.CalendarTitleForeColor = System.Drawing.Color.Gold;
            this.dtpdbirth.CustomFormat = "yyyy-MM-dd";
            this.dtpdbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdbirth.Location = new System.Drawing.Point(730, 117);
            this.dtpdbirth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpdbirth.Name = "dtpdbirth";
            this.dtpdbirth.Size = new System.Drawing.Size(140, 23);
            this.dtpdbirth.TabIndex = 12;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Location = new System.Drawing.Point(643, 123);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(81, 16);
            this.Label22.TabIndex = 11;
            this.Label22.Text = "Date of Birth";
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(412, 39);
            this.txtlname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(207, 23);
            this.txtlname.TabIndex = 0;
            // 
            // GroupBox9
            // 
            this.GroupBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(60)))), ((int)(((byte)(106)))));
            this.GroupBox9.Controls.Add(this.txtbplace);
            this.GroupBox9.Controls.Add(this.txtaddress);
            this.GroupBox9.Controls.Add(this.Label21);
            this.GroupBox9.Controls.Add(this.dtpdbirth);
            this.GroupBox9.Controls.Add(this.Label22);
            this.GroupBox9.Controls.Add(this.txtlname);
            this.GroupBox9.Controls.Add(this.Label23);
            this.GroupBox9.Controls.Add(this.txtcontact);
            this.GroupBox9.Controls.Add(this.txtage);
            this.GroupBox9.Controls.Add(this.txtfname);
            this.GroupBox9.Controls.Add(this.Label24);
            this.GroupBox9.Controls.Add(this.txtmname);
            this.GroupBox9.Controls.Add(this.rdofemale);
            this.GroupBox9.Controls.Add(this.txtemerg);
            this.GroupBox9.Controls.Add(this.rdomale);
            this.GroupBox9.Controls.Add(this.Label25);
            this.GroupBox9.Controls.Add(this.Label26);
            this.GroupBox9.Controls.Add(this.Label27);
            this.GroupBox9.Controls.Add(this.txtstatus);
            this.GroupBox9.Controls.Add(this.Label28);
            this.GroupBox9.Controls.Add(this.Label29);
            this.GroupBox9.Controls.Add(this.Label30);
            this.GroupBox9.Controls.Add(this.Label31);
            this.GroupBox9.ForeColor = System.Drawing.Color.Gold;
            this.GroupBox9.Location = new System.Drawing.Point(36, 58);
            this.GroupBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox9.Name = "GroupBox9";
            this.GroupBox9.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox9.Size = new System.Drawing.Size(923, 233);
            this.GroupBox9.TabIndex = 18;
            this.GroupBox9.TabStop = false;
            this.GroupBox9.Text = "Personal Information";
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(374, 166);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(28, 16);
            this.Label23.TabIndex = 9;
            this.Label23.Text = "Age";
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(412, 73);
            this.txtcontact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcontact.MaxLength = 11;
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(207, 23);
            this.txtcontact.TabIndex = 0;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(412, 161);
            this.txtage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtage.MaxLength = 2;
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(67, 23);
            this.txtage.TabIndex = 8;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(99, 39);
            this.txtfname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(198, 23);
            this.txtfname.TabIndex = 0;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(374, 123);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(29, 16);
            this.Label24.TabIndex = 7;
            this.Label24.Text = "Sex";
            // 
            // txtmname
            // 
            this.txtmname.Location = new System.Drawing.Point(730, 39);
            this.txtmname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmname.Name = "txtmname";
            this.txtmname.Size = new System.Drawing.Size(181, 23);
            this.txtmname.TabIndex = 0;
            // 
            // rdofemale
            // 
            this.rdofemale.AutoSize = true;
            this.rdofemale.Location = new System.Drawing.Point(474, 121);
            this.rdofemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdofemale.Name = "rdofemale";
            this.rdofemale.Size = new System.Drawing.Size(63, 20);
            this.rdofemale.TabIndex = 6;
            this.rdofemale.TabStop = true;
            this.rdofemale.Text = "Female";
            this.rdofemale.UseVisualStyleBackColor = true;
            // 
            // txtemerg
            // 
            this.txtemerg.Location = new System.Drawing.Point(730, 161);
            this.txtemerg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtemerg.MaxLength = 11;
            this.txtemerg.Name = "txtemerg";
            this.txtemerg.Size = new System.Drawing.Size(180, 23);
            this.txtemerg.TabIndex = 0;
            // 
            // rdomale
            // 
            this.rdomale.AutoSize = true;
            this.rdomale.Location = new System.Drawing.Point(411, 121);
            this.rdomale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdomale.Name = "rdomale";
            this.rdomale.Size = new System.Drawing.Size(52, 20);
            this.rdomale.TabIndex = 6;
            this.rdomale.TabStop = true;
            this.rdomale.Text = "Male";
            this.rdomale.UseVisualStyleBackColor = true;
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.Location = new System.Drawing.Point(307, 75);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(96, 16);
            this.Label25.TabIndex = 1;
            this.Label25.Text = "Contact Number";
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.Location = new System.Drawing.Point(26, 43);
            this.Label26.Name = "Label26";
            this.Label26.Size = new System.Drawing.Size(68, 16);
            this.Label26.TabIndex = 1;
            this.Label26.Text = "First Name";
            // 
            // Label27
            // 
            this.Label27.AutoSize = true;
            this.Label27.Location = new System.Drawing.Point(680, 75);
            this.Label27.Name = "Label27";
            this.Label27.Size = new System.Drawing.Size(43, 16);
            this.Label27.TabIndex = 1;
            this.Label27.Text = "Status";
            // 
            // txtstatus
            // 
            this.txtstatus.FormattingEnabled = true;
            this.txtstatus.Items.AddRange(new object[] {
            "Married",
            "Single",
            "Widow"});
            this.txtstatus.Location = new System.Drawing.Point(730, 71);
            this.txtstatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(140, 24);
            this.txtstatus.TabIndex = 2;
            this.txtstatus.Text = "Single";
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.Location = new System.Drawing.Point(337, 43);
            this.Label28.Name = "Label28";
            this.Label28.Size = new System.Drawing.Size(65, 16);
            this.Label28.TabIndex = 1;
            this.Label28.Text = "Last Name";
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.Location = new System.Drawing.Point(40, 75);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(49, 16);
            this.Label29.TabIndex = 1;
            this.Label29.Text = "Address";
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.Location = new System.Drawing.Point(528, 166);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(195, 16);
            this.Label30.TabIndex = 1;
            this.Label30.Text = "Contact no. [ case of emergency ]";
            // 
            // Label31
            // 
            this.Label31.AutoSize = true;
            this.Label31.Location = new System.Drawing.Point(643, 43);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(78, 16);
            this.Label31.TabIndex = 1;
            this.Label31.Text = "Middle Name";
            // 
            // txtpmethod
            // 
            this.txtpmethod.FormattingEnabled = true;
            this.txtpmethod.Items.AddRange(new object[] {
            "Weekly",
            "Monthly"});
            this.txtpmethod.Location = new System.Drawing.Point(105, 59);
            this.txtpmethod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpmethod.Name = "txtpmethod";
            this.txtpmethod.Size = new System.Drawing.Size(179, 24);
            this.txtpmethod.TabIndex = 0;
            this.txtpmethod.Text = "Weekly";
            // 
            // TabControl2
            // 
            this.TabControl2.Controls.Add(this.TabPage6);
            this.TabControl2.Controls.Add(this.TabPage7);
            this.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl2.Location = new System.Drawing.Point(0, 0);
            this.TabControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabControl2.Name = "TabControl2";
            this.TabControl2.SelectedIndex = 0;
            this.TabControl2.Size = new System.Drawing.Size(988, 569);
            this.TabControl2.TabIndex = 2;
            // 
            // TabPage6
            // 
            this.TabPage6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(30)))), ((int)(((byte)(103)))));
            this.TabPage6.Controls.Add(this.btnempupdate);
            this.TabPage6.Controls.Add(this.txtcode);
            this.TabPage6.Controls.Add(this.Label20);
            this.TabPage6.Controls.Add(this.GroupBox10);
            this.TabPage6.Controls.Add(this.GroupBox9);
            this.TabPage6.Controls.Add(this.btnempnew);
            this.TabPage6.Controls.Add(this.btnempsave);
            this.TabPage6.Location = new System.Drawing.Point(4, 25);
            this.TabPage6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabPage6.Name = "TabPage6";
            this.TabPage6.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TabPage6.Size = new System.Drawing.Size(980, 540);
            this.TabPage6.TabIndex = 0;
            this.TabPage6.Text = "Information";
            // 
            // btnempupdate
            // 
            this.btnempupdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(60)))), ((int)(((byte)(106)))));
            this.btnempupdate.Location = new System.Drawing.Point(474, 455);
            this.btnempupdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnempupdate.Name = "btnempupdate";
            this.btnempupdate.Size = new System.Drawing.Size(87, 39);
            this.btnempupdate.TabIndex = 21;
            this.btnempupdate.Text = "Update";
            this.btnempupdate.UseVisualStyleBackColor = true;
            this.btnempupdate.Click += new System.EventHandler(this.btnempupdate_Click);
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(135, 26);
            this.txtcode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(233, 23);
            this.txtcode.TabIndex = 15;
            this.txtcode.TextChanged += new System.EventHandler(this.txtcode_TextChanged);
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(43, 30);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(80, 16);
            this.Label20.TabIndex = 16;
            this.Label20.Text = "Assign code :";
            // 
            // GroupBox10
            // 
            this.GroupBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(60)))), ((int)(((byte)(106)))));
            this.GroupBox10.Controls.Add(this.txtworkstatus);
            this.GroupBox10.Controls.Add(this.Label37);
            this.GroupBox10.Controls.Add(this.Label36);
            this.GroupBox10.Controls.Add(this.Label35);
            this.GroupBox10.Controls.Add(this.Label34);
            this.GroupBox10.Controls.Add(this.Label33);
            this.GroupBox10.Controls.Add(this.txtposition);
            this.GroupBox10.Controls.Add(this.txtdrate);
            this.GroupBox10.Controls.Add(this.dtpdhired);
            this.GroupBox10.Controls.Add(this.txtpmethod);
            this.GroupBox10.ForeColor = System.Drawing.Color.Gold;
            this.GroupBox10.Location = new System.Drawing.Point(36, 298);
            this.GroupBox10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox10.Name = "GroupBox10";
            this.GroupBox10.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupBox10.Size = new System.Drawing.Size(923, 137);
            this.GroupBox10.TabIndex = 19;
            this.GroupBox10.TabStop = false;
            this.GroupBox10.Text = "Work Information";
            // 
            // txtworkstatus
            // 
            this.txtworkstatus.FormattingEnabled = true;
            this.txtworkstatus.Items.AddRange(new object[] {
            "Active",
            "Resigned",
            "Retired"});
            this.txtworkstatus.Location = new System.Drawing.Point(407, 55);
            this.txtworkstatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtworkstatus.Name = "txtworkstatus";
            this.txtworkstatus.Size = new System.Drawing.Size(179, 24);
            this.txtworkstatus.TabIndex = 8;
            this.txtworkstatus.Text = "Active";
            // 
            // Label37
            // 
            this.Label37.AutoSize = true;
            this.Label37.Location = new System.Drawing.Point(26, 27);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(73, 16);
            this.Label37.TabIndex = 7;
            this.Label37.Text = "Daily Rate :";
            // 
            // Label36
            // 
            this.Label36.AutoSize = true;
            this.Label36.Location = new System.Drawing.Point(342, 27);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(58, 16);
            this.Label36.TabIndex = 6;
            this.Label36.Text = "Position :";
            // 
            // Label35
            // 
            this.Label35.AutoSize = true;
            this.Label35.Location = new System.Drawing.Point(350, 59);
            this.Label35.Name = "Label35";
            this.Label35.Size = new System.Drawing.Size(53, 16);
            this.Label35.TabIndex = 5;
            this.Label35.Text = "Status :";
            // 
            // Label34
            // 
            this.Label34.AutoSize = true;
            this.Label34.Location = new System.Drawing.Point(16, 62);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(81, 16);
            this.Label34.TabIndex = 4;
            this.Label34.Text = "Pay Method :";
            // 
            // Label33
            // 
            this.Label33.AutoSize = true;
            this.Label33.Location = new System.Drawing.Point(619, 26);
            this.Label33.Name = "Label33";
            this.Label33.Size = new System.Drawing.Size(76, 16);
            this.Label33.TabIndex = 3;
            this.Label33.Text = "Date Hired :";
            // 
            // txtposition
            // 
            this.txtposition.Location = new System.Drawing.Point(405, 23);
            this.txtposition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtposition.Name = "txtposition";
            this.txtposition.Size = new System.Drawing.Size(181, 23);
            this.txtposition.TabIndex = 2;
            // 
            // txtdrate
            // 
            this.txtdrate.Location = new System.Drawing.Point(105, 23);
            this.txtdrate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdrate.MaxLength = 3;
            this.txtdrate.Name = "txtdrate";
            this.txtdrate.Size = new System.Drawing.Size(179, 23);
            this.txtdrate.TabIndex = 2;
            // 
            // dtpdhired
            // 
            this.dtpdhired.CalendarForeColor = System.Drawing.Color.PeachPuff;
            this.dtpdhired.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(30)))), ((int)(((byte)(102)))));
            this.dtpdhired.CalendarTitleForeColor = System.Drawing.Color.Gold;
            this.dtpdhired.CustomFormat = "yyyy-MM-dd";
            this.dtpdhired.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpdhired.Location = new System.Drawing.Point(701, 23);
            this.dtpdhired.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpdhired.Name = "dtpdhired";
            this.dtpdhired.Size = new System.Drawing.Size(179, 23);
            this.dtpdhired.TabIndex = 1;
            // 
            // EmployeesMg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(30)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(988, 569);
            this.Controls.Add(this.TabControl2);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gold;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmployeesMg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cheetah Services | Employees Information Manager";
            this.Load += new System.EventHandler(this.frm_Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgemplist)).EndInit();
            this.TabPage7.ResumeLayout(false);
            this.TabPage7.PerformLayout();
            this.GroupBox9.ResumeLayout(false);
            this.GroupBox9.PerformLayout();
            this.TabControl2.ResumeLayout(false);
            this.TabPage6.ResumeLayout(false);
            this.TabPage6.PerformLayout();
            this.GroupBox10.ResumeLayout(false);
            this.GroupBox10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btndelete;
        internal System.Windows.Forms.Label Label46;
        internal System.Windows.Forms.DataGridView dtgemplist;
        internal System.Windows.Forms.TabPage TabPage7;
        internal System.Windows.Forms.TextBox txtempsearch;
        internal System.Windows.Forms.Button btnempnew;
        internal System.Windows.Forms.Button btnempsave;
        internal System.Windows.Forms.RichTextBox txtbplace;
        internal System.Windows.Forms.RichTextBox txtaddress;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.DateTimePicker dtpdbirth;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.TextBox txtlname;
        internal System.Windows.Forms.GroupBox GroupBox9;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.TextBox txtcontact;
        internal System.Windows.Forms.TextBox txtage;
        internal System.Windows.Forms.TextBox txtfname;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.TextBox txtmname;
        internal System.Windows.Forms.RadioButton rdofemale;
        internal System.Windows.Forms.TextBox txtemerg;
        internal System.Windows.Forms.RadioButton rdomale;
        internal System.Windows.Forms.Label Label25;
        internal System.Windows.Forms.Label Label26;
        internal System.Windows.Forms.Label Label27;
        internal System.Windows.Forms.ComboBox txtstatus;
        internal System.Windows.Forms.Label Label28;
        internal System.Windows.Forms.Label Label29;
        internal System.Windows.Forms.Label Label30;
        internal System.Windows.Forms.Label Label31;
        internal System.Windows.Forms.ComboBox txtpmethod;
        internal System.Windows.Forms.TabControl TabControl2;
        internal System.Windows.Forms.TabPage TabPage6;
        internal System.Windows.Forms.Button btnempupdate;
        internal System.Windows.Forms.TextBox txtcode;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.GroupBox GroupBox10;
        internal System.Windows.Forms.ComboBox txtworkstatus;
        internal System.Windows.Forms.Label Label37;
        internal System.Windows.Forms.Label Label36;
        internal System.Windows.Forms.Label Label35;
        internal System.Windows.Forms.Label Label34;
        internal System.Windows.Forms.Label Label33;
        internal System.Windows.Forms.TextBox txtposition;
        internal System.Windows.Forms.TextBox txtdrate;
        internal System.Windows.Forms.DateTimePicker dtpdhired;
        internal System.Windows.Forms.Button btn_edit;
    }
}