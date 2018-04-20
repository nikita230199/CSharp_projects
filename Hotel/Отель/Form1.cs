using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing;
using System.Collections.Generic;

namespace Отель
{
    public partial class Form1 : Form
    {
        public string folderClients = "Клиенты";    // Папка в текущем каталоге с файлами клиентов

        public static string nameFile = "";         // Имя текущего файла клиентов. 
        public static string pathCurFile = "";      // Папка "Клиенты" + имя текущего файла клиентов. 
        public static List<ClientClass> list = new List<ClientClass>(); // Список клиентов.
        public static bool editList = false;        // Редактировался ли список (таблица) для ее последующего сохранения.
        public static string textButton = "Завершить работу с сохранением списка клиентов";
        public static bool newFile = false;         // Определен ли новый файл клиентов.
        public static string vers = "4.2";          // Версия программы.

        public Режим formPSWD;
        public int rowAdd = 1;                      // Наличие пустой строки в DataGridView для добавления нового объекта.

        //---------------------------------------------------
        public Form1()
        { InitializeComponent(); }

        //---------------------------------------------------
        // Запускаем окно с выбором режима работы.
        // Выполняем настройки.
        // Проверяем различные сочетания состояния рееста и наличия файлов клиентов.
        // Загружаем клиентов либо из тестового списка , либо из текущего файла.
        private void Form1_Load(object sender, EventArgs e)
        {

            ////////formPSWD = new Режим();
            ////////formPSWD.ShowDialog();
            ////////if (Режим.mode == 0)
            ////////{
            ////////    Close();
            ////////    return;
            ////////}

            Text += "    Версия программы " + vers;

            if (Режим.mode == 1)     // Только просмотр.
            {
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.ReadOnly = true;

                b_AddNew.Enabled = false;
                b_Edit.Enabled = false;
                b_DeleteRow.Enabled = false;
                b_Cleare.Enabled = false;
                b_NewFileClient.Enabled = false;

                textButton = "Завершить работу";
            }


            label3.Text = "";

            b_SaveList.Text = textButton;

            if (dataGridView1.Rows.Count == 1)   // Таблица еще пустая.
                rowAdd = 1;         // Есть строка для добавления объекта
            else
                rowAdd = 0;         // Нет строки для добавления объекта


            // Сформировать следующие переменные:
            /* 
             * flagFalesInFolder = 0 - нет файлов в папке "Клиенты";
             * flagFalesInFolder = 1 - есть файлы в папке "Клиенты";
             * 
             * flagNameFile = 0 - нет имени файла в реестре;
             * flagNameFile = 1 - есть имя файла в реестре;
             */

            int flagNameFile = 0;
            int flagFalesInFolder = 0;


            // Чтение списка файлов в папке Клиенты.
            string[] files = null;

            if (!Directory.Exists(folderClients))
            {
                Directory.CreateDirectory(folderClients);
                flagFalesInFolder = 0;
            }
            else
            {
                DirectoryInfo di = new DirectoryInfo(folderClients);
                FileInfo[] filesDir = di.GetFiles();

                files = new string[filesDir.Length];

                // Преобразуем из FileInfo в string/
                for (int i = 0; i < filesDir.Length; i++)
                    files[i] = filesDir[i].Name;


                if (files.Length > 0)    // Файлы клиентов есть.
                    flagFalesInFolder = 1;
                else
                    flagFalesInFolder = 0;
            }

            // Чтение имени текущего  файла из реестра.

            nameFile = MyReg.ValueGet();

            if (nameFile == "")
                flagNameFile = 0;
            else
                flagNameFile = 1;




            // Анализируем сочетание flagNameFile и flagFalesInFolder.

            if (flagNameFile == 1 && flagFalesInFolder == 1)
            {

                pathCurFile = Path.Combine(folderClients, nameFile);

                if (Array.IndexOf(files, nameFile) == -1)
                {
                    MyReg.SubKeyDel();   // Удалить имя файла из реестра.
                    flagNameFile = 0;

                    b_ListFiles_Click(null, null);   //------------->>>>
                    return;
                }
                else if ((list = MySerial<List<ClientClass>>.Deserialize(pathCurFile)) != null)
                {
                    pathCurFile = Path.Combine(folderClients, nameFile);
                    label3.Text = nameFile;

                    if (Режим.mode == 2)
                        b_SaveList.Text = textButton + " в \"" + nameFile + "\"";

                    clientClassBindingSource.DataSource = list;

                    editList = false;

                    return;
                }
                else
                {
                    pathCurFile = "";
                    MessageBox.Show("Открыть файл и загрузить список клиентов не удалось.",
                        "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flagNameFile = 0;
                    return;
                }
            }


            if (flagNameFile == 1 && flagFalesInFolder == 0)
            {
                MyReg.SubKeyDel();   // Удалить имя файла из реестра.
                flagNameFile = 0;
            }



            if (flagNameFile == 0 && flagFalesInFolder == 1)
            {
                b_ListFiles_Click(null, null);
                editList = false;
                return;
            }


            if (flagNameFile == 0 && flagFalesInFolder == 0)
            {

                DialogResult res = MessageBox.Show("Файл не найден! \n\nЗагрузить тестовый список клиентов?",
                        "Сделайте выбор", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    list.Add(new ClientClass(1, 251, "Иванов", "Петр",
                        new DateTime(2018, 06, 16), new DateTime(2018, 06, 26), "+7 (916) 333-4455", false, false));
                    list.Add(new ClientClass(2, 252, "Петров", "Иван",
                        new DateTime(2018, 06, 16), new DateTime(2018, 06, 26), "+7 (916) 444-4455", false, false));
                    list.Add(new ClientClass(3, 251, "Козлов", "Буян",
                        new DateTime(2017, 06, 06), new DateTime(2017, 06, 15), "+7 (916) 555-4455", false, true));
                    list.Add(new ClientClass(4, 253, "Лепселидзе", "Григорий",
                        new DateTime(2018, 2, 05), new DateTime(2018, 2, 13), "+7 (916) 555-4455", true, false));
                }

                clientClassBindingSource.DataSource = list;
                editList = false;
            }
        }



        //---------------------------------------------------
        // Отображаем форму со списком файлов.
        private void b_ListFiles_Click(object sender, EventArgs e) // загрузка с указанием файла
        {
            ListFiles form = new ListFiles();
            form.form1 = this;
            form.ShowDialog();
        }

        //---------------------------------------------------
        // Отображаем форму для перехода к новому файлу.
        private void newClient_Click(object sender, EventArgs e)
        {
            NewFile form = new NewFile();
            form.form1 = this;
            form.ShowDialog();

            if (newFile)
            {
                if (MessageBox.Show("Текущие клиенты из таблицы запомнены в файле " + Form1.nameFile + ".\n\n" +
                                    "Очистить таблицу клиентов для нового файла?", "Внимание",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    list.Clear();
                    dataGridView1.Rows.Clear();
                    //clientClassBindingSource.ResetBindings(false);
                }

                editList = true;
                newFile = false;
            }
        }


        //---------------------------------------------------
        // Отображаем форму для добавления нового клиента.
        private void b_AddNew_Click(object sender, EventArgs e)
        {
            FormAdd form = new FormAdd();
            form.form1 = this;
            form.ShowDialog();
        }



        //---------------------------------------------------
        // Отображаем форму для редактирования клиента.
        private void b_Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == rowAdd)
            {
                MessageBox.Show("Нельзя редактировать пустую таблицу.", "ОШИБКА");
                return;
            }


            if (dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Для редактирования клиента его строку нужно выделить.", "ОШИБКА");
                return;
            }

            int y = dataGridView1.CurrentRow.Index;

            FormEdit form = new FormEdit();
            form.form1 = this;
            form.ShowDialog();
        }

