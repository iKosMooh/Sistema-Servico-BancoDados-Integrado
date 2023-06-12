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
using System.Data;

namespace SIServico
{
    public partial class frmServico : Form
    {
        SqlConnection cn = new SqlConnection(Properties.Settings.Default.dbServicoConnectionString); SqlCommand cmd = null;
        public frmServico()
        {
            InitializeComponent();
        }

        private void tbServicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.tbServicoBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.dbServicoDataSet);
            try
            {
                //Desabilita o botão excluir para quem tiver a permissão Operador
                if (frmLogin.NivelAcesso == "")
                {
                    bindingNavigatorDeleteItem.Enabled = false;
                }
                
                // Se todos os campos estiverem preenchidos, faça
                if (!string.IsNullOrEmpty(nomeTextBox.Text))
                {
                    // Mostrar a Data do Cadastro na Hora
                    if (string.IsNullOrEmpty(dataDiaTextBox.Text))
                    {
                        dataDiaTextBox.Text = DateTime.Now.ToString();
                    }

                    // Mostrar quem Cadastrou o usuário
                    if (string.IsNullOrEmpty(cadastradoPorTextBox.Text))
                    {
                        cadastradoPorTextBox.Text = frmLogin.usuarioConectado;
                    }

                    // Executar a aplicação
                    this.Validate();
                    this.tbServicoBindingSource.EndEdit();
                    this.tbServicoTableAdapter.Update(this.dbServicoDataSet.tbServico);
                    MessageBox.Show("Cadastrado realizado com sucesso");
                }
                else
                {
                    // Se algum campo não estiver preenchido
                    MessageBox.Show("O campo nome não pode ficar vazio");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmServico_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbServicoDataSet.tbServico'. Você pode movê-la ou removê-la conforme necessário.
            this.tbServicoTableAdapter.Fill(this.dbServicoDataSet.tbServico);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmFiltrar.Text == "Código")
                {
                    //Define a instrução SQL
                    string sql = "SELECT * from tbServico WHERE idServico = " + txtPesquisar.Text + "";

                    //Lê os dados da sql e conectar no cn
                    SqlCommand cmd = new SqlCommand(sql, cn);

                    //Abre conexão
                    cn.Open();

                    //Define o valor da CommandType para cmd
                    cmd.CommandType = CommandType.Text;

                    /* Representa um conjunto de comandos de dados e uma conexão de banco de dados que são
                     usados para preencher o DataSet e atualizar o banco de dados SQL Server*/
                    SqlDataAdapter da = new SqlDataAdapter(cmd);

                    //Representa uma tabela de dados na memória.
                    DataTable servico = new DataTable();

                    //Adiciona ou atualiza linhas em um DataTable para que correspondam na fonte de dados usando o DataTable.
                    da.Fill(servico);

                    // A tbUsuarioDataGridView recebe o DataTable usuario.
                    tbServicoDataGridView.DataSource = servico;
                }
                if (cbmFiltrar.Text == "Nome")
                {
                    //Define instrução SQL
                    string sql = "SELECT * FROM tbServico WHERE nome LIKE '%" + txtPesquisar + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable servico = new DataTable();
                    da.Fill(servico);
                    tbServicoDataGridView.DataSource = servico;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível salvar pelo seguinte motivo: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //Desabilita o botão excluir para quem tiver a permissão Operador
            if(frmLogin.NivelAcesso == "")
            {
                bindingNavigatorDeleteItem.Enabled = false;
            }

        }

        private void Limpar()
        {
            txtPesquisar.Clear();
            idServicoTextBox.Clear();
            nomeTextBox.Clear();
            descricaoTextBox.Clear();
            valorTextBox.Clear();
            dataDiaTextBox.Clear();
            cadastradoPorTextBox.Clear();
        }

        private void tbServicoDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Limpar();
            idServicoTextBox.Text = tbServicoDataGridView.CurrentRow.Cells[0].Value.ToString();
            nomeTextBox.Text = tbServicoDataGridView.CurrentRow.Cells[1].Value.ToString();
            descricaoTextBox.Text = tbServicoDataGridView.CurrentRow.Cells[2].Value.ToString();
            observacaoTextBox.Text = tbServicoDataGridView.CurrentRow.Cells[3].Value.ToString();
            valorTextBox.Text = tbServicoDataGridView.CurrentRow.Cells[4].Value.ToString();
            dataDiaTextBox.Text = tbServicoDataGridView.CurrentRow.Cells[5].Value.ToString();
            cadastradoPorTextBox.Text = tbServicoDataGridView.CurrentRow.Cells[6].Value.ToString();

        }
    }
}
