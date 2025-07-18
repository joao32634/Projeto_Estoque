using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle_de_estoque
{
    public class C_Movimentacao
    {
        
                private C_Conexao c_Conexao = new C_Conexao();

        public void Contratos(string N, string C, string U, string Q, string P, string E, string F)
        {
            SqlConnection conn = c_Conexao.AbrirConexao();
            string sql = ("INSERT INTO Produto (Nome, Categoria, Unidade, Quantidade, Preco, Estoque_Minimo, Fornecedor) " +
                "VALUES(@Nome, @Categoria, @Unidade, @Quantidade, @Preco, @Estoque_Minimo, @Fornecedor)");

            try
            {
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.Add(new SqlParameter("@Nome", N));
                comando.Parameters.Add(new SqlParameter("@Categoria", C));
                comando.Parameters.Add(new SqlParameter("@Unidade", U));
                comando.Parameters.Add(new SqlParameter("@Preco", P));
                comando.Parameters.Add(new SqlParameter("@Quantidade", Q));
                comando.Parameters.Add(new SqlParameter("@Estoque_Minimo", E));
                comando.Parameters.Add(new SqlParameter("@Fornecedor", F));

                string verificacao = c_Conexao.modificarDados(comando, conn);
                if (verificacao == "ok")
                {
                    MessageBox.Show("Produto Cadastrado com Sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Não foi possivel cadastrar", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

    }
}
