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
    public partial class FormCarroInserirAtualizar : Form
    {
        public FormCarroInserirAtualizar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Inserir_Click(object sender, EventArgs e)
        {
            CarroController c = new CarroController();
            Carro p = new Carro();

            p.Id =Convert.ToInt64(textBoxId.Text);
            p.Nome = textBoxNome.Text;
            //p.Carro =textBoxCliente.Text;
            
            c.ExecutarOpBD('i', p);
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {

            CarroController c = new CarroController();
            Carro p = new Carro();

            p.Id = Convert.ToInt64(textBoxId.Text);
            p.Nome = textBoxNome.Text;
            //p.Carro =textBoxCliente.Text;

            c.ExecutarOpBD('a', p);
        }
    }
}
