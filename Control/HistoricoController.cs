using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Dao;
namespace Control
{
    public class HistoricoController
    {
        public Object ExecutarOpBD(char _c, Historico _o)
        {
            try
            {
                HistoricoDAO dao = new HistoricoDAO();
                switch (_c)
                {
                    case 'i':
                        return dao.InserirBD(_o);
                    case 'd':
                        return dao.DeletarBD(_o.DataInicio);
                    case 'a':
                        return dao.AlterarBD(_o);
                    case 'l':
                        return dao.ListarTodos(_o.DataInicio);
                    case 'b':
                        return dao.BuscarPorID(_o.DataInicio);

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
