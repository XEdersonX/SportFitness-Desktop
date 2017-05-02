namespace SportFitness.View.Tab
{
    partial class FrmTabGrupoMuscular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTabGrupoMuscular));
            this.dataGridViewGrupoMuscular = new System.Windows.Forms.DataGridView();
            this.id_grupoMuscular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textPesquisa = new System.Windows.Forms.TextBox();
            this.btIncluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupoMuscular)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGrupoMuscular
            // 
            this.dataGridViewGrupoMuscular.AllowUserToAddRows = false;
            this.dataGridViewGrupoMuscular.AllowUserToDeleteRows = false;
            this.dataGridViewGrupoMuscular.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewGrupoMuscular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrupoMuscular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_grupoMuscular,
            this.nome});
            this.dataGridViewGrupoMuscular.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewGrupoMuscular.Name = "dataGridViewGrupoMuscular";
            this.dataGridViewGrupoMuscular.ReadOnly = true;
            this.dataGridViewGrupoMuscular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGrupoMuscular.Size = new System.Drawing.Size(664, 212);
            this.dataGridViewGrupoMuscular.TabIndex = 0;
            // 
            // id_grupoMuscular
            // 
            this.id_grupoMuscular.DataPropertyName = "id_grupoMuscular";
            this.id_grupoMuscular.HeaderText = "ID";
            this.id_grupoMuscular.Name = "id_grupoMuscular";
            this.id_grupoMuscular.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 520;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisa:";
            // 
            // textPesquisa
            // 
            this.textPesquisa.Location = new System.Drawing.Point(62, 238);
            this.textPesquisa.Name = "textPesquisa";
            this.textPesquisa.Size = new System.Drawing.Size(242, 20);
            this.textPesquisa.TabIndex = 3;
            this.textPesquisa.TextChanged += new System.EventHandler(this.textPesquisa_TextChanged);
            // 
            // btIncluir
            // 
            this.btIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btIncluir.Image")));
            this.btIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIncluir.Location = new System.Drawing.Point(336, 230);
            this.btIncluir.Margin = new System.Windows.Forms.Padding(2);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(114, 35);
            this.btIncluir.TabIndex = 5;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btAlterar.Image")));
            this.btAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAlterar.Location = new System.Drawing.Point(449, 230);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(114, 35);
            this.btAlterar.TabIndex = 6;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btDeletar.Image")));
            this.btDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDeletar.Location = new System.Drawing.Point(562, 230);
            this.btDeletar.Margin = new System.Windows.Forms.Padding(2);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(114, 35);
            this.btDeletar.TabIndex = 7;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // FrmTabGrupoMuscular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(691, 273);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.textPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewGrupoMuscular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmTabGrupoMuscular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupos Musculares";
            this.Activated += new System.EventHandler(this.FrmTabGrupoMuscular_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTabGrupoMuscular_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupoMuscular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGrupoMuscular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPesquisa;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_grupoMuscular;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
    }
}