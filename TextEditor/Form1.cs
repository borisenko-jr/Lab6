using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Drawing.Printing;

namespace TextEditor
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem mnuFile;
        private System.Windows.Forms.MenuItem mnuOpen;
        private System.Windows.Forms.MenuItem mnuSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MenuItem menuItem1;
        private MenuItem menuItem2;
        private MenuItem mnuPageSetup;
        private MenuItem mnuPrintPreview;
        private MenuItem mnuPrint;
        private RichTextBox rtbText;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PageSetupDialog pageSetupDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private PrintDialog printDialog1;
        private IContainer components;
        //Переменная для хранения текста для печати.
        //В нее мы будем помещать текст из RichTextBox
        string stringPrintText;
        //Переменная, определяющая номер страницы, с которой нужно начать печать
        int StartPage;
        //Переменная, определяющая количество страниц для печати:
        int NumPages;
        //Переменная, определяющая номер текущей страницы:
        int PageNumber;

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            printDialog1.Document = printDocument1;
            //Определяем номер страницы, с которой следует начать печать
            printDialog1.PrinterSettings.FromPage = 1;
            //Определяем максимальный номер печатаемой страницы.
            printDialog1.PrinterSettings.ToPage = printDialog1.PrinterSettings.MaximumPage;
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuOpen = new System.Windows.Forms.MenuItem();
            this.mnuSave = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mnuPageSetup = new System.Windows.Forms.MenuItem();
            this.mnuPrintPreview = new System.Windows.Forms.MenuItem();
            this.mnuPrint = new System.Windows.Forms.MenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFile});
            // 
            // mnuFile
            // 
            this.mnuFile.Index = 0;
            this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.mnuOpen,
            this.mnuSave,
            this.menuItem2,
            this.mnuPageSetup,
            this.mnuPrintPreview,
            this.mnuPrint});
            this.mnuFile.Text = "&File";
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "&Файл";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Index = 1;
            this.mnuOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.mnuOpen.Text = "&Открыть";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Index = 2;
            this.mnuSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.mnuSave.Text = "&Сохранить";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 3;
            this.menuItem2.Text = "-";
            // 
            // mnuPageSetup
            // 
            this.mnuPageSetup.Index = 4;
            this.mnuPageSetup.Text = "Пара&метры страницы";
            this.mnuPageSetup.Click += new System.EventHandler(this.mnuPageSetup_Click);
            // 
            // mnuPrintPreview
            // 
            this.mnuPrintPreview.Index = 5;
            this.mnuPrintPreview.Text = "Пред&варительный просмотр ";
            this.mnuPrintPreview.Click += new System.EventHandler(this.mnuPrintPreview_Click);
            // 
            // mnuPrint
            // 
            this.mnuPrint.Index = 6;
            this.mnuPrint.Text = "&Печать";
            this.mnuPrint.Click += new System.EventHandler(this.mnuPrint_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Текстовые файлы";
            this.openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*  ";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Текстовые файлы";
            this.saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*  ";
            // 
            // rtbText
            // 
            this.rtbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbText.Location = new System.Drawing.Point(0, 0);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(292, 266);
            this.rtbText.TabIndex = 0;
            this.rtbText.Text = "";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.AllowSelection = true;
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.rtbText);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }

        private void mnuOpen_Click(object sender, System.EventArgs e)
        {
            //Показываем диалог выбора файла
            openFileDialog1.ShowDialog();
            // Переменной fileName присваиваем имя открываемого файла
            string fileName = openFileDialog1.FileName;
            //Создаем поток fs и открываем файл для чтения.
            FileStream filestream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            //Проверяем,  открыт ли поток,  и если открыт, выполняем условие
            if (filestream != null)
            {
                //Создаем объект streamreader и связываем его с потоком filestream
                StreamReader streamreader = new StreamReader(filestream /*System.Text.Encoding.Unicode*/);
                //Считываем весь файл и записываем его в TextBox
                rtbText.Text = streamreader.ReadToEnd();
                //Закрываем поток.
                filestream.Close();
            }
        }

  

        private void mnuSave_Click(object sender, System.EventArgs e)
        {
            //Показываем диалог выбора файла
            saveFileDialog1.ShowDialog();
            // В качестве имени сохраняемого файла устанавливаем переменную fileName
            string fileName = saveFileDialog1.FileName;
            //Создаем поток fs и открываем файл для записи.
            FileStream filestream = File.Open(fileName, FileMode.Create, FileAccess.Write);
            //Проверяем,  открыт ли поток,  и если открыт, выполняем условие
            if (filestream != null)
            {
                //Создаем объект streamwriter и связываем его с потоком filestream
                StreamWriter streamwriter = new StreamWriter(filestream);
                //Записываем данные из TextBox в файл
                streamwriter.Write(rtbText.Text);
                //Переносим данные из потока в файл
                streamwriter.Flush();
                //Закрываем поток
                filestream.Close();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graph = e.Graphics;
            //Создаем объект font, которому устанавливаем 
            // шрифт элемента rtbText
            Font font = rtbText.Font;
            //Получаем значение межстрочного интервала — высоту шрифта 
            float HeightFont = font.GetHeight(graph);
            //Создаем экземпляр strfmt класса StringFormat для определения 
            //дополнительных параметров форматирования текста.
            StringFormat stringformat = new StringFormat();
            //Создаем экземляры  rectanglefFull и rectfText класса RectangleF для 
            //определения областей печати и текста. 
            RectangleF rectanglefFull, rectanglefText;
            //Создаем переменные для подсчета числа символов и строк.
            int NumberSymbols, NumberLines;
            //В качестве области печати устанавливаем объект rectanglefFull
            if (graph.VisibleClipBounds.X < 0) rectanglefFull = e.MarginBounds;
            else
                //Определяем   объект  rectanglefFull
                rectanglefFull = new RectangleF(
                    //Устанавливаем координату  X  
                    e.MarginBounds.Left - (e.PageBounds.Width - graph.VisibleClipBounds.Width) / 2,
                    //Устанавливаем координату  Y
                    e.MarginBounds.Top - (e.PageBounds.Height - graph.VisibleClipBounds.Height) / 2,
                    //Устанавливаем ширину области
                    e.MarginBounds.Width,
                    //Устанавливаем высоту области
                    e.MarginBounds.Height);
            rectanglefText = RectangleF.Inflate(rectanglefFull, 0, -2 * HeightFont);
            //Определяем число строк
            int NumDisplayLines = (int)Math.Floor(rectanglefText.Height / HeightFont);
            //Устанавливаем высоту области
            rectanglefText.Height = NumDisplayLines * HeightFont;

            if (rtbText.WordWrap)
            {
                stringformat.Trimming = StringTrimming.Word;
            }
            else
            {
                stringformat.Trimming = StringTrimming.EllipsisCharacter;
                stringformat.FormatFlags |= StringFormatFlags.NoWrap;
            }
            //При печати выбранных страниц переходим к первой стартовой странице
            while ((PageNumber < StartPage) && (stringPrintText.Length > 0))
            {
                if (rtbText.WordWrap)
                    //Измеряем текстовые переменные, 
                    //формирующие печать,  и возвращаем число символов NumberSymbols
                    //и число строк NumberLines
                    graph.MeasureString(stringPrintText, font, rectanglefText.Size, stringformat, out NumberSymbols, out NumberLines);
                else
                    NumberSymbols = SymbolsInLines(stringPrintText, NumDisplayLines);
                stringPrintText = stringPrintText.Substring(NumberSymbols);
                //Увеличиваем число страниц 
                PageNumber++;
            }
            //Если длина строки stringPrintText равняется нулю (нет текста для печати),
            // Останавливаем печать
            if (stringPrintText.Length == 0)
            {
                e.Cancel = true;
                return;
            }
            //Выводим (рисуем) текст для печати - stringPrintText, используем для этого шрифт font,
            //кисть черного цвета  - Brushes.Black, область печати - rectanglefText,
            //передаем строку  дополнительного форматирования stringformat
            graph.DrawString(stringPrintText, font, Brushes.Black, rectanglefText, stringformat);
            //Получаем текст для следующей страницы
            if (rtbText.WordWrap)
                graph.MeasureString(stringPrintText, font, rectanglefText.Size, stringformat, out NumberSymbols, out NumberLines);
            else
                NumberSymbols = SymbolsInLines(stringPrintText, NumDisplayLines);
            stringPrintText = stringPrintText.Substring(NumberSymbols);
            //Очищаем объект stringformat, использованный для формирования полей.
            stringformat = new StringFormat();
            //Добавляем  вывод на каждую страницу ее номер
            stringformat.Alignment = StringAlignment.Far;
            graph.DrawString("Страница " + PageNumber, font, Brushes.Black, rectanglefFull, stringformat);
            PageNumber++;
            //Cнова проверяем, имеется ли текст для печати и номер страницы, заданной для печати
            e.HasMorePages = (stringPrintText.Length > 0) && (PageNumber < StartPage + NumPages);
            //Для печати из окна предварительного просмотра  снова инициализируем переменные
            if (!e.HasMorePages)
            {
                stringPrintText = rtbText.Text;
                StartPage = 1;
                NumPages = printDialog1.PrinterSettings.MaximumPage;
                PageNumber = 1;
            }


        }


        int SymbolsInLines(string stringPrintText, int NumLines)
        {
            int index = 0;
            for (int i = 0; i < NumLines; i++)
            {
                index = 1 + stringPrintText.IndexOf('\n', index);
                if (index == 0)
                    return stringPrintText.Length;
            }
            return index;
        }

        private void mnuPrint_Click(object sender, EventArgs e)
        {
            printDialog1.AllowSelection = rtbText.SelectionLength > 0;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.DocumentName = Text;
                //Определяем диапазон страниц для печати
                switch (printDialog1.PrinterSettings.PrintRange)
                {
                    //Выбраны все страницы
                    case PrintRange.AllPages:
                        stringPrintText = rtbText.Text;
                        StartPage = 1;
                        NumPages = printDialog1.PrinterSettings.MaximumPage;
                        break;
                    //Выбрана выделенная область
                    case PrintRange.Selection:
                        stringPrintText = rtbText.SelectedText;
                        StartPage = 1;
                        NumPages = printDialog1.PrinterSettings.MaximumPage;
                        break;
                    //Выбран ряд страниц
                    case PrintRange.SomePages:
                        stringPrintText = rtbText.Text;
                        StartPage = printDialog1.PrinterSettings.FromPage;
                        NumPages = printDialog1.PrinterSettings.ToPage - StartPage + 1;
                        break;
                }
                PageNumber = 1;
                //Вызываем встроенный метод для начала печати
                printDocument1.Print();
            }
        }

        private void mnuPrintPreview_Click(object sender, EventArgs e)
        {
            //Инициализируем переменные
            printDocument1.DocumentName = Text;
            stringPrintText = rtbText.Text;
            StartPage = 1;
            NumPages = printDialog1.PrinterSettings.MaximumPage;
            PageNumber = 1;
            //Показываем диалог
            printPreviewDialog1.ShowDialog();
        }

        private void mnuPageSetup_Click(object sender, EventArgs e)
        {
            //Показываем диалог
            pageSetupDialog1.ShowDialog();
        }
    }
}

