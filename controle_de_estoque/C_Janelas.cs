using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controle_de_estoque
{
    public static class C_Janelas
    {
        public static F_Controle_de_Estoque f_Controle_De_Estoque = new F_Controle_de_Estoque();
        public static F_Movimento_de_Estoque f_movimento_de_estoque = new F_Movimento_de_Estoque();
        public static F_Relatorios f_relatorios = new F_Relatorios();
        public static void Visivel(F_Controle_de_Estoque fControle, F_Movimento_de_Estoque fMovimento, F_Relatorios fRelatorios)
        {
            
            fControle.Visible = true;
            fRelatorios.Visible = true;
            fMovimento.Visible = true;
            
            
            

        }
        public static void Invisivel(Form1 Login)
        {
            Login.Visible = false;
        }
    }
}
