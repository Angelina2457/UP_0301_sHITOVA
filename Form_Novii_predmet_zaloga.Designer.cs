namespace PR_7_02._01
{
    partial class Form_Novii_predmet_zaloga
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.договорыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.составToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметЗалогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_dobavit_ghtlvtn = new System.Windows.Forms.Button();
            this.label_ID_predmeta = new System.Windows.Forms.Label();
            this.label_Predmet = new System.Windows.Forms.Label();
            this.label_Ves_predmeta = new System.Windows.Forms.Label();
            this.label_Proba_metalla = new System.Windows.Forms.Label();
            this.label_ID_klienta = new System.Windows.Forms.Label();
            this.label_ID_sostava = new System.Windows.Forms.Label();
            this.label_Tip_predmeta = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label_Status = new System.Windows.Forms.Label();
            this.button_Izmenit_predmet = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.GreenYellow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(551, 36);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.договорыToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.составToolStripMenuItem,
            this.предметЗалогаToolStripMenuItem,
            this.должностиToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.таблицыToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(93, 32);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            this.таблицыToolStripMenuItem.Click += new System.EventHandler(this.таблицыToolStripMenuItem_Click);
            // 
            // договорыToolStripMenuItem
            // 
            this.договорыToolStripMenuItem.Name = "договорыToolStripMenuItem";
            this.договорыToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.договорыToolStripMenuItem.Text = "Договоры";
            this.договорыToolStripMenuItem.Click += new System.EventHandler(this.договорыToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // составToolStripMenuItem
            // 
            this.составToolStripMenuItem.Name = "составToolStripMenuItem";
            this.составToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.составToolStripMenuItem.Text = "Состав";
            this.составToolStripMenuItem.Click += new System.EventHandler(this.составToolStripMenuItem_Click);
            // 
            // предметЗалогаToolStripMenuItem
            // 
            this.предметЗалогаToolStripMenuItem.Name = "предметЗалогаToolStripMenuItem";
            this.предметЗалогаToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.предметЗалогаToolStripMenuItem.Text = "Предмет залога";
            this.предметЗалогаToolStripMenuItem.Click += new System.EventHandler(this.предметЗалогаToolStripMenuItem_Click);
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.должностиToolStripMenuItem.Text = "Должности";
            this.должностиToolStripMenuItem.Click += new System.EventHandler(this.должностиToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(91, 32);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // button_dobavit_ghtlvtn
            // 
            this.button_dobavit_ghtlvtn.BackColor = System.Drawing.Color.GreenYellow;
            this.button_dobavit_ghtlvtn.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_dobavit_ghtlvtn.Location = new System.Drawing.Point(362, 66);
            this.button_dobavit_ghtlvtn.Name = "button_dobavit_ghtlvtn";
            this.button_dobavit_ghtlvtn.Size = new System.Drawing.Size(158, 102);
            this.button_dobavit_ghtlvtn.TabIndex = 22;
            this.button_dobavit_ghtlvtn.Text = "Добавить предмет";
            this.button_dobavit_ghtlvtn.UseVisualStyleBackColor = false;
            // 
            // label_ID_predmeta
            // 
            this.label_ID_predmeta.AutoSize = true;
            this.label_ID_predmeta.BackColor = System.Drawing.Color.LawnGreen;
            this.label_ID_predmeta.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ID_predmeta.Location = new System.Drawing.Point(12, 43);
            this.label_ID_predmeta.Name = "label_ID_predmeta";
            this.label_ID_predmeta.Size = new System.Drawing.Size(150, 26);
            this.label_ID_predmeta.TabIndex = 23;
            this.label_ID_predmeta.Text = "Номер предмета";
            // 
            // label_Predmet
            // 
            this.label_Predmet.AutoSize = true;
            this.label_Predmet.BackColor = System.Drawing.Color.LawnGreen;
            this.label_Predmet.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Predmet.Location = new System.Drawing.Point(12, 84);
            this.label_Predmet.Name = "label_Predmet";
            this.label_Predmet.Size = new System.Drawing.Size(85, 26);
            this.label_Predmet.TabIndex = 24;
            this.label_Predmet.Text = "Предмет";
            // 
            // label_Ves_predmeta
            // 
            this.label_Ves_predmeta.AutoSize = true;
            this.label_Ves_predmeta.BackColor = System.Drawing.Color.LawnGreen;
            this.label_Ves_predmeta.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Ves_predmeta.Location = new System.Drawing.Point(12, 126);
            this.label_Ves_predmeta.Name = "label_Ves_predmeta";
            this.label_Ves_predmeta.Size = new System.Drawing.Size(126, 26);
            this.label_Ves_predmeta.TabIndex = 25;
            this.label_Ves_predmeta.Text = "Вес предмета";
            // 
            // label_Proba_metalla
            // 
            this.label_Proba_metalla.AutoSize = true;
            this.label_Proba_metalla.BackColor = System.Drawing.Color.LawnGreen;
            this.label_Proba_metalla.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Proba_metalla.Location = new System.Drawing.Point(12, 212);
            this.label_Proba_metalla.Name = "label_Proba_metalla";
            this.label_Proba_metalla.Size = new System.Drawing.Size(136, 26);
            this.label_Proba_metalla.TabIndex = 26;
            this.label_Proba_metalla.Text = "Проба металла";
            // 
            // label_ID_klienta
            // 
            this.label_ID_klienta.AutoSize = true;
            this.label_ID_klienta.BackColor = System.Drawing.Color.LawnGreen;
            this.label_ID_klienta.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ID_klienta.Location = new System.Drawing.Point(12, 258);
            this.label_ID_klienta.Name = "label_ID_klienta";
            this.label_ID_klienta.Size = new System.Drawing.Size(137, 26);
            this.label_ID_klienta.TabIndex = 27;
            this.label_ID_klienta.Text = "Номер клиента";
            // 
            // label_ID_sostava
            // 
            this.label_ID_sostava.AutoSize = true;
            this.label_ID_sostava.BackColor = System.Drawing.Color.LawnGreen;
            this.label_ID_sostava.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ID_sostava.Location = new System.Drawing.Point(9, 304);
            this.label_ID_sostava.Name = "label_ID_sostava";
            this.label_ID_sostava.Size = new System.Drawing.Size(134, 26);
            this.label_ID_sostava.TabIndex = 28;
            this.label_ID_sostava.Text = "Номер состава";
            // 
            // label_Tip_predmeta
            // 
            this.label_Tip_predmeta.AutoSize = true;
            this.label_Tip_predmeta.BackColor = System.Drawing.Color.LawnGreen;
            this.label_Tip_predmeta.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Tip_predmeta.Location = new System.Drawing.Point(12, 168);
            this.label_Tip_predmeta.Name = "label_Tip_predmeta";
            this.label_Tip_predmeta.Size = new System.Drawing.Size(128, 26);
            this.label_Tip_predmeta.TabIndex = 29;
            this.label_Tip_predmeta.Text = "Тип предмета";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(203, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 30;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(203, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 31;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(203, 131);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 32;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(203, 174);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 33;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(203, 218);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 34;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(203, 264);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 35;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(203, 310);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 36;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(203, 355);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 38;
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.BackColor = System.Drawing.Color.LawnGreen;
            this.label_Status.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Status.Location = new System.Drawing.Point(9, 349);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(78, 26);
            this.label_Status.TabIndex = 37;
            this.label_Status.Text = "Статус";
            // 
            // button_Izmenit_predmet
            // 
            this.button_Izmenit_predmet.BackColor = System.Drawing.Color.GreenYellow;
            this.button_Izmenit_predmet.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Izmenit_predmet.Location = new System.Drawing.Point(362, 194);
            this.button_Izmenit_predmet.Name = "button_Izmenit_predmet";
            this.button_Izmenit_predmet.Size = new System.Drawing.Size(158, 108);
            this.button_Izmenit_predmet.TabIndex = 39;
            this.button_Izmenit_predmet.Text = "Изменить предмет";
            this.button_Izmenit_predmet.UseVisualStyleBackColor = false;
            // 
            // Form_Novii_predmet_zaloga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(551, 381);
            this.Controls.Add(this.button_Izmenit_predmet);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_Tip_predmeta);
            this.Controls.Add(this.label_ID_sostava);
            this.Controls.Add(this.label_ID_klienta);
            this.Controls.Add(this.label_Proba_metalla);
            this.Controls.Add(this.label_Ves_predmeta);
            this.Controls.Add(this.label_Predmet);
            this.Controls.Add(this.label_ID_predmeta);
            this.Controls.Add(this.button_dobavit_ghtlvtn);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form_Novii_predmet_zaloga";
            this.Text = "Добавление предмета залога";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem договорыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.Button button_dobavit_ghtlvtn;
        private System.Windows.Forms.Label label_ID_predmeta;
        private System.Windows.Forms.Label label_Predmet;
        private System.Windows.Forms.Label label_Ves_predmeta;
        private System.Windows.Forms.Label label_Proba_metalla;
        private System.Windows.Forms.Label label_ID_klienta;
        private System.Windows.Forms.Label label_ID_sostava;
        private System.Windows.Forms.Label label_Tip_predmeta;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem составToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предметЗалогаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Button button_Izmenit_predmet;
    }
}