﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Carro
    {
        public Int64 Id { get; set; }

        public String Placa { get; set; }

        public String Nome { get; set; }
        
        public Cliente Cliente { get; set; }
        
        public Carro()
        {
            this.Cliente = new Cliente();
        }




    }
}
