using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace TextEditor
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtBox;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem mnuFile;
		private System.Windows.Forms.MenuItem mnuOpen;
		private System.Windows.Forms.MenuItem mnuSave;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtBox = new System.Windows.Forms.TextBox();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.mnuFile = new System.Windows.Forms.MenuItem();
			this.mnuOpen = new System.Windows.Forms.MenuItem();
			this.mnuSave = new System.Windows.Forms.MenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// txtBox
			// 
			this.txtBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtBox.Location = new System.Drawing.Point(0, 0);
			this.txtBox.Multiline = true;
			this.txtBox.Name = "txtBox";
			this.txtBox.Size = new System.Drawing.Size(292, 266);
			this.txtBox.TabIndex = 0;
			this.txtBox.Text = "";
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
																					this.mnuSave});
			this.mnuFile.Text = "&File";
			// 
			// mnuOpen
			// 
			this.mnuOpen.Index = 0;
			this.mnuOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
			this.mnuOpen.Text = "&Open";
			this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
			// 
			// mnuSave
			// 
			this.mnuSave.Index = 1;
			this.mnuSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.mnuSave.Text = "&Save";
			this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
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
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.txtBox);
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
			openFileDialog1.ShowDialog() ;
			// Переменной fileName присваиваем имя открываемого файла
			string fileName = openFileDialog1.FileName;
			//Создаем поток fs и открываем файл для чтения.
			FileStream filestream= File.Open(fileName, FileMode.Open, FileAccess.Read);
			//Проверяем,  открыт ли поток,  и если открыт, выполняем условие
			if(filestream != null)
			{
				//Создаем объект streamreader и связываем его с потоком filestream
				StreamReader streamreader = new StreamReader(filestream);
				//Считываем весь файл и записываем его в TextBox
				txtBox.Text = streamreader.ReadToEnd();
				//Закрываем поток.
				filestream.Close();
			}
		}

		private void mnuSave_Click(object sender, System.EventArgs e)
		{
			//Показываем диалог выбора файла
			saveFileDialog1.ShowDialog();
			// В качестве имени сохраняемого файла устанавлиываем переменную fileName
			string fileName=saveFileDialog1.FileName;
			//Создаем поток fs и открываем файл для записи.
			FileStream filestream = File.Open(fileName, FileMode.Create, FileAccess.Write);
				//Проверяем,  открыт ли поток,  и если открыт, выполняем условие
			if(filestream != null)
			{
				//Создаем объект streamwriter и связываем его с потоком filestream
				StreamWriter streamwriter = new StreamWriter(filestream);
				//Записываем данные из TextBox в файл
				streamwriter.Write(txtBox.Text);
				//Переносим данные из потока в файл
				streamwriter.Flush();
				//Закрываем поток
				filestream.Close();
			}
		}
		}
	}

