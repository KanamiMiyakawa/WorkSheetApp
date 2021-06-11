
namespace WorkSheetApp
{
    partial class DataBaseSettings
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
            this.lbl_oldServerNameTitle = new System.Windows.Forms.Label();
            this.lbl_oldServerName = new System.Windows.Forms.Label();
            this.group_oldSettings = new System.Windows.Forms.GroupBox();
            this.lbl_oldUserNameTitle = new System.Windows.Forms.Label();
            this.lbl_oldUserName = new System.Windows.Forms.Label();
            this.lbl_oldPasswordTitle = new System.Windows.Forms.Label();
            this.lbl_oldPassword = new System.Windows.Forms.Label();
            this.lbl_oldDBNameTitle = new System.Windows.Forms.Label();
            this.lbl_oldDBName = new System.Windows.Forms.Label();
            this.group_newSettings = new System.Windows.Forms.GroupBox();
            this.lbl_newDBNameTitle = new System.Windows.Forms.Label();
            this.lbl_newPasswordTitle = new System.Windows.Forms.Label();
            this.lbl_newUserNameTitle = new System.Windows.Forms.Label();
            this.lbl_newServerNameTitle = new System.Windows.Forms.Label();
            this.txtBox_newServerName = new System.Windows.Forms.TextBox();
            this.txtBox_newUserName = new System.Windows.Forms.TextBox();
            this.txtBox_newPassword = new System.Windows.Forms.TextBox();
            this.txtBox_newDBName = new System.Windows.Forms.TextBox();
            this.btn_tryConnect = new System.Windows.Forms.Button();
            this.btn_saveSetting = new System.Windows.Forms.Button();
            this.btn_closeWindow = new System.Windows.Forms.Button();
            this.group_oldSettings.SuspendLayout();
            this.group_newSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_oldServerNameTitle
            // 
            this.lbl_oldServerNameTitle.AutoSize = true;
            this.lbl_oldServerNameTitle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_oldServerNameTitle.Location = new System.Drawing.Point(28, 38);
            this.lbl_oldServerNameTitle.Name = "lbl_oldServerNameTitle";
            this.lbl_oldServerNameTitle.Size = new System.Drawing.Size(72, 21);
            this.lbl_oldServerNameTitle.TabIndex = 1;
            this.lbl_oldServerNameTitle.Text = "サーバー名";
            // 
            // lbl_oldServerName
            // 
            this.lbl_oldServerName.AutoSize = true;
            this.lbl_oldServerName.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_oldServerName.Location = new System.Drawing.Point(28, 59);
            this.lbl_oldServerName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.lbl_oldServerName.Name = "lbl_oldServerName";
            this.lbl_oldServerName.Size = new System.Drawing.Size(117, 21);
            this.lbl_oldServerName.TabIndex = 2;
            this.lbl_oldServerName.Text = "DBServerName";
            // 
            // group_oldSettings
            // 
            this.group_oldSettings.BackColor = System.Drawing.SystemColors.Control;
            this.group_oldSettings.Controls.Add(this.lbl_oldDBName);
            this.group_oldSettings.Controls.Add(this.lbl_oldDBNameTitle);
            this.group_oldSettings.Controls.Add(this.lbl_oldPassword);
            this.group_oldSettings.Controls.Add(this.lbl_oldPasswordTitle);
            this.group_oldSettings.Controls.Add(this.lbl_oldUserName);
            this.group_oldSettings.Controls.Add(this.lbl_oldUserNameTitle);
            this.group_oldSettings.Controls.Add(this.lbl_oldServerName);
            this.group_oldSettings.Controls.Add(this.lbl_oldServerNameTitle);
            this.group_oldSettings.Location = new System.Drawing.Point(44, 40);
            this.group_oldSettings.Name = "group_oldSettings";
            this.group_oldSettings.Size = new System.Drawing.Size(295, 335);
            this.group_oldSettings.TabIndex = 3;
            this.group_oldSettings.TabStop = false;
            this.group_oldSettings.Text = "現在の設定";
            // 
            // lbl_oldUserNameTitle
            // 
            this.lbl_oldUserNameTitle.AutoSize = true;
            this.lbl_oldUserNameTitle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_oldUserNameTitle.Location = new System.Drawing.Point(28, 110);
            this.lbl_oldUserNameTitle.Name = "lbl_oldUserNameTitle";
            this.lbl_oldUserNameTitle.Size = new System.Drawing.Size(72, 21);
            this.lbl_oldUserNameTitle.TabIndex = 3;
            this.lbl_oldUserNameTitle.Text = "ユーザー名";
            // 
            // lbl_oldUserName
            // 
            this.lbl_oldUserName.AutoSize = true;
            this.lbl_oldUserName.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_oldUserName.Location = new System.Drawing.Point(28, 131);
            this.lbl_oldUserName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.lbl_oldUserName.Name = "lbl_oldUserName";
            this.lbl_oldUserName.Size = new System.Drawing.Size(104, 21);
            this.lbl_oldUserName.TabIndex = 4;
            this.lbl_oldUserName.Text = "DBUserName";
            // 
            // lbl_oldPasswordTitle
            // 
            this.lbl_oldPasswordTitle.AutoSize = true;
            this.lbl_oldPasswordTitle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_oldPasswordTitle.Location = new System.Drawing.Point(28, 182);
            this.lbl_oldPasswordTitle.Name = "lbl_oldPasswordTitle";
            this.lbl_oldPasswordTitle.Size = new System.Drawing.Size(68, 21);
            this.lbl_oldPasswordTitle.TabIndex = 5;
            this.lbl_oldPasswordTitle.Text = "パスワード";
            // 
            // lbl_oldPassword
            // 
            this.lbl_oldPassword.AutoSize = true;
            this.lbl_oldPassword.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_oldPassword.Location = new System.Drawing.Point(28, 203);
            this.lbl_oldPassword.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.lbl_oldPassword.Name = "lbl_oldPassword";
            this.lbl_oldPassword.Size = new System.Drawing.Size(66, 21);
            this.lbl_oldPassword.TabIndex = 6;
            this.lbl_oldPassword.Text = "********";
            // 
            // lbl_oldDBNameTitle
            // 
            this.lbl_oldDBNameTitle.AutoSize = true;
            this.lbl_oldDBNameTitle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_oldDBNameTitle.Location = new System.Drawing.Point(28, 254);
            this.lbl_oldDBNameTitle.Name = "lbl_oldDBNameTitle";
            this.lbl_oldDBNameTitle.Size = new System.Drawing.Size(96, 21);
            this.lbl_oldDBNameTitle.TabIndex = 7;
            this.lbl_oldDBNameTitle.Text = "データベース名";
            // 
            // lbl_oldDBName
            // 
            this.lbl_oldDBName.AutoSize = true;
            this.lbl_oldDBName.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_oldDBName.Location = new System.Drawing.Point(28, 275);
            this.lbl_oldDBName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.lbl_oldDBName.Name = "lbl_oldDBName";
            this.lbl_oldDBName.Size = new System.Drawing.Size(72, 21);
            this.lbl_oldDBName.TabIndex = 8;
            this.lbl_oldDBName.Text = "DBName";
            // 
            // group_newSettings
            // 
            this.group_newSettings.BackColor = System.Drawing.SystemColors.Control;
            this.group_newSettings.Controls.Add(this.txtBox_newDBName);
            this.group_newSettings.Controls.Add(this.txtBox_newPassword);
            this.group_newSettings.Controls.Add(this.txtBox_newUserName);
            this.group_newSettings.Controls.Add(this.txtBox_newServerName);
            this.group_newSettings.Controls.Add(this.lbl_newDBNameTitle);
            this.group_newSettings.Controls.Add(this.lbl_newPasswordTitle);
            this.group_newSettings.Controls.Add(this.lbl_newUserNameTitle);
            this.group_newSettings.Controls.Add(this.lbl_newServerNameTitle);
            this.group_newSettings.Location = new System.Drawing.Point(405, 40);
            this.group_newSettings.Name = "group_newSettings";
            this.group_newSettings.Size = new System.Drawing.Size(295, 335);
            this.group_newSettings.TabIndex = 9;
            this.group_newSettings.TabStop = false;
            this.group_newSettings.Text = "新しい設定";
            // 
            // lbl_newDBNameTitle
            // 
            this.lbl_newDBNameTitle.AutoSize = true;
            this.lbl_newDBNameTitle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_newDBNameTitle.Location = new System.Drawing.Point(28, 254);
            this.lbl_newDBNameTitle.Name = "lbl_newDBNameTitle";
            this.lbl_newDBNameTitle.Size = new System.Drawing.Size(96, 21);
            this.lbl_newDBNameTitle.TabIndex = 7;
            this.lbl_newDBNameTitle.Text = "データベース名";
            // 
            // lbl_newPasswordTitle
            // 
            this.lbl_newPasswordTitle.AutoSize = true;
            this.lbl_newPasswordTitle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_newPasswordTitle.Location = new System.Drawing.Point(28, 182);
            this.lbl_newPasswordTitle.Name = "lbl_newPasswordTitle";
            this.lbl_newPasswordTitle.Size = new System.Drawing.Size(68, 21);
            this.lbl_newPasswordTitle.TabIndex = 5;
            this.lbl_newPasswordTitle.Text = "パスワード";
            // 
            // lbl_newUserNameTitle
            // 
            this.lbl_newUserNameTitle.AutoSize = true;
            this.lbl_newUserNameTitle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_newUserNameTitle.Location = new System.Drawing.Point(28, 110);
            this.lbl_newUserNameTitle.Name = "lbl_newUserNameTitle";
            this.lbl_newUserNameTitle.Size = new System.Drawing.Size(72, 21);
            this.lbl_newUserNameTitle.TabIndex = 3;
            this.lbl_newUserNameTitle.Text = "ユーザー名";
            // 
            // lbl_newServerNameTitle
            // 
            this.lbl_newServerNameTitle.AutoSize = true;
            this.lbl_newServerNameTitle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_newServerNameTitle.Location = new System.Drawing.Point(28, 38);
            this.lbl_newServerNameTitle.Name = "lbl_newServerNameTitle";
            this.lbl_newServerNameTitle.Size = new System.Drawing.Size(72, 21);
            this.lbl_newServerNameTitle.TabIndex = 1;
            this.lbl_newServerNameTitle.Text = "サーバー名";
            // 
            // txtBox_newServerName
            // 
            this.txtBox_newServerName.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_newServerName.Location = new System.Drawing.Point(28, 62);
            this.txtBox_newServerName.Name = "txtBox_newServerName";
            this.txtBox_newServerName.Size = new System.Drawing.Size(238, 29);
            this.txtBox_newServerName.TabIndex = 9;
            // 
            // txtBox_newUserName
            // 
            this.txtBox_newUserName.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_newUserName.Location = new System.Drawing.Point(28, 134);
            this.txtBox_newUserName.Name = "txtBox_newUserName";
            this.txtBox_newUserName.Size = new System.Drawing.Size(238, 29);
            this.txtBox_newUserName.TabIndex = 10;
            // 
            // txtBox_newPassword
            // 
            this.txtBox_newPassword.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_newPassword.Location = new System.Drawing.Point(28, 206);
            this.txtBox_newPassword.Name = "txtBox_newPassword";
            this.txtBox_newPassword.Size = new System.Drawing.Size(238, 29);
            this.txtBox_newPassword.TabIndex = 11;
            // 
            // txtBox_newDBName
            // 
            this.txtBox_newDBName.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_newDBName.Location = new System.Drawing.Point(28, 278);
            this.txtBox_newDBName.Name = "txtBox_newDBName";
            this.txtBox_newDBName.Size = new System.Drawing.Size(238, 29);
            this.txtBox_newDBName.TabIndex = 12;
            // 
            // btn_tryConnect
            // 
            this.btn_tryConnect.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_tryConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_tryConnect.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_tryConnect.Location = new System.Drawing.Point(760, 90);
            this.btn_tryConnect.Name = "btn_tryConnect";
            this.btn_tryConnect.Size = new System.Drawing.Size(147, 51);
            this.btn_tryConnect.TabIndex = 10;
            this.btn_tryConnect.Text = "接続確認";
            this.btn_tryConnect.UseVisualStyleBackColor = false;
            // 
            // btn_saveSetting
            // 
            this.btn_saveSetting.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_saveSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saveSetting.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_saveSetting.Location = new System.Drawing.Point(760, 183);
            this.btn_saveSetting.Name = "btn_saveSetting";
            this.btn_saveSetting.Size = new System.Drawing.Size(147, 51);
            this.btn_saveSetting.TabIndex = 11;
            this.btn_saveSetting.Text = "設定の変更";
            this.btn_saveSetting.UseVisualStyleBackColor = false;
            // 
            // btn_closeWindow
            // 
            this.btn_closeWindow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_closeWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_closeWindow.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_closeWindow.Location = new System.Drawing.Point(760, 279);
            this.btn_closeWindow.Name = "btn_closeWindow";
            this.btn_closeWindow.Size = new System.Drawing.Size(147, 51);
            this.btn_closeWindow.TabIndex = 12;
            this.btn_closeWindow.Text = "変更せずに閉じる";
            this.btn_closeWindow.UseVisualStyleBackColor = false;
            // 
            // DataBaseSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 422);
            this.Controls.Add(this.btn_closeWindow);
            this.Controls.Add(this.btn_saveSetting);
            this.Controls.Add(this.btn_tryConnect);
            this.Controls.Add(this.group_newSettings);
            this.Controls.Add(this.group_oldSettings);
            this.Name = "DataBaseSettings";
            this.Text = "データベース設定";
            this.group_oldSettings.ResumeLayout(false);
            this.group_oldSettings.PerformLayout();
            this.group_newSettings.ResumeLayout(false);
            this.group_newSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_oldServerNameTitle;
        private System.Windows.Forms.Label lbl_oldServerName;
        private System.Windows.Forms.GroupBox group_oldSettings;
        private System.Windows.Forms.Label lbl_oldUserNameTitle;
        private System.Windows.Forms.Label lbl_oldDBName;
        private System.Windows.Forms.Label lbl_oldDBNameTitle;
        private System.Windows.Forms.Label lbl_oldPassword;
        private System.Windows.Forms.Label lbl_oldPasswordTitle;
        private System.Windows.Forms.Label lbl_oldUserName;
        private System.Windows.Forms.GroupBox group_newSettings;
        private System.Windows.Forms.TextBox txtBox_newDBName;
        private System.Windows.Forms.TextBox txtBox_newPassword;
        private System.Windows.Forms.TextBox txtBox_newUserName;
        private System.Windows.Forms.TextBox txtBox_newServerName;
        private System.Windows.Forms.Label lbl_newDBNameTitle;
        private System.Windows.Forms.Label lbl_newPasswordTitle;
        private System.Windows.Forms.Label lbl_newUserNameTitle;
        private System.Windows.Forms.Label lbl_newServerNameTitle;
        private System.Windows.Forms.Button btn_tryConnect;
        private System.Windows.Forms.Button btn_saveSetting;
        private System.Windows.Forms.Button btn_closeWindow;
    }
}