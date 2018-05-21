using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numero_Magico
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Cleaner()
        {
            vsComputerLog.Clear();
            vsHumanLog.Clear();
            NumeroTxtBox.Clear();
        }
        private void vsComputer_CheckedChanged(object sender, EventArgs e)
        {
            Cleaner();
            vsComputerGroup.Enabled = true;
            vsHumanGroup.Enabled = false;
            vsComputerLog.AppendText("Adivina mi número \n");
        }

        private void vsHumanLog_TextChanged(object sender, EventArgs e)
        {
            Cleaner();
            vsComputerGroup.Enabled = false;
            vsHumanGroup.Enabled = true;
            vsHumanLog.AppendText("?\n");
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

        }
    }
}
