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
                dgvDados.Rows.Add(h.data, h.preco, h.carro, h.vaga, h.funcionario);
            }
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)/*dvgDados é o name do método*/
        {   try
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
    }
}
