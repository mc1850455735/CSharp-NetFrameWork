namespace CSharpCourse_NetFrameWork.Example14
{
    partial class Example14_01
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
            this.vsbWidth = new System.Windows.Forms.VScrollBar();
            this.hsbAlpha = new System.Windows.Forms.HScrollBar();
            this.hsbRed = new System.Windows.Forms.HScrollBar();
            this.hsbGreen = new System.Windows.Forms.HScrollBar();
            this.hsbBlue = new System.Windows.Forms.HScrollBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "透明度:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "红:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "绿:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "蓝:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "宽度:";
            // 
            // vsbWidth
            // 
            this.vsbWidth.Location = new System.Drawing.Point(378, 271);
            this.vsbWidth.Maximum = 255;
            this.vsbWidth.Name = "vsbWidth";
            this.vsbWidth.Size = new System.Drawing.Size(20, 149);
            this.vsbWidth.TabIndex = 5;
            this.vsbWidth.ValueChanged += new System.EventHandler(this.BarWidth_ValueChange);
            // 
            // hsbAlpha
            // 
            this.hsbAlpha.Location = new System.Drawing.Point(97, 271);
            this.hsbAlpha.Maximum = 255;
            this.hsbAlpha.Name = "hsbAlpha";
            this.hsbAlpha.Size = new System.Drawing.Size(180, 20);
            this.hsbAlpha.TabIndex = 6;
            this.hsbAlpha.Value = 255;
            this.hsbAlpha.ValueChanged += new System.EventHandler(this.BarColor_ValueChange);
            // 
            // hsbRed
            // 
            this.hsbRed.Location = new System.Drawing.Point(97, 316);
            this.hsbRed.Maximum = 255;
            this.hsbRed.Name = "hsbRed";
            this.hsbRed.Size = new System.Drawing.Size(180, 20);
            this.hsbRed.TabIndex = 7;
            this.hsbRed.ValueChanged += new System.EventHandler(this.BarColor_ValueChange);
            // 
            // hsbGreen
            // 
            this.hsbGreen.Location = new System.Drawing.Point(97, 358);
            this.hsbGreen.Maximum = 255;
            this.hsbGreen.Name = "hsbGreen";
            this.hsbGreen.Size = new System.Drawing.Size(180, 20);
            this.hsbGreen.TabIndex = 8;
            this.hsbGreen.ValueChanged += new System.EventHandler(this.BarColor_ValueChange);
            // 
            // hsbBlue
            // 
            this.hsbBlue.Location = new System.Drawing.Point(97, 400);
            this.hsbBlue.Maximum = 255;
            this.hsbBlue.Name = "hsbBlue";
            this.hsbBlue.Size = new System.Drawing.Size(180, 20);
            this.hsbBlue.TabIndex = 9;
            this.hsbBlue.ValueChanged += new System.EventHandler(this.BarColor_ValueChange);
            // 
            // Example14_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.hsbBlue);
            this.Controls.Add(this.hsbGreen);
            this.Controls.Add(this.hsbRed);
            this.Controls.Add(this.hsbAlpha);
            this.Controls.Add(this.vsbWidth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Example14_01";
            this.Text = "Example14_01";
            this.Load += new System.EventHandler(this.Example14_01_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Example14_01_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Example14_01_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.VScrollBar vsbWidth;
        private System.Windows.Forms.HScrollBar hsbAlpha;
        private System.Windows.Forms.HScrollBar hsbRed;
        private System.Windows.Forms.HScrollBar hsbGreen;
        private System.Windows.Forms.HScrollBar hsbBlue;
    }
}