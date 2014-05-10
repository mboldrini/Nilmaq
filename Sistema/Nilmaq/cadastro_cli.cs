using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nilmaq
{
    public partial class cadastro_cli : Form
    {
        public cadastro_cli()
        {
            InitializeComponent();
        }

        private void tbClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBADataSet);

        }

        private void cadastro_cli_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBADataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
           this.tbClienteTableAdapter.Fill(this.dBADataSet.tbCliente);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir esse cadastro?", "Excluir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Validate();
                this.tbClienteBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dBADataSet);

            }
            else
            {
                this.tbClienteTableAdapter.Fill(this.dBADataSet.tbCliente);
            }

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
        }

        private void cli_cancela_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBADataSet);
            Close();
        }
    }
}
