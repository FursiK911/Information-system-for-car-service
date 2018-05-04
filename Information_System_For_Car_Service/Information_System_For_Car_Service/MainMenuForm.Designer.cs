namespace Information_System_For_Car_Service
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.bt_services = new System.Windows.Forms.Button();
            this.bt_currentOrders = new System.Windows.Forms.Button();
            this.lb_fullName = new System.Windows.Forms.Label();
            this.bt_registration = new System.Windows.Forms.Button();
            this.bt_vip = new System.Windows.Forms.Button();
            this.bt_schedule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_services
            // 
            this.bt_services.Location = new System.Drawing.Point(327, 215);
            this.bt_services.Name = "bt_services";
            this.bt_services.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_services.Size = new System.Drawing.Size(159, 33);
            this.bt_services.TabIndex = 0;
            this.bt_services.Text = "Услуги";
            this.bt_services.UseVisualStyleBackColor = true;
            this.bt_services.Click += new System.EventHandler(this.bt_services_Click);
            // 
            // bt_currentOrders
            // 
            this.bt_currentOrders.Location = new System.Drawing.Point(327, 254);
            this.bt_currentOrders.Name = "bt_currentOrders";
            this.bt_currentOrders.Size = new System.Drawing.Size(159, 33);
            this.bt_currentOrders.TabIndex = 1;
            this.bt_currentOrders.Text = "Текущие заказы";
            this.bt_currentOrders.UseVisualStyleBackColor = true;
            this.bt_currentOrders.Click += new System.EventHandler(this.bt_currentOrders_Click);
            // 
            // lb_fullName
            // 
            this.lb_fullName.AutoSize = true;
            this.lb_fullName.BackColor = System.Drawing.SystemColors.Window;
            this.lb_fullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_fullName.Location = new System.Drawing.Point(12, 26);
            this.lb_fullName.Name = "lb_fullName";
            this.lb_fullName.Size = new System.Drawing.Size(150, 16);
            this.lb_fullName.TabIndex = 2;
            this.lb_fullName.Text = "Приветствуем вас,";
            // 
            // bt_registration
            // 
            this.bt_registration.Location = new System.Drawing.Point(12, 188);
            this.bt_registration.Name = "bt_registration";
            this.bt_registration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_registration.Size = new System.Drawing.Size(159, 44);
            this.bt_registration.TabIndex = 3;
            this.bt_registration.Text = "Зарегистрировать нового сотрудника";
            this.bt_registration.UseVisualStyleBackColor = true;
            // 
            // bt_vip
            // 
            this.bt_vip.Location = new System.Drawing.Point(12, 238);
            this.bt_vip.Name = "bt_vip";
            this.bt_vip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_vip.Size = new System.Drawing.Size(159, 49);
            this.bt_vip.TabIndex = 4;
            this.bt_vip.Text = "Присвоить клиенту статус VIP";
            this.bt_vip.UseVisualStyleBackColor = true;
            // 
            // bt_schedule
            // 
            this.bt_schedule.Location = new System.Drawing.Point(12, 138);
            this.bt_schedule.Name = "bt_schedule";
            this.bt_schedule.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_schedule.Size = new System.Drawing.Size(159, 44);
            this.bt_schedule.TabIndex = 5;
            this.bt_schedule.Text = "График работы";
            this.bt_schedule.UseVisualStyleBackColor = true;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(498, 310);
            this.Controls.Add(this.bt_schedule);
            this.Controls.Add(this.bt_vip);
            this.Controls.Add(this.bt_registration);
            this.Controls.Add(this.lb_fullName);
            this.Controls.Add(this.bt_currentOrders);
            this.Controls.Add(this.bt_services);
            this.Name = "MainMenuForm";
            this.Text = "Главное меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_services;
        private System.Windows.Forms.Button bt_currentOrders;
        private System.Windows.Forms.Label lb_fullName;
        private System.Windows.Forms.Button bt_registration;
        private System.Windows.Forms.Button bt_vip;
        private System.Windows.Forms.Button bt_schedule;
    }
}