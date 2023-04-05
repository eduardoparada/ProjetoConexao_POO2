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
    public partial class TelaCliente : Form
    {
        public TelaCliente()
        {
            InitializeComponent();
        }

        Conexao con = new Conexao();

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                string sql = "insert into tb_cliente values (null, '" + nome_txt.Text + "', '" + cpf_txt.Text + "','"
                + tel_txt.Text + "');";
                if (con.Executar(sql))
                {
                    MessageBox.Show("Cadastrado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro no cadastro");
                }
                limpar();
            }
            else
            {
                string sql = "update tb_cliente set cli_cpf='" + cpf_txt.Text + "', cli_nome='" + nome_txt.Text +
                    "',cli_celular ='" + tel_txt.Text + "' where cli_id=" + txt_id.Text;
                if (con.Executar(sql))
                {
                    MessageBox.Show("Atualizado com sucesso!");

                }
                else
                {
                    MessageBox.Show("Não atualizado!");
                }
                limpar();
            }
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DataTable dados = con.Retorna(
                    "select * from tb_cliente where cli_id=" +
                    txt_id.Text);
                cpf_txt.Text = dados.Rows[0]["cli_cpf"].ToString();
                tel_txt.Text = dados.Rows[0]["cli_tel"].ToString();
                nome_txt.Text = dados.Rows[0]["cli_nome"].ToString();

            }
        }
        public void limpar()
        {
            txt_id.Text = "";
            nome_txt.Text = "";
            cpf_txt.Text = null;
            tel_txt= null;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            string sql = "delete from tb_cliente where cli_id=" + txt_id.Text;
            if (con.Executar(sql))
            {
                MessageBox.Show("Excluido com sucesso!");

            }
            else
            {
                MessageBox.Show("Erro ao excluir");
            }
        } /////// criar BD da aula e tabelas ---> conectar ao banco de dados
    }
}
