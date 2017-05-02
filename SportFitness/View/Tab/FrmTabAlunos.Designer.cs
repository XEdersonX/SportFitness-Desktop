namespace SportFitness.View
{
    partial class FrmTabAlunos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTabAlunos));
            this.textPesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btIncluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.dataGridViewAlunos = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnidEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefoneRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefoneCel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnObservacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // textPesquisa
            // 
            this.textPesquisa.Location = new System.Drawing.Point(63, 248);
            this.textPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.textPesquisa.Name = "textPesquisa";
            this.textPesquisa.Size = new System.Drawing.Size(242, 20);
            this.textPesquisa.TabIndex = 5;
            this.textPesquisa.TextChanged += new System.EventHandler(this.textPesquisa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 251);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pesquisa:";
            // 
            // btIncluir
            // 
            this.btIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btIncluir.Image")));
            this.btIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIncluir.Location = new System.Drawing.Point(348, 240);
            this.btIncluir.Margin = new System.Windows.Forms.Padding(2);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(114, 35);
            this.btIncluir.TabIndex = 1;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.butIncluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btAlterar.Image")));
            this.btAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAlterar.Location = new System.Drawing.Point(461, 240);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(114, 35);
            this.btAlterar.TabIndex = 2;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.butAlterar_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btDeletar.Image")));
            this.btDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDeletar.Location = new System.Drawing.Point(574, 240);
            this.btDeletar.Margin = new System.Windows.Forms.Padding(2);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(114, 35);
            this.btDeletar.TabIndex = 3;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // dataGridViewAlunos
            // 
            this.dataGridViewAlunos.AllowUserToAddRows = false;
            this.dataGridViewAlunos.AllowUserToDeleteRows = false;
            this.dataGridViewAlunos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.nome1,
            this.ColumnidEstado,
            this.ColumnNome,
            this.ColumnIdCidade,
            this.ColumnEmail,
            this.ColumnTelefoneRes,
            this.ColumnTelefoneCel,
            this.ColumnDataNasc,
            this.ColumnCpf,
            this.ColumnCep,
            this.ColumnEndereco,
            this.ColumnBairro,
            this.ColumnCidade,
            this.ColumnObservacao,
            this.ColumnSenha,
            this.ColumnIdUsuario,
            this.sexo});
            this.dataGridViewAlunos.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAlunos.Name = "dataGridViewAlunos";
            this.dataGridViewAlunos.ReadOnly = true;
            this.dataGridViewAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAlunos.Size = new System.Drawing.Size(675, 223);
            this.dataGridViewAlunos.TabIndex = 6;
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "id_aluno";
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // nome1
            // 
            this.nome1.DataPropertyName = "nome1";
            this.nome1.HeaderText = "nome1";
            this.nome1.Name = "nome1";
            this.nome1.ReadOnly = true;
            this.nome1.Visible = false;
            // 
            // ColumnidEstado
            // 
            this.ColumnidEstado.DataPropertyName = "idEstado";
            this.ColumnidEstado.HeaderText = "Estado";
            this.ColumnidEstado.Name = "ColumnidEstado";
            this.ColumnidEstado.ReadOnly = true;
            this.ColumnidEstado.Visible = false;
            // 
            // ColumnNome
            // 
            this.ColumnNome.DataPropertyName = "nome";
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 325;
            // 
            // ColumnIdCidade
            // 
            this.ColumnIdCidade.DataPropertyName = "id_cidade";
            this.ColumnIdCidade.HeaderText = "cidade2";
            this.ColumnIdCidade.Name = "ColumnIdCidade";
            this.ColumnIdCidade.ReadOnly = true;
            this.ColumnIdCidade.Visible = false;
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.DataPropertyName = "email";
            this.ColumnEmail.HeaderText = "Email";
            this.ColumnEmail.Name = "ColumnEmail";
            this.ColumnEmail.ReadOnly = true;
            this.ColumnEmail.Width = 230;
            // 
            // ColumnTelefoneRes
            // 
            this.ColumnTelefoneRes.DataPropertyName = "telefoneRes";
            this.ColumnTelefoneRes.HeaderText = "Telefone Residencial";
            this.ColumnTelefoneRes.Name = "ColumnTelefoneRes";
            this.ColumnTelefoneRes.ReadOnly = true;
            // 
            // ColumnTelefoneCel
            // 
            this.ColumnTelefoneCel.DataPropertyName = "telefoneCel";
            this.ColumnTelefoneCel.HeaderText = "Telefone Celular";
            this.ColumnTelefoneCel.Name = "ColumnTelefoneCel";
            this.ColumnTelefoneCel.ReadOnly = true;
            // 
            // ColumnDataNasc
            // 
            this.ColumnDataNasc.DataPropertyName = "dataNasc";
            this.ColumnDataNasc.HeaderText = "Data Nascimento";
            this.ColumnDataNasc.Name = "ColumnDataNasc";
            this.ColumnDataNasc.ReadOnly = true;
            // 
            // ColumnCpf
            // 
            this.ColumnCpf.DataPropertyName = "cpf";
            this.ColumnCpf.HeaderText = "CPF";
            this.ColumnCpf.Name = "ColumnCpf";
            this.ColumnCpf.ReadOnly = true;
            // 
            // ColumnCep
            // 
            this.ColumnCep.DataPropertyName = "cep";
            this.ColumnCep.HeaderText = "CEP";
            this.ColumnCep.Name = "ColumnCep";
            this.ColumnCep.ReadOnly = true;
            // 
            // ColumnEndereco
            // 
            this.ColumnEndereco.DataPropertyName = "endereco";
            this.ColumnEndereco.HeaderText = "Endereco";
            this.ColumnEndereco.Name = "ColumnEndereco";
            this.ColumnEndereco.ReadOnly = true;
            // 
            // ColumnBairro
            // 
            this.ColumnBairro.DataPropertyName = "bairro";
            this.ColumnBairro.HeaderText = "Bairro";
            this.ColumnBairro.Name = "ColumnBairro";
            this.ColumnBairro.ReadOnly = true;
            // 
            // ColumnCidade
            // 
            this.ColumnCidade.DataPropertyName = "idCidade";
            this.ColumnCidade.HeaderText = "Cidade";
            this.ColumnCidade.Name = "ColumnCidade";
            this.ColumnCidade.ReadOnly = true;
            this.ColumnCidade.Visible = false;
            // 
            // ColumnObservacao
            // 
            this.ColumnObservacao.DataPropertyName = "observacao";
            this.ColumnObservacao.HeaderText = "Observacao";
            this.ColumnObservacao.Name = "ColumnObservacao";
            this.ColumnObservacao.ReadOnly = true;
            this.ColumnObservacao.Visible = false;
            // 
            // ColumnSenha
            // 
            this.ColumnSenha.DataPropertyName = "senha";
            this.ColumnSenha.HeaderText = "Senha";
            this.ColumnSenha.Name = "ColumnSenha";
            this.ColumnSenha.ReadOnly = true;
            this.ColumnSenha.Visible = false;
            // 
            // ColumnIdUsuario
            // 
            this.ColumnIdUsuario.DataPropertyName = "idUsuario";
            this.ColumnIdUsuario.HeaderText = "Usuario";
            this.ColumnIdUsuario.Name = "ColumnIdUsuario";
            this.ColumnIdUsuario.ReadOnly = true;
            this.ColumnIdUsuario.Visible = false;
            // 
            // sexo
            // 
            this.sexo.DataPropertyName = "sexo";
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            this.sexo.Visible = false;
            // 
            // FrmTabAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(699, 281);
            this.Controls.Add(this.dataGridViewAlunos);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmTabAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alunos";
            this.Activated += new System.EventHandler(this.FrmTabAlunos_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTabClientes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textPesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.DataGridView dataGridViewAlunos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnidEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefoneRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefoneCel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnObservacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSenha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
    }
}