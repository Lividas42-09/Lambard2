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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 sistema = new Form8();
            sistema.ShowDialog();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = @"select Klienti.Imia,Klienti.Familia,Klienti.Otchestvo,Tovar.Srok_otkladivania_tovara_v_nedelah,Sdacha_v_Lambard.Data_prodaji,Tovar.Sostoianie_prodaji
              from dbo.Klienti, dbo.Sdacha_v_Lambard, dbo.Tovar
              where Tovar.Srok_otkladivania_tovara_v_nedelah = '1'and Tovar.Sostoianie_prodaji != 'Распродан'";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            Form2.ClearAndAddColumnsDataGridView(dataGridView1, "Familia","Imia","Otchestvo");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0],row[1],row[2],row[3],row[4],row[5]);
            }
        }

        private static void ClearAndAddColumnsDataGridView(DataGridView dataGridView1, string v1, string v2, string v3)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
