namespace ИС_Книжный_магазин
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.книги_открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователи_открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.роли_открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказы_открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранить_какToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.книги_сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователи_сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.роли_сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказы_сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранить_всеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотр_справкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.путь_к_программеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.о_программеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.labelRoles = new System.Windows.Forms.Label();
            this.labelSearchUser = new System.Windows.Forms.Label();
            this.labelAdminCode = new System.Windows.Forms.Label();
            this.textBoxAdminCode = new System.Windows.Forms.TextBox();
            this.buttonDisplayAllUsers = new System.Windows.Forms.Button();
            this.buttonSearchUser = new System.Windows.Forms.Button();
            this.textBoxSearchUser = new System.Windows.Forms.TextBox();
            this.comboBoxSearchUser = new System.Windows.Forms.ComboBox();
            this.buttonSaveAdminCode = new System.Windows.Forms.Button();
            this.buttonSaveRoles = new System.Windows.Forms.Button();
            this.buttonSaveUsers = new System.Windows.Forms.Button();
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            this.dataGridViewRoles = new System.Windows.Forms.DataGridView();
            this.roleIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPageBooks = new System.Windows.Forms.TabPage();
            this.buttonSaveBooks = new System.Windows.Forms.Button();
            this.comboBoxOperator = new System.Windows.Forms.ComboBox();
            this.buttonDisplayAllBooks = new System.Windows.Forms.Button();
            this.buttonSearchBook = new System.Windows.Forms.Button();
            this.textBoxSearchBook = new System.Windows.Forms.TextBox();
            this.comboBoxSearchBook = new System.Windows.Forms.ComboBox();
            this.dataGridViewCatalog = new System.Windows.Forms.DataGridView();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storehouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxSum = new System.Windows.Forms.CheckBox();
            this.checkBoxNumber = new System.Windows.Forms.CheckBox();
            this.checkBoxDate = new System.Windows.Forms.CheckBox();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.checkBoxSurname = new System.Windows.Forms.CheckBox();
            this.checkBoxAdress = new System.Windows.Forms.CheckBox();
            this.checkBoxFirstName = new System.Windows.Forms.CheckBox();
            this.checkBoxDelivery = new System.Windows.Forms.CheckBox();
            this.checkBoxMiddleName = new System.Windows.Forms.CheckBox();
            this.checkBoxPhone = new System.Windows.Forms.CheckBox();
            this.buttonSaveOrders = new System.Windows.Forms.Button();
            this.buttonDisplayAllOrders = new System.Windows.Forms.Button();
            this.checkBoxDisplay = new System.Windows.Forms.CheckBox();
            this.buttonSearchOrders = new System.Windows.Forms.Button();
            this.labelOrderedBooks = new System.Windows.Forms.Label();
            this.dataGridViewOrderedBooks = new System.Windows.Forms.DataGridView();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storehouseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderedBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.numberOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userSurnameOrders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userFirstNameOrders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userMiddleNameOrders = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delivery = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewComboBoxColumn11 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabPageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.tabPageBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.tabControlAdmin.SuspendLayout();
            this.tabPageOrders.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderedBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderedBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(954, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранить_какToolStripMenuItem,
            this.сохранить_всеToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.книги_открытьToolStripMenuItem,
            this.пользователи_открытьToolStripMenuItem,
            this.роли_открытьToolStripMenuItem,
            this.заказы_открытьToolStripMenuItem});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // книги_открытьToolStripMenuItem
            // 
            this.книги_открытьToolStripMenuItem.Name = "книги_открытьToolStripMenuItem";
            this.книги_открытьToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.книги_открытьToolStripMenuItem.Text = "Книги";
            this.книги_открытьToolStripMenuItem.Click += new System.EventHandler(this.книги_открытьToolStripMenuItem_Click);
            // 
            // пользователи_открытьToolStripMenuItem
            // 
            this.пользователи_открытьToolStripMenuItem.Name = "пользователи_открытьToolStripMenuItem";
            this.пользователи_открытьToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.пользователи_открытьToolStripMenuItem.Text = "Пользователи";
            this.пользователи_открытьToolStripMenuItem.Click += new System.EventHandler(this.пользователи_открытьToolStripMenuItem_Click);
            // 
            // роли_открытьToolStripMenuItem
            // 
            this.роли_открытьToolStripMenuItem.Name = "роли_открытьToolStripMenuItem";
            this.роли_открытьToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.роли_открытьToolStripMenuItem.Text = "Роли";
            this.роли_открытьToolStripMenuItem.Click += new System.EventHandler(this.роли_открытьToolStripMenuItem_Click);
            // 
            // заказы_открытьToolStripMenuItem
            // 
            this.заказы_открытьToolStripMenuItem.Name = "заказы_открытьToolStripMenuItem";
            this.заказы_открытьToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.заказы_открытьToolStripMenuItem.Text = "Заказы";
            this.заказы_открытьToolStripMenuItem.Click += new System.EventHandler(this.заказы_открытьToolStripMenuItem_Click);
            // 
            // сохранить_какToolStripMenuItem
            // 
            this.сохранить_какToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.книги_сохранитьToolStripMenuItem,
            this.пользователи_сохранитьToolStripMenuItem,
            this.роли_сохранитьToolStripMenuItem,
            this.заказы_сохранитьToolStripMenuItem});
            this.сохранить_какToolStripMenuItem.Name = "сохранить_какToolStripMenuItem";
            this.сохранить_какToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.сохранить_какToolStripMenuItem.Text = "Сохранить как";
            // 
            // книги_сохранитьToolStripMenuItem
            // 
            this.книги_сохранитьToolStripMenuItem.Name = "книги_сохранитьToolStripMenuItem";
            this.книги_сохранитьToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.книги_сохранитьToolStripMenuItem.Text = "Книги";
            this.книги_сохранитьToolStripMenuItem.Click += new System.EventHandler(this.книги_сохранитьToolStripMenuItem_Click);
            // 
            // пользователи_сохранитьToolStripMenuItem
            // 
            this.пользователи_сохранитьToolStripMenuItem.Name = "пользователи_сохранитьToolStripMenuItem";
            this.пользователи_сохранитьToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.пользователи_сохранитьToolStripMenuItem.Text = "Пользователи";
            this.пользователи_сохранитьToolStripMenuItem.Click += new System.EventHandler(this.пользователи_сохранитьToolStripMenuItem_Click);
            // 
            // роли_сохранитьToolStripMenuItem
            // 
            this.роли_сохранитьToolStripMenuItem.Name = "роли_сохранитьToolStripMenuItem";
            this.роли_сохранитьToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.роли_сохранитьToolStripMenuItem.Text = "Роли";
            this.роли_сохранитьToolStripMenuItem.Click += new System.EventHandler(this.роли_сохранитьToolStripMenuItem_Click);
            // 
            // заказы_сохранитьToolStripMenuItem
            // 
            this.заказы_сохранитьToolStripMenuItem.Name = "заказы_сохранитьToolStripMenuItem";
            this.заказы_сохранитьToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.заказы_сохранитьToolStripMenuItem.Text = "Заказы";
            this.заказы_сохранитьToolStripMenuItem.Click += new System.EventHandler(this.заказы_сохранитьToolStripMenuItem_Click);
            // 
            // сохранить_всеToolStripMenuItem
            // 
            this.сохранить_всеToolStripMenuItem.Name = "сохранить_всеToolStripMenuItem";
            this.сохранить_всеToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.сохранить_всеToolStripMenuItem.Text = "Сохранить всё";
            this.сохранить_всеToolStripMenuItem.Click += new System.EventHandler(this.сохранитьВсеToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотр_справкиToolStripMenuItem,
            this.путь_к_программеToolStripMenuItem,
            this.о_программеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // просмотр_справкиToolStripMenuItem
            // 
            this.просмотр_справкиToolStripMenuItem.Name = "просмотр_справкиToolStripMenuItem";
            this.просмотр_справкиToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.просмотр_справкиToolStripMenuItem.Text = "Просмотр справки";
            this.просмотр_справкиToolStripMenuItem.Click += new System.EventHandler(this.просмотр_справкиToolStripMenuItem_Click);
            // 
            // путь_к_программеToolStripMenuItem
            // 
            this.путь_к_программеToolStripMenuItem.Name = "путь_к_программеToolStripMenuItem";
            this.путь_к_программеToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.путь_к_программеToolStripMenuItem.Text = "Путь к программе";
            this.путь_к_программеToolStripMenuItem.Click += new System.EventHandler(this.путь_к_программеToolStripMenuItem_Click);
            // 
            // о_программеToolStripMenuItem
            // 
            this.о_программеToolStripMenuItem.Name = "о_программеToolStripMenuItem";
            this.о_программеToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.о_программеToolStripMenuItem.Text = "О программе";
            this.о_программеToolStripMenuItem.Click += new System.EventHandler(this.о_программеToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageUsers.Controls.Add(this.labelRoles);
            this.tabPageUsers.Controls.Add(this.labelSearchUser);
            this.tabPageUsers.Controls.Add(this.labelAdminCode);
            this.tabPageUsers.Controls.Add(this.textBoxAdminCode);
            this.tabPageUsers.Controls.Add(this.buttonDisplayAllUsers);
            this.tabPageUsers.Controls.Add(this.buttonSearchUser);
            this.tabPageUsers.Controls.Add(this.textBoxSearchUser);
            this.tabPageUsers.Controls.Add(this.comboBoxSearchUser);
            this.tabPageUsers.Controls.Add(this.buttonSaveAdminCode);
            this.tabPageUsers.Controls.Add(this.buttonSaveRoles);
            this.tabPageUsers.Controls.Add(this.buttonSaveUsers);
            this.tabPageUsers.Controls.Add(this.checkBoxPassword);
            this.tabPageUsers.Controls.Add(this.dataGridViewRoles);
            this.tabPageUsers.Controls.Add(this.dataGridViewUsers);
            this.tabPageUsers.Location = new System.Drawing.Point(4, 29);
            this.tabPageUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageUsers.Size = new System.Drawing.Size(946, 551);
            this.tabPageUsers.TabIndex = 1;
            this.tabPageUsers.Text = "Пользователи";
            // 
            // labelRoles
            // 
            this.labelRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRoles.AutoSize = true;
            this.labelRoles.BackColor = System.Drawing.Color.White;
            this.labelRoles.Location = new System.Drawing.Point(692, 96);
            this.labelRoles.Name = "labelRoles";
            this.labelRoles.Size = new System.Drawing.Size(50, 22);
            this.labelRoles.TabIndex = 17;
            this.labelRoles.Text = "Роли";
            // 
            // labelSearchUser
            // 
            this.labelSearchUser.AutoSize = true;
            this.labelSearchUser.BackColor = System.Drawing.Color.White;
            this.labelSearchUser.Location = new System.Drawing.Point(56, 23);
            this.labelSearchUser.Name = "labelSearchUser";
            this.labelSearchUser.Size = new System.Drawing.Size(180, 22);
            this.labelSearchUser.TabIndex = 17;
            this.labelSearchUser.Text = "Поиск пользователей";
            // 
            // labelAdminCode
            // 
            this.labelAdminCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAdminCode.AutoSize = true;
            this.labelAdminCode.BackColor = System.Drawing.Color.White;
            this.labelAdminCode.Location = new System.Drawing.Point(758, 23);
            this.labelAdminCode.Name = "labelAdminCode";
            this.labelAdminCode.Size = new System.Drawing.Size(180, 22);
            this.labelAdminCode.TabIndex = 17;
            this.labelAdminCode.Text = "Код администратора";
            // 
            // textBoxAdminCode
            // 
            this.textBoxAdminCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAdminCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAdminCode.Location = new System.Drawing.Point(696, 43);
            this.textBoxAdminCode.Name = "textBoxAdminCode";
            this.textBoxAdminCode.Size = new System.Drawing.Size(198, 28);
            this.textBoxAdminCode.TabIndex = 16;
            // 
            // buttonDisplayAllUsers
            // 
            this.buttonDisplayAllUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDisplayAllUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDisplayAllUsers.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDisplayAllUsers.Location = new System.Drawing.Point(524, 77);
            this.buttonDisplayAllUsers.Name = "buttonDisplayAllUsers";
            this.buttonDisplayAllUsers.Size = new System.Drawing.Size(138, 27);
            this.buttonDisplayAllUsers.TabIndex = 14;
            this.buttonDisplayAllUsers.Text = "Отобразить всё";
            this.buttonDisplayAllUsers.UseVisualStyleBackColor = true;
            this.buttonDisplayAllUsers.Click += new System.EventHandler(this.buttonDisplayAllUsers_Click);
            // 
            // buttonSearchUser
            // 
            this.buttonSearchUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearchUser.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchUser.Location = new System.Drawing.Point(60, 77);
            this.buttonSearchUser.Name = "buttonSearchUser";
            this.buttonSearchUser.Size = new System.Drawing.Size(64, 27);
            this.buttonSearchUser.TabIndex = 15;
            this.buttonSearchUser.Text = "Найти";
            this.buttonSearchUser.UseVisualStyleBackColor = true;
            this.buttonSearchUser.Click += new System.EventHandler(this.buttonSearchUser_Click);
            // 
            // textBoxSearchUser
            // 
            this.textBoxSearchUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchUser.Location = new System.Drawing.Point(239, 43);
            this.textBoxSearchUser.Name = "textBoxSearchUser";
            this.textBoxSearchUser.Size = new System.Drawing.Size(423, 28);
            this.textBoxSearchUser.TabIndex = 13;
            // 
            // comboBoxSearchUser
            // 
            this.comboBoxSearchUser.DisplayMember = "Index";
            this.comboBoxSearchUser.FormattingEnabled = true;
            this.comboBoxSearchUser.Location = new System.Drawing.Point(60, 42);
            this.comboBoxSearchUser.Name = "comboBoxSearchUser";
            this.comboBoxSearchUser.Size = new System.Drawing.Size(149, 28);
            this.comboBoxSearchUser.TabIndex = 12;
            this.comboBoxSearchUser.ValueMember = "Index";
            // 
            // buttonSaveAdminCode
            // 
            this.buttonSaveAdminCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveAdminCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveAdminCode.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveAdminCode.Location = new System.Drawing.Point(803, 77);
            this.buttonSaveAdminCode.Name = "buttonSaveAdminCode";
            this.buttonSaveAdminCode.Size = new System.Drawing.Size(91, 27);
            this.buttonSaveAdminCode.TabIndex = 11;
            this.buttonSaveAdminCode.Text = "Сохранить";
            this.buttonSaveAdminCode.UseVisualStyleBackColor = true;
            this.buttonSaveAdminCode.Click += new System.EventHandler(this.buttonSaveAdminCode_Click);
            // 
            // buttonSaveRoles
            // 
            this.buttonSaveRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveRoles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveRoles.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveRoles.Location = new System.Drawing.Point(803, 505);
            this.buttonSaveRoles.Name = "buttonSaveRoles";
            this.buttonSaveRoles.Size = new System.Drawing.Size(91, 27);
            this.buttonSaveRoles.TabIndex = 11;
            this.buttonSaveRoles.Text = "Сохранить";
            this.buttonSaveRoles.UseVisualStyleBackColor = true;
            this.buttonSaveRoles.Click += new System.EventHandler(this.buttonSaveRoles_Click);
            // 
            // buttonSaveUsers
            // 
            this.buttonSaveUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveUsers.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveUsers.Location = new System.Drawing.Point(571, 505);
            this.buttonSaveUsers.Name = "buttonSaveUsers";
            this.buttonSaveUsers.Size = new System.Drawing.Size(91, 27);
            this.buttonSaveUsers.TabIndex = 11;
            this.buttonSaveUsers.Text = "Сохранить";
            this.buttonSaveUsers.UseVisualStyleBackColor = true;
            this.buttonSaveUsers.Click += new System.EventHandler(this.buttonSaveUsers_Click);
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.Location = new System.Drawing.Point(60, 504);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(95, 26);
            this.checkBoxPassword.TabIndex = 2;
            this.checkBoxPassword.Text = "Пароли";
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            this.checkBoxPassword.CheckedChanged += new System.EventHandler(this.checkBoxPassword_CheckedChanged);
            // 
            // dataGridViewRoles
            // 
            this.dataGridViewRoles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRoles.AutoGenerateColumns = false;
            this.dataGridViewRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roleIdDataGridViewTextBoxColumn,
            this.roleName});
            this.dataGridViewRoles.DataSource = this.roleBindingSource;
            this.dataGridViewRoles.Location = new System.Drawing.Point(696, 121);
            this.dataGridViewRoles.Name = "dataGridViewRoles";
            this.dataGridViewRoles.RowTemplate.Height = 24;
            this.dataGridViewRoles.Size = new System.Drawing.Size(198, 378);
            this.dataGridViewRoles.TabIndex = 1;
            this.dataGridViewRoles.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewRoles_DataError);
            this.dataGridViewRoles.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewRoles_UserDeletingRow);
            // 
            // roleIdDataGridViewTextBoxColumn
            // 
            this.roleIdDataGridViewTextBoxColumn.DataPropertyName = "roleId";
            this.roleIdDataGridViewTextBoxColumn.FillWeight = 50.76142F;
            this.roleIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.roleIdDataGridViewTextBoxColumn.Name = "roleIdDataGridViewTextBoxColumn";
            this.roleIdDataGridViewTextBoxColumn.ToolTipText = "ID роли (определяет какое окно он видит после входа)";
            // 
            // roleName
            // 
            this.roleName.DataPropertyName = "roleName";
            this.roleName.FillWeight = 149.2386F;
            this.roleName.HeaderText = "Название";
            this.roleName.Name = "roleName";
            this.roleName.ToolTipText = "Название роли";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(ИС_Книжный_магазин.Role);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUsers.AutoGenerateColumns = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.loginDataGridViewTextBoxColumn,
            this.password,
            this.surname,
            this.userName,
            this.userMiddleName,
            this.roleId,
            this.dataGridViewTextBoxColumn1});
            this.dataGridViewUsers.DataSource = this.userBindingSource;
            this.dataGridViewUsers.Location = new System.Drawing.Point(60, 121);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(602, 378);
            this.dataGridViewUsers.TabIndex = 0;
            this.dataGridViewUsers.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewUsers_DataError);
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Логин";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ToolTipText = "Логин пользователя";
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Пароль";
            this.password.Name = "password";
            this.password.ToolTipText = "Пароль пользователя";
            // 
            // surname
            // 
            this.surname.DataPropertyName = "userSurname";
            this.surname.HeaderText = "Фамилия";
            this.surname.Name = "surname";
            this.surname.ToolTipText = "Фамилия пользователя";
            // 
            // userName
            // 
            this.userName.DataPropertyName = "userFirstName";
            this.userName.HeaderText = "Имя";
            this.userName.Name = "userName";
            this.userName.ToolTipText = "Имя пользователя";
            // 
            // userMiddleName
            // 
            this.userMiddleName.DataPropertyName = "userMiddleName";
            this.userMiddleName.HeaderText = "Отчество";
            this.userMiddleName.Name = "userMiddleName";
            this.userMiddleName.ToolTipText = "Отчество пользователя";
            // 
            // roleId
            // 
            this.roleId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.roleId.DataPropertyName = "roleId";
            this.roleId.DataSource = this.roleBindingSource;
            this.roleId.DisplayMember = "roleId";
            this.roleId.HeaderText = "ID";
            this.roleId.Name = "roleId";
            this.roleId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.roleId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.roleId.ToolTipText = "Идентификатор должности пользователя";
            this.roleId.ValueMember = "roleId";
            this.roleId.Width = 58;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "roleName";
            this.dataGridViewTextBoxColumn1.DataSource = this.roleBindingSource;
            this.dataGridViewTextBoxColumn1.DisplayMember = "roleName";
            this.dataGridViewTextBoxColumn1.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.ToolTipText = "Наименование должности пользователя";
            this.dataGridViewTextBoxColumn1.ValueMember = "roleName";
            this.dataGridViewTextBoxColumn1.Width = 128;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(ИС_Книжный_магазин.User);
            // 
            // tabPageBooks
            // 
            this.tabPageBooks.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageBooks.Controls.Add(this.buttonSaveBooks);
            this.tabPageBooks.Controls.Add(this.comboBoxOperator);
            this.tabPageBooks.Controls.Add(this.buttonDisplayAllBooks);
            this.tabPageBooks.Controls.Add(this.buttonSearchBook);
            this.tabPageBooks.Controls.Add(this.textBoxSearchBook);
            this.tabPageBooks.Controls.Add(this.comboBoxSearchBook);
            this.tabPageBooks.Controls.Add(this.dataGridViewCatalog);
            this.tabPageBooks.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageBooks.Location = new System.Drawing.Point(4, 29);
            this.tabPageBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageBooks.Name = "tabPageBooks";
            this.tabPageBooks.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageBooks.Size = new System.Drawing.Size(946, 551);
            this.tabPageBooks.TabIndex = 0;
            this.tabPageBooks.Text = "Книги";
            // 
            // buttonSaveBooks
            // 
            this.buttonSaveBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveBooks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveBooks.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveBooks.Location = new System.Drawing.Point(784, 497);
            this.buttonSaveBooks.Name = "buttonSaveBooks";
            this.buttonSaveBooks.Size = new System.Drawing.Size(91, 27);
            this.buttonSaveBooks.TabIndex = 12;
            this.buttonSaveBooks.Text = "Сохранить";
            this.buttonSaveBooks.UseVisualStyleBackColor = true;
            this.buttonSaveBooks.Click += new System.EventHandler(this.buttonSaveBooks_Click);
            // 
            // comboBoxOperator
            // 
            this.comboBoxOperator.FormattingEnabled = true;
            this.comboBoxOperator.Location = new System.Drawing.Point(257, 37);
            this.comboBoxOperator.Name = "comboBoxOperator";
            this.comboBoxOperator.Size = new System.Drawing.Size(44, 28);
            this.comboBoxOperator.TabIndex = 11;
            // 
            // buttonDisplayAllBooks
            // 
            this.buttonDisplayAllBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDisplayAllBooks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDisplayAllBooks.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDisplayAllBooks.Location = new System.Drawing.Point(737, 68);
            this.buttonDisplayAllBooks.Name = "buttonDisplayAllBooks";
            this.buttonDisplayAllBooks.Size = new System.Drawing.Size(138, 27);
            this.buttonDisplayAllBooks.TabIndex = 10;
            this.buttonDisplayAllBooks.Text = "Отобразить всё";
            this.buttonDisplayAllBooks.UseVisualStyleBackColor = true;
            this.buttonDisplayAllBooks.Click += new System.EventHandler(this.buttonDisplayAllBooks_Click);
            // 
            // buttonSearchBook
            // 
            this.buttonSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearchBook.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchBook.Location = new System.Drawing.Point(62, 68);
            this.buttonSearchBook.Name = "buttonSearchBook";
            this.buttonSearchBook.Size = new System.Drawing.Size(64, 27);
            this.buttonSearchBook.TabIndex = 10;
            this.buttonSearchBook.Text = "Найти";
            this.buttonSearchBook.UseVisualStyleBackColor = true;
            this.buttonSearchBook.Click += new System.EventHandler(this.buttonSearchBook_Click);
            // 
            // textBoxSearchBook
            // 
            this.textBoxSearchBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchBook.Location = new System.Drawing.Point(319, 37);
            this.textBoxSearchBook.Name = "textBoxSearchBook";
            this.textBoxSearchBook.Size = new System.Drawing.Size(556, 28);
            this.textBoxSearchBook.TabIndex = 8;
            // 
            // comboBoxSearchBook
            // 
            this.comboBoxSearchBook.DisplayMember = "Index";
            this.comboBoxSearchBook.FormattingEnabled = true;
            this.comboBoxSearchBook.Location = new System.Drawing.Point(62, 37);
            this.comboBoxSearchBook.Name = "comboBoxSearchBook";
            this.comboBoxSearchBook.Size = new System.Drawing.Size(174, 28);
            this.comboBoxSearchBook.TabIndex = 7;
            this.comboBoxSearchBook.ValueMember = "Index";
            this.comboBoxSearchBook.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchBook_SelectedIndexChanged);
            // 
            // dataGridViewCatalog
            // 
            this.dataGridViewCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCatalog.AutoGenerateColumns = false;
            this.dataGridViewCatalog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCatalog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isbn,
            this.name,
            this.authorName,
            this.price,
            this.storehouse,
            this.shop});
            this.dataGridViewCatalog.DataSource = this.bookBindingSource;
            this.dataGridViewCatalog.Location = new System.Drawing.Point(62, 117);
            this.dataGridViewCatalog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewCatalog.Name = "dataGridViewCatalog";
            this.dataGridViewCatalog.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewCatalog.Size = new System.Drawing.Size(813, 372);
            this.dataGridViewCatalog.TabIndex = 0;
            this.dataGridViewCatalog.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewCatalog_DataError);
            // 
            // isbn
            // 
            this.isbn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isbn.DataPropertyName = "isbn";
            this.isbn.FillWeight = 123.4689F;
            this.isbn.HeaderText = "ISBN";
            this.isbn.Name = "isbn";
            this.isbn.ToolTipText = "Международный стандартный номер книги";
            this.isbn.Width = 78;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.FillWeight = 123.4689F;
            this.name.HeaderText = "Название";
            this.name.Name = "name";
            this.name.ToolTipText = "Название книги";
            // 
            // authorName
            // 
            this.authorName.DataPropertyName = "authorName";
            this.authorName.FillWeight = 123.4689F;
            this.authorName.HeaderText = "Автор";
            this.authorName.Name = "authorName";
            this.authorName.ToolTipText = "Автор книги";
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.price.DataPropertyName = "price";
            this.price.FillWeight = 92.63218F;
            this.price.HeaderText = "Цена";
            this.price.Name = "price";
            this.price.ToolTipText = "Цена книги";
            this.price.Width = 81;
            // 
            // storehouse
            // 
            this.storehouse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.storehouse.DataPropertyName = "storehouse";
            this.storehouse.FillWeight = 76.04745F;
            this.storehouse.HeaderText = "Склад";
            this.storehouse.Name = "storehouse";
            this.storehouse.ToolTipText = "Наличие на складе";
            this.storehouse.Width = 89;
            // 
            // shop
            // 
            this.shop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.shop.DataPropertyName = "shop";
            this.shop.FillWeight = 60.9137F;
            this.shop.HeaderText = "Магазин";
            this.shop.Name = "shop";
            this.shop.ToolTipText = "Наличие в магазине";
            this.shop.Width = 109;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(ИС_Книжный_магазин.Book);
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlAdmin.Controls.Add(this.tabPageBooks);
            this.tabControlAdmin.Controls.Add(this.tabPageUsers);
            this.tabControlAdmin.Controls.Add(this.tabPageOrders);
            this.tabControlAdmin.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlAdmin.Location = new System.Drawing.Point(0, 28);
            this.tabControlAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(954, 584);
            this.tabControlAdmin.TabIndex = 0;
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageOrders.Controls.Add(this.groupBox1);
            this.tabPageOrders.Controls.Add(this.buttonSaveOrders);
            this.tabPageOrders.Controls.Add(this.buttonDisplayAllOrders);
            this.tabPageOrders.Controls.Add(this.checkBoxDisplay);
            this.tabPageOrders.Controls.Add(this.buttonSearchOrders);
            this.tabPageOrders.Controls.Add(this.labelOrderedBooks);
            this.tabPageOrders.Controls.Add(this.dataGridViewOrderedBooks);
            this.tabPageOrders.Controls.Add(this.dataGridViewOrders);
            this.tabPageOrders.Controls.Add(this.dateTimePicker1);
            this.tabPageOrders.Location = new System.Drawing.Point(4, 29);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrders.Size = new System.Drawing.Size(946, 551);
            this.tabPageOrders.TabIndex = 2;
            this.tabPageOrders.Text = "Заказы";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBoxSum);
            this.groupBox1.Controls.Add(this.checkBoxNumber);
            this.groupBox1.Controls.Add(this.checkBoxDate);
            this.groupBox1.Controls.Add(this.checkBoxStatus);
            this.groupBox1.Controls.Add(this.checkBoxSurname);
            this.groupBox1.Controls.Add(this.checkBoxAdress);
            this.groupBox1.Controls.Add(this.checkBoxFirstName);
            this.groupBox1.Controls.Add(this.checkBoxDelivery);
            this.groupBox1.Controls.Add(this.checkBoxMiddleName);
            this.groupBox1.Controls.Add(this.checkBoxPhone);
            this.groupBox1.Location = new System.Drawing.Point(820, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 381);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отображать столбцы:";
            // 
            // checkBoxSum
            // 
            this.checkBoxSum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSum.AutoSize = true;
            this.checkBoxSum.Checked = true;
            this.checkBoxSum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSum.Location = new System.Drawing.Point(20, 112);
            this.checkBoxSum.Name = "checkBoxSum";
            this.checkBoxSum.Size = new System.Drawing.Size(86, 26);
            this.checkBoxSum.TabIndex = 20;
            this.checkBoxSum.Text = "Сумма";
            this.checkBoxSum.UseVisualStyleBackColor = true;
            this.checkBoxSum.CheckedChanged += new System.EventHandler(this.checkBoxSum_CheckedChanged);
            // 
            // checkBoxNumber
            // 
            this.checkBoxNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxNumber.AutoSize = true;
            this.checkBoxNumber.Checked = true;
            this.checkBoxNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNumber.Location = new System.Drawing.Point(20, 48);
            this.checkBoxNumber.Name = "checkBoxNumber";
            this.checkBoxNumber.Size = new System.Drawing.Size(85, 26);
            this.checkBoxNumber.TabIndex = 20;
            this.checkBoxNumber.Text = "Номер";
            this.checkBoxNumber.UseVisualStyleBackColor = true;
            this.checkBoxNumber.CheckedChanged += new System.EventHandler(this.checkBoxNumber_CheckedChanged);
            // 
            // checkBoxDate
            // 
            this.checkBoxDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDate.AutoSize = true;
            this.checkBoxDate.Checked = true;
            this.checkBoxDate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDate.Location = new System.Drawing.Point(20, 80);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(71, 26);
            this.checkBoxDate.TabIndex = 20;
            this.checkBoxDate.Text = "Дата";
            this.checkBoxDate.UseVisualStyleBackColor = true;
            this.checkBoxDate.CheckedChanged += new System.EventHandler(this.checkBoxDate_CheckedChanged);
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.Checked = true;
            this.checkBoxStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxStatus.Location = new System.Drawing.Point(20, 336);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(86, 26);
            this.checkBoxStatus.TabIndex = 20;
            this.checkBoxStatus.Text = "Статус";
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            this.checkBoxStatus.CheckedChanged += new System.EventHandler(this.checkBoxStatus_CheckedChanged);
            // 
            // checkBoxSurname
            // 
            this.checkBoxSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSurname.AutoSize = true;
            this.checkBoxSurname.Checked = true;
            this.checkBoxSurname.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSurname.Location = new System.Drawing.Point(20, 144);
            this.checkBoxSurname.Name = "checkBoxSurname";
            this.checkBoxSurname.Size = new System.Drawing.Size(108, 26);
            this.checkBoxSurname.TabIndex = 20;
            this.checkBoxSurname.Text = "Фамилия";
            this.checkBoxSurname.UseVisualStyleBackColor = true;
            this.checkBoxSurname.CheckedChanged += new System.EventHandler(this.checkBoxSurname_CheckedChanged);
            // 
            // checkBoxAdress
            // 
            this.checkBoxAdress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxAdress.AutoSize = true;
            this.checkBoxAdress.Checked = true;
            this.checkBoxAdress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdress.Location = new System.Drawing.Point(20, 304);
            this.checkBoxAdress.Name = "checkBoxAdress";
            this.checkBoxAdress.Size = new System.Drawing.Size(81, 26);
            this.checkBoxAdress.TabIndex = 20;
            this.checkBoxAdress.Text = "Адрес";
            this.checkBoxAdress.UseVisualStyleBackColor = true;
            this.checkBoxAdress.CheckedChanged += new System.EventHandler(this.checkBoxAdress_CheckedChanged);
            // 
            // checkBoxFirstName
            // 
            this.checkBoxFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxFirstName.AutoSize = true;
            this.checkBoxFirstName.Checked = true;
            this.checkBoxFirstName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFirstName.Location = new System.Drawing.Point(20, 176);
            this.checkBoxFirstName.Name = "checkBoxFirstName";
            this.checkBoxFirstName.Size = new System.Drawing.Size(67, 26);
            this.checkBoxFirstName.TabIndex = 20;
            this.checkBoxFirstName.Text = "Имя";
            this.checkBoxFirstName.UseVisualStyleBackColor = true;
            this.checkBoxFirstName.CheckedChanged += new System.EventHandler(this.checkBoxFirstName_CheckedChanged);
            // 
            // checkBoxDelivery
            // 
            this.checkBoxDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDelivery.AutoSize = true;
            this.checkBoxDelivery.Checked = true;
            this.checkBoxDelivery.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDelivery.Location = new System.Drawing.Point(20, 272);
            this.checkBoxDelivery.Name = "checkBoxDelivery";
            this.checkBoxDelivery.Size = new System.Drawing.Size(105, 26);
            this.checkBoxDelivery.TabIndex = 20;
            this.checkBoxDelivery.Text = "Доставка";
            this.checkBoxDelivery.UseVisualStyleBackColor = true;
            this.checkBoxDelivery.CheckedChanged += new System.EventHandler(this.checkBoxDelivery_CheckedChanged);
            // 
            // checkBoxMiddleName
            // 
            this.checkBoxMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxMiddleName.AutoSize = true;
            this.checkBoxMiddleName.Checked = true;
            this.checkBoxMiddleName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMiddleName.Location = new System.Drawing.Point(20, 208);
            this.checkBoxMiddleName.Name = "checkBoxMiddleName";
            this.checkBoxMiddleName.Size = new System.Drawing.Size(104, 26);
            this.checkBoxMiddleName.TabIndex = 20;
            this.checkBoxMiddleName.Text = "Отчество";
            this.checkBoxMiddleName.UseVisualStyleBackColor = true;
            this.checkBoxMiddleName.CheckedChanged += new System.EventHandler(this.checkBoxMiddleName_CheckedChanged);
            // 
            // checkBoxPhone
            // 
            this.checkBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPhone.AutoSize = true;
            this.checkBoxPhone.Checked = true;
            this.checkBoxPhone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPhone.Location = new System.Drawing.Point(20, 240);
            this.checkBoxPhone.Name = "checkBoxPhone";
            this.checkBoxPhone.Size = new System.Drawing.Size(102, 26);
            this.checkBoxPhone.TabIndex = 20;
            this.checkBoxPhone.Text = "Телефон";
            this.checkBoxPhone.UseVisualStyleBackColor = true;
            this.checkBoxPhone.CheckedChanged += new System.EventHandler(this.checkBoxPhone_CheckedChanged);
            // 
            // buttonSaveOrders
            // 
            this.buttonSaveOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveOrders.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveOrders.Location = new System.Drawing.Point(729, 495);
            this.buttonSaveOrders.Name = "buttonSaveOrders";
            this.buttonSaveOrders.Size = new System.Drawing.Size(91, 27);
            this.buttonSaveOrders.TabIndex = 22;
            this.buttonSaveOrders.Text = "Сохранить";
            this.buttonSaveOrders.UseVisualStyleBackColor = true;
            this.buttonSaveOrders.Click += new System.EventHandler(this.buttonSaveOrders_Click);
            // 
            // buttonDisplayAllOrders
            // 
            this.buttonDisplayAllOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDisplayAllOrders.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDisplayAllOrders.Location = new System.Drawing.Point(336, 26);
            this.buttonDisplayAllOrders.Name = "buttonDisplayAllOrders";
            this.buttonDisplayAllOrders.Size = new System.Drawing.Size(138, 28);
            this.buttonDisplayAllOrders.TabIndex = 21;
            this.buttonDisplayAllOrders.Text = "Отобразить всё";
            this.buttonDisplayAllOrders.UseVisualStyleBackColor = true;
            this.buttonDisplayAllOrders.Click += new System.EventHandler(this.buttonDisplayAllOrders_Click);
            // 
            // checkBoxDisplay
            // 
            this.checkBoxDisplay.AutoSize = true;
            this.checkBoxDisplay.Location = new System.Drawing.Point(72, 60);
            this.checkBoxDisplay.Name = "checkBoxDisplay";
            this.checkBoxDisplay.Size = new System.Drawing.Size(326, 26);
            this.checkBoxDisplay.TabIndex = 20;
            this.checkBoxDisplay.Text = "Отображать только открытые заказы";
            this.checkBoxDisplay.UseVisualStyleBackColor = true;
            this.checkBoxDisplay.CheckedChanged += new System.EventHandler(this.checkBoxDisplay_CheckedChanged);
            // 
            // buttonSearchOrders
            // 
            this.buttonSearchOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearchOrders.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchOrders.Location = new System.Drawing.Point(257, 26);
            this.buttonSearchOrders.Name = "buttonSearchOrders";
            this.buttonSearchOrders.Size = new System.Drawing.Size(64, 27);
            this.buttonSearchOrders.TabIndex = 19;
            this.buttonSearchOrders.Text = "Найти";
            this.buttonSearchOrders.UseVisualStyleBackColor = true;
            this.buttonSearchOrders.Click += new System.EventHandler(this.buttonSearchOrders_Click);
            // 
            // labelOrderedBooks
            // 
            this.labelOrderedBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOrderedBooks.AutoSize = true;
            this.labelOrderedBooks.BackColor = System.Drawing.Color.White;
            this.labelOrderedBooks.Location = new System.Drawing.Point(68, 324);
            this.labelOrderedBooks.Name = "labelOrderedBooks";
            this.labelOrderedBooks.Size = new System.Drawing.Size(163, 22);
            this.labelOrderedBooks.TabIndex = 18;
            this.labelOrderedBooks.Text = "Заказанные книги:";
            // 
            // dataGridViewOrderedBooks
            // 
            this.dataGridViewOrderedBooks.AllowUserToAddRows = false;
            this.dataGridViewOrderedBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOrderedBooks.AutoGenerateColumns = false;
            this.dataGridViewOrderedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrderedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderedBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isbnDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.authorNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.storehouseDataGridViewTextBoxColumn,
            this.shopDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn});
            this.dataGridViewOrderedBooks.DataSource = this.orderedBooksBindingSource;
            this.dataGridViewOrderedBooks.Location = new System.Drawing.Point(72, 349);
            this.dataGridViewOrderedBooks.Name = "dataGridViewOrderedBooks";
            this.dataGridViewOrderedBooks.RowTemplate.Height = 24;
            this.dataGridViewOrderedBooks.Size = new System.Drawing.Size(748, 140);
            this.dataGridViewOrderedBooks.TabIndex = 2;
            this.dataGridViewOrderedBooks.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewOrderedBooks_DataError);
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            this.isbnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorNameDataGridViewTextBoxColumn
            // 
            this.authorNameDataGridViewTextBoxColumn.DataPropertyName = "authorName";
            this.authorNameDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.authorNameDataGridViewTextBoxColumn.Name = "authorNameDataGridViewTextBoxColumn";
            this.authorNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // storehouseDataGridViewTextBoxColumn
            // 
            this.storehouseDataGridViewTextBoxColumn.DataPropertyName = "storehouse";
            this.storehouseDataGridViewTextBoxColumn.HeaderText = "Склад";
            this.storehouseDataGridViewTextBoxColumn.Name = "storehouseDataGridViewTextBoxColumn";
            this.storehouseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // shopDataGridViewTextBoxColumn
            // 
            this.shopDataGridViewTextBoxColumn.DataPropertyName = "shop";
            this.shopDataGridViewTextBoxColumn.HeaderText = "Магазин";
            this.shopDataGridViewTextBoxColumn.Name = "shopDataGridViewTextBoxColumn";
            this.shopDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // orderedBooksBindingSource
            // 
            this.orderedBooksBindingSource.DataMember = "orderedBooks";
            this.orderedBooksBindingSource.DataSource = this.orderBindingSource;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(ИС_Книжный_магазин.Order);
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOrders.AutoGenerateColumns = false;
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberOrder,
            this.date,
            this.sum,
            this.userSurnameOrders,
            this.userFirstNameOrders,
            this.userMiddleNameOrders,
            this.phoneNumber,
            this.delivery,
            this.adress,
            this.orderStatus});
            this.dataGridViewOrders.DataSource = this.orderBindingSource;
            this.dataGridViewOrders.Location = new System.Drawing.Point(72, 92);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowTemplate.Height = 24;
            this.dataGridViewOrders.Size = new System.Drawing.Size(748, 225);
            this.dataGridViewOrders.TabIndex = 1;
            this.dataGridViewOrders.CurrentCellChanged += new System.EventHandler(this.dataGridViewOrders_CurrentCellChanged);
            this.dataGridViewOrders.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewOrders_DataError);
            // 
            // numberOrder
            // 
            this.numberOrder.DataPropertyName = "number";
            this.numberOrder.HeaderText = "Номер";
            this.numberOrder.Name = "numberOrder";
            this.numberOrder.ReadOnly = true;
            this.numberOrder.ToolTipText = "Номер заказа";
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.ToolTipText = "Дата заказа";
            // 
            // sum
            // 
            this.sum.DataPropertyName = "sum";
            this.sum.HeaderText = "Сумма";
            this.sum.Name = "sum";
            this.sum.ReadOnly = true;
            this.sum.ToolTipText = "Сумма заказа";
            // 
            // userSurnameOrders
            // 
            this.userSurnameOrders.DataPropertyName = "userSurname";
            this.userSurnameOrders.HeaderText = "Фамилия";
            this.userSurnameOrders.Name = "userSurnameOrders";
            this.userSurnameOrders.ToolTipText = "Фамилия заказчика";
            // 
            // userFirstNameOrders
            // 
            this.userFirstNameOrders.DataPropertyName = "userFirstName";
            this.userFirstNameOrders.HeaderText = "Имя";
            this.userFirstNameOrders.Name = "userFirstNameOrders";
            this.userFirstNameOrders.ToolTipText = "Имя заказчика";
            // 
            // userMiddleNameOrders
            // 
            this.userMiddleNameOrders.DataPropertyName = "userMiddleName";
            this.userMiddleNameOrders.HeaderText = "Отчество";
            this.userMiddleNameOrders.Name = "userMiddleNameOrders";
            this.userMiddleNameOrders.ToolTipText = "Отчество заказчика";
            // 
            // phoneNumber
            // 
            this.phoneNumber.DataPropertyName = "phoneNumber";
            this.phoneNumber.HeaderText = "Телефон";
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.ToolTipText = "Телефон заказчика";
            // 
            // delivery
            // 
            this.delivery.DataPropertyName = "delivery";
            this.delivery.HeaderText = "Доставка";
            this.delivery.Name = "delivery";
            this.delivery.ToolTipText = "Доставка по адресу/Самовывоз";
            // 
            // adress
            // 
            this.adress.DataPropertyName = "adress";
            this.adress.HeaderText = "Адрес";
            this.adress.Name = "adress";
            this.adress.ToolTipText = "Адрес доставки";
            // 
            // orderStatus
            // 
            this.orderStatus.DataPropertyName = "orderStatus";
            this.orderStatus.HeaderText = "Статус";
            this.orderStatus.Name = "orderStatus";
            this.orderStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.orderStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.orderStatus.ToolTipText = "Статус заказа";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(72, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 28);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewComboBoxColumn1.DataPropertyName = "userRole";
            this.dataGridViewComboBoxColumn1.HeaderText = "Должность";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewComboBoxColumn2
            // 
            this.dataGridViewComboBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewComboBoxColumn2.DataPropertyName = "userRole";
            this.dataGridViewComboBoxColumn2.HeaderText = "Должность";
            this.dataGridViewComboBoxColumn2.Name = "dataGridViewComboBoxColumn2";
            this.dataGridViewComboBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewComboBoxColumn3
            // 
            this.dataGridViewComboBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewComboBoxColumn3.DataPropertyName = "userRole";
            this.dataGridViewComboBoxColumn3.HeaderText = "Должность";
            this.dataGridViewComboBoxColumn3.Name = "dataGridViewComboBoxColumn3";
            this.dataGridViewComboBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewComboBoxColumn4
            // 
            this.dataGridViewComboBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewComboBoxColumn4.DataPropertyName = "userRole";
            this.dataGridViewComboBoxColumn4.HeaderText = "Должность";
            this.dataGridViewComboBoxColumn4.Name = "dataGridViewComboBoxColumn4";
            this.dataGridViewComboBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewComboBoxColumn5
            // 
            this.dataGridViewComboBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewComboBoxColumn5.DataPropertyName = "userRole";
            this.dataGridViewComboBoxColumn5.HeaderText = "Должность";
            this.dataGridViewComboBoxColumn5.Name = "dataGridViewComboBoxColumn5";
            this.dataGridViewComboBoxColumn5.ReadOnly = true;
            this.dataGridViewComboBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewComboBoxColumn6
            // 
            this.dataGridViewComboBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewComboBoxColumn6.DataPropertyName = "userRole";
            this.dataGridViewComboBoxColumn6.HeaderText = "Должность";
            this.dataGridViewComboBoxColumn6.Name = "dataGridViewComboBoxColumn6";
            this.dataGridViewComboBoxColumn6.ReadOnly = true;
            this.dataGridViewComboBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewComboBoxColumn7
            // 
            this.dataGridViewComboBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewComboBoxColumn7.DataPropertyName = "userRole";
            this.dataGridViewComboBoxColumn7.HeaderText = "Должность";
            this.dataGridViewComboBoxColumn7.Name = "dataGridViewComboBoxColumn7";
            this.dataGridViewComboBoxColumn7.ReadOnly = true;
            this.dataGridViewComboBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewComboBoxColumn9
            // 
            this.dataGridViewComboBoxColumn9.DataPropertyName = "userRole";
            this.dataGridViewComboBoxColumn9.HeaderText = "userRole";
            this.dataGridViewComboBoxColumn9.Name = "dataGridViewComboBoxColumn9";
            this.dataGridViewComboBoxColumn9.Width = 112;
            // 
            // dataGridViewComboBoxColumn8
            // 
            this.dataGridViewComboBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewComboBoxColumn8.DataPropertyName = "userRole";
            this.dataGridViewComboBoxColumn8.HeaderText = "ID";
            this.dataGridViewComboBoxColumn8.Name = "dataGridViewComboBoxColumn8";
            this.dataGridViewComboBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn8.ToolTipText = "Идентификатор должности пользователя";
            // 
            // dataGridViewComboBoxColumn10
            // 
            this.dataGridViewComboBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewComboBoxColumn10.DataPropertyName = "userRole";
            this.dataGridViewComboBoxColumn10.HeaderText = "Должность";
            this.dataGridViewComboBoxColumn10.Name = "dataGridViewComboBoxColumn10";
            this.dataGridViewComboBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn10.ToolTipText = "Наименование должности пользователя";
            // 
            // dataGridViewComboBoxColumn11
            // 
            this.dataGridViewComboBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewComboBoxColumn11.DataPropertyName = "userRole";
            this.dataGridViewComboBoxColumn11.HeaderText = "Должность";
            this.dataGridViewComboBoxColumn11.Name = "dataGridViewComboBoxColumn11";
            this.dataGridViewComboBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewComboBoxColumn11.ToolTipText = "Наименование должности пользователя";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 611);
            this.Controls.Add(this.tabControlAdmin);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор - ИС \"Книжный магазин\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPageUsers.ResumeLayout(false);
            this.tabPageUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.tabPageBooks.ResumeLayout(false);
            this.tabPageBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.tabControlAdmin.ResumeLayout(false);
            this.tabPageOrders.ResumeLayout(false);
            this.tabPageOrders.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderedBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderedBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem книги_открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователи_открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem роли_открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранить_какToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem книги_сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователи_сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem роли_сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранить_всеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотр_справкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem о_программеToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.Button buttonDisplayAllUsers;
        private System.Windows.Forms.Button buttonSearchUser;
        private System.Windows.Forms.TextBox textBoxSearchUser;
        private System.Windows.Forms.ComboBox comboBoxSearchUser;
        private System.Windows.Forms.Button buttonSaveRoles;
        private System.Windows.Forms.Button buttonSaveUsers;
        private System.Windows.Forms.CheckBox checkBoxPassword;
        private System.Windows.Forms.DataGridView dataGridViewRoles;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.TabPage tabPageBooks;
        private System.Windows.Forms.ComboBox comboBoxOperator;
        private System.Windows.Forms.Button buttonDisplayAllBooks;
        private System.Windows.Forms.Button buttonSearchBook;
        private System.Windows.Forms.TextBox textBoxSearchBook;
        private System.Windows.Forms.ComboBox comboBoxSearchBook;
        private System.Windows.Forms.DataGridView dataGridViewCatalog;
        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.Label labelAdminCode;
        private System.Windows.Forms.TextBox textBoxAdminCode;
        private System.Windows.Forms.Button buttonSaveAdminCode;
        private System.Windows.Forms.Label labelRoles;
        private System.Windows.Forms.Label labelSearchUser;
        private System.Windows.Forms.ToolStripMenuItem путь_к_программеToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageOrders;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Label labelOrderedBooks;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Button buttonSearchOrders;
        private System.Windows.Forms.Button buttonDisplayAllOrders;
        private System.Windows.Forms.CheckBox checkBoxStatus;
        private System.Windows.Forms.CheckBox checkBoxAdress;
        private System.Windows.Forms.CheckBox checkBoxDelivery;
        private System.Windows.Forms.CheckBox checkBoxPhone;
        private System.Windows.Forms.CheckBox checkBoxMiddleName;
        private System.Windows.Forms.CheckBox checkBoxFirstName;
        private System.Windows.Forms.CheckBox checkBoxSurname;
        private System.Windows.Forms.CheckBox checkBoxSum;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.CheckBox checkBoxDisplay;
        private System.Windows.Forms.CheckBox checkBoxNumber;
        private System.Windows.Forms.Button buttonSaveOrders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn4;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn storehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn shop;
        private System.Windows.Forms.DataGridView dataGridViewOrderedBooks;
        private System.Windows.Forms.BindingSource orderedBooksBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storehouseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonSaveBooks;
        private System.Windows.Forms.ToolStripMenuItem заказы_открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказы_сохранитьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn userSurnameOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFirstNameOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn userMiddleNameOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn delivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress;
        private System.Windows.Forms.DataGridViewComboBoxColumn orderStatus;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn10;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewComboBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userMiddleName;
        private System.Windows.Forms.DataGridViewComboBoxColumn roleId;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
    }
}