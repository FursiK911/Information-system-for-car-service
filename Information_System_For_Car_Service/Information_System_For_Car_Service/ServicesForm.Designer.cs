namespace Information_System_For_Car_Service
{
    partial class ServicesForm
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
            this.dgv_service = new System.Windows.Forms.DataGridView();
            this.col_services = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_priceForVIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_leadTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ms_service = new System.Windows.Forms.MenuStrip();
            this.ms_toOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_discount = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_comeback = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_service)).BeginInit();
            this.ms_service.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_service
            // 
            this.dgv_service.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_service.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_service.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_services,
            this.col_price,
            this.col_priceForVIP,
            this.col_leadTime});
            this.dgv_service.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgv_service.Location = new System.Drawing.Point(12, 26);
            this.dgv_service.Name = "dgv_service";
            this.dgv_service.Size = new System.Drawing.Size(532, 320);
            this.dgv_service.TabIndex = 0;
            // 
            // col_services
            // 
            this.col_services.HeaderText = "Услуги";
            this.col_services.Name = "col_services";
            this.col_services.ReadOnly = true;
            // 
            // col_price
            // 
            this.col_price.HeaderText = "Цена";
            this.col_price.Name = "col_price";
            this.col_price.ReadOnly = true;
            // 
            // col_priceForVIP
            // 
            this.col_priceForVIP.HeaderText = "Цена для VIP";
            this.col_priceForVIP.Name = "col_priceForVIP";
            this.col_priceForVIP.ReadOnly = true;
            // 
            // col_leadTime
            // 
            this.col_leadTime.HeaderText = "Время выполнения";
            this.col_leadTime.Name = "col_leadTime";
            this.col_leadTime.ReadOnly = true;
            // 
            // ms_service
            // 
            this.ms_service.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_toOrder,
            this.ms_discount,
            this.ms_comeback});
            this.ms_service.Location = new System.Drawing.Point(0, 0);
            this.ms_service.Name = "ms_service";
            this.ms_service.Size = new System.Drawing.Size(556, 24);
            this.ms_service.TabIndex = 1;
            this.ms_service.Text = "menuStrip1";
            // 
            // ms_toOrder
            // 
            this.ms_toOrder.Name = "ms_toOrder";
            this.ms_toOrder.Size = new System.Drawing.Size(66, 20);
            this.ms_toOrder.Text = "Заказать";
            this.ms_toOrder.Click += new System.EventHandler(this.ms_toOrder_Click);
            // 
            // ms_discount
            // 
            this.ms_discount.Name = "ms_discount";
            this.ms_discount.Size = new System.Drawing.Size(163, 20);
            this.ms_discount.Text = "Установить скидку для VIP";
            this.ms_discount.Click += new System.EventHandler(this.ms_discount_Click);
            // 
            // ms_comeback
            // 
            this.ms_comeback.Name = "ms_comeback";
            this.ms_comeback.Size = new System.Drawing.Size(166, 20);
            this.ms_comeback.Text = "Вернуться в главное меню";
            this.ms_comeback.Click += new System.EventHandler(this.ms_comeback_Click);
            // 
            // ServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 358);
            this.Controls.Add(this.dgv_service);
            this.Controls.Add(this.ms_service);
            this.MainMenuStrip = this.ms_service;
            this.Name = "ServicesForm";
            this.Text = "Услуги";
            this.Load += new System.EventHandler(this.Services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_service)).EndInit();
            this.ms_service.ResumeLayout(false);
            this.ms_service.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_service;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_services;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_priceForVIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_leadTime;
        private System.Windows.Forms.MenuStrip ms_service;
        private System.Windows.Forms.ToolStripMenuItem ms_toOrder;
        private System.Windows.Forms.ToolStripMenuItem ms_comeback;
        private System.Windows.Forms.ToolStripMenuItem ms_discount;
    }
}