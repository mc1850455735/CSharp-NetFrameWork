namespace CSharpCourse_NetFrameWork
{
    partial class Test08_01
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
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnCreateArray = new System.Windows.Forms.Button();
            this.btnAscSort = new System.Windows.Forms.Button();
            this.btnDescSort = new System.Windows.Forms.Button();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "排序前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "排序后";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(16, 98);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(142, 218);
            this.txtSource.TabIndex = 2;
            // 
            // btnCreateArray
            // 
            this.btnCreateArray.Location = new System.Drawing.Point(194, 98);
            this.btnCreateArray.Name = "btnCreateArray";
            this.btnCreateArray.Size = new System.Drawing.Size(75, 23);
            this.btnCreateArray.TabIndex = 4;
            this.btnCreateArray.Text = "生成数组";
            this.btnCreateArray.UseVisualStyleBackColor = true;
            this.btnCreateArray.Click += new System.EventHandler(this.btnCreateArray_Click);
            // 
            // btnAscSort
            // 
            this.btnAscSort.Location = new System.Drawing.Point(194, 146);
            this.btnAscSort.Name = "btnAscSort";
            this.btnAscSort.Size = new System.Drawing.Size(75, 23);
            this.btnAscSort.TabIndex = 5;
            this.btnAscSort.Text = "升序排序";
            this.btnAscSort.UseVisualStyleBackColor = true;
            this.btnAscSort.Click += new System.EventHandler(this.btnAscSort_Click);
            // 
            // btnDescSort
            // 
            this.btnDescSort.Location = new System.Drawing.Point(194, 193);
            this.btnDescSort.Name = "btnDescSort";
            this.btnDescSort.Size = new System.Drawing.Size(75, 23);
            this.btnDescSort.TabIndex = 6;
            this.btnDescSort.Text = "降序排序";
            this.btnDescSort.UseVisualStyleBackColor = true;
            this.btnDescSort.Click += new System.EventHandler(this.btnDescSort_Click);
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(299, 98);
            this.txtTarget.Multiline = true;
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(142, 218);
            this.txtTarget.TabIndex = 7;
            // 
            // Test08_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 361);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.btnDescSort);
            this.Controls.Add(this.btnAscSort);
            this.Controls.Add(this.btnCreateArray);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Test08_01";
            this.Text = "Test08_01";
            this.Load += new System.EventHandler(this.Test08_01_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnCreateArray;
        private System.Windows.Forms.Button btnAscSort;
        private System.Windows.Forms.Button btnDescSort;
        private System.Windows.Forms.TextBox txtTarget;
    }
}