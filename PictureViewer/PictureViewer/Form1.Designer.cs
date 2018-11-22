namespace PictureViewer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.cmnuResize = new System.Windows.Forms.MenuItem();
            this.cmnuActual = new System.Windows.Forms.MenuItem();
            this.cmnuCenterImage = new System.Windows.Forms.MenuItem();
            this.cmnuAutoSize = new System.Windows.Forms.MenuItem();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuOpen = new System.Windows.Forms.MenuItem();
            this.mnuSave = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.mnuPageSetup = new System.Windows.Forms.MenuItem();
            this.mnuPrintPreview = new System.Windows.Forms.MenuItem();
            this.mnuPrint = new System.Windows.Forms.MenuItem();
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.mnuView = new System.Windows.Forms.MenuItem();
            this.mnuResize = new System.Windows.Forms.MenuItem();
            this.mnuActual = new System.Windows.Forms.MenuItem();
            this.mnuCenterImage = new System.Windows.Forms.MenuItem();
            this.mnuAutoSize = new System.Windows.Forms.MenuItem();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.sbFile = new System.Windows.Forms.StatusBarPanel();
            this.sbSize = new System.Windows.Forms.StatusBarPanel();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbSize)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Выбор изображения";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenu = this.contextMenu1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(584, 712);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.cmnuResize,
            this.cmnuActual,
            this.cmnuCenterImage,
            this.cmnuAutoSize});
            // 
            // cmnuResize
            // 
            this.cmnuResize.Index = 0;
            this.cmnuResize.Text = "&Подогнать размер";
            this.cmnuResize.Click += new System.EventHandler(this.cmnuResize_Click);
            // 
            // cmnuActual
            // 
            this.cmnuActual.Index = 1;
            this.cmnuActual.Text = "&Истинный размер";
            this.cmnuActual.Click += new System.EventHandler(this.cmnuActual_Click);
            // 
            // cmnuCenterImage
            // 
            this.cmnuCenterImage.Index = 2;
            this.cmnuCenterImage.Text = "&По центру";
            this.cmnuCenterImage.Click += new System.EventHandler(this.cmnuCenterImage_Click);
            // 
            // cmnuAutoSize
            // 
            this.cmnuAutoSize.Index = 3;
            this.cmnuAutoSize.Text = "&Автоматический размер";
            this.cmnuAutoSize.Click += new System.EventHandler(this.cmnuAutoSize_Click);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFile,
            this.mnuView});
            // 
            // mnuFile
            // 
            this.mnuFile.Index = 0;
            this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuOpen,
            this.mnuSave,
            this.menuItem4,
            this.mnuPageSetup,
            this.mnuPrintPreview,
            this.mnuPrint,
            this.mnuExit});
            this.mnuFile.Text = "&Файл";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Index = 0;
            this.mnuOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.mnuOpen.Text = "&Открыть";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Index = 1;
            this.mnuSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.mnuSave.Text = "&Сохранить";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 2;
            this.menuItem4.Text = "-";
            // 
            // mnuPageSetup
            // 
            this.mnuPageSetup.Index = 3;
            this.mnuPageSetup.Text = "Пара&метры страницы";
            this.mnuPageSetup.Click += new System.EventHandler(this.mnuPageSetup_Click);
            // 
            // mnuPrintPreview
            // 
            this.mnuPrintPreview.Index = 4;
            this.mnuPrintPreview.Text = "Пред&варительный просмотр";
            this.mnuPrintPreview.Click += new System.EventHandler(this.mnuPrintPreview_Click);
            // 
            // mnuPrint
            // 
            this.mnuPrint.Index = 5;
            this.mnuPrint.Shortcut = System.Windows.Forms.Shortcut.CtrlP;
            this.mnuPrint.Text = "&Печать";
            this.mnuPrint.Click += new System.EventHandler(this.mnuPrint_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Index = 6;
            this.mnuExit.Text = "&Exit";
            // 
            // mnuView
            // 
            this.mnuView.Index = 1;
            this.mnuView.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuResize,
            this.mnuActual,
            this.mnuCenterImage,
            this.mnuAutoSize});
            this.mnuView.Text = "&Вид";
            this.mnuView.Popup += new System.EventHandler(this.mnuView_Popup);
            // 
            // mnuResize
            // 
            this.mnuResize.Index = 0;
            this.mnuResize.Text = "&Подогнать размер";
            this.mnuResize.Click += new System.EventHandler(this.mnuResize_Click);
            // 
            // mnuActual
            // 
            this.mnuActual.Index = 1;
            this.mnuActual.Text = "&Истинный размер";
            this.mnuActual.Click += new System.EventHandler(this.mnuActual_Click);
            // 
            // mnuCenterImage
            // 
            this.mnuCenterImage.Index = 2;
            this.mnuCenterImage.Text = "&По центру";
            this.mnuCenterImage.Click += new System.EventHandler(this.mnuCenterImage_Click);
            // 
            // mnuAutoSize
            // 
            this.mnuAutoSize.Index = 3;
            this.mnuAutoSize.Text = "&Автоматический размер";
            this.mnuAutoSize.Click += new System.EventHandler(this.mnuAutoSize_Click);
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 690);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.sbFile,
            this.sbSize});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(584, 22);
            this.statusBar1.TabIndex = 3;
            this.statusBar1.Text = "statusBar1";
            // 
            // sbFile
            // 
            this.sbFile.Name = "sbFile";
            this.sbFile.Width = 500;
            // 
            // sbSize
            // 
            this.sbSize.Name = "sbSize";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 712);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.pictureBox1);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem mnuFile;
        private System.Windows.Forms.MenuItem mnuOpen;
        private System.Windows.Forms.MenuItem mnuSave;
        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem mnuPageSetup;
        private System.Windows.Forms.MenuItem mnuPrintPreview;
        private System.Windows.Forms.MenuItem mnuPrint;
        private System.Windows.Forms.MenuItem mnuExit;
        private System.Windows.Forms.MenuItem mnuView;
        private System.Windows.Forms.MenuItem mnuResize;
        private System.Windows.Forms.MenuItem mnuActual;
        private System.Windows.Forms.MenuItem mnuCenterImage;
        private System.Windows.Forms.MenuItem mnuAutoSize;
        private System.Windows.Forms.MenuItem cmnuResize;
        private System.Windows.Forms.MenuItem cmnuActual;
        private System.Windows.Forms.MenuItem cmnuCenterImage;
        private System.Windows.Forms.MenuItem cmnuAutoSize;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel sbFile;
        private System.Windows.Forms.StatusBarPanel sbSize;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}

