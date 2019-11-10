using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlServerCe;

namespace Dao
{
    class ClienteDAO
    {
        public List<Cliente> ListarTodos()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            try
            {
                String SQL = "SELECT * FROM Cliente;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Cliente e = new Cliente();

                    e.Id = data.GetInt32(0);
                    e.Nome = data.GetString(1);
                    e.Tel = data.GetString(2);

                    listaClientes.Add(e);
                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaClientes;
        }

        
      

        public Cliente BuscarPorID(Int64 _id)
        {
            Cliente e = null;
            try
            {
                String SQL = String.Format("SELECT * FROM Cliente WHERE id = {0} ", _id);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    e = new Cliente();

                    e.Id = data.GetInt32(0);
                    e.Nome = data.GetString(1);
                    e.Tel = data.GetString(2);
                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return e;
        }

        public Boolean InserirBD(Cliente _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("INSERT INTO Cliente (id, nome, tel) VALUES ('{0}', '{1}', '{2}')", _objeto.Id, _objeto.Nome, _objeto.Tel);

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


        public Boolean AlterarBD(Cliente _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("UPDATE Cliente SET id = '{0}', nome = '{1}', tel = '{2}'  WHERE id = {0};",
                    _objeto.Id,
                    _objeto.Nome,
                    _objeto.Tel);

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
                String SQL = String.Format("DELETE FROM cliente WHERE id = {0};", _id);

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

        public List<Cliente> BuscarClientePorCarro(Int64 _id)
        {
            List<Cliente> listaClientes = new List<Cliente>();
            try
            {
                String SQL = String.Format("SELECT * FROM cliente, carro WHERE cliente.id = {0};", _id);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Cliente e = new Cliente();

                    e.Id = data.GetInt32(0);
                    e.Nome = data.GetString(1);
                    e.Tel = data.GetString(2);




                    listaClientes.Add(e);
                }

                data.Close();
                BD.FecharConexao();

                /*
                foreach (Cliente end in listaClientes)
                {
                    CidadeDAO dao = new CidadeDAO();

                    end.Cidade = dao.BuscarCidadePorID(end.Cidade.Id);
                }
                */
                return listaClientes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
