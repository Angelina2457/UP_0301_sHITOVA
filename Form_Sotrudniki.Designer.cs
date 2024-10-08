namespace PR_7_02._01
{
    partial class Form_Sotrudniki
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
            this.dataGridView_sotr = new System.Windows.Forms.DataGridView();
            this.sotrudnikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fluere1DataSet7 = new PR_7_02._01.Fluere1DataSet7();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.договорыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.составToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметЗалогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_novii_sotrudnik = new System.Windows.Forms.Button();
            this.button_Ydalit_sotr = new System.Windows.Forms.Button();
            this.sotrudnikiTableAdapter4 = new PR_7_02._01.Fluere1DataSet7TableAdapters.SotrudnikiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sotr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluere1DataSet7)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_sotr
            // 
            this.dataGridView_sotr.BackgroundColor = System.Drawing.Color.LawnGreen;
            this.dataGridView_sotr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_sotr.Location = new System.Drawing.Point(12, 53);
            this.dataGridView_sotr.Name = "dataGridView_sotr";
            this.dataGridView_sotr.Size = new System.Drawing.Size(946, 141);
            this.dataGridView_sotr.TabIndex = 0;
            this.dataGridView_sotr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_sotr_CellContentClick);
            // 
            // sotrudnikiBindingSource
            // 
            this.sotrudnikiBindingSource.DataMember = "Sotrudniki";
            this.sotrudnikiBindingSource.DataSource = this.fluere1DataSet7;
            this.sotrudnikiBindingSource.CurrentChanged += new System.EventHandler(this.sotrudnikiBindingSource_CurrentChanged);
            // 
            // fluere1DataSet7
            // 
            this.fluere1DataSet7.DataSetName = "Fluere1DataSet7";
            this.fluere1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.GreenYellow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.договорыToolStripMenuItem,
            this.составToolStripMenuItem,
            this.предметЗалогаToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.выходToolStripMenuItem1});
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
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
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
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // button_novii_sotrudnik
            // 
            this.button_novii_sotrudnik.BackColor = System.Drawing.Color.GreenYellow;
            this.button_novii_sotrudnik.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_novii_sotrudnik.Location = new System.Drawing.Point(108, 209);
            this.button_novii_sotrudnik.Name = "button_novii_sotrudnik";
            this.button_novii_sotrudnik.Size = new System.Drawing.Size(343, 60);
            this.button_novii_sotrudnik.TabIndex = 2;
            this.button_novii_sotrudnik.Text = "Добавить нового сотрудника";
            this.button_novii_sotrudnik.UseVisualStyleBackColor = false;
            this.button_novii_sotrudnik.Click += new System.EventHandler(this.button_novii_sotrudnik_Click);
            // 
            // button_Ydalit_sotr
            // 
            this.button_Ydalit_sotr.BackColor = System.Drawing.Color.GreenYellow;
            this.button_Ydalit_sotr.Font = new System.Drawing.Font("Segoe Print", 14.25F);
            this.button_Ydalit_sotr.Location = new System.Drawing.Point(500, 209);
            this.button_Ydalit_sotr.Name = "button_Ydalit_sotr";
            this.button_Ydalit_sotr.Size = new System.Drawing.Size(343, 60);
            this.button_Ydalit_sotr.TabIndex = 27;
            this.button_Ydalit_sotr.Text = "Удалить сотрудника";
            this.button_Ydalit_sotr.UseVisualStyleBackColor = false;
            // 
            // sotrudnikiTableAdapter4
            // 
            this.sotrudnikiTableAdapter4.ClearBeforeFill = true;
            // 
            // Form_Sotrudniki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1020, 292);
            this.Controls.Add(this.button_Ydalit_sotr);
            this.Controls.Add(this.button_novii_sotrudnik);
            this.Controls.Add(this.dataGridView_sotr);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Sotrudniki";
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.Form_Sotrudniki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_sotr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sotrudnikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluere1DataSet7)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem договорыToolStripMenuItem;
        private System.Windows.Forms.Button button_novii_sotrudnik;
        public System.Windows.Forms.DataGridView dataGridView_sotr;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предметЗалогаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem составToolStripMenuItem;
        private System.Windows.Forms.Button button_Ydalit_sotr;
        private Fluere1DataSet7 fluere1DataSet7;
        private System.Windows.Forms.BindingSource sotrudnikiBindingSource;
        private Fluere1DataSet7TableAdapters.SotrudnikiTableAdapter sotrudnikiTableAdapter4;
    }
}