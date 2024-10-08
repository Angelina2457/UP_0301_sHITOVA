namespace PR_7_02._01
{
    partial class Form_Sostav
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
            this.dataGridView_sostav = new System.Windows.Forms.DataGridView();
            this.iDsostavaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sostavizdeliyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sostavBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fluere1DataSet4 = new PR_7_02._01.Fluere1DataSet4();
            this.sostavTableAdapter = new PR_7_02._01.FluereDataSet5TableAdapters.SostavTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.договорыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметЗалогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_dobavit_novii_sostav = new System.Windows.Forms.Button();
            this.button_Ydalit_sost = new System.Windows.Forms.Button();
            this.sostavTableAdapter1 = new PR_7_02._01.FluereDataSet15TableAdapters.SostavTableAdapter();
            this.sostavTableAdapter2 = new PR_7_02._01.Fluere1DataSet4TableAdapters.SostavTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sostav)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sostavBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluere1DataSet4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_sostav
            // 
            this.dataGridView_sostav.AutoGenerateColumns = false;
            this.dataGridView_sostav.BackgroundColor = System.Drawing.Color.LawnGreen;
            this.dataGridView_sostav.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sostav.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDsostavaDataGridViewTextBoxColumn,
            this.sostavizdeliyaDataGridViewTextBoxColumn});
            this.dataGridView_sostav.DataSource = this.sostavBindingSource2;
            this.dataGridView_sostav.Location = new System.Drawing.Point(12, 59);
            this.dataGridView_sostav.Name = "dataGridView_sostav";
            this.dataGridView_sostav.Size = new System.Drawing.Size(245, 150);
            this.dataGridView_sostav.TabIndex = 0;
            // 
            // iDsostavaDataGridViewTextBoxColumn
            // 
            this.iDsostavaDataGridViewTextBoxColumn.DataPropertyName = "ID_sostava";
            this.iDsostavaDataGridViewTextBoxColumn.HeaderText = "ID_sostava";
            this.iDsostavaDataGridViewTextBoxColumn.Name = "iDsostavaDataGridViewTextBoxColumn";
            // 
            // sostavizdeliyaDataGridViewTextBoxColumn
            // 
            this.sostavizdeliyaDataGridViewTextBoxColumn.DataPropertyName = "Sostav_izdeliya";
            this.sostavizdeliyaDataGridViewTextBoxColumn.HeaderText = "Sostav_izdeliya";
            this.sostavizdeliyaDataGridViewTextBoxColumn.Name = "sostavizdeliyaDataGridViewTextBoxColumn";
            // 
            // sostavBindingSource2
            // 
            this.sostavBindingSource2.DataMember = "Sostav";
            this.sostavBindingSource2.DataSource = this.fluere1DataSet4;
            // 
            // fluere1DataSet4
            // 
            this.fluere1DataSet4.DataSetName = "Fluere1DataSet4";
            this.fluere1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sostavTableAdapter
            // 
            this.sostavTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.GreenYellow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(457, 41);
            this.menuStrip1.TabIndex = 2;
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
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // button_dobavit_novii_sostav
            // 
            this.button_dobavit_novii_sostav.BackColor = System.Drawing.Color.GreenYellow;
            this.button_dobavit_novii_sostav.Font = new System.Drawing.Font("Segoe Print", 13.25F);
            this.button_dobavit_novii_sostav.Location = new System.Drawing.Point(278, 59);
            this.button_dobavit_novii_sostav.Name = "button_dobavit_novii_sostav";
            this.button_dobavit_novii_sostav.Size = new System.Drawing.Size(164, 75);
            this.button_dobavit_novii_sostav.TabIndex = 5;
            this.button_dobavit_novii_sostav.Text = "Добавить новый состав";
            this.button_dobavit_novii_sostav.UseVisualStyleBackColor = false;
            this.button_dobavit_novii_sostav.Click += new System.EventHandler(this.button_dobavit_novii_sostav_Click);
            // 
            // button_Ydalit_sost
            // 
            this.button_Ydalit_sost.BackColor = System.Drawing.Color.GreenYellow;
            this.button_Ydalit_sost.Font = new System.Drawing.Font("Segoe Print", 13.25F);
            this.button_Ydalit_sost.Location = new System.Drawing.Point(278, 139);
            this.button_Ydalit_sost.Name = "button_Ydalit_sost";
            this.button_Ydalit_sost.Size = new System.Drawing.Size(164, 70);
            this.button_Ydalit_sost.TabIndex = 28;
            this.button_Ydalit_sost.Text = "Удалить состав";
            this.button_Ydalit_sost.UseVisualStyleBackColor = false;
            // 
            // sostavTableAdapter1
            // 
            this.sostavTableAdapter1.ClearBeforeFill = true;
            // 
            // sostavTableAdapter2
            // 
            this.sostavTableAdapter2.ClearBeforeFill = true;
            // 
            // Form_Sostav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(457, 222);
            this.Controls.Add(this.button_Ydalit_sost);
            this.Controls.Add(this.button_dobavit_novii_sostav);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView_sostav);
            this.Name = "Form_Sostav";
            this.Text = "Состав";
            this.Load += new System.EventHandler(this.Form_Sostav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sostav)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sostavBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluere1DataSet4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_sostav;
        private FluereDataSet5TableAdapters.SostavTableAdapter sostavTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDsostavaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sostavizdeliyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem договорыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предметЗалогаToolStripMenuItem;
        private System.Windows.Forms.Button button_dobavit_novii_sostav;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button button_Ydalit_sost;
        private FluereDataSet15TableAdapters.SostavTableAdapter sostavTableAdapter1;
        private Fluere1DataSet4 fluere1DataSet4;
        private System.Windows.Forms.BindingSource sostavBindingSource2;
        private Fluere1DataSet4TableAdapters.SostavTableAdapter sostavTableAdapter2;
    }
}