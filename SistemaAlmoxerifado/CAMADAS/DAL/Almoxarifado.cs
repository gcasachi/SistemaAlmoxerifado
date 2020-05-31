using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlmoxerifado.CAMADAS.DAL {
    public class Almoxarifado {

        private string strCon = Conexao.getConexao();

        public List<MODEL.Almoxarifado> Select() {
            List<MODEL.Almoxarifado> lstAlmoxarifado = new List<MODEL.Almoxarifado>();

            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Almoxarifado";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                while (dados.Read()) {
                    MODEL.Almoxarifado almoxarifado = new MODEL.Almoxarifado();
                    almoxarifado.id = Convert.ToInt32(dados["id"].ToString());
                    almoxarifado.fornecedorID = Convert.ToInt32(dados["fornecedorID"].ToString());
                    almoxarifado.nome = dados["nome"].ToString();
                    almoxarifado.quantidade = Convert.ToInt32(dados["quantidade"].ToString());

                    lstAlmoxarifado.Add(almoxarifado);
                }
            }
            catch {
                Console.WriteLine("Erro no Select de Almoxarifado");
            }
            finally {
                conexao.Close();
            }
            return lstAlmoxarifado;
        }

        public void Insert(MODEL.Almoxarifado almoxarifado) {
            SqlConnection conexao = new SqlConnection(strCon);

            string sql = "INSERT INTO Almoxarifado VALUES (@fornecedorID, @nome, @quantidade);";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@fornecedorID", almoxarifado.fornecedorID);
            cmd.Parameters.AddWithValue("@nome", almoxarifado.nome);
            cmd.Parameters.AddWithValue("@quantidade", almoxarifado.quantidade);

            try {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch {
                Console.WriteLine("Erro no Insert Almoxarifado");
            }
            finally {
                conexao.Close();
            }
        }

        public void Update(MODEL.Almoxarifado almoxarifado) {
            SqlConnection conexao = new SqlConnection(strCon);

            string sql = "UPDATE Almoxarifado SET fornecedorID=@fornecedorID, quantidade=@quantidade ";
            sql += "WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@id", almoxarifado.id);
            cmd.Parameters.AddWithValue("@fornecedorID", almoxarifado.fornecedorID);
            cmd.Parameters.AddWithValue("@quantidade", almoxarifado.quantidade);

            try {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch {
                Console.WriteLine("Erro sql atualizar Almoxarifado...");
            }
            finally {
                conexao.Close();
            }
        }

        public void Delete(int idProduto) {
            SqlConnection conexao = new SqlConnection(strCon);

            string sql = "DELETE FROM Almoxarifado WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idProduto);

            try {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch {
                Console.WriteLine("Erro sql Remover Produto...");
            }
            finally {
                conexao.Close();
            }
        }
    }
}
