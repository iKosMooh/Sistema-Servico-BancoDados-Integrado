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
    public partial class frmUsuario : Form
    {
        SqlConnection cn = new SqlConnection(Properties.Settings.Default.dbServicoConnectionString);
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void tbUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbUsuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbServicoDataSet);

        }

        private void tbUsuarioBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            //this.Validate();
            //this.tbUsuarioBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.dbServicoDataSet);
            try
            {
                // Se os campos estiverem preenchidos, faça
                if (txtUsuario.Text != "" && cbNivelAcesso.Text != "" && txtSenha.Text != "")
                {
                    // Se as senhas forem iguais, faça
                    if (txtSenha.Text == txtRepitaSenha.Text)
                    {
                        // Mostrar a data do cadastro na hora
                        if (txtDataCadastro.Text == "")
                        {
                            txtDataCadastro.Text = DateTime.Now.ToString();
                        }

                        // Mostrar quem cadastrou o usuário
                        if (txtCadastradoPor.Text == "")
                        {
                            txtCadastradoPor.Text = frmLogin.usuarioConectado;
                        }

                        // Executar a aplicação
                        this.Validate();
                        this.tbUsuarioBindingSource.EndEdit();
                        MessageBox.Show("Cadastro realizado com sucesso!");
                        this.tbUsuarioTableAdapter.Update(this.dbServicoDataSet.tbUsuario);
                    }
                    else
                    {
                        // Caso as senhas sejam diferentes
                        MessageBox.Show("As senhas estão diferentes!");
                    }
                }
                else
                {
                    // Se os campos não estiverem preenchidos
                    MessageBox.Show("Todos os campos devem ser preenchidos!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Limpar()
        {
            txtCadastradoPor.Clear();
            txtCodigo.Clear();
            txtDataCadastro.Clear();
            txtSenha.Clear();
            txtRepitaSenha.Clear();
            txtPesquisar.Clear();
            txtUsuario.Clear();
            cbmFiltrar.Items.Clear();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbServicoDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.dbServicoDataSet.tbUsuario);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbmFiltrar.Text == "Código")
                {
                    //Define a instrução SQL
                    string sql = "SELECT * from tbUsuario WHERE idUsuario = " + txtPesquisar.Text + "";

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
                    DataTable usuario = new DataTable();

                    //Adiciona ou atualiza linhas em um DataTable para que correspondam na fonte de dados usando o DataTable.
                    da.Fill(usuario);

                    // A tbUsuarioDataGridView recebe o DataTable usuario.
                    tbUsuarioDataGridView.DataSource = usuario;
                }
                if(cbmFiltrar.Text == "Usuário")
                {
                    //Define instrução SQL
                    string sql = "SELECT * FROM tbUsuario WHERE usuario LIKE '%" + txtPesquisar + "%'";
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cn.Open();
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable usuario = new DataTable();
                    da.Fill(usuario);
                    tbUsuarioDataGridView.DataSource = usuario;
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

        private void tbUsuarioDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Limpar();
            txtCodigo.Text = tbUsuarioDataGridView.CurrentRow.Cells[0].Value.ToString();
            txtUsuario.Text = tbUsuarioDataGridView.CurrentRow.Cells[1].Value.ToString();
            txtSenha.Text = tbUsuarioDataGridView.CurrentRow.Cells[2].Value.ToString();
            txtRepitaSenha.Text = tbUsuarioDataGridView.CurrentRow.Cells[3].Value.ToString();
            cbNivelAcesso.Text = tbUsuarioDataGridView.CurrentRow.Cells[4].Value.ToString();
            txtDataCadastro.Text = tbUsuarioDataGridView.CurrentRow.Cells[5].Value.ToString();
            txtCadastradoPor.Text = tbUsuarioDataGridView.CurrentRow.Cells[6].Value.ToString();

        }
    }
}
