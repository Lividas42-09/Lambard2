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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 sistema = new Form8();
            sistema.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = @"SELECT distinct Klienti.ID_klienta,Klienti.Familia,Klienti.Imia,Klienti.Otchestvo,Cena.Summa_dla_vikupa_veshei
            from dbo.Klienti,dbo.Cena
            order by Klienti.ID_klienta,Cena.Summa_dla_vikupa_veshei";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            Form6.ClearAndAddColumnsDataGridView(dataGridView1, "Klienti.ID_klienta", "Klienti.Familia", "Klienti.Imia", "Klienti.Otchestvo", "Cena.Summa_dla_vikupa_veshei");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0],row[1],row[2],row[3],row[4]);
            }
        }

        private static void ClearAndAddColumnsDataGridView(DataGridView dataGridView1, string v1, string v2, string v3, string v4, string v5)
        {
            
        }
    }
}
