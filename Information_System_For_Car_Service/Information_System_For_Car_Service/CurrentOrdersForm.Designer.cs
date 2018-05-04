﻿namespace Information_System_For_Car_Service
{
    partial class CurrentOrdersForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.вернутьсяВМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.col_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_priceForVIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_leadTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_service)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.col_order,
            this.col_price,
            this.col_priceForVIP,
            this.col_leadTime,
            this.col_status,
            this.col_customer});
            this.dgv_service.Location = new System.Drawing.Point(12, 24);
            this.dgv_service.Name = "dgv_service";
            this.dgv_service.Size = new System.Drawing.Size(651, 313);
            this.dgv_service.TabIndex = 0;
            this.dgv_service.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_service_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вернутьсяВМенюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(675, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // вернутьсяВМенюToolStripMenuItem
            // 
            this.вернутьсяВМенюToolStripMenuItem.Name = "вернутьсяВМенюToolStripMenuItem";
            this.вернутьсяВМенюToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.вернутьсяВМенюToolStripMenuItem.Text = "Вернуться в меню";
            this.вернутьсяВМенюToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяВМенюToolStripMenuItem_Click);
            // 
            // col_order
            // 
            this.col_order.FillWeight = 253.8071F;
            this.col_order.HeaderText = "Услуги";
            this.col_order.MinimumWidth = 80;
            this.col_order.Name = "col_order";
            this.col_order.ReadOnly = true;
            // 
            // col_price
            // 
            this.col_price.FillWeight = 61.54823F;
            this.col_price.HeaderText = "Цена";
            this.col_price.Name = "col_price";
            this.col_price.ReadOnly = true;
            // 
            // col_priceForVIP
            // 
            this.col_priceForVIP.FillWeight = 61.54823F;
            this.col_priceForVIP.HeaderText = "Цена для VIP";
            this.col_priceForVIP.Name = "col_priceForVIP";
            this.col_priceForVIP.ReadOnly = true;
            // 
            // col_leadTime
            // 
            this.col_leadTime.FillWeight = 61.54823F;
            this.col_leadTime.HeaderText = "Время выполнения";
            this.col_leadTime.Name = "col_leadTime";
            this.col_leadTime.ReadOnly = true;
            // 
            // col_status
            // 
            this.col_status.FillWeight = 61.54823F;
            this.col_status.HeaderText = "Статус";
            this.col_status.Name = "col_status";
            this.col_status.ReadOnly = true;
            // 
            // col_customer
            // 
            this.col_customer.HeaderText = "Заказчик";
            this.col_customer.Name = "col_customer";
            this.col_customer.ReadOnly = true;
            // 
            // CurrentOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 347);
            this.Controls.Add(this.dgv_service);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CurrentOrdersForm";
            this.Text = "Текущие заказы";
            this.Load += new System.EventHandler(this.CurrentOrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_service)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_service;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяВМенюToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_priceForVIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_leadTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_customer;
    }
}