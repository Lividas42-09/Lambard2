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
    public partial class Tablica_Cena : Form
    {
        public Tablica_Cena()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from Cena";
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                query += "where Cena= '" + textBox1.Text + "'";
            }
            var list = DBConnectionService.SendQueryToSqlServer(query);
            dataGridView1.Rows.Clear();
            foreach (var l in list)
            {
                dataGridView1.Rows.Add(l[0], l[1], l[2], l[3], l[4], l[5]);
            }
            dataGridView1.Refresh();
        }

        private void Tablica_Cena_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID_ceni", "ID_ceni");
            dataGridView1.Columns.Add("ID_tovara", "ID_tovara");
            dataGridView1.Columns.Add("Izmenenie_ceni", "Izmenenie_ceni");
            dataGridView1.Columns.Add("Skidka", "Skidka");
            dataGridView1.Columns.Add("Summa_dla_vikupa_veshei", "Summa_dla_vikupa_veshei");
            dataGridView1.Columns.Add("Data_izmenenie_ceni", "Data_izmenenie_ceni");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 sistema = new Form7();
            sistema.ShowDialog();
            this.Close();
        }
    }
}
