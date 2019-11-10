using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Historico
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public Double Preco { get; set; }
        
        public Carro Carro { get; set; }
        public Vaga Vaga { get; set; }
        public Funcionario Funcionario { get; set; }

        public Historico()
        {
            this.Carro = new Carro();
            this.Vaga = new Vaga();
            this.Funcionario = new Funcionario();
        }
        

        /*
        public List<Carro> Carro { get; set; }
        public List<Vaga> Vaga { get; set; }
        public List<Funcionario> Funcionario { get; set; }

        public Historico()
        {
            this.Carro = new List<Carro>();
            this.Vaga = new List<Vaga>();
            this.Funcionario = new List<Funcionario>();
        }
         */
    }
}
