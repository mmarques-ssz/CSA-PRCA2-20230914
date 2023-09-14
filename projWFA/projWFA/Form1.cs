using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projWFA
{
    public partial class Form1 : Form
    {
        private Contador cont;

        public Form1()
        {
            InitializeComponent();
            this.cont = new Contador(99);
            atualizaDisplay();
        }

        private void atualizaDisplay()
        {
            lblDisplay.Text = cont.getNumero().ToString();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            cont.subtrair();
            atualizaDisplay();
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            cont.adicionar();
            atualizaDisplay();
        }

        private void btnZerar_Click(object sender, EventArgs e)
        {
            cont.zerar();
            atualizaDisplay();
        }
    }
}
