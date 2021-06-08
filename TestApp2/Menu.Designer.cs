
namespace WorkSheetApp
{
    partial class Form_Menu
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
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.lbl_NameTitle = new System.Windows.Forms.Label();
            this.lbl_DateTitle = new System.Windows.Forms.Label();
            this.dPicker_Date = new System.Windows.Forms.DateTimePicker();
            this.btn_CreateUser = new System.Windows.Forms.Button();
            this.btn_OpenWorkSheet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_Name.Location = new System.Drawing.Point(36, 60);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(234, 29);
            this.txtBox_Name.TabIndex = 0;
            // 
            // lbl_NameTitle
            // 
            this.lbl_NameTitle.AutoSize = true;
            this.lbl_NameTitle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_NameTitle.Location = new System.Drawing.Point(36, 36);
            this.lbl_NameTitle.Name = "lbl_NameTitle";
            this.lbl_NameTitle.Size = new System.Drawing.Size(72, 21);
            this.lbl_NameTitle.TabIndex = 1;
            this.lbl_NameTitle.Text = "ユーザー名";
            // 
            // lbl_DateTitle
            // 
            this.lbl_DateTitle.AutoSize = true;
            this.lbl_DateTitle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_DateTitle.Location = new System.Drawing.Point(36, 123);
            this.lbl_DateTitle.Name = "lbl_DateTitle";
            this.lbl_DateTitle.Size = new System.Drawing.Size(90, 21);
            this.lbl_DateTitle.TabIndex = 2;
            this.lbl_DateTitle.Text = "作業予定日";
            // 
            // dPicker_Date
            // 
            this.dPicker_Date.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dPicker_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dPicker_Date.Location = new System.Drawing.Point(36, 147);
            this.dPicker_Date.Name = "dPicker_Date";
            this.dPicker_Date.Size = new System.Drawing.Size(234, 29);
            this.dPicker_Date.TabIndex = 4;
            // 
            // btn_CreateUser
            // 
            this.btn_CreateUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_CreateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CreateUser.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CreateUser.Location = new System.Drawing.Point(335, 48);
            this.btn_CreateUser.Name = "btn_CreateUser";
            this.btn_CreateUser.Size = new System.Drawing.Size(147, 55);
            this.btn_CreateUser.TabIndex = 5;
            this.btn_CreateUser.Text = "ユーザー登録";
            this.btn_CreateUser.UseVisualStyleBackColor = false;
            this.btn_CreateUser.Click += new System.EventHandler(this.btn_CreateUser_Click);
            // 
            // btn_OpenWorkSheet
            // 
            this.btn_OpenWorkSheet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_OpenWorkSheet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OpenWorkSheet.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_OpenWorkSheet.Location = new System.Drawing.Point(335, 136);
            this.btn_OpenWorkSheet.Name = "btn_OpenWorkSheet";
            this.btn_OpenWorkSheet.Size = new System.Drawing.Size(147, 55);
            this.btn_OpenWorkSheet.TabIndex = 6;
            this.btn_OpenWorkSheet.Text = "作業予定表を開く";
            this.btn_OpenWorkSheet.UseVisualStyleBackColor = false;
            this.btn_OpenWorkSheet.Click += new System.EventHandler(this.btn_OpenWorkSheet_Click);
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 240);
            this.Controls.Add(this.btn_OpenWorkSheet);
            this.Controls.Add(this.btn_CreateUser);
            this.Controls.Add(this.dPicker_Date);
            this.Controls.Add(this.lbl_DateTitle);
            this.Controls.Add(this.lbl_NameTitle);
            this.Controls.Add(this.txtBox_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Menu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "作業予定表メニュー";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.Label lbl_NameTitle;
        private System.Windows.Forms.Label lbl_DateTitle;
        private System.Windows.Forms.DateTimePicker dPicker_Date;
        private System.Windows.Forms.Button btn_CreateUser;
        private System.Windows.Forms.Button btn_OpenWorkSheet;
    }
}