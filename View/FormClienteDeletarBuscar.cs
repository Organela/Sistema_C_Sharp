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
    public partial class FormClienteDeletarBuscar : Form
    {
        public FormClienteDeletarBuscar()
        {
            InitializeComponent();
        }

        private void deletar_Click(object sender, EventArgs e)
        {

            ClienteController c = new ClienteController();
            Cliente p = new Cliente();

            c.ExecutarOpBD('d', p);
        }

        private void buscar_Click(object sender, EventArgs e)
        {

            ClienteController c = new ClienteController();
            Cliente p = new Cliente();

            c.ExecutarOpBD('b', p);
        }
    }
}
