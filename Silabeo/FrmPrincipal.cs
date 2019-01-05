using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Silabeo
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        SeparadorDeSilabas instSep = new SeparadorDeSilabas();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            CmbSeparador.SelectedIndex = 0;
        }


        private void CmdSeparar_Click(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            string[] partes = TxtTextoOriginal.Text.Split(' ');
            string Separado = string.Empty;
            instSep.SeparadorSilaba = CmbSeparador.Text;
            instSep.ultPal = "";
            foreach (string c in partes)
            {
                Separado = Separado + instSep.PalabraSilabas(c);
            }
            TxtTextoSeparado.Text = Separado;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 fmracerca = new AboutBox1();
            fmracerca.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
