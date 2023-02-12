using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trabalho_EdFisica
{
    public partial class Geral : Form
    {
        public Geral()
        {
            InitializeComponent();
        }

        private void Geral_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaOB prox = new TelaOB();
            prox.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CLPesoIdeal prox = new CLPesoIdeal();
            prox.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Registro prox = new Registro();
            prox.ShowDialog();
            this.Close();
        }
    }
}
