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
    public partial class termos_garantia : Form
    {
        public termos_garantia()
        {
            InitializeComponent();
        }

        private void tbGarantiaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbGarantiaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBADataSet);

        }

        private void termos_garantia_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBADataSet.tbGarantia'. Você pode movê-la ou removê-la conforme necessário.
            this.tbGarantiaTableAdapter.Fill(this.dBADataSet.tbGarantia);

        }
    }
}
