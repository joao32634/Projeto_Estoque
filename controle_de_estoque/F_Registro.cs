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
    public partial class F_Registro : Form
    {
        public F_Registro()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            string strconn = ("Data Source=SOB041982L4B1PC\\SQLEXPRESS;" +
                        "Initial Catalog=BDESTOQUE;Integrated Security=true");
            SqlConnection conn = new SqlConnection(strconn);
            string sql = "INSERT INTO Cadastro (usuario, email, senha, salt)" +
                "VALUES(@usuario, @email, @senha, @salt)";
            string salt = "";
            string senhahash = "";
            try
            {
                salt = PasswordHelper.GenerateSalt();
                senhahash = PasswordHelper.HashPassword(tbxSenhaR.Text, salt);
                SqlCommand comando = new SqlCommand(sql, conn);
                try
                {
                    comando.Parameters.Add(new SqlParameter("@usuario", tbxUsuarioR.Text));
                    comando.Parameters.Add(new SqlParameter("@email" , tbxEmailR.Text));
                    comando.Parameters.Add(new SqlParameter("@senha", senhahash));
                    comando.Parameters.Add(new SqlParameter("@salt", salt));

                    conn.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastrado com Sucesso!", " cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show("erro 1", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }








            }
            catch
            {
                MessageBox.Show("Não foi possivel cadastrar", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
