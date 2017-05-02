namespace SportFitness.View.Tab
{
    partial class FrmTabExercicios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTabExercicios));
            this.dataGridViewExercicios = new System.Windows.Forms.DataGridView();
            this.id_exercicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGrupoMuscular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_grupoMuscular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btDeletar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btIncluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textPesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExercicios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewExercicios
            // 
            this.dataGridViewExercicios.AllowUserToAddRows = false;
            this.dataGridViewExercicios.AllowUserToDeleteRows = false;
            this.dataGridViewExercicios.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewExercicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExercicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_exercicio,
            this.idGrupoMuscular,
            this.id_grupoMuscular,
            this.nome,
            this.nome1});
            this.dataGridViewExercicios.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewExercicios.Name = "dataGridViewExercicios";
            this.dataGridViewExercicios.ReadOnly = true;
            this.dataGridViewExercicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExercicios.Size = new System.Drawing.Size(675, 221);
            this.dataGridViewExercicios.TabIndex = 0;
            // 
            // id_exercicio
            // 
            this.id_exercicio.DataPropertyName = "id_exercicio";
            this.id_exercicio.HeaderText = "ID";
            this.id_exercicio.Name = "id_exercicio";
            this.id_exercicio.ReadOnly = true;
            // 
            // idGrupoMuscular
            // 
            this.idGrupoMuscular.DataPropertyName = "idGrupoMuscular";
            this.idGrupoMuscular.HeaderText = "idGrupoMuscular";
            this.idGrupoMuscular.Name = "idGrupoMuscular";
            this.idGrupoMuscular.ReadOnly = true;
            this.idGrupoMuscular.Visible = false;
            // 
            // id_grupoMuscular
            // 
            this.id_grupoMuscular.DataPropertyName = "id_grupoMuscular";
            this.id_grupoMuscular.HeaderText = "id_grupoMuscular";
            this.id_grupoMuscular.Name = "id_grupoMuscular";
            this.id_grupoMuscular.ReadOnly = true;
            this.id_grupoMuscular.Visible = false;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 300;
            // 
            // nome1
            // 
            this.nome1.DataPropertyName = "nome1";
            this.nome1.HeaderText = "Grupo Muscular";
            this.nome1.Name = "nome1";
            this.nome1.ReadOnly = true;
            this.nome1.Width = 230;
            // 
            // btDeletar
            // 
            this.btDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btDeletar.Image")));
            this.btDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDeletar.Location = new System.Drawing.Point(573, 238);
            this.btDeletar.Margin = new System.Windows.Forms.Padding(2);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(114, 35);
            this.btDeletar.TabIndex = 9;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btAlterar.Image")));
            this.btAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAlterar.Location = new System.Drawing.Point(460, 238);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(114, 35);
            this.btAlterar.TabIndex = 10;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btIncluir
            // 
            this.btIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btIncluir.Image")));
            this.btIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIncluir.Location = new System.Drawing.Point(347, 238);
            this.btIncluir.Margin = new System.Windows.Forms.Padding(2);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(114, 35);
            this.btIncluir.TabIndex = 11;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pesquisa:";
            // 
            // textPesquisa
            // 
            this.textPesquisa.Location = new System.Drawing.Point(62, 246);
            this.textPesquisa.Name = "textPesquisa";
            this.textPesquisa.Size = new System.Drawing.Size(242, 20);
            this.textPesquisa.TabIndex = 13;
            this.textPesquisa.TextChanged += new System.EventHandler(this.textPesquisa_TextChanged);
            // 
            // FrmTabExercicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(699, 281);
            this.Controls.Add(this.textPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.dataGridViewExercicios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmTabExercicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercícios";
            this.Activated += new System.EventHandler(this.FrmTabExercicios_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTabExercicios_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExercicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewExercicios;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_exercicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGrupoMuscular;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_grupoMuscular;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome1;
    }
}