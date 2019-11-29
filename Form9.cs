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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from Tovar";
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                query += "where Tovar= '" + textBox1.Text + "'";
            }
            var list = DBConnectionService.SendQueryToSqlServer(query);
            dataGridView1.Rows.Clear();
            foreach (var l in list)
            {
                dataGridView1.Rows.Add(l[0], l[1], l[2], l[3], l[4], l[5], l[6], l[7]);
            }
            dataGridView1.Refresh();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID_tovara", "ID_tovara");
            dataGridView1.Columns.Add("ID_kategorii", "ID_kategorii");
            dataGridView1.Columns.Add("Nazvanie", "Nazvanie");
            dataGridView1.Columns.Add("Opisanie", "Opisanie");
            dataGridView1.Columns.Add("Srok_eksplotacii", "Srok_eksplotacii");
            dataGridView1.Columns.Add("Sostoianie_prodaji", "Sostoianie_prodaji");
            dataGridView1.Columns.Add("Kachestvo_tovara", "Kachestvo_tovara");
            dataGridView1.Columns.Add("Srok_otkladivania_tovara_v_nedelah", "Srok_otkladivania_tovara_v_nedelah");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 sistema = new Form7();
            sistema.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ID_tovara = null;
            string ID_kategorii = null;
            string Nazvanie = null;
            string Opisanie = null;
            string Srok_eksplotacii = null;
            string Sostoianie_prodaji = null;
            string Kachestvo_tovara = null;
            string Srok_otkladivania_tovara_v_nedelah = null;
            try
            {
                ID_tovara = ID_tovar.Text;
                ID_kategorii = ID_kategori.Text;
                Nazvanie = Nazvani.Text;
                Opisanie = Opisani.Text;
                Srok_eksplotacii = Srok_eksplotaci.Text;
                Sostoianie_prodaji = Sostoianie_prodaj.Text;
                Kachestvo_tovara = Kachestvo_tovar.Text;
                Srok_otkladivania_tovara_v_nedelah = Srok_otkladivania_tovara_v_nedela.Text;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = "INSERT INTO Tovar(ID_tovara,ID_kategorii,Nazvanie,Opisanie,Srok_eksplotacii,Sostoianie_prodaji,Kachestvo_tovara,Srok_otkladivania_tovara_v_nedelah) " +
                "values(" + $"'{ID_tovara}','{ID_kategorii}','{Nazvanie}','{Opisanie}','{Srok_eksplotacii}','{Sostoianie_prodaji}','{Kachestvo_tovara}','{Srok_otkladivania_tovara_v_nedelah}'" + ")";
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("Done", "Saving object", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
