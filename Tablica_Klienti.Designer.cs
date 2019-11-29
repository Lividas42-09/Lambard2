namespace WindowsFormsApp2
{
    partial class Tablica_Klienti
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.lambardDataSet = new WindowsFormsApp2.LambardDataSet();
            this.klientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientiTableAdapter = new WindowsFormsApp2.LambardDataSetTableAdapters.KlientiTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ID_klient = new System.Windows.Forms.TextBox();
            this.Famili = new System.Windows.Forms.TextBox();
            this.Imi = new System.Windows.Forms.TextBox();
            this.Otchestv = new System.Windows.Forms.TextBox();
            this.Nomer_pasport = new System.Windows.Forms.TextBox();
            this.Ceria_pasport = new System.Windows.Forms.TextBox();
            this.Data_sdach = new System.Windows.Forms.TextBox();
            this.Data_vidachi_pasport = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lambardDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Показать таблицу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lambardDataSet
            // 
            this.lambardDataSet.DataSetName = "LambardDataSet";
            this.lambardDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klientiBindingSource
            // 
            this.klientiBindingSource.DataMember = "Klienti";
            this.klientiBindingSource.DataSource = this.lambardDataSet;
            // 
            // klientiTableAdapter
            // 
            this.klientiTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(487, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 345);
            this.dataGridView1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Обратно";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1140, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID_klienta";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(891, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 53);
            this.button3.TabIndex = 6;
            this.button3.Text = "Добавление данных";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1140, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Familia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1140, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Imia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1140, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Otchestvo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1140, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nomer_pasporta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1140, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ceria_pasporta";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1140, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Data_sdachi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1140, 373);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Data_vidachi_pasporta";
            // 
            // ID_klient
            // 
            this.ID_klient.Location = new System.Drawing.Point(835, 93);
            this.ID_klient.Name = "ID_klient";
            this.ID_klient.Size = new System.Drawing.Size(265, 22);
            this.ID_klient.TabIndex = 14;
            // 
            // Famili
            // 
            this.Famili.Location = new System.Drawing.Point(835, 132);
            this.Famili.Name = "Famili";
            this.Famili.Size = new System.Drawing.Size(265, 22);
            this.Famili.TabIndex = 15;
            // 
            // Imi
            // 
            this.Imi.Location = new System.Drawing.Point(835, 173);
            this.Imi.Name = "Imi";
            this.Imi.Size = new System.Drawing.Size(265, 22);
            this.Imi.TabIndex = 16;
            // 
            // Otchestv
            // 
            this.Otchestv.Location = new System.Drawing.Point(835, 214);
            this.Otchestv.Name = "Otchestv";
            this.Otchestv.Size = new System.Drawing.Size(265, 22);
            this.Otchestv.TabIndex = 17;
            // 
            // Nomer_pasport
            // 
            this.Nomer_pasport.Location = new System.Drawing.Point(835, 257);
            this.Nomer_pasport.Name = "Nomer_pasport";
            this.Nomer_pasport.Size = new System.Drawing.Size(265, 22);
            this.Nomer_pasport.TabIndex = 18;
            // 
            // Ceria_pasport
            // 
            this.Ceria_pasport.Location = new System.Drawing.Point(835, 296);
            this.Ceria_pasport.Name = "Ceria_pasport";
            this.Ceria_pasport.Size = new System.Drawing.Size(265, 22);
            this.Ceria_pasport.TabIndex = 19;
            // 
            // Data_sdach
            // 
            this.Data_sdach.Location = new System.Drawing.Point(835, 335);
            this.Data_sdach.Name = "Data_sdach";
            this.Data_sdach.Size = new System.Drawing.Size(265, 22);
            this.Data_sdach.TabIndex = 20;
            // 
            // Data_vidachi_pasport
            // 
            this.Data_vidachi_pasport.Location = new System.Drawing.Point(835, 373);
            this.Data_vidachi_pasport.Name = "Data_vidachi_pasport";
            this.Data_vidachi_pasport.Size = new System.Drawing.Size(265, 22);
            this.Data_vidachi_pasport.TabIndex = 21;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1102, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 53);
            this.button4.TabIndex = 22;
            this.button4.Text = "Изменение данных";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Tablica_Klienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources._39097_anime_teatralnye_dekoracii_priroda_dnevnoe_vremya_spokojnyj_x750;
            this.ClientSize = new System.Drawing.Size(1326, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Data_vidachi_pasport);
            this.Controls.Add(this.Data_sdach);
            this.Controls.Add(this.Ceria_pasport);
            this.Controls.Add(this.Nomer_pasport);
            this.Controls.Add(this.Otchestv);
            this.Controls.Add(this.Imi);
            this.Controls.Add(this.Famili);
            this.Controls.Add(this.ID_klient);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Tablica_Klienti";
            this.Text = "Tablica_Klienti";
            this.Load += new System.EventHandler(this.Tablica_Klienti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lambardDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private LambardDataSet lambardDataSet;
        private System.Windows.Forms.BindingSource klientiBindingSource;
        private LambardDataSetTableAdapters.KlientiTableAdapter klientiTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ID_klient;
        private System.Windows.Forms.TextBox Famili;
        private System.Windows.Forms.TextBox Imi;
        private System.Windows.Forms.TextBox Otchestv;
        private System.Windows.Forms.TextBox Nomer_pasport;
        private System.Windows.Forms.TextBox Ceria_pasport;
        private System.Windows.Forms.TextBox Data_sdach;
        private System.Windows.Forms.TextBox Data_vidachi_pasport;
        private System.Windows.Forms.Button button4;
    }
}