using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlServerCe;

namespace Dao
{
    class FuncionarioDAO
    {
        public List<Funcionario> ListarTodos()
        {
            List<Funcionario> listaFuncionarios = new List<Funcionario>();
            try
            {
                String SQL = "SELECT * FROM funcionario;";

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Funcionario e = new Funcionario();

                    e.Id = data.GetInt64(0);
                    e.Nome = data.GetString(1);
                    e.Senha = data.GetString(2);
                    e.Tel = data.GetString(3);

                    listaFuncionarios.Add(e);
                }

                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaFuncionarios;
        }

        public Funcionario BuscarPorID(Int64 _id)
        {
            Funcionario e = null;
            try
            {
                String SQL = String.Format("SELECT * FROM funcionario WHERE id = {0} ", _id);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    e = new Funcionario();

                    e.Id = data.GetInt64(0);
                    e.Nome = data.GetString(1);
                    e.Senha = data.GetString(2);
                    e.Tel = data.GetString(3);
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

        public Boolean InserirBD(Funcionario _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("INSERT INTO funcionario (id, nome, senha, tel) VALUES ('{0}', '{1}', '{2}', '{3}')", 
                    _objeto.Id, 
                    _objeto.Nome, 
                    _objeto.Senha, 
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

        public Boolean AlterarBD(Funcionario _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("UPDATE funcionario SET id = '{0}', nome = '{1}', senha = '{2}',  tel = '{3}' WHERE id = {0};",
                    _objeto.Id,
                    _objeto.Nome,
                    _objeto.Senha,
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
                String SQL = String.Format("DELETE FROM funcionario WHERE id = {0};", _id);

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
