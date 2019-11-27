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
    public partial class FormHistoricoListar : Form
    {
        public FormHistoricoListar()
        {
            InitializeComponent();
        }
        private void frmListarHistorico_Load(object sender, EventArgs e)
        {
            CarregarMapaHistorico();
        }

        private void CarregarMapaHistorico()
        {
            Dictionary<Int64, Historico> mapaHistorico = (Dictionary<Int64, Historico>)this.Tag;
            foreach (Historico h in mapaHistorico.Values)
            {
                dgvDados.Rows.Add(h.DataInicio, h.DataFim, h.Preco, h.Carro, h.Vaga, h.Funcionario);
            }
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)/*dvgDados é o name do método*/
        {
            try
            {
                Int64 idHistorico = Convert.ToInt64(dgvDados.SelectedRows[0].Cells[0].Value);

                Dictionary<Int64, Historico> mapaHistorico = (Dictionary<Int64, Historico>)this.Tag;

                Historico p = mapaHistorico[idHistorico];

                FormHistoricoInserirAtualizar form = new FormHistoricoInserirAtualizar();

                form.Tag = p;

                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO SELECIONAR LINHA: " + ex.Message);
            }
        }

        private void FormHistoricoListar_Load(object sender, EventArgs e)
        {
            CarregarMapaHistoricos();
        }

        private void CarregarMapaHistoricos()
        {


            HistoricoController Control = new HistoricoController();
            Historico Objeto = new Historico();
            List<Historico> Lista = new List<Historico>();

            Lista = (List<Historico>)Control.ExecutarOpBD('l', Objeto);


            foreach (Historico O in Lista)
            {
                dvgDados.Rows.Add(O.DataInicio, O.Preco, O.Carro, O.Vaga, O.Funcionario);
            }
        }
    }
}
