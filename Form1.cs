using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvedorInternet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double value = 0;

            if (listacidades.SelectedItem == "São Paulo - SP" || listacidades.SelectedItem == "Rio de Janeiro - RJ")
            {

                value = 140;
                resultado.Text = "Resultado: " + value.ToString("C2");
            }
            else if (listacidades.SelectedItem == "Campo Grande - MS") {

                value = 135;
                resultado.Text = "Resultado: " + value.ToString("C2");
            }
            else
            {

                value = 120;
                resultado.Text = "Resultado: " + value.ToString("C2");
            }
            if (mbs1.Checked == true)
            {

                value += 0;
                resultado.Text = "Resultado: " + value.ToString("C2");
            }
            else if (mbs2.Checked == true)
            {

                value += 30;
                resultado.Text = "Resultado: " + value.ToString("C2");
            }
            else if (mbs3.Checked == true) {

                value += 60;
                resultado.Text = "Resultado: " + value.ToString("C2");
            }
            if (simEmail.Checked == true) {

                value += 10;
                resultado.Text = "Resultado: " + value.ToString("C2");
            }
            if (simHosp.Checked == true) {

                value += 15;
                resultado.Text = "Resultado: " + value.ToString("C2");
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: João Pedro Ferreira de Souza Batista" + "\r\n" + "RGM: 2316257-1");
        }
    }
}
