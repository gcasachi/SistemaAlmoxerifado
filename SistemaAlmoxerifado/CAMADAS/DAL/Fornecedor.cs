using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlmoxerifado.CAMADAS.DAL {
    public class Fornecedor {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Fornecedor> Select() {
            List<MODEL.Fornecedor> lstFornecedores = new List<MODEL.Fornecedor>();

            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Fornecedor";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read()) {
                    MODEL.Fornecedor fornecedor = new MODEL.Fornecedor();
                    fornecedor.id = Convert.ToInt32(dados["id"].ToString());
                    fornecedor.nome = dados["nome"].ToString();
                    lstFornecedores.Add(fornecedor);
                }
            }
            catch {
                Console.WriteLine("Erro no Select do Fornecedor");
            }
            finally {
                conexao.Close();
            }
            return lstFornecedores;
        }

        public MODEL.Fornecedor SelectByID(int id) {

            MODEL.Fornecedor fornecedor = new MODEL.Fornecedor();

            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Fornecedor WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);

            try {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                if (dados.Read()) {
                    
                    fornecedor.id = Convert.ToInt32(dados["id"].ToString());
                    fornecedor.nome = dados["nome"].ToString();
                    
                }
            }
            catch {
                Console.WriteLine("Erro no SelectByID do Fornecedor");
            }
            finally {
                conexao.Close();
            }
            return fornecedor;
        }

        public void Insert(MODEL.Fornecedor fornecedor) {
            SqlConnection conexao = new SqlConnection(strCon);

            string sql = "INSERT INTO Fornecedor VALUES (@nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", fornecedor.nome);

            try {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch {
                Console.WriteLine("Erro no Insert de Fornecedor");
            }
            finally {
                conexao.Close();
            }
        }

        public void Update(MODEL.Fornecedor fornecedor) {
            SqlConnection conexao = new SqlConnection(strCon);

            string sql = "UPDATE Fornecedor SET nome=@nome ";
            sql += "WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@id", fornecedor.id);
            cmd.Parameters.AddWithValue("@nome", fornecedor.nome);

            try {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch {
                Console.WriteLine("Erro sql atualizar fornecedor...");
            }
            finally {
                conexao.Close();
            }
        }

        public void Delete(int idFornecedor) {
            SqlConnection conexao = new SqlConnection(strCon);

            string sql = "DELETE FROM Fornecedor WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idFornecedor);

            try {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch {
                Console.WriteLine("Erro sql Remover fornecedor...");
            }
            finally {
                conexao.Close();
            }
        }
    }
}
