namespace Nilmaq
{
    partial class termos_garantia
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
            System.Windows.Forms.Label garantiaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(termos_garantia));
            this.dBADataSet = new Nilmaq.DBADataSet();
            this.tbGarantiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbGarantiaTableAdapter = new Nilmaq.DBADataSetTableAdapters.tbGarantiaTableAdapter();
            this.tableAdapterManager = new Nilmaq.DBADataSetTableAdapters.TableAdapterManager();
            this.tbGarantiaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.tbGarantiaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.garantiaTextBox = new System.Windows.Forms.TextBox();
            garantiaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dBADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGarantiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGarantiaBindingNavigator)).BeginInit();
            this.tbGarantiaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // garantiaLabel
            // 
            garantiaLabel.AutoSize = true;
            garantiaLabel.Location = new System.Drawing.Point(12, 43);
            garantiaLabel.Name = "garantiaLabel";
            garantiaLabel.Size = new System.Drawing.Size(101, 13);
            garantiaLabel.TabIndex = 1;
            garantiaLabel.Text = "Termos de garantia:";
            // 
            // dBADataSet
            // 
            this.dBADataSet.DataSetName = "DBADataSet";
            this.dBADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbGarantiaBindingSource
            // 
            this.tbGarantiaBindingSource.DataMember = "tbGarantia";
            this.tbGarantiaBindingSource.DataSource = this.dBADataSet;
            // 
            // tbGarantiaTableAdapter
            // 
            this.tbGarantiaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = null;
            this.tableAdapterManager.tbCompromissoTableAdapter = null;
            this.tableAdapterManager.tbGarantiaTableAdapter = this.tbGarantiaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Nilmaq.DBADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbGarantiaBindingNavigator
            // 
            this.tbGarantiaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbGarantiaBindingNavigator.BindingSource = this.tbGarantiaBindingSource;
            this.tbGarantiaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbGarantiaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbGarantiaBindingNavigator.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.tbGarantiaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbGarantiaBindingNavigatorSaveItem});
            this.tbGarantiaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbGarantiaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbGarantiaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbGarantiaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbGarantiaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbGarantiaBindingNavigator.Name = "tbGarantiaBindingNavigator";
            this.tbGarantiaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbGarantiaBindingNavigator.Size = new System.Drawing.Size(464, 37);
            this.tbGarantiaBindingNavigator.TabIndex = 0;
            this.tbGarantiaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 34);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
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
            // tbGarantiaBindingNavigatorSaveItem
            // 
            this.tbGarantiaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbGarantiaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbGarantiaBindingNavigatorSaveItem.Image")));
            this.tbGarantiaBindingNavigatorSaveItem.Name = "tbGarantiaBindingNavigatorSaveItem";
            this.tbGarantiaBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 34);
            this.tbGarantiaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tbGarantiaBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbGarantiaBindingNavigatorSaveItem_Click);
            // 
            // garantiaTextBox
            // 
            this.garantiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbGarantiaBindingSource, "Garantia", true));
            this.garantiaTextBox.Location = new System.Drawing.Point(15, 59);
            this.garantiaTextBox.MaxLength = 800;
            this.garantiaTextBox.Multiline = true;
            this.garantiaTextBox.Name = "garantiaTextBox";
            this.garantiaTextBox.Size = new System.Drawing.Size(437, 230);
            this.garantiaTextBox.TabIndex = 2;
            // 
            // termos_garantia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 306);
            this.Controls.Add(garantiaLabel);
            this.Controls.Add(this.garantiaTextBox);
            this.Controls.Add(this.tbGarantiaBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "termos_garantia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Termos de garantia";
            this.Load += new System.EventHandler(this.termos_garantia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dBADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGarantiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGarantiaBindingNavigator)).EndInit();
            this.tbGarantiaBindingNavigator.ResumeLayout(false);
            this.tbGarantiaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DBADataSet dBADataSet;
        private System.Windows.Forms.BindingSource tbGarantiaBindingSource;
        private DBADataSetTableAdapters.tbGarantiaTableAdapter tbGarantiaTableAdapter;
        private DBADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbGarantiaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbGarantiaBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox garantiaTextBox;
    }
}