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
    public partial class pesquisa_cli : Form
    {
        string vmodo;
        public pesquisa_cli()
        {
            InitializeComponent();
        }
        private void pesquisa_cli_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dBADataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.dBADataSet.tbCliente);

            tamanho_form();
        }


        private void cli_cancela_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cli_pesquisa_Click(object sender, EventArgs e)
        {
            botao_pesquisa();
        }
        private void limpa_campos()
        {
            cli_nome.Text = "";
            cli_telefone.Text = "";
            cli_celular.Text = "";
            cli_endereco.Text = "";
            cli_numerocasa.Text = "";
            cli_bairro.Text = "";
            cli_cidade.Text = "";
            cli_referencia.Text = "";
        }
        private void botao_pesquisa()
        {
           limpa_campos();
            if (cli_search.Text == "")
            {
                MessageBox.Show("Digite algo!", "Campo em branco", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                desativa_botao();
                return;
            }
            OleDbConnection Con = new OleDbConnection();
            // Con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='|DataDirectory|\DBA.accdb';Persist Security Info=True";
            Con.ConnectionString = Properties.Settings.Default.DBAConnectionString;
            try
            {
                Con.Open();
                OleDbCommand Cmm = new OleDbCommand();
                Cmm.CommandText = "Select Codigo, Nome, Telefone, Celular, Endereco, Numerocasa, Bairro, Cidade, Referencia From tbCliente WHERE Nome Like '" + cli_search.Text + "%'";
                Cmm.CommandType = CommandType.Text;
                Cmm.Connection = Con;

                OleDbDataReader DR;
                DR = Cmm.ExecuteReader();

                DR.Read();
                cli_codigo.Text = Convert.ToString(DR.GetInt32(0));
                cli_nome.Text = DR.GetString(1);
                cli_telefone.Text = Convert.ToString(DR.GetString(2));
                cli_celular.Text = Convert.ToString(DR.GetString(3));
                cli_endereco.Text = Convert.ToString(DR.GetString(4));
                cli_numerocasa.Text = Convert.ToString(DR.GetString(5));
                cli_bairro.Text = Convert.ToString(DR.GetString(6));
                cli_cidade.Text = Convert.ToString(DR.GetString(7));
                cli_referencia.Text = Convert.ToString(DR.GetString(8));
                
                Con.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao pesquisar, Cadastro contendo algo em branco ou inexistente");
            }
        }

        private void cli_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                botao_pesquisa();
            }
        }
        private void ativa_botao()
        {
            cli_nome.ReadOnly = false;
            cli_telefone.ReadOnly = false; ;
            cli_celular.ReadOnly = false;
            cli_endereco.ReadOnly = false;
            cli_numerocasa.ReadOnly = false;
            cli_bairro.ReadOnly = false;
            cli_cidade.ReadOnly = false;
            cli_referencia.ReadOnly = false;
        }

        private void cli_edita_Click(object sender, EventArgs e)
        {
            if (cli_nome.Text == "")
            {
                MessageBox.Show("Não é possível editar um registro em branco", "Pesquise algo primeiro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ativa_botao();
            vmodo = "alterar";
        }
        private void salvar()
        {
            if (vmodo == "alterar")
            {
                //asfasf
                OleDbConnection Con = new OleDbConnection();
                Con.ConnectionString = Properties.Settings.Default.DBAConnectionString;
                try
                {
                    Con.Open();
                    OleDbCommand Cmm = new OleDbCommand();
                    Cmm.CommandText = "UPDATE tbCliente SET Nome = ?, Telefone = ?, Celular = ?, Endereco = ?, Numerocasa = ?, Bairro = ?, Cidade = ?, Referencia = ? WHERE Codigo = ? ";
                    Cmm.Parameters.Clear();
                    Cmm.Parameters.Add("@Nome", OleDbType.VarChar, 50).Value = cli_nome.Text;
                    Cmm.Parameters.Add("@Telefone", OleDbType.VarChar, 50).Value = cli_telefone.Text;
                    Cmm.Parameters.Add("@Celular", OleDbType.VarChar, 50).Value = cli_celular.Text;
                    Cmm.Parameters.Add("@Endereco", OleDbType.VarChar, 150).Value = cli_endereco.Text;
                    Cmm.Parameters.Add("@Numerocasa", OleDbType.VarChar, 50).Value = cli_numerocasa.Text;
                    Cmm.Parameters.Add("@Bairro", OleDbType.VarChar, 50).Value = cli_bairro.Text;
                    Cmm.Parameters.Add("@Cidade", OleDbType.VarChar, 50).Value = cli_cidade.Text;
                    Cmm.Parameters.Add("@Referencia", OleDbType.VarChar, 150).Value = cli_referencia.Text;
                    Cmm.Parameters.Add("@Codigo", OleDbType.Integer, 50).Value = cli_codigo.Text;



                    Cmm.CommandType = CommandType.Text;
                    Cmm.Connection = Con;
                    Cmm.ExecuteNonQuery();
                    Con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Falha na gravação do banco de dados : {0}", ex.Message));
                }

                //asfasf
            }
        }

        private void cli_salvar_Click(object sender, EventArgs e)
        {
            salvar();
        }

        private void cli_confirma_Click(object sender, EventArgs e)
        {
            salvar();
            Close();
        }
        private void tamanho_form()
        {
            tabelaa.Visible = false;
            this.Width = 635;
            this.Height = 228;
        }

        private void ativa_lista_Click(object sender, EventArgs e)
        {
            if (tabelaa.Visible == false)
            {
                tabelaa.Visible = true;
                this.Width = 928;
                this.Height = 298;
            }
            else
            {
                tabelaa.Visible = false;
                this.Width = 635;
                this.Height = 228;
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbClienteTableAdapter.FillBy(this.dBADataSet.tbCliente);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void desativa_botao()
        {
            cli_nome.ReadOnly = true;
            cli_telefone.ReadOnly = true;
            cli_celular.ReadOnly = true;
            cli_endereco.ReadOnly = true;
            cli_numerocasa.ReadOnly = true;
            cli_bairro.ReadOnly = true;
            cli_cidade.ReadOnly = true;
            cli_referencia.ReadOnly = true;
        }

        private void tabelaa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cli_codigo.Text = tabelaa[0, tabelaa.CurrentRow.Index].Value.ToString();
            cli_nome.Text = tabelaa[2, tabelaa.CurrentRow.Index].Value.ToString();
            cli_telefone.Text = tabelaa[3, tabelaa.CurrentRow.Index].Value.ToString();
            cli_celular.Text = tabelaa[15, tabelaa.CurrentRow.Index].Value.ToString();
            cli_endereco.Text = tabelaa[4, tabelaa.CurrentRow.Index].Value.ToString();
            cli_numerocasa.Text = tabelaa[5, tabelaa.CurrentRow.Index].Value.ToString();
            cli_bairro.Text = tabelaa[6, tabelaa.CurrentRow.Index].Value.ToString();
            cli_referencia.Text = tabelaa[8, tabelaa.CurrentRow.Index].Value.ToString();
            cli_cidade.Text = tabelaa[7, tabelaa.CurrentRow.Index].Value.ToString();
        }
    }
}