using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuttingApp
{
    public partial class MainForm : Form
    {
        Detail detail;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void CreateRect(PaintEventArgs e)
        {
            detail = new Detail("Material", 2750, 1830);
            Pen pen = new Pen(Color.Black);
            Rectangle rect = new Rectangle(10, 10, detail.Length, detail.Width);
            //rect.Size = new Size(detail.Length, detail.Width);
            e.Graphics.ScaleTransform(0.1f, 0.1f);
            e.Graphics.DrawRectangle(pen, rect);

        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            CreateRect(e);
        }
    }
}
