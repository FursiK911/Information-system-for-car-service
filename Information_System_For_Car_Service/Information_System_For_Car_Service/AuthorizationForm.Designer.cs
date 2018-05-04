namespace Information_System_For_Car_Service
{
    partial class AuthorizationForm
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
            this.tb_login = new System.Windows.Forms.TextBox();
            this.lb_login = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.cb_viewPassword = new System.Windows.Forms.CheckBox();
            this.bt_ok = new System.Windows.Forms.Button();
            this.bt_close = new System.Windows.Forms.Button();
            this.llb_registered = new System.Windows.Forms.LinkLabel();
            this.lb_notHaveAcc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_login
            // 
            this.tb_login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_login.Location = new System.Drawing.Point(12, 38);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(286, 20);
            this.tb_login.TabIndex = 0;
            this.tb_login.Text = "ManikO";
            // 
            // lb_login
            // 
            this.lb_login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_login.AutoSize = true;
            this.lb_login.Location = new System.Drawing.Point(12, 22);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(38, 13);
            this.lb_login.TabIndex = 1;
            this.lb_login.Text = "Логин";
            // 
            // lb_password
            // 
            this.lb_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(12, 83);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(45, 13);
            this.lb_password.TabIndex = 3;
            this.lb_password.Text = "Пароль";
            // 
            // tb_password
            // 
            this.tb_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_password.Location = new System.Drawing.Point(12, 99);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(286, 20);
            this.tb_password.TabIndex = 2;
            this.tb_password.Text = "black";
            // 
            // cb_viewPassword
            // 
            this.cb_viewPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_viewPassword.AutoSize = true;
            this.cb_viewPassword.Checked = true;
            this.cb_viewPassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_viewPassword.Location = new System.Drawing.Point(171, 79);
            this.cb_viewPassword.Name = "cb_viewPassword";
            this.cb_viewPassword.Size = new System.Drawing.Size(64, 17);
            this.cb_viewPassword.TabIndex = 4;
            this.cb_viewPassword.Text = "Скрыть";
            this.cb_viewPassword.UseVisualStyleBackColor = true;
            this.cb_viewPassword.CheckedChanged += new System.EventHandler(this.cb_viewPassword_CheckedChanged);
            // 
            // bt_ok
            // 
            this.bt_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_ok.Location = new System.Drawing.Point(12, 200);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(116, 54);
            this.bt_ok.TabIndex = 5;
            this.bt_ok.Text = "Войти";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // bt_close
            // 
            this.bt_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_close.Location = new System.Drawing.Point(186, 200);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(116, 54);
            this.bt_close.TabIndex = 6;
            this.bt_close.Text = "Выйти";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // llb_registered
            // 
            this.llb_registered.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.llb_registered.AutoSize = true;
            this.llb_registered.Location = new System.Drawing.Point(172, 163);
            this.llb_registered.Name = "llb_registered";
            this.llb_registered.Size = new System.Drawing.Size(113, 13);
            this.llb_registered.TabIndex = 7;
            this.llb_registered.TabStop = true;
            this.llb_registered.Text = "Зарегистрироваться";
            this.llb_registered.Click += new System.EventHandler(this.llb_register_Click);
            // 
            // lb_notHaveAcc
            // 
            this.lb_notHaveAcc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_notHaveAcc.AutoSize = true;
            this.lb_notHaveAcc.Location = new System.Drawing.Point(85, 163);
            this.lb_notHaveAcc.Name = "lb_notHaveAcc";
            this.lb_notHaveAcc.Size = new System.Drawing.Size(81, 13);
            this.lb_notHaveAcc.TabIndex = 8;
            this.lb_notHaveAcc.Text = "Нет аккаунта?";
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 266);
            this.Controls.Add(this.lb_notHaveAcc);
            this.Controls.Add(this.llb_registered);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.cb_viewPassword);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.tb_login);
            this.MaximumSize = new System.Drawing.Size(472, 346);
            this.MinimumSize = new System.Drawing.Size(330, 304);
            this.Name = "AuthorizationForm";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.CheckBox cb_viewPassword;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.LinkLabel llb_registered;
        private System.Windows.Forms.Label lb_notHaveAcc;
    }
}

