using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureElement
{
    public partial class NamePictureElement : UserControl
    {
        public NamePictureElement()
        {
            InitializeComponent();
        }

        private RejimProsmotra prosmotrperemen;

        public Image Izobrajenie
        {
            get { return this.pictureBox1.Image; }
            set
            {
                this.pictureBox1.Image = value;
                //Вызываем метод для установки режима просмотра
                this.UstanovkaRejima();

            }
        }

        public RejimProsmotra UserPropRejimProsmotra
        {
            get { return this.prosmotrperemen; }
            set
            {
                this.prosmotrperemen = value;
                this.AutoScroll = (this.prosmotrperemen == RejimProsmotra.Prokrutka);
                //Вызываем метод для установки режима просмотра
                this.UstanovkaRejima();
            }

        }

        private void PodgonRazmera()
        {
            //Определяем переменную ProporciiElementa, которая равна 
            //отношению ширины элемента к его высоте
            float ProporciiElementa = (float)this.Width / this.Height;
            //Определяем переменную ProporciiIzobrajeniya, которая равна 
            //отношению ширины загруженного изображения к его высоте
            float ProporciiIzobrajeniya = (float)this.pictureBox1.Image.Width / this.pictureBox1.Image.Height;
            //Если ширина элемента  больше или равна ширине изображения 
            //и высота больше или равна высоте изображения, устанавливаем значения ширины 
            //и высоты pictureBox1 равными ширине и высоте изображения
            if (this.Width >= this.pictureBox1.Image.Width && this.Height >= this.pictureBox1.Image.Height)
            {
                this.pictureBox1.Width = this.pictureBox1.Image.Width;
                this.pictureBox1.Height = this.pictureBox1.Image.Height;
            }
            //Иначе, если ширина элемента  больше ширины изображения 
            //и высота меньше высоты  изображения, устанавливаем значение высоты 
            // pictureBox1, равное  высоте  элемента, а  значение ширины — равное значению 
            //ширины изображения 
            else if (this.Width > this.pictureBox1.Image.Width && this.Height < this.pictureBox1.Image.Height)
            {
                this.pictureBox1.Height = this.Height;
                this.pictureBox1.Width = (int)(this.Height * ProporciiIzobrajeniya);
            }
            //Иначе, если ширина элемента  меньше  ширины изображения 
            //и высота больше  высоты  изображения, устанавливаем значение ширины 
            // pictureBox1, равное  ширине  элемента, а  значение высоты — равное значению 
            //высоты изображения 
            else if (this.Width < this.pictureBox1.Image.Width && this.Height > this.pictureBox1.Image.Height)
            {
                this.pictureBox1.Width = this.Width;
                this.pictureBox1.Height = (int)(this.Width / ProporciiIzobrajeniya);
            }
            //Иначе, если ширина элемента  меньше  ширины изображения 
            //и высота меньше  высоты  изображения
            else if (this.Width < this.pictureBox1.Image.Width && this.Height < this.pictureBox1.Image.Height)
            {
                //если ширина элемента больше или равна его высоте
                if (this.Width >= this.Height)
                {
                    //Если ширина изображения больше или равна его высоте и переменная 
                    //ProporciiIzobrajeniya больше или равна переменной ProporciiElementa,
                    //устанавливаем значение ширины pictureBox1, равное значению ширины элемента,
                    //а значение высоты — равное значению высоты изображения
                    if (this.pictureBox1.Image.Width >= this.pictureBox1.Image.Height && ProporciiIzobrajeniya >= ProporciiElementa)
                    {
                        this.pictureBox1.Width = this.Width;
                        this.pictureBox1.Height = (int)(this.Width / ProporciiIzobrajeniya);
                    }
                    //Иначе, устанавливаем значение высоты  pictureBox1, равное значению
                    //высоты элемента, а значение ширины — равное значению ширины изображения
                    else
                    {
                        this.pictureBox1.Height = this.Height;
                        this.pictureBox1.Width = (int)(this.Height * ProporciiIzobrajeniya);
                    }
                }
                //Иначе
                else
                {
                    //Если ширина изображения меньше  его высоты и переменная 
                    //ProporciiIzobrajeniya меньше переменной ProporciiElementa,
                    //устанавливаем значение высоты  pictureBox1, равное значению высоты элемента,
                    //а значение ширины — равное значению ширины изображения
                    if (this.pictureBox1.Image.Width < this.pictureBox1.Image.Height && ProporciiIzobrajeniya < ProporciiElementa)
                    {
                        this.pictureBox1.Height = this.Height;
                        this.pictureBox1.Width = (int)(this.Height * ProporciiIzobrajeniya);
                    }
                    //Иначе, устанавливаем значение ширины  pictureBox1, равное значению
                    //ширины  элемента, а значение высоты — равное значению высоты изображения
                    else
                    {
                        this.pictureBox1.Width = this.Width;
                        this.pictureBox1.Height = (int)(this.Width / ProporciiIzobrajeniya);
                    }
                }
            }
            //Вызываем метод для размещения изображения в центре
            PomeshenieIzobrajeniyavCenter();
        }

        private void Prokrutka()
        {
            //Устанавливаем значение ширины pictureBox1, равное значению ширины изображения
            this.pictureBox1.Width = this.pictureBox1.Image.Width;
            //Устанавливаем значение высоты pictureBox1, равное значению высоты изображения
            this.pictureBox1.Height = this.pictureBox1.Image.Height;
            //Вызываем метод для установки режима просмотра
            this.PomeshenieIzobrajeniyavCenter();
        }

        private void UstanovkaRejima()
        {
            //если pictureBox1 не содержит изображения, возвращаемся назад
            if (this.pictureBox1.Image == null)
                return;
            //Если значение переменной prosmotrperemen равно PodgonRazmera,
            //вызываем метод PodgonRazmera
            if (this.prosmotrperemen == RejimProsmotra.PodgonRazmera)
                this.PodgonRazmera();
            //Иначе вызываем метод Prokrutka
            else
            {

                this.Prokrutka();
                this.AutoScroll = true;

            }
        }

        private void PomeshenieIzobrajeniyavCenter()
        {
            //Переменная top равна разнице между высотой элемента 
            //и высотой pictureBox1, деленной пополам
            int top = (int)((this.Height - this.pictureBox1.Height) / 2.0);
            //Переменная left равна разнице между шириной  элемента 
            //и шириной pictureBox1, деленной пополам
            int left = (int)((this.Width - this.pictureBox1.Width) / 2.0);
            if (top < 0)
                top = 0;
            if (left > 0)
                left = 0;
            this.pictureBox1.Top = top;
            this.pictureBox1.Left = left;
        }

        public enum RejimProsmotra
        {
            Prokrutka,
            PodgonRazmera
        }

        private void NamePictureElement_Load(object sender, EventArgs e)
        {
            //при загрузке элемента устанавливаем нулевые ширину и высоту pictureBox1
            this.pictureBox1.Width = 0;
            this.pictureBox1.Height = 0;
            //Вызываем метод для установки режима просмотра
            this.UstanovkaRejima();
        }

        private void NamePictureElement_Resize(object sender, EventArgs e)
        {
            //При изменении размеров элемента вызывается метод для установки режима просмотра:
            this.UstanovkaRejima();
        }
    }
}
