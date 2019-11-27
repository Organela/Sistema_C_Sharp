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
    public partial class FormFuncionarioListar : Form
    {
        public FormFuncionarioListar()
        {
            InitializeComponent();
        }

        private void FormFuncionarioListar_Load(object sender, EventArgs e)
        {
            CarregarMapaFuncionarios();
        }

       private void CarregarMapaFuncionarios()
        {
            FuncionarioController Control = new FuncionarioController();
            Funcionario Objeto = new Funcionario();
            List<Funcionario> Lista = new List<Funcionario>();

            Lista = (List<Funcionario>)Control.ExecutarOpBD('l', Objeto);


            foreach (Funcionario O in Lista)
            {
                dvgDados.Rows.Add(O.Id, O.Nome, O.Tel);
            }
        }
    }
}
