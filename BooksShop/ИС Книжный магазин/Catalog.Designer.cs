namespace ИС_Книжный_магазин
{
    partial class Catalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Catalog));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранить_какToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотр_справкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.о_программеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControlCatalog = new System.Windows.Forms.TabControl();
            this.tabPageBooks = new System.Windows.Forms.TabPage();
            this.buttonDisplayAll = new System.Windows.Forms.Button();
            this.buttonSearchBook = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.labelInvalidSearch = new System.Windows.Forms.Label();
            this.comboBoxOperator = new System.Windows.Forms.ComboBox();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.comboBoxSearch = new System.Windows.Forms.ComboBox();
            this.labelCurrentUser = new System.Windows.Forms.Label();
            this.dataGridViewCatalog = new System.Windows.Forms.DataGridView();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.orderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.tabControlCatalog.SuspendLayout();
            this.tabPageBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.tabPageOrders.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderedBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderedBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 611);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(951, 33);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранить_какToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранить_какToolStripMenuItem
            // 
            this.сохранить_какToolStripMenuItem.Name = "сохранить_какToolStripMenuItem";
            this.сохранить_какToolStripMenuItem.Size = new System.Drawing.Size(214, 30);
            this.сохранить_какToolStripMenuItem.Text = "Сохранить как";
            this.сохранить_какToolStripMenuItem.Click += new System.EventHandler(this.сохранить_какToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотр_справкиToolStripMenuItem,
            this.о_программеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // просмотр_справкиToolStripMenuItem
            // 
            this.просмотр_справкиToolStripMenuItem.Name = "просмотр_справкиToolStripMenuItem";
            this.просмотр_справкиToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.просмотр_справкиToolStripMenuItem.Text = "Просмотр справки";
            this.просмотр_справкиToolStripMenuItem.Click += new System.EventHandler(this.просмотр_справкиToolStripMenuItem_Click);
            // 
            // о_программеToolStripMenuItem
            // 
            this.о_программеToolStripMenuItem.Name = "о_программеToolStripMenuItem";
            this.о_программеToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.о_программеToolStripMenuItem.Text = "О программе";
            this.о_программеToolStripMenuItem.Click += new System.EventHandler(this.о_программеToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControlCatalog
            // 
            this.tabControlCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlCatalog.Controls.Add(this.tabPageBooks);
            this.tabControlCatalog.Controls.Add(this.tabPageOrders);
            this.tabControlCatalog.Location = new System.Drawing.Point(3, 31);
            this.tabControlCatalog.Name = "tabControlCatalog";
            this.tabControlCatalog.SelectedIndex = 0;
            this.tabControlCatalog.Size = new System.Drawing.Size(951, 580);
            this.tabControlCatalog.TabIndex = 20;
            // 
            // tabPageBooks
            // 
            this.tabPageBooks.BackgroundImage = global::ИС_Книжный_магазин.Properties.Resources.ImageCatalogBooks;
            this.tabPageBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageBooks.Controls.Add(this.buttonDisplayAll);
            this.tabPageBooks.Controls.Add(this.buttonSearchBook);
            this.tabPageBooks.Controls.Add(this.buttonOrder);
            this.tabPageBooks.Controls.Add(this.labelInvalidSearch);
            this.tabPageBooks.Controls.Add(this.comboBoxOperator);
            this.tabPageBooks.Controls.Add(this.textBoxFilter);
            this.tabPageBooks.Controls.Add(this.comboBoxSearch);
            this.tabPageBooks.Controls.Add(this.labelCurrentUser);
            this.tabPageBooks.Controls.Add(this.dataGridViewCatalog);
            this.tabPageBooks.Location = new System.Drawing.Point(4, 31);
            this.tabPageBooks.Name = "tabPageBooks";
            this.tabPageBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBooks.Size = new System.Drawing.Size(943, 545);
            this.tabPageBooks.TabIndex = 0;
            this.tabPageBooks.Text = "Каталог книг";
            this.tabPageBooks.UseVisualStyleBackColor = true;
            // 
            // buttonDisplayAll
            // 
            this.buttonDisplayAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDisplayAll.BackColor = System.Drawing.Color.White;
            this.buttonDisplayAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDisplayAll.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDisplayAll.Location = new System.Drawing.Point(753, 83);
            this.buttonDisplayAll.Name = "buttonDisplayAll";
            this.buttonDisplayAll.Size = new System.Drawing.Size(138, 25);
            this.buttonDisplayAll.TabIndex = 24;
            this.buttonDisplayAll.Text = "Отобразить всё";
            this.buttonDisplayAll.UseVisualStyleBackColor = false;
            this.buttonDisplayAll.Click += new System.EventHandler(this.buttonDisplayAllBooks_Click);
            // 
            // buttonSearchBook
            // 
            this.buttonSearchBook.BackColor = System.Drawing.Color.White;
            this.buttonSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearchBook.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchBook.Location = new System.Drawing.Point(57, 85);
            this.buttonSearchBook.Name = "buttonSearchBook";
            this.buttonSearchBook.Size = new System.Drawing.Size(64, 27);
            this.buttonSearchBook.TabIndex = 25;
            this.buttonSearchBook.Text = "Найти";
            this.buttonSearchBook.UseVisualStyleBackColor = false;
            this.buttonSearchBook.Click += new System.EventHandler(this.buttonSearchBook_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOrder.BackColor = System.Drawing.Color.Coral;
            this.buttonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOrder.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrder.Location = new System.Drawing.Point(753, 9);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(138, 36);
            this.buttonOrder.TabIndex = 28;
            this.buttonOrder.Text = "Заказать";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // labelInvalidSearch
            // 
            this.labelInvalidSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelInvalidSearch.AutoSize = true;
            this.labelInvalidSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelInvalidSearch.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInvalidSearch.Location = new System.Drawing.Point(53, 490);
            this.labelInvalidSearch.Name = "labelInvalidSearch";
            this.labelInvalidSearch.Size = new System.Drawing.Size(263, 26);
            this.labelInvalidSearch.TabIndex = 27;
            this.labelInvalidSearch.Text = "Не нашли то, что искали?";
            this.labelInvalidSearch.Click += new System.EventHandler(this.labelInvalidSearch_Click);
            // 
            // comboBoxOperator
            // 
            this.comboBoxOperator.FormattingEnabled = true;
            this.comboBoxOperator.Location = new System.Drawing.Point(252, 51);
            this.comboBoxOperator.Name = "comboBoxOperator";
            this.comboBoxOperator.Size = new System.Drawing.Size(44, 30);
            this.comboBoxOperator.TabIndex = 26;
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilter.Location = new System.Drawing.Point(315, 51);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(576, 30);
            this.textBoxFilter.TabIndex = 23;
            // 
            // comboBoxSearch
            // 
            this.comboBoxSearch.DisplayMember = "Index";
            this.comboBoxSearch.FormattingEnabled = true;
            this.comboBoxSearch.Location = new System.Drawing.Point(57, 51);
            this.comboBoxSearch.Name = "comboBoxSearch";
            this.comboBoxSearch.Size = new System.Drawing.Size(174, 30);
            this.comboBoxSearch.TabIndex = 22;
            this.comboBoxSearch.ValueMember = "Index";
            this.comboBoxSearch.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearch_SelectedIndexChanged);
            // 
            // labelCurrentUser
            // 
            this.labelCurrentUser.AutoSize = true;
            this.labelCurrentUser.BackColor = System.Drawing.Color.Coral;
            this.labelCurrentUser.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentUser.Location = new System.Drawing.Point(53, 15);
            this.labelCurrentUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurrentUser.Name = "labelCurrentUser";
            this.labelCurrentUser.Size = new System.Drawing.Size(59, 26);
            this.labelCurrentUser.TabIndex = 21;
            this.labelCurrentUser.Text = "login";
            // 
            // dataGridViewCatalog
            // 
            this.dataGridViewCatalog.AllowUserToAddRows = false;
            this.dataGridViewCatalog.AllowUserToDeleteRows = false;
            this.dataGridViewCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCatalog.AutoGenerateColumns = false;
            this.dataGridViewCatalog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCatalog.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCatalog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCatalog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isbn,
            this.nameDataGridViewTextBoxColumn,
            this.authorNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.shopDataGridViewTextBoxColumn});
            this.dataGridViewCatalog.DataSource = this.bookBindingSource;
            this.dataGridViewCatalog.Location = new System.Drawing.Point(57, 121);
            this.dataGridViewCatalog.Name = "dataGridViewCatalog";
            this.dataGridViewCatalog.ReadOnly = true;
            this.dataGridViewCatalog.RowTemplate.Height = 24;
            this.dataGridViewCatalog.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCatalog.Size = new System.Drawing.Size(833, 366);
            this.dataGridViewCatalog.TabIndex = 20;
            // 
            // isbn
            // 
            this.isbn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isbn.DataPropertyName = "isbn";
            this.isbn.HeaderText = "ISBN";
            this.isbn.Name = "isbn";
            this.isbn.ReadOnly = true;
            this.isbn.ToolTipText = "Международный стандартный номер книги";
            this.isbn.Width = 87;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.ToolTipText = "Название книги";
            // 
            // authorNameDataGridViewTextBoxColumn
            // 
            this.authorNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.authorNameDataGridViewTextBoxColumn.DataPropertyName = "authorName";
            this.authorNameDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.authorNameDataGridViewTextBoxColumn.Name = "authorNameDataGridViewTextBoxColumn";
            this.authorNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.authorNameDataGridViewTextBoxColumn.ToolTipText = "Автор книги";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.ToolTipText = "Цена книги";
            this.priceDataGridViewTextBoxColumn.Width = 90;
            // 
            // shopDataGridViewTextBoxColumn
            // 
            this.shopDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.shopDataGridViewTextBoxColumn.DataPropertyName = "shop";
            this.shopDataGridViewTextBoxColumn.HeaderText = "Наличие";
            this.shopDataGridViewTextBoxColumn.Name = "shopDataGridViewTextBoxColumn";
            this.shopDataGridViewTextBoxColumn.ReadOnly = true;
            this.shopDataGridViewTextBoxColumn.ToolTipText = "Текущее количество книг в магазине";
            this.shopDataGridViewTextBoxColumn.Width = 121;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(ИС_Книжный_магазин.Book);
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.BackgroundImage = global::ИС_Книжный_магазин.Properties.Resources.ImageCatalogBooks;
            this.tabPageOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageOrders.Controls.Add(this.groupBox1);
            this.tabPageOrders.Controls.Add(this.buttonSaveOrders);
            this.tabPageOrders.Controls.Add(this.buttonDisplayAllOrders);
            this.tabPageOrders.Controls.Add(this.checkBoxDisplay);
            this.tabPageOrders.Controls.Add(this.buttonSearchOrders);
            this.tabPageOrders.Controls.Add(this.labelOrderedBooks);
            this.tabPageOrders.Controls.Add(this.dataGridViewOrderedBooks);
            this.tabPageOrders.Controls.Add(this.dataGridViewOrders);
            this.tabPageOrders.Controls.Add(this.dateTimePicker1);
            this.tabPageOrders.Location = new System.Drawing.Point(4, 31);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrders.Size = new System.Drawing.Size(943, 545);
            this.tabPageOrders.TabIndex = 1;
            this.tabPageOrders.Text = "Мои заказы";
            this.tabPageOrders.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
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
            this.groupBox1.Location = new System.Drawing.Point(826, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 361);
            this.groupBox1.TabIndex = 32;
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
            this.checkBoxSum.Location = new System.Drawing.Point(6, 104);
            this.checkBoxSum.Name = "checkBoxSum";
            this.checkBoxSum.Size = new System.Drawing.Size(92, 26);
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
            this.checkBoxNumber.Location = new System.Drawing.Point(6, 40);
            this.checkBoxNumber.Name = "checkBoxNumber";
            this.checkBoxNumber.Size = new System.Drawing.Size(93, 26);
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
            this.checkBoxDate.Location = new System.Drawing.Point(6, 72);
            this.checkBoxDate.Name = "checkBoxDate";
            this.checkBoxDate.Size = new System.Drawing.Size(77, 26);
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
            this.checkBoxStatus.Location = new System.Drawing.Point(6, 328);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(94, 26);
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
            this.checkBoxSurname.Location = new System.Drawing.Point(6, 136);
            this.checkBoxSurname.Name = "checkBoxSurname";
            this.checkBoxSurname.Size = new System.Drawing.Size(113, 26);
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
            this.checkBoxAdress.Location = new System.Drawing.Point(6, 296);
            this.checkBoxAdress.Name = "checkBoxAdress";
            this.checkBoxAdress.Size = new System.Drawing.Size(88, 26);
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
            this.checkBoxFirstName.Location = new System.Drawing.Point(6, 168);
            this.checkBoxFirstName.Name = "checkBoxFirstName";
            this.checkBoxFirstName.Size = new System.Drawing.Size(72, 26);
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
            this.checkBoxDelivery.Location = new System.Drawing.Point(6, 264);
            this.checkBoxDelivery.Name = "checkBoxDelivery";
            this.checkBoxDelivery.Size = new System.Drawing.Size(114, 26);
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
            this.checkBoxMiddleName.Location = new System.Drawing.Point(6, 200);
            this.checkBoxMiddleName.Name = "checkBoxMiddleName";
            this.checkBoxMiddleName.Size = new System.Drawing.Size(114, 26);
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
            this.checkBoxPhone.Location = new System.Drawing.Point(6, 232);
            this.checkBoxPhone.Name = "checkBoxPhone";
            this.checkBoxPhone.Size = new System.Drawing.Size(111, 26);
            this.checkBoxPhone.TabIndex = 20;
            this.checkBoxPhone.Text = "Телефон";
            this.checkBoxPhone.UseVisualStyleBackColor = true;
            this.checkBoxPhone.CheckedChanged += new System.EventHandler(this.checkBoxPhone_CheckedChanged);
            // 
            // buttonSaveOrders
            // 
            this.buttonSaveOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveOrders.BackColor = System.Drawing.Color.White;
            this.buttonSaveOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveOrders.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveOrders.Location = new System.Drawing.Point(729, 500);
            this.buttonSaveOrders.Name = "buttonSaveOrders";
            this.buttonSaveOrders.Size = new System.Drawing.Size(91, 27);
            this.buttonSaveOrders.TabIndex = 31;
            this.buttonSaveOrders.Text = "Сохранить";
            this.buttonSaveOrders.UseVisualStyleBackColor = false;
            this.buttonSaveOrders.Click += new System.EventHandler(this.buttonSaveOrders_Click);
            // 
            // buttonDisplayAllOrders
            // 
            this.buttonDisplayAllOrders.BackColor = System.Drawing.Color.White;
            this.buttonDisplayAllOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDisplayAllOrders.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDisplayAllOrders.Location = new System.Drawing.Point(322, 33);
            this.buttonDisplayAllOrders.Name = "buttonDisplayAllOrders";
            this.buttonDisplayAllOrders.Size = new System.Drawing.Size(138, 28);
            this.buttonDisplayAllOrders.TabIndex = 30;
            this.buttonDisplayAllOrders.Text = "Отобразить всё";
            this.buttonDisplayAllOrders.UseVisualStyleBackColor = false;
            this.buttonDisplayAllOrders.Click += new System.EventHandler(this.buttonDisplayAllOrders_Click);
            // 
            // checkBoxDisplay
            // 
            this.checkBoxDisplay.AutoSize = true;
            this.checkBoxDisplay.BackColor = System.Drawing.Color.White;
            this.checkBoxDisplay.Location = new System.Drawing.Point(58, 67);
            this.checkBoxDisplay.Name = "checkBoxDisplay";
            this.checkBoxDisplay.Size = new System.Drawing.Size(351, 26);
            this.checkBoxDisplay.TabIndex = 29;
            this.checkBoxDisplay.Text = "Отображать только открытые заказы";
            this.checkBoxDisplay.UseVisualStyleBackColor = false;
            this.checkBoxDisplay.CheckedChanged += new System.EventHandler(this.checkBoxDisplay_CheckedChanged);
            // 
            // buttonSearchOrders
            // 
            this.buttonSearchOrders.BackColor = System.Drawing.Color.White;
            this.buttonSearchOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSearchOrders.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchOrders.Location = new System.Drawing.Point(243, 33);
            this.buttonSearchOrders.Name = "buttonSearchOrders";
            this.buttonSearchOrders.Size = new System.Drawing.Size(64, 27);
            this.buttonSearchOrders.TabIndex = 28;
            this.buttonSearchOrders.Text = "Найти";
            this.buttonSearchOrders.UseVisualStyleBackColor = false;
            this.buttonSearchOrders.Click += new System.EventHandler(this.buttonSearchOrders_Click);
            // 
            // labelOrderedBooks
            // 
            this.labelOrderedBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelOrderedBooks.AutoSize = true;
            this.labelOrderedBooks.BackColor = System.Drawing.Color.White;
            this.labelOrderedBooks.Location = new System.Drawing.Point(54, 331);
            this.labelOrderedBooks.Name = "labelOrderedBooks";
            this.labelOrderedBooks.Size = new System.Drawing.Size(169, 22);
            this.labelOrderedBooks.TabIndex = 27;
            this.labelOrderedBooks.Text = "Заказанные книги:";
            // 
            // dataGridViewOrderedBooks
            // 
            this.dataGridViewOrderedBooks.AllowUserToAddRows = false;
            this.dataGridViewOrderedBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOrderedBooks.AutoGenerateColumns = false;
            this.dataGridViewOrderedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrderedBooks.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewOrderedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderedBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isbnDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.authorNameDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1,
            this.shopDataGridViewTextBoxColumn1,
            this.numberDataGridViewTextBoxColumn});
            this.dataGridViewOrderedBooks.DataSource = this.orderedBooksBindingSource;
            this.dataGridViewOrderedBooks.Location = new System.Drawing.Point(58, 354);
            this.dataGridViewOrderedBooks.Name = "dataGridViewOrderedBooks";
            this.dataGridViewOrderedBooks.RowTemplate.Height = 24;
            this.dataGridViewOrderedBooks.Size = new System.Drawing.Size(762, 140);
            this.dataGridViewOrderedBooks.TabIndex = 26;
            this.dataGridViewOrderedBooks.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewOrderedBooks_DataError);
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            this.isbnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // authorNameDataGridViewTextBoxColumn1
            // 
            this.authorNameDataGridViewTextBoxColumn1.DataPropertyName = "authorName";
            this.authorNameDataGridViewTextBoxColumn1.HeaderText = "Автор";
            this.authorNameDataGridViewTextBoxColumn1.Name = "authorNameDataGridViewTextBoxColumn1";
            this.authorNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Цена";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // shopDataGridViewTextBoxColumn1
            // 
            this.shopDataGridViewTextBoxColumn1.DataPropertyName = "shop";
            this.shopDataGridViewTextBoxColumn1.HeaderText = "Наличие";
            this.shopDataGridViewTextBoxColumn1.Name = "shopDataGridViewTextBoxColumn1";
            this.shopDataGridViewTextBoxColumn1.ReadOnly = true;
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
            this.dataGridViewOrders.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.dataGridViewOrders.Location = new System.Drawing.Point(58, 99);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.RowTemplate.Height = 24;
            this.dataGridViewOrders.Size = new System.Drawing.Size(762, 225);
            this.dataGridViewOrders.TabIndex = 25;
            this.dataGridViewOrders.CurrentCellChanged += new System.EventHandler(this.dataGridViewOrders_CurrentCellChanged);
            this.dataGridViewOrders.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewOrders_UserDeletingRow);
            // 
            // numberOrder
            // 
            this.numberOrder.DataPropertyName = "number";
            this.numberOrder.HeaderText = "Номер";
            this.numberOrder.Name = "numberOrder";
            this.numberOrder.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.ToolTipText = "Дата заказа";
            this.date.Width = 87;
            // 
            // sum
            // 
            this.sum.DataPropertyName = "sum";
            this.sum.HeaderText = "Сумма";
            this.sum.Name = "sum";
            this.sum.ReadOnly = true;
            // 
            // userSurnameOrders
            // 
            this.userSurnameOrders.DataPropertyName = "userSurname";
            this.userSurnameOrders.HeaderText = "Фамилия";
            this.userSurnameOrders.Name = "userSurnameOrders";
            // 
            // userFirstNameOrders
            // 
            this.userFirstNameOrders.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.userFirstNameOrders.DataPropertyName = "userFirstName";
            this.userFirstNameOrders.HeaderText = "Имя";
            this.userFirstNameOrders.Name = "userFirstNameOrders";
            this.userFirstNameOrders.ToolTipText = "Имя заказчика";
            this.userFirstNameOrders.Width = 82;
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
            // 
            // delivery
            // 
            this.delivery.DataPropertyName = "delivery";
            this.delivery.HeaderText = "Доставка";
            this.delivery.Name = "delivery";
            // 
            // adress
            // 
            this.adress.DataPropertyName = "adress";
            this.adress.HeaderText = "Адрес";
            this.adress.Name = "adress";
            // 
            // orderStatus
            // 
            this.orderStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderStatus.DataPropertyName = "orderStatus";
            this.orderStatus.HeaderText = "Статус";
            this.orderStatus.Name = "orderStatus";
            this.orderStatus.ReadOnly = true;
            this.orderStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.orderStatus.ToolTipText = "Статус заказа";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(58, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 30);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 611);
            this.Controls.Add(this.tabControlCatalog);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitter1);
            this.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Catalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Каталог - ИС \"Книжный магазин\"";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Catalog_FormClosing);
            this.Load += new System.EventHandler(this.Catalog_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlCatalog.ResumeLayout(false);
            this.tabPageBooks.ResumeLayout(false);
            this.tabPageBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
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
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранить_какToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотр_справкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem о_программеToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.TabControl tabControlCatalog;
        private System.Windows.Forms.TabPage tabPageBooks;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Label labelInvalidSearch;
        private System.Windows.Forms.ComboBox comboBoxOperator;
        private System.Windows.Forms.Button buttonDisplayAll;
        private System.Windows.Forms.Button buttonSearchBook;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.ComboBox comboBoxSearch;
        private System.Windows.Forms.Label labelCurrentUser;
        public System.Windows.Forms.DataGridView dataGridViewCatalog;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tabPageOrders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxSum;
        private System.Windows.Forms.CheckBox checkBoxNumber;
        private System.Windows.Forms.CheckBox checkBoxDate;
        private System.Windows.Forms.CheckBox checkBoxStatus;
        private System.Windows.Forms.CheckBox checkBoxSurname;
        private System.Windows.Forms.CheckBox checkBoxAdress;
        private System.Windows.Forms.CheckBox checkBoxFirstName;
        private System.Windows.Forms.CheckBox checkBoxDelivery;
        private System.Windows.Forms.CheckBox checkBoxMiddleName;
        private System.Windows.Forms.CheckBox checkBoxPhone;
        private System.Windows.Forms.Button buttonSaveOrders;
        private System.Windows.Forms.Button buttonDisplayAllOrders;
        private System.Windows.Forms.CheckBox checkBoxDisplay;
        private System.Windows.Forms.Button buttonSearchOrders;
        private System.Windows.Forms.Label labelOrderedBooks;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.BindingSource orderBindingSource;//!!!
        private System.Windows.Forms.DataGridView dataGridViewOrderedBooks;
        private System.Windows.Forms.BindingSource orderedBooksBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn userSurnameOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFirstNameOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn userMiddleNameOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn delivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderStatus;
    }
}

