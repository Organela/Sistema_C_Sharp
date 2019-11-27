using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao;
using Model;


namespace Control
{
    public class ClienteController
    {
        public Object ExecutarOpBD(char _c, Cliente _o)
        {   
            try
            {
                ClienteDAO dao = new ClienteDAO();
                switch (_c)
                {
                    case 'i':
                        return dao.InserirBD(_o);
                    case 'd':
                        return dao.DeletarBD(_o.Id);
                    case 'a':
                        return dao.AlterarBD(_o);
                    case 'l':
                        return dao.ListarTodos();
                    case 'b':
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