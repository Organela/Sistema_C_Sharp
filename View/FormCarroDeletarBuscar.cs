using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control;
using Model;

namespace View
{
    public partial class FormCarroDeletarBuscar : Form
    {
        public FormCarroDeletarBuscar()
        {
            InitializeComponent();
        }

        private void id_Click(object sender, EventArgs e)
        {

        }

        private void deletar_Click(object sender, EventArgs e)
        {
            CarroController c = new CarroController();
            Carro p = new Carro();

            c.ExecutarOpBD('d', p);
            
            
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            CarroController c = new CarroController();
            Carro p = new Carro();

            c.ExecutarOpBD('b', p);
        }
    }
}
