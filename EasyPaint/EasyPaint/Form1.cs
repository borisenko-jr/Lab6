using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Cursor = new Cursor("Pencil.cur");
            mainPen = new Pen(this.ForeColor);
        }

        //Переменная, отвечающая за включения режима рисования.
        //Значение true — режим включен
        bool DrawMode = false;
        //Создаем массив точек, из которых будут формироваться линии
        ArrayList points = new ArrayList();
        Pen mainPen;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //Если нажата левая кнопка мыши
            if (e.Button == MouseButtons.Left)
            {
                //Включаем режим рисования
                DrawMode = true;
                //Удаляем все элементы из массива points
                points.Clear();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //Если включен режим рисования
            if (DrawMode)
            {
                //Создаем экземпляр pt класса Point,
                //представляющий собой точку с координатами мыши в данный момент
                Point pt = new Point(e.X, e.Y);
                //Добавляем созданную точку в массив points
                points.Add(pt);
                if (points.Count <= 1) return;
                //Создаем новый массив pts, содержащий число  точек в массиве points
                Point[] pts = new Point[points.Count];
                //Преобразуем массив points в массив pts, начиная с первого элемента
                points.CopyTo(pts, 0);
                //Создаем экземпляр graph класса Graphics для рисования
                Graphics graph = this.CreateGraphics();
                //Вызываем метод DrawCurve для рисования кривой, которому 
                //передаем перо mainPen и массив pts
                graph.DrawCurve(mainPen, pts);

            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //Отключаем режим рисования.
            DrawMode = false;
        }

        private void mnuColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                mainPen = new Pen(colorDialog1.Color);
            }
        }

        private void mnuWidth_Click(object sender, EventArgs e)
        {
            LineWidth diag = new LineWidth();
            if (diag.ShowDialog(this) == DialogResult.OK)
            {
                mainPen = new Pen(mainPen.Color, diag.PenWidth);
            }
        }
    }
}
