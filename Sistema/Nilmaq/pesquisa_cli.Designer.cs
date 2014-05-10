namespace Nilmaq
{
    partial class pesquisa_cli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label numerocasaLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label referenciaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pesquisa_cli));
            this.cli_nome = new System.Windows.Forms.TextBox();
            this.cli_telefone = new System.Windows.Forms.MaskedTextBox();
            this.cli_celular = new System.Windows.Forms.MaskedTextBox();
            this.cli_endereco = new System.Windows.Forms.TextBox();
            this.cli_numerocasa = new System.Windows.Forms.TextBox();
            this.cli_bairro = new System.Windows.Forms.TextBox();
            this.cli_cidade = new System.Windows.Forms.TextBox();
            this.cli_referencia = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.cli_codigo = new System.Windows.Forms.TextBox();
            this.cli_cancela = new System.Windows.Forms.Button();
            this.cli_confirma = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.cli_search = new System.Windows.Forms.ToolStripTextBox();
            this.cli_pesquisa = new System.Windows.Forms.ToolStripButton();
            this.tbClienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cli_edita = new System.Windows.Forms.ToolStripButton();
            this.cli_salvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ativa_lista = new System.Windows.Forms.ToolStripButton();
            this.tabelaa = new System.Windows.Forms.DataGridView();
            this.tbClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBADataSet = new Nilmaq.DBADataSet();
            this.tbClienteTableAdapter = new Nilmaq.DBADataSetTableAdapters.tbClienteTableAdapter();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerocasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataentradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defeitoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orcamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nomeLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            numerocasaLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            referenciaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingNavigator)).BeginInit();
            this.tbClienteBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(11, 43);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 1;
            nomeLabel.Text = "Nome:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(299, 43);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 5;
            telefoneLabel.Text = "Telefone:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(456, 43);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(42, 13);
            celularLabel.TabIndex = 7;
            celularLabel.Text = "Celular:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(12, 73);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(56, 13);
            enderecoLabel.TabIndex = 9;
            enderecoLabel.Text = "Endereço:";
            // 
            // numerocasaLabel
            // 
            numerocasaLabel.AutoSize = true;
            numerocasaLabel.Location = new System.Drawing.Point(348, 73);
            numerocasaLabel.Name = "numerocasaLabel";
            numerocasaLabel.Size = new System.Drawing.Size(19, 13);
            numerocasaLabel.TabIndex = 11;
            numerocasaLabel.Text = "Nº";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(446, 73);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(37, 13);
            bairroLabel.TabIndex = 13;
            bairroLabel.Text = "Bairro:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(12, 104);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(43, 13);
            cidadeLabel.TabIndex = 15;
            cidadeLabel.Text = "Cidade:";
            // 
            // referenciaLabel
            // 
            referenciaLabel.AutoSize = true;
            referenciaLabel.Location = new System.Drawing.Point(188, 104);
            referenciaLabel.Name = "referenciaLabel";
            referenciaLabel.Size = new System.Drawing.Size(62, 13);
            referenciaLabel.TabIndex = 17;
            referenciaLabel.Text = "Próximo de:";
            // 
            // cli_nome
            // 
            this.cli_nome.Location = new System.Drawing.Point(55, 40);
            this.cli_nome.MaxLength = 120;
            this.cli_nome.Name = "cli_nome";
            this.cli_nome.ReadOnly = true;
            this.cli_nome.Size = new System.Drawing.Size(227, 20);
            this.cli_nome.TabIndex = 2;
            // 
            // cli_telefone
            // 
            this.cli_telefone.Location = new System.Drawing.Point(357, 40);
            this.cli_telefone.Mask = "0000-00000";
            this.cli_telefone.Name = "cli_telefone";
            this.cli_telefone.ReadOnly = true;
            this.cli_telefone.Size = new System.Drawing.Size(85, 20);
            this.cli_telefone.TabIndex = 6;
            // 
            // cli_celular
            // 
            this.cli_celular.Location = new System.Drawing.Point(499, 40);
            this.cli_celular.Mask = "0000-00000";
            this.cli_celular.Name = "cli_celular";
            this.cli_celular.ReadOnly = true;
            this.cli_celular.Size = new System.Drawing.Size(85, 20);
            this.cli_celular.TabIndex = 8;
            // 
            // cli_endereco
            // 
            this.cli_endereco.Location = new System.Drawing.Point(74, 70);
            this.cli_endereco.Name = "cli_endereco";
            this.cli_endereco.ReadOnly = true;
            this.cli_endereco.Size = new System.Drawing.Size(257, 20);
            this.cli_endereco.TabIndex = 10;
            // 
            // cli_numerocasa
            // 
            this.cli_numerocasa.Location = new System.Drawing.Point(373, 70);
            this.cli_numerocasa.Name = "cli_numerocasa";
            this.cli_numerocasa.ReadOnly = true;
            this.cli_numerocasa.Size = new System.Drawing.Size(61, 20);
            this.cli_numerocasa.TabIndex = 12;
            // 
            // cli_bairro
            // 
            this.cli_bairro.Location = new System.Drawing.Point(489, 70);
            this.cli_bairro.MaxLength = 40;
            this.cli_bairro.Name = "cli_bairro";
            this.cli_bairro.ReadOnly = true;
            this.cli_bairro.Size = new System.Drawing.Size(115, 20);
            this.cli_bairro.TabIndex = 14;
            // 
            // cli_cidade
            // 
            this.cli_cidade.Location = new System.Drawing.Point(61, 101);
            this.cli_cidade.MaxLength = 35;
            this.cli_cidade.Name = "cli_cidade";
            this.cli_cidade.ReadOnly = true;
            this.cli_cidade.Size = new System.Drawing.Size(106, 20);
            this.cli_cidade.TabIndex = 16;
            // 
            // cli_referencia
            // 
            this.cli_referencia.Location = new System.Drawing.Point(256, 101);
            this.cli_referencia.MaxLength = 120;
            this.cli_referencia.Name = "cli_referencia";
            this.cli_referencia.ReadOnly = true;
            this.cli_referencia.Size = new System.Drawing.Size(348, 20);
            this.cli_referencia.TabIndex = 18;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(912, 259);
            this.shapeContainer1.TabIndex = 19;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 15;
            this.lineShape1.X2 = 603;
            this.lineShape1.Y1 = 136;
            this.lineShape1.Y2 = 136;
            // 
            // cli_codigo
            // 
            this.cli_codigo.Location = new System.Drawing.Point(15, 154);
            this.cli_codigo.Name = "cli_codigo";
            this.cli_codigo.ReadOnly = true;
            this.cli_codigo.Size = new System.Drawing.Size(1, 20);
            this.cli_codigo.TabIndex = 1;
            // 
            // cli_cancela
            // 
            this.cli_cancela.Location = new System.Drawing.Point(529, 147);
            this.cli_cancela.Name = "cli_cancela";
            this.cli_cancela.Size = new System.Drawing.Size(75, 27);
            this.cli_cancela.TabIndex = 33;
            this.cli_cancela.Text = "Cancelar";
            this.cli_cancela.UseVisualStyleBackColor = true;
            this.cli_cancela.Click += new System.EventHandler(this.cli_cancela_Click);
            // 
            // cli_confirma
            // 
            this.cli_confirma.Location = new System.Drawing.Point(448, 147);
            this.cli_confirma.Name = "cli_confirma";
            this.cli_confirma.Size = new System.Drawing.Size(75, 27);
            this.cli_confirma.TabIndex = 32;
            this.cli_confirma.Text = "Concluir";
            this.cli_confirma.UseVisualStyleBackColor = true;
            this.cli_confirma.Click += new System.EventHandler(this.cli_confirma_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 34);
            // 
            // cli_search
            // 
            this.cli_search.Name = "cli_search";
            this.cli_search.Size = new System.Drawing.Size(100, 37);
            this.cli_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cli_search_KeyPress);
            // 
            // cli_pesquisa
            // 
            this.cli_pesquisa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cli_pesquisa.Image = ((System.Drawing.Image)(resources.GetObject("cli_pesquisa.Image")));
            this.cli_pesquisa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cli_pesquisa.Name = "cli_pesquisa";
            this.cli_pesquisa.Size = new System.Drawing.Size(34, 34);
            this.cli_pesquisa.Text = "Pesquisar";
            this.cli_pesquisa.Click += new System.EventHandler(this.cli_pesquisa_Click);
            // 
            // tbClienteBindingNavigator
            // 
            this.tbClienteBindingNavigator.AddNewItem = null;
            this.tbClienteBindingNavigator.CountItem = null;
            this.tbClienteBindingNavigator.DeleteItem = null;
            this.tbClienteBindingNavigator.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.tbClienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.cli_search,
            this.cli_pesquisa,
            this.toolStripSeparator1,
            this.cli_edita,
            this.cli_salvar,
            this.toolStripSeparator2,
            this.ativa_lista});
            this.tbClienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbClienteBindingNavigator.MoveFirstItem = null;
            this.tbClienteBindingNavigator.MoveLastItem = null;
            this.tbClienteBindingNavigator.MoveNextItem = null;
            this.tbClienteBindingNavigator.MovePreviousItem = null;
            this.tbClienteBindingNavigator.Name = "tbClienteBindingNavigator";
            this.tbClienteBindingNavigator.PositionItem = null;
            this.tbClienteBindingNavigator.Size = new System.Drawing.Size(912, 37);
            this.tbClienteBindingNavigator.TabIndex = 0;
            this.tbClienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // cli_edita
            // 
            this.cli_edita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cli_edita.Image = ((System.Drawing.Image)(resources.GetObject("cli_edita.Image")));
            this.cli_edita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cli_edita.Name = "cli_edita";
            this.cli_edita.Size = new System.Drawing.Size(34, 34);
            this.cli_edita.Text = "Editar";
            this.cli_edita.Click += new System.EventHandler(this.cli_edita_Click);
            // 
            // cli_salvar
            // 
            this.cli_salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cli_salvar.Image = ((System.Drawing.Image)(resources.GetObject("cli_salvar.Image")));
            this.cli_salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cli_salvar.Name = "cli_salvar";
            this.cli_salvar.Size = new System.Drawing.Size(34, 34);
            this.cli_salvar.Text = "Salvar";
            this.cli_salvar.Click += new System.EventHandler(this.cli_salvar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // ativa_lista
            // 
            this.ativa_lista.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ativa_lista.Image = ((System.Drawing.Image)(resources.GetObject("ativa_lista.Image")));
            this.ativa_lista.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ativa_lista.Name = "ativa_lista";
            this.ativa_lista.Size = new System.Drawing.Size(34, 34);
            this.ativa_lista.Text = "lista";
            this.ativa_lista.Click += new System.EventHandler(this.ativa_lista_Click);
            // 
            // tabelaa
            // 
            this.tabelaa.AllowUserToAddRows = false;
            this.tabelaa.AllowUserToDeleteRows = false;
            this.tabelaa.AutoGenerateColumns = false;
            this.tabelaa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.numerocasaDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.referenciaDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.codigoprodutoDataGridViewTextBoxColumn,
            this.dataentradaDataGridViewTextBoxColumn,
            this.defeitoDataGridViewTextBoxColumn,
            this.orcamentoDataGridViewTextBoxColumn,
            this.precoDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn});
            this.tabelaa.DataSource = this.tbClienteBindingSource;
            this.tabelaa.Location = new System.Drawing.Point(627, 40);
            this.tabelaa.Name = "tabelaa";
            this.tabelaa.ReadOnly = true;
            this.tabelaa.Size = new System.Drawing.Size(273, 207);
            this.tabelaa.TabIndex = 34;
            this.tabelaa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaa_CellDoubleClick);
            // 
            // tbClienteBindingSource
            // 
            this.tbClienteBindingSource.DataMember = "tbCliente";
            this.tbClienteBindingSource.DataSource = this.dBADataSet;
            // 
            // dBADataSet
            // 
            this.dBADataSet.DataSetName = "DBADataSet";
            this.dBADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbClienteTableAdapter
            // 
            this.tbClienteTableAdapter.ClearBeforeFill = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.codigoDataGridViewTextBoxColumn.Visible = false;
            this.codigoDataGridViewTextBoxColumn.Width = 50;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPFDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 230;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            this.enderecoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numerocasaDataGridViewTextBoxColumn
            // 
            this.numerocasaDataGridViewTextBoxColumn.DataPropertyName = "Numerocasa";
            this.numerocasaDataGridViewTextBoxColumn.HeaderText = "Numerocasa";
            this.numerocasaDataGridViewTextBoxColumn.Name = "numerocasaDataGridViewTextBoxColumn";
            this.numerocasaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // referenciaDataGridViewTextBoxColumn
            // 
            this.referenciaDataGridViewTextBoxColumn.DataPropertyName = "Referencia";
            this.referenciaDataGridViewTextBoxColumn.HeaderText = "Referencia";
            this.referenciaDataGridViewTextBoxColumn.Name = "referenciaDataGridViewTextBoxColumn";
            this.referenciaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoprodutoDataGridViewTextBoxColumn
            // 
            this.codigoprodutoDataGridViewTextBoxColumn.DataPropertyName = "Codigoproduto";
            this.codigoprodutoDataGridViewTextBoxColumn.HeaderText = "Codigoproduto";
            this.codigoprodutoDataGridViewTextBoxColumn.Name = "codigoprodutoDataGridViewTextBoxColumn";
            this.codigoprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataentradaDataGridViewTextBoxColumn
            // 
            this.dataentradaDataGridViewTextBoxColumn.DataPropertyName = "Dataentrada";
            this.dataentradaDataGridViewTextBoxColumn.HeaderText = "Dataentrada";
            this.dataentradaDataGridViewTextBoxColumn.Name = "dataentradaDataGridViewTextBoxColumn";
            this.dataentradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // defeitoDataGridViewTextBoxColumn
            // 
            this.defeitoDataGridViewTextBoxColumn.DataPropertyName = "Defeito";
            this.defeitoDataGridViewTextBoxColumn.HeaderText = "Defeito";
            this.defeitoDataGridViewTextBoxColumn.Name = "defeitoDataGridViewTextBoxColumn";
            this.defeitoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orcamentoDataGridViewTextBoxColumn
            // 
            this.orcamentoDataGridViewTextBoxColumn.DataPropertyName = "Orcamento";
            this.orcamentoDataGridViewTextBoxColumn.HeaderText = "Orcamento";
            this.orcamentoDataGridViewTextBoxColumn.Name = "orcamentoDataGridViewTextBoxColumn";
            this.orcamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precoDataGridViewTextBoxColumn
            // 
            this.precoDataGridViewTextBoxColumn.DataPropertyName = "Preco";
            this.precoDataGridViewTextBoxColumn.HeaderText = "Preco";
            this.precoDataGridViewTextBoxColumn.Name = "precoDataGridViewTextBoxColumn";
            this.precoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "Celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pesquisa_cli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 259);
            this.Controls.Add(this.tabelaa);
            this.Controls.Add(this.cli_codigo);
            this.Controls.Add(this.cli_cancela);
            this.Controls.Add(this.cli_confirma);
            this.Controls.Add(referenciaLabel);
            this.Controls.Add(this.cli_referencia);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cli_cidade);
            this.Controls.Add(bairroLabel);
            this.Controls.Add(this.cli_bairro);
            this.Controls.Add(numerocasaLabel);
            this.Controls.Add(this.cli_numerocasa);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.cli_endereco);
            this.Controls.Add(this.cli_celular);
            this.Controls.Add(celularLabel);
            this.Controls.Add(this.cli_telefone);
            this.Controls.Add(telefoneLabel);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.cli_nome);
            this.Controls.Add(this.tbClienteBindingNavigator);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pesquisa_cli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa de clientes";
            this.Load += new System.EventHandler(this.pesquisa_cli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingNavigator)).EndInit();
            this.tbClienteBindingNavigator.ResumeLayout(false);
            this.tbClienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBADataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cli_nome;
        private System.Windows.Forms.MaskedTextBox cli_telefone;
        private System.Windows.Forms.MaskedTextBox cli_celular;
        private System.Windows.Forms.TextBox cli_endereco;
        private System.Windows.Forms.TextBox cli_numerocasa;
        private System.Windows.Forms.TextBox cli_bairro;
        private System.Windows.Forms.TextBox cli_cidade;
        private System.Windows.Forms.TextBox cli_referencia;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button cli_cancela;
        private System.Windows.Forms.Button cli_confirma;
        private System.Windows.Forms.TextBox cli_codigo;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripTextBox cli_search;
        private System.Windows.Forms.ToolStripButton cli_pesquisa;
        private System.Windows.Forms.BindingNavigator tbClienteBindingNavigator;
        private DBADataSet dBADataSet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton cli_edita;
        private System.Windows.Forms.ToolStripButton cli_salvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ativa_lista;
        private System.Windows.Forms.DataGridView tabelaa;
        private System.Windows.Forms.BindingSource tbClienteBindingSource;
        private DBADataSetTableAdapters.tbClienteTableAdapter tbClienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerocasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataentradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defeitoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orcamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
    }
}