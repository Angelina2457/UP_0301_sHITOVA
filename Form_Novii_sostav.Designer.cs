using System;

namespace PR_7_02._01
{
    partial class Form_Novii_sostav
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
            this.button_dobavit_novii_sostav = new System.Windows.Forms.Button();
            this.label_ID_sostava = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.договорыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметЗалогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.составToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_sostav_izdeliya = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_dobavit_novii_sostav
            // 
            this.button_dobavit_novii_sostav.BackColor = System.Drawing.Color.GreenYellow;
            this.button_dobavit_novii_sostav.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dobavit_novii_sostav.Location = new System.Drawing.Point(83, 159);
            this.button_dobavit_novii_sostav.Name = "button_dobavit_novii_sostav";
            this.button_dobavit_novii_sostav.Size = new System.Drawing.Size(160, 99);
            this.button_dobavit_novii_sostav.TabIndex = 0;
            this.button_dobavit_novii_sostav.Text = "Добавить состав";
            this.button_dobavit_novii_sostav.UseVisualStyleBackColor = false;
            // 
            // label_ID_sostava
            // 
            this.label_ID_sostava.AutoSize = true;
            this.label_ID_sostava.BackColor = System.Drawing.Color.LawnGreen;
            this.label_ID_sostava.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_ID_sostava.Location = new System.Drawing.Point(12, 56);
            this.label_ID_sostava.Name = "label_ID_sostava";
            this.label_ID_sostava.Size = new System.Drawing.Size(134, 26);
            this.label_ID_sostava.TabIndex = 1;
            this.label_ID_sostava.Text = "Номер состава";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.GreenYellow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(319, 41);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.договорыToolStripMenuItem,
            this.должностиToolStripMenuItem,
            this.предметЗалогаToolStripMenuItem,
            this.составToolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.таблицыToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(109, 37);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            this.таблицыToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(254, 38);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(254, 38);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // договорыToolStripMenuItem
            // 
            this.договорыToolStripMenuItem.Name = "договорыToolStripMenuItem";
            this.договорыToolStripMenuItem.Size = new System.Drawing.Size(254, 38);
            this.договорыToolStripMenuItem.Text = "Договоры";
            this.договорыToolStripMenuItem.Click += new System.EventHandler(this.договорыToolStripMenuItem_Click);
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(254, 38);
            this.должностиToolStripMenuItem.Text = "Должности";
            this.должностиToolStripMenuItem.Click += new System.EventHandler(this.должностиToolStripMenuItem_Click);
            // 
            // предметЗалогаToolStripMenuItem
            // 
            this.предметЗалогаToolStripMenuItem.Name = "предметЗалогаToolStripMenuItem";
            this.предметЗалогаToolStripMenuItem.Size = new System.Drawing.Size(254, 38);
            this.предметЗалогаToolStripMenuItem.Text = "Предмет залога";
            this.предметЗалогаToolStripMenuItem.Click += new System.EventHandler(this.предметЗалогаToolStripMenuItem_Click);
            // 
            // составToolStripMenuItem1
            // 
            this.составToolStripMenuItem1.Name = "составToolStripMenuItem1";
            this.составToolStripMenuItem1.Size = new System.Drawing.Size(254, 38);
            this.составToolStripMenuItem1.Text = "Состав";
            this.составToolStripMenuItem1.Click += new System.EventHandler(this.составToolStripMenuItem1_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(254, 38);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(91, 37);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // label_sostav_izdeliya
            // 
            this.label_sostav_izdeliya.AutoSize = true;
            this.label_sostav_izdeliya.BackColor = System.Drawing.Color.LawnGreen;
            this.label_sostav_izdeliya.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_sostav_izdeliya.Location = new System.Drawing.Point(12, 97);
            this.label_sostav_izdeliya.Name = "label_sostav_izdeliya";
            this.label_sostav_izdeliya.Size = new System.Drawing.Size(134, 26);
            this.label_sostav_izdeliya.TabIndex = 4;
            this.label_sostav_izdeliya.Text = "Состав изделия";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(184, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // Form_Novii_sostav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(319, 278);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_sostav_izdeliya);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_ID_sostava);
            this.Controls.Add(this.button_dobavit_novii_sostav);
            this.Name = "Form_Novii_sostav";
            this.Text = "Добавление нового состава";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_dobavit_novii_sostav;
        private System.Windows.Forms.Label label_ID_sostava;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem договорыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предметЗалогаToolStripMenuItem;
        private System.Windows.Forms.Label label_sostav_izdeliya;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem составToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}