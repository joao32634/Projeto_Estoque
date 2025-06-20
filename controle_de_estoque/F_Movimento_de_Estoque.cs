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
        public F_Movimento_de_Estoque(F_Controle_de_Estoque f)
        {
            f.Visible = false;
            InitializeComponent();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Relatorios janela = new F_Relatorios(this);
            janela.ShowDialog();
            this.Close();

        }

        private void F_Movimento_de_Estoque_Load(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=SOB041982L4B1PC\\SQLEXPRESS;" +
                      "Initial Catalog=BDESTOQUE;Integrated Security=true");

            string command = "SELECT Nome FROM Cadastro_Produto";
            SqlCommand comando = new SqlCommand(command, sql);
            try
            {
                sql.Open();
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
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
