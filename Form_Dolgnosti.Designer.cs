namespace PR_7_02._01
{
    partial class Form_Dolgnosti
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
            this.dataGridView_dolgost = new System.Windows.Forms.DataGridView();
            this.iDdolgnostiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolgnostsotrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolgnostiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fluereDataSet14 = new PR_7_02._01.FluereDataSet14();
            this.dolgnostiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fluereDataSet4 = new PR_7_02._01.FluereDataSet4();
            this.dolgnostiTableAdapter = new PR_7_02._01.FluereDataSet4TableAdapters.DolgnostiTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.договорыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.составToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметЗалогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dolgnostiTableAdapter1 = new PR_7_02._01.FluereDataSet14TableAdapters.DolgnostiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dolgost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolgnostiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluereDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolgnostiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluereDataSet4)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_dolgost
            // 
            this.dataGridView_dolgost.AutoGenerateColumns = false;
            this.dataGridView_dolgost.BackgroundColor = System.Drawing.Color.LawnGreen;
            this.dataGridView_dolgost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dolgost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDdolgnostiDataGridViewTextBoxColumn,
            this.dolgnostsotrDataGridViewTextBoxColumn});
            this.dataGridView_dolgost.DataSource = this.dolgnostiBindingSource1;
            this.dataGridView_dolgost.Location = new System.Drawing.Point(25, 65);
            this.dataGridView_dolgost.Name = "dataGridView_dolgost";
            this.dataGridView_dolgost.Size = new System.Drawing.Size(270, 141);
            this.dataGridView_dolgost.TabIndex = 0;
            // 
            // iDdolgnostiDataGridViewTextBoxColumn
            // 
            this.iDdolgnostiDataGridViewTextBoxColumn.DataPropertyName = "ID_dolgnosti";
            this.iDdolgnostiDataGridViewTextBoxColumn.HeaderText = "№ должности";
            this.iDdolgnostiDataGridViewTextBoxColumn.Name = "iDdolgnostiDataGridViewTextBoxColumn";
            // 
            // dolgnostsotrDataGridViewTextBoxColumn
            // 
            this.dolgnostsotrDataGridViewTextBoxColumn.DataPropertyName = "Dolgnost_sotr";
            this.dolgnostsotrDataGridViewTextBoxColumn.HeaderText = "Должность сотрудника";
            this.dolgnostsotrDataGridViewTextBoxColumn.Name = "dolgnostsotrDataGridViewTextBoxColumn";
            // 
            // dolgnostiBindingSource1
            // 
            this.dolgnostiBindingSource1.DataMember = "Dolgnosti";
            this.dolgnostiBindingSource1.DataSource = this.fluereDataSet14;
            // 
            // fluereDataSet14
            // 
            this.fluereDataSet14.DataSetName = "FluereDataSet14";
            this.fluereDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dolgnostiBindingSource
            // 
            this.dolgnostiBindingSource.DataMember = "Dolgnosti";
            this.dolgnostiBindingSource.DataSource = this.fluereDataSet4;
            // 
            // fluereDataSet4
            // 
            this.fluereDataSet4.DataSetName = "FluereDataSet4";
            this.fluereDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dolgnostiTableAdapter
            // 
            this.dolgnostiTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.GreenYellow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(307, 41);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.договорыToolStripMenuItem,
            this.составToolStripMenuItem,
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
            // составToolStripMenuItem
            // 
            this.составToolStripMenuItem.Name = "составToolStripMenuItem";
            this.составToolStripMenuItem.Size = new System.Drawing.Size(254, 38);
            this.составToolStripMenuItem.Text = "Состав";
            this.составToolStripMenuItem.Click += new System.EventHandler(this.составToolStripMenuItem_Click);
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
            // dolgnostiTableAdapter1
            // 
            this.dolgnostiTableAdapter1.ClearBeforeFill = true;
            // 
            // Form_Dolgnosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(307, 230);
            this.Controls.Add(this.dataGridView_dolgost);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Dolgnosti";
            this.Text = "Должности";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dolgost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolgnostiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluereDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dolgnostiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluereDataSet4)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_dolgost;
        private FluereDataSet4 fluereDataSet4;
        private System.Windows.Forms.BindingSource dolgnostiBindingSource;
        private FluereDataSet4TableAdapters.DolgnostiTableAdapter dolgnostiTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem договорыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem составToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предметЗалогаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDdolgnostiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dolgnostsotrDataGridViewTextBoxColumn;
        private FluereDataSet14 fluereDataSet14;
        private System.Windows.Forms.BindingSource dolgnostiBindingSource1;
        private FluereDataSet14TableAdapters.DolgnostiTableAdapter dolgnostiTableAdapter1;
    }
}