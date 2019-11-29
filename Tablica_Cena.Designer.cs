namespace WindowsFormsApp2
{
    partial class Tablica_Cena
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ID_cen = new System.Windows.Forms.TextBox();
            this.ID_tovar = new System.Windows.Forms.TextBox();
            this.Izmenenie_cen = new System.Windows.Forms.TextBox();
            this.Skidk = new System.Windows.Forms.TextBox();
            this.Summa_dla_vikupa_veshe = new System.Windows.Forms.TextBox();
            this.Data_izmenenie_cen = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Показать таблицу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 363);
            this.dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(496, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Обратно";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(870, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 46);
            this.button3.TabIndex = 4;
            this.button3.Text = "Добавление данных";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1116, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID_ceni";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1116, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID_tovara";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1116, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Izmenenie_ceni";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1116, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Skidka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1116, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Summa_dla_vikupa_veshei";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1116, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data_izmenenie_ceni";
            // 
            // ID_cen
            // 
            this.ID_cen.Location = new System.Drawing.Point(825, 75);
            this.ID_cen.Name = "ID_cen";
            this.ID_cen.Size = new System.Drawing.Size(254, 22);
            this.ID_cen.TabIndex = 11;
            // 
            // ID_tovar
            // 
            this.ID_tovar.Location = new System.Drawing.Point(825, 115);
            this.ID_tovar.Name = "ID_tovar";
            this.ID_tovar.Size = new System.Drawing.Size(254, 22);
            this.ID_tovar.TabIndex = 12;
            // 
            // Izmenenie_cen
            // 
            this.Izmenenie_cen.Location = new System.Drawing.Point(825, 155);
            this.Izmenenie_cen.Name = "Izmenenie_cen";
            this.Izmenenie_cen.Size = new System.Drawing.Size(254, 22);
            this.Izmenenie_cen.TabIndex = 13;
            this.Izmenenie_cen.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Skidk
            // 
            this.Skidk.Location = new System.Drawing.Point(825, 194);
            this.Skidk.Name = "Skidk";
            this.Skidk.Size = new System.Drawing.Size(254, 22);
            this.Skidk.TabIndex = 14;
            // 
            // Summa_dla_vikupa_veshe
            // 
            this.Summa_dla_vikupa_veshe.Location = new System.Drawing.Point(825, 229);
            this.Summa_dla_vikupa_veshe.Name = "Summa_dla_vikupa_veshe";
            this.Summa_dla_vikupa_veshe.Size = new System.Drawing.Size(254, 22);
            this.Summa_dla_vikupa_veshe.TabIndex = 15;
            // 
            // Data_izmenenie_cen
            // 
            this.Data_izmenenie_cen.Location = new System.Drawing.Point(825, 268);
            this.Data_izmenenie_cen.Name = "Data_izmenenie_cen";
            this.Data_izmenenie_cen.Size = new System.Drawing.Size(254, 22);
            this.Data_izmenenie_cen.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1109, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 46);
            this.button4.TabIndex = 17;
            this.button4.Text = "Изменение данных";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Tablica_Cena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.images__1_;
            this.ClientSize = new System.Drawing.Size(1315, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Data_izmenenie_cen);
            this.Controls.Add(this.Summa_dla_vikupa_veshe);
            this.Controls.Add(this.Skidk);
            this.Controls.Add(this.Izmenenie_cen);
            this.Controls.Add(this.ID_tovar);
            this.Controls.Add(this.ID_cen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Tablica_Cena";
            this.Text = "Tablica_Cena";
            this.Load += new System.EventHandler(this.Tablica_Cena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ID_cen;
        private System.Windows.Forms.TextBox ID_tovar;
        private System.Windows.Forms.TextBox Izmenenie_cen;
        private System.Windows.Forms.TextBox Skidk;
        private System.Windows.Forms.TextBox Summa_dla_vikupa_veshe;
        private System.Windows.Forms.TextBox Data_izmenenie_cen;
        private System.Windows.Forms.Button button4;
    }
}