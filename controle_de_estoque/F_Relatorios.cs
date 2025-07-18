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

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            String produtos = cbbTipoRelatorio.Text;
            String MovProdutos = cbbTipoRelatorio.Text;
            String Nome = tbxNomeEditar.Text = dgvRelatorios.CurrentRow.Cells[1].Value.ToString();
            C_CProdutos c_Cprodutos = new C_CProdutos();
            c_Cprodutos.EditarProduto(Nome, produtos, MovProdutos, tbxCategoriaEditar.Text, cbbUnidadeEditar.Text, tbxQuantidadeInicialEditar.Text, tbxEstoqueMinimoEditar.Text, tbxFornecedorEditar.Text);
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            tbxID.Text = dgvRelatorios.CurrentRow.Cells[0].Value.ToString();
            tbxNomeEditar.Text = dgvRelatorios.CurrentRow.Cells[1].Value.ToString();
            tbxCategoriaEditar.Text = dgvRelatorios.CurrentRow.Cells[2].Value.ToString();
            cbbUnidadeEditar.Text = dgvRelatorios.CurrentRow.Cells[3].Value.ToString();
            tbxQuantidadeInicialEditar.Text = dgvRelatorios.CurrentRow.Cells[4].Value.ToString();
            tbxEstoqueMinimoEditar.Text = dgvRelatorios.CurrentRow.Cells[5].Value.ToString();
            tbxFornecedorEditar.Text = dgvRelatorios.CurrentRow.Cells[6].Value.ToString();


        }

        private void dgvRelatorios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            C_CProdutos c_CProdutos = new C_CProdutos();
            String Produtos = cbbTipoRelatorio.Text;
            String MovProdutos = cbbTipoRelatorio.Text;
            String id = dgvRelatorios.CurrentRow.Cells[0].Value.ToString();
            c_CProdutos.DeletarProduto(id, Produtos, MovProdutos);

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
            if (cbbTipoRelatorio.Text == "Produtos")
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
    }
}
