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
    public partial class FormVagaListar : Form
    {
        public FormVagaListar()
        {
            InitializeComponent();
        }

        private void FormVagaListar_Load(object sender, EventArgs e)
        {
            CarregarMapaVagas();
        }
        private void CarregarMapaVagas()
        {
            VagaController Control = new VagaController();
            Vaga Objeto = new Vaga();
            List<Vaga> Lista = new List<Vaga>();

            Lista = (List<Vaga>)Control.ExecutarOpBD('l', Objeto);


            foreach (Vaga O in Lista)
            {
                dvgDados.Rows.Add(O.Id, O.Status);
            }
        }
    }
}
