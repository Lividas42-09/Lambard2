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
    public partial class Tablica_Kategorii_tovarov : Form
    {
        public Tablica_Kategorii_tovarov()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from Tovar";
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                query += "where Tovar= '" + textBox1.Text + "'";
            }
            var list = DBConnectionService.SendQueryToSqlServer(query);
            dataGridView1.Rows.Clear();
            foreach (var l in list)
            {
                dataGridView1.Rows.Add(l[0], l[1], l[2], l[3]);
            }
            dataGridView1.Refresh();
        }

        private void Tablica_Kategorii_tovarov_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID_kategorii", "ID_kategorii");
            dataGridView1.Columns.Add("Nevikuplenie_veshi", "Nevikuplenie_veshi");
            dataGridView1.Columns.Add("Nasvanie", "Nasvanie");
            dataGridView1.Columns.Add("Priminenie", "Priminenie");
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
