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
    public partial class FormFuncionarioInserirAtualizar : Form
    {
        public FormFuncionarioInserirAtualizar()
        {
            InitializeComponent();
        }

        private void Inserir_Click(object sender, EventArgs e)
        {
            FuncionarioController c = new FuncionarioController();
            Funcionario p = new Funcionario();

            p.Id = Convert.ToInt64(textBoxId.Text);
            p.Nome = textBoxNome.Text;
            p.Tel = textBoxTel.Text;

            c.ExecutarOpBD('i', p);
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            FuncionarioController c = new FuncionarioController();
            Funcionario p = new Funcionario();

            p.Id = Convert.ToInt64(textBoxId.Text);
            p.Nome = textBoxNome.Text;
            p.Tel = textBoxTel.Text;

            c.ExecutarOpBD('a', p);
        }
    }
}
