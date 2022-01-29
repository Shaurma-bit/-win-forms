
namespace Проект_школаКОДА
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.enter3 = new System.Windows.Forms.PictureBox();
            this.enter2 = new System.Windows.Forms.PictureBox();
            this.enter1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.enter3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enter2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // enter3
            // 
            this.enter3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.enter3.BackColor = System.Drawing.Color.Transparent;
            this.enter3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enter3.BackgroundImage")));
            this.enter3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enter3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enter3.Location = new System.Drawing.Point(536, 137);
            this.enter3.Name = "enter3";
            this.enter3.Size = new System.Drawing.Size(74, 47);
            this.enter3.TabIndex = 11;
            this.enter3.TabStop = false;
            this.enter3.Click += new System.EventHandler(this.enter3_Click);
            // 
            // enter2
            // 
            this.enter2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enter2.BackColor = System.Drawing.Color.Transparent;
            this.enter2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enter2.BackgroundImage")));
            this.enter2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enter2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enter2.Location = new System.Drawing.Point(307, 137);
            this.enter2.Name = "enter2";
            this.enter2.Size = new System.Drawing.Size(74, 47);
            this.enter2.TabIndex = 12;
            this.enter2.TabStop = false;
            this.enter2.Click += new System.EventHandler(this.enter2_Click);
            // 
            // enter1
            // 
            this.enter1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.enter1.BackColor = System.Drawing.Color.Transparent;
            this.enter1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("enter1.BackgroundImage")));
            this.enter1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.enter1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enter1.Location = new System.Drawing.Point(80, 137);
            this.enter1.Name = "enter1";
            this.enter1.Size = new System.Drawing.Size(74, 47);
            this.enter1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enter1.TabIndex = 13;
            this.enter1.TabStop = false;
            this.enter1.Click += new System.EventHandler(this.enter1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(455, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 355);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(0, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(228, 355);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(227, -13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(228, 355);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(667, 338);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.enter1);
            this.Controls.Add(this.enter2);
            this.Controls.Add(this.enter3);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form2";
            this.Text = "Выбор файла";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enter3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enter2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enter1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox enter3;
        private System.Windows.Forms.PictureBox enter2;
        private System.Windows.Forms.PictureBox enter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}