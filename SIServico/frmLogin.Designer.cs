namespace SIServico
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nivelAcessoLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label usuarioLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.dbServicoDataSet = new SIServico.dbServicoDataSet();
            this.tbUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbUsuarioTableAdapter = new SIServico.dbServicoDataSetTableAdapters.tbUsuarioTableAdapter();
            this.tableAdapterManager = new SIServico.dbServicoDataSetTableAdapters.TableAdapterManager();
            this.nivelAcessoComboBox = new System.Windows.Forms.ComboBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.usuarioComboBox = new System.Windows.Forms.ComboBox();
            nivelAcessoLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            usuarioLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbServicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nivelAcessoLabel
            // 
            nivelAcessoLabel.AutoSize = true;
            nivelAcessoLabel.BackColor = System.Drawing.Color.Transparent;
            nivelAcessoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            nivelAcessoLabel.ForeColor = System.Drawing.Color.White;
            nivelAcessoLabel.Location = new System.Drawing.Point(66, 93);
            nivelAcessoLabel.Name = "nivelAcessoLabel";
            nivelAcessoLabel.Size = new System.Drawing.Size(147, 28);
            nivelAcessoLabel.TabIndex = 3;
            nivelAcessoLabel.Text = "Nivel Acesso:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.BackColor = System.Drawing.Color.Transparent;
            senhaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            senhaLabel.ForeColor = System.Drawing.Color.White;
            senhaLabel.Location = new System.Drawing.Point(130, 131);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(83, 28);
            senhaLabel.TabIndex = 5;
            senhaLabel.Text = "Senha:";
            // 
            // usuarioLabel1
            // 
            usuarioLabel1.AutoSize = true;
            usuarioLabel1.BackColor = System.Drawing.Color.Transparent;
            usuarioLabel1.ForeColor = System.Drawing.Color.White;
            usuarioLabel1.Location = new System.Drawing.Point(120, 56);
            usuarioLabel1.Name = "usuarioLabel1";
            usuarioLabel1.Size = new System.Drawing.Size(93, 26);
            usuarioLabel1.TabIndex = 9;
            usuarioLabel1.Text = "Usuario:";
            // 
            // dbServicoDataSet
            // 
            this.dbServicoDataSet.DataSetName = "dbServicoDataSet";
            this.dbServicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbUsuarioBindingSource
            // 
            this.tbUsuarioBindingSource.DataMember = "tbUsuario";
            this.tbUsuarioBindingSource.DataSource = this.dbServicoDataSet;
            // 
            // tbUsuarioTableAdapter
            // 
            this.tbUsuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbClienteTableAdapter = null;
            this.tableAdapterManager.tbOrdemServicoTableAdapter = null;
            this.tableAdapterManager.tbServicoTableAdapter = null;
            this.tableAdapterManager.tbUsuarioTableAdapter = this.tbUsuarioTableAdapter;
            this.tableAdapterManager.UpdateOrder = SIServico.dbServicoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nivelAcessoComboBox
            // 
            this.nivelAcessoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "nivelAcesso", true));
            this.nivelAcessoComboBox.FormattingEnabled = true;
            this.nivelAcessoComboBox.Items.AddRange(new object[] {
            "",
            "Administrador",
            "Operador"});
            this.nivelAcessoComboBox.Location = new System.Drawing.Point(254, 88);
            this.nivelAcessoComboBox.Name = "nivelAcessoComboBox";
            this.nivelAcessoComboBox.Size = new System.Drawing.Size(207, 33);
            this.nivelAcessoComboBox.TabIndex = 4;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "senha", true));
            this.senhaTextBox.Location = new System.Drawing.Point(254, 127);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.PasswordChar = '*';
            this.senhaTextBox.Size = new System.Drawing.Size(207, 32);
            this.senhaTextBox.TabIndex = 6;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(380, 168);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(81, 34);
            this.btnEntrar.TabIndex = 7;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(254, 168);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(81, 34);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // usuarioComboBox
            // 
            this.usuarioComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbUsuarioBindingSource, "usuario", true));
            this.usuarioComboBox.DataSource = this.tbUsuarioBindingSource;
            this.usuarioComboBox.DisplayMember = "usuario";
            this.usuarioComboBox.FormattingEnabled = true;
            this.usuarioComboBox.Location = new System.Drawing.Point(254, 49);
            this.usuarioComboBox.Name = "usuarioComboBox";
            this.usuarioComboBox.Size = new System.Drawing.Size(207, 33);
            this.usuarioComboBox.TabIndex = 10;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(577, 252);
            this.Controls.Add(usuarioLabel1);
            this.Controls.Add(this.usuarioComboBox);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(senhaLabel);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(nivelAcessoLabel);
            this.Controls.Add(this.nivelAcessoComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbServicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbServicoDataSet dbServicoDataSet;
        private System.Windows.Forms.BindingSource tbUsuarioBindingSource;
        private dbServicoDataSetTableAdapters.tbUsuarioTableAdapter tbUsuarioTableAdapter;
        private dbServicoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox nivelAcessoComboBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox usuarioComboBox;
    }
}

