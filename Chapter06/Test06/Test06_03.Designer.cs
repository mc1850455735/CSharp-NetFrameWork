namespace CSharpCourse_NetFrameWork
{
    partial class Test06_03
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
            this.lblShow = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddUniStu = new System.Windows.Forms.Button();
            this.btnAddMidStu = new System.Windows.Forms.Button();
            this.btnAddLitStu = new System.Windows.Forms.Button();
            this.btnStudy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Location = new System.Drawing.Point(30, 36);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(374, 324);
            this.lblShow.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(535, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 25);
            this.txtName.TabIndex = 1;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(535, 99);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 25);
            this.txtAge.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "姓名: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "年龄: ";
            // 
            // btnAddUniStu
            // 
            this.btnAddUniStu.Location = new System.Drawing.Point(493, 160);
            this.btnAddUniStu.Name = "btnAddUniStu";
            this.btnAddUniStu.Size = new System.Drawing.Size(142, 38);
            this.btnAddUniStu.TabIndex = 2;
            this.btnAddUniStu.Text = "添加大学生";
            this.btnAddUniStu.UseVisualStyleBackColor = true;
            this.btnAddUniStu.Click += new System.EventHandler(this.btnAddUniStu_Click);
            // 
            // btnAddMidStu
            // 
            this.btnAddMidStu.Location = new System.Drawing.Point(493, 214);
            this.btnAddMidStu.Name = "btnAddMidStu";
            this.btnAddMidStu.Size = new System.Drawing.Size(142, 38);
            this.btnAddMidStu.TabIndex = 2;
            this.btnAddMidStu.Text = "添加中学生";
            this.btnAddMidStu.UseVisualStyleBackColor = true;
            this.btnAddMidStu.Click += new System.EventHandler(this.btnAddMidStu_Click);
            // 
            // btnAddLitStu
            // 
            this.btnAddLitStu.Location = new System.Drawing.Point(493, 268);
            this.btnAddLitStu.Name = "btnAddLitStu";
            this.btnAddLitStu.Size = new System.Drawing.Size(142, 38);
            this.btnAddLitStu.TabIndex = 2;
            this.btnAddLitStu.Text = "添加小学生";
            this.btnAddLitStu.UseVisualStyleBackColor = true;
            this.btnAddLitStu.Click += new System.EventHandler(this.btnAddLitStu_Click);
            // 
            // btnStudy
            // 
            this.btnStudy.Location = new System.Drawing.Point(493, 322);
            this.btnStudy.Name = "btnStudy";
            this.btnStudy.Size = new System.Drawing.Size(142, 38);
            this.btnStudy.TabIndex = 2;
            this.btnStudy.Text = "学习";
            this.btnStudy.UseVisualStyleBackColor = true;
            this.btnStudy.Click += new System.EventHandler(this.btnStudy_Click);
            // 
            // Test06_03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 418);
            this.Controls.Add(this.btnStudy);
            this.Controls.Add(this.btnAddLitStu);
            this.Controls.Add(this.btnAddMidStu);
            this.Controls.Add(this.btnAddUniStu);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblShow);
            this.Name = "Test06_03";
            this.Text = "Test06_03";
            this.Load += new System.EventHandler(this.Test06_03_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddUniStu;
        private System.Windows.Forms.Button btnAddMidStu;
        private System.Windows.Forms.Button btnAddLitStu;
        private System.Windows.Forms.Button btnStudy;
    }
}