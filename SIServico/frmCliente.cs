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
using System.Runtime.InteropServices;

namespace SIServico
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(Properties.Settings.Default.dbServicoConnectionString);
        SqlCommand cmd = null;

        private void tbClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbServicoDataSet);

        }

        private void tbClienteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Desabilita o botão excluir para quem tiver nível de acesso Operador
                if (frmLogin.NivelAcesso == "Operador")
                {
                    bindingNavigatorDeleteItem.Enabled = false;
                }

                // Verifica se o campo nome e CPF estão preenchidos
                if (nomeTextBox.Text == "" || cpfMaskedTextBox.Text == "")
                {
                    MessageBox.Show("O campo 'Nome' e 'CPF' não podem ficar vazios", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Verifica se o CPF é válido
                    if (!cpf.ValidarCPF(cpfMaskedTextBox.Text))
                    {
                        MessageBox.Show("CPF incorreto", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Atualiza a data de cadastro para a data atual
                        dataDiaTextBox.Text = DateTime.Now.ToString();

                        // Define o usuário que realizou o cadastro como o usuário conectado
                        cadastradoPorTextBox.Text = frmLogin.usuarioConectado;

                        // Valida os dados e salva no banco de dados
                        this.Validate();
                        this.tbClienteBindingSource.EndEdit();
                        this.tbClienteTableAdapter.Update(this.dbServicoDataSet.tbCliente);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LimparCampos()
        {
            idClienteTextBox.Clear();
            nomeTextBox.Clear();
            cpfMaskedTextBox.Clear();
            telefoneTextBox.Clear();
            cepTextBox.Clear();
            logradouroTextBox.Clear();
            numeroTextBox.Clear();
            bairroTextBox.Clear();
            cidadeTextBox.Clear();
            estadoTextBox.Clear();
            dataDiaTextBox.Clear();
            emailTextBox.Clear();
            cadastradoPorTextBox.Clear();
        }


        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dbServicoDataSet.tbOrdemServico'. Você pode movê-la ou removê-la conforme necessário.
            this.tbOrdemServicoTableAdapter.Fill(this.dbServicoDataSet.tbOrdemServico);
            // TODO: esta linha de código carrega dados na tabela 'dbServicoDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.dbServicoDataSet.tbCliente);

        }

        private void txtFiltrar_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                // Criar um objeto SqlDataAdapter e DataTable
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable cliente = new DataTable();

                // Preencher o DataTable com os dados do SqlDataAdapter
                da.Fill(cliente);

                // Definir o DataTable como a origem de dados do DataGridView
                tbClienteDataGridView.DataSource = cliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Certificar-se de fechar a conexão no bloco finally
                cn.Close();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmFiltrar1.Text == "Código")
            {
                txtFiltrar.Mask = "";
            }

            if (cbmFiltrar1.Text == "Nome")
            {
                txtFiltrar.Mask = "";
                txtFiltrar.Mask = "";
            }

            if (cbmFiltrar1.Text == "CPF")
            {
                txtFiltrar.Mask = "000,000,000-00";
            }

            if (cbmFiltrar1.Text == "")
            {
                txtFiltrar.Mask = "";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                // Define a instrução SQL
                string sql = "SELECT * FROM tbOrdemServico WHERE idCliente = '" + idClienteTextBox.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, cn);

                cn.Open();

                cmd.CommandType = CommandType.Text;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable os = new DataTable();

                da.Fill(os);

                tbOrdemServicoDataGridView.DataSource = os;
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
            if (frmLogin.NivelAcesso == "Operador")
            {
                bindingNavigatorDeleteItem.Enabled = false;
            }
        }

        private void tbClienteDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LimparCampos();
            idClienteTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[0].Value.ToString();
            nomeTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[1].Value.ToString();
            cpfMaskedTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[2].Value.ToString();
            telefoneTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[3].Value.ToString();
            logradouroTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[4].Value.ToString();
            numeroTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[5].Value.ToString();
            bairroTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[6].Value.ToString();
            cidadeTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[7].Value.ToString();
            cepTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[8].Value.ToString();
            estadoTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[9].Value.ToString();
            dataDiaTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[10].Value.ToString();
            emailTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[11].Value.ToString();
            cadastradoPorTextBox.Text = tbClienteDataGridView.CurrentRow.Cells[12].Value.ToString();
        }
    }
}
