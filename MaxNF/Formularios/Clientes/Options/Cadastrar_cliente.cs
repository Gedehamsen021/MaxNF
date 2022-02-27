using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MaxNF.Formularios.Clientes.Options
{
    public partial class Cadastrar_cliente : Form
    {

        public Cadastrar_cliente()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            //Fecha a janela
            Dispose();
        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            string con = Properties.Settings.Default.notinhasDb;
            //Verifica se o cliente é vazio
            if (fld_cliente.Text != "")
            {
                try
                {
                    //Conecta ao mysql
                    MySqlConnection connection = new MySqlConnection(con);
                    connection.Open();
                    //Criando comando
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    //Parametros do comando
                    cmd.CommandText = $"INSERT into clientes(nome,notas_restantes) VALUES (@nome,@notasR)";
                    cmd.Parameters.AddWithValue("@nome", fld_cliente.Text);
                    cmd.Parameters.AddWithValue("@notasR", fld_quantidade.Value);
                    //Executando a query
                    cmd.ExecuteNonQuery();
                    //Fexando conexão
                    connection.Close();
                    //Mensagem que deu certo
                    MessageBox.Show("Cliente criado com sucesso");
                    //Recarregando grid
                    Clientes.Recarregar();
                    //Resetando fields
                    fld_cliente.Text = "";
                    fld_quantidade.Value = 0;
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
