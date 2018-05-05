namespace Information_System_For_Car_Service
{
    partial class BaseClientsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseClientsForm));
            this.ms_menu = new System.Windows.Forms.MenuStrip();
            this.ms_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_comeback = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_info = new System.Windows.Forms.DataGridView();
            this.col_login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_yearOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_carModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_licensePlate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_yearOfCar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_statusVIP = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ms_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).BeginInit();
            this.SuspendLayout();
            // 
            // ms_menu
            // 
            this.ms_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_delete,
            this.ms_comeback});
            this.ms_menu.Location = new System.Drawing.Point(0, 0);
            this.ms_menu.Name = "ms_menu";
            this.ms_menu.Size = new System.Drawing.Size(843, 24);
            this.ms_menu.TabIndex = 0;
            this.ms_menu.Text = "menuStrip1";
            // 
            // ms_delete
            // 
            this.ms_delete.Name = "ms_delete";
            this.ms_delete.Size = new System.Drawing.Size(63, 20);
            this.ms_delete.Text = "Удалить";
            // 
            // ms_comeback
            // 
            this.ms_comeback.Name = "ms_comeback";
            this.ms_comeback.Size = new System.Drawing.Size(119, 20);
            this.ms_comeback.Text = "Вернуться в меню";
            // 
            // dgv_info
            // 
            this.dgv_info.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_info.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_login,
            this.col_password,
            this.col_fullName,
            this.col_yearOfBirth,
            this.col_carModel,
            this.col_licensePlate,
            this.col_yearOfCar,
            this.col_statusVIP});
            this.dgv_info.Location = new System.Drawing.Point(0, 27);
            this.dgv_info.Name = "dgv_info";
            this.dgv_info.Size = new System.Drawing.Size(843, 394);
            this.dgv_info.TabIndex = 1;
            // 
            // col_login
            // 
            this.col_login.HeaderText = "Логин";
            this.col_login.Name = "col_login";
            // 
            // col_password
            // 
            this.col_password.HeaderText = "Пароль";
            this.col_password.Name = "col_password";
            // 
            // col_fullName
            // 
            this.col_fullName.HeaderText = "ФИО";
            this.col_fullName.Name = "col_fullName";
            // 
            // col_yearOfBirth
            // 
            this.col_yearOfBirth.HeaderText = "Год рождения";
            this.col_yearOfBirth.Name = "col_yearOfBirth";
            // 
            // col_carModel
            // 
            this.col_carModel.HeaderText = "Модель автомобиля";
            this.col_carModel.Name = "col_carModel";
            // 
            // col_licensePlate
            // 
            this.col_licensePlate.HeaderText = "Номер автомобиля";
            this.col_licensePlate.Name = "col_licensePlate";
            // 
            // col_yearOfCar
            // 
            this.col_yearOfCar.HeaderText = "Год выпуска автомобиля";
            this.col_yearOfCar.Name = "col_yearOfCar";
            // 
            // col_statusVIP
            // 
            this.col_statusVIP.HeaderText = "Статус VIP";
            this.col_statusVIP.Name = "col_statusVIP";
            // 
            // BaseClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(843, 421);
            this.Controls.Add(this.dgv_info);
            this.Controls.Add(this.ms_menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_menu;
            this.Name = "BaseClientsForm";
            this.Text = "Присвоить статус VIP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaseClientsForm_FormClosing);
            this.Load += new System.EventHandler(this.BaseClientsForm_Load);
            this.ms_menu.ResumeLayout(false);
            this.ms_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_menu;
        private System.Windows.Forms.ToolStripMenuItem ms_delete;
        private System.Windows.Forms.DataGridView dgv_info;
        private System.Windows.Forms.ToolStripMenuItem ms_comeback;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_login;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_yearOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_carModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_licensePlate;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_yearOfCar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_statusVIP;
    }
}