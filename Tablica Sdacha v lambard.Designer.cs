namespace WindowsFormsApp2
{
    partial class Tablica_Sdacha_v_lambard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ID1 = new System.Windows.Forms.TextBox();
            this.ID_klient = new System.Windows.Forms.TextBox();
            this.ID_tovar = new System.Windows.Forms.TextBox();
            this.Pribil1 = new System.Windows.Forms.TextBox();
            this.Opisanye_tovar = new System.Windows.Forms.TextBox();
            this.Data_sdach = new System.Windows.Forms.TextBox();
            this.Data_prodaj = new System.Windows.Forms.TextBox();
            this.Data_vozvrat = new System.Windows.Forms.TextBox();
            this.Data_nevozvrat = new System.Windows.Forms.TextBox();
            this.Summ = new System.Windows.Forms.TextBox();
            this.Komissionni = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(529, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 411);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Показат таблицу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "Обратно";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1179, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1179, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID_klienta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1179, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID_tovara";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1179, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pribil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1179, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Opisanye_tovara";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1179, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Data_sdachi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1179, 338);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Data_prodaji";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1179, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Data_vozvrata";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1179, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Data_nevozvrata";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1179, 453);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Summa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1179, 491);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Komissionnie";
            // 
            // ID1
            // 
            this.ID1.Location = new System.Drawing.Point(843, 94);
            this.ID1.Name = "ID1";
            this.ID1.Size = new System.Drawing.Size(301, 22);
            this.ID1.TabIndex = 15;
            // 
            // ID_klient
            // 
            this.ID_klient.Location = new System.Drawing.Point(843, 135);
            this.ID_klient.Name = "ID_klient";
            this.ID_klient.Size = new System.Drawing.Size(301, 22);
            this.ID_klient.TabIndex = 16;
            this.ID_klient.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ID_tovar
            // 
            this.ID_tovar.Location = new System.Drawing.Point(843, 175);
            this.ID_tovar.Name = "ID_tovar";
            this.ID_tovar.Size = new System.Drawing.Size(301, 22);
            this.ID_tovar.TabIndex = 17;
            // 
            // Pribil1
            // 
            this.Pribil1.Location = new System.Drawing.Point(843, 217);
            this.Pribil1.Name = "Pribil1";
            this.Pribil1.Size = new System.Drawing.Size(301, 22);
            this.Pribil1.TabIndex = 18;
            // 
            // Opisanye_tovar
            // 
            this.Opisanye_tovar.Location = new System.Drawing.Point(843, 257);
            this.Opisanye_tovar.Name = "Opisanye_tovar";
            this.Opisanye_tovar.Size = new System.Drawing.Size(301, 22);
            this.Opisanye_tovar.TabIndex = 19;
            // 
            // Data_sdach
            // 
            this.Data_sdach.Location = new System.Drawing.Point(843, 298);
            this.Data_sdach.Name = "Data_sdach";
            this.Data_sdach.Size = new System.Drawing.Size(301, 22);
            this.Data_sdach.TabIndex = 20;
            // 
            // Data_prodaj
            // 
            this.Data_prodaj.Location = new System.Drawing.Point(843, 338);
            this.Data_prodaj.Name = "Data_prodaj";
            this.Data_prodaj.Size = new System.Drawing.Size(301, 22);
            this.Data_prodaj.TabIndex = 21;
            // 
            // Data_vozvrat
            // 
            this.Data_vozvrat.Location = new System.Drawing.Point(843, 380);
            this.Data_vozvrat.Name = "Data_vozvrat";
            this.Data_vozvrat.Size = new System.Drawing.Size(301, 22);
            this.Data_vozvrat.TabIndex = 22;
            // 
            // Data_nevozvrat
            // 
            this.Data_nevozvrat.Location = new System.Drawing.Point(843, 415);
            this.Data_nevozvrat.Name = "Data_nevozvrat";
            this.Data_nevozvrat.Size = new System.Drawing.Size(301, 22);
            this.Data_nevozvrat.TabIndex = 23;
            // 
            // Summ
            // 
            this.Summ.Location = new System.Drawing.Point(843, 453);
            this.Summ.Name = "Summ";
            this.Summ.Size = new System.Drawing.Size(301, 22);
            this.Summ.TabIndex = 24;
            // 
            // Komissionni
            // 
            this.Komissionni.Location = new System.Drawing.Point(843, 491);
            this.Komissionni.Name = "Komissionni";
            this.Komissionni.Size = new System.Drawing.Size(301, 22);
            this.Komissionni.TabIndex = 25;
            this.Komissionni.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(884, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 44);
            this.button3.TabIndex = 26;
            this.button3.Text = "Добавление данных";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1113, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 44);
            this.button4.TabIndex = 27;
            this.button4.Text = "Изменение данных";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Tablica_Sdacha_v_lambard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._147200395612713356;
            this.ClientSize = new System.Drawing.Size(1352, 517);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Komissionni);
            this.Controls.Add(this.Summ);
            this.Controls.Add(this.Data_nevozvrat);
            this.Controls.Add(this.Data_vozvrat);
            this.Controls.Add(this.Data_prodaj);
            this.Controls.Add(this.Data_sdach);
            this.Controls.Add(this.Opisanye_tovar);
            this.Controls.Add(this.Pribil1);
            this.Controls.Add(this.ID_tovar);
            this.Controls.Add(this.ID_klient);
            this.Controls.Add(this.ID1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Name = "Tablica_Sdacha_v_lambard";
            this.Text = "Tablica_Sdacha_v_lambard";
            this.Load += new System.EventHandler(this.Tablica_Sdacha_v_lambard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ID1;
        private System.Windows.Forms.TextBox ID_klient;
        private System.Windows.Forms.TextBox ID_tovar;
        private System.Windows.Forms.TextBox Pribil1;
        private System.Windows.Forms.TextBox Data_sdach;
        private System.Windows.Forms.TextBox Data_prodaj;
        private System.Windows.Forms.TextBox Data_vozvrat;
        private System.Windows.Forms.TextBox Data_nevozvrat;
        private System.Windows.Forms.TextBox Summ;
        private System.Windows.Forms.TextBox Komissionni;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Opisanye_tovar;
        private System.Windows.Forms.Button button4;
    }
}