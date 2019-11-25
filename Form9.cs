using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp2.Class1;

namespace WindowsFormsApp2
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from Товар";
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                query += "where Товар= '" + textBox1.Text + "'";
            }
            var list = DBConnectionService.SendQueryToSqlServer(query);
            dataGridView1.Rows.Clear();
            foreach (var l in list)
            {
                dataGridView1.Rows.Add(l[0], l[1], l[2], l[3], l[4], l[5]);
            }
            dataGridView1.Refresh();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID_товара1", "ID");
            dataGridView1.Columns.Add("ID_категории", "ID категории");
            dataGridView1.Columns.Add("Описание_товара", "Описание");
            dataGridView1.Columns.Add("Состояние_товара", "Состояние");
            dataGridView1.Columns.Add("Название", "Название ");
            dataGridView1.Columns.Add("Срок_откладывание_товара", "Откладывание");
        }
    }
}
