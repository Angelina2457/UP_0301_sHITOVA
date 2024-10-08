namespace PR_7_02._01
{
    partial class Form_Vhod
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_vhod = new System.Windows.Forms.Button();
            this.label_login = new System.Windows.Forms.Label();
            this.label_parol = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_parol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_vhod
            // 
            this.button_vhod.BackColor = System.Drawing.Color.GreenYellow;
            this.button_vhod.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_vhod.Location = new System.Drawing.Point(46, 149);
            this.button_vhod.Name = "button_vhod";
            this.button_vhod.Size = new System.Drawing.Size(190, 42);
            this.button_vhod.TabIndex = 0;
            this.button_vhod.Text = "Войти";
            this.button_vhod.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_vhod.UseVisualStyleBackColor = false;
            this.button_vhod.Click += new System.EventHandler(this.button_vhod_Click);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.BackColor = System.Drawing.Color.LawnGreen;
            this.label_login.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.Location = new System.Drawing.Point(23, 18);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(68, 25);
            this.label_login.TabIndex = 1;
            this.label_login.Text = "Логин";
            // 
            // label_parol
            // 
            this.label_parol.AutoSize = true;
            this.label_parol.BackColor = System.Drawing.Color.LawnGreen;
            this.label_parol.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_parol.Location = new System.Drawing.Point(23, 79);
            this.label_parol.Name = "label_parol";
            this.label_parol.Size = new System.Drawing.Size(72, 25);
            this.label_parol.TabIndex = 2;
            this.label_parol.Text = "Пароль";
            // 
            // tb_login
            // 
            this.tb_login.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_login.Location = new System.Drawing.Point(143, 10);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(128, 33);
            this.tb_login.TabIndex = 3;
            // 
            // tb_parol
            // 
            this.tb_parol.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_parol.Location = new System.Drawing.Point(143, 76);
            this.tb_parol.Name = "tb_parol";
            this.tb_parol.Size = new System.Drawing.Size(128, 33);
            this.tb_parol.TabIndex = 4;
            // 
            // Form_Vhod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(283, 225);
            this.Controls.Add(this.tb_parol);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.label_parol);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.button_vhod);
            this.Name = "Form_Vhod";
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.Form_Vhod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_vhod;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_parol;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_parol;
    }
}

