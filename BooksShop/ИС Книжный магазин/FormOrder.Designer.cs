namespace ИС_Книжный_магазин
{
    partial class FormOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderedBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonOrder = new System.Windows.Forms.Button();
            this.labelOrderNumber = new System.Windows.Forms.Label();
            this.textBoxOrderNumber = new System.Windows.Forms.TextBox();
            this.labelOrderDate = new System.Windows.Forms.Label();
            this.textBoxOrderDate = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.labelOrderSum = new System.Windows.Forms.Label();
            this.textBoxOrderSum = new System.Windows.Forms.TextBox();
            this.buttonLoadOut = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.labelPhone = new System.Windows.Forms.Label();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.labelAdress = new System.Windows.Forms.Label();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.radioButtonDelivery = new System.Windows.Forms.RadioButton();
            this.radioButtonPickup = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderedBooksBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AllowUserToAddRows = false;
            this.dataGridViewOrder.AutoGenerateColumns = false;
            this.dataGridViewOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrder.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isbnDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.authorNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.shopDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn});
            this.dataGridViewOrder.DataSource = this.orderedBooksBindingSource;
            this.dataGridViewOrder.Location = new System.Drawing.Point(44, 271);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowTemplate.Height = 24;
            this.dataGridViewOrder.Size = new System.Drawing.Size(645, 196);
            this.dataGridViewOrder.TabIndex = 0;
            this.dataGridViewOrder.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrder_CellValueChanged);
            this.dataGridViewOrder.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewOrder_DataError);
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
            // shopDataGridViewTextBoxColumn
            // 
            this.shopDataGridViewTextBoxColumn.DataPropertyName = "shop";
            this.shopDataGridViewTextBoxColumn.HeaderText = "Наличие";
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
            this.orderedBooksBindingSource.DataSource = typeof(ИС_Книжный_магазин.OrderedBook);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOrder.BackColor = System.Drawing.Color.Coral;
            this.buttonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOrder.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrder.Location = new System.Drawing.Point(551, 502);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(138, 36);
            this.buttonOrder.TabIndex = 15;
            this.buttonOrder.Text = "Заказать";
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // labelOrderNumber
            // 
            this.labelOrderNumber.AutoSize = true;
            this.labelOrderNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelOrderNumber.Location = new System.Drawing.Point(431, 39);
            this.labelOrderNumber.Name = "labelOrderNumber";
            this.labelOrderNumber.Size = new System.Drawing.Size(103, 20);
            this.labelOrderNumber.TabIndex = 16;
            this.labelOrderNumber.Text = "Номер заказа";
            // 
            // textBoxOrderNumber
            // 
            this.textBoxOrderNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxOrderNumber.Location = new System.Drawing.Point(573, 33);
            this.textBoxOrderNumber.Name = "textBoxOrderNumber";
            this.textBoxOrderNumber.ReadOnly = true;
            this.textBoxOrderNumber.Size = new System.Drawing.Size(116, 26);
            this.textBoxOrderNumber.TabIndex = 18;
            // 
            // labelOrderDate
            // 
            this.labelOrderDate.AutoSize = true;
            this.labelOrderDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelOrderDate.Location = new System.Drawing.Point(431, 80);
            this.labelOrderDate.Name = "labelOrderDate";
            this.labelOrderDate.Size = new System.Drawing.Size(91, 20);
            this.labelOrderDate.TabIndex = 16;
            this.labelOrderDate.Text = "Дата заказа";
            // 
            // textBoxOrderDate
            // 
            this.textBoxOrderDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxOrderDate.Location = new System.Drawing.Point(573, 74);
            this.textBoxOrderDate.Name = "textBoxOrderDate";
            this.textBoxOrderDate.ReadOnly = true;
            this.textBoxOrderDate.Size = new System.Drawing.Size(116, 26);
            this.textBoxOrderDate.TabIndex = 18;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSurname.Location = new System.Drawing.Point(40, 39);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(74, 20);
            this.labelSurname.TabIndex = 16;
            this.labelSurname.Text = "Фамилия";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(180, 33);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(116, 26);
            this.textBoxSurname.TabIndex = 18;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFirstName.Location = new System.Drawing.Point(40, 80);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(39, 20);
            this.labelFirstName.TabIndex = 16;
            this.labelFirstName.Text = "Имя";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(180, 74);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(116, 26);
            this.textBoxFirstName.TabIndex = 18;
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMiddleName.Location = new System.Drawing.Point(40, 123);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(73, 20);
            this.labelMiddleName.TabIndex = 16;
            this.labelMiddleName.Text = "Отчество";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(180, 117);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(116, 26);
            this.textBoxMiddleName.TabIndex = 18;
            // 
            // labelOrderSum
            // 
            this.labelOrderSum.AutoSize = true;
            this.labelOrderSum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelOrderSum.Location = new System.Drawing.Point(40, 513);
            this.labelOrderSum.Name = "labelOrderSum";
            this.labelOrderSum.Size = new System.Drawing.Size(104, 20);
            this.labelOrderSum.TabIndex = 16;
            this.labelOrderSum.Text = "Сумма заказа";
            // 
            // textBoxOrderSum
            // 
            this.textBoxOrderSum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxOrderSum.Location = new System.Drawing.Point(158, 507);
            this.textBoxOrderSum.Name = "textBoxOrderSum";
            this.textBoxOrderSum.ReadOnly = true;
            this.textBoxOrderSum.Size = new System.Drawing.Size(116, 26);
            this.textBoxOrderSum.TabIndex = 18;
            // 
            // buttonLoadOut
            // 
            this.buttonLoadOut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLoadOut.Location = new System.Drawing.Point(339, 502);
            this.buttonLoadOut.Name = "buttonLoadOut";
            this.buttonLoadOut.Size = new System.Drawing.Size(183, 36);
            this.buttonLoadOut.TabIndex = 19;
            this.buttonLoadOut.Text = "Выгрузить чек";
            this.buttonLoadOut.UseVisualStyleBackColor = false;
            this.buttonLoadOut.Click += new System.EventHandler(this.buttonLoadOut_Click);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPhone.Location = new System.Drawing.Point(40, 166);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(70, 20);
            this.labelPhone.TabIndex = 16;
            this.labelPhone.Text = "Телефон";
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.BackColor = System.Drawing.Color.White;
            this.maskedTextBoxPhone.ForeColor = System.Drawing.SystemColors.InfoText;
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(158, 166);
            this.maskedTextBoxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBoxPhone.Mask = "8 (999) 000-00-00";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(138, 26);
            this.maskedTextBoxPhone.TabIndex = 21;
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAdress.Location = new System.Drawing.Point(40, 211);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(53, 20);
            this.labelAdress.TabIndex = 16;
            this.labelAdress.Text = "Адрес";
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Enabled = false;
            this.textBoxAdress.Location = new System.Drawing.Point(158, 208);
            this.textBoxAdress.Multiline = true;
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(138, 26);
            this.textBoxAdress.TabIndex = 18;
            // 
            // radioButtonDelivery
            // 
            this.radioButtonDelivery.AutoSize = true;
            this.radioButtonDelivery.Location = new System.Drawing.Point(20, 51);
            this.radioButtonDelivery.Name = "radioButtonDelivery";
            this.radioButtonDelivery.Size = new System.Drawing.Size(94, 24);
            this.radioButtonDelivery.TabIndex = 22;
            this.radioButtonDelivery.Text = "Доставка";
            this.radioButtonDelivery.UseVisualStyleBackColor = true;
            this.radioButtonDelivery.CheckedChanged += new System.EventHandler(this.radioButtonDelivery_CheckedChanged);
            // 
            // radioButtonPickup
            // 
            this.radioButtonPickup.AutoSize = true;
            this.radioButtonPickup.Checked = true;
            this.radioButtonPickup.Location = new System.Drawing.Point(20, 25);
            this.radioButtonPickup.Name = "radioButtonPickup";
            this.radioButtonPickup.Size = new System.Drawing.Size(106, 24);
            this.radioButtonPickup.TabIndex = 22;
            this.radioButtonPickup.TabStop = true;
            this.radioButtonPickup.Text = "Самовывоз";
            this.radioButtonPickup.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.radioButtonPickup);
            this.groupBox1.Controls.Add(this.radioButtonDelivery);
            this.groupBox1.Location = new System.Drawing.Point(435, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 86);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Способ доставки";
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::ИС_Книжный_магазин.Properties.Resources.ImageOrderBooks;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(732, 566);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.maskedTextBoxPhone);
            this.Controls.Add(this.buttonLoadOut);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxOrderSum);
            this.Controls.Add(this.labelOrderSum);
            this.Controls.Add(this.textBoxOrderDate);
            this.Controls.Add(this.labelOrderDate);
            this.Controls.Add(this.textBoxOrderNumber);
            this.Controls.Add(this.labelOrderNumber);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.dataGridViewOrder);
            this.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление заказа";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOrder_FormClosing);
            this.Load += new System.EventHandler(this.FormOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderedBooksBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Label labelOrderNumber;
        private System.Windows.Forms.TextBox textBoxOrderNumber;
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.TextBox textBoxOrderDate;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.Label labelOrderSum;
        private System.Windows.Forms.TextBox textBoxOrderSum;
        private System.Windows.Forms.Button buttonLoadOut;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.RadioButton radioButtonDelivery;
        private System.Windows.Forms.RadioButton radioButtonPickup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderedBooksBindingSource;
    }
}