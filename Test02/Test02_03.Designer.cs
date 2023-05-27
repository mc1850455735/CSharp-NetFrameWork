namespace CSharpCourse_NetFrameWork
{
    partial class Test2_3
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.beforeSort = new System.Windows.Forms.Label();
            this.afterSort = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入数字";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "排序前";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "排序后";
            // 
            // beforeSort
            // 
            this.beforeSort.AutoSize = true;
            this.beforeSort.Location = new System.Drawing.Point(142, 169);
            this.beforeSort.Name = "beforeSort";
            this.beforeSort.Size = new System.Drawing.Size(0, 15);
            this.beforeSort.TabIndex = 4;
            // 
            // afterSort
            // 
            this.afterSort.AutoSize = true;
            this.afterSort.Location = new System.Drawing.Point(142, 223);
            this.afterSort.Name = "afterSort";
            this.afterSort.Size = new System.Drawing.Size(0, 15);
            this.afterSort.TabIndex = 5;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(459, 68);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(82, 30);
            this.ok.TabIndex = 6;
            this.ok.Text = "确认";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(459, 104);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(82, 30);
            this.clear.TabIndex = 7;
            this.clear.Text = "清空";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Test2_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.afterSort);
            this.Controls.Add(this.beforeSort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Test2_3";
            this.Text = "Test2_3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label beforeSort;
        private System.Windows.Forms.Label afterSort;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button clear;
    }
}