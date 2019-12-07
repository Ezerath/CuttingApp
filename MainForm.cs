using System;
using System.Drawing;
using System.Windows.Forms;

namespace CuttingApp
{
    public partial class MainForm : Form
    {
        PictureBox materialPB;
        PictureBox detailPB;
        Size tempX;
        Size tempY;
        bool rotated = false;
        Point mouseLocation;
        int scale = 4;
        public MainForm()
        {
            InitializeComponent();
            addMaterialButton.Click += AddButton_Click;
            addDetailButton.Click += AddDetailButton_Click;
        }

        private void AddDetailButton_Click(object sender, EventArgs e)
        {
            if (materialPB != null)
            {
                CreateDetail();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CreateMaterial();
        }
        //private void CreateRect(PaintEventArgs e)
        //{
        //    detail = new Detail("Material", 2750, 1830);
        //    Pen pen = new Pen(Color.Black);
        //    Rectangle rect = new Rectangle(10, 10, detail.Xsize, detail.Ysize);
        //    e.Graphics.ScaleTransform(0.2f, 0.2f);
        //    e.Graphics.DrawRectangle(pen, rect);

        //}
        private void CreateMaterial()
        {
            var material = new Detail("Material", 2750, 1830);
            materialPB = new PictureBox
            {
                Size = new Size(material.Xsize / scale, material.Ysize / scale),
                Location = new Point(10, 10),
                BorderStyle = BorderStyle.FixedSingle,
                ImageLocation = "Gray.jpg",
            };
            panel.Controls.Add(materialPB);
        }
        private void CreateDetail()
        {
            detailPB = new PictureBox
            {
                Size = new Size(720 / scale, 320 / scale),
                Location = new Point(10, 10),
                BorderStyle = BorderStyle.FixedSingle,
                ImageLocation = "Gray.jpg",
            };
            //detailPB.Click += DetailPB_Click;
            detailPB.MouseDown += DetailPB_MouseDown;
            detailPB.MouseMove += DetailPB_MouseMove;
            tempX = new Size(detailPB.Width, detailPB.Height);
            tempY = new Size(detailPB.Height, detailPB.Width);
            materialPB.Controls.Add(detailPB);
        }

        private void DetailPB_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                detailPB.Left = e.X + detailPB.Left - mouseLocation.X;
                detailPB.Top = e.Y + detailPB.Top - mouseLocation.Y;
            }
        }

        private void DetailPB_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mouseLocation = e.Location;
            if (e.Button == MouseButtons.Right)
            {
                if (!rotated)
                {
                    detailPB.Size = tempX;
                    rotated = true;
                }
                else
                {
                    detailPB.Size = tempY;
                    rotated = false;
                }
            }
        }

        private void DetailPB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("check");
        }
    }
}
