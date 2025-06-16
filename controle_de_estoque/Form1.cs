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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            F_senharecuperar janelarecuperar = new F_senharecuperar();
            janelarecuperar.ShowDialog();
        }

        private void lblinkCriarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            F_Registro janela = new F_Registro();
            janela.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string usuario = tbxusuario.Text;
            string senha = tbxsenha.Text;


            string strconn = ("Data Source=SOB041982L4B1PC\\SQLEXPRESS;" +
                "Initial Catalog=BDESTOQUE;Integrated Security=true");
            SqlConnection conn = new SqlConnection(strconn);
            try
            {
                conn.Open();
                string sql = "Select senha, salt FROM Cadastro " +
                    "WHERE usuario = @usuario";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@usuario", usuario);
                //cmd.ExecuteReader - comando para realizar a leitura no banco de dados
                using (SqlDataReader reader = cmd.ExecuteReader())
                {   //verifica se retornou algum valor do banco de dados
                    if (reader.Read())
                    {
                        //reade.GetString(0) - retorna a string da coluna zero
                        //retornada do banco de dados
                        string senhaHashBanco = reader.GetString(0);
                        string saltBanco = reader.GetString(1);
                        //remove espaços em branco
                        saltBanco = saltBanco.Replace(" ", "");

                        string senhaHashDigitada = PasswordHelper.HashPassword(senha, saltBanco);

                        senhaHashBanco = senhaHashBanco.Replace(" ", "");
                        senhaHashDigitada = senhaHashDigitada.Replace(" ", "");
                        if (senhaHashDigitada == senhaHashBanco)
                        {
                            F_Controle_de_Estoque janelaEstoque = new F_Controle_de_Estoque(this);
                            janelaEstoque.ShowDialog();
                            this.Close();
                            


                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha inválidos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

            





