namespace Отель
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.b_LoadFile = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.b_DeleteRow = new System.Windows.Forms.Button();
            this.b_SaveList = new System.Windows.Forms.Button();
            this.b_AddNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reservBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.b_searchFilterButton = new System.Windows.Forms.Button();
            this.b_resetSearch = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reserv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vIP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nonGrata = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clientClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.b_Edit = new System.Windows.Forms.Button();
            this.b_NewFileClient = new System.Windows.Forms.Button();
            this.roomBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.VIPcheckBox = new System.Windows.Forms.CheckBox();
            this.NONcheckBox = new System.Windows.Forms.CheckBox();
            this.b_Cleare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.inDateBox = new System.Windows.Forms.TextBox();
            this.b_dateIn = new System.Windows.Forms.Button();
            this.outDateBox = new System.Windows.Forms.TextBox();
            this.b_dateOut = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.telefonBox = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.monthCalendar3 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // b_LoadFile
            // 
            this.b_LoadFile.BackColor = System.Drawing.Color.Navy;
            this.b_LoadFile.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_LoadFile.ForeColor = System.Drawing.Color.Yellow;
            this.b_LoadFile.Location = new System.Drawing.Point(1079, 105);
            this.b_LoadFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_LoadFile.Name = "b_LoadFile";
            this.b_LoadFile.Size = new System.Drawing.Size(272, 82);
            this.b_LoadFile.TabIndex = 15;
            this.b_LoadFile.Text = "Существующие файлы клиентов";
            this.toolTip1.SetToolTip(this.b_LoadFile, "Отобразится форма со списком всех файлов клиентов. \r\nМожно будет загрузить клиент" +
        "ов из выбранного файла.");
            this.b_LoadFile.UseVisualStyleBackColor = false;
            this.b_LoadFile.Click += new System.EventHandler(this.b_ListFiles_Click);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathLabel.Location = new System.Drawing.Point(1061, 43);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(136, 20);
            this.pathLabel.TabIndex = 3;
            this.pathLabel.Text = "Текущий файл:";
            // 
            // b_DeleteRow
            // 
            this.b_DeleteRow.BackColor = System.Drawing.Color.MediumBlue;
            this.b_DeleteRow.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_DeleteRow.ForeColor = System.Drawing.SystemColors.Control;
            this.b_DeleteRow.Location = new System.Drawing.Point(1079, 438);
            this.b_DeleteRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_DeleteRow.Name = "b_DeleteRow";
            this.b_DeleteRow.Size = new System.Drawing.Size(272, 65);
            this.b_DeleteRow.TabIndex = 19;
            this.b_DeleteRow.Text = "Удалить выделенного клиента";
            this.b_DeleteRow.UseVisualStyleBackColor = false;
            this.b_DeleteRow.Click += new System.EventHandler(this.b_DeleteRow_Click);
            // 
            // b_SaveList
            // 
            this.b_SaveList.BackColor = System.Drawing.Color.Maroon;
            this.b_SaveList.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_SaveList.ForeColor = System.Drawing.SystemColors.Control;
            this.b_SaveList.Location = new System.Drawing.Point(1079, 586);
            this.b_SaveList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_SaveList.Name = "b_SaveList";
            this.b_SaveList.Size = new System.Drawing.Size(272, 137);
            this.b_SaveList.TabIndex = 21;
            this.b_SaveList.UseVisualStyleBackColor = false;
            this.b_SaveList.Click += new System.EventHandler(this.b_SaveClientsToFile_Click);
            // 
            // b_AddNew
            // 
            this.b_AddNew.BackColor = System.Drawing.Color.MediumBlue;
            this.b_AddNew.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_AddNew.ForeColor = System.Drawing.SystemColors.Control;
            this.b_AddNew.Location = new System.Drawing.Point(1079, 292);
            this.b_AddNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_AddNew.Name = "b_AddNew";
            this.b_AddNew.Size = new System.Drawing.Size(272, 69);
            this.b_AddNew.TabIndex = 17;
            this.b_AddNew.Text = "Добавить нового клиента";
            this.b_AddNew.UseVisualStyleBackColor = false;
            this.b_AddNew.Click += new System.EventHandler(this.b_AddNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(675, 552);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Дата заезда:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(675, 589);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Дата выезда:";
            // 
            // reservBox
            // 
            this.reservBox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reservBox.Location = new System.Drawing.Point(149, 546);
            this.reservBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reservBox.Name = "reservBox";
            this.reservBox.Size = new System.Drawing.Size(101, 28);
            this.reservBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 549);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "№ брони:";
            // 
            // b_searchFilterButton
            // 
            this.b_searchFilterButton.BackColor = System.Drawing.Color.BlueViolet;
            this.b_searchFilterButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_searchFilterButton.ForeColor = System.Drawing.Color.White;
            this.b_searchFilterButton.Location = new System.Drawing.Point(331, 679);
            this.b_searchFilterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_searchFilterButton.Name = "b_searchFilterButton";
            this.b_searchFilterButton.Size = new System.Drawing.Size(188, 39);
            this.b_searchFilterButton.TabIndex = 12;
            this.b_searchFilterButton.Text = "Отбор клиентов";
            this.toolTip1.SetToolTip(this.b_searchFilterButton, "Отбор клиента осуществляется, если его поля \r\nодновременно равны всем заданным зн" +
        "ачениям.");
            this.b_searchFilterButton.UseVisualStyleBackColor = false;
            this.b_searchFilterButton.Click += new System.EventHandler(this.searchFilterButton_Click);
            // 
            // b_resetSearch
            // 
            this.b_resetSearch.BackColor = System.Drawing.Color.BlueViolet;
            this.b_resetSearch.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_resetSearch.ForeColor = System.Drawing.Color.White;
            this.b_resetSearch.Location = new System.Drawing.Point(544, 679);
            this.b_resetSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_resetSearch.Name = "b_resetSearch";
            this.b_resetSearch.Size = new System.Drawing.Size(170, 39);
            this.b_resetSearch.TabIndex = 13;
            this.b_resetSearch.Text = "Все клиенты";
            this.toolTip1.SetToolTip(this.b_resetSearch, "Отобразятся все исходные клиенты.");
            this.b_resetSearch.UseVisualStyleBackColor = false;
            this.b_resetSearch.Click += new System.EventHandler(this.b_ВсеКлиенты_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.обАвтореToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1365, 32);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(82, 28);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(97, 28);
            this.обАвтореToolStripMenuItem.Text = "Об авторе";
            this.обАвтореToolStripMenuItem.Click += new System.EventHandler(this.обАвтореToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reserv,
            this.room,
            this.surnam,
            this.name,
            this.checkInDate,
            this.checkOutDate,
            this.telefon,
            this.vIP,
            this.nonGrata});
            this.dataGridView1.DataSource = this.clientClassBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 76);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1014, 427);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridView1_CellValidating);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_RowValidating);
            // 
            // reserv
            // 
            this.reserv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.reserv.DataPropertyName = "Reserv";
            dataGridViewCellStyle1.NullValue = null;
            this.reserv.DefaultCellStyle = dataGridViewCellStyle1;
            this.reserv.HeaderText = "№ брони";
            this.reserv.Name = "reserv";
            this.reserv.Width = 95;
            // 
            // room
            // 
            this.room.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.room.DataPropertyName = "Room";
            dataGridViewCellStyle2.NullValue = null;
            this.room.DefaultCellStyle = dataGridViewCellStyle2;
            this.room.HeaderText = "№ комнаты";
            this.room.Name = "room";
            this.room.Width = 112;
            // 
            // surnam
            // 
            this.surnam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.surnam.DataPropertyName = "Surname";
            this.surnam.HeaderText = "Фамилия";
            this.surnam.Name = "surnam";
            this.surnam.Width = 99;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.DataPropertyName = "Name";
            dataGridViewCellStyle3.NullValue = null;
            this.name.DefaultCellStyle = dataGridViewCellStyle3;
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            this.name.Width = 64;
            // 
            // checkInDate
            // 
            this.checkInDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.checkInDate.DataPropertyName = "CheckInDate";
            this.checkInDate.HeaderText = "Дата заезда";
            this.checkInDate.Name = "checkInDate";
            this.checkInDate.ToolTipText = "По двойному щелчку отображается календарь для выбора даты. ";
            this.checkInDate.Width = 121;
            // 
            // checkOutDate
            // 
            this.checkOutDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.checkOutDate.DataPropertyName = "CheckOutDate";
            dataGridViewCellStyle4.NullValue = null;
            this.checkOutDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.checkOutDate.HeaderText = "Дата выезда";
            this.checkOutDate.Name = "checkOutDate";
            this.checkOutDate.ToolTipText = "По двойному щелчку отображается календарь для выбора даты.";
            this.checkOutDate.Width = 123;
            // 
            // telefon
            // 
            this.telefon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.telefon.DataPropertyName = "Telefon";
            dataGridViewCellStyle5.NullValue = null;
            this.telefon.DefaultCellStyle = dataGridViewCellStyle5;
            this.telefon.HeaderText = "Телефон";
            this.telefon.Name = "telefon";
            this.telefon.Width = 97;
            // 
            // vIP
            // 
            this.vIP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.vIP.DataPropertyName = "VIP";
            this.vIP.HeaderText = "VIP";
            this.vIP.Name = "vIP";
            this.vIP.Width = 35;
            // 
            // nonGrata
            // 
            this.nonGrata.DataPropertyName = "NonGrata";
            this.nonGrata.HeaderText = "NonGrata";
            this.nonGrata.Name = "nonGrata";
            this.nonGrata.Width = 76;
            // 
            // clientClassBindingSource
            // 
            this.clientClassBindingSource.DataSource = typeof(Отель.ClientClass);
            // 
            // b_Edit
            // 
            this.b_Edit.BackColor = System.Drawing.Color.MediumBlue;
            this.b_Edit.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Edit.ForeColor = System.Drawing.SystemColors.Control;
            this.b_Edit.Location = new System.Drawing.Point(1079, 365);
            this.b_Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_Edit.Name = "b_Edit";
            this.b_Edit.Size = new System.Drawing.Size(272, 69);
            this.b_Edit.TabIndex = 18;
            this.b_Edit.Text = "Изменить выделенного клиента";
            this.b_Edit.UseVisualStyleBackColor = false;
            this.b_Edit.Click += new System.EventHandler(this.b_Edit_Click);
            // 
            // b_NewFileClient
            // 
            this.b_NewFileClient.BackColor = System.Drawing.Color.Navy;
            this.b_NewFileClient.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_NewFileClient.ForeColor = System.Drawing.Color.Yellow;
            this.b_NewFileClient.Location = new System.Drawing.Point(1079, 191);
            this.b_NewFileClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_NewFileClient.Name = "b_NewFileClient";
            this.b_NewFileClient.Size = new System.Drawing.Size(272, 82);
            this.b_NewFileClient.TabIndex = 16;
            this.b_NewFileClient.Text = "Создать НОВЫЙ файл клиентов ";
            this.toolTip1.SetToolTip(this.b_NewFileClient, resources.GetString("b_NewFileClient.ToolTip"));
            this.b_NewFileClient.UseVisualStyleBackColor = false;
            this.b_NewFileClient.Click += new System.EventHandler(this.newClient_Click);
            // 
            // roomBox
            // 
            this.roomBox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomBox.Location = new System.Drawing.Point(149, 583);
            this.roomBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomBox.Name = "roomBox";
            this.roomBox.Size = new System.Drawing.Size(101, 28);
            this.roomBox.TabIndex = 1;
            // 
            // surnameBox
            // 
            this.surnameBox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameBox.Location = new System.Drawing.Point(428, 549);
            this.surnameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(203, 28);
            this.surnameBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 586);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "№ комнаты:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(321, 552);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Фамилия:";
            // 
            // VIPcheckBox
            // 
            this.VIPcheckBox.AutoSize = true;
            this.VIPcheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.VIPcheckBox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VIPcheckBox.Location = new System.Drawing.Point(12, 625);
            this.VIPcheckBox.Name = "VIPcheckBox";
            this.VIPcheckBox.Size = new System.Drawing.Size(261, 24);
            this.VIPcheckBox.TabIndex = 2;
            this.VIPcheckBox.Text = "VIP персона:                   ";
            this.toolTip1.SetToolTip(this.VIPcheckBox, "Фамилия и имя VIP клиента отображаются на желтом фоне.");
            this.VIPcheckBox.UseVisualStyleBackColor = true;
            // 
            // NONcheckBox
            // 
            this.NONcheckBox.AutoSize = true;
            this.NONcheckBox.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.NONcheckBox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NONcheckBox.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.NONcheckBox.Location = new System.Drawing.Point(12, 655);
            this.NONcheckBox.Name = "NONcheckBox";
            this.NONcheckBox.Size = new System.Drawing.Size(261, 24);
            this.NONcheckBox.TabIndex = 3;
            this.NONcheckBox.Text = "Нежелательный клиент:  ";
            this.toolTip1.SetToolTip(this.NONcheckBox, "Строка нежелательного клиента отображается на сером фоне.");
            this.NONcheckBox.UseVisualStyleBackColor = true;
            // 
            // b_Cleare
            // 
            this.b_Cleare.BackColor = System.Drawing.Color.MediumBlue;
            this.b_Cleare.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Cleare.ForeColor = System.Drawing.SystemColors.Control;
            this.b_Cleare.Location = new System.Drawing.Point(1079, 506);
            this.b_Cleare.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.b_Cleare.Name = "b_Cleare";
            this.b_Cleare.Size = new System.Drawing.Size(272, 65);
            this.b_Cleare.TabIndex = 20;
            this.b_Cleare.Text = "Очистить таблицу";
            this.b_Cleare.UseVisualStyleBackColor = false;
            this.b_Cleare.Click += new System.EventHandler(this.b_Clear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(1061, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(69, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(549, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Для сортировки таблицы щелкните соответствующий заголовк";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(321, 589);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Телефон:";
            // 
            // inDateBox
            // 
            this.inDateBox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inDateBox.Location = new System.Drawing.Point(812, 549);
            this.inDateBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inDateBox.Name = "inDateBox";
            this.inDateBox.Size = new System.Drawing.Size(197, 28);
            this.inDateBox.TabIndex = 10;
            // 
            // b_dateIn
            // 
            this.b_dateIn.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_dateIn.Location = new System.Drawing.Point(1008, 549);
            this.b_dateIn.Name = "b_dateIn";
            this.b_dateIn.Size = new System.Drawing.Size(29, 30);
            this.b_dateIn.TabIndex = 6;
            this.b_dateIn.Text = "ˇ";
            this.toolTip1.SetToolTip(this.b_dateIn, "Кнопка отображает календарь. Выбранная дата будет записана в текстовое поле (слев" +
        "а)\r\nпосле потери календарем фокуса ввода. Желкните мышкой в текстовом поле.");
            this.b_dateIn.UseVisualStyleBackColor = true;
            this.b_dateIn.Click += new System.EventHandler(this.b_dateIn_Click);
            // 
            // outDateBox
            // 
            this.outDateBox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outDateBox.Location = new System.Drawing.Point(812, 586);
            this.outDateBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outDateBox.Name = "outDateBox";
            this.outDateBox.Size = new System.Drawing.Size(197, 28);
            this.outDateBox.TabIndex = 11;
            // 
            // b_dateOut
            // 
            this.b_dateOut.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_dateOut.Location = new System.Drawing.Point(1007, 586);
            this.b_dateOut.Name = "b_dateOut";
            this.b_dateOut.Size = new System.Drawing.Size(29, 30);
            this.b_dateOut.TabIndex = 7;
            this.b_dateOut.Text = "ˇ";
            this.toolTip1.SetToolTip(this.b_dateOut, "Кнопка отображает календарь. Выбранная дата будет записана в текстовое поле (слев" +
        "а)\r\nпосле потери календарем фокуса ввода. Желкните мышкой в текстовом поле.\r\n");
            this.b_dateOut.UseVisualStyleBackColor = true;
            this.b_dateOut.Click += new System.EventHandler(this.b_dateOut_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.BlueViolet;
            this.button3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(743, 679);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 39);
            this.button3.TabIndex = 14;
            this.button3.Text = "Очистить критерии";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.CleareFind_Click);
            // 
            // telefonBox
            // 
            this.telefonBox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.telefonBox.Location = new System.Drawing.Point(428, 586);
            this.telefonBox.Mask = "+7 (999) 000-0000";
            this.telefonBox.Name = "telefonBox";
            this.telefonBox.Size = new System.Drawing.Size(203, 28);
            this.telefonBox.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(360, 518);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(336, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Многокритериальный отбор клиентов:";
            // 
            // monthCalendar3
            // 
            this.monthCalendar3.Location = new System.Drawing.Point(30, 296);
            this.monthCalendar3.MaxSelectionCount = 1;
            this.monthCalendar3.Name = "monthCalendar3";
            this.monthCalendar3.TabIndex = 32;
            this.toolTip1.SetToolTip(this.monthCalendar3, "Календарь исчезает при покидании фокуса или по кнопке Escape.");
            this.monthCalendar3.Visible = false;
            this.monthCalendar3.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar3_DateSelected);
            this.monthCalendar3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.monthCalendar3_KeyDown);
            this.monthCalendar3.Leave += new System.EventHandler(this.monthCalendar3_Leave);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(1008, 549);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 30;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(1007, 586);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 31;
            this.monthCalendar2.Visible = false;
            this.monthCalendar2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateSelected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1365, 751);
            this.Controls.Add(this.monthCalendar3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.telefonBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.b_dateOut);
            this.Controls.Add(this.b_dateIn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NONcheckBox);
            this.Controls.Add(this.VIPcheckBox);
            this.Controls.Add(this.b_resetSearch);
            this.Controls.Add(this.b_searchFilterButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.outDateBox);
            this.Controls.Add(this.inDateBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.roomBox);
            this.Controls.Add(this.reservBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_Edit);
            this.Controls.Add(this.b_AddNew);
            this.Controls.Add(this.b_SaveList);
            this.Controls.Add(this.b_Cleare);
            this.Controls.Add(this.b_DeleteRow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.b_NewFileClient);
            this.Controls.Add(this.b_LoadFile);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отель \"У погибшего альпиниста\".";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientClassBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button b_LoadFile;
        public System.Windows.Forms.Label pathLabel;
        public System.Windows.Forms.Button b_DeleteRow;
        public System.Windows.Forms.Button b_SaveList;
        public System.Windows.Forms.Button b_AddNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reservBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b_searchFilterButton;
        private System.Windows.Forms.Button b_resetSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button b_Edit;
        public System.Windows.Forms.Button b_NewFileClient;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.TextBox roomBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox VIPcheckBox;
        private System.Windows.Forms.CheckBox NONcheckBox;
        public System.Windows.Forms.Button b_Cleare;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.BindingSource clientClassBindingSource;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox inDateBox;
        private System.Windows.Forms.Button b_dateIn;
        private System.Windows.Forms.TextBox outDateBox;
        private System.Windows.Forms.Button b_dateOut;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox telefonBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.MonthCalendar monthCalendar3;
        private System.Windows.Forms.DataGridViewTextBoxColumn reserv;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnam;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vIP;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nonGrata;
    }
}

