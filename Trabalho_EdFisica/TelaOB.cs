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
    public partial class TelaOB : Form
    {
        public TelaOB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Geral prox = new Geral();
            prox.ShowDialog();
            this.Close();
        }

        private void btnOK2_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true)
            {
                double vo,tx1,tx2,vom,vol,kcal;
                tx1 = double.Parse(textBox1.Text);
                tx2 = double.Parse(textBox2.Text);
                vo = tx1 / tx2;
                vom = 0.1 * vo + 3.5;
                vol = vom / 1000;
                kcal = vol * 5;
                label4.Text = "O Consumo de Caloria foi: "+kcal;
            }
            else if (radioButton2.Checked == true)
                {
                   double vo, tx1, tx2, vom, vol, kcal;
                    tx1 = double.Parse(textBox1.Text);
                    tx2 = double.Parse(textBox2.Text);
                    vo = tx1 / tx2;
                    vom = 0.2 * vo + 3.5;
                    vol = vom / 1000;
                    kcal = vol * 5;
                    label4.Text = "O Consumo de Caloria foi: " + kcal;

                }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void TelaOB_Load(object sender, EventArgs e)
        {

        }
    }
}
