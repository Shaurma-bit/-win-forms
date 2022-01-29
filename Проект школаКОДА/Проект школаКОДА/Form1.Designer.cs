
namespace Проект_школаКОДА
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Height_box = new System.Windows.Forms.TextBox();
            this.Width_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rgb_color = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rgb_2 = new System.Windows.Forms.TextBox();
            this.rgb_3 = new System.Windows.Forms.TextBox();
            this.rgb_1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Height_box
            // 
            this.Height_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Height_box.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Height_box.Location = new System.Drawing.Point(85, 669);
            this.Height_box.Multiline = true;
            this.Height_box.Name = "Height_box";
            this.Height_box.Size = new System.Drawing.Size(163, 28);
            this.Height_box.TabIndex = 7;
            this.Height_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Height_box.TextChanged += new System.EventHandler(this.Weight_TextChanged);
            this.Height_box.Enter += new System.EventHandler(this.Height_box_Enter);
            this.Height_box.Leave += new System.EventHandler(this.Height_box_Leave);
            // 
            // Width_box
            // 
            this.Width_box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Width_box.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Width_box.Location = new System.Drawing.Point(264, 669);
            this.Width_box.Multiline = true;
            this.Width_box.Name = "Width_box";
            this.Width_box.Size = new System.Drawing.Size(163, 29);
            this.Width_box.TabIndex = 8;
            this.Width_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Width_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Width_box.Enter += new System.EventHandler(this.Width_box_Enter);
            this.Width_box.Leave += new System.EventHandler(this.Width_box_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkCyan;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(318, 651);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ширина";
            // 
            // pic
            // 
            this.pic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(456, 244);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(400, 250);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.LocationChanged += new System.EventHandler(this.pic_LocationChanged);
            this.pic.Click += new System.EventHandler(this.Picture_Click);
            this.pic.DragDrop += new System.Windows.Forms.DragEventHandler(this.pic_DragDrop);
            this.pic.DragEnter += new System.Windows.Forms.DragEventHandler(this.pic_DragEnter);
            this.pic.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.pic_GiveFeedback);
            this.pic.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.pic_QueryContinueDrag);
            this.pic.DoubleClick += new System.EventHandler(this.pic_DoubleClick);
            this.pic.MouseCaptureChanged += new System.EventHandler(this.Picture_MouseCaptureChanged);
            this.pic.MouseEnter += new System.EventHandler(this.pic_MouseEnter);
            this.pic.MouseLeave += new System.EventHandler(this.pic_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 660);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkCyan;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(143, 651);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Длина";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pic3
            // 
            this.pic3.Image = ((System.Drawing.Image)(resources.GetObject("pic3.Image")));
            this.pic3.Location = new System.Drawing.Point(883, 270);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(361, 220);
            this.pic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic3.TabIndex = 12;
            this.pic3.TabStop = false;
            this.pic3.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pic2
            // 
            this.pic2.Image = ((System.Drawing.Image)(resources.GetObject("pic2.Image")));
            this.pic2.Location = new System.Drawing.Point(31, 270);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(361, 220);
            this.pic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic2.TabIndex = 13;
            this.pic2.TabStop = false;
            this.pic2.Click += new System.EventHandler(this.pic2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox2.Location = new System.Drawing.Point(-18, 651);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1379, 59);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // rgb_color
            // 
            this.rgb_color.Location = new System.Drawing.Point(1228, 669);
            this.rgb_color.Name = "rgb_color";
            this.rgb_color.Size = new System.Drawing.Size(84, 29);
            this.rgb_color.TabIndex = 14;
            this.rgb_color.Text = "Color";
            this.rgb_color.UseVisualStyleBackColor = true;
            this.rgb_color.Click += new System.EventHandler(this.rgb_color_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1225, 651);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Фон формы";
            // 
            // rgb_2
            // 
            this.rgb_2.Location = new System.Drawing.Point(1163, 675);
            this.rgb_2.Name = "rgb_2";
            this.rgb_2.Size = new System.Drawing.Size(30, 22);
            this.rgb_2.TabIndex = 17;
            this.rgb_2.TextChanged += new System.EventHandler(this.rgb_2_TextChanged);
            this.rgb_2.Leave += new System.EventHandler(this.rgb_2_Leave);
            // 
            // rgb_3
            // 
            this.rgb_3.Location = new System.Drawing.Point(1193, 675);
            this.rgb_3.Name = "rgb_3";
            this.rgb_3.Size = new System.Drawing.Size(29, 22);
            this.rgb_3.TabIndex = 18;
            this.rgb_3.TextChanged += new System.EventHandler(this.rgb_3_TextChanged);
            this.rgb_3.Leave += new System.EventHandler(this.rgb_3_Leave);
            // 
            // rgb_1
            // 
            this.rgb_1.Location = new System.Drawing.Point(1135, 675);
            this.rgb_1.Name = "rgb_1";
            this.rgb_1.Size = new System.Drawing.Size(29, 22);
            this.rgb_1.TabIndex = 19;
            this.rgb_1.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.rgb_1.Leave += new System.EventHandler(this.rgb_1_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1334, 710);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Height_box);
            this.Controls.Add(this.Width_box);
            this.Controls.Add(this.rgb_1);
            this.Controls.Add(this.rgb_3);
            this.Controls.Add(this.rgb_2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rgb_color);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.pic3);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Image";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Height_box;
        private System.Windows.Forms.TextBox Width_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button rgb_color;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rgb_2;
        private System.Windows.Forms.TextBox rgb_3;
        private System.Windows.Forms.TextBox rgb_1;
    }
}

