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
    public partial class Tablica_Sdacha_v_lambard : Form
    {
        public Tablica_Sdacha_v_lambard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from Sdacha_v_lambard";
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                query += "where Sdacha_v_lambard= '" + textBox1.Text + "'";
            }
            var list = DBConnectionService.SendQueryToSqlServer(query);
            dataGridView1.Rows.Clear();
            foreach (var l in list)
            {
                dataGridView1.Rows.Add(l[0], l[1], l[2], l[3], l[4], l[5], l[6], l[7], l[8], l[9], l[10]);
            }
            dataGridView1.Refresh();
        }

        private void Tablica_Sdacha_v_lambard_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("ID_klienta", "ID_klienta");
            dataGridView1.Columns.Add("ID_tovara", "ID_tovara");
            dataGridView1.Columns.Add("Pribil", "Pribil");
            dataGridView1.Columns.Add("Opisanye_tovara", "Opisanye_tovara");
            dataGridView1.Columns.Add("Data_sdachi", "Data_sdachi");
            dataGridView1.Columns.Add("Data_prodaji", "Data_prodaji");
            dataGridView1.Columns.Add("Data_vozvrata", "Data_vozvrata");
            dataGridView1.Columns.Add("Data_nevozvrata", "Data_nevozvrata");
            dataGridView1.Columns.Add("Summa", "Summa");
            dataGridView1.Columns.Add("Komissionnie", "Komissionnie");
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
