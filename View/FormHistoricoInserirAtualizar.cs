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
    public partial class FormHistoricoInserirAtualizar : Form
    {
        public FormHistoricoInserirAtualizar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void formHistoricoInserir_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            HistoricoController c = new HistoricoController();
            Historico p = new Historico();

            c.ExecutarOpBD('a', p);
        }

        private void inserir_Click(object sender, EventArgs e)
        {
            HistoricoController c = new HistoricoController();
            Historico p = new Historico();

            c.ExecutarOpBD('i', p);
        }
    }
}
