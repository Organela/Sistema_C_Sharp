using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Dao;

namespace Control
{
    class CarroController
    {
        public Object ExecutarOpBD(char _c, Carro _o)
        {
            try
            {
                CarroDAO dao = new CarroDAO();
                switch (_c)
                {
                    case 'i':
                        return dao.InserirBD(_o);
                    case 'd':
                        return dao.DeletarBD(_o.Id);
                    case 'a':
                        return dao.AlterarBD(_o);
                    case 't':
                        return dao.ListarTodos(_o.Id);
                    case 'o':
                        return dao.BuscarPorID(_o.Id);
                    default:
                        return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
