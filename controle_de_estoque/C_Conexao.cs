using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace controle_de_estoque
{
    public class C_Conexao
    {


        public SqlConnection AbrirConexao()
        {
            string strconn = ("Data Source=SOB041982L4B1PC\\SQLEXPRESS;" +
    "Initial Catalog=BDESTOQUE;Integrated Security=true");
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            
            return conn;

        }
        public string modificarDados(SqlCommand c, SqlConnection conn)
        {
            try
            {
                
                c.ExecuteNonQuery();
                conn.Close();
                return "ok";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "erro";
            }
        }
        public SqlDataAdapter SelecionarDados(string c, SqlConnection conn)
        {
            SqlDataAdapter da = new SqlDataAdapter(c, conn);
            return da;
        }
        public SqlDataReader SelecionarDadosReader(string c, SqlConnection conn)
        {
            
            SqlCommand command = new SqlCommand(c, conn);
            SqlDataReader reader = command.ExecuteReader();
            
            return reader;
        }


    }
}
