using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle_de_estoque
{
    public class C_CProdutos
    {
        private int ID;
        private string Nome;
        private string Categoria;
        private string Unidade;
        private string Preço_de_Custo;
        private string Preço_de_Venda;
        private string Quantidade_Inicial;
        private string Estoque_Minimo;
        private string Fornecedor;
        private C_Conexao C_Conexao = new C_Conexao();

        public void CadastroProduto(string N, string C, string U, string PC, string PV, string QI, string EM, string F)
        {
            SqlConnection conn = C_Conexao.AbrirConexao();
            string sql = ("INSERT INTO Cadastro_Produto (Nome, Categoria, Unidade, Preço_de_Custo, Preço_de_Venda, Quantidade_Inicial, Estoque_Minimo, Fornecedor) " +
                "VALUES(@Nome, @Categoria, @Unidade, @Preço_de_Custo, @Preço_de_Venda, @Quantidade_Inicial, @Estoque_Minimo, @Fornecedor)");

            try
            {
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.Add(new SqlParameter("@Nome", N));
                comando.Parameters.Add(new SqlParameter("@Categoria", C));
                comando.Parameters.Add(new SqlParameter("@Unidade", U));
                comando.Parameters.Add(new SqlParameter("@Preço_de_Custo", PC));
                comando.Parameters.Add(new SqlParameter("@Preço_de_Venda", PV));
                comando.Parameters.Add(new SqlParameter("@Quantidade_Inicial", QI));
                comando.Parameters.Add(new SqlParameter("@Estoque_Minimo", EM));
                comando.Parameters.Add(new SqlParameter("@Fornecedor", F));
                conn.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Produto Cadastrado com Sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public SqlDataAdapter SelecionarTodos()
        {
            SqlConnection conn = C_Conexao.AbrirConexao();

            string command = "Select id, Nome, Categoria, Unidade, Preço_de_Custo, Preço_de_Venda, Quantidade_Inicial, Estoque_Minimo, Fornecedor from dbo.Cadastro_Produto ";
            SqlDataAdapter da = C_Conexao.SelecionarDados(command, conn);
            conn.Close();
            return da;
        }
        public SqlDataReader SelecionarNome()
        {
            SqlConnection conn = C_Conexao.AbrirConexao();

            string command = "Select Nome from dbo.Cadastro_Produto";
            SqlDataReader Reader = C_Conexao.SelecionarDadosReader(command, conn);
            conn.Close();
            return Reader;
        }
        public SqlDataAdapter SelecionarTodosMovimento()
        {
            SqlConnection conn = C_Conexao.AbrirConexao();

            string command = "Select id, Nome, Categoria, Data_de_Movimentacao, Quantidade, Entrada, Saida, Motivo, Fornecedor from dbo.Movimento_Produto ";
            SqlDataAdapter da = C_Conexao.SelecionarDados(command, conn);
            conn.Close();
            return da;

        }
        public SqlDataReader SelecionarNomeMovimento()
        {
            SqlConnection conn = C_Conexao.AbrirConexao();

            string command = "Select Nome From dbo.Movimento_Produto";
            SqlDataReader Reader = C_Conexao.SelecionarDadosReader(command, conn);
            conn.Close();
            return Reader;

        }
        public SqlDataAdapter SelecionarNomeProduto()
        {
            SqlConnection conn = C_Conexao.AbrirConexao();
            string command = "Select Nome From Cadastro_Produtos";
            SqlDataAdapter da = C_Conexao.SelecionarDados(command, conn);
            return da;
        }

    }
}
