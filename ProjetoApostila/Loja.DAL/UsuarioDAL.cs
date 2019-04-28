using Loja.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.DAL
{
    public class UsuarioDAL
    {
        SqlConnection conn;

        public UsuarioDAL()
        {
            conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.Conn;
        }

        public IList<UsuarioDTO> ObterUsuarios()
        {
            var command = new SqlCommand("Select * From Usuario");
            command.Connection = conn;

            try
            {
                command.Connection.Open();
                var reader = command.ExecuteReader();

                var retorno = new List<UsuarioDTO>();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var test = reader["Id"];

                        retorno.Add(
                            new UsuarioDTO
                        {
                            Id = int.Parse(reader["Id"].ToString()),
                            Nome = reader["Nome"].ToString(),
                            Email = reader["Email"].ToString(),
                            Senha = reader["Senha"].ToString(),
                            DataCadastro = DateTime.Parse(reader["DataCadastro"].ToString()),
                            Situacao = reader["Situacao"].ToString(),
                            Perfil = int.Parse(reader["Perfil"].ToString())
                        });
                    }
                }

                command.Connection.Close();

                return retorno;
            }
            catch
            {
                throw;
            }
        }

        public void Inserir(UsuarioDTO usuario)
        {
            var command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "Insert Into Usuario Values (" +
                "@Nome, " +
                "@Email, " +
                "@Senha, " +
                "@DataCadastro, " +
                "@Situacao, " +
                "@Perfil)";

            command.Parameters.Add("Nome", SqlDbType.VarChar).Value = usuario.Nome;
            command.Parameters.Add("Email", SqlDbType.VarChar).Value = usuario.Email;
            command.Parameters.Add("Senha", SqlDbType.VarChar).Value = usuario.Senha;
            command.Parameters.Add("DataCadastro", SqlDbType.DateTime).Value = usuario.DataCadastro;
            command.Parameters.Add("Situacao", SqlDbType.VarChar).Value = usuario.Situacao;
            command.Parameters.Add("Perfil", SqlDbType.Int).Value = usuario.Perfil;

            command.Connection = conn;
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
        }

        public void Alterar(UsuarioDTO usuario)
        {
            var command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "Update Usuario " +
                "Set Nome = @Nome, " +
                "Email = @Email, " +
                "Senha = @Senha, " +
                "DataCadastro = @DataCadastro, " +
                "Situacao = @Situacao, " +
                "Perfil = @Perfil " +
                "Where Id = @Id";

            command.Parameters.Add("Nome", SqlDbType.VarChar).Value = usuario.Nome;
            command.Parameters.Add("Email", SqlDbType.VarChar).Value = usuario.Email;
            command.Parameters.Add("Senha", SqlDbType.VarChar).Value = usuario.Senha;
            command.Parameters.Add("DataCadastro", SqlDbType.DateTime).Value = usuario.DataCadastro;
            command.Parameters.Add("Situacao", SqlDbType.VarChar).Value = usuario.Situacao;
            command.Parameters.Add("Perfil", SqlDbType.Int).Value = usuario.Perfil;
            command.Parameters.Add("Id", SqlDbType.Int).Value = usuario.Id;

            command.Connection = conn;
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
        }
        public void Excluir(UsuarioDTO usuario)
        {
            var command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "Delete From Usuario Where Id = @Id";

            command.Parameters.Add("Id", SqlDbType.Int).Value = usuario.Id;

            command.Connection = conn;
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
        }
    }
}
