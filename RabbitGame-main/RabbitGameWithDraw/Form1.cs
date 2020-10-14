using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitGameWithDraw
{
    public partial class Form1 : Form
    {
        public Transform tr = new Transform();
        private Rabbit rabbit;
        public Form1()
        {
            rabbit = Rabbit.CreateRabbit(); 
            InitializeComponent();  
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            tr.angel += 1;
            Paint();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
             Paint();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tr.scale = tr.scale * (2);
            Paint();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tr.scale = tr.scale * (0.5);
            Paint();
        }

        private void Paint()
        {
            Figure.SetOffsets(canvas.Size.Width / 2, canvas.Size.Height / 2);
            Pen pn = new Pen(Color.Black, 1);  // Перо для рисования
            Graphics g = canvas.CreateGraphics();
            Point center = new Point(0, 0);
            g.FillRectangle(Brushes.White, 0, 0, canvas.Size.Width, canvas.Size.Height);
            g.DrawLine(pn, 0, (int)canvas.Size.Height / 2, canvas.Size.Width, (int)canvas.Size.Height / 2);
            g.DrawLine(pn, (int)canvas.Size.Width / 2, 0, (int)canvas.Size.Width / 2, canvas.Size.Height);
            rabbit.Draw(g, pn, tr);
        }

        private void canvas_SizeChanged(object sender, EventArgs e)
        {
            Paint();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tr.x += 2;
            Paint();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tr.x -= 2;
            Paint();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tr.y += 2;
            Paint();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tr.y -= 2;
            Paint();
        }
    }
}
