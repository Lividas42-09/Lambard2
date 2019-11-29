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
    public partial class Tablica_Kategorii_tovarov : Form
    {
        public Tablica_Kategorii_tovarov()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from Kategorii_tovarov";
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                query += "where Kategorii_tovarov= '" + textBox1.Text + "'";
            }
            var list = DBConnectionService.SendQueryToSqlServer(query);
            dataGridView1.Rows.Clear();
            foreach (var l in list)
            {
                dataGridView1.Rows.Add(l[0], l[1], l[2], l[3]);
            }
            dataGridView1.Refresh();
        }

        private void Tablica_Kategorii_tovarov_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID_kategorii", "ID_kategorii");
            dataGridView1.Columns.Add("Nevikuplenie_veshi", "Nevikuplenie_veshi");
            dataGridView1.Columns.Add("Nasvanie", "Nasvanie");
            dataGridView1.Columns.Add("Priminenie", "Priminenie");
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
            string ID_kategorii = null;
            string Nevikuplenie_veshi = null;
            string Nasvanie = null;
            string Priminenie = null;
            try
            {
                ID_kategorii = ID.Text;
                Nevikuplenie_veshi = Nevikuplenie_vesh.Text;
                Nasvanie = Nazvanie.Text;
                Priminenie = Primineni.Text;
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string query = "INSERT INTO Kategorii_tovarov(ID_kategorii,Nevikuplenie_veshi,Nasvanie,Priminenie) " +
                "values(" + $"'{ID_kategorii}','{Nevikuplenie_veshi}','{Nasvanie}','{Priminenie}'" + ")";
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if(result != null && result > 0)
            {
                MessageBox.Show("Done", "Saving object", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string ID_kategorii = null;
            string Nevikuplenie_veshi = null;
            string Nasvanie = null;
            string Priminenie = null;
            try
            {
                ID_kategorii = ID.Text;
                Nevikuplenie_veshi = Nevikuplenie_vesh.Text;
                Nasvanie = Nazvanie.Text;
                Priminenie = Primineni.Text;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int n =
                int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            string query = " update dbo.Kategorii_tovarov set Nasvanie = '"+ Nasvanie +"',Nevikuplenie_veshi = '"+ Nevikuplenie_veshi +"', Priminenie = '"+ Priminenie +"' where ID_kategorii = '"+ ID_kategorii +"'";
            int? result = DBConnectionService.SendCommandToSqlServer(query);
            if (result != null && result > 0)
            {
                MessageBox.Show("Done", "Object is updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }
    }
}
