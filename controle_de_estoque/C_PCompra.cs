using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle_de_estoque
{
    public class C_PCompra
    {
        private C_Conexao c_Conexao = new C_Conexao();

        public void CompraProduto(string idProdu, string P, string Q)
        {
            int idProd = Convert.ToInt32(idProdu);
            double Preco = Convert.ToDouble(P);
            int Quantidade = Convert.ToInt32(Q);

            SqlConnection conn = c_Conexao.AbrirConexao();
        string sql = ("INSERT INTO PCompra (id_Produto, Preco_Compra, Quantidade) " +
                "VALUES(@id_Produto, @Preco_Compra, @Quantidade)");

            try
            {


                    SqlCommand comando = new SqlCommand(sql, conn);
                    comando.Parameters.Add(new SqlParameter("@id_Produto", idProdu));
                    comando.Parameters.Add(new SqlParameter("@Preco_Compra", P));
                    comando.Parameters.Add(new SqlParameter("@Quantidade", Q));
                    C_CProdutos c_CProdutos = new C_CProdutos();
                    c_CProdutos.AtualizarQuantidade(Convert.ToInt32(idProdu), Quantidade);
                    comando.ExecuteNonQuery();

                    
                    MessageBox.Show("Compra Realizada!", "Compra de Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

                
                 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Compra de Produtos");
            }


        }


    }
}
