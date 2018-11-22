using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            diag.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (diag.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(diag.OpenFile());
            }
            pictureBox1.Image = new Bitmap(diag.OpenFile());
            //Строка для вывода   во время загрузки изображения
            sbFile.Text = "Загрузка " + diag.FileName;
            //Строка для вывода после загрузки изображения		
            sbFile.Text = "Изображение " + diag.FileName;
            //Вывод ширины (Width) и высоты (Height) изображения
            sbSize.Text = String.Format("{0:#} x {1:#}", pictureBox1.Image.Width, pictureBox1.Image.Height);
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog diag = new SaveFileDialog();
            diag.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            if (diag.ShowDialog() != DialogResult.OK)
                return;
            // Получаем адрес файла.
            string filename = diag.FileName;
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.ReadWrite);
            pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
            fs.Close();
        }

        private PictureBoxSizeMode[] ArrayMenu = { PictureBoxSizeMode.StretchImage, PictureBoxSizeMode.Normal, PictureBoxSizeMode.CenterImage, PictureBoxSizeMode.AutoSize };
        private int selectedMode = 0;

        private void mnuResize_Click(object sender, EventArgs e)
        {
            if (sender is MenuItem)
            {
                MenuItem menuitem = (MenuItem)sender;
                selectedMode = menuitem.Index;
                pictureBox1.SizeMode = ArrayMenu[0];
                pictureBox1.Invalidate();

            }
        }

        private void mnuActual_Click(object sender, EventArgs e)
        {
            if (sender is MenuItem)
            {
                MenuItem menuitem = (MenuItem)sender;
                selectedMode = menuitem.Index;

                pictureBox1.SizeMode = ArrayMenu[1];
                pictureBox1.Invalidate();

            }
        }

        private void mnuCenterImage_Click(object sender, EventArgs e)
        {
            if (sender is MenuItem)
            {
                MenuItem menuitem = (MenuItem)sender;
                selectedMode = menuitem.Index;

                pictureBox1.SizeMode = ArrayMenu[2];
                pictureBox1.Invalidate();

            }
        }

        private void mnuAutoSize_Click(object sender, EventArgs e)
        {
            if (sender is MenuItem)
            {
                MenuItem menuitem = (MenuItem)sender;
                selectedMode = menuitem.Index;

                pictureBox1.SizeMode = ArrayMenu[3];
                pictureBox1.Invalidate();

            }
        }

        private void mnuView_Popup(object sender, EventArgs e)
        {
            if (sender is MenuItem)
            {
                bool ImLoad = (pictureBox1.Image != null);
                foreach (MenuItem menuitem in ((MenuItem)sender).MenuItems)
                {
                    menuitem.Enabled = ImLoad;
                    menuitem.Checked = (this.selectedMode == menuitem.Index);
                }
            }
        }

        private void cmnuResize_Click(object sender, System.EventArgs e)
        {
            if (sender is MenuItem)
            {
                MenuItem menuitem = (MenuItem)sender;
                selectedMode = menuitem.Index;

                pictureBox1.SizeMode = ArrayMenu[0];
                pictureBox1.Invalidate();

            }
        }

        private void cmnuActual_Click(object sender, System.EventArgs e)
        {
            if (sender is MenuItem)
            {
                MenuItem menuitem = (MenuItem)sender;
                selectedMode = menuitem.Index;

                pictureBox1.SizeMode = ArrayMenu[1];
                pictureBox1.Invalidate();

            }
        }

        private void cmnuCenterImage_Click(object sender, System.EventArgs e)
        {
            if (sender is MenuItem)
            {
                MenuItem menuitem = (MenuItem)sender;
                selectedMode = menuitem.Index;

                pictureBox1.SizeMode = ArrayMenu[2];
                pictureBox1.Invalidate();

            }
        }

        private void cmnuAutoSize_Click(object sender, System.EventArgs e)
        {
            if (sender is MenuItem)
            {
                MenuItem menuitem = (MenuItem)sender;
                selectedMode = menuitem.Index;

                pictureBox1.SizeMode = ArrayMenu[3];
                pictureBox1.Invalidate();

            }
        }

        private void mnuPageSetup_Click(object sender, EventArgs e)
        {
            PageSetupDialog diag = new PageSetupDialog();
            diag.Document = printDocument1;
            diag.ShowDialog();
        }

        private void mnuPrintPreview_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog diag = new PrintPreviewDialog();
            diag.Document = printDocument1;
            diag.ShowDialog();
        }

        private void mnuPrint_Click(object sender, EventArgs e)
        {
            PrintDialog diag = new PrintDialog();
            diag.Document = printDocument1;
            if (diag.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                e.Cancel = true;
                return;
            }
            float leftMargin = e.MarginBounds.Left;
            float rightMargin = e.MarginBounds.Right;
            float topMargin = e.MarginBounds.Top;
            float bottomMargin = e.MarginBounds.Bottom;
            float printableWidth = e.MarginBounds.Width;
            float printableHeight = e.MarginBounds.Height;
            Graphics graph = e.Graphics;
            Font font = new Font("Comic Sans MS", 16);
            //Определяем высоту шрифта
            float fontHeight = font.GetHeight(graph);
            //Определяем размер пробелов 
            float spaceWidth = graph.MeasureString(" ", font).Width;
            float imageLength;
            float Xposition = leftMargin;
            float Yposition = topMargin + fontHeight;
            if (printableWidth < printableHeight)
            {
                imageLength = printableWidth * 90 / 100;
                Yposition += imageLength;
            }
            else
            {
                imageLength = printableHeight * 90 / 100;
                Xposition += imageLength + spaceWidth;
            }
            Rectangle rectImage = new Rectangle((int)leftMargin + 1, (int)topMargin + 1, (int)imageLength, (int)imageLength);
            graph.DrawImage(pictureBox1.Image, (int)leftMargin + 1, (int)topMargin + 1, (int)imageLength, (int)imageLength);
            RectangleF rectText = new RectangleF(Xposition, Yposition, rightMargin - -Xposition, bottomMargin - Yposition);
            PrintText(graph, font, "Размер изображения: ", Convert.ToString
            (pictureBox1.Image.Size), ref rectText);
        }

        protected void PrintText(Graphics graph, Font font, string name, string text, ref RectangleF rectText)
        {
            // Определяем размеры печатной области для текста:
            float leftMargin = rectText.Left;
            float rightMargin = rectText.Right;
            float topMargin = rectText.Top;
            float bottomMargin = rectText.Bottom;
            //Определяем высоту текста и координаты, где он будет выводиться:
            float fontHeight = font.GetHeight(graph);
            float Xposition = rectText.Left;
            float Yposition = topMargin + fontHeight;
            //Определяем ширину текста и размер пробелов
            float spaceWidth = graph.MeasureString(" ", font).Width;
            float nameWidth = graph.MeasureString(name, font).Width;
            graph.DrawString(name, font,
            Brushes.Black, new PointF(Xposition, Yposition));
            leftMargin += nameWidth + spaceWidth;
            Xposition = leftMargin;
            // Формируем несколько строк для текста  в случае,
            // если он не будет умещаться на одной строке
            string[] words
               = text.Split(" \r\t\n\0".ToCharArray());
            foreach (string word in words)
            {
                float wordWidth = graph.MeasureString(
                   word, font).Width;
                if (wordWidth == 0.0)
                    continue;
                if (Xposition + wordWidth > rightMargin)
                {
                    // Начало с новой строки
                    Xposition = leftMargin;
                    Yposition += fontHeight;
                    if (Yposition > bottomMargin)
                    {
                        break;
                    }
                }
                graph.DrawString(word, font, Brushes.Black, new PointF(Xposition, Yposition));
                Xposition += wordWidth;
            }
            // Исключаем область, на которую был выведен текст, из области печати 
            //для избежания наложения текста и рисунка
            rectText.Y = Yposition;
            rectText.Height = bottomMargin - Yposition;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
