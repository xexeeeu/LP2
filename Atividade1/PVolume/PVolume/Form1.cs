using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn2Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn1Limp_Click(object sender, EventArgs e)
        {
            txt1Raio.Text = null;
            txt2Alt.Text = null;
            txt3Vol.Text = null;
        }

        private void btn3Calc_Click(object sender, EventArgs e)
        {
            double raio = 0.0, altura = 0.0 ;

            if (double.TryParse(txt1Raio.Text, out raio) && double.TryParse(txt2Alt.Text, out altura))
            {
                raio = double.Parse(txt1Raio.Text);
                altura = double.Parse(txt2Alt.Text);
                txt3Vol.Text = (Math.PI * Math.Pow(2, raio) * altura).ToString("F");
            }

            else
                MessageBox.Show("Valores inválidos");
        }
    }
}
