namespace SportFitness.View.Tab
{
    partial class FrmTabTreinos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTabTreinos));
            this.dataGridViewTreinos = new System.Windows.Forms.DataGridView();
            this.btIncluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textPesquisa = new System.Windows.Forms.TextBox();
            this.id_planoTreino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTreinador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idObjetivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vezesSemana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_fichaTreino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlanoTreino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFicha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_fichaDetalhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFichaTreino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idExercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.series = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repeticoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroTreinosRealizados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneCel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTreinos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTreinos
            // 
            this.dataGridViewTreinos.AllowUserToAddRows = false;
            this.dataGridViewTreinos.AllowUserToDeleteRows = false;
            this.dataGridViewTreinos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewTreinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTreinos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_planoTreino,
            this.nome,
            this.idAluno,
            this.idTreinador,
            this.idObjetivo,
            this.dataInicio,
            this.vezesSemana,
            this.id_fichaTreino,
            this.idPlanoTreino,
            this.nomeFicha,
            this.id_fichaDetalhe,
            this.idFichaTreino,
            this.idExercicio,
            this.series,
            this.repeticoes,
            this.carga,
            this.situacao,
            this.numeroTreinosRealizados,
            this.situacao1,
            this.id_aluno,
            this.email,
            this.telefoneRes,
            this.telefoneCel,
            this.dataNasc,
            this.cpf,
            this.idCidade,
            this.cep,
            this.endereco,
            this.bairro,
            this.observacao,
            this.senha,
            this.idUsuario,
            this.sexo});
            this.dataGridViewTreinos.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTreinos.Name = "dataGridViewTreinos";
            this.dataGridViewTreinos.ReadOnly = true;
            this.dataGridViewTreinos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTreinos.Size = new System.Drawing.Size(663, 207);
            this.dataGridViewTreinos.TabIndex = 0;
            // 
            // btIncluir
            // 
            this.btIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btIncluir.Image")));
            this.btIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIncluir.Location = new System.Drawing.Point(335, 224);
            this.btIncluir.Margin = new System.Windows.Forms.Padding(2);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(114, 35);
            this.btIncluir.TabIndex = 2;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btAlterar.Image")));
            this.btAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAlterar.Location = new System.Drawing.Point(448, 224);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(114, 35);
            this.btAlterar.TabIndex = 3;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btDeletar.Image")));
            this.btDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDeletar.Location = new System.Drawing.Point(561, 224);
            this.btDeletar.Margin = new System.Windows.Forms.Padding(2);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(114, 35);
            this.btDeletar.TabIndex = 4;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 235);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Pesquisa:";
            // 
            // textPesquisa
            // 
            this.textPesquisa.Location = new System.Drawing.Point(63, 232);
            this.textPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.textPesquisa.Name = "textPesquisa";
            this.textPesquisa.Size = new System.Drawing.Size(242, 20);
            this.textPesquisa.TabIndex = 15;
            this.textPesquisa.TextChanged += new System.EventHandler(this.textPesquisa_TextChanged);
            // 
            // id_planoTreino
            // 
            this.id_planoTreino.DataPropertyName = "id_planoTreino";
            this.id_planoTreino.HeaderText = "ID";
            this.id_planoTreino.Name = "id_planoTreino";
            this.id_planoTreino.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Aluno";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 518;
            // 
            // idAluno
            // 
            this.idAluno.DataPropertyName = "idAluno";
            this.idAluno.HeaderText = "idAluno";
            this.idAluno.Name = "idAluno";
            this.idAluno.ReadOnly = true;
            this.idAluno.Visible = false;
            // 
            // idTreinador
            // 
            this.idTreinador.DataPropertyName = "idTreinador";
            this.idTreinador.HeaderText = "idTreinador";
            this.idTreinador.Name = "idTreinador";
            this.idTreinador.ReadOnly = true;
            this.idTreinador.Visible = false;
            // 
            // idObjetivo
            // 
            this.idObjetivo.DataPropertyName = "idObjetivo";
            this.idObjetivo.HeaderText = "idObjetivo";
            this.idObjetivo.Name = "idObjetivo";
            this.idObjetivo.ReadOnly = true;
            this.idObjetivo.Visible = false;
            // 
            // dataInicio
            // 
            this.dataInicio.DataPropertyName = "dataInicio";
            this.dataInicio.HeaderText = "Data Inicio";
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.ReadOnly = true;
            this.dataInicio.Visible = false;
            // 
            // vezesSemana
            // 
            this.vezesSemana.DataPropertyName = "vezesSemana";
            this.vezesSemana.HeaderText = "Vezes Semana";
            this.vezesSemana.Name = "vezesSemana";
            this.vezesSemana.ReadOnly = true;
            this.vezesSemana.Visible = false;
            // 
            // id_fichaTreino
            // 
            this.id_fichaTreino.DataPropertyName = "id_fichaTreino";
            this.id_fichaTreino.HeaderText = "ID";
            this.id_fichaTreino.Name = "id_fichaTreino";
            this.id_fichaTreino.ReadOnly = true;
            this.id_fichaTreino.Visible = false;
            // 
            // idPlanoTreino
            // 
            this.idPlanoTreino.DataPropertyName = "idPlanoTreino";
            this.idPlanoTreino.HeaderText = "IdPlanoTreino";
            this.idPlanoTreino.Name = "idPlanoTreino";
            this.idPlanoTreino.ReadOnly = true;
            this.idPlanoTreino.Visible = false;
            // 
            // nomeFicha
            // 
            this.nomeFicha.DataPropertyName = "nomeFicha";
            this.nomeFicha.HeaderText = "Nome da Ficha";
            this.nomeFicha.Name = "nomeFicha";
            this.nomeFicha.ReadOnly = true;
            this.nomeFicha.Visible = false;
            this.nomeFicha.Width = 110;
            // 
            // id_fichaDetalhe
            // 
            this.id_fichaDetalhe.DataPropertyName = "id_fichaDetalhe";
            this.id_fichaDetalhe.HeaderText = "ID";
            this.id_fichaDetalhe.Name = "id_fichaDetalhe";
            this.id_fichaDetalhe.ReadOnly = true;
            this.id_fichaDetalhe.Visible = false;
            // 
            // idFichaTreino
            // 
            this.idFichaTreino.DataPropertyName = "idFichaTreino";
            this.idFichaTreino.HeaderText = "idFichaTreino";
            this.idFichaTreino.Name = "idFichaTreino";
            this.idFichaTreino.ReadOnly = true;
            this.idFichaTreino.Visible = false;
            // 
            // idExercicio
            // 
            this.idExercicio.DataPropertyName = "idExercicio";
            this.idExercicio.HeaderText = "Id Exercicio";
            this.idExercicio.Name = "idExercicio";
            this.idExercicio.ReadOnly = true;
            this.idExercicio.Visible = false;
            // 
            // series
            // 
            this.series.DataPropertyName = "series";
            this.series.HeaderText = "Series";
            this.series.Name = "series";
            this.series.ReadOnly = true;
            this.series.Visible = false;
            // 
            // repeticoes
            // 
            this.repeticoes.DataPropertyName = "repeticoes";
            this.repeticoes.HeaderText = "Repeticoes";
            this.repeticoes.Name = "repeticoes";
            this.repeticoes.ReadOnly = true;
            this.repeticoes.Visible = false;
            // 
            // carga
            // 
            this.carga.DataPropertyName = "carga";
            this.carga.HeaderText = "Carga";
            this.carga.Name = "carga";
            this.carga.ReadOnly = true;
            this.carga.Visible = false;
            // 
            // situacao
            // 
            this.situacao.DataPropertyName = "situacao";
            this.situacao.HeaderText = "situacao";
            this.situacao.Name = "situacao";
            this.situacao.ReadOnly = true;
            this.situacao.Visible = false;
            // 
            // numeroTreinosRealizados
            // 
            this.numeroTreinosRealizados.DataPropertyName = "numeroTreinosRealizados";
            this.numeroTreinosRealizados.HeaderText = "numeroTreinosRealizados";
            this.numeroTreinosRealizados.Name = "numeroTreinosRealizados";
            this.numeroTreinosRealizados.ReadOnly = true;
            this.numeroTreinosRealizados.Visible = false;
            // 
            // situacao1
            // 
            this.situacao1.DataPropertyName = "situacao1";
            this.situacao1.HeaderText = "situacao1";
            this.situacao1.Name = "situacao1";
            this.situacao1.ReadOnly = true;
            this.situacao1.Visible = false;
            // 
            // id_aluno
            // 
            this.id_aluno.DataPropertyName = "id_aluno";
            this.id_aluno.HeaderText = "id_aluno";
            this.id_aluno.Name = "id_aluno";
            this.id_aluno.ReadOnly = true;
            this.id_aluno.Visible = false;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Visible = false;
            // 
            // telefoneRes
            // 
            this.telefoneRes.DataPropertyName = "telefoneRes";
            this.telefoneRes.HeaderText = "telefoneRes";
            this.telefoneRes.Name = "telefoneRes";
            this.telefoneRes.ReadOnly = true;
            this.telefoneRes.Visible = false;
            // 
            // telefoneCel
            // 
            this.telefoneCel.DataPropertyName = "telefoneCel";
            this.telefoneCel.HeaderText = "telefoneCel";
            this.telefoneCel.Name = "telefoneCel";
            this.telefoneCel.ReadOnly = true;
            this.telefoneCel.Visible = false;
            // 
            // dataNasc
            // 
            this.dataNasc.DataPropertyName = "dataNasc";
            this.dataNasc.HeaderText = "dataNasc";
            this.dataNasc.Name = "dataNasc";
            this.dataNasc.ReadOnly = true;
            this.dataNasc.Visible = false;
            // 
            // cpf
            // 
            this.cpf.DataPropertyName = "cpf";
            this.cpf.HeaderText = "cpf";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            this.cpf.Visible = false;
            // 
            // idCidade
            // 
            this.idCidade.DataPropertyName = "idCidade";
            this.idCidade.HeaderText = "idCidade";
            this.idCidade.Name = "idCidade";
            this.idCidade.ReadOnly = true;
            this.idCidade.Visible = false;
            // 
            // cep
            // 
            this.cep.DataPropertyName = "cep";
            this.cep.HeaderText = "cep";
            this.cep.Name = "cep";
            this.cep.ReadOnly = true;
            this.cep.Visible = false;
            // 
            // endereco
            // 
            this.endereco.DataPropertyName = "endereco";
            this.endereco.HeaderText = "endereco";
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            this.endereco.Visible = false;
            // 
            // bairro
            // 
            this.bairro.DataPropertyName = "bairro";
            this.bairro.HeaderText = "bairro";
            this.bairro.Name = "bairro";
            this.bairro.ReadOnly = true;
            this.bairro.Visible = false;
            // 
            // observacao
            // 
            this.observacao.DataPropertyName = "observacao";
            this.observacao.HeaderText = "observacao";
            this.observacao.Name = "observacao";
            this.observacao.ReadOnly = true;
            this.observacao.Visible = false;
            // 
            // senha
            // 
            this.senha.DataPropertyName = "senha";
            this.senha.HeaderText = "senha";
            this.senha.Name = "senha";
            this.senha.ReadOnly = true;
            this.senha.Visible = false;
            // 
            // idUsuario
            // 
            this.idUsuario.DataPropertyName = "idUsuario";
            this.idUsuario.HeaderText = "idUsuario";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.Visible = false;
            // 
            // sexo
            // 
            this.sexo.DataPropertyName = "sexo";
            this.sexo.HeaderText = "sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            this.sexo.Visible = false;
            // 
            // FrmTabTreinos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(687, 265);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPesquisa);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.dataGridViewTreinos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmTabTreinos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Treinos";
            this.Activated += new System.EventHandler(this.FrmTabTreinos_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTabTreinos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTreinos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTreinos;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_planoTreino;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTreinador;
        private System.Windows.Forms.DataGridViewTextBoxColumn idObjetivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn vezesSemana;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_fichaTreino;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlanoTreino;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFicha;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_fichaDetalhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFichaTreino;
        private System.Windows.Forms.DataGridViewTextBoxColumn idExercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn series;
        private System.Windows.Forms.DataGridViewTextBoxColumn repeticoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn carga;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTreinosRealizados;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneCel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cep;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
    }
}