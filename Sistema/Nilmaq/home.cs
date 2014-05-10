using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nilmaq
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }
        private void home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            cadastro_cli frm_cadcli = new cadastro_cli();
            frm_cadcli.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            termos_compromisso compromisso = new termos_compromisso();
            compromisso.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            termos_garantia garantia = new termos_garantia();
            garantia.ShowDialog();
        }

        private void home_Load(object sender, EventArgs e)
        {
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ordem_servico ordem = new ordem_servico();
            ordem.ShowDialog();
        }

        private void pesquisa_clientes_Click(object sender, EventArgs e)
        {
            pesquisa_cli pesq = new pesquisa_cli();
            pesq.ShowDialog();
        }
    }
}
