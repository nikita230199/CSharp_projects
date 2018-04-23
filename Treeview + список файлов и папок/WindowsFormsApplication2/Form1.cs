using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Создание класса для вывода окна выбора директории
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            //Выводим диалоговое окно для выбора директории.
            // Данный класс возвращает следующие значения:
            // 1) Объект System.Windows.Forms.DialogResult.OK, 
            //    если пользователь нажимает кнопку 
            //    ОК в диалоговом окне;
            // 2) Объект System.Windows.Forms.DialogResult.Cancel,  
            //    если пользователь закрывает диалоговое окно.
            DialogResult result = fbd.ShowDialog();

            //Если пользователь выбрал директорию
            //и нажал ОК, то запускаем процесс сканирования
            if (result == DialogResult.OK)
            {
                //Вызов метода сканирования с
                //передачей в качестве параметра, пути к  
                //выбранной директории 
                InitFolders(fbd.SelectedPath);
            }
        }
        private void InitFolders(string path)
        {
            //Отключаем любую перерисовку
            //иерархического представления.
            treeView1.BeginUpdate();

            //Инициализируем новую переменную предоставляющую методы экземпляра
            //класса для создания, перемещения и перечисления
            //в каталогах и подкаталогах.
            System.IO.DirectoryInfo di;
            try
            {
                //Вызываем метод GetDirectories с передачей в качестве параметра, пути к 
                //выбранной директории. Данный метод возвращает
                //массив имен подкаталогов.
                string[] root = System.IO.Directory.GetDirectories(path);

                if (root.Rank > 1)
                {
                    //Проходим по всем полученным подкаталогам.
                    foreach (string s in root)
                    {
                        try
                        {
                            //Заносим в переменную информацию
                            //о текущей директории.
                            di = new System.IO.DirectoryInfo(s);
                            //Вызов метода сканирования с
                            //передачей в качестве параметра, информации
                            //о текущей директории и объект 
                            //System.Windows.Forms.TreeNodeCollection,
                            //который предоставляет узлы
                            //дерева, назначенные элементу управления 
                            //иерархического представления.
                            BuildTree(di, treeView1.Nodes);
                        }
                        catch { }
                    }
                }
                else
                {
                    di = new System.IO.DirectoryInfo(path);
                    BuildTree(di, treeView1.Nodes);
                }
            }
            catch { }
            //Разрешаем перерисовку иерархического представления.
            treeView1.EndUpdate();
        }
        //Процесс получения папок и файлов
        private void BuildTree(System.IO.DirectoryInfo directoryInfo, TreeNodeCollection addInMe)
        {
            //Добавляем новый узел в коллекцию Nodes
            //с именем текущей директории и указанием ключа 
            //со значением "Folder".
            TreeNode curNode = addInMe.Add("Folder", directoryInfo.Name);

            //addInMe.Add(directoryInfo.FullName, directoryInfo.Name, 
            //тут можно указать номер картинки для узла из imageCollection);

            //Перебираем папки.
            foreach (System.IO.DirectoryInfo subdir in directoryInfo.GetDirectories())
            {
                //Запускам процесс получения папок и фалов 
                //с текущей найденной директории.
                BuildTree(subdir, curNode.Nodes);
            }

            //Перебираем файлы
            foreach (System.IO.FileInfo file in directoryInfo.GetFiles())
            {
                //Добавляем новый узел в коллекцию Nodes
                //С именем текущей директории и указанием ключа 
                //со значением "File".
                curNode.Nodes.Add("File", file.Name);

                //curNode.Nodes.Add("File", file.Name, 
                //тут можно указать номер картинки для узла из imageCollection);  
            }
        }
    }
}
