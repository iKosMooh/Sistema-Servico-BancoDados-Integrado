using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SIServico
{
    public partial class frmOS : Form
    {
        public frmOS()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(Properties.Settings.Default.dbServicoConnectionString);

        private void tbOrdemServicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbOrdemServicoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbServicoDataSet);

        }

        private void frmOS_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbServicoDataSet.tbServico'. Você pode movê-la ou removê-la conforme necessário.
            this.tbServicoTableAdapter.Fill(this.dbServicoDataSet.tbServico);
            // TODO: esta linha de código carrega dados na tabela 'dbServicoDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.dbServicoDataSet.tbCliente);
            // TODO: esta linha de código carrega dados na tabela 'dbServicoDataSet.tbOrdemServico'. Você pode movê-la ou removê-la conforme necessário.
            this.tbOrdemServicoTableAdapter.Fill(this.dbServicoDataSet.tbOrdemServico);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmFiltrar.Text == "Codigo OS")
                {
                    // Define a instrução SQL
                    string sql = "SELECT * FROM tbOrdemServico WHERE idOrdem = " + txtPesquisar.Text + "";
                    SqlCommand cmd = new SqlCommand(sql, cn);

                    // Abre a conexão
                    cn.Open();

                    // Define o valor da CommandType para cmd
                    cmd.CommandType = CommandType.Text;

                    /* Representa um conjunto de comandos de dados e uma conexão de banco de dados
                    que são usados para preencher o DataSet e atualizar um banco de dados SQL Server. */
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    // Representa uma tabela de dados na memória.
                    DataTable os = new DataTable();

                    // Adiciona ou atualiza linhas em um DataTable para que correspondam na fonte de dados usando o DataTable.
                    da.Fill(os);

                    // thOrdemServicoDataGridView recebe o DataTable os.
                    tbOrdemServicoDataGridView.DataSource = os;

                    // Fechar a conexão
                    cn.Close();
                }

                if (cbmFiltrar.Text == "Codigo Cliente")
                {
                    // Define a instrução SQL
                    string sql = "SELECT * FROM tbOrdemServico WHERE idCliente = " + txtPesquisar.Text + "";
                    SqlCommand cmd = new SqlCommand(sql, cn);

                    // Abre a conexão
                    cn.Open();

                    cmd.CommandType = CommandType.Text;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataTable os = new DataTable();

                    da.Fill(os);

                    tbOrdemServicoDataGridView.DataSource = os;

                    // Fechar a conexão
                    cn.Close();
                }

                if (cbmFiltrar.Text == "Codigo Servico")
                {
                    // Define a instrução SQL
                    string sql = "SELECT * FROM tbOrdemServico WHERE idServico = " + txtPesquisar.Text + "";
                    SqlCommand cmd = new SqlCommand(sql, cn);

                    // Abre a conexão
                    cn.Open();

                    cmd.CommandType = CommandType.Text;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    DataTable os = new DataTable();

                    da.Fill(os);

                    tbOrdemServicoDataGridView.DataSource = os;

                    // Fechar a conexão
                    cn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Desabilita o botão excluir para quem tiver nível de acesso "Operador"
                if (frmLogin.NivelAcesso == "Operador")
                {
                    bindingNavigatorDeleteItem.Enabled = false;
                }

                // Verifica se os campos obrigatórios estão preenchidos
                if (!string.IsNullOrEmpty(idClienteComboBox.Text) && !string.IsNullOrEmpty(idServicoComboBox.Text))
                {
                    if (string.IsNullOrEmpty(dataDiaTextBox.Text))
                    {
                        dataDiaTextBox.Text = DateTime.Now.ToString();
                    }

                    if (string.IsNullOrEmpty(cadastradoPorTextBox.Text))
                    {
                        cadastradoPorTextBox.Text = frmLogin.usuarioConectado;
                    }

                    this.Validate();
                    this.tbOrdemServicoBindingSource.EndEdit();
                    this.tbOrdemServicoTableAdapter.Update(this.dbServicoDataSet.tbOrdemServico);

                    MessageBox.Show("Cadastro realizado com sucesso");
                }
                else
                {
                    MessageBox.Show("Todos os campos são obrigatórios");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        private void LimparCampo()
        {
            idOrdemTextBox.Clear();
            idClienteComboBox.SelectedIndex = -1;
            idServicoComboBox.SelectedIndex = -1;
            dataDiaTextBox.Clear();
            cadastradoPorTextBox.Clear();
        }

        private void tbOrdemServicoDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LimparCampo();

            idOrdemTextBox.Text = tbOrdemServicoDataGridView.CurrentRow.Cells[0].Value.ToString();
            idClienteComboBox.Text = tbOrdemServicoDataGridView.CurrentRow.Cells[1].Value.ToString();
            idServicoComboBox.Text = tbOrdemServicoDataGridView.CurrentRow.Cells[2].Value.ToString();
            dataDiaTextBox.Text = tbOrdemServicoDataGridView.CurrentRow.Cells[3].Value.ToString();
            cadastradoPorTextBox.Text = tbOrdemServicoDataGridView.CurrentRow.Cells[4].Value.ToString();    
        }
    }
}
