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
    public partial class F_Compra : Form
    {
        public F_Compra()
        {
            InitializeComponent();
        }

        private void F_Compra_Load(object sender, EventArgs e)
        {
            C_CProdutos c_CProdutos = new C_CProdutos();

            try
            {

                SqlDataReader reader = c_CProdutos.SelecionarNome();

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
    }
}
