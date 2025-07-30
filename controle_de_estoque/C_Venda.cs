using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle_de_estoque
{
    internal class C_Venda
    {
        private C_Conexao C_Conexao = new C_Conexao();

        public SqlDataReader LerDados(string id, string id_Produto, string Preco, string Quantidade)
        {
            SqlConnection conn = C_Conexao.AbrirConexao();
            string command = "SELECT id, id_Produto, Preco_Venda, Quantidade WHERE id = @id";
            SqlCommand comando = new SqlCommand(command, conn);
            comando.Parameters.AddWithValue("id", id_Produto);
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                id = reader["id"].ToString();
                id_Produto = reader["id_Produto"].ToString();
                Preco = reader["Preco_Venda"].ToString();
                Quantidade = reader["Quantidade"].ToString();
            }
            else
            {
                MessageBox.Show("Produto não encontrado");
            }
            return reader;
        }
        public void SelecionarDadosID(string produto)
        {

        }
        public void SelecionarDadosProduto(string idProduto, string preco, string Quantidade)
        {
            SqlConnection conn = C_Conexao.AbrirConexao();
            string command = "SELECT Preco, Quantidade FROM Produto WHERE id = @id";
            SqlCommand comando = new SqlCommand(command, conn);
            comando.Parameters.AddWithValue("@id", idProduto);

            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                preco = reader["Preco"].ToString();
                Quantidade = reader["Quantidade"].ToString();

            }
            reader.Close();

        }
        public void VendaProduto(string idProdu, string preco, string Quantidade)
        {
            int idProd = Convert.ToInt32(idProdu);
            double prec = Convert.ToDouble(preco);
            int qtd = Convert.ToInt32(Quantidade);

            SqlConnection conn = C_Conexao.AbrirConexao();
            string command = ("INSERT INTO Venda (id_Produto, Preco_Venda, Quantidade) " +
    "VALUES(@id_Produto, @Preco_Venda, @Quantidade)");

            try
            {
                SqlCommand comando = new SqlCommand(command, conn);
                comando.Parameters.Add(new SqlParameter("@id_Produto", idProd));
                comando.Parameters.Add(new SqlParameter("@Preco_Venda", prec));
                comando.Parameters.Add(new SqlParameter("@Quantidade", qtd));
                C_CProdutos c_CProdutos = new C_CProdutos();
                c_CProdutos.AtualizarVendaProduto(Convert.ToInt32(idProd), qtd);
                comando.ExecuteNonQuery();


                MessageBox.Show("Venda Realizada!", "VendaProduto");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"VendaProduto");
            }


        }
    }

}
