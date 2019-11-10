using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlServerCe;

namespace Dao
{
    public class CarroDAO
    {
        public List<Carro> ListarTodos()
        {
            List<Carro> listaCarros = new List<Carro>();
            try
            {
                String SQL = String.Format("SELECT * FROM carro");

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Carro c = new Carro();

                    c.Id = data.GetInt32(0);
                    c.Placa = data.GetString(1);
                    c.Nome = data.GetString(2);
                  
                    listaCarros.Add(c);
                }
                
                foreach (Carro c in listaCarros)
                {
                    ClienteDAO dao = new ClienteDAO();

                    c.Cliente = dao.BuscarPorID(c.Cliente.Id);
                }
                
           

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaCarros;
        }

        public Carro BuscarPorID(Int64 _id)
        {
            Carro c = null;
            try
            {
                String SQL = String.Format("SELECT * FROM carro WHERE id = {0} ", _id);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    c = new Carro();

                    c.Id = data.GetInt32(0);
                    c.Placa = data.GetString(1);
                    c.Nome = data.GetString(3);

                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return c;
        }

        public Boolean InserirBD(Carro _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("INSERT INTO carro (id, placa, nome) VALUES ('{0}', '{1}', '{2}')", _objeto.Id, _objeto.Placa, _objeto.Nome);

                int linhaAfetadas = BD.ExecutarIDU(SQL);

                if (linhaAfetadas > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return resultado;
        }

        public Boolean AlterarBD(Carro _objeto)
        {
            
            
            bool resultado = false;
            try
            {
                
                String SQL = String.Format("UPDATE carro SET id = '{0}', placa = '{1}', nome = '{2}' WHERE id = {0};",
                    _objeto.Id,
                    _objeto.Placa,
                    _objeto.Nome);
                /*Testar string SQL*/

                int linhaAfetadas = BD.ExecutarIDU(SQL);

                if (linhaAfetadas > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return resultado;
        }


        public Boolean DeletarBD(Int64 _id)
        {   
            bool resultado = false;
            try
            {
                String SQL = String.Format("DELETE FROM carro WHERE id = {0};", _id);

                int linhaAfetadas = BD.ExecutarIDU(SQL);

                if (linhaAfetadas > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return resultado;
        }

     
       
    }
}

