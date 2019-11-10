using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlServerCe;

namespace Dao
{
   public class VagaDAO
    {
        public List<Vaga> ListarTodos()
        {
            List<Vaga> listaVagas = new List<Vaga>();
            try
            {
                String SQL = "SELECT * FROM vaga;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Vaga e = new Vaga();

                    e.Id = data.GetInt64(0);
                    e.Status = data.GetBoolean(1);

                    listaVagas.Add(e);
                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaVagas;
        }

        public Vaga BuscarPorID(Int64 _id)
        {
            Vaga e = null;
            try
            {
                String SQL = String.Format("SELECT * FROM vaga WHERE id = {0} ", _id);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    e = new Vaga();

                    e.Id = data.GetInt64(0);
                    e.Status = data.GetBoolean(1);
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

        public Boolean InserirBD(Vaga _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("INSERT INTO vaga (id, status) VALUES ('{0}', '{1}')", _objeto.Id, _objeto.Status);

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

        public Boolean AlterarBD(Vaga _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("UPDATE vaga SET id = '{0}' , status = '{1}' WHERE id = {0};",
                    _objeto.Id,
                    _objeto.Status);

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
                String SQL = String.Format("DELETE FROM vaga WHERE id = {0};", _id);

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
