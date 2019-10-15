using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Control;

namespace View
{
    public partial class FormPrincipal : Form
    {
        /*private Dictionary<Int64, Funcionario> mapaFuncionarios;*/

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.Hide();

            FormLogin form = new FormLogin();

            if (form.ShowDialog() != DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                this.Show();

                Funcionario user = (Funcionario)form.Tag;

                sUser.Text = " | Usuário " + user.nome;

                tmHora.Enabled = true;

                /*CarregarListaFuncionario();*/
            }
        }
       /* private void CarregarListaFuncionario(){
            
            try
            {
                FuncionarioCrtl control = new FuncionarioCrtl();

                mapaFuncionarios = control.ListarFuncionarioDoArquivo();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR LISTA DE FUNCIONARIO: " + ex.Message);
            }
            
        }  */ 
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void carroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vagaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*FormFuncionarioListar form = new FormFuncionarioListar();

            form.Tag = mapaFuncionarios;

            form.ShowDialog();*/
        }

        private void historicoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deletarBuscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClienteDeletarBuscar form =  new FormClienteDeletarBuscar();
            form.ShowDialog();
        }

        private void inserirAtualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClienteInserirAtualizar form = new FormClienteInserirAtualizar();
            form.ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClienteListar form = new FormClienteListar();
            form.ShowDialog();
        }

        private void deletarBuscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCarroDeletarBuscar form = new FormCarroDeletarBuscar();
            form.ShowDialog();
        }

        private void inserirAtualizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCarroInserirAtualizar form = new FormCarroInserirAtualizar();
            form.ShowDialog();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCarroListar form = new FormCarroListar();
            form.ShowDialog();
        }

        private void deletarBuscarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormVagaDeletarBuscar form = new FormVagaDeletarBuscar();
            form.ShowDialog();
        }

        private void inserirAtualizarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormVagaInserirAtualizar form = new FormVagaInserirAtualizar();
            form.ShowDialog();
        }

        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormVagaListar form = new FormVagaListar();
            form.ShowDialog();
        }

        private void deletarBuscarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormFuncionarioDeletarBuscar form = new FormFuncionarioDeletarBuscar();
            form.ShowDialog();
        }

        private void inserirAtualizarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormFuncionarioInserirAtulizar form = new FormFuncionarioInserirAtulizar();
            form.ShowDialog();
        }

        private void listarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormFuncionarioListar form = new FormFuncionarioListar();
            form.ShowDialog();
        }

        private void deletarBuscarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FormHistoricoDeletarBuscar form = new FormHistoricoDeletarBuscar();
            form.ShowDialog();
        }

        private void inserirAtualizarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FormHistoricoInserirAtualizar form = new FormHistoricoInserirAtualizar();
            form.ShowDialog();
        }

        private void listarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FormHistoricoListar form = new FormHistoricoListar();
            form.ShowDialog();
        }

        private void sUser_Click(object sender, EventArgs e)
        {

        }

        private void itsLabelHora_Click(object sender, EventArgs e)
        {

        }

        private void tmHora_Tick(object sender, EventArgs e)
        {
            itsLabelHora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
