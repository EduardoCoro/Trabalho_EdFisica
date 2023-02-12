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
    public partial class CLPesoIdeal : Form
    {
        public CLPesoIdeal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {Geral prox = new Geral();
            prox.ShowDialog();
            this.Close();
        }

        private void btnOK2_Click(object sender, EventArgs e)
        {

            if (Global.Sexo == "Feminino")
            {
                double rs;
                rs = 655.1 + (9.56 * Global.Peso) + (1.85 * Global.Altura) - (4.68 * Global.Idade);
                lblRS.Text = "Sua Taxa Basal  é: "+rs;
            }
            else
            {
                if (Global.Sexo == "Masculino")
                {
                    double rs;
                    rs = 66.47 + (13.75 * Global.Peso) + (5.00 * Global.Altura) - (6.76 * Global.Idade);
                    lblRS.Text = "Sua Taxa Basal  é: " + rs;
                }
            }

        }

        private void CLPesoIdeal_Load(object sender, EventArgs e)
        {

        }

        private void lblRS_Click(object sender, EventArgs e)
        {

        }
    }
}
