using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle_de_estoque
{
    public partial class F_Controle_de_Estoque : Form
    {
        public F_Controle_de_Estoque()
        {
            
            InitializeComponent();


        }

        private void F_Controle_de_Estoque_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void movimentoDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Movimento_de_Estoque janela = new F_Movimento_de_Estoque(this);
            janela.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strconn = ("Data Source=SOB041982L4B1PC\\SQLEXPRESS;" +
                         "Initial Catalog=BDESTOQUE;Integrated Security=true");


            SqlConnection conn = new SqlConnection(strconn);
            string sql = ("INSERT INTO Cadastro_Produto (Nome, Categoria, Unidade, Preço_de_Custo, Preço_de_Venda, Quantidade_Inicial, Estoque_Minimo, Fornecedor) " +
                "VALUES(@Nome, @Categoria, @Unidade, @Preço_de_Custo, @Preço_de_Venda, @Quantidade_Inicial, @Estoque_Minimo, @Fornecedor)");

            try
            {
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.Add(new SqlParameter("@Nome", tbxNome.Text));
                comando.Parameters.Add(new SqlParameter("@Categoria", cbbCategoria.Text));
                comando.Parameters.Add(new SqlParameter("@Unidade", cbbUnidade.Text));
                comando.Parameters.Add(new SqlParameter("@Preço_de_Custo", tbxPreçoCusto.Text));
                comando.Parameters.Add(new SqlParameter("@Preço_de_Venda", tbxPreçoVenda.Text));
                comando.Parameters.Add(new SqlParameter("@Quantidade_Inicial", tbxQuantidadeInicial.Text));
                comando.Parameters.Add(new SqlParameter("@Estoque_Minimo", tbxEstoqueMinimo.Text));
                comando.Parameters.Add(new SqlParameter("@Fornecedor", tbxFornecedor.Text));
                conn.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Produto Cadastrado com Sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
