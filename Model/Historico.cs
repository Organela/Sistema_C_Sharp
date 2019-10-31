using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Historico
    {
        public DateTime Data { get; set; }
        public Double Preco { get; set; }
        


        public List<Carro> Carro { get; set; }
        public List<Vaga> Vaga { get; set; }
        public List<Funcionario> Funcionario { get; set; }
    }
}
