using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class Form2 : Form
    {
        private Form1 Main;
        public Form2(Form1 main)
        {
            InitializeComponent();
            Main = main;//获取控件层对象
            ShowInTaskbar = true;//使背景层在任务栏影藏
            Main.Owner = this;//设置控件层的拥有皮肤层
            Location = new Point(Main.Location.X, Main.Location.Y);//统一控件层和皮肤层的位置
        }
        Point downPoint;//窗口拖动

        private void Form2_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0xff, 0x00, 0xff, 0x00);
            this.TransparencyKey = Color.FromArgb(0xff, 0x00, 0xff, 0x00);
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            downPoint = new Point(e.X, e.Y); //窗口拖动
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                #region 窗口拖动
                ///窗口拖动
                this.Location = new Point(this.Location.X + e.X - downPoint.X,this.Location.Y + e.Y - downPoint.Y);
                Main.Location = this.Location;
                #endregion
            }
        }
    }
}
