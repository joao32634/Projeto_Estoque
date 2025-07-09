using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle_de_estoque
{
    internal class C_Usuario
    {    
        private int id;
        private string usuario;
        private string senha;
        private string salt;
        private string email;
        private C_Conexao C_Conexao = new C_Conexao();

        public void cadastrarUsuario(string u, string se, string email)
        {
            SqlConnection conn = C_Conexao.AbrirConexao();
            string sql = "INSERT INTO Cadastro (usuario, email, senha, salt)" +
                      "VALUES(@usuario, @email, @senha, @salt)";
            string salt = "";
            string senhahash = "";
            
            try
            {
                salt = PasswordHelper.GenerateSalt();
                senhahash = PasswordHelper.HashPassword(se, salt);
                SqlCommand comando = new SqlCommand(sql, conn);
                try
                {
                    comando.Parameters.Add(new SqlParameter("@usuario", u));
                    comando.Parameters.Add(new SqlParameter("@email", email));
                    comando.Parameters.Add(new SqlParameter("@senha", senhahash));
                    comando.Parameters.Add(new SqlParameter("@salt", salt));

                    
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastrado com Sucesso!", " cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
