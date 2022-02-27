using MaxNF.Formularios.Clientes;
using MaxNF.Formularios.Notas;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MaxNF
{
    public partial class Principal : Form
    {

        List<Form> forms = new List<Form>();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Principal()
        {
            InitializeComponent();
        }

        private bool CheckisOpen(string name)
        {
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Text == name)
                {
                    return true;
                }
            }
            return false;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            if (!pnl_conteudo.HasChildren)
            {
                Clientes clientes = new Clientes() { Dock = DockStyle.Fill, TopLevel = false };
                pnl_conteudo.Controls.Add(clientes);
                clientes.Show();
            }
            else
            {
                pnl_conteudo.Controls.Remove(pnl_conteudo.GetChildAtPoint(Location));
                Clientes clientes = new Clientes() { Dock = DockStyle.Fill, TopLevel = false };
                pnl_conteudo.Controls.Add(clientes);
                clientes.Show();
            }
        }

        private void btn_notas_Click(object sender, EventArgs e)
        {
            if (!pnl_conteudo.HasChildren)
            {
                Notas notas = new Notas() { Dock = DockStyle.Fill, TopLevel = false };
                pnl_conteudo.Controls.Add(notas);
                notas.Show();
            }
            else
            {
                pnl_conteudo.Controls.Remove(pnl_conteudo.GetChildAtPoint(Location));
                Notas notas = new Notas() { Dock = DockStyle.Fill, TopLevel = false };
                pnl_conteudo.Controls.Add(notas);
                notas.Show();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
