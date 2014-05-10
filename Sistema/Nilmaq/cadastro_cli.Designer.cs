namespace Nilmaq
{
    partial class cadastro_cli
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
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label numerocasaLabel;
            System.Windows.Forms.Label bairroLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label referenciaLabel;
            System.Windows.Forms.Label celularLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastro_cli));
            this.tbClienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tbClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBADataSet = new Nilmaq.DBADataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbClienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cli_nome = new System.Windows.Forms.TextBox();
            this.cli_telefone = new System.Windows.Forms.MaskedTextBox();
            this.cli_endereco = new System.Windows.Forms.TextBox();
            this.cli_numerocasa = new System.Windows.Forms.TextBox();
            this.cli_bairro = new System.Windows.Forms.TextBox();
            this.cli_cidade = new System.Windows.Forms.TextBox();
            this.cli_referencia = new System.Windows.Forms.TextBox();
            this.tbClienteTableAdapter = new Nilmaq.DBADataSetTableAdapters.tbClienteTableAdapter();
            this.tableAdapterManager = new Nilmaq.DBADataSetTableAdapters.TableAdapterManager();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.cli_confirma = new System.Windows.Forms.Button();
            this.cli_cancela = new System.Windows.Forms.Button();
            this.cli_celular = new System.Windows.Forms.MaskedTextBox();
            nomeLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            numerocasaLabel = new System.Windows.Forms.Label();
            bairroLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            referenciaLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingNavigator)).BeginInit();
            this.tbClienteBindingNavigator.SuspendLayout();
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
            telefoneLabel.Location = new System.Drawing.Point(294, 43);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(52, 13);
            telefoneLabel.TabIndex = 5;
            telefoneLabel.Text = "Telefone:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(12, 73);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(56, 13);
            enderecoLabel.TabIndex = 7;
            enderecoLabel.Text = "Endereço:";
            // 
            // numerocasaLabel
            // 
            numerocasaLabel.AutoSize = true;
            numerocasaLabel.Location = new System.Drawing.Point(343, 73);
            numerocasaLabel.Name = "numerocasaLabel";
            numerocasaLabel.Size = new System.Drawing.Size(19, 13);
            numerocasaLabel.TabIndex = 9;
            numerocasaLabel.Text = "Nº";
            // 
            // bairroLabel
            // 
            bairroLabel.AutoSize = true;
            bairroLabel.Location = new System.Drawing.Point(437, 73);
            bairroLabel.Name = "bairroLabel";
            bairroLabel.Size = new System.Drawing.Size(37, 13);
            bairroLabel.TabIndex = 11;
            bairroLabel.Text = "Bairro:";
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(11, 104);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(43, 13);
            cidadeLabel.TabIndex = 13;
            cidadeLabel.Text = "Cidade:";
            // 
            // referenciaLabel
            // 
            referenciaLabel.AutoSize = true;
            referenciaLabel.Location = new System.Drawing.Point(182, 104);
            referenciaLabel.Name = "referenciaLabel";
            referenciaLabel.Size = new System.Drawing.Size(62, 13);
            referenciaLabel.TabIndex = 15;
            referenciaLabel.Text = "Próximo de:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(467, 43);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(42, 13);
            celularLabel.TabIndex = 0;
            celularLabel.Text = "Celular:";
            // 
            // tbClienteBindingNavigator
            // 
            this.tbClienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbClienteBindingNavigator.BindingSource = this.tbClienteBindingSource;
            this.tbClienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbClienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbClienteBindingNavigator.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.tbClienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbClienteBindingNavigatorSaveItem,
            this.toolStripSeparator1});
            this.tbClienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbClienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbClienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbClienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbClienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbClienteBindingNavigator.Name = "tbClienteBindingNavigator";
            this.tbClienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbClienteBindingNavigator.Size = new System.Drawing.Size(614, 37);
            this.tbClienteBindingNavigator.TabIndex = 0;
            this.tbClienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 34);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 34);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 34);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 34);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 34);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 37);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 34);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 34);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // tbClienteBindingNavigatorSaveItem
            // 
            this.tbClienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbClienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbClienteBindingNavigatorSaveItem.Image")));
            this.tbClienteBindingNavigatorSaveItem.Name = "tbClienteBindingNavigatorSaveItem";
            this.tbClienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 34);
            this.tbClienteBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tbClienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbClienteBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // cli_nome
            // 
            this.cli_nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "Nome", true));
            this.cli_nome.Location = new System.Drawing.Point(55, 40);
            this.cli_nome.Name = "cli_nome";
            this.cli_nome.Size = new System.Drawing.Size(227, 20);
            this.cli_nome.TabIndex = 2;
            // 
            // cli_telefone
            // 
            this.cli_telefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "Telefone", true));
            this.cli_telefone.Location = new System.Drawing.Point(352, 40);
            this.cli_telefone.Mask = "0000-00000";
            this.cli_telefone.Name = "cli_telefone";
            this.cli_telefone.Size = new System.Drawing.Size(100, 20);
            this.cli_telefone.TabIndex = 6;
            // 
            // cli_endereco
            // 
            this.cli_endereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "Endereco", true));
            this.cli_endereco.Location = new System.Drawing.Point(74, 70);
            this.cli_endereco.Name = "cli_endereco";
            this.cli_endereco.Size = new System.Drawing.Size(257, 20);
            this.cli_endereco.TabIndex = 8;
            // 
            // cli_numerocasa
            // 
            this.cli_numerocasa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "Numerocasa", true));
            this.cli_numerocasa.Location = new System.Drawing.Point(368, 70);
            this.cli_numerocasa.Name = "cli_numerocasa";
            this.cli_numerocasa.Size = new System.Drawing.Size(55, 20);
            this.cli_numerocasa.TabIndex = 10;
            // 
            // cli_bairro
            // 
            this.cli_bairro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "Bairro", true));
            this.cli_bairro.Location = new System.Drawing.Point(480, 70);
            this.cli_bairro.Name = "cli_bairro";
            this.cli_bairro.Size = new System.Drawing.Size(115, 20);
            this.cli_bairro.TabIndex = 12;
            // 
            // cli_cidade
            // 
            this.cli_cidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "Cidade", true));
            this.cli_cidade.Location = new System.Drawing.Point(60, 101);
            this.cli_cidade.Name = "cli_cidade";
            this.cli_cidade.Size = new System.Drawing.Size(106, 20);
            this.cli_cidade.TabIndex = 14;
            // 
            // cli_referencia
            // 
            this.cli_referencia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "Referencia", true));
            this.cli_referencia.Location = new System.Drawing.Point(250, 101);
            this.cli_referencia.Name = "cli_referencia";
            this.cli_referencia.Size = new System.Drawing.Size(345, 20);
            this.cli_referencia.TabIndex = 16;
            // 
            // tbClienteTableAdapter
            // 
            this.tbClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = this.tbClienteTableAdapter;
            this.tableAdapterManager.tbCompromissoTableAdapter = null;
            this.tableAdapterManager.tbGarantiaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Nilmaq.DBADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(614, 192);
            this.shapeContainer1.TabIndex = 29;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 14;
            this.lineShape1.X2 = 593;
            this.lineShape1.Y1 = 136;
            this.lineShape1.Y2 = 136;
            // 
            // cli_confirma
            // 
            this.cli_confirma.Location = new System.Drawing.Point(439, 149);
            this.cli_confirma.Name = "cli_confirma";
            this.cli_confirma.Size = new System.Drawing.Size(75, 27);
            this.cli_confirma.TabIndex = 30;
            this.cli_confirma.Text = "Concluir";
            this.cli_confirma.UseVisualStyleBackColor = true;
            this.cli_confirma.Click += new System.EventHandler(this.button1_Click);
            // 
            // cli_cancela
            // 
            this.cli_cancela.Location = new System.Drawing.Point(520, 149);
            this.cli_cancela.Name = "cli_cancela";
            this.cli_cancela.Size = new System.Drawing.Size(75, 27);
            this.cli_cancela.TabIndex = 31;
            this.cli_cancela.Text = "Cancelar";
            this.cli_cancela.UseVisualStyleBackColor = true;
            this.cli_cancela.Click += new System.EventHandler(this.cli_cancela_Click);
            // 
            // cli_celular
            // 
            this.cli_celular.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbClienteBindingSource, "Celular", true));
            this.cli_celular.Location = new System.Drawing.Point(510, 40);
            this.cli_celular.Mask = "0000-00000";
            this.cli_celular.Name = "cli_celular";
            this.cli_celular.Size = new System.Drawing.Size(85, 20);
            this.cli_celular.TabIndex = 32;
            // 
            // cadastro_cli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 192);
            this.Controls.Add(this.cli_celular);
            this.Controls.Add(celularLabel);
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
            this.Name = "cadastro_cli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de clientes";
            this.Load += new System.EventHandler(this.cadastro_cli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingNavigator)).EndInit();
            this.tbClienteBindingNavigator.ResumeLayout(false);
            this.tbClienteBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBADataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBADataSet dBADataSet;
        private System.Windows.Forms.BindingSource tbClienteBindingSource;
        private DBADataSetTableAdapters.tbClienteTableAdapter tbClienteTableAdapter;
        private DBADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbClienteBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbClienteBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox cli_nome;
        private System.Windows.Forms.MaskedTextBox cli_telefone;
        private System.Windows.Forms.TextBox cli_endereco;
        private System.Windows.Forms.TextBox cli_numerocasa;
        private System.Windows.Forms.TextBox cli_bairro;
        private System.Windows.Forms.TextBox cli_cidade;
        private System.Windows.Forms.TextBox cli_referencia;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button cli_confirma;
        private System.Windows.Forms.Button cli_cancela;
        private System.Windows.Forms.MaskedTextBox cli_celular;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}