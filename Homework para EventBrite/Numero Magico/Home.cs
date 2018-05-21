using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clases;

namespace Numero_Magico
{
    public partial class Home : Form
    {
        Adivinante adivinante;
        Adivinador adivinador;
        int ultimoNumero;

        public Home()
        {
            InitializeComponent();
        }

        private void Cleaner()
        {
            vsComputerLog.Clear();
            vsHumanLog.Clear();
            NumeroTxtBox.Clear();
            adivinante = new Adivinante();
            adivinador = new Adivinador();
        }
        private void vsComputer_CheckedChanged(object sender, EventArgs e)
        {
            Cleaner();
            vsComputerGroup.Enabled = true;
            vsHumanGroup.Enabled = false;
            vsComputerLog.AppendText("Adivina mi número\n");
        }

        private void vsHuman_CheckedChanged(object sender, EventArgs e)
        {
            Cleaner();
            vsComputerGroup.Enabled = false;
            vsHumanGroup.Enabled = true;
            vsHumanLog.AppendText("Tu numero es: " + Convert.ToString(adivinador.Pregunta(0)) + "?\n");
        }

        private void NumeroTxtBox_KeyPress(object sender, KeyPressEventArgs e) //Controla la entrada de caracteres en TxtBox. 
                                                                               //Acepta Numeros y controles (retroceso, enter, etc.)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            } else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                if (e.KeyChar == Convert.ToChar(Keys.Enter)) // Presionar Enter equivale a hacer click en preguntaBtn
                {
                    preguntaBtn_Click(sender, e);
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void preguntaBtn_Click(object sender, EventArgs e)
        {
            if (NumeroTxtBox.TextLength > 0)
            {
                switch (adivinante.Respuesta(Convert.ToInt32(NumeroTxtBox.Text)))
                {
                    case -1:
                        vsComputerLog.AppendText("Mi número es Mayor a "+NumeroTxtBox.Text+"\n");
                        break;
                    case 1:
                        vsComputerLog.AppendText("Mi número es Menor a " + NumeroTxtBox.Text + "\n");
                        break;
                    case 0:
                        MessageBox.Show("Adivinaste! Buen Trabajo \n Lo hiciste en: " + Convert.ToString(adivinante.GetIntentos() + " intentos\n"));
                        vsComputer_CheckedChanged(sender, e);
                        break;
                }
            }
            vsComputerLog.ScrollToCaret();
            NumeroTxtBox.Clear();
        }

        private bool Trampa(int unNumero) //Controla que el usuario no añada intentos, una vez que la computadora encontro el número
        {
            if (ultimoNumero == unNumero)
                return true;
            else
                return false;
        }

        private void menorBtn_Click(object sender, EventArgs e)
        {
            adivinador.Pregunta(1); // Piensa un numero mas chico
            if (Trampa(adivinador.Pregunta(0))){
                MessageBox.Show("No Mientas! ya adiviné\n Y solo me llevo " + adivinador.GetIntentos() + " intentos\n");
                vsHuman_CheckedChanged(sender, e);
            }
            else
            {
                vsHumanLog.AppendText("Tu Número es: " + Convert.ToString(adivinador.Pregunta(0)) + "?\n");
                ultimoNumero = adivinador.Pregunta(0);
                vsHumanLog.ScrollToCaret();
            }
        }        

        private void mayorBtn_Click(object sender, EventArgs e)
        {
            adivinador.Pregunta(-1); // Piensa un numero mas grande
            if (Trampa(adivinador.Pregunta(0)))
            {
                MessageBox.Show("No Mientas! ya adiviné\n Y solo me llevo " + adivinador.GetIntentos() + " intentos\n");
                vsHuman_CheckedChanged(sender, e);
            }
            else
            {
                vsHumanLog.AppendText("Tu Número es: " + Convert.ToString(adivinador.Pregunta(0)) + "?\n");
                ultimoNumero = adivinador.Pregunta(0);
                vsHumanLog.ScrollToCaret();
            }
            
        }

        private void igualBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YAY!\n Y solo me llevo " + adivinador.GetIntentos() + " intentos\n");
            vsHuman_CheckedChanged(sender, e);
        }
    }
}
