using System;
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
    public partial class ordem_servico : Form
    {
       string vmodo;
        public ordem_servico()
        {
            InitializeComponent();
        }


        private void limpa_campos()
        {
            os_nome.Text = "";
            os_telefone.Text = "";
            cli_celular.Text = "";
            os_endereco.Text = "";
            os_numerocasa.Text = "";
            os_bairro.Text = "";
            os_referencia.Text = "";
            os_cidade.Text = "";
            os_defeito.Text = "";
            os_marca.Text = "";
            os_codigo.Text = "";
            os_data.Text = "";
            os_orcamento.Text = "";
            os_preco.Text = "";
        }

        private void ordem_servico_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBADataSet.tbGarantia'. Você pode movê-la ou removê-la conforme necessário.
            this.tbGarantiaTableAdapter.Fill(this.dBADataSet.tbGarantia);
            // TODO: esta linha de código carrega dados na tabela 'dBADataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.dBADataSet.tbCliente);
            limpa_campos();
            ativa_tabela();
        }

        private void ordem_cancela_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void ordem_print_Click(object sender, EventArgs e)
        {
            os_garantia.Visible = true;
            ordemservico_print rec = new ordemservico_print(os_nome.Text, os_telefone.Text, cli_celular.Text, os_endereco.Text, os_numerocasa.Text, os_bairro.Text, os_referencia.Text, os_cidade.Text, os_defeito.Text, os_marca.Text, os_codigo.Text, os_data.Text, os_orcamento.Text, os_preco.Text, os_garantia.Text);
            rec.ShowDialog();
        }

        private void os_pesquisar_Click(object sender, EventArgs e)
        {
            botao_pesquisaos();
        }

        private void ordem_concluir_Click(object sender, EventArgs e)
        {
            salva_ordem();  
            Close();
        }
        private void botao_pesquisaos()
        {
            limpa_campos();
            if (os_pesquisa.Text == "")
            {
                MessageBox.Show("Digite algo!", "Campo em branco", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            OleDbConnection Con = new OleDbConnection();
            // Con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='|DataDirectory|\DBA.accdb';Persist Security Info=True";
            Con.ConnectionString = Properties.Settings.Default.DBAConnectionString;
            try
            {
                Con.Open();
                OleDbCommand Cmm = new OleDbCommand();
                Cmm.CommandText = "Select Codigo, Nome, Telefone, Celular, Endereco, Numerocasa, Bairro, Referencia, Cidade, Defeito, Marca, Codigoproduto, Dataentrada, Orcamento, Preco  From tbCliente WHERE Nome Like '" + os_pesquisa.Text + "%'";
                Cmm.CommandType = CommandType.Text;
                Cmm.Connection = Con;

                OleDbDataReader DR;
                DR = Cmm.ExecuteReader();

                DR.Read();

                codigoTextBox.Text = Convert.ToString(DR.GetInt32(0));
                os_nome.Text = DR.GetString(1);
                os_telefone.Text = Convert.ToString(DR.GetString(2));
                cli_celular.Text = Convert.ToString(DR.GetString(3));
                os_endereco.Text = Convert.ToString(DR.GetString(4));
                os_numerocasa.Text = Convert.ToString(DR.GetString(5));
                os_bairro.Text = Convert.ToString(DR.GetString(6));
                os_referencia.Text = Convert.ToString(DR.GetString(7));
                os_cidade.Text = Convert.ToString(DR.GetString(8));
                os_defeito.Text = Convert.ToString(DR.GetString(9));
                os_marca.Text = Convert.ToString(DR.GetString(10));
                os_codigo.Text = Convert.ToString(DR.GetString(11));
                os_data.Text = Convert.ToString(DR.GetDateTime(12));
                os_orcamento.Text = Convert.ToString(DR.GetString(13));
                os_preco.Text = Convert.ToString(DR.GetString(14));

                Con.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Algum campo está em branco ou o cadastro não existe");
            }

        }

        private void os_pesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                botao_pesquisaos();
            }
        }
        private void salva_ordem()
        {
            if (vmodo == "alterar")
            {
                OleDbConnection Con = new OleDbConnection();
                Con.ConnectionString = Properties.Settings.Default.DBAConnectionString;
                try
                {
                    Con.Open();
                    OleDbCommand Cmm = new OleDbCommand();
                    Cmm.CommandText = "UPDATE tbCliente SET Nome = ?, Telefone = ?, Celular = ?, Endereco = ?, Numerocasa = ?, Bairro = ?, Referencia = ?, Cidade = ?, Defeito = ?, Marca = ?, Codigoproduto = ?, Dataentrada = ?, Orcamento = ?, Preco = ? WHERE Codigo = ? ";
                    Cmm.Parameters.Clear();
                    Cmm.Parameters.Add("@Nome", OleDbType.VarChar, 50).Value = os_nome.Text;
                    Cmm.Parameters.Add("@Telefone", OleDbType.VarChar, 50).Value = os_telefone.Text;
                    Cmm.Parameters.Add("@Celular", OleDbType.VarChar, 50).Value = cli_celular.Text;
                    Cmm.Parameters.Add("@Endereco", OleDbType.VarChar, 150).Value = os_endereco.Text;
                    Cmm.Parameters.Add("@Numerocasa", OleDbType.VarChar, 50).Value = os_numerocasa.Text;
                    Cmm.Parameters.Add("@Bairro", OleDbType.VarChar, 50).Value = os_bairro.Text;
                    Cmm.Parameters.Add("@Referencia", OleDbType.VarChar, 150).Value = os_referencia.Text;
                    Cmm.Parameters.Add("@Cidade", OleDbType.VarChar, 50).Value = os_cidade.Text;
                    Cmm.Parameters.Add("@Defeito", OleDbType.VarChar, 150).Value = os_defeito.Text;
                    Cmm.Parameters.Add("@Marca", OleDbType.VarChar, 150).Value = os_marca.Text;
                    Cmm.Parameters.Add("@Codigoproduto", OleDbType.VarChar, 150).Value = os_codigo.Text;
                    Cmm.Parameters.Add("@Dataentrada", OleDbType.Date).Value = os_data.Text;
                    Cmm.Parameters.Add("@Orcamento", OleDbType.VarChar, 799).Value = os_orcamento.Text;
                    Cmm.Parameters.Add("@Preco", OleDbType.VarChar, 150).Value = os_preco.Text;

                    Cmm.Parameters.Add("@Codigo", OleDbType.Integer, 50).Value = codigoTextBox.Text;

                    Cmm.CommandType = CommandType.Text;
                    Cmm.Connection = Con;
                    Cmm.ExecuteNonQuery();
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Falha na gravação do banco de dados : {0}", ex.Message));
                }
            }
        }
        //fim salva ordem!
        private void editar_ordem()
        {
            os_nome.ReadOnly = false;
            os_telefone.ReadOnly = false;
            cli_celular.ReadOnly = false;
            os_endereco.ReadOnly = false;
            os_numerocasa.ReadOnly = false;
            os_bairro.ReadOnly = false;
            os_referencia.ReadOnly = false;
            os_cidade.ReadOnly = false;
            os_defeito.ReadOnly = false;
            os_marca.ReadOnly = false;
            os_codigo.ReadOnly = false;
            os_data.Enabled = true;
            os_orcamento.ReadOnly = false;
            os_preco.ReadOnly = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (os_nome.Visible = true)
            {
                if (os_nome.Text == "")
                {
                    MessageBox.Show("Pesquise algo primeiro antes de editar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    editar_ordem();
                    vmodo = "alterar";
                }
            }
            else
            {
                MessageBox.Show("Pesquise algo antes de editar");
            }
        }
        private void ativa_tabela()
        {
            tabelaa.Visible = false;
            this.Width = 613;
            this.Height = 487;
        }

        private void ativar_tabela_Click(object sender, EventArgs e)
        {
            if (tabelaa.Visible == false)
            {
                tabelaa.Visible = true;
                this.Width = 853;
                this.Height = 487;
            }
            else
            {
                ativa_tabela();
            }
        }

        private void tabelaa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            codigoTextBox.Text = tabelaa[0, tabelaa.CurrentRow.Index].Value.ToString();
            os_nome.Text = tabelaa[2, tabelaa.CurrentRow.Index].Value.ToString();
            os_telefone.Text = tabelaa[3, tabelaa.CurrentRow.Index].Value.ToString();
            cli_celular.Text = tabelaa[15, tabelaa.CurrentRow.Index].Value.ToString();
            os_endereco.Text = tabelaa[4, tabelaa.CurrentRow.Index].Value.ToString();
            os_numerocasa.Text = tabelaa[5, tabelaa.CurrentRow.Index].Value.ToString();
            os_bairro.Text = tabelaa[6, tabelaa.CurrentRow.Index].Value.ToString();
            os_referencia.Text = tabelaa[8, tabelaa.CurrentRow.Index].Value.ToString();
            os_cidade.Text = tabelaa[7, tabelaa.CurrentRow.Index].Value.ToString();
            os_defeito.Text = tabelaa[12, tabelaa.CurrentRow.Index].Value.ToString();
            os_marca.Text = tabelaa[9, tabelaa.CurrentRow.Index].Value.ToString();
            os_codigo.Text = tabelaa[10, tabelaa.CurrentRow.Index].Value.ToString();
            os_data.Text = tabelaa[11, tabelaa.CurrentRow.Index].Value.ToString();
            os_orcamento.Text = tabelaa[13, tabelaa.CurrentRow.Index].Value.ToString();
            os_preco.Text = tabelaa[14, tabelaa.CurrentRow.Index].Value.ToString();
        }
    }
}
