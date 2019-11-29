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
    public partial class Form5 : Form
    {
        public Form5()
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
            string query = @"SELECT count(Kategorii_tovarov.Nasvanie),Nasvanie
            from dbo.Kategorii_tovarov
            group by Nasvanie";
            var list = DBConnectionService.SendQueryToSqlServer(query);
            Form5.ClearAndAddColumnsDataGridView(dataGridView1, "Kategorii_tovarov.Nasvanie");
            foreach (var row in list)
            {
                dataGridView1.Rows.Add(row[0],row[1]);
            }
        }

        private static void ClearAndAddColumnsDataGridView(DataGridView dataGridView1, string v1)
        {
            
        }
    }
}
