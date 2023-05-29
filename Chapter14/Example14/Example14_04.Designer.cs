namespace CSharpCourse_NetFrameWork.Chapter14.Example14
{
    partial class Example14_04
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ngRotate = new System.Windows.Forms.NumericUpDown();
            this.ngxScale = new System.Windows.Forms.NumericUpDown();
            this.ngxMove = new System.Windows.Forms.NumericUpDown();
            this.ngyScale = new System.Windows.Forms.NumericUpDown();
            this.ngyMove = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nlRotate = new System.Windows.Forms.NumericUpDown();
            this.nlxScale = new System.Windows.Forms.NumericUpDown();
            this.nlyScale = new System.Windows.Forms.NumericUpDown();
            this.nlxMove = new System.Windows.Forms.NumericUpDown();
            this.nlyMove = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngxScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngxMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngyScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngyMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlRotate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlxScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlyScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlxMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlyMove)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "旋转:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "放缩: 横向:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "平移: 横向:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "纵向:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "纵向:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ngyMove);
            this.groupBox1.Controls.Add(this.ngxMove);
            this.groupBox1.Controls.Add(this.ngyScale);
            this.groupBox1.Controls.Add(this.ngxScale);
            this.groupBox1.Controls.Add(this.ngRotate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(22, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 166);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "全局变形";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nlyMove);
            this.groupBox2.Controls.Add(this.nlRotate);
            this.groupBox2.Controls.Add(this.nlxMove);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.nlyScale);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.nlxScale);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(401, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 166);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "对椭圆进行局部变形";
            // 
            // ngRotate
            // 
            this.ngRotate.Location = new System.Drawing.Point(133, 34);
            this.ngRotate.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.ngRotate.Name = "ngRotate";
            this.ngRotate.Size = new System.Drawing.Size(59, 25);
            this.ngRotate.TabIndex = 5;
            this.ngRotate.ValueChanged += new System.EventHandler(this.ngRotate_ValueChanged);
            // 
            // ngxScale
            // 
            this.ngxScale.DecimalPlaces = 1;
            this.ngxScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ngxScale.Location = new System.Drawing.Point(133, 75);
            this.ngxScale.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ngxScale.Name = "ngxScale";
            this.ngxScale.Size = new System.Drawing.Size(59, 25);
            this.ngxScale.TabIndex = 5;
            this.ngxScale.ValueChanged += new System.EventHandler(this.ngxScale_ValueChanged);
            // 
            // ngxMove
            // 
            this.ngxMove.Location = new System.Drawing.Point(133, 116);
            this.ngxMove.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ngxMove.Name = "ngxMove";
            this.ngxMove.Size = new System.Drawing.Size(59, 25);
            this.ngxMove.TabIndex = 5;
            this.ngxMove.ValueChanged += new System.EventHandler(this.ngxMove_ValueChanged);
            // 
            // ngyScale
            // 
            this.ngyScale.DecimalPlaces = 1;
            this.ngyScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ngyScale.Location = new System.Drawing.Point(267, 75);
            this.ngyScale.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ngyScale.Name = "ngyScale";
            this.ngyScale.Size = new System.Drawing.Size(59, 25);
            this.ngyScale.TabIndex = 5;
            this.ngyScale.ValueChanged += new System.EventHandler(this.ngyScale_ValueChanged);
            // 
            // ngyMove
            // 
            this.ngyMove.Location = new System.Drawing.Point(267, 116);
            this.ngyMove.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ngyMove.Name = "ngyMove";
            this.ngyMove.Size = new System.Drawing.Size(59, 25);
            this.ngyMove.TabIndex = 5;
            this.ngyMove.ValueChanged += new System.EventHandler(this.ngyMove_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "纵向:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "纵向:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "平移: 横向:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "放缩: 横向:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "旋转:";
            // 
            // nlRotate
            // 
            this.nlRotate.Location = new System.Drawing.Point(129, 34);
            this.nlRotate.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nlRotate.Name = "nlRotate";
            this.nlRotate.Size = new System.Drawing.Size(59, 25);
            this.nlRotate.TabIndex = 5;
            this.nlRotate.ValueChanged += new System.EventHandler(this.nlRotate_ValueChanged);
            // 
            // nlxScale
            // 
            this.nlxScale.DecimalPlaces = 1;
            this.nlxScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nlxScale.Location = new System.Drawing.Point(129, 75);
            this.nlxScale.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nlxScale.Name = "nlxScale";
            this.nlxScale.Size = new System.Drawing.Size(59, 25);
            this.nlxScale.TabIndex = 5;
            this.nlxScale.ValueChanged += new System.EventHandler(this.nlxScale_ValueChanged);
            // 
            // nlyScale
            // 
            this.nlyScale.DecimalPlaces = 1;
            this.nlyScale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nlyScale.Location = new System.Drawing.Point(263, 75);
            this.nlyScale.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nlyScale.Name = "nlyScale";
            this.nlyScale.Size = new System.Drawing.Size(59, 25);
            this.nlyScale.TabIndex = 5;
            this.nlyScale.ValueChanged += new System.EventHandler(this.nlyScale_ValueChanged);
            // 
            // nlxMove
            // 
            this.nlxMove.Location = new System.Drawing.Point(129, 116);
            this.nlxMove.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nlxMove.Name = "nlxMove";
            this.nlxMove.Size = new System.Drawing.Size(59, 25);
            this.nlxMove.TabIndex = 5;
            this.nlxMove.ValueChanged += new System.EventHandler(this.nlxMove_ValueChanged);
            // 
            // nlyMove
            // 
            this.nlyMove.Location = new System.Drawing.Point(263, 116);
            this.nlyMove.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nlyMove.Name = "nlyMove";
            this.nlyMove.Size = new System.Drawing.Size(59, 25);
            this.nlyMove.TabIndex = 5;
            this.nlyMove.ValueChanged += new System.EventHandler(this.nlyMove_ValueChanged);
            // 
            // Example14_04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 427);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Example14_04";
            this.Text = "Example14_04";
            this.Load += new System.EventHandler(this.Example14_04_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Example14_04_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngxScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngxMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngyScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngyMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlRotate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlxScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlyScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlxMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nlyMove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown ngyMove;
        private System.Windows.Forms.NumericUpDown ngxMove;
        private System.Windows.Forms.NumericUpDown ngyScale;
        private System.Windows.Forms.NumericUpDown ngxScale;
        private System.Windows.Forms.NumericUpDown ngRotate;
        private System.Windows.Forms.NumericUpDown nlyMove;
        private System.Windows.Forms.NumericUpDown nlRotate;
        private System.Windows.Forms.NumericUpDown nlxMove;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nlyScale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nlxScale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}