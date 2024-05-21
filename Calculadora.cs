using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;  // Declaración de la variable segundo
        string operador;
        public Calculadora()
        {
            InitializeComponent();
        }

        // Instancias de clases para operaciones
        Clases.sumar obj = new Clases.sumar();
        Clases.restar obj2 = new Clases.restar();
        Clases.multiplicar obj3 = new Clases.multiplicar();
        Clases.dividir obj4 = new Clases.dividir();

        // Métodos de eventos para botones
        private void btn0_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + "9";
        }

        private void btn_punto_Click(object sender, EventArgs e)
        {
            tbxScreen.Text = tbxScreen.Text + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Métodos de eventos para operadores
        private void btn_suma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(tbxScreen.Text);
            tbxScreen.Clear();
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(tbxScreen.Text);  // Asignación de valor a la variable segundo

            double sum;
            double res;
            double mult;
            double divi;

            switch (operador)
            {
                case "+":
                    sum = obj.Sumar(primero, segundo);
                    tbxScreen.Text = sum.ToString();
                    break;
                case "-":
                    res = obj2.Restar(primero, segundo);
                    tbxScreen.Text = res.ToString();
                    break;
                case "*":
                    mult = obj3.Multiplicar(primero, segundo);
                    tbxScreen.Text = mult.ToString();
                    break;
                case "/":
                    divi = obj4.Dividir(primero, segundo);
                    tbxScreen.Text = divi.ToString();
                    break;
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            tbxScreen.Clear();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (tbxScreen.Text.Length == 1)
                tbxScreen.Text = "";
            else 
                tbxScreen.Text = tbxScreen.Text.Substring(0, tbxScreen.Text.Length -    1);
        }
    }
}
