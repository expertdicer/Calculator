namespace Calculator3
{
    partial class Paint
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Cordinates = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(22, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tính Thể tích";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.cal_v);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.Location = new System.Drawing.Point(22, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 46);
            this.button2.TabIndex = 1;
            this.button2.Text = "Tính Diện tích";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.cal_s);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button3.Location = new System.Drawing.Point(114, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "Vẽ ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.draw);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(215, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 449);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkOrange;
            this.button4.Location = new System.Drawing.Point(114, 91);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = "Xóa Hình";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.clear);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkOrange;
            this.button5.Location = new System.Drawing.Point(22, 389);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 49);
            this.button5.TabIndex = 5;
            this.button5.Text = "Finish";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.close);
            // 
            // Cordinates
            // 
            this.Cordinates.AutoSize = true;
            this.Cordinates.Location = new System.Drawing.Point(19, 31);
            this.Cordinates.Name = "Cordinates";
            this.Cordinates.Size = new System.Drawing.Size(46, 17);
            this.Cordinates.TabIndex = 6;
            this.Cordinates.Text = "label1";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Khaki;
            this.button7.Location = new System.Drawing.Point(977, 31);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 36);
            this.button7.TabIndex = 8;
            this.button7.Text = "Vẽ lại B";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.clear_point_b);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Khaki;
            this.button8.Location = new System.Drawing.Point(977, 82);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(87, 36);
            this.button8.TabIndex = 9;
            this.button8.Text = "Vẽ lại C";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.clear_point_c);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Khaki;
            this.button9.Location = new System.Drawing.Point(977, 134);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(87, 36);
            this.button9.TabIndex = 10;
            this.button9.Text = "Vẽ lại D";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.clear_point_d);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1102, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lưuToolStripMenuItem,
            this.mởToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // lưuToolStripMenuItem
            // 
            this.lưuToolStripMenuItem.Name = "lưuToolStripMenuItem";
            this.lưuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lưuToolStripMenuItem.Text = "Lưu File";
            this.lưuToolStripMenuItem.Click += new System.EventHandler(this.lưuToolStripMenuItem_Click);
            // 
            // mởToolStripMenuItem
            // 
            this.mởToolStripMenuItem.Name = "mởToolStripMenuItem";
            this.mởToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mởToolStripMenuItem.Text = "Mở File";
            this.mởToolStripMenuItem.Click += new System.EventHandler(this.mởToolStripMenuItem_Click);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 450);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.Cordinates);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Paint";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Paint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label Cordinates;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mởToolStripMenuItem;
    }
}