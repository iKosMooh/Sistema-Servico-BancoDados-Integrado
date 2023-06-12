using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIServico
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void frmTelaPrincipal_Load(object sender, EventArgs e)
        {
            // Nível de Acesso: Se o usuário for Operador, o formulário estará invisível
            if (frmLogin.NivelAcesso == "Operador")
            {
                //Nivel de Operador nao podera cadastrar usudrio
                tsslUsuario.Visible = false;
            }

            // Mostrar o número de usuários conectados
            tsslUsuario.Text = "Usuário: " + frmLogin.usuarioConectado;

            // Mostrar o nome do PC
            string myHost = System.Net.Dns.GetHostName();
            tsslNomePC.Text = "Nome do PC: " + myHost;

            // Mostrar o IP do usuário
            System.Net.IPHostEntry myIPs = System.Net.Dns.GetHostEntry(myHost);

            foreach (System.Net.IPAddress myIP in myIPs.AddressList)
            {
                // Mostrar o IP
                tsslIP.Text = "IP: " + myIP;
            }

            // Nível de Operador não poderá cadastrar usuário
            usuárioToolStripMenuItem.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslHora.Text = DateTime.Now.ToString("HH:mm:ss");
            tsslData.Text = DateTime.Now.ToString("d");
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
            frmUsuario usuario = null; // form a ser aberto
                                       // procura form na lista de forms filhos
            foreach (Form frm in this.MdiChildren)
            {
                // se encontrou, inicializa uma instância de frmUsuario com o form já aberto
                if (frm is frmUsuario)
                {
                    usuario = (frmUsuario)frm;
                    break;
                }
            }

            // se não encontrou na lista, instancia o objeto, define o form pai e exibe o form
            if (usuario == null)
            {
                usuario = new frmUsuario();
                usuario.MdiParent = this;
                usuario.Show();
            }

            // garante que ele fique em foco caso haja outros forms abertos
            usuario.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmCliente cliente = null; // form a ser aberto
                                           // procura form na lista de forms filhos
                foreach (Form frm in this.MdiChildren)
                {
                    // se encontrou, inicializa uma instância de frmUsuario com o form já aberto
                    if (frm is frmCliente)
                    {
                        cliente = (frmCliente)frm;
                        break;
                    }
                }

                // se não encontrou na lista, instancia o objeto, define o form pai e exibe o form
                if (cliente == null)
                {
                    cliente = new frmCliente();
                    cliente.MdiParent = this;
                    cliente.Show();
                }

                // garante que ele fique em foco caso haja outros forms abertos
                cliente.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmServico servico = null; // form a ser aberto
                                           // procura form na lista de forms filhos
                foreach (Form frm in this.MdiChildren)
                {
                    // se encontrou, inicializa uma instância de frmUsuario com o form já aberto
                    if (frm is frmServico)
                    {
                        servico = (frmServico)frm;
                        break;
                    }
                }

                // se não encontrou na lista, instancia o objeto, define o form pai e exibe o form
                if (servico == null)
                {
                    servico = new frmServico();
                    servico.MdiParent = this;
                    servico.Show();
                }

                // garante que ele fique em foco caso haja outros forms abertos
                servico.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void ordemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmOS OS = null; // form a ser aberto
                                           // procura form na lista de forms filhos
                foreach (Form frm in this.MdiChildren)
                {
                    // se encontrou, inicializa uma instância de frmUsuario com o form já aberto
                    if (frm is frmOS)
                    {
                        OS = (frmOS)frm;
                        break;
                    }
                }

                // se não encontrou na lista, instancia o objeto, define o form pai e exibe o form
                if (OS == null)
                {
                    OS = new frmOS();
                    OS.MdiParent = this;
                    OS.Show();
                }

                // garante que ele fique em foco caso haja outros forms abertos
                OS.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmRelatCliente relatCliente = null; // form a ser aberto
                                 // procura form na lista de forms filhos
                foreach (Form frm in this.MdiChildren)
                {
                    // se encontrou, inicializa uma instância de frmUsuario com o form já aberto
                    if (frm is frmRelatCliente)
                    {
                        relatCliente = (frmRelatCliente)frm;
                        break;
                    }
                }

                // se não encontrou na lista, instancia o objeto, define o form pai e exibe o form
                if (relatCliente == null)
                {
                    relatCliente = new frmRelatCliente();
                    relatCliente.MdiParent = this;
                    relatCliente.Show();
                }

                // garante que ele fique em foco caso haja outros forms abertos
                relatCliente.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void serviçoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmRelatOS relatOS = null; // form a ser aberto
                                                     // procura form na lista de forms filhos
                foreach (Form frm in this.MdiChildren)
                {
                    // se encontrou, inicializa uma instância de frmUsuario com o form já aberto
                    if (frm is frmRelatOS)
                    {
                        relatOS = (frmRelatOS)frm;
                        break;
                    }
                }

                // se não encontrou na lista, instancia o objeto, define o form pai e exibe o form
                if (relatOS == null)
                {
                    relatOS = new frmRelatOS();
                    relatOS.MdiParent = this;
                    relatOS.Show();
                }

                // garante que ele fique em foco caso haja outros forms abertos
                relatOS.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void ordemDeServiçoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmRelatServico relatServico = null; // form a ser aberto
                                           // procura form na lista de forms filhos
                foreach (Form frm in this.MdiChildren)
                {
                    // se encontrou, inicializa uma instância de frmUsuario com o form já aberto
                    if (frm is frmRelatServico)
                    {
                        relatServico = (frmRelatServico)frm;
                        break;
                    }
                }

                // se não encontrou na lista, instancia o objeto, define o form pai e exibe o form
                if (relatServico == null)
                {
                    relatServico = new frmRelatServico();
                    relatServico.MdiParent = this;
                    relatServico.Show();
                }

                // garante que ele fique em foco caso haja outros forms abertos
                relatServico.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível conectar ao formulário devido ao erro: " + ex.Message,
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void tsbLogoff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmTelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
