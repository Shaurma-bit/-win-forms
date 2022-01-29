using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект_школаКОДА
{
    //public struct Image2D
    //{
    //    float x, y;
    //    public float X
    //    {
    //        get { return x; }
    //        set { x = value; }
    //    }
    //    public float Y
    //    {
    //        get { return y; }
    //        set { y = value; }
    //    }
    //}

    public partial class Form1 : Form
    {
        public string str;

        void Size_Height(int _height)
        {
            this.pic.Height += _height;
            Height_box.Text = Convert.ToString(pic.Height);
        }

        void Size_Width(int _width)
        {
            this.pic.Width += _width;
            Width_box.Text = Convert.ToString(pic.Width);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pic.Width = 400;
            //pic.Height = 250;
            pic2.Hide();
            pic3.Hide();
            for (int i = 0; i < 2; i++)
            {
                int x = (this.Size.Width / 2 - pic.Width / 2) - 10;
                int y = this.Size.Height / 2 - pic.Height / 2;
                pic.Location = new Point(x, y);
                pic.Width = this.Size.Width / 4 + 35;
                pic.Height = this.Size.Height / 3;


                //int x2 = this.Size.Width / 6 - pic2.Width / 2;
                //int y2 = this.Size.Height / 2 - pic2.Height / 2;
                //pic2.Location = new Point(x2, y2);

                //int x3 = this.Size.Width - (this.Size.Width / 6) - pic3.Width / 2;
                //int y3 = this.Size.Height / 2 - pic3.Height / 2;
                //pic3.Location = new Point(x3, y3);
            }

            Width_box.Text = Convert.ToString(pic.Width);
            Height_box.Text = Convert.ToString(pic.Height);

            //pic.Image = Image.FromFile("1.png");
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Size_Height(5);
        }

        private void button_width_Click(object sender, EventArgs e)
        {
            Size_Width(5);
        }

        private void button_height__Click(object sender, EventArgs e)
        {
            Size_Height(-5);
        }

        private void button_width__Click(object sender, EventArgs e)
        {
            Size_Width(-5);
        }
        private void Back_Color(int rgb1, int rgb2, int rgb3)
        {
            this.BackColor = Color.FromArgb(rgb1, rgb2, rgb3);
        }

        public PictureBox Get_PictureBox2()
        {
            return pic2;
        }
        public PictureBox Get_PictureBox()
        {
            return pic;
        }

        public PictureBox Get_PictureBox3()
        {
            return pic3;
        }



        public int flag = 0;
        int hei = 250, wid = 400;
        public bool optifine = true;

        private void Weight_TextChanged(object sender, EventArgs e)
        {
            int height_ = 250;
            bool success = int.TryParse(Height_box.Text, out height_);

            if (success == false)
            {
                Height_box.Text = "";
            }
            else
            {
                if (flag == 0)
                {
                    pic.Height = height_;
                }
                if (flag == 2)
                {
                    pic2.Height = height_;
                }
                if (flag == 3)
                {
                    pic3.Height = height_;
                }
                hei = height_;
            }
        }
        private void Height_box_Leave(object sender, EventArgs e)
        {
            if (Height_box.Text == "")
            {
                if (flag == 0)
                {
                    Height_box.Text = Convert.ToString(hei);
                    pic.Height = hei;
                }
                if (flag == 2)
                {
                    Height_box.Text = Convert.ToString(hei);
                    pic2.Height = hei;
                }
                if (flag == 3)
                {
                    Height_box.Text = Convert.ToString(hei);
                    pic3.Height = hei;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int width_ = 400;
            bool success = int.TryParse(Width_box.Text, out width_);

            if (success == false)
            {
                Width_box.Text = "";
            }
            else
            {
                if (flag == 0)
                {
                    pic.Width = width_;
                }
                if (flag == 2)
                {
                    pic2.Width = width_;
                }
                if (flag == 3)
                {
                    pic3.Width = width_;
                }
                wid = width_;
            }
        }
        private void Width_box_Leave(object sender, EventArgs e)
        {
            if (Width_box.Text == "")
            {
                if (flag == 0)
                {
                    Width_box.Text = Convert.ToString(wid);
                    pic.Width = wid;
                }
                if (flag == 2)
                {
                    Width_box.Text = Convert.ToString(wid);
                    pic2.Width = wid;
                }
                if (flag == 3)
                {
                    Width_box.Text = Convert.ToString(wid);
                    pic2.Width = wid;
                }
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
            {
                for (int i = 0; i < 2; i++)
                {
                    pic.Show();
                    pic2.Show();
                    pic3.Show();
                    flag = 0;
                    optifine = false;

                    int x = (this.Size.Width / 2 - pic.Width / 2) - 10;
                    int y = this.Size.Height / 2 - pic.Height / 2;
                    pic.Location = new Point(x, y);
                    pic.Width = this.Size.Width / 4 + 35;
                    pic.Height = this.Size.Height / 3;

                    int x2 = (this.Size.Width / 6 - pic2.Width / 2) - 10;
                    int y2 = this.Size.Height / 2 - pic2.Height / 2;
                    pic2.Location = new Point(x2, y2);
                    pic2.Width = this.Size.Width / 4 + 10;
                    pic2.Height = this.Size.Height / 3 - 20;

                    int x3 = (this.Size.Width - (this.Size.Width / 6) - pic3.Width / 2) - 10;
                    int y3 = this.Size.Height / 2 - pic3.Height / 2;
                    pic3.Location = new Point(x3, y3);
                    pic3.Width = this.Size.Width / 4 + 10;
                    pic3.Height = this.Size.Height / 3 - 20;
                }
            }
            if (e.KeyCode == Keys.W)
            {
                Size_Height(5);
                Size_Width(5);
            }
            if (e.KeyCode == Keys.S)
            {
                Size_Height(-5);
                Size_Width(-5);
            }
            if (e.KeyCode == Keys.Z)
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
        }
        private void Picture_Click(object sender, EventArgs e)
        {
            if (optifine == false)
            {
                pic2.Hide();
                pic3.Hide();

                flag = 0;
                optifine = true;

                int x = this.Size.Width / 2 - pic.Width / 2;
                int y = this.Size.Height / 2 - pic.Height / 2;
                pic.Location = new Point(x, y);
                pic.Width = this.Size.Width / 4 + 35;
                pic.Height = this.Size.Height / 3;
            }
        }
        int x, y;
        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            x = MousePosition.X - this.Left - (pic.Width / 2);
            y = (MousePosition.Y - this.Top - (this.Size.Height - this.ClientRectangle.Height)) - (pic.Height / 2);

            if (flag == 0)
            {
                pic.Location = new Point(x, y);
            }
            if (flag == 2)
            {
                pic2.Location = new Point(x, y);
            }
            if (flag == 3)
            {
                pic3.Location = new Point(x, y);
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (optifine == false)
            {
                pic.Hide();
                pic2.Hide();

                flag = 3;
                optifine = true;

                int x = this.Size.Width / 2 - pic.Width / 2;
                int y = this.Size.Height / 2 - pic.Height / 2;
                pic3.Location = new Point(x, y);
                pic3.Width = this.Size.Width / 4 + 35;
                pic3.Height = this.Size.Height / 3;
            }
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            if (optifine == false)
            {
                pic.Hide();
                pic3.Hide();

                flag = 2;
                optifine = true;

                int x = this.Size.Width / 2 - pic.Width / 2;
                int y = this.Size.Height / 2 - pic.Height / 2;
                pic2.Location = new Point(x, y);
                pic2.Width = this.Size.Width / 4 + 35;
                pic2.Height = this.Size.Height / 3;
            }
        }
        int rgb1, rgb2 = 0, rgb3 = 0;
        bool rgb_flag1 = true, rgb_flag2 = true, rgb_flag3 = true;
        private void rgb_color_Click(object sender, EventArgs e)
        {
            if (rgb_flag1 == false && rgb_flag2 == false && rgb_flag3 == false)
            {
                Back_Color(rgb1, rgb2, rgb3);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e) //rgb_1, я зыбал сначала поменять название
        {
            bool success = int.TryParse(rgb_1.Text, out rgb1);

            if (success == false)
            {
                rgb_1.Text = "";
            }
            else
            {
                rgb_flag1 = false;
            }
            if (rgb1 > 255)
            {
                MessageBox.Show("Введенное число не попадает в возможное разрешение! rgb<256");
                rgb_1.Text = "";
                rgb_flag1 = true;
            }
        }

        private void rgb_2_TextChanged(object sender, EventArgs e)
        {
            bool success = int.TryParse(rgb_2.Text, out rgb2);

            if (success == false)
            {
                rgb_2.Text = "";
            }
            else
            {
                rgb_flag2 = false;
            }
            if (rgb2 > 255)
            {
                MessageBox.Show("Введенное число не попадает в возможное разрешение! rgb<256");
                rgb_2.Text = "";
                rgb_flag2 = true;
            }
        }

        private void rgb_3_TextChanged(object sender, EventArgs e)
        {
            bool success = int.TryParse(rgb_3.Text, out rgb3);

            if (success == false)
            {
                rgb_3.Text = "";
            }
            else
            {
                rgb_flag3 = false;
            }
            if (rgb3 > 255)
            {
                MessageBox.Show("Введенное число не попадает в возможное разрешение! rgb<256");
                rgb_3.Text = "";
                rgb_flag3 = true;
            }
        }















        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void pic_LocationChanged(object sender, EventArgs e)
        {
            //x = MousePosition.X - pic.Width;
            //y = MousePosition.Y - pic.Height;
            //pic.Location = new Point(x, y);
        }
        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void Weight_box_Enter(object sender, EventArgs e)
        {
        //    if (Weight_box.Text == "Введите значение")
        //    {
        //        Weight_box.Text = " ";
        //        Weight_box.ForeColor = SystemColors.WindowText;
        //        label2.Text = Convert.ToString(Weight_box.Text);
        //    }
        }

        private void Weight_box_Leave(object sender, EventArgs e)
        {
        //    if (Weight_box.Text.Trim() == "")
        //    {
        //        Weight_box.Text = "Введите значение";
        //        Weight_box.ForeColor = SystemColors.GrayText;
        //        label2.Text = Convert.ToString(Weight_box.Text);
        //    }
        }
        public void picc()
        {

        }
        private void rgb_1_Leave(object sender, EventArgs e)
        {
            //rgb_1.Text = "r";
        }

        private void rgb_2_Leave(object sender, EventArgs e)
        {
            //rgb_2.Text = "g";
        }

        private void rgb_3_Leave(object sender, EventArgs e)
        {
            //rgb_3.Text = "b";
        }
        private void Picture_MouseCaptureChanged(object sender, EventArgs e)
        {
        }

        //private void pic_DoubleClick(object sender, EventArgs e)
                //{
                //    x = MousePosition.X - pic.Width;
                //    y = MousePosition.Y - pic.Height;
                //    pic.Location = new Point(x, y);
                //}
        private void pic_DragEnter(object sender, DragEventArgs e)
        {
        }
        public void picc(Bitmap image)
        {

        }
        private void pic_DragDrop(object sender, DragEventArgs e)
        {
        }

        private void pic_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
        }
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //    if (e.KeyChar =='q')
            //    {
            //        Height_box.Text = Convert.ToString(Picture.Height);
            //        Width_box.Text = Convert.ToString(Picture.Width);
            //    }
        }
        private void pic_QueryContinueDrag(object sender, QueryContinueDragEventArgs e)
        {
        }

        private void pic_MouseEnter(object sender, EventArgs e)
        {
            //x = MousePosition.X + pic.Height;
            //y = MousePosition.Y + pic.Width;
        }

        private void pic_MouseLeave(object sender, EventArgs e)
        {
            //pic.Location = new Point(x, y);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Height_box_Enter(object sender, EventArgs e)
        {
            //if (Height_box.Text == "0")
            //{
            //    Height_box.Text = " ";
            //}
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Width_box.Text = Convert.ToString(wid);
            //Height_box.Text = Convert.ToString(hei);
        }
        private void pic_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Width_box_Enter(object sender, EventArgs e)
        {
            
        }
    }
}