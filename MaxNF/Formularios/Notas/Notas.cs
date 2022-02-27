using MaxNF.Classes;
using MaxNF.Formularios.Notas.Options;
using System;
using System.Windows.Forms;

namespace MaxNF.Formularios.Notas
{
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
        }

        private void Notas_Load(object sender, EventArgs e)
        {
            //Carregar a tabela
            Recarregar();
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
            //Fechar formulario
            Dispose();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            //Checka se o cliente é valido
            if (dataGridView1.CurrentRow != null)
            {
                if (Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value) != 0)
                {
                    //Guarda a ID
                    Cliente.instancia.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    Cliente.instancia.Qtd = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
                    //Instancia o formulario Criar_nota
                    Criar_nota criar_Nota = new Criar_nota();
                    criar_Nota.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Cliente não tem mais nenhuma nota disponivel, contate o cliente");
                }
            }
            else
            {
                MessageBox.Show("Nenhum cliente foi selecionado");
            }
        }

        private void btn_alterar_pacote_Click(object sender, EventArgs e)
        {
            //Checka se o cliente é valido
            if (dataGridView1.CurrentRow != null)
            {
                //Guarda a ID
                Cliente.instancia.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Cliente.instancia.Nome = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Cliente.instancia.Qtd = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
                //Instancia o formulario Alterar_Pacote
                Alterar_pacote alterar_Pacote = new Alterar_pacote();
                alterar_Pacote.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhum cliente foi selecionado");
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            Cliente.instancia.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            if (!Principal.pnl_conteudo.HasChildren)
            {
                Consultar_notas consultar = new Consultar_notas() { Dock = DockStyle.Fill, TopLevel = false };
                Principal.pnl_conteudo.Controls.Add(consultar);
                consultar.notasBindingSource.Filter = $"cliente_id = {Cliente.instancia.Id} AND pago = 'N'";
                consultar.Show();
                if (consultar.notasBindingSource.Count == 0)
                {
                    consultar.Dispose();
                    MessageBox.Show("Este cliente não tem nenhuma nota");
                    Principal.pnl_conteudo.Controls.Remove(Principal.pnl_conteudo.GetChildAtPoint(Location));
                    Notas notas = new Notas() { Dock = DockStyle.Fill, TopLevel = false };
                    Principal.pnl_conteudo.Controls.Add(notas);
                    notas.Show();
                }
            }
            else
            {
                Principal.pnl_conteudo.Controls.Remove(Principal.pnl_conteudo.GetChildAtPoint(Location));
                Consultar_notas consultar = new Consultar_notas() { Dock = DockStyle.Fill, TopLevel = false };
                Principal.pnl_conteudo.Controls.Add(consultar);
                consultar.notasBindingSource.Filter = $"cliente_id = {Cliente.instancia.Id} AND pago = 'N'";
                consultar.Show();
                if (consultar.notasBindingSource.Count == 0)
                {
                    consultar.Dispose();
                    MessageBox.Show("Este cliente não tem nenhuma nota");
                    Principal.pnl_conteudo.Controls.Remove(Principal.pnl_conteudo.GetChildAtPoint(Location));
                    Notas notas = new Notas() { Dock = DockStyle.Fill, TopLevel = false };
                    Principal.pnl_conteudo.Controls.Add(notas);
                    notas.Show();
                }
            }
        }

        private void btn_arquivados_Click(object sender, EventArgs e)
        {
            Cliente.instancia.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            if (!Principal.pnl_conteudo.HasChildren)
            {
                Consultar_notas consultar = new Consultar_notas() { Dock = DockStyle.Fill, TopLevel = false };
                Principal.pnl_conteudo.Controls.Add(consultar);
                consultar.notasBindingSource.Filter = $"cliente_id = {Cliente.instancia.Id} AND pago = 'S'";
                consultar.Show();
                if (consultar.notasBindingSource.Count == 0)
                {
                    consultar.Dispose();
                    MessageBox.Show("Este cliente não tem nenhuma nota");
                    Principal.pnl_conteudo.Controls.Remove(Principal.pnl_conteudo.GetChildAtPoint(Location));
                    Notas notas = new Notas() { Dock = DockStyle.Fill, TopLevel = false };
                    Principal.pnl_conteudo.Controls.Add(notas);
                    notas.Show();
                }
            }
            else
            {
                Principal.pnl_conteudo.Controls.Remove(Principal.pnl_conteudo.GetChildAtPoint(Location));
                Consultar_notas consultar = new Consultar_notas() { Dock = DockStyle.Fill, TopLevel = false };
                Principal.pnl_conteudo.Controls.Add(consultar);
                consultar.notasBindingSource.Filter = $"cliente_id = {Cliente.instancia.Id} AND pago = 'S'";
                consultar.Show();
                if (consultar.notasBindingSource.Count == 0)
                {
                    consultar.Dispose();
                    MessageBox.Show("Este cliente não tem nenhuma nota");
                    Principal.pnl_conteudo.Controls.Remove(Principal.pnl_conteudo.GetChildAtPoint(Location));
                    Notas notas = new Notas() { Dock = DockStyle.Fill, TopLevel = false };
                    Principal.pnl_conteudo.Controls.Add(notas);
                    notas.Show();
                }
            }
        }
    }
}
