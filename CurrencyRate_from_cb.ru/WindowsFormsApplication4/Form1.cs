

using CsQuery;
using CsQuery.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

            getData();
      

        }

        public void getData()
        {
            var kots = new BindingList<Kotirovka>();
            CQ cq = CQ.CreateFromUrl("http://bcs-express.ru/kotirovki-i-grafiki");
            DataTable dt = new DataTable();
            dataGridView1.DataSource = null;
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "Cost";
            dataGridView1.Columns[2].Name = "Height";

            int rowPos = 0;
            foreach (IDomObject obj in cq.Find("li"))
            {
                try
                {
                    Kotirovka kotirovka = new Kotirovka();
                    INodeList nodes = obj.ChildNodes;
                    IDomObject node = nodes.Item(1);
                    kotirovka.name = node.LastChild.NodeValue;
                    node = nodes.Item(3);
                    kotirovka.cost = node.LastChild.NodeValue + "";
                    node = nodes.Item(5);
                    kotirovka.height = node.LastChild.NodeValue + "";
                    kots.Add(kotirovka);
                    if (!kotirovka.cost.Contains("%"))
                    dataGridView1.Rows.Add(new String[3] { kotirovka.name, kotirovka.cost, kotirovka.height });

                    if (kotirovka.height.Contains("+"))
                    {
                        dataGridView1.Rows[rowPos].Cells[2].Style.BackColor = Color.Green;
                    }
                    else if (kotirovka.height.Contains("-"))
                    {
                        dataGridView1.Rows[rowPos].Cells[2].Style.BackColor = Color.Red;

                    }
                    rowPos++;
                }
                catch (Exception e11)
                {
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kotirovkaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = dataGridView1.Rows.Count-1; i > 0; i--)
            {
                dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
            }
            getData();
        }
    }


    public class Kotirovka
    {
        public String name;
        public String cost;
        public String height; 
    }
}
