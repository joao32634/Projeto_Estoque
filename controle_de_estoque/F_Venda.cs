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
    public partial class F_Venda : Form
    {
        public F_Venda()
        {
            InitializeComponent();
        }

        private void F_Venda_Load(object sender, EventArgs e)
        {
            C_CProdutos c_CProdutos = new C_CProdutos();
            try
            {

                SqlDataReader reader = c_CProdutos.SelecionarNome();

                while (reader.Read())
                {
                    string id = reader["id"].ToString().Trim();
                    string Nome = reader["Nome"].ToString().Trim();
                    string idNome = $"{id} - {Nome}";

                    cbbProduto.Items.Add(idNome);
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
    }
}
