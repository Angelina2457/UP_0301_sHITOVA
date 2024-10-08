using System;

namespace PR_7_02._01
{
    partial class Form_Novii_sotrudnik
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
            this.button_dobavit_sotrudnika = new System.Windows.Forms.Button();
            this.label_ID_sotr = new System.Windows.Forms.Label();
            this.tb_id_sotr = new System.Windows.Forms.TextBox();
            this.label_Familia = new System.Windows.Forms.Label();
            this.label_Imya = new System.Windows.Forms.Label();
            this.label_Otchestvo = new System.Windows.Forms.Label();
            this.label_Nomer_telefona = new System.Windows.Forms.Label();
            this.label_ID_dolgnosti = new System.Windows.Forms.Label();
            this.label_Data_rozhdeniya = new System.Windows.Forms.Label();
            this.tb_imya = new System.Windows.Forms.TextBox();
            this.tb_familiya = new System.Windows.Forms.TextBox();
            this.tb_otch = new System.Windows.Forms.TextBox();
            this.tb_telefon = new System.Windows.Forms.TextBox();
            this.tb_id_dolg = new System.Windows.Forms.TextBox();
            this.tb_data_rozh = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.договорыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.составToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметЗалогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_Izmenit_sotr = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_dobavit_sotrudnika
            // 
            this.button_dobavit_sotrudnika.BackColor = System.Drawing.Color.GreenYellow;
            this.button_dobavit_sotrudnika.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_dobavit_sotrudnika.Location = new System.Drawing.Point(335, 72);
            this.button_dobavit_sotrudnika.Name = "button_dobavit_sotrudnika";
            this.button_dobavit_sotrudnika.Size = new System.Drawing.Size(158, 108);
            this.button_dobavit_sotrudnika.TabIndex = 1;
            this.button_dobavit_sotrudnika.Text = "Добавить сотрудника";
            this.button_dobavit_sotrudnika.UseVisualStyleBackColor = false;
            this.button_dobavit_sotrudnika.Click += new System.EventHandler(this.button_dobavit_sotrudnika_Click);
            // 
            // label_ID_sotr
            // 
            this.label_ID_sotr.AutoSize = true;
            this.label_ID_sotr.BackColor = System.Drawing.Color.LawnGreen;
            this.label_ID_sotr.Font = new System.Drawing.Font("Segoe Print", 11F);
            this.label_ID_sotr.Location = new System.Drawing.Point(8, 44);
            this.label_ID_sotr.Name = "label_ID_sotr";
            this.label_ID_sotr.Size = new System.Drawing.Size(163, 26);
            this.label_ID_sotr.TabIndex = 2;
            this.label_ID_sotr.Text = "Номер сотрудника";
            // 
            // tb_id_sotr
            // 
            this.tb_id_sotr.Location = new System.Drawing.Point(190, 44);
            this.tb_id_sotr.Name = "tb_id_sotr";
            this.tb_id_sotr.Size = new System.Drawing.Size(100, 20);
            this.tb_id_sotr.TabIndex = 3;
            // 
            // label_Familia
            // 
            this.label_Familia.AutoSize = true;
            this.label_Familia.BackColor = System.Drawing.Color.LawnGreen;
            this.label_Familia.Font = new System.Drawing.Font("Segoe Print", 11F);
            this.label_Familia.Location = new System.Drawing.Point(8, 132);
            this.label_Familia.Name = "label_Familia";
            this.label_Familia.Size = new System.Drawing.Size(82, 26);
            this.label_Familia.TabIndex = 4;
            this.label_Familia.Text = "Фамилия";
            // 
            // label_Imya
            // 
            this.label_Imya.AutoSize = true;
            this.label_Imya.BackColor = System.Drawing.Color.LawnGreen;
            this.label_Imya.Font = new System.Drawing.Font("Segoe Print", 11F);
            this.label_Imya.Location = new System.Drawing.Point(8, 86);
            this.label_Imya.Name = "label_Imya";
            this.label_Imya.Size = new System.Drawing.Size(47, 26);
            this.label_Imya.TabIndex = 5;
            this.label_Imya.Text = "Имя";
            // 
            // label_Otchestvo
            // 
            this.label_Otchestvo.AutoSize = true;
            this.label_Otchestvo.BackColor = System.Drawing.Color.LawnGreen;
            this.label_Otchestvo.Font = new System.Drawing.Font("Segoe Print", 11F);
            this.label_Otchestvo.Location = new System.Drawing.Point(8, 175);
            this.label_Otchestvo.Name = "label_Otchestvo";
            this.label_Otchestvo.Size = new System.Drawing.Size(96, 26);
            this.label_Otchestvo.TabIndex = 6;
            this.label_Otchestvo.Text = "Отчество";
            // 
            // label_Nomer_telefona
            // 
            this.label_Nomer_telefona.AutoSize = true;
            this.label_Nomer_telefona.BackColor = System.Drawing.Color.LawnGreen;
            this.label_Nomer_telefona.Font = new System.Drawing.Font("Segoe Print", 11F);
            this.label_Nomer_telefona.Location = new System.Drawing.Point(8, 220);
            this.label_Nomer_telefona.Name = "label_Nomer_telefona";
            this.label_Nomer_telefona.Size = new System.Drawing.Size(149, 26);
            this.label_Nomer_telefona.TabIndex = 7;
            this.label_Nomer_telefona.Text = "Номер телефона";
            // 
            // label_ID_dolgnosti
            // 
            this.label_ID_dolgnosti.AutoSize = true;
            this.label_ID_dolgnosti.BackColor = System.Drawing.Color.LawnGreen;
            this.label_ID_dolgnosti.Font = new System.Drawing.Font("Segoe Print", 11F);
            this.label_ID_dolgnosti.Location = new System.Drawing.Point(8, 263);
            this.label_ID_dolgnosti.Name = "label_ID_dolgnosti";
            this.label_ID_dolgnosti.Size = new System.Drawing.Size(156, 26);
            this.label_ID_dolgnosti.TabIndex = 8;
            this.label_ID_dolgnosti.Text = "Номер должности";
            // 
            // label_Data_rozhdeniya
            // 
            this.label_Data_rozhdeniya.AutoSize = true;
            this.label_Data_rozhdeniya.BackColor = System.Drawing.Color.LawnGreen;
            this.label_Data_rozhdeniya.Font = new System.Drawing.Font("Segoe Print", 11F);
            this.label_Data_rozhdeniya.Location = new System.Drawing.Point(8, 307);
            this.label_Data_rozhdeniya.Name = "label_Data_rozhdeniya";
            this.label_Data_rozhdeniya.Size = new System.Drawing.Size(138, 26);
            this.label_Data_rozhdeniya.TabIndex = 9;
            this.label_Data_rozhdeniya.Text = "Дата рождения";
            // 
            // tb_imya
            // 
            this.tb_imya.Location = new System.Drawing.Point(190, 86);
            this.tb_imya.Name = "tb_imya";
            this.tb_imya.Size = new System.Drawing.Size(100, 20);
            this.tb_imya.TabIndex = 10;
            // 
            // tb_familiya
            // 
            this.tb_familiya.Location = new System.Drawing.Point(190, 132);
            this.tb_familiya.Name = "tb_familiya";
            this.tb_familiya.Size = new System.Drawing.Size(100, 20);
            this.tb_familiya.TabIndex = 11;
            // 
            // tb_otch
            // 
            this.tb_otch.Location = new System.Drawing.Point(190, 175);
            this.tb_otch.Name = "tb_otch";
            this.tb_otch.Size = new System.Drawing.Size(100, 20);
            this.tb_otch.TabIndex = 12;
            // 
            // tb_telefon
            // 
            this.tb_telefon.Location = new System.Drawing.Point(190, 217);
            this.tb_telefon.Name = "tb_telefon";
            this.tb_telefon.Size = new System.Drawing.Size(100, 20);
            this.tb_telefon.TabIndex = 13;
            // 
            // tb_id_dolg
            // 
            this.tb_id_dolg.Location = new System.Drawing.Point(190, 263);
            this.tb_id_dolg.Name = "tb_id_dolg";
            this.tb_id_dolg.Size = new System.Drawing.Size(100, 20);
            this.tb_id_dolg.TabIndex = 14;
            // 
            // tb_data_rozh
            // 
            this.tb_data_rozh.Location = new System.Drawing.Point(190, 307);
            this.tb_data_rozh.Name = "tb_data_rozh";
            this.tb_data_rozh.Size = new System.Drawing.Size(100, 20);
            this.tb_data_rozh.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.GreenYellow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 36);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникиToolStripMenuItem,
            this.договорыToolStripMenuItem,
            this.составToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.предметЗалогаToolStripMenuItem,
            this.должностиToolStripMenuItem,
            this.выходToolStripMenuItem1});
            this.таблицыToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(93, 32);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            this.таблицыToolStripMenuItem.Click += new System.EventHandler(this.таблицыToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // договорыToolStripMenuItem
            // 
            this.договорыToolStripMenuItem.Name = "договорыToolStripMenuItem";
            this.договорыToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.договорыToolStripMenuItem.Text = "Договоры";
            this.договорыToolStripMenuItem.Click += new System.EventHandler(this.договорыToolStripMenuItem_Click);
            // 
            // составToolStripMenuItem
            // 
            this.составToolStripMenuItem.Name = "составToolStripMenuItem";
            this.составToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.составToolStripMenuItem.Text = "Состав";
            this.составToolStripMenuItem.Click += new System.EventHandler(this.составToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
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
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(219, 32);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem1_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(91, 32);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click_1);
            // 
            // button_Izmenit_sotr
            // 
            this.button_Izmenit_sotr.BackColor = System.Drawing.Color.GreenYellow;
            this.button_Izmenit_sotr.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Izmenit_sotr.Location = new System.Drawing.Point(335, 200);
            this.button_Izmenit_sotr.Name = "button_Izmenit_sotr";
            this.button_Izmenit_sotr.Size = new System.Drawing.Size(158, 108);
            this.button_Izmenit_sotr.TabIndex = 40;
            this.button_Izmenit_sotr.Text = "Изменить сотрудника";
            this.button_Izmenit_sotr.UseVisualStyleBackColor = false;
            // 
            // Form_Novii_sotrudnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(515, 350);
            this.Controls.Add(this.button_Izmenit_sotr);
            this.Controls.Add(this.tb_data_rozh);
            this.Controls.Add(this.tb_id_dolg);
            this.Controls.Add(this.tb_telefon);
            this.Controls.Add(this.tb_otch);
            this.Controls.Add(this.tb_familiya);
            this.Controls.Add(this.tb_imya);
            this.Controls.Add(this.label_Data_rozhdeniya);
            this.Controls.Add(this.label_ID_dolgnosti);
            this.Controls.Add(this.label_Nomer_telefona);
            this.Controls.Add(this.label_Otchestvo);
            this.Controls.Add(this.label_Imya);
            this.Controls.Add(this.label_Familia);
            this.Controls.Add(this.tb_id_sotr);
            this.Controls.Add(this.label_ID_sotr);
            this.Controls.Add(this.button_dobavit_sotrudnika);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Novii_sotrudnik";
            this.Text = "Добавление нового сотрудника";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_dobavit_sotrudnika;
        private System.Windows.Forms.Label label_ID_sotr;
        private System.Windows.Forms.TextBox tb_id_sotr;
        private System.Windows.Forms.Label label_Familia;
        private System.Windows.Forms.Label label_Imya;
        private System.Windows.Forms.Label label_Otchestvo;
        private System.Windows.Forms.Label label_Nomer_telefona;
        private System.Windows.Forms.Label label_ID_dolgnosti;
        private System.Windows.Forms.Label label_Data_rozhdeniya;
        private System.Windows.Forms.TextBox tb_imya;
        private System.Windows.Forms.TextBox tb_familiya;
        private System.Windows.Forms.TextBox tb_otch;
        private System.Windows.Forms.TextBox tb_telefon;
        private System.Windows.Forms.TextBox tb_id_dolg;
        private System.Windows.Forms.TextBox tb_data_rozh;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem договорыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem составToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предметЗалогаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.Button button_Izmenit_sotr;
    }
}