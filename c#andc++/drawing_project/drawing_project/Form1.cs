using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawing_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.White);
            g.DrawPie(Pens.Silver, 100, 200, 300, 400, 500, 600);
        }
    }
}
