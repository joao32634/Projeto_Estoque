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

        public void CadastroProduto(string N, string C, string U, string p, string Q, string EM, string F)
        {
            SqlConnection conn = C_Conexao.AbrirConexao();
            string sql = ("INSERT INTO Produto (Nome, Categoria, Unidade, Quantidade, Preco, Estoque_Minimo, Fornecedor) " +
                "VALUES(@Nome, @Categoria, @Unidade, @Quantidade, @Preco, @Estoque_Minimo, @Fornecedor)");

            try
            {
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.Add(new SqlParameter("@Nome", N));
                comando.Parameters.Add(new SqlParameter("@Categoria", C));
                comando.Parameters.Add(new SqlParameter("@Unidade", U));
                comando.Parameters.Add(new SqlParameter("@Preco", p));
                comando.Parameters.Add(new SqlParameter("@Quantidade", Q));
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

            string command = "Select id, Nome, Categoria, Unidade, Quantidade, Estoque_Minimo, Fornecedor from dbo.Produto ";
            SqlDataAdapter da = C_Conexao.SelecionarDados(command, conn);
            conn.Close();
            return da;
        }
        public SqlDataReader SelecionarNome()
        {
            SqlConnection conn = C_Conexao.AbrirConexao();
            string command = "Select Nome from dbo.Produto";
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
            string command = "Select Nome From Produto";
            SqlDataAdapter da = C_Conexao.SelecionarDados(command, conn);
            conn.Close();
            return da;
        }
        public SqlDataAdapter FiltrarNome(string PesquisaNome)
        {
            SqlConnection conn = C_Conexao.AbrirConexao();
            string command = $"select id, Nome, Categoria, Unidade, Quantidade, Estoque_Minimo, Fornecedor from dbo.Produtos WHERE Nome LIKE '%{PesquisaNome}%'";
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
        public void EditarProduto(string nome, string categoria, string unidade, string Quantidade, string EstoqueMinimo, string Fornecedor, string produtos, string MovProdutos)
        {
            SqlConnection conn = C_Conexao.AbrirConexao();
            if (produtos == "Produtos")
            {
                SqlCommand command = new SqlCommand("UPDATE Produto SET Nome = @Nome, " +
$"Categoria = @Categoria, Unidade = @Unidade, Quantidade = @Quantidade, Estoque_Minimo = @Estoque_Minimo, Fornecedor = @Fornecedor  WHERE Nome = '{nome}'", conn);
                try
                {
                    command.Parameters.Add(new SqlParameter("@Nome", nome));
                    command.Parameters.Add(new SqlParameter("@Categoria", categoria));
                    command.Parameters.Add(new SqlParameter("@Unidade", unidade));
                    command.Parameters.Add(new SqlParameter("@Quantidade", Quantidade));
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
            if (MovProdutos == "Movimento Produtos")
            {
                SqlCommand command = new SqlCommand("UPDATE Produto SET Nome = @Nome, " +
$"Categoria = @Categoria, Unidade = @Unidade, Quantidade = @Quantidade, Estoque_Minimo = @Estoque_Minimo, Fornecedor = @Fornecedor  WHERE Nome = '{nome}'", conn);
                try
                {
                    command.Parameters.Add(new SqlParameter("@Nome", nome));
                    command.Parameters.Add(new SqlParameter("@Categoria", categoria));
                    command.Parameters.Add(new SqlParameter("@Unidade", unidade));
                    command.Parameters.Add(new SqlParameter("@Quantidade", Quantidade));
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


        }
        public void DeletarProduto(string id, string Produtos, string MovProdutos)
        {
            SqlConnection conn = C_Conexao.AbrirConexao();
            if(Produtos == "Produtos")
            {
                SqlCommand command = new SqlCommand("DELETE From Produtos WHERE id=@id", conn);
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
            if (MovProdutos == "Movimento de Produtos")
            {
                SqlCommand command = new SqlCommand("DELETE From Movimento_Produtos WHERE id=@id", conn);
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
}
