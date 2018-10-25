using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;

namespace urna
{
    public partial class Form1 : Form
    {

        string num; //armazena o número do candidato

        int candidato19, candidato51, candidato12, candidato27, candidato13, candidato45, candidato50, candidato15, candidato17, candidato18, branco, nulo;
        int a = 0;
        public Form1()
        {
            InitializeComponent();
        }

        WindowsMediaPlayer audio;

        private void btnNumero(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtDireita.Text = txtDireita.Text + bt.Text;

        }
        private void txtDireita_TextChanged(object sender, EventArgs e)
        {
            num = txtDireita.Text;

            if (num == "19")
            {
                pictureBox1.Image = Properties.Resources.cad_alvaro;
                lblNomeCandidato.Text = "Alvaro Dias";

            }

            else if (num == "51")
            {
                pictureBox1.Image = Properties.Resources.cad_daciolo;
                lblNomeCandidato.Text = "Cabo Daciolo";
            }

            else if (num == "12")
            {
                pictureBox1.Image = Properties.Resources.cad_ciro;
                lblNomeCandidato.Text = "Ciro Gomes";
            }

            else if (num == "27")
            {
                pictureBox1.Image = Properties.Resources.cad_eymael;
                lblNomeCandidato.Text = "Eymael";
            }

            else if (num == "13")
            {
                pictureBox1.Image = Properties.Resources.cad_haddad;
                lblNomeCandidato.Text = "Fernando Haddad";
            }
            else if (num == "45")
            {
                pictureBox1.Image = Properties.Resources.cad_alckmin;
                lblNomeCandidato.Text = "Geraldo Alckmin";
            }

            else if (num == "50")
            {
                pictureBox1.Image = Properties.Resources.cad_boulos;
                lblNomeCandidato.Text = "Guilerme Boulos";
            }

            else if (num == "15")
            {
                pictureBox1.Image = Properties.Resources.cad_meirelles;
                lblNomeCandidato.Text = "Henrique Meirelles";
            }

            else if (num == "17")
            {
                pictureBox1.Image = Properties.Resources.cad_mito;
                lblNomeCandidato.Text = "Jair Bolsonaro";
            }

            else if (num == "18")
            {
                pictureBox1.Image = Properties.Resources.cad_marina;
                lblNomeCandidato.Text = "Marina Silva";
            }
            else if (num != "1" && num != "2" && num != "3" && num != "4" && num != "5" && num != "6" &&
                  num != "7" && num != "8" && num != "9" && num != "0" & num != "--")
            {
                pictureBox1.Image = Properties.Resources.fundoazul_urna;
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtDireita.Text = "";
            lblNomeCandidato.Text = "";
            a = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.fundobranco_urna;
            txtDireita.Text = "--";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var resultado = new Form2(candidato19, candidato51, candidato12, candidato27, candidato13, candidato45, candidato50, candidato15, candidato17, candidato18, branco, nulo);
            resultado.ShowDialog();
        }
       
        private void button13_Click(object sender, EventArgs e)   
        {
           
            {
                if (num == "19")
                {
                    candidato19 += 1;
                    txtDireita.Clear();
                    lblNomeCandidato.ResetText();
                    lblFim.Text = "FIM";
                    audio = new WindowsMediaPlayer();
                    audio.URL = Application.StartupPath + @"C:\Users\hsoares\Desktop\Urna-eletronica-master\urna\audio\MenuATH_Ini.wav";
                    audio.controls.play();

                }
                else if (num == "51")
                {
                    candidato51 += 1;
                    txtDireita.Clear();
                    lblNomeCandidato.ResetText();
                    pictureBox1.Image = Properties.Resources.fundo_fim;
                    audio = new WindowsMediaPlayer();
                    audio.URL = Application.StartupPath + @"C:\Users\hsoares\Desktop\Urna-eletronica-master\urna\audio\MenuATH_Ini.wav";
                    audio.controls.play();
                }
                else if (num == "12")
                {
                    candidato12 += 1;
                    txtDireita.Clear();
                    lblNomeCandidato.ResetText();
                    pictureBox1.Image = Properties.Resources.fundo_fim;
                }
                else if (num == "27")
                {
                    candidato27 += 1;
                    txtDireita.Clear();
                    lblNomeCandidato.ResetText();
                    pictureBox1.Image = Properties.Resources.fundo_fim;
                }
                else if (num == "13")
                {
                    candidato13 += 1;
                    txtDireita.Clear();
                    lblNomeCandidato.ResetText();
                    pictureBox1.Image = Properties.Resources.fundo_fim;
                }
                else if (num == "45")
                {
                    candidato45 += 1;
                    txtDireita.Clear();
                    lblNomeCandidato.ResetText();
                    pictureBox1.Image = Properties.Resources.fundo_fim;
                }
                else if (num == "50")
                {
                    candidato50 += 1;
                    txtDireita.Clear();
                    lblNomeCandidato.ResetText();
                    pictureBox1.Image = Properties.Resources.fundo_fim;
                }
                else if (num == "15")
                {
                    candidato15 += 1;
                    txtDireita.Clear();
                    lblNomeCandidato.ResetText();
                    pictureBox1.Image = Properties.Resources.fundo_fim;
                }
                else if (num == "17")
                {
                    candidato17 += 1;
                    txtDireita.Clear();
                    lblNomeCandidato.ResetText();
                    pictureBox1.Image = Properties.Resources.fundo_fim;
                }
                else if (num == "18")
                {
                    candidato18 += 1;
                    txtDireita.Clear();
                    lblNomeCandidato.ResetText();
                    pictureBox1.Image = Properties.Resources.fundo_fim;
                }
                else if (num == "--")
                {
                    branco += 1;
                    txtDireita.Clear();
                    pictureBox1.Image = Properties.Resources.fundo_fim;
                }

                else
                {
                    nulo += 1;
                    txtDireita.Clear();
                    pictureBox1.Image = Properties.Resources.fundobranco_urna;
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

      


    }
}






