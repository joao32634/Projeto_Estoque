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
        public F_Relatorios(F_Movimento_de_Estoque f)
        {
            f.Visible = false;
            InitializeComponent();
        }

        private void F_Relatorios_Load(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=SOB041982L4B1PC\\SQLEXPRESS;" +
    "Initial Catalog=BDESTOQUE;Integrated Security=true");

            string command = "Select id, Nome, Categoria, Unidade, Preço_de_Custo, Preço_de_Venda, Quantidade_Inicial, Estoque_Minimo, Fornecedor from dbo.Cadastro_Produto ";
            try
            {
                //executa o comando SQL e recebendo os dados
                SqlDataAdapter da = new SqlDataAdapter(command, sql);

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

        private void tbxFiltros_TextChanged(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=SOB041982L4B1PC\\SQLEXPRESS;" +
                            "Initial Catalog=BDESTOQUE;Integrated Security=true");

            string command = "Where '%' from dbo.Cadaastro_Produto";

            SqlDataAdapter da = new SqlDataAdapter(command, sql);


        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=SOB041982L4B1PC\\SQLEXPRESS;" +
"Initial Catalog=BDESTOQUE;Integrated Security=true");

            String PesquisaNome = tbxFiltro.Text;
            string command = $"select Nome, Categoria, Unidade, Preço_de_Custo, Preço_de_Venda, Quantidade_Inicial, Estoque_Minimo, Fornecedor from dbo.Cadastro_Produto WHERE Categoria LIKE '%{PesquisaNome}%'";
            try
            {
               
                //executa o comando SQL e recebendo os dados
                SqlDataAdapter da = new SqlDataAdapter(command, sql);

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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=SOB041982L4B1PC\\SQLEXPRESS;" +
                        "Initial Catalog=BDESTOQUE;Integrated Security=true");
            String ID = tbxID.Text = dgvRelatorios.CurrentRow.Cells[0].Value.ToString();
            SqlCommand command = new SqlCommand("UPDATE Cadastro_Produto SET ID =@ID Nome = @Nome, " +
                $"Categoria =@Categoria, Unidade =@Unidade, Preço_de_Custo =@Preço_de_Venda, @Quantidade_Inicial =@Quantidade_Inicial, Estoque_Minimo =@Estoque_Minimo, Fornecedor =@Fornecedor  WHERE ID = '{ID}'", conn);
            try
            {
                command.Parameters.Add(new SqlParameter("@ID", tbxID.Text));
                command.Parameters.Add(new SqlParameter("@Nome", tbxNomeEditar.Text));
                command.Parameters.Add(new SqlParameter("@Categoria", tbxCategoriaEditar.Text));
                command.Parameters.Add(new SqlParameter("@Unidade", cbbUnidadeEditar.Text));
                command.Parameters.Add(new SqlParameter("@Preço_de_Custo", tbxPrecoCustoEditar.Text));
                command.Parameters.Add(new SqlParameter("@Preço_de_Venda", tbxPrecoVendaEditar.Text));
                command.Parameters.Add(new SqlParameter("@Quantidade_Inicial", tbxQuantidadeInicialEditar.Text));
                command.Parameters.Add(new SqlParameter("@Estoque_Minimo", tbxEstoqueMinimoEditar.Text));
                command.Parameters.Add(new SqlParameter("@Fornecedor", tbxFornecedorEditar.Text));









                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Alteração realizada com Sucesso!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            tbxID.Text = dgvRelatorios.CurrentRow.Cells[0].Value.ToString();
            tbxNomeEditar.Text = dgvRelatorios.CurrentRow.Cells[1].Value.ToString();
            tbxCategoriaEditar.Text = dgvRelatorios.CurrentRow.Cells[2].Value.ToString();
            cbbUnidadeEditar.Text = dgvRelatorios.CurrentRow.Cells[3].Value.ToString();
            tbxPrecoCustoEditar.Text = dgvRelatorios.CurrentRow.Cells[4].Value.ToString();
            tbxPrecoVendaEditar.Text = dgvRelatorios.CurrentRow.Cells[5].Value.ToString();
            tbxQuantidadeInicialEditar.Text = dgvRelatorios.CurrentRow.Cells[6].Value.ToString();
            tbxEstoqueMinimoEditar.Text = dgvRelatorios.CurrentRow.Cells[7].Value.ToString();
            tbxFornecedorEditar.Text = dgvRelatorios.CurrentRow.Cells[8].Value.ToString();


        }

        private void dgvRelatorios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=SOB041982L4B1PC\\SQLEXPRESS;" +
            "Initial Catalog=BDESTOQUE;Integrated Security=true");
            String id = dgvRelatorios.CurrentRow.Cells[0].Value.ToString();
            SqlCommand command = new SqlCommand("DELETE From Cadastro_Produto WHERE id=@id", conn);
            try
            {
                command.Parameters.Add(new SqlParameter("@id", id));

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Registro Deletado com Sucesso!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbbTipoRelatorio_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlConnection sql = new SqlConnection("Data Source=SOB041982L4B1PC\\SQLEXPRESS;" +
                       "Initial Catalog=BDESTOQUE;Integrated Security=true");

            string command = "Select id, Nome, Categoria, Data_de_Movimentacao, Quantidade, Entrada, Saida, Motivo, Fornecedor FROM dbo.Movimento_Produto ";
            try
            {
                


                    //executa o comando SQL e recebendo os dados
                    SqlDataAdapter da = new SqlDataAdapter(command, sql);

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

        private void gerenciamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Controle_de_Estoque janela = new F_Controle_de_Estoque();
            janela.ShowDialog();

        }
    }
}
