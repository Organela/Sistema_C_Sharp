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
    public partial class FormVagaDeletarBuscar : Form
    {
        public FormVagaDeletarBuscar()
        {
            InitializeComponent();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            VagaController c = new VagaController();
            Vaga p = new Vaga();

            c.ExecutarOpBD('b', p);
        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            VagaController c = new VagaController();
            Vaga p = new Vaga();

            c.ExecutarOpBD('d', p);
        }
    }
}
