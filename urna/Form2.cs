using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace urna
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int candidato19, int candidato51, int candidato12, int candidato27, int candidato13, int candidato45, int candidato50, int candidato15, int candidato17, int candidato18, int nulo, int branco)
        {
            InitializeComponent();
            label1.Text = Convert.ToString(candidato19);
            label2.Text = Convert.ToString(candidato51);
            label3.Text = Convert.ToString(candidato12);
            label17.Text = Convert.ToString(candidato27);
            label16.Text = Convert.ToString(candidato13);
            label15.Text = Convert.ToString(candidato45);
            label19.Text = Convert.ToString(candidato50);
            label21.Text = Convert.ToString(candidato15);
            label23.Text = Convert.ToString(candidato17);
            label25.Text = Convert.ToString(candidato18);
            label4.Text = Convert.ToString(nulo);
            label5.Text = Convert.ToString(branco);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
