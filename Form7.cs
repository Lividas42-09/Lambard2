using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 sistema = new Form8();
            sistema.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 sistema = new Form9();
            sistema.ShowDialog();
            this.Close();
        }

        

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tablica_Klienti sistema = new Tablica_Klienti();
            sistema.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tablica_Cena sistema = new Tablica_Cena();
            sistema.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tablica_Kategorii_tovarov sistema = new Tablica_Kategorii_tovarov();
            sistema.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tablica_Sdacha_v_lambard sistema = new Tablica_Sdacha_v_lambard();
            sistema.ShowDialog();
            this.Close();
        }
    }
}
