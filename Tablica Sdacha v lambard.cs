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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ID = null;
            string ID_klienta = null;
            string ID_tovara = null;
            string Pribil = null;
            string Opisanye_tovara = null;
            string Data_sdachi = null;
            string Data_prodaji = null;
            string Data_vozvrata = null;
            string Data_nevozvrata = null;
            string Summa = null;
            string Komissionnie = null;
            try
            {
                ID = ID1.Text;
                ID_klienta = ID_klient.Text;
                ID_tovara = ID_tovar.Text;
                Pribil = Pribil1.Text;
                Opisanye_tovara = Opisanye_tovar.Text;
                Data_sdachi = Data_sdach.Text;
                Data_prodaji = Data_prodaj.Text;
                Data_vozvrata = Data_vozvrat.Text;
                Data_nevozvrata = Data_nevozvrat.Text;
                Summa = Summ.Text;
                Komissionnie = Komissionni.Text;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = "INSERT INTO Sdacha_v_lambard(ID,ID_klienta,ID_tovara,Pribil,Opisanye_tovara,Data_sdachi,Data_prodaji,Data_vozvrata,Data_nevozvrata,Summa,Komissionnie) " +
                "values(" + $"'{ID}','{ID_klienta}','{ID_tovara}','{Pribil}','{Opisanye_tovara}','{Data_sdachi}','{Data_prodaji}','{Data_vozvrata}','{Data_nevozvrata}','{Summa}','{Komissionnie}'" + ")";
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("Done", "Saving object", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ID = null;
            string ID_klienta = null;
            string ID_tovara = null;
            string Pribil = null;
            string Opisanye_tovara = null;
            string Data_sdachi = null;
            string Data_prodaji = null;
            string Data_vozvrata = null;
            string Data_nevozvrata = null;
            string Summa = null;
            string Komissionnie = null;
            try
            {
                ID = ID1.Text;
                ID_klienta = ID_klient.Text;
                ID_tovara = ID_tovar.Text;
                Pribil = Pribil1.Text;
                Opisanye_tovara = Opisanye_tovar.Text;
                Data_sdachi = Data_sdach.Text;
                Data_prodaji = Data_prodaj.Text;
                Data_vozvrata = Data_vozvrat.Text;
                Data_nevozvrata = Data_nevozvrat.Text;
                Summa = Summ.Text;
                Komissionnie = Komissionni.Text;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int n =
                int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string query = "update dbo.Sdacha_v_lambard Pribil = '" + Pribil + "', Opisanye_tovara = '" + Opisanye_tovara + "', Data_sdachi = '" + Data_sdachi + "', Data_prodaji = '" + Data_prodaji + "', Data_vozvrata = '" + Data_vozvrata + "', Data_nevozvrata = '" + Data_nevozvrata + "', Summa = '" + Summa + "', Komissionnie = '" + Komissionnie + "', where ID = '"+ ID +"'";
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("Done", "Object is updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
