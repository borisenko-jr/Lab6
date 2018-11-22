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
        //���������� ��� �������� ������ ��� ������.
        //� ��� �� ����� �������� ����� �� RichTextBox
        string stringPrintText;
        //����������, ������������ ����� ��������, � ������� ����� ������ ������
        int StartPage;
        //����������, ������������ ���������� ������� ��� ������:
        int NumPages;
        //����������, ������������ ����� ������� ��������:
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
            //���������� ����� ��������, � ������� ������� ������ ������
            printDialog1.PrinterSettings.FromPage = 1;
            //���������� ������������ ����� ���������� ��������.
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
            this.menuItem1.Text = "&����";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Index = 1;
            this.mnuOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.mnuOpen.Text = "&�������";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Index = 2;
            this.mnuSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.mnuSave.Text = "&���������";
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
            this.mnuPageSetup.Text = "����&����� ��������";
            this.mnuPageSetup.Click += new System.EventHandler(this.mnuPageSetup_Click);
            // 
            // mnuPrintPreview
            // 
            this.mnuPrintPreview.Index = 5;
            this.mnuPrintPreview.Text = "����&����������� �������� ";
            this.mnuPrintPreview.Click += new System.EventHandler(this.mnuPrintPreview_Click);
            // 
            // mnuPrint
            // 
            this.mnuPrint.Index = 6;
            this.mnuPrint.Text = "&������";
            this.mnuPrint.Click += new System.EventHandler(this.mnuPrint_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "��������� �����";
            this.openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*  ";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "��������� �����";
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
            //���������� ������ ������ �����
            openFileDialog1.ShowDialog();
            // ���������� fileName ����������� ��� ������������ �����
            string fileName = openFileDialog1.FileName;
            //������� ����� fs � ��������� ���� ��� ������.
            FileStream filestream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            //���������,  ������ �� �����,  � ���� ������, ��������� �������
            if (filestream != null)
            {
                //������� ������ streamreader � ��������� ��� � ������� filestream
                StreamReader streamreader = new StreamReader(filestream /*System.Text.Encoding.Unicode*/);
                //��������� ���� ���� � ���������� ��� � TextBox
                rtbText.Text = streamreader.ReadToEnd();
                //��������� �����.
                filestream.Close();
            }
        }

  

        private void mnuSave_Click(object sender, System.EventArgs e)
        {
            //���������� ������ ������ �����
            saveFileDialog1.ShowDialog();
            // � �������� ����� ������������ ����� ������������� ���������� fileName
            string fileName = saveFileDialog1.FileName;
            //������� ����� fs � ��������� ���� ��� ������.
            FileStream filestream = File.Open(fileName, FileMode.Create, FileAccess.Write);
            //���������,  ������ �� �����,  � ���� ������, ��������� �������
            if (filestream != null)
            {
                //������� ������ streamwriter � ��������� ��� � ������� filestream
                StreamWriter streamwriter = new StreamWriter(filestream);
                //���������� ������ �� TextBox � ����
                streamwriter.Write(rtbText.Text);
                //��������� ������ �� ������ � ����
                streamwriter.Flush();
                //��������� �����
                filestream.Close();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graph = e.Graphics;
            //������� ������ font, �������� ������������� 
            // ����� �������� rtbText
            Font font = rtbText.Font;
            //�������� �������� ������������ ��������� � ������ ������ 
            float HeightFont = font.GetHeight(graph);
            //������� ��������� strfmt ������ StringFormat ��� ����������� 
            //�������������� ���������� �������������� ������.
            StringFormat stringformat = new StringFormat();
            //������� ���������  rectanglefFull � rectfText ������ RectangleF ��� 
            //����������� �������� ������ � ������. 
            RectangleF rectanglefFull, rectanglefText;
            //������� ���������� ��� �������� ����� �������� � �����.
            int NumberSymbols, NumberLines;
            //� �������� ������� ������ ������������� ������ rectanglefFull
            if (graph.VisibleClipBounds.X < 0) rectanglefFull = e.MarginBounds;
            else
                //����������   ������  rectanglefFull
                rectanglefFull = new RectangleF(
                    //������������� ����������  X  
                    e.MarginBounds.Left - (e.PageBounds.Width - graph.VisibleClipBounds.Width) / 2,
                    //������������� ����������  Y
                    e.MarginBounds.Top - (e.PageBounds.Height - graph.VisibleClipBounds.Height) / 2,
                    //������������� ������ �������
                    e.MarginBounds.Width,
                    //������������� ������ �������
                    e.MarginBounds.Height);
            rectanglefText = RectangleF.Inflate(rectanglefFull, 0, -2 * HeightFont);
            //���������� ����� �����
            int NumDisplayLines = (int)Math.Floor(rectanglefText.Height / HeightFont);
            //������������� ������ �������
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
            //��� ������ ��������� ������� ��������� � ������ ��������� ��������
            while ((PageNumber < StartPage) && (stringPrintText.Length > 0))
            {
                if (rtbText.WordWrap)
                    //�������� ��������� ����������, 
                    //����������� ������,  � ���������� ����� �������� NumberSymbols
                    //� ����� ����� NumberLines
                    graph.MeasureString(stringPrintText, font, rectanglefText.Size, stringformat, out NumberSymbols, out NumberLines);
                else
                    NumberSymbols = SymbolsInLines(stringPrintText, NumDisplayLines);
                stringPrintText = stringPrintText.Substring(NumberSymbols);
                //����������� ����� ������� 
                PageNumber++;
            }
            //���� ����� ������ stringPrintText ��������� ���� (��� ������ ��� ������),
            // ������������� ������
            if (stringPrintText.Length == 0)
            {
                e.Cancel = true;
                return;
            }
            //������� (������) ����� ��� ������ - stringPrintText, ���������� ��� ����� ����� font,
            //����� ������� �����  - Brushes.Black, ������� ������ - rectanglefText,
            //�������� ������  ��������������� �������������� stringformat
            graph.DrawString(stringPrintText, font, Brushes.Black, rectanglefText, stringformat);
            //�������� ����� ��� ��������� ��������
            if (rtbText.WordWrap)
                graph.MeasureString(stringPrintText, font, rectanglefText.Size, stringformat, out NumberSymbols, out NumberLines);
            else
                NumberSymbols = SymbolsInLines(stringPrintText, NumDisplayLines);
            stringPrintText = stringPrintText.Substring(NumberSymbols);
            //������� ������ stringformat, �������������� ��� ������������ �����.
            stringformat = new StringFormat();
            //���������  ����� �� ������ �������� �� �����
            stringformat.Alignment = StringAlignment.Far;
            graph.DrawString("�������� " + PageNumber, font, Brushes.Black, rectanglefFull, stringformat);
            PageNumber++;
            //C���� ���������, ������� �� ����� ��� ������ � ����� ��������, �������� ��� ������
            e.HasMorePages = (stringPrintText.Length > 0) && (PageNumber < StartPage + NumPages);
            //��� ������ �� ���� ���������������� ���������  ����� �������������� ����������
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
                //���������� �������� ������� ��� ������
                switch (printDialog1.PrinterSettings.PrintRange)
                {
                    //������� ��� ��������
                    case PrintRange.AllPages:
                        stringPrintText = rtbText.Text;
                        StartPage = 1;
                        NumPages = printDialog1.PrinterSettings.MaximumPage;
                        break;
                    //������� ���������� �������
                    case PrintRange.Selection:
                        stringPrintText = rtbText.SelectedText;
                        StartPage = 1;
                        NumPages = printDialog1.PrinterSettings.MaximumPage;
                        break;
                    //������ ��� �������
                    case PrintRange.SomePages:
                        stringPrintText = rtbText.Text;
                        StartPage = printDialog1.PrinterSettings.FromPage;
                        NumPages = printDialog1.PrinterSettings.ToPage - StartPage + 1;
                        break;
                }
                PageNumber = 1;
                //�������� ���������� ����� ��� ������ ������
                printDocument1.Print();
            }
        }

        private void mnuPrintPreview_Click(object sender, EventArgs e)
        {
            //�������������� ����������
            printDocument1.DocumentName = Text;
            stringPrintText = rtbText.Text;
            StartPage = 1;
            NumPages = printDialog1.PrinterSettings.MaximumPage;
            PageNumber = 1;
            //���������� ������
            printPreviewDialog1.ShowDialog();
        }

        private void mnuPageSetup_Click(object sender, EventArgs e)
        {
            //���������� ������
            pageSetupDialog1.ShowDialog();
        }
    }
}

