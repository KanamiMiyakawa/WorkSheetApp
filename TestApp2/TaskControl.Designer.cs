
namespace WorkSheetApp
{
    partial class TaskControl
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_GaiyouTitle = new System.Windows.Forms.Label();
            this.txtBox_Gaiyou = new System.Windows.Forms.TextBox();
            this.txtBox_Meisai = new System.Windows.Forms.TextBox();
            this.lbl_MeisaiTitle = new System.Windows.Forms.Label();
            this.lbl_ScheduleTitle = new System.Windows.Forms.Label();
            this.time_PlanTimeStart = new System.Windows.Forms.DateTimePicker();
            this.lbl_mark1 = new System.Windows.Forms.Label();
            this.time_PlanTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.time_ResultTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.lbl_mark2 = new System.Windows.Forms.Label();
            this.time_ResultTimeStart = new System.Windows.Forms.DateTimePicker();
            this.lbl_ResultTitle = new System.Windows.Forms.Label();
            this.check_EndFlag = new System.Windows.Forms.CheckBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_HED_ID = new System.Windows.Forms.Label();
            this.lbl_InsertOrUpdate = new System.Windows.Forms.Label();
            this.lbl_DTL_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Title.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Title.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title.Location = new System.Drawing.Point(62, 29);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(383, 37);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "作業編集画面";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_GaiyouTitle
            // 
            this.lbl_GaiyouTitle.AutoSize = true;
            this.lbl_GaiyouTitle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_GaiyouTitle.Location = new System.Drawing.Point(72, 96);
            this.lbl_GaiyouTitle.Name = "lbl_GaiyouTitle";
            this.lbl_GaiyouTitle.Size = new System.Drawing.Size(74, 21);
            this.lbl_GaiyouTitle.TabIndex = 2;
            this.lbl_GaiyouTitle.Text = "作業概要";
            // 
            // txtBox_Gaiyou
            // 
            this.txtBox_Gaiyou.Location = new System.Drawing.Point(76, 120);
            this.txtBox_Gaiyou.Name = "txtBox_Gaiyou";
            this.txtBox_Gaiyou.Size = new System.Drawing.Size(355, 23);
            this.txtBox_Gaiyou.TabIndex = 3;
            // 
            // txtBox_Meisai
            // 
            this.txtBox_Meisai.Location = new System.Drawing.Point(76, 185);
            this.txtBox_Meisai.Multiline = true;
            this.txtBox_Meisai.Name = "txtBox_Meisai";
            this.txtBox_Meisai.Size = new System.Drawing.Size(355, 46);
            this.txtBox_Meisai.TabIndex = 5;
            // 
            // lbl_MeisaiTitle
            // 
            this.lbl_MeisaiTitle.AutoSize = true;
            this.lbl_MeisaiTitle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_MeisaiTitle.Location = new System.Drawing.Point(72, 161);
            this.lbl_MeisaiTitle.Name = "lbl_MeisaiTitle";
            this.lbl_MeisaiTitle.Size = new System.Drawing.Size(74, 21);
            this.lbl_MeisaiTitle.TabIndex = 4;
            this.lbl_MeisaiTitle.Text = "作業詳細";
            // 
            // lbl_ScheduleTitle
            // 
            this.lbl_ScheduleTitle.AutoSize = true;
            this.lbl_ScheduleTitle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ScheduleTitle.Location = new System.Drawing.Point(72, 249);
            this.lbl_ScheduleTitle.Name = "lbl_ScheduleTitle";
            this.lbl_ScheduleTitle.Size = new System.Drawing.Size(74, 21);
            this.lbl_ScheduleTitle.TabIndex = 6;
            this.lbl_ScheduleTitle.Text = "作業予定";
            // 
            // time_PlanTimeStart
            // 
            this.time_PlanTimeStart.CustomFormat = "HH:mm";
            this.time_PlanTimeStart.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time_PlanTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time_PlanTimeStart.Location = new System.Drawing.Point(76, 273);
            this.time_PlanTimeStart.Name = "time_PlanTimeStart";
            this.time_PlanTimeStart.ShowUpDown = true;
            this.time_PlanTimeStart.Size = new System.Drawing.Size(91, 29);
            this.time_PlanTimeStart.TabIndex = 7;
            // 
            // lbl_mark1
            // 
            this.lbl_mark1.AutoSize = true;
            this.lbl_mark1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_mark1.Location = new System.Drawing.Point(173, 279);
            this.lbl_mark1.Name = "lbl_mark1";
            this.lbl_mark1.Size = new System.Drawing.Size(21, 21);
            this.lbl_mark1.TabIndex = 8;
            this.lbl_mark1.Text = "~";
            // 
            // time_PlanTimeEnd
            // 
            this.time_PlanTimeEnd.CustomFormat = "HH:mm";
            this.time_PlanTimeEnd.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time_PlanTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time_PlanTimeEnd.Location = new System.Drawing.Point(198, 273);
            this.time_PlanTimeEnd.Name = "time_PlanTimeEnd";
            this.time_PlanTimeEnd.ShowUpDown = true;
            this.time_PlanTimeEnd.Size = new System.Drawing.Size(91, 29);
            this.time_PlanTimeEnd.TabIndex = 9;
            // 
            // time_ResultTimeEnd
            // 
            this.time_ResultTimeEnd.CustomFormat = "HH:mm";
            this.time_ResultTimeEnd.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time_ResultTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time_ResultTimeEnd.Location = new System.Drawing.Point(198, 340);
            this.time_ResultTimeEnd.Name = "time_ResultTimeEnd";
            this.time_ResultTimeEnd.ShowCheckBox = true;
            this.time_ResultTimeEnd.ShowUpDown = true;
            this.time_ResultTimeEnd.Size = new System.Drawing.Size(91, 29);
            this.time_ResultTimeEnd.TabIndex = 13;
            // 
            // lbl_mark2
            // 
            this.lbl_mark2.AutoSize = true;
            this.lbl_mark2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_mark2.Location = new System.Drawing.Point(173, 346);
            this.lbl_mark2.Name = "lbl_mark2";
            this.lbl_mark2.Size = new System.Drawing.Size(21, 21);
            this.lbl_mark2.TabIndex = 12;
            this.lbl_mark2.Text = "~";
            // 
            // time_ResultTimeStart
            // 
            this.time_ResultTimeStart.CustomFormat = "HH:mm";
            this.time_ResultTimeStart.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.time_ResultTimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time_ResultTimeStart.Location = new System.Drawing.Point(76, 340);
            this.time_ResultTimeStart.Name = "time_ResultTimeStart";
            this.time_ResultTimeStart.ShowCheckBox = true;
            this.time_ResultTimeStart.ShowUpDown = true;
            this.time_ResultTimeStart.Size = new System.Drawing.Size(91, 29);
            this.time_ResultTimeStart.TabIndex = 11;
            // 
            // lbl_ResultTitle
            // 
            this.lbl_ResultTitle.AutoSize = true;
            this.lbl_ResultTitle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ResultTitle.Location = new System.Drawing.Point(72, 316);
            this.lbl_ResultTitle.Name = "lbl_ResultTitle";
            this.lbl_ResultTitle.Size = new System.Drawing.Size(74, 21);
            this.lbl_ResultTitle.TabIndex = 10;
            this.lbl_ResultTitle.Text = "作業実績";
            // 
            // check_EndFlag
            // 
            this.check_EndFlag.AutoSize = true;
            this.check_EndFlag.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.check_EndFlag.Location = new System.Drawing.Point(198, 398);
            this.check_EndFlag.Name = "check_EndFlag";
            this.check_EndFlag.Size = new System.Drawing.Size(111, 32);
            this.check_EndFlag.TabIndex = 15;
            this.check_EndFlag.Text = "作業完了";
            this.check_EndFlag.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Save.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Save.Location = new System.Drawing.Point(128, 455);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(104, 42);
            this.btn_Save.TabIndex = 16;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cancel.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancel.Location = new System.Drawing.Point(274, 455);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(104, 42);
            this.btn_Cancel.TabIndex = 17;
            this.btn_Cancel.Text = "キャンセル";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_HED_ID
            // 
            this.lbl_HED_ID.AutoSize = true;
            this.lbl_HED_ID.Location = new System.Drawing.Point(370, 292);
            this.lbl_HED_ID.Name = "lbl_HED_ID";
            this.lbl_HED_ID.Size = new System.Drawing.Size(46, 15);
            this.lbl_HED_ID.TabIndex = 19;
            this.lbl_HED_ID.Text = "HED_ID";
            // 
            // lbl_InsertOrUpdate
            // 
            this.lbl_InsertOrUpdate.AutoSize = true;
            this.lbl_InsertOrUpdate.Location = new System.Drawing.Point(370, 307);
            this.lbl_InsertOrUpdate.Name = "lbl_InsertOrUpdate";
            this.lbl_InsertOrUpdate.Size = new System.Drawing.Size(87, 15);
            this.lbl_InsertOrUpdate.TabIndex = 20;
            this.lbl_InsertOrUpdate.Text = "InsertOrUpdate";
            // 
            // lbl_DTL_ID
            // 
            this.lbl_DTL_ID.AutoSize = true;
            this.lbl_DTL_ID.Location = new System.Drawing.Point(370, 273);
            this.lbl_DTL_ID.Name = "lbl_DTL_ID";
            this.lbl_DTL_ID.Size = new System.Drawing.Size(43, 15);
            this.lbl_DTL_ID.TabIndex = 21;
            this.lbl_DTL_ID.Text = "DTL_ID";
            // 
            // TaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 535);
            this.Controls.Add(this.lbl_DTL_ID);
            this.Controls.Add(this.lbl_InsertOrUpdate);
            this.Controls.Add(this.lbl_HED_ID);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.check_EndFlag);
            this.Controls.Add(this.time_ResultTimeEnd);
            this.Controls.Add(this.lbl_mark2);
            this.Controls.Add(this.time_ResultTimeStart);
            this.Controls.Add(this.lbl_ResultTitle);
            this.Controls.Add(this.time_PlanTimeEnd);
            this.Controls.Add(this.lbl_mark1);
            this.Controls.Add(this.time_PlanTimeStart);
            this.Controls.Add(this.lbl_ScheduleTitle);
            this.Controls.Add(this.txtBox_Meisai);
            this.Controls.Add(this.lbl_MeisaiTitle);
            this.Controls.Add(this.txtBox_Gaiyou);
            this.Controls.Add(this.lbl_GaiyouTitle);
            this.Controls.Add(this.lbl_Title);
            this.MaximizeBox = false;
            this.Name = "TaskControl";
            this.Text = "作業編集画面";
            this.Load += new System.EventHandler(this.TaskControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_GaiyouTitle;
        private System.Windows.Forms.TextBox txtBox_Gaiyou;
        private System.Windows.Forms.TextBox txtBox_Meisai;
        private System.Windows.Forms.Label lbl_MeisaiTitle;
        private System.Windows.Forms.Label lbl_ScheduleTitle;
        private System.Windows.Forms.DateTimePicker time_PlanTimeStart;
        private System.Windows.Forms.Label lbl_mark1;
        private System.Windows.Forms.DateTimePicker time_PlanTimeEnd;
        private System.Windows.Forms.DateTimePicker time_ResultTimeEnd;
        private System.Windows.Forms.Label lbl_mark2;
        private System.Windows.Forms.DateTimePicker time_ResultTimeStart;
        private System.Windows.Forms.Label lbl_ResultTitle;
        private System.Windows.Forms.CheckBox check_EndFlag;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_HED_ID;
        private System.Windows.Forms.Label lbl_InsertOrUpdate;
        private System.Windows.Forms.Label lbl_DTL_ID;
    }
}