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

                string verificacao = C_Conexao.modificarDados(comando, conn);
                if(verificacao == "ok")
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
            SqlDataReader reader = C_Conexao.SelecionarDadosReader(command, conn);
            return reader;
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
            conn.Close();
            return da;
        }
        public SqlDataAdapter FiltrarNome(string PesquisaNome)
        {
            SqlConnection conn = C_Conexao.AbrirConexao();
            string command = $"select id, Nome, Categoria, Unidade, Preço_de_Custo, Preço_de_Venda, Quantidade_Inicial, Estoque_Minimo, Fornecedor from dbo.Cadastro_Produto WHERE Nome LIKE '%{PesquisaNome}%'";
            SqlDataAdapter da = C_Conexao.SelecionarDados(command , conn);
            conn.Close();
            return da;
        }
        public SqlDataAdapter FiltrarNomeMovimento(string PesquisaNome)
        {
            SqlConnection conn = C_Conexao.AbrirConexao();
            string command = $"select id, Nome, Categoria, Data_de_Movimentacao, Quantidade, Entrada, Saida, Motivo, Fornecedor from dbo.Movimento_Produto WHERE Nome LIKE '%{PesquisaNome}%'";
            SqlDataAdapter da = C_Conexao.SelecionarDados(command, conn);
            conn.Close();
            return da;
        }
        public void EditarProduto(string nome, string categoria, string unidade, string precoCusto, string PrecoVenda, string QuantidadeInicial, string EstoqueMinimo, string Fornecedor)
        {
            SqlConnection conn = C_Conexao.AbrirConexao();

            SqlCommand command = new SqlCommand("UPDATE Cadastro_Produto SET Nome = @Nome, " +
    $"Categoria = @Categoria, Unidade = @Unidade, Preço_de_Custo =@Preço_de_Custo, Preço_de_Venda = @Preço_de_Venda, Quantidade_Inicial = @Quantidade_Inicial, Estoque_Minimo = @Estoque_Minimo, Fornecedor = @Fornecedor  WHERE Nome = '{nome}'", conn);
            try
            {
                command.Parameters.Add(new SqlParameter("@Nome", nome));
                command.Parameters.Add(new SqlParameter("@Categoria", categoria));
                command.Parameters.Add(new SqlParameter("@Unidade", unidade));
                command.Parameters.Add(new SqlParameter("@Preço_de_Custo", precoCusto));
                command.Parameters.Add(new SqlParameter("@Preço_de_Venda", PrecoVenda));
                command.Parameters.Add(new SqlParameter("@Quantidade_Inicial", QuantidadeInicial));
                command.Parameters.Add(new SqlParameter("@Estoque_Minimo", EstoqueMinimo));
                command.Parameters.Add(new SqlParameter("@Fornecedor", Fornecedor));
                string Verificacao = C_Conexao.modificarDados(command, conn);

                if (Verificacao == "ok")
                {
                    MessageBox.Show("Produto Atualizado!", "Editar");

                }
                else
                {
                    MessageBox.Show("Não foi possivel atualizar o produto", "Editar");
                }









                
                MessageBox.Show("Alteração realizada com Sucesso!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void DeletarProduto(string id)
        {
            SqlConnection conn = C_Conexao.AbrirConexao();
            SqlCommand command = new SqlCommand("DELETE From Cadastro_Produto WHERE id=@id", conn);
            try
            {
                command.Parameters.Add(new SqlParameter("@id", id));

                string verificacao = C_Conexao.modificarDados(command, conn);
                if (verificacao == "ok")
                {
                    MessageBox.Show("Registro Deletado com Sucesso!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Não foi possivel deletar", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
