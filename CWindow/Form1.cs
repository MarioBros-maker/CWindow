using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "可恶啊...竟然不能把C#作为文件名？！";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "我猜是因为#不能作为文件名吧";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
