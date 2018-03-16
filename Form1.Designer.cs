namespace Fiap.PlataformaNet.Avaliacao_44334
{
    partial class Form1
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.txtBoxDescricao = new System.Windows.Forms.TextBox();
            this.txtBoxTelefone = new System.Windows.Forms.TextBox();
            this.btnIncluirPaciente = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnListarTodosTratamentos = new System.Windows.Forms.Button();
            this.btnIncluirTratamento = new System.Windows.Forms.Button();
            this.btnListarTratamentoPaciente = new System.Windows.Forms.Button();
            this.cboBoxPaciente = new System.Windows.Forms.ComboBox();
            this.nupdPreco = new System.Windows.Forms.NumericUpDown();
            this.listBoxRelatorios = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.nupdPreco)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(9, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(14, 158);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(14, 221);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 2;
            this.lblPreco.Text = "Preço";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(14, 131);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(49, 13);
            this.lblPaciente.TabIndex = 3;
            this.lblPaciente.Text = "Paciente";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(9, 46);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 4;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(70, 17);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(278, 20);
            this.txtBoxNome.TabIndex = 5;
            // 
            // txtBoxDescricao
            // 
            this.txtBoxDescricao.Location = new System.Drawing.Point(87, 155);
            this.txtBoxDescricao.Multiline = true;
            this.txtBoxDescricao.Name = "txtBoxDescricao";
            this.txtBoxDescricao.Size = new System.Drawing.Size(248, 58);
            this.txtBoxDescricao.TabIndex = 9;
            // 
            // txtBoxTelefone
            // 
            this.txtBoxTelefone.Location = new System.Drawing.Point(70, 43);
            this.txtBoxTelefone.Name = "txtBoxTelefone";
            this.txtBoxTelefone.Size = new System.Drawing.Size(278, 20);
            this.txtBoxTelefone.TabIndex = 10;
            // 
            // btnIncluirPaciente
            // 
            this.btnIncluirPaciente.Location = new System.Drawing.Point(12, 69);
            this.btnIncluirPaciente.Name = "btnIncluirPaciente";
            this.btnIncluirPaciente.Size = new System.Drawing.Size(336, 23);
            this.btnIncluirPaciente.TabIndex = 11;
            this.btnIncluirPaciente.Text = "Incluir Paciente";
            this.btnIncluirPaciente.UseVisualStyleBackColor = true;
            this.btnIncluirPaciente.Click += new System.EventHandler(this.btnIncluirPaciente_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(374, 397);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(282, 35);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnListarTodosTratamentos
            // 
            this.btnListarTodosTratamentos.Location = new System.Drawing.Point(535, 6);
            this.btnListarTodosTratamentos.Name = "btnListarTodosTratamentos";
            this.btnListarTodosTratamentos.Size = new System.Drawing.Size(121, 115);
            this.btnListarTodosTratamentos.TabIndex = 14;
            this.btnListarTodosTratamentos.Text = "Listar Todos Tratamentos";
            this.btnListarTodosTratamentos.UseVisualStyleBackColor = true;
            this.btnListarTodosTratamentos.Click += new System.EventHandler(this.btnListarTodosTratamentos_ClickAsync);
            // 
            // btnIncluirTratamento
            // 
            this.btnIncluirTratamento.Location = new System.Drawing.Point(17, 245);
            this.btnIncluirTratamento.Name = "btnIncluirTratamento";
            this.btnIncluirTratamento.Size = new System.Drawing.Size(318, 23);
            this.btnIncluirTratamento.TabIndex = 15;
            this.btnIncluirTratamento.Text = "Incluir Tratamento";
            this.btnIncluirTratamento.UseVisualStyleBackColor = true;
            this.btnIncluirTratamento.Click += new System.EventHandler(this.btnIncluirTratamento_Click);
            // 
            // btnListarTratamentoPaciente
            // 
            this.btnListarTratamentoPaciente.Location = new System.Drawing.Point(374, 6);
            this.btnListarTratamentoPaciente.Name = "btnListarTratamentoPaciente";
            this.btnListarTratamentoPaciente.Size = new System.Drawing.Size(128, 115);
            this.btnListarTratamentoPaciente.TabIndex = 16;
            this.btnListarTratamentoPaciente.Text = "Listar Tratamento por Paciente";
            this.btnListarTratamentoPaciente.UseVisualStyleBackColor = true;
            this.btnListarTratamentoPaciente.Click += new System.EventHandler(this.btnListarTratamentoPaciente_Click);
            // 
            // cboBoxPaciente
            // 
            this.cboBoxPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxPaciente.FormattingEnabled = true;
            this.cboBoxPaciente.Location = new System.Drawing.Point(87, 128);
            this.cboBoxPaciente.Name = "cboBoxPaciente";
            this.cboBoxPaciente.Size = new System.Drawing.Size(248, 21);
            this.cboBoxPaciente.TabIndex = 17;
            this.cboBoxPaciente.Enter += new System.EventHandler(this.cboBoxPaciente_Enter);
            // 
            // nupdPreco
            // 
            this.nupdPreco.DecimalPlaces = 2;
            this.nupdPreco.Location = new System.Drawing.Point(87, 219);
            this.nupdPreco.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nupdPreco.Name = "nupdPreco";
            this.nupdPreco.Size = new System.Drawing.Size(247, 20);
            this.nupdPreco.TabIndex = 18;
            // 
            // listBoxRelatorios
            // 
            this.listBoxRelatorios.FormattingEnabled = true;
            this.listBoxRelatorios.Location = new System.Drawing.Point(374, 131);
            this.listBoxRelatorios.Name = "listBoxRelatorios";
            this.listBoxRelatorios.Size = new System.Drawing.Size(282, 225);
            this.listBoxRelatorios.TabIndex = 19;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(374, 368);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(282, 23);
            this.progressBar1.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 437);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.listBoxRelatorios);
            this.Controls.Add(this.nupdPreco);
            this.Controls.Add(this.cboBoxPaciente);
            this.Controls.Add(this.btnListarTratamentoPaciente);
            this.Controls.Add(this.btnIncluirTratamento);
            this.Controls.Add(this.btnListarTodosTratamentos);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnIncluirPaciente);
            this.Controls.Add(this.txtBoxTelefone);
            this.Controls.Add(this.txtBoxDescricao);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Trabalho FIAP";
            ((System.ComponentModel.ISupportInitialize)(this.nupdPreco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.TextBox txtBoxDescricao;
        private System.Windows.Forms.TextBox txtBoxTelefone;
        private System.Windows.Forms.Button btnIncluirPaciente;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnListarTodosTratamentos;
        private System.Windows.Forms.Button btnIncluirTratamento;
        private System.Windows.Forms.Button btnListarTratamentoPaciente;
        private System.Windows.Forms.ComboBox cboBoxPaciente;
        private System.Windows.Forms.NumericUpDown nupdPreco;
        private System.Windows.Forms.ListBox listBoxRelatorios;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

