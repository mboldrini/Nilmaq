using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Nilmaq
{
    public partial class ordemservico_print : Form
    {
        public ordemservico_print(string Nome, string Telefone, string Celular, string Endereco, string Numerocasa, string Bairro, string Referencia, string Cidade, string Defeito, string Marca, string Codigo, string Data, string Ordemservico, string Preco, string Garantia)
        {
            InitializeComponent();

            reportViewer1.LocalReport.ReportEmbeddedResource = "Nilmaq.ordemservico.rdlc";
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[16];
            p[0] = new Microsoft.Reporting.WinForms.ReportParameter("Nome", Nome);
            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("Telefone", Telefone);
            p[2] = new Microsoft.Reporting.WinForms.ReportParameter("Endereco", Endereco);
            p[3] = new Microsoft.Reporting.WinForms.ReportParameter("Numerocasa", Numerocasa);
            p[4] = new Microsoft.Reporting.WinForms.ReportParameter("Bairro", Bairro);
            p[5] = new Microsoft.Reporting.WinForms.ReportParameter("Referencia", Referencia);
            p[6] = new Microsoft.Reporting.WinForms.ReportParameter("Cidade", Cidade);
            p[7] = new Microsoft.Reporting.WinForms.ReportParameter("Defeito", Defeito);
            p[8] = new Microsoft.Reporting.WinForms.ReportParameter("Preco", Preco);
            p[9] = new Microsoft.Reporting.WinForms.ReportParameter("Marca", Marca);
            p[10] = new Microsoft.Reporting.WinForms.ReportParameter("Codigo", Codigo);
            p[11] = new Microsoft.Reporting.WinForms.ReportParameter("Data", Data);
            p[12] = new Microsoft.Reporting.WinForms.ReportParameter("Ordemservico", Ordemservico);
            p[13] = new Microsoft.Reporting.WinForms.ReportParameter("Preco", Preco);
            p[14] = new Microsoft.Reporting.WinForms.ReportParameter("Garantia", Garantia);
            p[15] = new Microsoft.Reporting.WinForms.ReportParameter("Celular", Celular);
            reportViewer1.LocalReport.SetParameters(p);
        }

        private void ordemservico_print_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void ordemservico_print_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
