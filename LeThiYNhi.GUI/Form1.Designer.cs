﻿
namespace LeThiYNhi.GUI
{
    partial class Form1
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
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckbGt = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.dgvEm = new System.Windows.Forms.DataGridView();
            this.playbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbDv = new System.Windows.Forms.ComboBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEm)).BeginInit();
            this.SuspendLayout();
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "iddepart";
            this.Column6.HeaderText = "Đơn vị";
            this.Column6.Name = "Column6";
            // 
            // ckbGt
            // 
            this.ckbGt.AutoSize = true;
            this.ckbGt.Location = new System.Drawing.Point(561, 42);
            this.ckbGt.Name = "ckbGt";
            this.ckbGt.Size = new System.Drawing.Size(91, 17);
            this.ckbGt.TabIndex = 62;
            this.ckbGt.Text = "Giới tính Nam";
            this.ckbGt.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Ngày sinh";
            // 
            // tbNs
            // 
            this.tbNs.Location = new System.Drawing.Point(237, 76);
            this.tbNs.Name = "tbNs";
            this.tbNs.Size = new System.Drawing.Size(415, 20);
            this.tbNs.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Nơi sinh";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "gender";
            this.Column4.HeaderText = "Giới tính";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "datebirth";
            this.Column3.HeaderText = "Ngày sinh";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "name";
            this.Column2.HeaderText = "Họ tên";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idemploy";
            this.Column1.HeaderText = "Mã";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // dt
            // 
            this.dt.Cursor = System.Windows.Forms.Cursors.Default;
            this.dt.CustomFormat = "dd/MM/yyyy";
            this.dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt.Location = new System.Drawing.Point(438, 40);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(106, 20);
            this.dt.TabIndex = 64;
            // 
            // dgvEm
            // 
            this.dgvEm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.playbirth,
            this.Column6});
            this.dgvEm.Location = new System.Drawing.Point(33, 121);
            this.dgvEm.Name = "dgvEm";
            this.dgvEm.Size = new System.Drawing.Size(619, 193);
            this.dgvEm.TabIndex = 58;
            this.dgvEm.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEm_RowEnter);
            // 
            // playbirth
            // 
            this.playbirth.DataPropertyName = "placebirth";
            this.playbirth.HeaderText = "Nơi sinh";
            this.playbirth.Name = "playbirth";
            // 
            // cbDv
            // 
            this.cbDv.FormattingEnabled = true;
            this.cbDv.Location = new System.Drawing.Point(74, 76);
            this.cbDv.Name = "cbDv";
            this.cbDv.Size = new System.Drawing.Size(103, 21);
            this.cbDv.TabIndex = 57;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(306, 335);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 56;
            this.btDelete.Text = "Xoá";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(414, 335);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 55;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(523, 335);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 54;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(208, 335);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(75, 23);
            this.btNew.TabIndex = 53;
            this.btNew.Text = "Thêm";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(75, 40);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(102, 20);
            this.tbId.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Đơn vị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Mã";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(237, 40);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(126, 20);
            this.tbName.TabIndex = 52;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 399);
            this.Controls.Add(this.ckbGt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNs);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.dgvEm);
            this.Controls.Add(this.cbDv);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.CheckBox ckbGt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DateTimePicker dt;
        private System.Windows.Forms.DataGridView dgvEm;
        private System.Windows.Forms.DataGridViewTextBoxColumn playbirth;
        private System.Windows.Forms.ComboBox cbDv;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
    }
}

