﻿namespace Information_System_For_Car_Service
{
    partial class StatusVIPForm
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
            this.cb_users = new System.Windows.Forms.ComboBox();
            this.lb_listUsers = new System.Windows.Forms.Label();
            this.bt_ok = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.cb_vipStatus = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cb_users
            // 
            this.cb_users.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_users.FormattingEnabled = true;
            this.cb_users.Location = new System.Drawing.Point(115, 27);
            this.cb_users.Name = "cb_users";
            this.cb_users.Size = new System.Drawing.Size(182, 21);
            this.cb_users.TabIndex = 0;
            // 
            // lb_listUsers
            // 
            this.lb_listUsers.AutoSize = true;
            this.lb_listUsers.Location = new System.Drawing.Point(112, 9);
            this.lb_listUsers.Name = "lb_listUsers";
            this.lb_listUsers.Size = new System.Drawing.Size(80, 13);
            this.lb_listUsers.TabIndex = 1;
            this.lb_listUsers.Text = "Пользователи";
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(12, 78);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(95, 42);
            this.bt_ok.TabIndex = 2;
            this.bt_ok.Text = "Подтвердить";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(202, 78);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(95, 42);
            this.bt_cancel.TabIndex = 3;
            this.bt_cancel.Text = "Отменить";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // cb_vipStatus
            // 
            this.cb_vipStatus.AutoSize = true;
            this.cb_vipStatus.Location = new System.Drawing.Point(12, 29);
            this.cb_vipStatus.Name = "cb_vipStatus";
            this.cb_vipStatus.Size = new System.Drawing.Size(79, 17);
            this.cb_vipStatus.TabIndex = 4;
            this.cb_vipStatus.Text = "VIP статус";
            this.cb_vipStatus.UseVisualStyleBackColor = true;
            // 
            // StatusVIPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 132);
            this.Controls.Add(this.cb_vipStatus);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.lb_listUsers);
            this.Controls.Add(this.cb_users);
            this.Name = "StatusVIPForm";
            this.Text = "Присвоить статус VIP";
            this.Load += new System.EventHandler(this.StatusVIPForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_users;
        private System.Windows.Forms.Label lb_listUsers;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.CheckBox cb_vipStatus;
    }
}