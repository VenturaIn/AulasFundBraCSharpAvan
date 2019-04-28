using Loja.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Loja.DAL
{
    public class ProdutoDAL
    {
        SqlConnection conn;

        public ProdutoDAL()
        {
            conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.Conn;
        }

        public IList<ProdutoDTO> ObterProdutos()
        {
            var command = new SqlCommand("Select * From Produto");
            command.Connection = conn;

            try
            {
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                List<ProdutoDTO> retorno = new List<ProdutoDTO>();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var item = reader["Id"];
                        var prod =
                            new ProdutoDTO
                            {
                                Id = int.Parse(reader["Id"].ToString()),
                                Nome = reader["Nome"].ToString(),
                                ValorUnitario = decimal.Parse(reader["ValorUnitario"].ToString()),
                                Descricao = reader["Descricao"].ToString()
                            };
                        retorno.Add(prod);
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

        public void Inserir(ProdutoDTO produto)
        {
            var command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "Insert Into Produto Values (" +
                "@Nome, " +
                "@ValorUnitario, " +
                "@Descricao)";

            command.Parameters.Add("Nome", SqlDbType.VarChar).Value = produto.Nome;
            command.Parameters.Add("ValorUnitario", SqlDbType.Decimal).Value = produto.ValorUnitario;
            command.Parameters.Add("Descricao", SqlDbType.VarChar).Value = produto.Descricao;

            command.Connection = conn;
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
        }

        public void Alterar(ProdutoDTO produto)
        {
            var command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "Update Produto " +
                "Set Nome = @Nome, " +
                "ValorUnitario = @ValorUnitario, " +
                "Descricao = @Descricao, " +
                "Where Id = @Id";

            command.Parameters.Add("Nome", SqlDbType.VarChar).Value = produto.Nome;
            command.Parameters.Add("ValorUnitario", SqlDbType.Decimal).Value = produto.ValorUnitario;
            command.Parameters.Add("Descricao", SqlDbType.VarChar).Value = produto.Descricao;
            command.Parameters.Add("Id", SqlDbType.Int).Value = produto.Id;

            command.Connection = conn;
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
        }
        public void Excluir(ProdutoDTO produto)
        {
            var command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "Delete From Produto Where Id = @Id";

            command.Parameters.Add("Id", SqlDbType.Int).Value = produto.Id;

            command.Connection = conn;
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
        }
    }
}