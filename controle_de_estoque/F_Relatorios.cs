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
    public partial class F_Relatorios : Form
    {
        public F_Relatorios()
        {
            
            InitializeComponent();
        }

        private void F_Relatorios_Load(object sender, EventArgs e)
        {
            C_CProdutos c_CProdutos = new C_CProdutos();


            try
            {



                //executa o comando SQL e recebendo os dados
                SqlDataAdapter da = c_CProdutos.SelecionarTodos();

                //instância um DateTable - que servirá de intermediário
                DataTable dt = new DataTable();

                //Preencher o dataGrudView com os dados do dt
                da.Fill(dt);

                dgvRelatorios.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {

              

                    SqlDataReader reader = c_CProdutos.SelecionarNome();

                    while (reader.Read())
                    {
                        string nome = reader["Nome"].ToString().Trim();
                        string id = reader["id"].ToString().Trim();
                        string idNome = $"{id} - {nome}"; 
                        cbbProdutos.Items.Add(idNome);
                    }


                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void tbxFiltros_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=SOB041982L4B1PC\\SQLEXPRESS;" +
                            "Initial Catalog=BDESTOQUE;Integrated Security=true");

            string command = "Where '%' from dbo.Cadaastro_Produto";

            SqlDataAdapter da = new SqlDataAdapter(command, sql);


        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            /*string strconn = ("Data Source=SOB041982L4B1PC\\SQLEXPRESS;" +
 "Initial Catalog=BDESTOQUE;Integrated Security=true");
             SqlConnection conn = new SqlConnection(strconn);*/

            C_CProdutos c_CProdutos = new C_CProdutos();



            if (cbbTipoRelatorio.Text == "Produtos")
            {

                try
                {
                    String PesquisaNome = tbxFiltro.Text;

                    //executa o comando SQL e recebendo os dados
                    SqlDataAdapter da = c_CProdutos.FiltrarNome(PesquisaNome);

                    //instância um DateTable - que servirá de intermediário
                    DataTable dt = new DataTable();

                    //Preencher o dataGrudView com os dados do dt
                    da.Fill(dt);

                    dgvRelatorios.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Relatorios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (cbbTipoRelatorio.Text == "Movimento de Produtos")
            { 
                try
                {
                    String PesquisaNome = tbxFiltro.Text;



                    //executa o comando SQL e recebendo os dados
                    SqlDataAdapter da = c_CProdutos.FiltrarNomeMovimento(PesquisaNome);
    
                //instância um DateTable - que servirá de intermediário
                DataTable dt = new DataTable();

                    //Preencher o dataGrudView com os dados do dt
                    da.Fill(dt);

                    dgvRelatorios.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Relatorios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (cbbTipoRelatorio.Text == "Compra")
            {
                try
                {
                    String PesquisaNome = tbxFiltro.Text;



                    //executa o comando SQL e recebendo os dados
                    SqlDataAdapter da = c_CProdutos.FiltrarProdutoCompra(PesquisaNome);

                    //instância um DateTable - que servirá de intermediário
                    DataTable dt = new DataTable();

                    //Preencher o dataGrudView com os dados do dt
                    da.Fill(dt);

                    dgvRelatorios.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Relatorios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           /* C_CProdutos c_Cprodutos = new C_CProdutos();
            String Compra = cbbTipoRelatorio.Text;
            String produtos = cbbTipoRelatorio.Text;
            String MovProdutos = cbbTipoRelatorio.Text;
            String Nome = tbxID.Text = dgvRelatorios.CurrentRow.Cells[0].Value.ToString();
            c_Cprodutos.EditarProduto(Nome, produtos, MovProdutos, Compra,tbxCategoriaEditar.Text, cbbPreco.Text, tbxQuantidade.Text, tbxEstoqueMinimoEditar.Text, tbxFornecedor.Text);*/
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            /*tbxID.Text = dgvRelatorios.CurrentRow.Cells[0].Value.ToString();
            tbxNomeEditar.Text = dgvRelatorios.CurrentRow.Cells[1].Value.ToString();
            tbxCategoriaEditar.Text = dgvRelatorios.CurrentRow.Cells[2].Value.ToString();
            cbbPreco.Text = dgvRelatorios.CurrentRow.Cells[3].Value.ToString();
            tbxQuantidade.Text = dgvRelatorios.CurrentRow.Cells[4].Value.ToString();
            tbxEstoqueMinimoEditar.Text = dgvRelatorios.CurrentRow.Cells[5].Value.ToString();
            tbxFornecedor.Text = dgvRelatorios.CurrentRow.Cells[6].Value.ToString();*/


        }

        private void dgvRelatorios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            C_CProdutos c_CProdutos = new C_CProdutos();
            String Compra = cbbTipoRelatorio.Text; 
            String Produtos = cbbTipoRelatorio.Text;
            String MovProdutos = cbbTipoRelatorio.Text;
            String id = dgvRelatorios.CurrentRow.Cells[0].Value.ToString();
            c_CProdutos.DeletarProduto(id, Produtos, MovProdutos, Compra);

        }

        private void cbbTipoRelatorio_SelectedIndexChanged(object sender, EventArgs e)
        {

            C_CProdutos c_CProdutos = new C_CProdutos();
            if (cbbTipoRelatorio.Text == "Movimento de Produtos")
            {
                try
                {



                    //executa o comando SQL e recebendo os dados
                    SqlDataAdapter da = c_CProdutos.SelecionarTodosMovimento();

                    //instância um DateTable - que servirá de intermediário
                    DataTable dt = new DataTable();

                    //Preencher o dataGrudView com os dados do dt
                    da.Fill(dt);

                    dgvRelatorios.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (cbbTipoRelatorio.Text == "Produto")
            {


                try
                {



                    //executa o comando SQL e recebendo os dados
                    SqlDataAdapter da = c_CProdutos.SelecionarTodos();

                    //instância um DateTable - que servirá de intermediário
                    DataTable dt = new DataTable();

                    //Preencher o dataGrudView com os dados do dt
                    da.Fill(dt);

                    dgvRelatorios.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (cbbTipoRelatorio.Text == "Compra")
            {


                try
                {



                    //executa o comando SQL e recebendo os dados
                    SqlDataAdapter da = c_CProdutos.ProdutoCompra();

                    //instância um DateTable - que servirá de intermediário
                    DataTable dt = new DataTable();

                    //Preencher o dataGrudView com os dados do dt
                    da.Fill(dt);

                    dgvRelatorios.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Listar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void gerenciamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Controle_de_Estoque janela = new F_Controle_de_Estoque();
            janela.Show();

        }

        private void movimentoDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            C_CProdutos c_CProdutos = new C_CProdutos();

            string[] partes = cbbProdutos.Text.Split('-');
            int produtoId = Convert.ToInt32(partes[0].Trim());
            int qtd = Convert.ToInt32(tbxQuantidade.Text);
            float PC = Convert.ToSingle(tbxPreco.Text);
            c_CProdutos.RegistrarProdutoCompra(produtoId, cbbCategoria.Text, PC, qtd, dtpData,  tbxFornecedor.Text, rdbCompra.Text);

        }

        private void cbbProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
                string[] partes = cbbProdutos.Text.Split('-');
                int produtoId = Convert.ToInt32(partes[0].Trim());
            MessageBox.Show($"{produtoId}");
            //int produtoId = (int)cbbProdutos.SelectedValue;

            // Buscar categoria desse produto
            string query = "SELECT Categoria, Preco FROM Produto WHERE id = @id";
                using (SqlConnection conn = new SqlConnection("Data Source=SOB041982L4B1PC\\SQLEXPRESS;" +
                    "Initial Catalog=BDESTOQUE;Integrated Security=True;"))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", produtoId);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        cbbCategoria.Text = reader["Categoria"].ToString();
                        tbxPreco.Text = reader["Preco"].ToString();
                    }

                }
            

        }

        private void cbbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
