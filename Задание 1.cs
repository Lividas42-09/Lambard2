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
    public partial class Задание_1 : Form
    {
        public Задание_1()
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

        private void button1_Click(object sender, EventArgs e)
        {
            string query = @"SELECT Klienti.ID_klienta, Klienti.Familia,Klienti.Imia,Klienti.Otchestvo,Klienti.Nomer_pasporta,Klienti.Ceria_pasporta,Sdacha_v_Lambard.Data_sdachi,Tovar.Nazvanie,Tovar.ID_kategorii FROM dbo.Klienti,dbo.Sdacha_v_Lambard,dbo.Tovar where Tovar.Nazvanie = 'Холодильник' and (Sdacha_v_Lambard.Data_sdachi between '2005-10-04' and '2007-09-19') and Klienti.ID_klienta = '9' and Tovar.ID_kategorii = '19'";             
            var list = DBConnectionService.SendQueryToSqlServer(query);
            Задание_1.ClearAndAddColumnsDataGridView(dataGridView1,"ID_klienta","Familia","Imia", "Otchestvo", "Nomer_pasporta", "Ceria_pasporta", "Data_sdachi", "Nazvanie", "ID_kategorii");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0],row[1],row[2],row[3],row[4],row[5],row[6],row[7],row[8]);
            }
        }

        private static void ClearAndAddColumnsDataGridView(DataGridView dataGridView1, string v1,string v2,string v3, string v4, string v5, string v6, string v7, string v8, string v9)
        {
           

        }
    }
}
