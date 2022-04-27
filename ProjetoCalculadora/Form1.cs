using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCalculadora
{
    public partial class Form1 : Form
    {

        ModelCalculadora calc;

        public Form1()
        {
            InitializeComponent();

            calc = new ModelCalculadora();

        }

        private void SomaButton_Click(object sender, EventArgs e)
        {

            double resultado = calc.sumOperacao((Convert.ToDouble(PrimeiraTextBox.Text)), Convert.ToDouble(SegundaTextBox.Text));

            ResultadoLabel.Text = "" + resultado;

        }// Fim do SomaButton

        private void SubtButton_Click(object sender, EventArgs e)
        {

            try
            {

                double resultado = calc.SubtOperacao(Convert.ToDouble(PrimeiraTextBox.Text), Convert.ToDouble(SegundaTextBox.Text));

                ResultadoLabel.Text = "" + resultado;

            }
            catch (Exception erro)
            {
                MessageBox.Show("Digite um valor nas caixas!\n\n" + erro);
            }


        }// Fim do SubtButton

        private void MultiButton_Click(object sender, EventArgs e)
        {

            double resultado = calc.MultOperacao((Convert.ToDouble(PrimeiraTextBox.Text)), Convert.ToDouble(SegundaTextBox.Text));

            ResultadoLabel.Text = "" + resultado;

        }// Fim do MultButton

        private void DiviButton_Click(object sender, EventArgs e)
        {

            try
            {

                if (calc.DiviOperacao((Convert.ToDouble(PrimeiraTextBox.Text)), Convert.ToDouble(SegundaTextBox.Text)) == -1)
                {
                    MessageBox.Show("Impossível dividir por zero!", "Ô, camarada!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    double resultado = calc.DiviOperacao((Convert.ToDouble(PrimeiraTextBox.Text)), Convert.ToDouble(SegundaTextBox.Text));
                    ResultadoLabel.Text = "" + resultado;

                }
            }
            catch (Exception erro)
            {

                MessageBox.Show("Digite um valor nas caixas!\n\n" + erro);

            }


        }// Fim do DiviButton

        private void RadButton_Click(object sender, EventArgs e)
        {

            if (calc.RadiOperacao(Convert.ToDouble(PrimeiraTextBox.Text)) == -1)
            {
                MessageBox.Show("Impossível radicializar números negativos", "Ô, camarada!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double resultado = calc.RadiOperacao(Convert.ToDouble(PrimeiraTextBox.Text));

                ResultadoLabel.Text = "" + resultado;

            }


        }// Fim do RadButton

        private void PoteButton_Click(object sender, EventArgs e)
        {

            double resultado = calc.PoteOperacao(Convert.ToDouble(PrimeiraTextBox.Text), Convert.ToDouble(SegundaTextBox.Text));

            ResultadoLabel.Text = "" + resultado;


        }// Fim do PotButton

        private void PrimeiraTextBox_TextChanged(object sender, EventArgs e)
        {



        }// Fim do PrimeiraTextBox

        private void SegundaTextBox_TextChanged(object sender, EventArgs e)
        {

        }// Fim do SegundaTextBox

        private void FirstNumText_Click(object sender, EventArgs e)
        {

        }// Fim do FirstNumText

        private void SegundoNumText_Click(object sender, EventArgs e)
        {

        }// Fim do SegundoNumText

        private void ResultadoLabel_Click(object sender, EventArgs e)
        {

        }// Fim do ResultadoLabel
    }
}
