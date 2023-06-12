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
    public partial class frmLogin : Form
    {
        //Responsavel pelo nivel acesso
        public static string NivelAcesso;
        //Responsavel por mostrar quem está conectado ao sistema
        public static string usuarioConectado;
        //Definir comando de connect
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.dbServicoConnectionString);
        public frmLogin()
        {
            InitializeComponent();
        }

        private void tbUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbUsuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbServicoDataSet);

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            usuarioComboBox.SelectedIndex = -1;
            // TODO: esta linha de código carrega dados na tabela 'dbServicoDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.dbServicoDataSet.tbUsuario);
            senhaTextBox.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se os campos estão preenchidos
                if (usuarioComboBox.Text != "" || nivelAcessoComboBox.Text != "" || senhaTextBox.Text != "")
                {
 
                    // Responsável pelo comando SQL
                    SqlCommand comm = new SqlCommand("SELECT * FROM tbUsuario WHERE usuario = @usuario AND senha = @senha AND nivelAcesso = @nivel", conn);

                    // Parametrizar os códigos
                    comm.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuarioComboBox.Text;
                    comm.Parameters.Add("@senha", SqlDbType.VarChar).Value = senhaTextBox.Text;
                    comm.Parameters.Add("@nivel", SqlDbType.VarChar).Value = nivelAcessoComboBox.Text;

                    // Abre a conexão
                    conn.Open();

                    SqlDataReader reader = null;
                    // Lê as linhas de uma base de dados SQL Server
                    reader = comm.ExecuteReader();

                    // Se tiver algo para ler, faz:
                    if (reader.Read())
                    {
                        // Variáveis usuarioConectado e nivelAcesso recebem os valores dos campos correspondentes
                        usuarioConectado = usuarioComboBox.Text;
                        NivelAcesso = nivelAcessoComboBox.Text;

                        // Declara a variável que recebe o formulário frmTelaPrincipal
                        frmTelaPrincipal p = new frmTelaPrincipal();

                        // Esconde o formulário de login
                        this.Hide();

                        // Mostra o formulário frmTelaPrincipal
                        p.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuário e/ou senha incorretos", "Aviso de Segurança", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "Aviso de Segurança", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                //Finalizar tarefa
                conn.Close(); 
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Test_Click(object sender, EventArgs e)
        {
            frmUsuario usu = new frmUsuario();
            usu.Show();
        }

    }
}
