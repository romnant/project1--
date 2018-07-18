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
    public partial class Form1 : Form
    {
        private Form2 Skin;
        public Form1()
        {
            InitializeComponent();
            ShowInTaskbar = false;//任务栏显示
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0xff, 0x00, 0xff, 0x00);
            this.TransparencyKey = Color.FromArgb(0xff, 0x00, 0xff, 0x00);
            if (!DesignMode)
            {
                Skin = new Form2(this);//创建皮肤层 
                Skin.Show();//显示皮肤层 
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
             this.Close();
        }
    }
}