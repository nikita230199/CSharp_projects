using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TreeViewЦиклыОтбор
{
    public partial class Form1 : Form
    {

        List<Auto> list;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list = new List<Auto> 
            {
                new Auto("Мерседес С200",   "Купе",      "Автомат",  "Черный"),
                new Auto("Мерседес С200",   "Седан",     "Вариатор", "Белый"),
                new Auto("Мерседес С200",   "Седан",     "Автомат",  "Красный"),
                new Auto("Ауди А6",         "Купе",      "Автомат",  "Белый"),
                new Auto("Ауди А6",         "Седан",     "Автомат",  "Черный"),
                new Auto("Ауди А6",         "Универсал", "Автомат",  "Белый"),
                new Auto("Ауди А6",         "Купе",      "Ручная",   "Черный"),
                new Auto("Тойота Камри",    "Седан",     "Автомат",  "Черный"),
                new Auto("Тойота Камри",    "Купе",      "Ручная",   "Белый"),
                new Auto("Тойота Камри",    "Седан",     "Вариатор", "Красный"),
                new Auto("Мерседес С200",   "Универсал", "Ручная",   "Черный"),
                new Auto("Мерседес С200",   "Седан",     "Ручная",   "Белый"),
            };

            autoBindingSource.DataSource = list;


            string модель1 = "", форма1 = "";

            var марка = (from auto in list
                         select auto.Марка).Distinct();

            var кузов = (from auto in list
                         where auto.Марка == модель1
                         select auto.Кузов).Distinct();

            var коробка = (from auto in list
                           where auto.Марка == модель1 && auto.Кузов == форма1
                           select auto.Коробка).Distinct();


            treeView1.BeginUpdate();

            TreeNode узел0 = new TreeNode("Все марки");
            treeView1.Nodes.Add(узел0);

            foreach (var модель in марка)
            {
                узел0 = new TreeNode(модель);

                модель1 = модель;
                foreach (var форма in кузов) 
                {
                    TreeNode узел1 = new TreeNode(форма);

                    форма1 = форма;
                    foreach (var кпп in коробка) 
                    {
                        узел1.Nodes.Add(кпп);     
                    }
                    узел0.Nodes.Add(узел1);     
                }
                treeView1.Nodes.Add(узел0);     // Добавить в дерево узел вместе с дочерними
            }

            treeView1.EndUpdate();
     

        }



        //---------------------------------------------------------------------
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string[] критерии = e.Node.FullPath.Split('\\');


            List<Auto> list2 = new List<Auto>();

            if (критерии[0] == "Все марки")
            {
                autoBindingSource.DataSource = list;
                return;
            }


            if (критерии.Length == 1)
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Марка == критерии[0])
                        list2.Add(list[i]);
                }
             else if (критерии.Length == 2)
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Марка == критерии[0] && list[i].Кузов == критерии[1]) 
                        list2.Add(list[i]);
                }

            else if (критерии.Length == 3)
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Марка == критерии[0] && list[i].Кузов == критерии[1] && list[i].Коробка == критерии[2])
                        list2.Add(list[i]);
                }

            autoBindingSource.DataSource = list2;

        }
    }
}
