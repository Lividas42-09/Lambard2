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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = @"SELECT Tovar.Nazvanie,Tovar.Kachestvo_tovara,Sdacha_v_Lambard.Data_nevozvrata
            from dbo.Tovar,dbo.Sdacha_v_Lambard
            where Tovar.Kachestvo_tovara = 'Самый новый' and Tovar.Nazvanie = 'Телевизор х9999'";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            Form4.ClearAndAddColumnsDataGridView(dataGridView1, "Tovar.Nazvanie", "Tovar.Kachestvo_tovara", "Sdacha_v_Lambard.Data_nevozvrata");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0],row[1],row[2]);
            }
        }

        private static void ClearAndAddColumnsDataGridView(DataGridView dataGridView1, string v1, string v2, string v3)
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
