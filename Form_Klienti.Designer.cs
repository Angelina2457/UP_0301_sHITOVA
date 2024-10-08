namespace PR_7_02._01
{
    partial class Form_Klienti
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
            this.dataGridView_klienti = new System.Windows.Forms.DataGridView();
            this.klientiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fluere1DataSet3 = new PR_7_02._01.Fluere1DataSet3();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.составToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.договорыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметЗалогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_dobavit_novogo_klienta = new System.Windows.Forms.Button();
            this.klientiTableAdapter1 = new PR_7_02._01.FluereDataSet12TableAdapters.KlientiTableAdapter();
            this.fIASadresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_Ydalit_kl = new System.Windows.Forms.Button();
            this.klientiTableAdapter2 = new PR_7_02._01.Fluere1DataSet3TableAdapters.KlientiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_klienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluere1DataSet3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fIASadresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_klienti
            // 
            this.dataGridView_klienti.BackgroundColor = System.Drawing.Color.LawnGreen;
            this.dataGridView_klienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_klienti.Location = new System.Drawing.Point(12, 63);
            this.dataGridView_klienti.Name = "dataGridView_klienti";
            this.dataGridView_klienti.Size = new System.Drawing.Size(944, 142);
            this.dataGridView_klienti.TabIndex = 0;
            // 
            // klientiBindingSource2
            // 
            this.klientiBindingSource2.DataMember = "Klienti";
            this.klientiBindingSource2.DataSource = this.fluere1DataSet3;
            this.klientiBindingSource2.CurrentChanged += new System.EventHandler(this.klientiBindingSource2_CurrentChanged);
            // 
            // fluere1DataSet3
            // 
            this.fluere1DataSet3.DataSetName = "Fluere1DataSet3";
            this.fluere1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.GreenYellow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(968, 41);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.составToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.договорыToolStripMenuItem,
            this.должностиToolStripMenuItem,
            this.предметЗалогаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.таблицыToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(109, 37);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            this.таблицыToolStripMenuItem.Click += new System.EventHandler(this.таблицыToolStripMenuItem_Click);
            // 
            // составToolStripMenuItem
            // 
            this.составToolStripMenuItem.Name = "составToolStripMenuItem";
            this.составToolStripMenuItem.Size = new System.Drawing.Size(254, 38);
            this.составToolStripMenuItem.Text = "Состав";
            this.составToolStripMenuItem.Click += new System.EventHandler(this.составToolStripMenuItem_Click);
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
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click_1);
            // 
            // button_dobavit_novogo_klienta
            // 
            this.button_dobavit_novogo_klienta.BackColor = System.Drawing.Color.GreenYellow;
            this.button_dobavit_novogo_klienta.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_dobavit_novogo_klienta.Location = new System.Drawing.Point(86, 211);
            this.button_dobavit_novogo_klienta.Name = "button_dobavit_novogo_klienta";
            this.button_dobavit_novogo_klienta.Size = new System.Drawing.Size(355, 60);
            this.button_dobavit_novogo_klienta.TabIndex = 4;
            this.button_dobavit_novogo_klienta.Text = "Добавить нового клиента";
            this.button_dobavit_novogo_klienta.UseVisualStyleBackColor = false;
            this.button_dobavit_novogo_klienta.Click += new System.EventHandler(this.button_dobavit_novogo_klienta_Click);
            // 
            // klientiTableAdapter1
            // 
            this.klientiTableAdapter1.ClearBeforeFill = true;
            // 
            // button_Ydalit_kl
            // 
            this.button_Ydalit_kl.BackColor = System.Drawing.Color.GreenYellow;
            this.button_Ydalit_kl.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.button_Ydalit_kl.Location = new System.Drawing.Point(543, 211);
            this.button_Ydalit_kl.Name = "button_Ydalit_kl";
            this.button_Ydalit_kl.Size = new System.Drawing.Size(355, 60);
            this.button_Ydalit_kl.TabIndex = 26;
            this.button_Ydalit_kl.Text = "Удалить клиента";
            this.button_Ydalit_kl.UseVisualStyleBackColor = false;
            // 
            // klientiTableAdapter2
            // 
            this.klientiTableAdapter2.ClearBeforeFill = true;
            // 
            // Form_Klienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(968, 299);
            this.Controls.Add(this.button_Ydalit_kl);
            this.Controls.Add(this.button_dobavit_novogo_klienta);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView_klienti);
            this.Name = "Form_Klienti";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.Form_Klienti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_klienti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluere1DataSet3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fIASadresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_klienti;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem составToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem договорыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предметЗалогаToolStripMenuItem;
        private System.Windows.Forms.Button button_dobavit_novogo_klienta;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private FluereDataSet12TableAdapters.KlientiTableAdapter klientiTableAdapter1;
        private System.Windows.Forms.BindingSource fIASadresBindingSource;
        private System.Windows.Forms.Button button_Ydalit_kl;
        private Fluere1DataSet3 fluere1DataSet3;
        private System.Windows.Forms.BindingSource klientiBindingSource2;
        private Fluere1DataSet3TableAdapters.KlientiTableAdapter klientiTableAdapter2;
    }
}