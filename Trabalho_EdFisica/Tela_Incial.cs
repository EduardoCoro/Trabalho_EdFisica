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
    public partial class Tela_Incial : Form
    {
        public Tela_Incial()
        {
            InitializeComponent();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fontes_Info prox = new Fontes_Info();
            prox.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registro prox = new Registro();
            prox.ShowDialog();
            this.Close();
            
        }
    }
}
