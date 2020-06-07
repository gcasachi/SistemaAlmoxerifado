using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlmoxerifado.CAMADAS.DAL {
    class Requisicao {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Requisicao> Select() {
            List<MODEL.Requisicao> lstFornecedores = new List<MODEL.Requisicao>();

            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Requisicao";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read()) {
                    MODEL.Requisicao requisicao = new MODEL.Requisicao();

                    requisicao.id = Convert.ToInt32(dados["id"].ToString());
                    requisicao.setorID = Convert.ToInt32(dados["setorID"].ToString());
                    requisicao.produtoID = Convert.ToInt32(dados["produtoID"].ToString());
                    requisicao.quantidade = Convert.ToInt32(dados["quantidade"].ToString());
                    requisicao.data = Convert.ToDateTime(dados["data"].ToString());

                    //recuperar nome Setor e Produto
                    CAMADAS.BLL.Setor bllSetor = new CAMADAS.BLL.Setor();
                    CAMADAS.MODEL.Setor setor= bllSetor.SelectByID(requisicao.setorID);
                    requisicao.setor = setor.nome;

                    BLL.Almoxarifado bllAlmo = new BLL.Almoxarifado();
                    MODEL.Almoxarifado almoxarifado = bllAlmo.SelectByID(requisicao.produtoID)[0];
                    requisicao.produto = almoxarifado.nome;

                    lstFornecedores.Add(requisicao);
                }
            }
            catch {
                Console.WriteLine("Erro no Select do Requisição");
            }
            finally {
                conexao.Close();
            }
            return lstFornecedores;
        }

        public List<MODEL.Requisicao> SelectByID(int id) {
            List<MODEL.Requisicao> lstRequisicao = new List<MODEL.Requisicao>();

            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Requisicao WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);

            try {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                if (dados.Read()) {
                    MODEL.Requisicao requisicao = new MODEL.Requisicao();

                    requisicao.id = Convert.ToInt32(dados["id"].ToString());
                    requisicao.setorID = Convert.ToInt32(dados["setorID"].ToString());
                    requisicao.produtoID = Convert.ToInt32(dados["produtoID"].ToString());
                    requisicao.quantidade = Convert.ToInt32(dados["quantidade"].ToString());
                    requisicao.data = Convert.ToDateTime(dados["data"].ToString());

                    //recuperar nome Setor e Produto
                    CAMADAS.BLL.Setor bllSetor = new CAMADAS.BLL.Setor();
                    CAMADAS.MODEL.Setor setor = bllSetor.SelectByID(requisicao.setorID);
                    requisicao.setor = setor.nome;

                    BLL.Almoxarifado bllAlmo = new BLL.Almoxarifado();
                    MODEL.Almoxarifado almoxarifado = bllAlmo.SelectByID(requisicao.produtoID)[0];
                    requisicao.produto = almoxarifado.nome;

                    lstRequisicao.Add(requisicao);
                }
            }
            catch {
                Console.WriteLine("Erro listar Banco sql-Rquisição");
            }
            finally {
                conexao.Close();
            }
            return lstRequisicao;
        }

        public List<MODEL.Requisicao> SelectByNome(List<MODEL.Almoxarifado> listaAlmoxarifado) {
            List<MODEL.Requisicao> lstRequisicao = new List<MODEL.Requisicao>();
            int id;
            string sql;
            SqlConnection conexao = new SqlConnection(strCon);

            for (int indice = 0; indice < listaAlmoxarifado.Count; indice++) {
                id = listaAlmoxarifado[indice].id;

               // conexao = new SqlConnection(strCon);
                sql = "SELECT * FROM Requisicao WHERE produtoID=@produtoID;";
                SqlCommand cmd = new SqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@produtoID", id);

                try {
                    conexao.Open();
                    SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                    while (dados.Read()) {
                        MODEL.Requisicao requisicao = new MODEL.Requisicao();

                        requisicao.id = Convert.ToInt32(dados["id"].ToString());
                        requisicao.setorID = Convert.ToInt32(dados["setorID"].ToString());
                        requisicao.produtoID = Convert.ToInt32(dados["produtoID"].ToString());
                        requisicao.produto = listaAlmoxarifado[indice].nome;
                        requisicao.quantidade = Convert.ToInt32(dados["quantidade"].ToString());
                        requisicao.data = Convert.ToDateTime(dados["data"].ToString());

                        //recuperar nome Setor
                        BLL.Setor bllSetor = new CAMADAS.BLL.Setor();
                        MODEL.Setor setor = bllSetor.SelectByID(requisicao.setorID);
                        requisicao.setor = setor.nome;

                        lstRequisicao.Add(requisicao);
                    }
                }
                catch {
                    Console.WriteLine("Erro listar Banco sql-Rquisição");
                }
            } 
             conexao.Close();

            return lstRequisicao;
        }

        public void Insert(MODEL.Requisicao requisicao) {
            SqlConnection conexao = new SqlConnection(strCon);

            string sql = "INSERT INTO Requisicao VALUES (@setorID, @produtoID, @quantidade, @data);";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@setorID", requisicao.setorID);
            cmd.Parameters.AddWithValue("@produtoID", requisicao.produtoID);
            cmd.Parameters.AddWithValue("@quantidade", requisicao.quantidade);
            cmd.Parameters.AddWithValue("@data", requisicao.data);

            try {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch {
                Console.WriteLine("Erro no Insert de Requisicao");
            }
            finally {
                conexao.Close();
            }
        }

        public void Update(MODEL.Requisicao requisicao) {
            SqlConnection conexao = new SqlConnection(strCon);

            string sql = "UPDATE Requisicao SET quantidade=@quantidade ";
            sql += "WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", requisicao.id);
            cmd.Parameters.AddWithValue("@quantidade", requisicao.quantidade);

            try {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch {
                Console.WriteLine("Erro sql atualizar Requisicao...");
            }
            finally {
                conexao.Close();
            }
        }

        public void Delete(int idRequisicao) {
            SqlConnection conexao = new SqlConnection(strCon);

            string sql = "DELETE FROM Requisicao WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            cmd.Parameters.AddWithValue("@id", idRequisicao);

            try {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch {
                Console.WriteLine("Erro sql Remover Requisicao...");
            }
            finally {
                conexao.Close();
            }
        }
    }
}
