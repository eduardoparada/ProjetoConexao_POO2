using Aula_1_POO_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_1_POO_2
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        Form tela;

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            tela = new TelaCliente
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,

            };
            pl_Principal.Controls.Add(tela);
            tela.Show();

        }

        private void btn_produto_principal_Click(object sender, EventArgs e)
        {
            tela?.Close();
            tela = new TelaProduto
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            pl_Principal.Controls.Add(tela);
            tela.Show();
        }

        private void btn_fornecedor_principal_Click(object sender, EventArgs e)
        {
            tela?.Close();
            tela = new TelaFornecedor
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            pl_Principal.Controls.Add(tela);
            tela.Show();
        }
        //    public void limpar_tela()
        //    {
        //       if (btn_cliente.Click = true || btn)
        //        tela.Close();
        //    }
        //}
    }
}

