namespace CSharpCourse_NetFrameWork.Test09_01
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
            this.gboxEffect = new System.Windows.Forms.GroupBox();
            this.chkDeleteLine = new System.Windows.Forms.CheckBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.chkStrong = new System.Windows.Forms.CheckBox();
            this.gboxFont = new System.Windows.Forms.GroupBox();
            this.rdoHei = new System.Windows.Forms.RadioButton();
            this.rdoKai = new System.Windows.Forms.RadioButton();
            this.rdoLi = new System.Windows.Forms.RadioButton();
            this.rdoSong = new System.Windows.Forms.RadioButton();
            this.gboxColor = new System.Windows.Forms.GroupBox();
            this.rdoGreen = new System.Windows.Forms.RadioButton();
            this.rdoBlack = new System.Windows.Forms.RadioButton();
            this.rdoRed = new System.Windows.Forms.RadioButton();
            this.rdoBlue = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtShow = new System.Windows.Forms.RichTextBox();
            this.cboFontSize = new System.Windows.Forms.ComboBox();
            this.gboxEffect.SuspendLayout();
            this.gboxFont.SuspendLayout();
            this.gboxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxEffect
            // 
            this.gboxEffect.Controls.Add(this.chkDeleteLine);
            this.gboxEffect.Controls.Add(this.chkItalic);
            this.gboxEffect.Controls.Add(this.chkUnderline);
            this.gboxEffect.Controls.Add(this.chkStrong);
            this.gboxEffect.Location = new System.Drawing.Point(421, 42);
            this.gboxEffect.Name = "gboxEffect";
            this.gboxEffect.Size = new System.Drawing.Size(214, 100);
            this.gboxEffect.TabIndex = 0;
            this.gboxEffect.TabStop = false;
            this.gboxEffect.Text = "字形与效果";
            // 
            // chkDeleteLine
            // 
            this.chkDeleteLine.AutoSize = true;
            this.chkDeleteLine.Location = new System.Drawing.Point(107, 63);
            this.chkDeleteLine.Name = "chkDeleteLine";
            this.chkDeleteLine.Size = new System.Drawing.Size(74, 19);
            this.chkDeleteLine.TabIndex = 3;
            this.chkDeleteLine.Text = "删除线";
            this.chkDeleteLine.UseVisualStyleBackColor = true;
            this.chkDeleteLine.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Location = new System.Drawing.Point(107, 29);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(59, 19);
            this.chkItalic.TabIndex = 2;
            this.chkItalic.Text = "斜体";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chkUnderline
            // 
            this.chkUnderline.AutoSize = true;
            this.chkUnderline.Location = new System.Drawing.Point(18, 63);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(74, 19);
            this.chkUnderline.TabIndex = 1;
            this.chkUnderline.Text = "下划线";
            this.chkUnderline.UseVisualStyleBackColor = true;
            this.chkUnderline.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chkStrong
            // 
            this.chkStrong.AutoSize = true;
            this.chkStrong.Location = new System.Drawing.Point(18, 29);
            this.chkStrong.Name = "chkStrong";
            this.chkStrong.Size = new System.Drawing.Size(59, 19);
            this.chkStrong.TabIndex = 0;
            this.chkStrong.Text = "粗体";
            this.chkStrong.UseVisualStyleBackColor = true;
            this.chkStrong.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // gboxFont
            // 
            this.gboxFont.Controls.Add(this.rdoHei);
            this.gboxFont.Controls.Add(this.rdoKai);
            this.gboxFont.Controls.Add(this.rdoLi);
            this.gboxFont.Controls.Add(this.rdoSong);
            this.gboxFont.Location = new System.Drawing.Point(421, 148);
            this.gboxFont.Name = "gboxFont";
            this.gboxFont.Size = new System.Drawing.Size(214, 100);
            this.gboxFont.TabIndex = 1;
            this.gboxFont.TabStop = false;
            this.gboxFont.Text = "字体名称";
            // 
            // rdoHei
            // 
            this.rdoHei.AutoSize = true;
            this.rdoHei.Location = new System.Drawing.Point(107, 59);
            this.rdoHei.Name = "rdoHei";
            this.rdoHei.Size = new System.Drawing.Size(58, 19);
            this.rdoHei.TabIndex = 3;
            this.rdoHei.Text = "黑体";
            this.rdoHei.UseVisualStyleBackColor = true;
            this.rdoHei.CheckedChanged += new System.EventHandler(this.rdoFontFamily_CheckedChanged);
            // 
            // rdoKai
            // 
            this.rdoKai.AutoSize = true;
            this.rdoKai.Location = new System.Drawing.Point(107, 34);
            this.rdoKai.Name = "rdoKai";
            this.rdoKai.Size = new System.Drawing.Size(58, 19);
            this.rdoKai.TabIndex = 2;
            this.rdoKai.Text = "楷体";
            this.rdoKai.UseVisualStyleBackColor = true;
            this.rdoKai.CheckedChanged += new System.EventHandler(this.rdoFontFamily_CheckedChanged);
            // 
            // rdoLi
            // 
            this.rdoLi.AutoSize = true;
            this.rdoLi.Location = new System.Drawing.Point(16, 59);
            this.rdoLi.Name = "rdoLi";
            this.rdoLi.Size = new System.Drawing.Size(58, 19);
            this.rdoLi.TabIndex = 1;
            this.rdoLi.Text = "隶书";
            this.rdoLi.UseVisualStyleBackColor = true;
            this.rdoLi.CheckedChanged += new System.EventHandler(this.rdoFontFamily_CheckedChanged);
            // 
            // rdoSong
            // 
            this.rdoSong.AutoSize = true;
            this.rdoSong.Checked = true;
            this.rdoSong.Location = new System.Drawing.Point(16, 34);
            this.rdoSong.Name = "rdoSong";
            this.rdoSong.Size = new System.Drawing.Size(58, 19);
            this.rdoSong.TabIndex = 0;
            this.rdoSong.TabStop = true;
            this.rdoSong.Text = "宋体";
            this.rdoSong.UseVisualStyleBackColor = true;
            this.rdoSong.CheckedChanged += new System.EventHandler(this.rdoFontFamily_CheckedChanged);
            // 
            // gboxColor
            // 
            this.gboxColor.Controls.Add(this.rdoGreen);
            this.gboxColor.Controls.Add(this.rdoBlack);
            this.gboxColor.Controls.Add(this.rdoRed);
            this.gboxColor.Controls.Add(this.rdoBlue);
            this.gboxColor.Location = new System.Drawing.Point(421, 254);
            this.gboxColor.Name = "gboxColor";
            this.gboxColor.Size = new System.Drawing.Size(214, 100);
            this.gboxColor.TabIndex = 1;
            this.gboxColor.TabStop = false;
            this.gboxColor.Text = "字体颜色";
            // 
            // rdoGreen
            // 
            this.rdoGreen.AutoSize = true;
            this.rdoGreen.Location = new System.Drawing.Point(107, 59);
            this.rdoGreen.Name = "rdoGreen";
            this.rdoGreen.Size = new System.Drawing.Size(58, 19);
            this.rdoGreen.TabIndex = 7;
            this.rdoGreen.Text = "绿色";
            this.rdoGreen.UseVisualStyleBackColor = true;
            this.rdoGreen.CheckedChanged += new System.EventHandler(this.rdoFontColor_CheckedChanged);
            // 
            // rdoBlack
            // 
            this.rdoBlack.AutoSize = true;
            this.rdoBlack.Checked = true;
            this.rdoBlack.Location = new System.Drawing.Point(107, 34);
            this.rdoBlack.Name = "rdoBlack";
            this.rdoBlack.Size = new System.Drawing.Size(58, 19);
            this.rdoBlack.TabIndex = 6;
            this.rdoBlack.TabStop = true;
            this.rdoBlack.Text = "黑色";
            this.rdoBlack.UseVisualStyleBackColor = true;
            this.rdoBlack.CheckedChanged += new System.EventHandler(this.rdoFontColor_CheckedChanged);
            // 
            // rdoRed
            // 
            this.rdoRed.AutoSize = true;
            this.rdoRed.Location = new System.Drawing.Point(18, 34);
            this.rdoRed.Name = "rdoRed";
            this.rdoRed.Size = new System.Drawing.Size(58, 19);
            this.rdoRed.TabIndex = 4;
            this.rdoRed.Text = "红色";
            this.rdoRed.UseVisualStyleBackColor = true;
            this.rdoRed.CheckedChanged += new System.EventHandler(this.rdoFontColor_CheckedChanged);
            // 
            // rdoBlue
            // 
            this.rdoBlue.AutoSize = true;
            this.rdoBlue.Location = new System.Drawing.Point(18, 59);
            this.rdoBlue.Name = "rdoBlue";
            this.rdoBlue.Size = new System.Drawing.Size(58, 19);
            this.rdoBlue.TabIndex = 5;
            this.rdoBlue.Text = "蓝色";
            this.rdoBlue.UseVisualStyleBackColor = true;
            this.rdoBlue.CheckedChanged += new System.EventHandler(this.rdoFontColor_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "字体字号: ";
            // 
            // rtxtShow
            // 
            this.rtxtShow.Location = new System.Drawing.Point(26, 84);
            this.rtxtShow.Name = "rtxtShow";
            this.rtxtShow.Size = new System.Drawing.Size(356, 270);
            this.rtxtShow.TabIndex = 4;
            this.rtxtShow.Text = "";
            // 
            // cboFontSize
            // 
            this.cboFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFontSize.FormattingEnabled = true;
            this.cboFontSize.Location = new System.Drawing.Point(110, 32);
            this.cboFontSize.Name = "cboFontSize";
            this.cboFontSize.Size = new System.Drawing.Size(272, 23);
            this.cboFontSize.TabIndex = 5;
            this.cboFontSize.SelectedIndexChanged += new System.EventHandler(this.cboFontSize_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 394);
            this.Controls.Add(this.cboFontSize);
            this.Controls.Add(this.rtxtShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gboxFont);
            this.Controls.Add(this.gboxColor);
            this.Controls.Add(this.gboxEffect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxEffect.ResumeLayout(false);
            this.gboxEffect.PerformLayout();
            this.gboxFont.ResumeLayout(false);
            this.gboxFont.PerformLayout();
            this.gboxColor.ResumeLayout(false);
            this.gboxColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxEffect;
        private System.Windows.Forms.CheckBox chkDeleteLine;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.CheckBox chkStrong;
        private System.Windows.Forms.GroupBox gboxFont;
        private System.Windows.Forms.GroupBox gboxColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtShow;
        private System.Windows.Forms.RadioButton rdoHei;
        private System.Windows.Forms.RadioButton rdoKai;
        private System.Windows.Forms.RadioButton rdoLi;
        private System.Windows.Forms.RadioButton rdoSong;
        private System.Windows.Forms.RadioButton rdoGreen;
        private System.Windows.Forms.RadioButton rdoBlack;
        private System.Windows.Forms.RadioButton rdoRed;
        private System.Windows.Forms.RadioButton rdoBlue;
        private System.Windows.Forms.ComboBox cboFontSize;
    }
}