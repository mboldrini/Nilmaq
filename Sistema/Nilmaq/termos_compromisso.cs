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
    public partial class termos_compromisso : Form
    {
        public termos_compromisso()
        {
            InitializeComponent();
        }
        private void termos_compromisso_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
