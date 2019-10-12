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

namespace View
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            try
            {
                Funcionario user = new Funcionario();

                user.nome = textLogin.Text;
                user.id = textSenha.Text;

                //UsuarioCtrl controlUser = new UsuarioCtrl();
                //controlUser.ValidarUsuario(user)
                if (ValidarUsuario(user))
                {
                    this.Tag = user;
                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                    FormPrincipal form = new FormPrincipal();
                    form.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Usuario ou Senha invalidos");
                    /*lblMsg.Text = "Usuário ou Senha inválidos!!!";*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        private bool ValidarUsuario(Funcionario user)
        {
            try
            {
                if (user.nome == "t" && user.id == "t")/*nome = login --- id = senha*/
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
            return false;
        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            String login = textLogin.Text;
            textLogin.Items.Add(login);

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void textLogin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
