using System;
using System.Collections;
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
    public partial class F_Movimento_de_Estoque : Form
    {
        public F_Movimento_de_Estoque()
        {
            
            InitializeComponent();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Relatorios janela = new F_Relatorios();
            janela.ShowDialog();
            

        }

        private void F_Movimento_de_Estoque_Load(object sender, EventArgs e)
        {
            C_CProdutos c_CProdutos = new C_CProdutos();

            try
            {

                SqlDataReader reader = c_CProdutos.SelecionarNome();

                while(reader.Read())
                {
                    string filtro = reader["Nome"].ToString().Trim();
                    cbbProduto.Items.Add(filtro);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cbbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbProduto.SelectedValue != null)
            {
                int produtoId = (int)cbbProduto.SelectedValue;

                // Buscar categoria desse produto
                string query = "SELECT Categoria FROM Produto WHERE id = @id";
                using (SqlConnection conn = new SqlConnection("Data Source=SOB041982L4B1PC\\SQLEXPRESS;Initial Catalog=BDESTOQUE;Integrated Security=True;"))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", produtoId);
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int categoriaId = Convert.ToInt32(result);
                        cbbProduto.SelectedValue = categoriaId;
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strconn = ("Data Source=SOB041982L4B1PC\\SQLEXPRESS;" +
             "Initial Catalog=BDESTOQUE;Integrated Security=true");

            bool entrada = true;
            bool saida = true;
            if (rdbEntrada.Checked)
            {
                entrada = true;
                saida = false;
            }
            if (rdbSaida.Checked)
            {
                entrada = false;
                saida = true;
            }

            SqlConnection conn = new SqlConnection(strconn);
            string sql = ("INSERT INTO Movimento_Produto (Nome, Categoria, Data_de_Movimentacao, Quantidade, Entrada, Saida, Motivo, Fornecedor) " +
                "VALUES(@Nome, @Categoria, @Data_de_Movimentacao, @Quantidade, @Entrada, @Saida, @Motivo, @Fornecedor)");

            try
            {


                    SqlCommand comando = new SqlCommand(sql, conn);
                    comando.Parameters.Add(new SqlParameter("@Nome", cbbProduto.Text));
                    comando.Parameters.Add(new SqlParameter("@Data_de_Movimentacao", dtpDataMovimentacao.Text));
                    comando.Parameters.Add(new SqlParameter("@Quantidade", tbxQuantidade.Text));
                    comando.Parameters.Add(new SqlParameter("@Entrada", entrada));
                    comando.Parameters.Add(new SqlParameter("@Saida", saida));
                    comando.Parameters.Add(new SqlParameter("@Motivo", cbbMotivo.Text));
                    comando.Parameters.Add(new SqlParameter("@Categoria", cbbCategoria.Text));
                    comando.Parameters.Add(new SqlParameter("@Fornecedor", tbxFornecedor.Text));
                    conn.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Produto Movimentado com Sucesso!", "Movimento de Estoque", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

                
                 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Movimento de Produto");
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
