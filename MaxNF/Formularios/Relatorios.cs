using System;
using System.Windows.Forms;

namespace MaxNF.Formularios
{
    public partial class Relatorios : Form
    {
        public Relatorios()
        {
            InitializeComponent();
        }

        private void Relatorios_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
