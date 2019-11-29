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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = @"SELECT Sdacha_v_Lambard.Data_nevozvrata,Tovar.Sostoianie_prodaji,SUM (Summa)
             from dbo.Sdacha_v_Lambard,dbo.Tovar
             where Tovar.Sostoianie_prodaji != 'Распродан' and Sdacha_v_Lambard.Data_nevozvrata < '2007-05-01'
             group by Sdacha_v_Lambard.Data_nevozvrata,Tovar.Sostoianie_prodaji";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            Form3.ClearAndAddColumnsDataGridView(dataGridView1, "Sdacha_v_Lambard.Data_nevozvrata", "Tovar.Sostoianie_prodaji", "Summa");
                foreach (var row in list)
                {
                 dataGridView1.Rows.Add(row[0],row[1],row[2]);
                }
        }

        private static void ClearAndAddColumnsDataGridView(DataGridView dataGridView1, string v1, string v2, string v3 )
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 sistema = new Form8();
            sistema.ShowDialog();
            this.Close();
        }
    }
}