        //------------------------------------------------------------------
        // Отображаем форму для удаления клиента.
        private void b_DeleteRow_Click(object sender, EventArgs e)
        {
            int y = dataGridView1.CurrentRow.Index;

            if (dataGridView1.CurrentRow.IsNewRow || y < 0)
            {
                MessageBox.Show("Для удаления клиента его строку нужно выделить.", "ОШИБКА");
                return;
            }

            string fam = (string)dataGridView1.CurrentRow.Cells["surnam"].Value;

            if (MessageBox.Show("Вы действительно хотите удалить клиента " + fam + "?", "Внимание",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            //dataGridView1.Rows.RemoveAt(y);
            list.RemoveAt(y);
            clientClassBindingSource.ResetBindings(false);

            MessageBox.Show("Клиент " + fam + " удален!", "Внимание");
        }



        //---------------------------------------------------
        // Обработчик события Click для отбора клиентов по совокупности критериев.
        private void searchFilterButton_Click(object sender, EventArgs e)
        {
            //b_ВсеКлиенты_Click(null, null);

            dataGridView1.CurrentCell = null;
            int count = dataGridView1.Rows.Count - rowAdd;

            for (int i = 0; i < count; i++)
                //for (int i = 0; i < count && dataGridView1.Rows[i].Visible == true; i++)
                if (RowFind(i))
                    dataGridView1.Rows[i].Visible = true;
                else
                    dataGridView1.Rows[i].Visible = false;
        }

        //---------------------------------------------------
        // Метод проверяет поля переданной строки 
        // на одновременное равенство всем критериям.
        private bool RowFind(int i)
        {
            if (reservBox.Text != "")
                if (dataGridView1["reserv", i].Value.ToString() != reservBox.Text)
                    return false;

            if (roomBox.Text != "")
                if (dataGridView1["room", i].Value.ToString() != roomBox.Text)
                    return false;


            if (surnameBox.Text != "")
                if (dataGridView1["surnam", i].Value.ToString() != surnameBox.Text)
                    return false;

            if (telefonBox.Text != "+7 (   )    -")
                if ((string)dataGridView1["telefon", i].Value != telefonBox.Text)
                    return false;

            if (inDateBox.Text != "")
                if ((DateTime)dataGridView1["checkInDate", i].Value != DateTime.Parse(inDateBox.Text))
                    return false;

            if (outDateBox.Text != "")
                if ((DateTime)dataGridView1["checkOutDate", i].Value != DateTime.Parse(outDateBox.Text))
                    return false;

            if (VIPcheckBox.Checked)
                if (!(bool)dataGridView1["vIP", i].Value)
                    return false;

            if (NONcheckBox.Checked)
                if (!(bool)dataGridView1["nonGrata", i].Value)
                    return false;

            return true;
        }


        //---------------------------------------------------
        // Отображение всех клиентов списка.
        private void b_ВсеКлиенты_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.Rows.Count - rowAdd;

            for (int i = 0; i < count; i++)
                dataGridView1.Rows[i].Visible = true;
        }



        //---------------------------------------------------
        // Запуск Блокнота
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process p = Process.Start("NotePad.exe", "Manual\\Info.txt");
        }



