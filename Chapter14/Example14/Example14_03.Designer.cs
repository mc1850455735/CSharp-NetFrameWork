namespace CSharpCourse_NetFrameWork.Example14
{
    partial class Example14_03
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
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnStartColor = new System.Windows.Forms.Button();
            this.btnEndColor = new System.Windows.Forms.Button();
            this.btnConverter = new System.Windows.Forms.Button();
            this.pnlShow = new System.Windows.Forms.Panel();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入文本:";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(150, 36);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(307, 25);
            this.txtSource.TabIndex = 1;
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(32, 87);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(83, 44);
            this.btnFont.TabIndex = 2;
            this.btnFont.Text = "设置字体";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnStartColor
            // 
            this.btnStartColor.Location = new System.Drawing.Point(146, 87);
            this.btnStartColor.Name = "btnStartColor";
            this.btnStartColor.Size = new System.Drawing.Size(83, 44);
            this.btnStartColor.TabIndex = 3;
            this.btnStartColor.Text = "起始颜色";
            this.btnStartColor.UseVisualStyleBackColor = true;
            this.btnStartColor.Click += new System.EventHandler(this.btnStartColor_Click);
            // 
            // btnEndColor
            // 
            this.btnEndColor.Location = new System.Drawing.Point(260, 87);
            this.btnEndColor.Name = "btnEndColor";
            this.btnEndColor.Size = new System.Drawing.Size(83, 44);
            this.btnEndColor.TabIndex = 4;
            this.btnEndColor.Text = "终止颜色";
            this.btnEndColor.UseVisualStyleBackColor = true;
            this.btnEndColor.Click += new System.EventHandler(this.btnEndColor_Click);
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(374, 87);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(83, 44);
            this.btnConverter.TabIndex = 5;
            this.btnConverter.Text = "绘制文本";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // pnlShow
            // 
            this.pnlShow.Location = new System.Drawing.Point(32, 159);
            this.pnlShow.Name = "pnlShow";
            this.pnlShow.Size = new System.Drawing.Size(425, 256);
            this.pnlShow.TabIndex = 6;
            this.pnlShow.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlShow_Paint);
            // 
            // Example14_03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 443);
            this.Controls.Add(this.pnlShow);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.btnEndColor);
            this.Controls.Add(this.btnStartColor);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label1);
            this.Name = "Example14_03";
            this.Text = "Example14_03";
            this.Load += new System.EventHandler(this.Example14_03_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnStartColor;
        private System.Windows.Forms.Button btnEndColor;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Panel pnlShow;
        private System.Windows.Forms.FontDialog dlgFont;
        private System.Windows.Forms.ColorDialog dlgColor;
    }
}