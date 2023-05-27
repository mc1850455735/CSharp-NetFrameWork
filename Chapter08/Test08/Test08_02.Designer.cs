namespace CSharpCourse_NetFrameWork
{
    partial class Test08_02
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtPressure = new System.Windows.Forms.TextBox();
            this.lblShow = new System.Windows.Forms.Label();
            this.btnManual = new System.Windows.Forms.Button();
            this.autoTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(217, 46);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 36);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "启动锅炉";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtPressure
            // 
            this.txtPressure.Location = new System.Drawing.Point(223, 121);
            this.txtPressure.Name = "txtPressure";
            this.txtPressure.Size = new System.Drawing.Size(85, 25);
            this.txtPressure.TabIndex = 1;
            // 
            // lblShow
            // 
            this.lblShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShow.Location = new System.Drawing.Point(153, 185);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(224, 40);
            this.lblShow.TabIndex = 2;
            // 
            // btnManual
            // 
            this.btnManual.Location = new System.Drawing.Point(217, 264);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(96, 36);
            this.btnManual.TabIndex = 3;
            this.btnManual.Text = "手动降压";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // autoTimer
            // 
            this.autoTimer.Interval = 1000;
            this.autoTimer.Tick += new System.EventHandler(this.autoTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CSharpCourse_NetFrameWork.Properties.Resources.reset;
            this.pictureBox1.Location = new System.Drawing.Point(12, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Test08_02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 387);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.txtPressure);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Test08_02";
            this.Text = "Test08_02";
            this.Load += new System.EventHandler(this.Test08_02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtPressure;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Timer autoTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}