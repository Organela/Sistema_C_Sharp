﻿using System;
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
    public partial class FormClienteInserirAtualizar : Form
    {
        public FormClienteInserirAtualizar()
        {
            InitializeComponent();
        }

        private void Inserir_Click(object sender, EventArgs e)
        {

            ClienteController c = new ClienteController();
            Cliente p = new Cliente();

            c.ExecutarOpBD('i', p);
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {

            ClienteController c = new ClienteController();
            Cliente p = new Cliente();

            c.ExecutarOpBD('a', p);
        }
    }
}
