using MaxNF.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MaxNF.Formularios.Clientes.Options
{
    public partial class Alterar_cliente : Form
    {
        public Alterar_cliente()
        {
            InitializeComponent();
            fld_cliente.Text = Cliente.instancia.Nome;
            fld_quantidade.Value = Cliente.instancia.Qtd;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            //Fechar form
            Dispose();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var box = MessageBox.Show("Deseja realmente excluir este cliente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (box == DialogResult.Yes)
            {
                try
                {
                    string con = Properties.Settings.Default.notinhasDb;
                    //Conecta ao mysql
                    MySqlConnection connection = new MySqlConnection(con);
                    connection.Open();
                    //Criando comando
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"DELETE FROM clientes WHERE id = @id";
                    //Parametros do comando
                    cmd.Parameters.AddWithValue("@id", Cliente.instancia.Id);
                    //Executando a query
                    cmd.ExecuteNonQuery();
                    //Fexando conexão
                    connection.Close();
                    //Mensagem que deu certo
                    MessageBox.Show("Cliente deletado com sucesso");
                    //Recarregar view
                    Clientes.Recarregar();
                    //Fechar janela
                    Dispose();
                }
                catch (Exception ex)
                {
#if DEBUG
                    MessageBox.Show(ex.ToString());
#endif
                    MessageBox.Show("Este cliente não pode ser deletado pois possui notas registradas", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            if (fld_cliente.Text != "")
            {
                try
                {
                    string con = Properties.Settings.Default.notinhasDb;
                    //Conecta ao mysql
                    MySqlConnection connection = new MySqlConnection(con);
                    connection.Open();
                    //Criando comando
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"Update clientes SET nome = @nome WHERE id = @id";
                    //Parametros do comando
                    cmd.Parameters.AddWithValue("@nome", fld_cliente.Text);
                    cmd.Parameters.AddWithValue("@id", Cliente.instancia.Id);
                    //Executando a query
                    cmd.ExecuteNonQuery();
                    //Fexando conexão
                    connection.Close();
                    //Menssagem que deu certo
                    MessageBox.Show("Cliente alterado com sucesso");
                    //Recarregar view
                    Clientes.Recarregar();
                    //Fechar janela
                    Dispose();
                }
                catch (Exception ex)
                {
#if DEBUG
                    MessageBox.Show(ex.ToString());
#endif
                }
            }
            else
            {
                MessageBox.Show("Nome ou empresa não informado");
            }
        }
    }
}
