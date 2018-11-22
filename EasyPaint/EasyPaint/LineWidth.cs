using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyPaint
{
    public partial class LineWidth : Form
    {
        public LineWidth()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void DrawLine()
        {
            //Создаем переменную, которая равна ординате точки, 
            //делящий элемент panel1 по высоте пополам
            int y = panel1.Bottom / 2;
            //Создаем точку point1 лежащей на левой границе панели, c ординатой y
            Point point1 = new Point(panel1.Left, y);
            //Создаем точку point2 лежащей на правой  границе панели, c ординатой y
            Point point2 = new Point(panel1.Right, y);
            //Создаем экземпляр graph класса Graphics для рисования
            Graphics graph = panel1.CreateGraphics();
            //Определяем толщину линии, равную значению в элементе numericUpDown1
            float f = Decimal.ToSingle(numericUpDown1.Value);
            //Создаем экземпляр pen для рисования линии 
            Pen pen = new Pen(Color.Blue, f);
            //Соединяем точки point1 и point2
            graph.DrawLine(pen, point1, point2);
        }

        public float PenWidth
        {
            get
            {
                float f = Decimal.ToSingle(numericUpDown1.Value);
                return f;
            }
        }

        private void LineWidth_Paint(object sender, PaintEventArgs e)
        {
            DrawLine();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int val = trackBar1.Value;
            numericUpDown1.Value = val;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int val2 = (int)numericUpDown1.Value;
            trackBar1.Value = val2;
            DrawLine();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
