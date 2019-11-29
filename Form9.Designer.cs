namespace WindowsFormsApp2
{
    partial class Form9
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ID_tovar = new System.Windows.Forms.TextBox();
            this.ID_kategori = new System.Windows.Forms.TextBox();
            this.Nazvani = new System.Windows.Forms.TextBox();
            this.Opisani = new System.Windows.Forms.TextBox();
            this.Srok_eksplotaci = new System.Windows.Forms.TextBox();
            this.Sostoianie_prodaj = new System.Windows.Forms.TextBox();
            this.Kachestvo_tovar = new System.Windows.Forms.TextBox();
            this.Srok_otkladivania_tovara_v_nedela = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 198);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(699, 341);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 117);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Показать таблицу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(438, 123);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Обратно";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1014, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID_tovara";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1014, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID_kategorii";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1014, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nazvanie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1014, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Opisanie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1014, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Srok_eksplotacii";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1014, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Sostoianie_prodaji";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1014, 436);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Kachestvo_tovara";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1014, 475);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(242, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Srok_otkladivania_tovara_v_nedelah";
            // 
            // ID_tovar
            // 
            this.ID_tovar.Location = new System.Drawing.Point(762, 198);
            this.ID_tovar.Name = "ID_tovar";
            this.ID_tovar.Size = new System.Drawing.Size(237, 22);
            this.ID_tovar.TabIndex = 13;
            // 
            // ID_kategori
            // 
            this.ID_kategori.Location = new System.Drawing.Point(762, 233);
            this.ID_kategori.Name = "ID_kategori";
            this.ID_kategori.Size = new System.Drawing.Size(237, 22);
            this.ID_kategori.TabIndex = 14;
            // 
            // Nazvani
            // 
            this.Nazvani.Location = new System.Drawing.Point(762, 273);
            this.Nazvani.Name = "Nazvani";
            this.Nazvani.Size = new System.Drawing.Size(237, 22);
            this.Nazvani.TabIndex = 15;
            // 
            // Opisani
            // 
            this.Opisani.Location = new System.Drawing.Point(762, 312);
            this.Opisani.Name = "Opisani";
            this.Opisani.Size = new System.Drawing.Size(237, 22);
            this.Opisani.TabIndex = 16;
            // 
            // Srok_eksplotaci
            // 
            this.Srok_eksplotaci.Location = new System.Drawing.Point(762, 351);
            this.Srok_eksplotaci.Name = "Srok_eksplotaci";
            this.Srok_eksplotaci.Size = new System.Drawing.Size(237, 22);
            this.Srok_eksplotaci.TabIndex = 17;
            // 
            // Sostoianie_prodaj
            // 
            this.Sostoianie_prodaj.Location = new System.Drawing.Point(762, 391);
            this.Sostoianie_prodaj.Name = "Sostoianie_prodaj";
            this.Sostoianie_prodaj.Size = new System.Drawing.Size(237, 22);
            this.Sostoianie_prodaj.TabIndex = 18;
            // 
            // Kachestvo_tovar
            // 
            this.Kachestvo_tovar.Location = new System.Drawing.Point(762, 431);
            this.Kachestvo_tovar.Name = "Kachestvo_tovar";
            this.Kachestvo_tovar.Size = new System.Drawing.Size(237, 22);
            this.Kachestvo_tovar.TabIndex = 19;
            // 
            // Srok_otkladivania_tovara_v_nedela
            // 
            this.Srok_otkladivania_tovara_v_nedela.Location = new System.Drawing.Point(762, 470);
            this.Srok_otkladivania_tovara_v_nedela.Name = "Srok_otkladivania_tovara_v_nedela";
            this.Srok_otkladivania_tovara_v_nedela.Size = new System.Drawing.Size(237, 22);
            this.Srok_otkladivania_tovara_v_nedela.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(697, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 44);
            this.button3.TabIndex = 21;
            this.button3.Text = "Добавление данных";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(962, 117);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 43);
            this.button4.TabIndex = 22;
            this.button4.Text = "Изменение данных";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1238, 196);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 24);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1251, 118);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(152, 43);
            this.button5.TabIndex = 24;
            this.button5.Text = "Удаление данных";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1432, 132);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 25;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._57994cd5bb15dcfa44f7657fc90d8473;
            this.ClientSize = new System.Drawing.Size(1586, 554);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Srok_otkladivania_tovara_v_nedela);
            this.Controls.Add(this.Kachestvo_tovar);
            this.Controls.Add(this.Sostoianie_prodaj);
            this.Controls.Add(this.Srok_eksplotaci);
            this.Controls.Add(this.Opisani);
            this.Controls.Add(this.Nazvani);
            this.Controls.Add(this.ID_kategori);
            this.Controls.Add(this.ID_tovar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form9";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ID_tovar;
        private System.Windows.Forms.TextBox ID_kategori;
        private System.Windows.Forms.TextBox Nazvani;
        private System.Windows.Forms.TextBox Opisani;
        private System.Windows.Forms.TextBox Srok_eksplotaci;
        private System.Windows.Forms.TextBox Sostoianie_prodaj;
        private System.Windows.Forms.TextBox Kachestvo_tovar;
        private System.Windows.Forms.TextBox Srok_otkladivania_tovara_v_nedela;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}