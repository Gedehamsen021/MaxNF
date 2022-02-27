using MaxNF.Classes;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace MaxNF.Formularios.Notas.Options
{
    public partial class Consultar_notas : Form
    {

        List<Nota> relData = new List<Nota>();

        bool selecionado = false;
        public Consultar_notas()
        {
            InitializeComponent();
        }

        private void Consultar_notas_Load(object sender, EventArgs e)
        {
            //Carregar tabela
            notasTableAdapter.Fill(notinhasDataSet.notas);
        }

        public void Recarregar()
        {
            //Recarregar
            notasTableAdapter.Fill(notinhasDataSet.notas);
        }
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            //Fechar formulario
            Dispose();
        }

        private void btn_alt_nota_Click(object sender, EventArgs e)
        {
            Nota nota = new Nota();
            string con = Properties.Settings.Default.notinhasDb;
            var msg = MessageBox.Show("Deseja alterar a condição destas notas?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (msg == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == false && selecionado == false)
                    {
                        MessageBox.Show("Nenhuma nota selecionada");
                        return;
                    }
                    else
                    {
                        selecionado = true;
                    }
                    if (selecionado == true && Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        nota.Id = Convert.ToInt32(dataGridView1.Rows[row.Index].Cells[1].Value);
                        if (dataGridView1.Rows[row.Index].Cells[4].Value.ToString() == "N")
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
                                cmd.CommandText = $"UPDATE notas SET pago = @pago WHERE id = @id";
                                cmd.Parameters.AddWithValue("@id", nota.Id);
                                cmd.Parameters.AddWithValue("@pago", "S");
                                //Executando a query
                                cmd.ExecuteNonQuery();
                                //Fexando conexão
                                connection.Close();

                            }
                            catch (Exception ex)
                            {
#if DEBUG
                                MessageBox.Show(ex.ToString());
#endif
                                MessageBox.Show("Erro ao acessar o banco de dados");
                            }
                        }
                        if (dataGridView1.Rows[row.Index].Cells[4].Value.ToString() == "S")
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
                                cmd.CommandText = $"UPDATE notas SET pago = @pago WHERE id = @id";
                                cmd.Parameters.AddWithValue("@id", nota.Id);
                                cmd.Parameters.AddWithValue("@pago", "N");
                                //Executando a query
                                cmd.ExecuteNonQuery();
                                //Fexando conexão
                                connection.Close();
                            }
                            catch (Exception ex)
                            {
#if DEBUG
                                MessageBox.Show(ex.ToString());
#endif
                                MessageBox.Show("Erro ao acessar o banco de dados");
                            }
                        }
                    }
                }
                MessageBox.Show("Notas alteradas");
                //Recarregando grid
                Recarregar();
                selecionado = false;
                return;
            }
        }

        private void btn_gerar_pagamento_Click(object sender, EventArgs e)
        {
            Relatorios rel = new Relatorios();
            var msg = MessageBox.Show("Deseja gerar o pagamento destas notas?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                string con = Properties.Settings.Default.notinhasDb;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {

                        Nota nota = new Nota();
                        nota.Numeracao = Convert.ToInt32(dataGridView1.Rows[row.Index].Cells[2].Value);
                        nota.Tipo = dataGridView1.Rows[row.Index].Cells[3].Value.ToString();
                        nota.Data = Convert.ToDateTime(dataGridView1.Rows[row.Index].Cells[5].Value).ToString("dd-MM-yyyy");
                        relData.Add(nota);
                        if (Convert.ToBoolean(row.Cells[0].Value) == false && selecionado == false)
                        {
                            MessageBox.Show("Nenhuma nota selecionada");
                            return;
                        }
                        else
                        {
                            selecionado = true;
                        }
                        if (selecionado == true && Convert.ToBoolean(row.Cells[0].Value) == true)
                        {
                            nota.Id = Convert.ToInt32(dataGridView1.Rows[row.Index].Cells[1].Value);
                            if (dataGridView1.Rows[row.Index].Cells[4].Value.ToString() == "N")
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
                                    cmd.CommandText = $"UPDATE notas SET pago = @pago WHERE id = @id";
                                    cmd.Parameters.AddWithValue("@id", nota.Id);
                                    cmd.Parameters.AddWithValue("@pago", "S");
                                    //Executando a query
                                    cmd.ExecuteNonQuery();
                                    //Fexando conexão
                                    connection.Close();

                                }
                                catch (Exception ex)
                                {
#if DEBUG
                                        MessageBox.Show(ex.ToString());
#endif
                                    MessageBox.Show("Erro ao acessar o banco de dados");
                                }
                            }
                        }
                    }
                }
                rel.reportViewer1.LocalReport.DataSources.Clear();
                rel.reportViewer1.LocalReport.ReportEmbeddedResource = "MaxNF.Pagamento.rdlc";
                rel.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", relData));
                rel.ShowDialog();
                relData.Clear();
                Recarregar();
            }
        }
    }
}
