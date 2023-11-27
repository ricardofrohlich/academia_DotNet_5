using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_AdoNet
{
    internal class Pessoa
    {
        public int id;
        public string nome;
        public int idade;

        public bool gravar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();

            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "insert into pessoas values " +
                "(@nome, @idade);";
            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@idade", System.Data.SqlDbType.Int);
            command.Parameters[0].Value = nome;
            command.Parameters[1].Value = idade;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();

                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }

        public bool atualizar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();

            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "update pessoas set nome = @nome, idade = @idade " +
                                  "where id = @id;";

            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@idade", System.Data.SqlDbType.Int);
            command.Parameters.Add("@id", System.Data.SqlDbType.Int);

            command.Parameters[0].Value = nome;
            command.Parameters[1].Value = idade;
            command.Parameters[2].Value = id;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }

        public bool excluir()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand command = new SqlCommand();
            command.Transaction = tran;
            command.Connection = cn;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "delete from pessoas where id = @id";
            command.Parameters.Add("@id", System.Data.SqlDbType.Int);
            command.Parameters[0].Value = id;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }

        public DataTable buscaPessoas()
        {
            Banco bd = new Banco();
            
            try
            {
                SqlConnection cn = bd.abrirConexao();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = cn;
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = "select * from pessoas";

                sqlCommand.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                adapter.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                bd.fecharConexao();
            }
        }

        public DataTable buscaPessoaById()
        {
            Banco bd = new Banco();

            try
            {
                SqlConnection cn = bd.abrirConexao();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = cn;
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = "select * from pessoas where id = @id";
                sqlCommand.Parameters.Add("@id", SqlDbType.Int);
                sqlCommand.Parameters[0].Value = id;

                sqlCommand.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                adapter.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                bd.fecharConexao();
            }
        }

        public Pessoa buscaPessoaByIdDR()
        {
            Banco bd = new Banco();

            try
            {
                SqlConnection cn = bd.abrirConexao();
                SqlCommand command = new SqlCommand("select * from pessoas", cn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if(reader.GetInt32(0) == id)
                    {
                        nome = reader.GetString(1);
                        idade = reader.GetInt32("idade");

                        return this;
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                bd.fecharConexao();
            }
        }
    }
}
