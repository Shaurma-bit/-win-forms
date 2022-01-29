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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
        Form1 f1 = new Form1();

        public void pic1()
        {
             
        }
        private void enter1_Click(object sender, EventArgs e)
        {
            Bitmap image;

            
            
            PictureBox pic2 = ((Form1)Application.OpenForms[0]).Get_PictureBox2();

            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    pic2.Size = pic2.Size;
                    pic2.Image = image;
                    int x = f1.Size.Width / 6 - pic2.Width / 2;
                    int y = f1.Size.Height / 2 - pic2.Height / 2;
                    pic2.Location = new Point(x, y);
                    pic2.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void enter2_Click(object sender, EventArgs e)
        {
            
        }

        private void enter3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Bitmap image;



            PictureBox pic2 = ((Form1)Application.OpenForms[0]).Get_PictureBox2();

            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    pic2.Size = pic2.Size;
                    pic2.Image = image;
                    int x = f1.Size.Width / 6 - pic2.Width / 2;
                    int y = f1.Size.Height / 2 - pic2.Height / 2;
                    pic2.Location = new Point(x, y);
                    pic2.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bitmap image;



            PictureBox pic3 = ((Form1)Application.OpenForms[0]).Get_PictureBox3();

            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    pic3.Size = pic3.Size;
                    pic3.Image = image;
                    int x = f1.Size.Width - (f1.Size.Width / 6) - pic3.Width / 2;
                    int y = f1.Size.Height / 2 - pic3.Height / 2;
                    pic3.Location = new Point(x, y);
                    pic3.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Bitmap image;



            PictureBox pic = ((Form1)Application.OpenForms[0]).Get_PictureBox();

            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    pic.Size = pic.Size;
                    pic.Image = image;
                    int x = f1.Size.Width / 2 - pic.Width / 2;
                    int y = f1.Size.Height / 2 - pic.Height / 2;
                    pic.Location = new Point(x, y);
                    pic.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}