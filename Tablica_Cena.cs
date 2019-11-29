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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ID_ceni = null;
            string ID_tovara = null;
            string Izmenenie_ceni = null;
            string Skidka = null;
            string Summa_dla_vikupa_veshei = null;
            string Data_izmenenie_ceni = null;
            try
            {
                ID_ceni = ID_cen.Text;
                ID_tovara = ID_tovar.Text;
                Izmenenie_ceni = Izmenenie_cen.Text;
                Skidka = Skidk.Text;
                Summa_dla_vikupa_veshei = Summa_dla_vikupa_veshe.Text;
                Data_izmenenie_ceni = Data_izmenenie_cen.Text;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = "INSERT INTO Cena(ID_ceni,ID_tovara,Izmenenie_ceni,Skidka,Summa_dla_vikupa_veshei,Data_izmenenie_ceni) " +
                "values(" + $"'{ID_ceni}','{ID_tovara}','{Izmenenie_ceni}','{Skidka}','{Summa_dla_vikupa_veshei}','{Data_izmenenie_ceni}'" + ")";
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("Done", "Saving object", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ID_ceni = null;
            string ID_tovara = null;
            string Izmenenie_ceni = null;
            string Skidka = null;
            string Summa_dla_vikupa_veshei = null;
            string Data_izmenenie_ceni = null;
            try
            {
                ID_ceni = ID_cen.Text;
                ID_tovara = ID_tovar.Text;
                Izmenenie_ceni = Izmenenie_cen.Text;
                Skidka = Skidk.Text;
                Summa_dla_vikupa_veshei = Summa_dla_vikupa_veshe.Text;
                Data_izmenenie_ceni = Data_izmenenie_cen.Text;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int n = 
                int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string query = "update dbo.Cena set Izmenenie_ceni = '" + Izmenenie_ceni + "', Skidka = '"+ Skidka + "', Summa_dla_vikupa_veshei = '"+ Summa_dla_vikupa_veshei + "', Data_izmenenie_ceni = '"+ Data_izmenenie_ceni + "' where ID_ceni = '"+ ID_ceni +"'";
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("Done", "Object is updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
