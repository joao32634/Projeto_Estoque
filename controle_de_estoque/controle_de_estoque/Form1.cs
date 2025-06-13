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
    }
}
