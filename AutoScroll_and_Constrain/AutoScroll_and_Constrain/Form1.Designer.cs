namespace AutoScroll_and_Constrain
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.mnuFile = new System.Windows.Forms.MenuItem();
            this.mnuOpen = new System.Windows.Forms.MenuItem();
            this.mnuView = new System.Windows.Forms.MenuItem();
            this.mnuResize = new System.Windows.Forms.MenuItem();
            this.mnuActual = new System.Windows.Forms.MenuItem();
            this.namePictureElement1 = new PictureElement.NamePictureElement();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.mnuOpen,
            this.mnuView,
            this.mnuResize,
            this.mnuActual});
            this.mnuFile.Text = "&Файл";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Index = 0;
            this.mnuOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.mnuOpen.Text = "&Открыть";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuView
            // 
            this.mnuView.Index = 1;
            this.mnuView.Text = "&Вид";
            // 
            // mnuResize
            // 
            this.mnuResize.Index = 2;
            this.mnuResize.Text = "&Подогнать размер";
            this.mnuResize.Click += new System.EventHandler(this.mnuResize_Click);
            // 
            // mnuActual
            // 
            this.mnuActual.Index = 3;
            this.mnuActual.Text = "&Истинный размер";
            this.mnuActual.Click += new System.EventHandler(this.mnuActual_Click);
            // 
            // namePictureElement1
            // 
            this.namePictureElement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.namePictureElement1.Izobrajenie = null;
            this.namePictureElement1.Location = new System.Drawing.Point(0, 0);
            this.namePictureElement1.Name = "namePictureElement1";
            this.namePictureElement1.Size = new System.Drawing.Size(800, 450);
            this.namePictureElement1.TabIndex = 0;
            this.namePictureElement1.UserPropRejimProsmotra = PictureElement.NamePictureElement.RejimProsmotra.PodgonRazmera;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.namePictureElement1);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Сохранение пропорций и прокрутка";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem mnuFile;
        private System.Windows.Forms.MenuItem mnuOpen;
        private System.Windows.Forms.MenuItem mnuView;
        private System.Windows.Forms.MenuItem mnuResize;
        private System.Windows.Forms.MenuItem mnuActual;
        private PictureElement.NamePictureElement namePictureElement1;
    }
}

