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
    public partial class FormClienteListar : Form
    {
        public FormClienteListar()
        {
            InitializeComponent();
        }

        private void dvgDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormClienteListar_Load(object sender, EventArgs e)
        {
            CarregarMapaClientes();
        }

        private void CarregarMapaClientes()
        {
           

            ClienteController Control = new ClienteController();
            Cliente Objeto = new Cliente();
            List<Cliente> Lista = new List<Cliente>();

            Lista =(List<Cliente>)Control.ExecutarOpBD('l', Objeto);


            foreach (Cliente O  in Lista)
            {
                dvgDados.Rows.Add(O.Id, O.Nome, O.Tel);
            }
        }
    }
}
