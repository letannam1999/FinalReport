namespace WindowsFormsApp4
{
    partial class welcom
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbdatetime = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbdatetime);
            this.panel1.Controls.Add(this.lbTime);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 222);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp4.Properties.Resources.Thegirltyler_Brand_Camp_Camp_Fire_Stories;
            this.pictureBox1.Location = new System.Drawing.Point(665, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 98);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELLCOME TO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbdatetime
            // 
            this.lbdatetime.AutoSize = true;
            this.lbdatetime.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdatetime.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbdatetime.Location = new System.Drawing.Point(666, 158);
            this.lbdatetime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbdatetime.Name = "lbdatetime";
            this.lbdatetime.Size = new System.Drawing.Size(325, 33);
            this.lbdatetime.TabIndex = 1;
            this.lbdatetime.Text = "Tuseday, december 31, 2019";
            this.lbdatetime.Click += new System.EventHandler(this.lbdatetime_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoEllipsis = true;
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Book Antiqua", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.Ivory;
            this.lbTime.Location = new System.Drawing.Point(798, 100);
            this.lbTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(133, 58);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "22:22";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // welcom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1018, 355);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "welcom";
            this.Text = "welcom";
            this.Load += new System.EventHandler(this.welcom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbdatetime;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}