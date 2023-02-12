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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tela_Incial prox = new Tela_Incial();
            prox.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double peso,altura;
            int idade;
            string cb1;
            peso = double.Parse(txt_peso.Text);
            idade = int.Parse(txt_idade.Text);
            altura = double.Parse(txt_altura.Text);
            cb1 = txtSexo.Text;
            Global.Peso= peso;
            Global.Idade=idade;
            Global.Altura=altura;
            Global.Sexo = cb1;
            Geral prox = new Geral();
            prox.ShowDialog();
            this.Close();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
