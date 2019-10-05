using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Historico
    {
        public DateTime data { get; set; }
        public Double preco { get; set; }
        


        public List<Carro> carro { get; set; }
        public List<Vaga> vaga { get; set; }
        public List<Funcionario> funcionario { get; set; }
    }
}
