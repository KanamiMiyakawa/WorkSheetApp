
namespace WorkSheetApp
{
    partial class Form_WorkSheet
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.data_Task = new System.Windows.Forms.DataGridView();
            this.column_Summary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_ScheduledStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_ScheduledEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Finished = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HED_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTL_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_NameTitle = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_DateTitle = new System.Windows.Forms.Label();
            this.txtBox_Date = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_SumScheduledTime = new System.Windows.Forms.Label();
            this.lbl_SumEndedTime = new System.Windows.Forms.Label();
            this.lbl_Comment1Title = new System.Windows.Forms.Label();
            this.txtBox_Comment1 = new System.Windows.Forms.TextBox();
            this.lbl_Comment2Title = new System.Windows.Forms.Label();
            this.txtBox_Comment2 = new System.Windows.Forms.TextBox();
            this.btn_CommentUpdate = new System.Windows.Forms.Button();
            this.btn_AddTask = new System.Windows.Forms.Button();
            this.btn_EditTask = new System.Windows.Forms.Button();
            this.btn_DeleteTask = new System.Windows.Forms.Button();
            this.lbl_HED_ID = new System.Windows.Forms.Label();
            this.lbl_USER_ID = new System.Windows.Forms.Label();
            this.dtPicker_Date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.data_Task)).BeginInit();
            this.SuspendLayout();
            // 
            // data_Task
            // 
            this.data_Task.AllowUserToAddRows = false;
            this.data_Task.AllowUserToDeleteRows = false;
            this.data_Task.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Task.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_Summary,
            this.column_Detail,
            this.column_ScheduledStartTime,
            this.column_ScheduledEndTime,
            this.column_StartTime,
            this.column_EndTime,
            this.column_Finished,
            this.HED_ID,
            this.DTL_ID});
            this.data_Task.Location = new System.Drawing.Point(90, 227);
            this.data_Task.MultiSelect = false;
            this.data_Task.Name = "data_Task";
            this.data_Task.RowTemplate.Height = 25;
            this.data_Task.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_Task.Size = new System.Drawing.Size(694, 182);
            this.data_Task.TabIndex = 6;
            // 
            // column_Summary
            // 
            this.column_Summary.DataPropertyName = "GAIYOU";
            this.column_Summary.HeaderText = "作業概要";
            this.column_Summary.Name = "column_Summary";
            this.column_Summary.ReadOnly = true;
            // 
            // column_Detail
            // 
            this.column_Detail.DataPropertyName = "MEISAI";
            this.column_Detail.HeaderText = "作業詳細";
            this.column_Detail.Name = "column_Detail";
            this.column_Detail.ReadOnly = true;
            // 
            // column_ScheduledStartTime
            // 
            this.column_ScheduledStartTime.DataPropertyName = "PLAN_TIME_START";
            this.column_ScheduledStartTime.HeaderText = "予定開始";
            this.column_ScheduledStartTime.Name = "column_ScheduledStartTime";
            this.column_ScheduledStartTime.ReadOnly = true;
            // 
            // column_ScheduledEndTime
            // 
            this.column_ScheduledEndTime.DataPropertyName = "PLAN_TIME_END";
            this.column_ScheduledEndTime.HeaderText = "予定終了";
            this.column_ScheduledEndTime.Name = "column_ScheduledEndTime";
            this.column_ScheduledEndTime.ReadOnly = true;
            // 
            // column_StartTime
            // 
            this.column_StartTime.DataPropertyName = "RESULT_TIME_START";
            this.column_StartTime.HeaderText = "実績開始";
            this.column_StartTime.Name = "column_StartTime";
            this.column_StartTime.ReadOnly = true;
            // 
            // column_EndTime
            // 
            this.column_EndTime.DataPropertyName = "RESULT_TIME_END";
            this.column_EndTime.HeaderText = "実績終了";
            this.column_EndTime.Name = "column_EndTime";
            this.column_EndTime.ReadOnly = true;
            // 
            // column_Finished
            // 
            this.column_Finished.DataPropertyName = "END_FLAG";
            this.column_Finished.FalseValue = "0";
            this.column_Finished.HeaderText = "完了";
            this.column_Finished.Name = "column_Finished";
            this.column_Finished.ReadOnly = true;
            this.column_Finished.TrueValue = "1";
            this.column_Finished.Width = 50;
            // 
            // HED_ID
            // 
            this.HED_ID.DataPropertyName = "HED_ID";
            this.HED_ID.HeaderText = "HED_ID";
            this.HED_ID.Name = "HED_ID";
            this.HED_ID.Visible = false;
            // 
            // DTL_ID
            // 
            this.DTL_ID.DataPropertyName = "DTL_ID";
            this.DTL_ID.HeaderText = "DTL_ID";
            this.DTL_ID.Name = "DTL_ID";
            this.DTL_ID.Visible = false;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Title.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Title.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title.Location = new System.Drawing.Point(81, 29);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(713, 50);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "作業予定表";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_NameTitle
            // 
            this.lbl_NameTitle.AutoSize = true;
            this.lbl_NameTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_NameTitle.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_NameTitle.Location = new System.Drawing.Point(118, 110);
            this.lbl_NameTitle.Name = "lbl_NameTitle";
            this.lbl_NameTitle.Size = new System.Drawing.Size(52, 28);
            this.lbl_NameTitle.TabIndex = 1;
            this.lbl_NameTitle.Text = "氏名";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Name.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Name.Location = new System.Drawing.Point(227, 110);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(132, 28);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "XXXXXXXXXX";
            // 
            // lbl_DateTitle
            // 
            this.lbl_DateTitle.AutoSize = true;
            this.lbl_DateTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_DateTitle.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_DateTitle.Location = new System.Drawing.Point(118, 164);
            this.lbl_DateTitle.Name = "lbl_DateTitle";
            this.lbl_DateTitle.Size = new System.Drawing.Size(72, 28);
            this.lbl_DateTitle.TabIndex = 3;
            this.lbl_DateTitle.Text = "作業日";
            // 
            // txtBox_Date
            // 
            this.txtBox_Date.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_Date.Location = new System.Drawing.Point(475, 107);
            this.txtBox_Date.Name = "txtBox_Date";
            this.txtBox_Date.Size = new System.Drawing.Size(155, 34);
            this.txtBox_Date.TabIndex = 4;
            this.txtBox_Date.Text = "YYYY/MM/DD";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Search.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Search.Location = new System.Drawing.Point(498, 161);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(86, 40);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "検索";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_SumScheduledTime
            // 
            this.lbl_SumScheduledTime.AutoSize = true;
            this.lbl_SumScheduledTime.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_SumScheduledTime.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbl_SumScheduledTime.Location = new System.Drawing.Point(408, 431);
            this.lbl_SumScheduledTime.Name = "lbl_SumScheduledTime";
            this.lbl_SumScheduledTime.Size = new System.Drawing.Size(176, 21);
            this.lbl_SumScheduledTime.TabIndex = 7;
            this.lbl_SumScheduledTime.Text = "合計予定時間  99.9時間";
            // 
            // lbl_SumEndedTime
            // 
            this.lbl_SumEndedTime.AutoSize = true;
            this.lbl_SumEndedTime.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_SumEndedTime.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lbl_SumEndedTime.Location = new System.Drawing.Point(597, 431);
            this.lbl_SumEndedTime.Name = "lbl_SumEndedTime";
            this.lbl_SumEndedTime.Size = new System.Drawing.Size(176, 21);
            this.lbl_SumEndedTime.TabIndex = 8;
            this.lbl_SumEndedTime.Text = "合計終了時間  99.9時間";
            // 
            // lbl_Comment1Title
            // 
            this.lbl_Comment1Title.AutoSize = true;
            this.lbl_Comment1Title.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Comment1Title.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Comment1Title.Location = new System.Drawing.Point(118, 492);
            this.lbl_Comment1Title.Name = "lbl_Comment1Title";
            this.lbl_Comment1Title.Size = new System.Drawing.Size(135, 21);
            this.lbl_Comment1Title.TabIndex = 9;
            this.lbl_Comment1Title.Text = "問題点及び改善点";
            // 
            // txtBox_Comment1
            // 
            this.txtBox_Comment1.Location = new System.Drawing.Point(102, 516);
            this.txtBox_Comment1.Multiline = true;
            this.txtBox_Comment1.Name = "txtBox_Comment1";
            this.txtBox_Comment1.Size = new System.Drawing.Size(671, 51);
            this.txtBox_Comment1.TabIndex = 10;
            // 
            // lbl_Comment2Title
            // 
            this.lbl_Comment2Title.AutoSize = true;
            this.lbl_Comment2Title.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Comment2Title.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Comment2Title.Location = new System.Drawing.Point(118, 579);
            this.lbl_Comment2Title.Name = "lbl_Comment2Title";
            this.lbl_Comment2Title.Size = new System.Drawing.Size(264, 21);
            this.lbl_Comment2Title.TabIndex = 11;
            this.lbl_Comment2Title.Text = "明日以降の予定及び、その他報告内容";
            // 
            // txtBox_Comment2
            // 
            this.txtBox_Comment2.Location = new System.Drawing.Point(102, 603);
            this.txtBox_Comment2.Multiline = true;
            this.txtBox_Comment2.Name = "txtBox_Comment2";
            this.txtBox_Comment2.Size = new System.Drawing.Size(671, 51);
            this.txtBox_Comment2.TabIndex = 12;
            // 
            // btn_CommentUpdate
            // 
            this.btn_CommentUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_CommentUpdate.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CommentUpdate.Location = new System.Drawing.Point(658, 669);
            this.btn_CommentUpdate.Name = "btn_CommentUpdate";
            this.btn_CommentUpdate.Size = new System.Drawing.Size(115, 43);
            this.btn_CommentUpdate.TabIndex = 13;
            this.btn_CommentUpdate.Text = "コメントの更新";
            this.btn_CommentUpdate.UseVisualStyleBackColor = false;
            this.btn_CommentUpdate.Click += new System.EventHandler(this.btn_CommentUpdate_Click);
            // 
            // btn_AddTask
            // 
            this.btn_AddTask.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_AddTask.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AddTask.Location = new System.Drawing.Point(131, 425);
            this.btn_AddTask.Name = "btn_AddTask";
            this.btn_AddTask.Size = new System.Drawing.Size(59, 33);
            this.btn_AddTask.TabIndex = 14;
            this.btn_AddTask.Text = "追加";
            this.btn_AddTask.UseVisualStyleBackColor = false;
            this.btn_AddTask.Click += new System.EventHandler(this.btn_AddTask_Click);
            // 
            // btn_EditTask
            // 
            this.btn_EditTask.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_EditTask.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_EditTask.Location = new System.Drawing.Point(214, 425);
            this.btn_EditTask.Name = "btn_EditTask";
            this.btn_EditTask.Size = new System.Drawing.Size(59, 33);
            this.btn_EditTask.TabIndex = 15;
            this.btn_EditTask.Text = "編集";
            this.btn_EditTask.UseVisualStyleBackColor = false;
            this.btn_EditTask.Click += new System.EventHandler(this.btn_EditTask_Click);
            // 
            // btn_DeleteTask
            // 
            this.btn_DeleteTask.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_DeleteTask.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_DeleteTask.Location = new System.Drawing.Point(300, 425);
            this.btn_DeleteTask.Name = "btn_DeleteTask";
            this.btn_DeleteTask.Size = new System.Drawing.Size(59, 33);
            this.btn_DeleteTask.TabIndex = 16;
            this.btn_DeleteTask.Text = "削除";
            this.btn_DeleteTask.UseVisualStyleBackColor = false;
            this.btn_DeleteTask.Click += new System.EventHandler(this.btn_DeleteTask_Click);
            // 
            // lbl_HED_ID
            // 
            this.lbl_HED_ID.AutoSize = true;
            this.lbl_HED_ID.Location = new System.Drawing.Point(733, 124);
            this.lbl_HED_ID.Name = "lbl_HED_ID";
            this.lbl_HED_ID.Size = new System.Drawing.Size(46, 15);
            this.lbl_HED_ID.TabIndex = 17;
            this.lbl_HED_ID.Text = "HED_ID";
            // 
            // lbl_USER_ID
            // 
            this.lbl_USER_ID.AutoSize = true;
            this.lbl_USER_ID.Location = new System.Drawing.Point(733, 99);
            this.lbl_USER_ID.Name = "lbl_USER_ID";
            this.lbl_USER_ID.Size = new System.Drawing.Size(50, 15);
            this.lbl_USER_ID.TabIndex = 18;
            this.lbl_USER_ID.Text = "USER_ID";
            // 
            // dtPicker_Date
            // 
            this.dtPicker_Date.Font = new System.Drawing.Font("Yu Gothic UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtPicker_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPicker_Date.Location = new System.Drawing.Point(227, 162);
            this.dtPicker_Date.Name = "dtPicker_Date";
            this.dtPicker_Date.Size = new System.Drawing.Size(181, 34);
            this.dtPicker_Date.TabIndex = 19;
            // 
            // Form_WorkSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(874, 749);
            this.Controls.Add(this.dtPicker_Date);
            this.Controls.Add(this.lbl_USER_ID);
            this.Controls.Add(this.lbl_HED_ID);
            this.Controls.Add(this.btn_DeleteTask);
            this.Controls.Add(this.btn_EditTask);
            this.Controls.Add(this.btn_AddTask);
            this.Controls.Add(this.btn_CommentUpdate);
            this.Controls.Add(this.txtBox_Comment2);
            this.Controls.Add(this.lbl_Comment2Title);
            this.Controls.Add(this.txtBox_Comment1);
            this.Controls.Add(this.lbl_Comment1Title);
            this.Controls.Add(this.lbl_SumEndedTime);
            this.Controls.Add(this.lbl_SumScheduledTime);
            this.Controls.Add(this.data_Task);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txtBox_Date);
            this.Controls.Add(this.lbl_DateTitle);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_NameTitle);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_WorkSheet";
            this.Text = "作業予定表";
            this.Load += new System.EventHandler(this.WorkSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Task)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_NameTitle;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_DateTitle;
        private System.Windows.Forms.TextBox txtBox_Date;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView data_Task;
        private System.Windows.Forms.Label lbl_SumScheduledTime;
        private System.Windows.Forms.Label lbl_SumEndedTime;
        private System.Windows.Forms.Label lbl_Comment1Title;
        private System.Windows.Forms.TextBox txtBox_Comment1;
        private System.Windows.Forms.Label lbl_Comment2Title;
        private System.Windows.Forms.TextBox txtBox_Comment2;
        private System.Windows.Forms.Button btn_CommentUpdate;
        private System.Windows.Forms.Button btn_AddTask;
        private System.Windows.Forms.Button btn_EditTask;
        private System.Windows.Forms.Button btn_DeleteTask;
        private System.Windows.Forms.Label lbl_HED_ID;
        private System.Windows.Forms.Label lbl_USER_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Summary;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_ScheduledStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_ScheduledEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_EndTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn column_Finished;
        private System.Windows.Forms.DataGridViewTextBoxColumn HED_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTL_ID;
        private System.Windows.Forms.DateTimePicker dtPicker_Date;
    }
}

