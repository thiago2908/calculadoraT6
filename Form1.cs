using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraDaT6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // enum é uma lista de opções.
        enum Operacao
        {
            Soma,
            Subtrai,
            Divide,
            Multiplica,
            Nenhuma
        }

        // Declaração da variável "ultimaOperacao".
        static Operacao ultimaOperacao = Operacao.Nenhuma;

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
        }

        private void buttonApagar_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text.Length > 0)
            {
                textBoxDisplay.Text =
                    textBoxDisplay.Text.Remove(textBoxDisplay.Text.Length - 1, 1);
            }
        }

        private void buttonCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxDisplay.Text);
        }

        private void buttonSubtrai_Click(object sender, EventArgs e)
        {

        }

        private void buttonMultiplica_Click(object sender, EventArgs e)
        {

        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {

        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {

        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacao.Nenhuma)
            {
                ultimaOperacao = Operacao.Soma;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
        }

        private void FazerCalculo(Operacao ultimaOperacao)
        {



            // uma lista de numero do tipo "double" (real)
            // Uma lista é um vetor MELHOR.
            List<double> listadeNumero = new List<double>();
            switch (ultimaOperacao) {


                case Operacao.Soma:
                    listadeNumero = textBoxDisplay.Text.Split('+').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listadeNumero[0] + listadeNumero[1]).ToString();
                    break;
                case Operacao.Subtrai:
                    listadeNumero = textBoxDisplay.Text.Split('-').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listadeNumero[0] - listadeNumero[1]).ToString();
                    break;
                case Operacao.Divide:
                    listadeNumero = textBoxDisplay.Text.Split('/').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listadeNumero[0] - listadeNumero[1]).ToString();
                    break;
                case Operacao.Multiplica:
                    listadeNumero = textBoxDisplay.Text.Split('*').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listadeNumero[0] - listadeNumero[1]).ToString();
                    break;
                case Operacao.Nenhuma:
                    break;
                default:
                    break;
            }
        }
    }
}