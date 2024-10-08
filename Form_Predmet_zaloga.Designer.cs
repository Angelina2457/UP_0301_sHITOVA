namespace PR_7_02._01
{
    partial class Form_Predmet_zaloga
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
            this.dataGridView_predmet = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.договорыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.составToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_dobavit_novii_predmet = new System.Windows.Forms.Button();
            this.button_Ydalit_predmet = new System.Windows.Forms.Button();
            this.button_Zapros = new System.Windows.Forms.Button();
            this.predmetzalogaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fluere1DataSet10 = new PR_7_02._01.Fluere1DataSet10();
            this.predmetzalogaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.predmet_zalogaTableAdapter2 = new PR_7_02._01.Fluere1DataSet10TableAdapters.Predmet_zalogaTableAdapter();
            this.выгрузкаВXmlфайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_predmet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.predmetzalogaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluere1DataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetzalogaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_predmet
            // 
            this.dataGridView_predmet.BackgroundColor = System.Drawing.Color.LawnGreen;
            this.dataGridView_predmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_predmet.Location = new System.Drawing.Point(109, 61);
            this.dataGridView_predmet.Name = "dataGridView_predmet";
            this.dataGridView_predmet.Size = new System.Drawing.Size(546, 150);
            this.dataGridView_predmet.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.GreenYellow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.выгрузкаВXmlфайлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(773, 41);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.договорыToolStripMenuItem,
            this.должностиToolStripMenuItem,
            this.составToolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.таблицыToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(109, 37);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            this.таблицыToolStripMenuItem.Click += new System.EventHandler(this.таблицыToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(213, 38);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(213, 38);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // договорыToolStripMenuItem
            // 
            this.договорыToolStripMenuItem.Name = "договорыToolStripMenuItem";
            this.договорыToolStripMenuItem.Size = new System.Drawing.Size(213, 38);
            this.договорыToolStripMenuItem.Text = "Договоры";
            this.договорыToolStripMenuItem.Click += new System.EventHandler(this.договорыToolStripMenuItem_Click);
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(213, 38);
            this.должностиToolStripMenuItem.Text = "Должности";
            this.должностиToolStripMenuItem.Click += new System.EventHandler(this.должностиToolStripMenuItem_Click);
            // 
            // составToolStripMenuItem1
            // 
            this.составToolStripMenuItem1.Name = "составToolStripMenuItem1";
            this.составToolStripMenuItem1.Size = new System.Drawing.Size(213, 38);
            this.составToolStripMenuItem1.Text = "Состав";
            this.составToolStripMenuItem1.Click += new System.EventHandler(this.составToolStripMenuItem1_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(213, 38);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(91, 37);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // button_dobavit_novii_predmet
            // 
            this.button_dobavit_novii_predmet.BackColor = System.Drawing.Color.GreenYellow;
            this.button_dobavit_novii_predmet.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dobavit_novii_predmet.Location = new System.Drawing.Point(23, 240);
            this.button_dobavit_novii_predmet.Name = "button_dobavit_novii_predmet";
            this.button_dobavit_novii_predmet.Size = new System.Drawing.Size(255, 99);
            this.button_dobavit_novii_predmet.TabIndex = 5;
            this.button_dobavit_novii_predmet.Text = "Добавить новый предмет залога";
            this.button_dobavit_novii_predmet.UseVisualStyleBackColor = false;
            this.button_dobavit_novii_predmet.Click += new System.EventHandler(this.button_dobavit_novii_predmet_Click);
            // 
            // button_Ydalit_predmet
            // 
            this.button_Ydalit_predmet.BackColor = System.Drawing.Color.GreenYellow;
            this.button_Ydalit_predmet.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.button_Ydalit_predmet.Location = new System.Drawing.Point(303, 240);
            this.button_Ydalit_predmet.Name = "button_Ydalit_predmet";
            this.button_Ydalit_predmet.Size = new System.Drawing.Size(255, 99);
            this.button_Ydalit_predmet.TabIndex = 28;
            this.button_Ydalit_predmet.Text = "Удалить предмет залога";
            this.button_Ydalit_predmet.UseVisualStyleBackColor = false;
            // 
            // button_Zapros
            // 
            this.button_Zapros.BackColor = System.Drawing.Color.GreenYellow;
            this.button_Zapros.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.button_Zapros.Location = new System.Drawing.Point(604, 259);
            this.button_Zapros.Name = "button_Zapros";
            this.button_Zapros.Size = new System.Drawing.Size(139, 61);
            this.button_Zapros.TabIndex = 30;
            this.button_Zapros.Text = "Запрос";
            this.button_Zapros.UseVisualStyleBackColor = false;
            this.button_Zapros.Click += new System.EventHandler(this.button_Zapros_Click);
            // 
            // predmetzalogaBindingSource1
            // 
            this.predmetzalogaBindingSource1.CurrentChanged += new System.EventHandler(this.predmetzalogaBindingSource1_CurrentChanged);
            // 
            // fluere1DataSet10
            // 
            this.fluere1DataSet10.DataSetName = "Fluere1DataSet10";
            this.fluere1DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // predmetzalogaBindingSource2
            // 
            this.predmetzalogaBindingSource2.DataMember = "Predmet_zaloga";
            this.predmetzalogaBindingSource2.DataSource = this.fluere1DataSet10;
            this.predmetzalogaBindingSource2.CurrentChanged += new System.EventHandler(this.predmetzalogaBindingSource2_CurrentChanged);
            // 
            // predmet_zalogaTableAdapter2
            // 
            this.predmet_zalogaTableAdapter2.ClearBeforeFill = true;
            // 
            // выгрузкаВXmlфайлToolStripMenuItem
            // 
            this.выгрузкаВXmlфайлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.выгрузкаВXmlфайлToolStripMenuItem.Name = "выгрузкаВXmlфайлToolStripMenuItem";
            this.выгрузкаВXmlфайлToolStripMenuItem.Size = new System.Drawing.Size(204, 37);
            this.выгрузкаВXmlфайлToolStripMenuItem.Text = "Выгрузка в xml-файл";
            this.выгрузкаВXmlфайлToolStripMenuItem.Click += new System.EventHandler(this.выгрузкаВXmlфайлToolStripMenuItem_Click);
            // 
            // Form_Predmet_zaloga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(773, 351);
            this.Controls.Add(this.button_Zapros);
            this.Controls.Add(this.button_Ydalit_predmet);
            this.Controls.Add(this.button_dobavit_novii_predmet);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView_predmet);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form_Predmet_zaloga";
            this.Text = "Предмет залога";
            this.Load += new System.EventHandler(this.Form_Predmet_zaloga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_predmet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.predmetzalogaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluere1DataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetzalogaBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_predmet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem договорыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.Button button_dobavit_novii_predmet;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem составToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button button_Ydalit_predmet;
        private System.Windows.Forms.BindingSource predmetzalogaBindingSource1;
        private System.Windows.Forms.Button button_Zapros;
        private Fluere1DataSet10 fluere1DataSet10;
        private System.Windows.Forms.BindingSource predmetzalogaBindingSource2;
        private Fluere1DataSet10TableAdapters.Predmet_zalogaTableAdapter predmet_zalogaTableAdapter2;
        private System.Windows.Forms.ToolStripMenuItem выгрузкаВXmlфайлToolStripMenuItem;
    }
}