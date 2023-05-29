namespace CSharpCourse_NetFrameWork
{
    partial class Test05_01
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtChinOrReq = new System.Windows.Forms.TextBox();
            this.txtMathOrSel = new System.Windows.Forms.TextBox();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.btnAddPupil = new System.Windows.Forms.Button();
            this.btnAddJunior = new System.Windows.Forms.Button();
            this.btnAddCollegeStu = new System.Windows.Forms.Button();
            this.lblShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "年龄:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "语文/必修课:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "数学/选修课:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "英语:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 25);
            this.txtName.TabIndex = 1;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(99, 94);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 25);
            this.txtAge.TabIndex = 1;
            // 
            // txtChinOrReq
            // 
            this.txtChinOrReq.Location = new System.Drawing.Point(325, 43);
            this.txtChinOrReq.Name = "txtChinOrReq";
            this.txtChinOrReq.Size = new System.Drawing.Size(100, 25);
            this.txtChinOrReq.TabIndex = 1;
            // 
            // txtMathOrSel
            // 
            this.txtMathOrSel.Location = new System.Drawing.Point(325, 94);
            this.txtMathOrSel.Name = "txtMathOrSel";
            this.txtMathOrSel.Size = new System.Drawing.Size(100, 25);
            this.txtMathOrSel.TabIndex = 1;
            // 
            // txtEng
            // 
            this.txtEng.Location = new System.Drawing.Point(325, 145);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(100, 25);
            this.txtEng.TabIndex = 1;
            // 
            // btnAddPupil
            // 
            this.btnAddPupil.Location = new System.Drawing.Point(469, 38);
            this.btnAddPupil.Name = "btnAddPupil";
            this.btnAddPupil.Size = new System.Drawing.Size(98, 34);
            this.btnAddPupil.TabIndex = 2;
            this.btnAddPupil.Text = "小学生";
            this.btnAddPupil.UseVisualStyleBackColor = true;
            this.btnAddPupil.Click += new System.EventHandler(this.btnAddPupil_Click);
            // 
            // btnAddJunior
            // 
            this.btnAddJunior.Location = new System.Drawing.Point(469, 89);
            this.btnAddJunior.Name = "btnAddJunior";
            this.btnAddJunior.Size = new System.Drawing.Size(98, 34);
            this.btnAddJunior.TabIndex = 2;
            this.btnAddJunior.Text = "中学生";
            this.btnAddJunior.UseVisualStyleBackColor = true;
            this.btnAddJunior.Click += new System.EventHandler(this.btnAddJunior_Click);
            // 
            // btnAddCollegeStu
            // 
            this.btnAddCollegeStu.Location = new System.Drawing.Point(469, 140);
            this.btnAddCollegeStu.Name = "btnAddCollegeStu";
            this.btnAddCollegeStu.Size = new System.Drawing.Size(98, 34);
            this.btnAddCollegeStu.TabIndex = 2;
            this.btnAddCollegeStu.Text = "大学生";
            this.btnAddCollegeStu.UseVisualStyleBackColor = true;
            this.btnAddCollegeStu.Click += new System.EventHandler(this.btnAddCollegeStu_Click);
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Location = new System.Drawing.Point(51, 205);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(516, 160);
            this.lblShow.TabIndex = 3;
            // 
            // Test05_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 427);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.btnAddCollegeStu);
            this.Controls.Add(this.btnAddJunior);
            this.Controls.Add(this.btnAddPupil);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.txtMathOrSel);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtChinOrReq);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Test05_01";
            this.Text = "Test05_01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtChinOrReq;
        private System.Windows.Forms.TextBox txtMathOrSel;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.Button btnAddPupil;
        private System.Windows.Forms.Button btnAddJunior;
        private System.Windows.Forms.Button btnAddCollegeStu;
        private System.Windows.Forms.Label lblShow;
    }
}