        bool close = false;     // Для Form1_FormClosed: true - выход был по кнопке b_SaveClientsToFile.
        //------------------------------------------------------------------
        // Если есть тестовые записи, то предлагается их сохранить в файле.
        // Если таблица клиентов была изменена, то список сохраняется в файле.
        private void b_SaveClientsToFile_Click(object sender, EventArgs e)
        {
            close = true;

            if (Режим.mode == 2)   // Полные возможности.
            {
                if (pathCurFile != "")
                {
                    if (editList)
                    {
                        // Запомнить текущих клиентов в текущем файле.
                        if (!MySerial<List<ClientClass>>.Serialize(pathCurFile, list))
                        {
                            MessageBox.Show("Текущих клиентов в файле запомнить не удалось!\n" +
                                "Чтобы их не потерять, создайте новый файл.",
                                              "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                }
                else
                {
                    // Файла нет. Это первое сохранение.
                    MessageBox.Show("Первый запуск программы. \n\n" +
                                    "Файла для сохранения клиентов нет.\n" +
                                    "Чтобы его создать введите имя файла.",
                                    "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NewFile form = new NewFile();
                    form.form1 = this;
                    form.ShowDialog();

                    if (pathCurFile != "")
                    {


                        if (!MySerial<List<ClientClass>>.Serialize(pathCurFile, list))
                        {
                            MessageBox.Show("Текущих клиентов в файле запомнить не удалось!\n" +
                                "Чтобы их не потерять, создание нового файла отменяется.",
                                              "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Файл не выбран!\n\n" +
                              "Завершить программу без сохранения?", "Сделайте выбор.",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            return;
                    }

                }
            }
            Close();
        }


        //-------------------------------------------------------------------
        // Очистка таблицы клиентов.
        private void b_Clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите очистить таблицу клиентов?", "Внимание",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dataGridView1.Rows.Clear();
                list.Clear();
                editList = true;
                //clientClassBindingSource.ResetBindings(false);
            }
        }


        //-------------------------------------------------------------------
        // Сортировка списка по свойству, соответствующему выбранному заголовку.
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.Rows.Count > rowAdd)
            {
                switch (dataGridView1.Columns[e.ColumnIndex].Name)
                {
                    case "reserv":
                        list.Sort(delegate (ClientClass a1, ClientClass a2)
                                 { return a1.Reserv.CompareTo(a2.Reserv); });
                        break;

                    case "room":
                        list.Sort(delegate (ClientClass a1, ClientClass a2)
                                 { return a1.Room.CompareTo(a2.Room); });
                        break;
                    case "surnam":
                        list.Sort(delegate (ClientClass a1, ClientClass a2)
                                 { return a1.Surname.CompareTo(a2.Surname); });
                        break;

                    case "name":
                        list.Sort(delegate (ClientClass a1, ClientClass a2)
                                 { return a1.Name.CompareTo(a2.Name); });
                        break;

                    case "checkInDate":
                        list.Sort(delegate (ClientClass a1, ClientClass a2)
                                 { return a1.CheckInDate.CompareTo(a2.CheckInDate); });
                        break;

                    case "checkOutDate":
                        list.Sort(delegate (ClientClass a1, ClientClass a2)
                                 { return a1.CheckOutDate.CompareTo(a2.CheckOutDate); });
                        break;

                }

                clientClassBindingSource.ResetBindings(false);

            }
        }




        //-------------------------------------------------------------------
        // Отображение календаря.
        private void b_dateIn_Click(object sender, EventArgs e)
        {
            monthCalendar1.BringToFront();  // На передний план.
            monthCalendar1.Visible = true;
        }

        //--------------------------------------------------------------------
        // Выборка даты из календаря 1.
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            inDateBox.Text = monthCalendar1.SelectionStart.ToString("dd MMMM yyyy");
            inDateBox.SelectionStart = 0;
            monthCalendar1.Visible = false;
        }


        //-------------------------------------------------------------------
        // Отображение календаря.
        private void b_dateOut_Click(object sender, EventArgs e)
        {
            monthCalendar2.BringToFront();
            monthCalendar2.Visible = true;
        }

        //--------------------------------------------------------------------
        // Выборка даты из календаря 2.
        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            outDateBox.Text = monthCalendar2.SelectionStart.ToString("dd MMMM yyyy");
            outDateBox.SelectionStart = 0;
            monthCalendar2.Visible = false;
        }

 
        //-------------------------------------------------------------------
        // Очищение всех критериев отбора клиентов.
        private void CleareFind_Click(object sender, EventArgs e)
        {
            reservBox.Text = "";
            roomBox.Text = "";
            surnameBox.Text = "";
            inDateBox.Text = "";
            outDateBox.Text = "";
            telefonBox.Text = "";
            VIPcheckBox.Checked = false;
            NONcheckBox.Checked = false;
        }

        //---------------------------------------------------------------------
        // Срабатывает при любом завершении программы.
        // Отделяем завершение по системной кнопке X от Button.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close || Режим.mode == 1)  // close=true - было завершение по Button 
                e.Cancel = false;       // Закрыть форму
            else if (editList == false)
                e.Cancel = false;       // Закрыть форму
            //else if (dataGridView1.Rows.Count == 0 + rowAdd)
            //    e.Cancel = false;     // Закрыть форму
            else if (MessageBox.Show("Выйти без сохранения списка клиентов?", "Внимание",
                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;       // Закрыть форму
            else
                e.Cancel = true;        // Отменить закрытие формы

        }

        //-------------------------------------------------------------
        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Рысин Н. А.",
                "Версия " + vers, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        //---------------------------------------------------------------------------------------
        // Проверка даты отъезда по отношению к дате заезда.
        // Происходит при перемещении фокуса на другую строку.
        private void dataGridView1_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            e.Cancel = false;
            int y = e.RowIndex; 

            // Эта проверка связана с удалением последней строки не из таблицы, а из списка.
            // Получается, что последняя строка в таблице еще присутствует, но ее уже нет.
            if (dataGridView1["checkInDate", y].Value == null ||
                dataGridView1["checkOutDate", y].Value == null)
                return;


            DateTime dt1 = (DateTime)dataGridView1["checkInDate", y].Value;
            DateTime dt2 = (DateTime)dataGridView1["checkOutDate", y].Value;

            // Проверяем поля даты.
            if (dt1 > dt2)
            {
                MessageBox.Show("Дата заезда не может быть позже даты отъезда", "ОШИБКА", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }



        //---------------------------------------------------------------------------------------
        // Проверка допустимости нового значения в ячейке при перемещении фокуса на другую ячейку этой же строки.
        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            e.Cancel = false;
            //MessageBox.Show("CellValidating!");

            string valueNew = e.FormattedValue.ToString().Trim();

            string nameValue = dataGridView1.Columns[e.ColumnIndex].Name;   // Имя поля

            int vInt;
            DateTime dt;

            switch (nameValue)
            {
                case "reserv":
                    if (!int.TryParse(valueNew, out vInt))
                    {
                        MessageBox.Show("Поле \"№ брони\" должно содержать числовое значение!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    return;

                case "room":
                    if (!int.TryParse(valueNew, out vInt))
                    {
                        MessageBox.Show("Поле \"№ комнаты\" должно содержать числовое значение!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    return;

                case "surnam":
                    if (valueNew == "")
                    {
                        MessageBox.Show("Поле \"Фамилия\" не должно быть пустым!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    return;

                case "name":
                    if (valueNew == "")
                    {
                        MessageBox.Show("Поле \"Имя\" не должно быть пустым!", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    return;

                case "checkInDate":
                    if (valueNew == "" || !DateTime.TryParse(valueNew, out dt))
                    {
                        MessageBox.Show("Поле \"Дата заезда\" должно содержать дату в формате дд.мм.гггг !", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    return;

                case "checkOutDate":
                    if (valueNew == "" || !DateTime.TryParse(valueNew, out dt))
                    {
                        MessageBox.Show("Поле \"Дата выезда\" должно содержать дату в формате дд.мм.гггг !", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                    return;
            }
        }


        //--------------------------------------------------------------------------
        // Изменить цвет у VIP и NonGrata.
        // Этот обработчик вызывается при срабатывании привязки,
        // поэтому здесь обновляется закраска.
        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - rowAdd; i++)
            {
                editList = true;

                if ((bool)(dataGridView1["nonGrata", i].Value) == true)
                {
                    dataGridView1["surNam", i].Style.BackColor = Color.LightCyan;
                    dataGridView1["name", i].Style.BackColor = Color.LightCyan;
                }
                else
                {
                    dataGridView1["surNam", i].Style.BackColor = Color.White;
                    dataGridView1["name", i].Style.BackColor = Color.White;
                }


                if ((bool)(dataGridView1["vIP", i].Value) == true)
                {
                    dataGridView1["surNam", i].Style.ForeColor = Color.Maroon;
                    dataGridView1["name", i].Style.ForeColor = Color.Maroon;
                }
                else
                {
                    dataGridView1["surNam", i].Style.ForeColor = Color.Black;
                    dataGridView1["name", i].Style.ForeColor = Color.Black;
                }
            }
        }

        //--------------------------------------------------------------------------
        // Изменить цвет у VIP и NonGrata.
        // Этот обработчик вызывается при попытке изменить значение ячейки 
        // с использованием базового интерфейса сетки.
        // Раз есть попытка, значит флажок переброшен: меняем цвет.
        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "nonGrata")
            {
                if ((bool)(dataGridView1["nonGrata", e.RowIndex].Value) == false)
                {
                    dataGridView1["surNam", e.RowIndex].Style.BackColor = Color.LightCyan;
                    dataGridView1["name", e.RowIndex].Style.BackColor = Color.LightCyan;
                }
                else
                {
                    dataGridView1["surNam", e.RowIndex].Style.BackColor = Color.White;
                    dataGridView1["name", e.RowIndex].Style.BackColor = Color.White;
                }
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "vIP")
            {
                if ((bool)(dataGridView1["vIP", e.RowIndex].Value) == false)
                {
                    dataGridView1["surNam", e.RowIndex].Style.ForeColor = Color.Maroon;
                    dataGridView1["name", e.RowIndex].Style.ForeColor = Color.Maroon;
                }
                else
                {
                    dataGridView1["surNam", e.RowIndex].Style.ForeColor = Color.Black;
                    dataGridView1["name", e.RowIndex].Style.ForeColor = Color.Black;
                }
            }
        }

        //------------------------------------------------------------------------------
        // Записать выбранную дату в ячейку и убрать календарь.

        DataGridViewCell cell;
        DateTime dtCurr;

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1) return;  // Щелчок на заголовках строк или столбцов.

            cell = dataGridView1[e.ColumnIndex, e.RowIndex];

            if (cell.ValueType.ToString() == "System.DateTime")
            {
                dtCurr = (DateTime)cell.Value;
                int x = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true).Right + dataGridView1.Location.X;
                int y = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true).Y + dataGridView1.Location.Y;
                monthCalendar3.Location = new Point(x, y);

                monthCalendar3.BringToFront();  // На передний план.
                monthCalendar3.Visible = true;
                monthCalendar3.Focus();   // Иначе Leave не сработает.
                monthCalendar3.MaxSelectionCount = 1;  //или monthCalendar3.SelectionEnd = dtCurr;
            }
        }

        //--------------------------------------------------------------------
        // Выборка даты из календаря.
        private void monthCalendar3_DateSelected(object sender, DateRangeEventArgs e)
        {
            cell.Value = monthCalendar3.SelectionStart.ToString("dd.MM.yyyy");
            //inDateBox.SelectionStart = 0;
            monthCalendar3.Visible = false;
        }

        //----------------------------------------------------------
        // Потеря фокуса ввода: дата не выбрана, убираем календарь.
        private void monthCalendar3_Leave(object sender, EventArgs e)
        {
            monthCalendar3.Visible = false;
        }

        //----------------------------------------------------------
        // Отказ от выборки даты по кнопке Escape, убираем календарь.
        private void monthCalendar3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                monthCalendar3.Visible = false;
        }

        //---------------------------------------------------------------------------------
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Ошибка формата данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.ThrowException = false;
        }
    }
}
