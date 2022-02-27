using MaxNF.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MaxNF.Formularios.Notas.Options
{
    public partial class Alterar_pacote : Form
    {
        public Alterar_pacote()
        {
            InitializeComponent();
            fld_cliente.Text = Cliente.instancia.Nome;
            num_field.Value = Cliente.instancia.Qtd;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            //Fechar aplicação
            Dispose();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            string con = Properties.Settings.Default.notinhasDb;
            var msg = MessageBox.Show("Deseja alterar este pacote?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
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
                    cmd.CommandText = $"UPDATE clientes SET notas_restantes=@nrestante WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", Cliente.instancia.Id);
                    cmd.Parameters.AddWithValue("@nrestante", num_field.Value);
                    //Executando a query
                    cmd.ExecuteNonQuery();
                    //Fexando conexão
                    connection.Close();
                    //Avisando que ocorreu tudo bem
                    MessageBox.Show("Pacote Atualizado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Fechando
                    Dispose();
                    //Recarregando grid
                    Notas.Recarregar();
                }
                catch (Exception ex)
                {
#if DEBUG
                    MessageBox.Show(ex.ToString());
#endif
                }
            }
        }
    }
}
