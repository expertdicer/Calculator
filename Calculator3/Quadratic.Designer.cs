namespace Calculator3
{
    partial class Quadratic
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ketqua = new System.Windows.Forms.Label();
            this.x1 = new System.Windows.Forms.Label();
            this.x2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Finish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 22);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập hệ số X :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(206, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 22);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập hệ số tự do :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(206, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 22);
            this.textBox3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập hệ số X^2 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kết quả :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "X1 = ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "X2 =";
            // 
            // ketqua
            // 
            this.ketqua.AutoSize = true;
            this.ketqua.Location = new System.Drawing.Point(115, 216);
            this.ketqua.Name = "ketqua";
            this.ketqua.Size = new System.Drawing.Size(46, 17);
            this.ketqua.TabIndex = 9;
            this.ketqua.Text = "label7";
            // 
            // x1
            // 
            this.x1.AutoSize = true;
            this.x1.Location = new System.Drawing.Point(88, 252);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(46, 17);
            this.x1.TabIndex = 10;
            this.x1.Text = "label8";
            // 
            // x2
            // 
            this.x2.AutoSize = true;
            this.x2.Location = new System.Drawing.Point(88, 281);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(46, 17);
            this.x2.TabIndex = 11;
            this.x2.Text = "label9";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Location = new System.Drawing.Point(206, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 48);
            this.button1.TabIndex = 12;
            this.button1.Text = "Solve";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.solve);
            // 
            // Finish
            // 
            this.Finish.BackColor = System.Drawing.Color.DarkOrange;
            this.Finish.Location = new System.Drawing.Point(206, 315);
            this.Finish.Name = "Finish";
            this.Finish.Size = new System.Drawing.Size(75, 47);
            this.Finish.TabIndex = 13;
            this.Finish.Text = "Finish";
            this.Finish.UseVisualStyleBackColor = false;
            this.Finish.Click += new System.EventHandler(this.close);
            // 
            // Quadratic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 374);
            this.Controls.Add(this.Finish);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Quadratic";
            this.Text = "Quadratic";
            this.Load += new System.EventHandler(this.Quadratic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ketqua;
        private System.Windows.Forms.Label x1;
        private System.Windows.Forms.Label x2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Finish;
    }
}