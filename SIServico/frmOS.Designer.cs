﻿namespace SIServico
{
    partial class frmOS
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
            System.Windows.Forms.Label idOrdemLabel;
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label idServicoLabel;
            System.Windows.Forms.Label dataDiaLabel;
            System.Windows.Forms.Label cadastradoPorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOS));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idOrdemTextBox = new System.Windows.Forms.TextBox();
            this.tbOrdemServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbServicoDataSet = new SIServico.dbServicoDataSet();
            this.idClienteComboBox = new System.Windows.Forms.ComboBox();
            this.tbClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idServicoComboBox = new System.Windows.Forms.ComboBox();
            this.tbServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDiaTextBox = new System.Windows.Forms.TextBox();
            this.cadastradoPorTextBox = new System.Windows.Forms.TextBox();
            this.tbOrdemServicoTableAdapter = new SIServico.dbServicoDataSetTableAdapters.tbOrdemServicoTableAdapter();
            this.tableAdapterManager = new SIServico.dbServicoDataSetTableAdapters.TableAdapterManager();
            this.tbClienteTableAdapter = new SIServico.dbServicoDataSetTableAdapters.tbClienteTableAdapter();
            this.tbServicoTableAdapter = new SIServico.dbServicoDataSetTableAdapters.tbServicoTableAdapter();
            this.tbOrdemServicoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tbOrdemServicoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbmFiltrar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbOrdemServicoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idOrdemLabel = new System.Windows.Forms.Label();
            idClienteLabel = new System.Windows.Forms.Label();
            idServicoLabel = new System.Windows.Forms.Label();
            dataDiaLabel = new System.Windows.Forms.Label();
            cadastradoPorLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbServicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemServicoBindingNavigator)).BeginInit();
            this.tbOrdemServicoBindingNavigator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemServicoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idOrdemLabel
            // 
            idOrdemLabel.AutoSize = true;
            idOrdemLabel.Location = new System.Drawing.Point(6, 28);
            idOrdemLabel.Name = "idOrdemLabel";
            idOrdemLabel.Size = new System.Drawing.Size(125, 26);
            idOrdemLabel.TabIndex = 0;
            idOrdemLabel.Text = "Código OS:";
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.Location = new System.Drawing.Point(247, 28);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(175, 26);
            idClienteLabel.TabIndex = 2;
            idClienteLabel.Text = "Nome do Cliente";
            // 
            // idServicoLabel
            // 
            idServicoLabel.AutoSize = true;
            idServicoLabel.Location = new System.Drawing.Point(6, 92);
            idServicoLabel.Name = "idServicoLabel";
            idServicoLabel.Size = new System.Drawing.Size(186, 26);
            idServicoLabel.TabIndex = 4;
            idServicoLabel.Text = "Nome do Serviço:";
            // 
            // dataDiaLabel
            // 
            dataDiaLabel.AutoSize = true;
            dataDiaLabel.Location = new System.Drawing.Point(6, 157);
            dataDiaLabel.Name = "dataDiaLabel";
            dataDiaLabel.Size = new System.Drawing.Size(188, 26);
            dataDiaLabel.TabIndex = 6;
            dataDiaLabel.Text = "Data do Cadastro:";
            // 
            // cadastradoPorLabel
            // 
            cadastradoPorLabel.AutoSize = true;
            cadastradoPorLabel.Location = new System.Drawing.Point(247, 157);
            cadastradoPorLabel.Name = "cadastradoPorLabel";
            cadastradoPorLabel.Size = new System.Drawing.Size(170, 26);
            cadastradoPorLabel.TabIndex = 8;
            cadastradoPorLabel.Text = "Cadastrado Por:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idOrdemLabel);
            this.groupBox1.Controls.Add(this.idOrdemTextBox);
            this.groupBox1.Controls.Add(idClienteLabel);
            this.groupBox1.Controls.Add(this.idClienteComboBox);
            this.groupBox1.Controls.Add(idServicoLabel);
            this.groupBox1.Controls.Add(this.idServicoComboBox);
            this.groupBox1.Controls.Add(dataDiaLabel);
            this.groupBox1.Controls.Add(this.dataDiaTextBox);
            this.groupBox1.Controls.Add(cadastradoPorLabel);
            this.groupBox1.Controls.Add(this.cadastradoPorTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados OS";
            // 
            // idOrdemTextBox
            // 
            this.idOrdemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbOrdemServicoBindingSource, "idOrdem", true));
            this.idOrdemTextBox.Location = new System.Drawing.Point(11, 57);
            this.idOrdemTextBox.Name = "idOrdemTextBox";
            this.idOrdemTextBox.ReadOnly = true;
            this.idOrdemTextBox.Size = new System.Drawing.Size(208, 32);
            this.idOrdemTextBox.TabIndex = 0;
            // 
            // tbOrdemServicoBindingSource
            // 
            this.tbOrdemServicoBindingSource.DataMember = "tbOrdemServico";
            this.tbOrdemServicoBindingSource.DataSource = this.dbServicoDataSet;
            // 
            // dbServicoDataSet
            // 
            this.dbServicoDataSet.DataSetName = "dbServicoDataSet";
            this.dbServicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idClienteComboBox
            // 
            this.idClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbOrdemServicoBindingSource, "idCliente", true));
            this.idClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbOrdemServicoBindingSource, "idCliente", true));
            this.idClienteComboBox.DataSource = this.tbClienteBindingSource;
            this.idClienteComboBox.DisplayMember = "idCliente";
            this.idClienteComboBox.FormattingEnabled = true;
            this.idClienteComboBox.Location = new System.Drawing.Point(252, 56);
            this.idClienteComboBox.Name = "idClienteComboBox";
            this.idClienteComboBox.Size = new System.Drawing.Size(231, 33);
            this.idClienteComboBox.TabIndex = 0;
            this.idClienteComboBox.ValueMember = "nome";
            // 
            // tbClienteBindingSource
            // 
            this.tbClienteBindingSource.DataMember = "tbCliente";
            this.tbClienteBindingSource.DataSource = this.dbServicoDataSet;
            // 
            // idServicoComboBox
            // 
            this.idServicoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbOrdemServicoBindingSource, "idServico", true));
            this.idServicoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbOrdemServicoBindingSource, "idServico", true));
            this.idServicoComboBox.DataSource = this.tbServicoBindingSource;
            this.idServicoComboBox.DisplayMember = "nome";
            this.idServicoComboBox.FormattingEnabled = true;
            this.idServicoComboBox.Location = new System.Drawing.Point(11, 121);
            this.idServicoComboBox.Name = "idServicoComboBox";
            this.idServicoComboBox.Size = new System.Drawing.Size(472, 33);
            this.idServicoComboBox.TabIndex = 1;
            this.idServicoComboBox.ValueMember = "idServico";
            // 
            // tbServicoBindingSource
            // 
            this.tbServicoBindingSource.DataMember = "tbServico";
            this.tbServicoBindingSource.DataSource = this.dbServicoDataSet;
            // 
            // dataDiaTextBox
            // 
            this.dataDiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbOrdemServicoBindingSource, "dataDia", true));
            this.dataDiaTextBox.Location = new System.Drawing.Point(11, 186);
            this.dataDiaTextBox.Name = "dataDiaTextBox";
            this.dataDiaTextBox.Size = new System.Drawing.Size(208, 32);
            this.dataDiaTextBox.TabIndex = 2;
            // 
            // cadastradoPorTextBox
            // 
            this.cadastradoPorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbOrdemServicoBindingSource, "cadastradoPor", true));
            this.cadastradoPorTextBox.Location = new System.Drawing.Point(252, 186);
            this.cadastradoPorTextBox.Name = "cadastradoPorTextBox";
            this.cadastradoPorTextBox.Size = new System.Drawing.Size(231, 32);
            this.cadastradoPorTextBox.TabIndex = 3;
            // 
            // tbOrdemServicoTableAdapter
            // 
            this.tbOrdemServicoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = this.tbClienteTableAdapter;
            this.tableAdapterManager.tbOrdemServicoTableAdapter = this.tbOrdemServicoTableAdapter;
            this.tableAdapterManager.tbServicoTableAdapter = this.tbServicoTableAdapter;
            this.tableAdapterManager.tbUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SIServico.dbServicoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbClienteTableAdapter
            // 
            this.tbClienteTableAdapter.ClearBeforeFill = true;
            // 
            // tbServicoTableAdapter
            // 
            this.tbServicoTableAdapter.ClearBeforeFill = true;
            // 
            // tbOrdemServicoBindingNavigator
            // 
            this.tbOrdemServicoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbOrdemServicoBindingNavigator.BindingSource = this.tbOrdemServicoBindingSource;
            this.tbOrdemServicoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbOrdemServicoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbOrdemServicoBindingNavigator.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.tbOrdemServicoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbOrdemServicoBindingNavigatorSaveItem});
            this.tbOrdemServicoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbOrdemServicoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbOrdemServicoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbOrdemServicoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbOrdemServicoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbOrdemServicoBindingNavigator.Name = "tbOrdemServicoBindingNavigator";
            this.tbOrdemServicoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbOrdemServicoBindingNavigator.Size = new System.Drawing.Size(553, 26);
            this.tbOrdemServicoBindingNavigator.TabIndex = 1;
            this.tbOrdemServicoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(26, 23);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(44, 26);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(26, 26);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(26, 26);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(26, 26);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 29);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9.163636F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 26);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(26, 26);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(26, 26);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // tbOrdemServicoBindingNavigatorSaveItem
            // 
            this.tbOrdemServicoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbOrdemServicoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbOrdemServicoBindingNavigatorSaveItem.Image")));
            this.tbOrdemServicoBindingNavigatorSaveItem.Name = "tbOrdemServicoBindingNavigatorSaveItem";
            this.tbOrdemServicoBindingNavigatorSaveItem.Size = new System.Drawing.Size(26, 26);
            this.tbOrdemServicoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tbOrdemServicoBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbOrdemServicoBindingNavigatorSaveItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPesquisar);
            this.groupBox2.Controls.Add(this.txtPesquisar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbmFiltrar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 89);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisa OS";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(406, 42);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(117, 33);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(281, 43);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(119, 32);
            this.txtPesquisar.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "=";
            // 
            // cbmFiltrar
            // 
            this.cbmFiltrar.FormattingEnabled = true;
            this.cbmFiltrar.Items.AddRange(new object[] {
            "Código",
            "Nome"});
            this.cbmFiltrar.Location = new System.Drawing.Point(122, 43);
            this.cbmFiltrar.Name = "cbmFiltrar";
            this.cbmFiltrar.Size = new System.Drawing.Size(131, 33);
            this.cbmFiltrar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtrar por:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbOrdemServicoDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(12, 416);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(523, 304);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OS:";
            // 
            // tbOrdemServicoDataGridView
            // 
            this.tbOrdemServicoDataGridView.AllowUserToAddRows = false;
            this.tbOrdemServicoDataGridView.AllowUserToDeleteRows = false;
            this.tbOrdemServicoDataGridView.AutoGenerateColumns = false;
            this.tbOrdemServicoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbOrdemServicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tbOrdemServicoDataGridView.DataSource = this.tbOrdemServicoBindingSource;
            this.tbOrdemServicoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbOrdemServicoDataGridView.Location = new System.Drawing.Point(3, 28);
            this.tbOrdemServicoDataGridView.Name = "tbOrdemServicoDataGridView";
            this.tbOrdemServicoDataGridView.ReadOnly = true;
            this.tbOrdemServicoDataGridView.RowHeadersWidth = 47;
            this.tbOrdemServicoDataGridView.Size = new System.Drawing.Size(517, 273);
            this.tbOrdemServicoDataGridView.TabIndex = 6;
            this.tbOrdemServicoDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbOrdemServicoDataGridView_MouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idOrdem";
            this.dataGridViewTextBoxColumn1.HeaderText = "Cód Ordem";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 115;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idCliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cód Cliente";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 115;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idServico";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cód Serviço";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 115;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dataDia";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data Cadastro";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 115;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "cadastradoPor";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cadastrado Por";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 115;
            // 
            // frmOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(553, 720);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbOrdemServicoBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar OS";
            this.Load += new System.EventHandler(this.frmOS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbServicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemServicoBindingNavigator)).EndInit();
            this.tbOrdemServicoBindingNavigator.ResumeLayout(false);
            this.tbOrdemServicoBindingNavigator.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdemServicoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private dbServicoDataSet dbServicoDataSet;
        private System.Windows.Forms.BindingSource tbOrdemServicoBindingSource;
        private dbServicoDataSetTableAdapters.tbOrdemServicoTableAdapter tbOrdemServicoTableAdapter;
        private dbServicoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbOrdemServicoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbOrdemServicoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idOrdemTextBox;
        private System.Windows.Forms.ComboBox idClienteComboBox;
        private System.Windows.Forms.ComboBox idServicoComboBox;
        private System.Windows.Forms.TextBox dataDiaTextBox;
        private System.Windows.Forms.TextBox cadastradoPorTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.MaskedTextBox txtPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbmFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView tbOrdemServicoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private dbServicoDataSetTableAdapters.tbClienteTableAdapter tbClienteTableAdapter;
        private System.Windows.Forms.BindingSource tbClienteBindingSource;
        private dbServicoDataSetTableAdapters.tbServicoTableAdapter tbServicoTableAdapter;
        private System.Windows.Forms.BindingSource tbServicoBindingSource;
    }
}