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
    public partial class FormCarroListar : Form
    {
        public FormCarroListar()
        {
            InitializeComponent();
        }

        private void dvgDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormCarroListar_Load(object sender, EventArgs e)
        {
            CarregarMapaCarros();
        }

        private void CarregarMapaCarros()
        {
            CarroController Control = new CarroController();
            Carro Objeto = new Carro();
            List<Carro> Lista = new List<Carro>();

            Lista = (List<Carro>)Control.ExecutarOpBD('l', Objeto);


            foreach (Carro O in Lista)
            {
                dvgDados.Rows.Add(O.Id, O.Placa, O.Nome, O.Cliente);
            }
        }

    }
}
