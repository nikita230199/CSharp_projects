namespace Отель
{
    partial class FormAdd
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
            this.reservBox = new System.Windows.Forms.TextBox();
            this.roomBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.b_Add = new System.Windows.Forms.Button();
            this.phoneBox = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBoxVIP = new System.Windows.Forms.CheckBox();
            this.checkBoxNON = new System.Windows.Forms.CheckBox();
            this.b_Cancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reservBox
            // 
            this.reservBox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reservBox.Location = new System.Drawing.Point(240, 35);
            this.reservBox.Name = "reservBox";
            this.reservBox.Size = new System.Drawing.Size(160, 28);
            this.reservBox.TabIndex = 0;
            // 
            // roomBox
            // 
            this.roomBox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomBox.Location = new System.Drawing.Point(241, 74);
            this.roomBox.Name = "roomBox";
            this.roomBox.Size = new System.Drawing.Size(161, 28);
            this.roomBox.TabIndex = 1;
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox.Location = new System.Drawing.Point(240, 160);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(274, 28);
            this.nameBox.TabIndex = 3;
            // 
            // surnameBox
            // 
            this.surnameBox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameBox.Location = new System.Drawing.Point(240, 114);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(274, 28);
            this.surnameBox.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd MMMM yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(240, 206);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(274, 28);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2018, 1, 1, 12, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd MMMM yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(240, 252);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(274, 28);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.Value = new System.DateTime(2018, 1, 1, 12, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "№ брони:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "№ комнаты:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(29, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Фамилия:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(29, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Дата выезда:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(30, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Дата заезда:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(29, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Мобильный телефон:";
            // 
            // b_Add
            // 
            this.b_Add.BackColor = System.Drawing.Color.Navy;
            this.b_Add.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Add.ForeColor = System.Drawing.SystemColors.Control;
            this.b_Add.Location = new System.Drawing.Point(112, 360);
            this.b_Add.Name = "b_Add";
            this.b_Add.Size = new System.Drawing.Size(179, 51);
            this.b_Add.TabIndex = 9;
            this.b_Add.Text = "Добавить";
            this.b_Add.UseVisualStyleBackColor = false;
            this.b_Add.Click += new System.EventHandler(this.b_Add_Click);
            // 
            // phoneBox
            // 
            this.phoneBox.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneBox.Location = new System.Drawing.Point(241, 303);
            this.phoneBox.Mask = "+7 (999) 000-0000";
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(194, 28);
            this.phoneBox.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(30, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Имя:";
            // 
            // checkBoxVIP
            // 
            this.checkBoxVIP.AutoSize = true;
            this.checkBoxVIP.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxVIP.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxVIP.Location = new System.Drawing.Point(555, 253);
            this.checkBoxVIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxVIP.Name = "checkBoxVIP";
            this.checkBoxVIP.Size = new System.Drawing.Size(183, 24);
            this.checkBoxVIP.TabIndex = 7;
            this.checkBoxVIP.Text = "VIP:                   ";
            this.checkBoxVIP.UseVisualStyleBackColor = true;
            // 
            // checkBoxNON
            // 
            this.checkBoxNON.AutoSize = true;
            this.checkBoxNON.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxNON.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxNON.Location = new System.Drawing.Point(555, 294);
            this.checkBoxNON.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxNON.Name = "checkBoxNON";
            this.checkBoxNON.Size = new System.Drawing.Size(186, 44);
            this.checkBoxNON.TabIndex = 8;
            this.checkBoxNON.Text = "Нежелательный  \r\nклиент :";
            this.checkBoxNON.UseVisualStyleBackColor = true;
            // 
            // b_Cancel
            // 
            this.b_Cancel.BackColor = System.Drawing.Color.Navy;
            this.b_Cancel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_Cancel.ForeColor = System.Drawing.Color.White;
            this.b_Cancel.Location = new System.Drawing.Point(512, 360);
            this.b_Cancel.Name = "b_Cancel";
            this.b_Cancel.Size = new System.Drawing.Size(178, 51);
            this.b_Cancel.TabIndex = 11;
            this.b_Cancel.Text = "Выход";
            this.b_Cancel.UseVisualStyleBackColor = false;
            this.b_Cancel.Click += new System.EventHandler(this.b_Cancel_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(313, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Очистить поля";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.b_Cleare_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Отель.Properties.Resources.picture;
            this.ClientSize = new System.Drawing.Size(792, 423);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b_Cancel);
            this.Controls.Add(this.checkBoxNON);
            this.Controls.Add(this.checkBoxVIP);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.b_Add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.roomBox);
            this.Controls.Add(this.reservBox);
            this.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form2";
            this.Text = "Добавление клиента";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox reservBox;
        public System.Windows.Forms.TextBox roomBox;
        public System.Windows.Forms.TextBox nameBox;
        public System.Windows.Forms.TextBox surnameBox;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button b_Add;
        private System.Windows.Forms.MaskedTextBox phoneBox;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxVIP;
        private System.Windows.Forms.CheckBox checkBoxNON;
        private System.Windows.Forms.Button b_Cancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
    }
}