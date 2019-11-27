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
    public partial class FormHistoricoDeletarBuscar : Form
    {
        public FormHistoricoDeletarBuscar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            HistoricoController c = new HistoricoController();
            Historico p = new Historico();

            p.DataInicio = Convert.ToDateTime(Deletar.Text);

            c.ExecutarOpBD('d', p);
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            HistoricoController c = new HistoricoController();
            Historico p = new Historico();

            p.DataInicio = Convert.ToDateTime(Deletar.Text);

            c.ExecutarOpBD('b', p);
        }
    }
}
