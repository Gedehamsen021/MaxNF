
namespace MaxNF
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_sair = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_notas = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            pnl_conteudo = new System.Windows.Forms.Panel();
            this.pnl_menu.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.White;
            this.pnl_menu.Controls.Add(this.panel6);
            this.pnl_menu.Controls.Add(this.panel4);
            this.pnl_menu.Controls.Add(this.panel3);
            this.pnl_menu.Controls.Add(this.panel2);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(200, 530);
            this.pnl_menu.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_sair);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 472);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 58);
            this.panel6.TabIndex = 4;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_sair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_sair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_sair.Location = new System.Drawing.Point(0, 0);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(200, 58);
            this.btn_sair.TabIndex = 0;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_notas);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 196);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 52);
            this.panel4.TabIndex = 2;
            // 
            // btn_notas
            // 
            this.btn_notas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_notas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_notas.FlatAppearance.BorderSize = 0;
            this.btn_notas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_notas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_notas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_notas.Location = new System.Drawing.Point(0, 0);
            this.btn_notas.Name = "btn_notas";
            this.btn_notas.Size = new System.Drawing.Size(200, 52);
            this.btn_notas.TabIndex = 0;
            this.btn_notas.Text = "Notas";
            this.btn_notas.UseVisualStyleBackColor = false;
            this.btn_notas.Click += new System.EventHandler(this.btn_notas_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_cadastro);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 52);
            this.panel3.TabIndex = 1;
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cadastro.FlatAppearance.BorderSize = 0;
            this.btn_cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_cadastro.Location = new System.Drawing.Point(0, 0);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(200, 52);
            this.btn_cadastro.TabIndex = 0;
            this.btn_cadastro.Text = "Clientes";
            this.btn_cadastro.UseVisualStyleBackColor = false;
            this.btn_cadastro.Click += new System.EventHandler(this.btn_cadastro_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 144);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // pnl_conteudo
            // 
            pnl_conteudo.BackColor = System.Drawing.Color.WhiteSmoke;
            pnl_conteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_conteudo.Location = new System.Drawing.Point(200, 0);
            pnl_conteudo.Name = "pnl_conteudo";
            pnl_conteudo.Size = new System.Drawing.Size(871, 530);
            pnl_conteudo.TabIndex = 1;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 530);
            this.Controls.Add(pnl_conteudo);
            this.Controls.Add(this.pnl_menu);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnl_menu.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_cadastro;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_notas;
        public static System.Windows.Forms.Panel pnl_conteudo;
    }
}

