
namespace MaxNF.Formularios.Notas
{
    partial class Notas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_arquivados = new System.Windows.Forms.Button();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_alterar_pacote = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel_6 = new System.Windows.Forms.Panel();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasrestantesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            notinhasDataSet = new MaxNF.notinhasDataSet();
            clientesTableAdapter = new MaxNF.notinhasDataSetTableAdapters.clientesTableAdapter();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel_6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(notinhasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.splitter3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this.panel_6);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 35);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_arquivados);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(510, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(159, 35);
            this.panel5.TabIndex = 7;
            // 
            // btn_arquivados
            // 
            this.btn_arquivados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_arquivados.Location = new System.Drawing.Point(0, 0);
            this.btn_arquivados.Name = "btn_arquivados";
            this.btn_arquivados.Size = new System.Drawing.Size(159, 35);
            this.btn_arquivados.TabIndex = 1;
            this.btn_arquivados.Text = "Notas Arquivadas";
            this.btn_arquivados.UseVisualStyleBackColor = true;
            this.btn_arquivados.Click += new System.EventHandler(this.btn_arquivados_Click);
            // 
            // splitter3
            // 
            this.splitter3.Enabled = false;
            this.splitter3.Location = new System.Drawing.Point(499, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(11, 35);
            this.splitter3.TabIndex = 6;
            this.splitter3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_alterar_pacote);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(340, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(159, 35);
            this.panel4.TabIndex = 5;
            // 
            // btn_alterar_pacote
            // 
            this.btn_alterar_pacote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_alterar_pacote.Location = new System.Drawing.Point(0, 0);
            this.btn_alterar_pacote.Name = "btn_alterar_pacote";
            this.btn_alterar_pacote.Size = new System.Drawing.Size(159, 35);
            this.btn_alterar_pacote.TabIndex = 1;
            this.btn_alterar_pacote.Text = "Alterar Pacote";
            this.btn_alterar_pacote.UseVisualStyleBackColor = true;
            this.btn_alterar_pacote.Click += new System.EventHandler(this.btn_alterar_pacote_Click);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(329, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(11, 35);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // panel_6
            // 
            this.panel_6.Controls.Add(this.btn_fechar);
            this.panel_6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_6.Location = new System.Drawing.Point(834, 0);
            this.panel_6.Name = "panel_6";
            this.panel_6.Size = new System.Drawing.Size(37, 35);
            this.panel_6.TabIndex = 3;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_fechar.Location = new System.Drawing.Point(0, 0);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(37, 35);
            this.btn_fechar.TabIndex = 0;
            this.btn_fechar.Text = "X";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_consultar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(170, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(159, 35);
            this.panel3.TabIndex = 2;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_consultar.Location = new System.Drawing.Point(0, 0);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(159, 35);
            this.btn_consultar.TabIndex = 1;
            this.btn_consultar.Text = "Consultar Notas";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // splitter1
            // 
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(159, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(11, 35);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_cadastrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 35);
            this.panel2.TabIndex = 0;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cadastrar.Location = new System.Drawing.Point(0, 0);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(159, 35);
            this.btn_cadastrar.TabIndex = 0;
            this.btn_cadastrar.Text = "Cadastrar Nota";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.notasrestantesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = clientesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 35);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(871, 495);
            this.dataGridView1.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 678;
            // 
            // notasrestantesDataGridViewTextBoxColumn
            // 
            this.notasrestantesDataGridViewTextBoxColumn.DataPropertyName = "Notas_restantes";
            this.notasrestantesDataGridViewTextBoxColumn.HeaderText = "NOTAS RESTANTES";
            this.notasrestantesDataGridViewTextBoxColumn.Name = "notasrestantesDataGridViewTextBoxColumn";
            this.notasrestantesDataGridViewTextBoxColumn.ReadOnly = true;
            this.notasrestantesDataGridViewTextBoxColumn.Width = 140;
            // 
            // clientesBindingSource
            // 
            clientesBindingSource.DataMember = "clientes";
            clientesBindingSource.DataSource = notinhasDataSet;
            // 
            // notinhasDataSet
            // 
            notinhasDataSet.DataSetName = "notinhasDataSet";
            notinhasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            clientesTableAdapter.ClearBeforeFill = true;
            // 
            // Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 530);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notas";
            this.Text = "Notas";
            this.Load += new System.EventHandler(this.Notas_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel_6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(notinhasDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_alterar_pacote;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel_6;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notasrestantesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_arquivados;
        private System.Windows.Forms.Splitter splitter3;
        public static System.Windows.Forms.BindingSource clientesBindingSource;
        public static notinhasDataSet notinhasDataSet;
        public static notinhasDataSetTableAdapters.clientesTableAdapter clientesTableAdapter;
    }
}