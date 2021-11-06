using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            tbPw1.UseSystemPasswordChar = !cbView1.Checked;
            tbPw2.UseSystemPasswordChar = !cbView2.Checked;
        }

        private void cbView1_CheckedChanged(object sender, EventArgs e)
        {
            tbPw1.UseSystemPasswordChar = !cbView1.Checked;
            cbView2.Checked = cbView1.Checked;
        }

        private void cbView2_CheckedChanged(object sender, EventArgs e)
        {
            tbPw2.UseSystemPasswordChar = !cbView2.Checked;
            cbView1.Checked = cbView2.Checked;
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if(Validar(tbPw1.Text, tbPw2.Text, out string mensaje))
            {
                MessageBox.Show(this, "Contraseña Válida", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validar(string cadena1, string cadena2, out string mensaje)
        {
            mensaje = "";
            Regex regMay, regMin, regNum, regEsp;
            regMay = new Regex("^(?=.*[A-Z]).{1,}$");
            regMin = new Regex("^(?=.*[a-z]).{1,}$");
            regNum = new Regex("^(?=.*\\d).{1,}$");
            regEsp = new Regex("^(?=.*\\W).{1,}$");

            mensaje += regMay.IsMatch(cadena1) ? "" : "Debe haber por lo menos una Mayúscula\n";
            mensaje += regMin.IsMatch(cadena1) ? "" : "Debe haber por lo menos una Minúscula\n";
            mensaje += regNum.IsMatch(cadena1) ? "" : "Debe haber por lo menos una Número\n";
            mensaje += regEsp.IsMatch(cadena1) ? "" : "Debe haber por lo menos una Caracter Especial\n";

            mensaje += cadena1 == cadena2 ? "" : "Debes repetir el password\n";

            return mensaje == "";
        }
    }
}
