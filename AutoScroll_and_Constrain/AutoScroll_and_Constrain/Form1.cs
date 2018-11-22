using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoScroll_and_Constrain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string path = this.openFileDialog1.FileName;
            this.namePictureElement1.Izobrajenie = Image.FromFile(path);
        }

        private void mnuResize_Click(object sender, EventArgs e)
        {
            this.namePictureElement1.UserPropRejimProsmotra = PictureElement.NamePictureElement.RejimProsmotra.PodgonRazmera;
        }

        private void mnuActual_Click(object sender, EventArgs e)
        {
            this.namePictureElement1.UserPropRejimProsmotra = PictureElement.NamePictureElement.RejimProsmotra.Prokrutka;
        }
    }
}
