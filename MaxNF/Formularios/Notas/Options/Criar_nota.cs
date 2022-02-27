using MaxNF.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MaxNF.Formularios.Notas.Options
{
    public partial class Criar_nota : Form
    {
        public Criar_nota()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            //Fechar formulario
            Dispose();
        }

        private void btn_gerar_Click(object sender, EventArgs e)
        {
            if (cmb_field.Text != "")
            {
                try
                {
                    string con = Properties.Settings.Default.notinhasDb;
                    //Cria conexão
                    MySqlConnection connection = new MySqlConnection(con);
                    connection.Open();
                    //Cria os comandos
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"INSERT into notas(cliente_id,tipo,pago,numeracao,data) VALUES (@id,@tipo,@pago,@numeracao,@data)";
                    //Parametros dos comandos
                    cmd.Parameters.AddWithValue("@id", Cliente.instancia.Id);
                    cmd.Parameters.AddWithValue("@tipo", cmb_field.Text);
                    if (chk_box.Checked)
                    {
                        cmd.Parameters.AddWithValue("@pago", "S");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@pago", "N");
                    }
                    cmd.Parameters.AddWithValue("@numeracao", num_field.Value);
                    cmd.Parameters.AddWithValue("@data", DateTime.Now);
                    //Executando a query
                    cmd.ExecuteNonQuery();
                    //Executando outro comando
                    cmd.CommandText = $"UPDATE clientes set notas_restantes = @restante where id = @id";
                    //Parametro do segundo comando
                    cmd.Parameters.AddWithValue("@restante", Cliente.instancia.Qtd - 1);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    //Mensagem que deu certo
                    MessageBox.Show("Nota criada com sucesso");
                    //Atualiza a tabela notas
                    Notas.Recarregar();
                    //Fecha janela
                    Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Tipo de nota invalida");
            }
        }
    }
}
