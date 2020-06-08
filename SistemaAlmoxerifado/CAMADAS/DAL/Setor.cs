using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAlmoxerifado.CAMADAS.DAL {
    public class Setor {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Setor> Select() {
            List<MODEL.Setor> lstSetores = new List<MODEL.Setor>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * from Setor";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            try {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read()) {
                    MODEL.Setor setor = new MODEL.Setor();
                    setor.id = Convert.ToInt32(dados["id"].ToString());
                    setor.nome = dados["nome"].ToString();
                    lstSetores.Add(setor);
                }
            }
            catch {
                Console.WriteLine("Erro no Select do Setor");
            }
            finally {
                conexao.Close();
            }
            return lstSetores;
        }

        public MODEL.Setor SelectByID(int id) {

            MODEL.Setor setor = new MODEL.Setor();

            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Setor WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", id);

            try {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader();
                if (dados.Read()) {

                    setor.id = Convert.ToInt32(dados["id"].ToString());
                    setor.nome = dados["nome"].ToString();

                }
            }
            catch {
                Console.WriteLine("Erro no SelectByID do Fornecedor");
            }
            finally {
                conexao.Close();
            }
            return setor;
        }

        public void Insert(MODEL.Setor setor) {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Setor VALUES (@nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", setor.nome);

            try {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch {
                Console.WriteLine("Erro no Insert Setor");
            }
            finally {
                conexao.Close();
            }
        }

        public void Update(MODEL.Setor setor) {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Setor SET nome=@nome WHERE id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", setor.id);
            cmd.Parameters.AddWithValue("@nome", setor.nome);

            try {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch {
                Console.WriteLine("Erro no Update Setor");
            }
            finally {
                conexao.Close();
            }
        }

        public void Delete(int idSetor) {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Setor WHERE id=@id";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@id", idSetor);
            try {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch {
                string msg = "Não foi possível remover o item. Verifique se ele está vinculado a outros campos";
                string titBox = "Erro";
                MessageBox.Show(msg, titBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                conexao.Close();
            }
        }

    }
}
