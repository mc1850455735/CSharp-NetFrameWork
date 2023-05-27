namespace CSharpCourse_NetFrameWork
{
    partial class Practice09_04
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
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tpgProjectInfo = new System.Windows.Forms.TabPage();
            this.tpgAcceptInfo = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoIncome = new System.Windows.Forms.RadioButton();
            this.rdoExpenditure = new System.Windows.Forms.RadioButton();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.rtxtShow = new System.Windows.Forms.RichTextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.tbControl.SuspendLayout();
            this.tpgProjectInfo.SuspendLayout();
            this.tpgAcceptInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tpgProjectInfo);
            this.tbControl.Controls.Add(this.tpgAcceptInfo);
            this.tbControl.Location = new System.Drawing.Point(34, 33);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(422, 425);
            this.tbControl.TabIndex = 0;
            this.tbControl.SelectedIndexChanged += new System.EventHandler(this.tbControl_SelectedIndexChanged);
            // 
            // tpgProjectInfo
            // 
            this.tpgProjectInfo.Controls.Add(this.btnPreview);
            this.tpgProjectInfo.Controls.Add(this.groupBox1);
            this.tpgProjectInfo.Controls.Add(this.txtName);
            this.tpgProjectInfo.Controls.Add(this.label1);
            this.tpgProjectInfo.Location = new System.Drawing.Point(4, 25);
            this.tpgProjectInfo.Name = "tpgProjectInfo";
            this.tpgProjectInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpgProjectInfo.Size = new System.Drawing.Size(414, 396);
            this.tpgProjectInfo.TabIndex = 0;
            this.tpgProjectInfo.Text = "收支项目信息";
            this.tpgProjectInfo.UseVisualStyleBackColor = true;
            // 
            // tpgAcceptInfo
            // 
            this.tpgAcceptInfo.Controls.Add(this.btnAccept);
            this.tpgAcceptInfo.Controls.Add(this.rtxtShow);
            this.tpgAcceptInfo.Location = new System.Drawing.Point(4, 25);
            this.tpgAcceptInfo.Name = "tpgAcceptInfo";
            this.tpgAcceptInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpgAcceptInfo.Size = new System.Drawing.Size(414, 396);
            this.tpgAcceptInfo.TabIndex = 1;
            this.tpgAcceptInfo.Text = "确认信息";
            this.tpgAcceptInfo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "项目名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "类别：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(146, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(202, 25);
            this.txtName.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboCategory);
            this.groupBox1.Controls.Add(this.rdoExpenditure);
            this.groupBox1.Controls.Add(this.rdoIncome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(38, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 148);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "所属类别";
            // 
            // rdoIncome
            // 
            this.rdoIncome.AutoSize = true;
            this.rdoIncome.Location = new System.Drawing.Point(88, 43);
            this.rdoIncome.Name = "rdoIncome";
            this.rdoIncome.Size = new System.Drawing.Size(58, 19);
            this.rdoIncome.TabIndex = 0;
            this.rdoIncome.Text = "收入";
            this.rdoIncome.UseVisualStyleBackColor = true;
            // 
            // rdoExpenditure
            // 
            this.rdoExpenditure.AutoSize = true;
            this.rdoExpenditure.Checked = true;
            this.rdoExpenditure.Location = new System.Drawing.Point(167, 43);
            this.rdoExpenditure.Name = "rdoExpenditure";
            this.rdoExpenditure.Size = new System.Drawing.Size(58, 19);
            this.rdoExpenditure.TabIndex = 1;
            this.rdoExpenditure.TabStop = true;
            this.rdoExpenditure.Text = "支出";
            this.rdoExpenditure.UseVisualStyleBackColor = true;
            this.rdoExpenditure.CheckedChanged += new System.EventHandler(this.rdoExpenditure_CheckedChanged);
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(87, 93);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(91, 23);
            this.cboCategory.TabIndex = 2;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(139, 311);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(124, 34);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Text = "预览(&V)";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // rtxtShow
            // 
            this.rtxtShow.Location = new System.Drawing.Point(26, 29);
            this.rtxtShow.Name = "rtxtShow";
            this.rtxtShow.Size = new System.Drawing.Size(358, 282);
            this.rtxtShow.TabIndex = 0;
            this.rtxtShow.Text = "";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(150, 333);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(109, 44);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "确定";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // Practice09_04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 503);
            this.Controls.Add(this.tbControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Practice09_04";
            this.Text = "Practice09_04";
            this.tbControl.ResumeLayout(false);
            this.tpgProjectInfo.ResumeLayout(false);
            this.tpgProjectInfo.PerformLayout();
            this.tpgAcceptInfo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tpgProjectInfo;
        private System.Windows.Forms.TabPage tpgAcceptInfo;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.RadioButton rdoExpenditure;
        private System.Windows.Forms.RadioButton rdoIncome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.RichTextBox rtxtShow;
    }
}