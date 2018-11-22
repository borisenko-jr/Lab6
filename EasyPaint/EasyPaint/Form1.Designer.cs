namespace EasyPaint
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
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.mnuFormat = new System.Windows.Forms.MenuItem();
            this.mnuColor = new System.Windows.Forms.MenuItem();
            this.mnuWidth = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFormat});
            // 
            // mnuFormat
            // 
            this.mnuFormat.Index = 0;
            this.mnuFormat.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuColor,
            this.mnuWidth});
            this.mnuFormat.Text = "&Формат";
            // 
            // mnuColor
            // 
            this.mnuColor.Index = 0;
            this.mnuColor.Text = "&Цвет";
            this.mnuColor.Click += new System.EventHandler(this.mnuColor_Click);
            // 
            // mnuWidth
            // 
            this.mnuWidth.Index = 1;
            this.mnuWidth.Text = "&Толщина линии";
            this.mnuWidth.Click += new System.EventHandler(this.mnuWidth_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "EasyPaint";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem mnuFormat;
        private System.Windows.Forms.MenuItem mnuColor;
        private System.Windows.Forms.MenuItem mnuWidth;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

