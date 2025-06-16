using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle_de_estoque
{
    public partial class F_Movimento_de_Estoque : Form
    {
        public F_Movimento_de_Estoque(F_Controle_de_Estoque f)
        {
            f.Visible = false;
            InitializeComponent();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Relatorios janela = new F_Relatorios(this);
            janela.ShowDialog();
            this.Close();

        }

        private void F_Movimento_de_Estoque_Load(object sender, EventArgs e)
        {

        }
    }
}
