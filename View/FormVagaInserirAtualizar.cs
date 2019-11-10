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
    public partial class FormVagaInserirAtualizar : Form
    {
        public FormVagaInserirAtualizar()
        {
            InitializeComponent();
        }

        private void Inserir_Click(object sender, EventArgs e)
        {
            VagaController c = new VagaController();
            Vaga p = new Vaga();

            c.ExecutarOpBD('i', p);
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            VagaController c = new VagaController();
            Vaga p = new Vaga();

            c.ExecutarOpBD('a', p);
        }
    }
}
