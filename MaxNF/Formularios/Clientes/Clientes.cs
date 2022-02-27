using MaxNF.Classes;
using MaxNF.Formularios.Clientes.Options;
using System;
using System.Windows.Forms;

namespace MaxNF.Formularios.Clientes
{
    public partial class Clientes : Form
    {

        public Clientes()
        {
            InitializeComponent();
        }

        public static void Recarregar()
        {
            //Recarrega a tabela
            try
            {
                clientesTableAdapter.Fill(notinhasDataSet.clientes);
            }
            catch (Exception)
            {
                MessageBox.Show("MYSQL não está respondendo");
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            //Fecha a janela
            Dispose();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            //Atualiza quando inicia o form
            Recarregar();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            //Ao clickar instancia Cadastrar_Cliente
            Cadastrar_cliente cadastrar = new Cadastrar_cliente();
            //Seta o formulario de cadastro como dialog
            cadastrar.ShowDialog();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            //Atualiza tabela
            Recarregar();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            //Atribui valores a classe cliente
            Cliente.instancia.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Cliente.instancia.Nome = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Cliente.instancia.Qtd = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            //Ao clickar instancia Alterar_cliente
            Alterar_cliente alterar = new Alterar_cliente();
            //Seta o formulario de alteração como dialog
            alterar.ShowDialog();
        }
    }
}
