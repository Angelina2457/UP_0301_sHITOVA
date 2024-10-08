namespace PR_7_02._01
{
    partial class Form_Dogovori
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
            this.dataGridView_dogovor = new System.Windows.Forms.DataGridView();
            this.dogovoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fluere1DataSet6 = new PR_7_02._01.Fluere1DataSet6();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ДолжностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметЗалогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.составToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_novii_dogovor = new System.Windows.Forms.Button();
            this.button_Ydalit_dog = new System.Windows.Forms.Button();
            this.button_Zapros_1 = new System.Windows.Forms.Button();
            this.button_Zapros_2 = new System.Windows.Forms.Button();
            this.dogovoriTableAdapter3 = new PR_7_02._01.Fluere1DataSet6TableAdapters.DogovoriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dogovor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogovoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluere1DataSet6)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_dogovor
            // 
            this.dataGridView_dogovor.BackgroundColor = System.Drawing.Color.LawnGreen;
            this.dataGridView_dogovor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dogovor.Location = new System.Drawing.Point(12, 39);
            this.dataGridView_dogovor.Name = "dataGridView_dogovor";
            this.dataGridView_dogovor.Size = new System.Drawing.Size(949, 150);
            this.dataGridView_dogovor.TabIndex = 0;
            // 
            // dogovoriBindingSource
            // 
            this.dogovoriBindingSource.DataMember = "Dogovori";
            this.dogovoriBindingSource.DataSource = this.fluere1DataSet6;
            this.dogovoriBindingSource.CurrentChanged += new System.EventHandler(this.dogovoriBindingSource_CurrentChanged_1);
            // 
            // fluere1DataSet6
            // 
            this.fluere1DataSet6.DataSetName = "Fluere1DataSet6";
            this.fluere1DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.GreenYellow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(973, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникиToolStripMenuItem,
            this.ДолжностиToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.предметЗалогаToolStripMenuItem,
            this.составToolStripMenuItem,
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
            // ДолжностиToolStripMenuItem
            // 
            this.ДолжностиToolStripMenuItem.Name = "ДолжностиToolStripMenuItem";
            this.ДолжностиToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.ДолжностиToolStripMenuItem.Text = "Должности";
            this.ДолжностиToolStripMenuItem.Click += new System.EventHandler(this.ДолжностиToolStripMenuItem_Click);
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
            // составToolStripMenuItem
            // 
            this.составToolStripMenuItem.Name = "составToolStripMenuItem";
            this.составToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.составToolStripMenuItem.Text = "Состав";
            this.составToolStripMenuItem.Click += new System.EventHandler(this.составToolStripMenuItem_Click);
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
            // button_novii_dogovor
            // 
            this.button_novii_dogovor.BackColor = System.Drawing.Color.GreenYellow;
            this.button_novii_dogovor.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_novii_dogovor.Location = new System.Drawing.Point(12, 207);
            this.button_novii_dogovor.Name = "button_novii_dogovor";
            this.button_novii_dogovor.Size = new System.Drawing.Size(364, 67);
            this.button_novii_dogovor.TabIndex = 2;
            this.button_novii_dogovor.Text = "Добавить новый доогвор";
            this.button_novii_dogovor.UseVisualStyleBackColor = false;
            this.button_novii_dogovor.Click += new System.EventHandler(this.button_novii_dogovor_Click);
            // 
            // button_Ydalit_dog
            // 
            this.button_Ydalit_dog.BackColor = System.Drawing.Color.GreenYellow;
            this.button_Ydalit_dog.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.button_Ydalit_dog.Location = new System.Drawing.Point(404, 207);
            this.button_Ydalit_dog.Name = "button_Ydalit_dog";
            this.button_Ydalit_dog.Size = new System.Drawing.Size(364, 67);
            this.button_Ydalit_dog.TabIndex = 27;
            this.button_Ydalit_dog.Text = "Удалить договор";
            this.button_Ydalit_dog.UseVisualStyleBackColor = false;
            // 
            // button_Zapros_1
            // 
            this.button_Zapros_1.BackColor = System.Drawing.Color.GreenYellow;
            this.button_Zapros_1.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.button_Zapros_1.Location = new System.Drawing.Point(792, 207);
            this.button_Zapros_1.Name = "button_Zapros_1";
            this.button_Zapros_1.Size = new System.Drawing.Size(122, 41);
            this.button_Zapros_1.TabIndex = 30;
            this.button_Zapros_1.Text = "Запрос 1";
            this.button_Zapros_1.UseVisualStyleBackColor = false;
            this.button_Zapros_1.Click += new System.EventHandler(this.button_Zapros_1_Click);
            // 
            // button_Zapros_2
            // 
            this.button_Zapros_2.BackColor = System.Drawing.Color.GreenYellow;
            this.button_Zapros_2.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.button_Zapros_2.Location = new System.Drawing.Point(792, 254);
            this.button_Zapros_2.Name = "button_Zapros_2";
            this.button_Zapros_2.Size = new System.Drawing.Size(122, 41);
            this.button_Zapros_2.TabIndex = 31;
            this.button_Zapros_2.Text = "Запрос 2";
            this.button_Zapros_2.UseVisualStyleBackColor = false;
            this.button_Zapros_2.Click += new System.EventHandler(this.button_Zapros_2_Click);
            // 
            // dogovoriTableAdapter3
            // 
            this.dogovoriTableAdapter3.ClearBeforeFill = true;
            // 
            // Form_Dogovori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(973, 302);
            this.Controls.Add(this.button_Zapros_2);
            this.Controls.Add(this.button_Zapros_1);
            this.Controls.Add(this.button_Ydalit_dog);
            this.Controls.Add(this.button_novii_dogovor);
            this.Controls.Add(this.dataGridView_dogovor);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form_Dogovori";
            this.Text = "Договоры";
            this.Load += new System.EventHandler(this.Form_Dogovori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dogovor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogovoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluere1DataSet6)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.Button button_novii_dogovor;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ДолжностиToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView_dogovor;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предметЗалогаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem составToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Button button_Ydalit_dog;
        private System.Windows.Forms.Button button_Zapros_1;
        private System.Windows.Forms.Button button_Zapros_2;
        private Fluere1DataSet6 fluere1DataSet6;
        private System.Windows.Forms.BindingSource dogovoriBindingSource;
        private Fluere1DataSet6TableAdapters.DogovoriTableAdapter dogovoriTableAdapter3;
    }
}