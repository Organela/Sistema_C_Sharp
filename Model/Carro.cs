using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Carro
    {
        public Int64 id { get; set; }

        public String placa { get; set; }

        public String nome { get; set; }

        public List<Cliente> cliente { get; set; }

    }
}
