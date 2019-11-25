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
    public partial class Tablica_Klienti : Form
    {
        public Tablica_Klienti()
        {
            InitializeComponent();
        }

        private void Tablica_Klienti_Load(object sender, EventArgs e)
        {

            dataGridView1.Columns.Add("ID_klienta", "ID_klienta");
            dataGridView1.Columns.Add("Familia", "Familia");
            dataGridView1.Columns.Add("Imia", "Imia");
            dataGridView1.Columns.Add("Otchestvo", "Otchestvo");
            dataGridView1.Columns.Add("Nomer_pasporta", "Nomer_pasporta");
            dataGridView1.Columns.Add("Ceria_pasporta", "Ceria_pasporta");
            dataGridView1.Columns.Add("Data_sdachi", "Data_sdachi");
            dataGridView1.Columns.Add("Data_vidachi_pasporta", "Data_vidachi_pasporta");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from Klienti";
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                query += "where Klienti= '" + textBox1.Text + "'";
            }
            var list =DBConnectionService.SendQueryToSqlServer(query);
            dataGridView1.Rows.Clear();
            foreach (var l in list)
            {
                dataGridView1.Rows.Add(l[0], l[1], l[2], l[3], l[4], l[5], l[6], l[7]);
            }
            dataGridView1.Refresh();
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
