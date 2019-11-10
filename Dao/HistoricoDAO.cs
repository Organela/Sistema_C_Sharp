using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlServerCe;

namespace Dao
{
    public class HistoricoDAO
    {
        public List<Historico> ListarTodos(DateTime _id)
        {
            List<Historico> listaHistoricos = new List<Historico>();
            try
            {
                String SQL = String.Format("SELECT * FROM historico WHERE estado id = {0};", _id);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Historico c = new Historico();

                    c.DataInicio = data.GetDateTime(0);
                    c.DataFim = data.GetDateTime(1);
                    c.Preco = data.GetFloat(2);

                    listaHistoricos.Add(c);
                }

                foreach (Historico h in listaHistoricos)
                {
                   
                    CarroDAO dao = new CarroDAO();
                    VagaDAO dao1 = new VagaDAO();
                    FuncionarioDAO dao2 = new FuncionarioDAO();
                    Carro c = new Carro();

                    h.Carro = dao.BuscarPorID(h.Carro.Id);
                    h.Vaga = dao1.BuscarPorID(h.Vaga.Id);
                    h.Funcionario = dao2.BuscarPorID(h.Funcionario.Id);

                }


                data.Close();
                BD.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listaHistoricos;
        }

        public Historico BuscarPorID(DateTime _id)
        {
            Historico c = null;
            try
            {
                String SQL = String.Format("SELECT * FROM historico WHERE datainicio = {0} ", _id);

                SqlCeDataReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    c = new Historico();

                    c.DataInicio = data.GetDateTime(0);
                    c.DataFim = data.GetDateTime(1);
                    c.Preco = data.GetFloat(2);


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

        public Boolean InserirBD(Historico _objeto)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("INSERT INTO historico (datainicio, datafim, preco) VALUES ('{0}', '{1}', '{2}')", 
                    _objeto.DataInicio,
                    _objeto.DataFim,
                    _objeto.Preco);

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

        public Boolean AlterarBD(Historico _objeto)
        {


            bool resultado = false;
            try
            {

                String SQL = String.Format("UPDATE historico SET datainicio = '{0}', datafim = '{1}', preco = '{2}' WHERE datainicio = {0};",
                    _objeto.DataInicio,
                    _objeto.DataFim,
                    _objeto.Preco);
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


        public Boolean DeletarBD(DateTime _id)
        {
            bool resultado = false;
            try
            {
                String SQL = String.Format("DELETE FROM historico WHERE datainicio = {0};", _id);

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
