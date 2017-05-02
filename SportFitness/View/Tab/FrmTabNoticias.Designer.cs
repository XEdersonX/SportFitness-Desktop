namespace SportFitness.View.Tab
{
    partial class FrmTabNoticias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTabNoticias));
            this.dataGridViewNoticias = new System.Windows.Forms.DataGridView();
            this.id_noticia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.texto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btDeletar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btIncluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textPesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNoticias)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNoticias
            // 
            this.dataGridViewNoticias.AllowUserToAddRows = false;
            this.dataGridViewNoticias.AllowUserToDeleteRows = false;
            this.dataGridViewNoticias.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewNoticias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNoticias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_noticia,
            this.titulo,
            this.data,
            this.texto,
            this.idUsuario});
            this.dataGridViewNoticias.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewNoticias.Name = "dataGridViewNoticias";
            this.dataGridViewNoticias.ReadOnly = true;
            this.dataGridViewNoticias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewNoticias.Size = new System.Drawing.Size(664, 212);
            this.dataGridViewNoticias.TabIndex = 0;
            // 
            // id_noticia
            // 
            this.id_noticia.DataPropertyName = "id_noticia";
            this.id_noticia.HeaderText = "ID";
            this.id_noticia.Name = "id_noticia";
            this.id_noticia.ReadOnly = true;
            // 
            // titulo
            // 
            this.titulo.DataPropertyName = "titulo";
            this.titulo.HeaderText = "Titulo";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            this.titulo.Width = 420;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // texto
            // 
            this.texto.DataPropertyName = "texto";
            this.texto.HeaderText = "Texto";
            this.texto.Name = "texto";
            this.texto.ReadOnly = true;
            this.texto.Visible = false;
            this.texto.Width = 226;
            // 
            // idUsuario
            // 
            this.idUsuario.DataPropertyName = "idUsuario";
            this.idUsuario.HeaderText = "Id Usuario";
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.Visible = false;
            // 
            // btDeletar
            // 
            this.btDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btDeletar.Image")));
            this.btDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDeletar.Location = new System.Drawing.Point(562, 233);
            this.btDeletar.Margin = new System.Windows.Forms.Padding(2);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(114, 35);
            this.btDeletar.TabIndex = 8;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btAlterar.Image")));
            this.btAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAlterar.Location = new System.Drawing.Point(449, 233);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(114, 35);
            this.btAlterar.TabIndex = 9;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btIncluir
            // 
            this.btIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btIncluir.Image")));
            this.btIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIncluir.Location = new System.Drawing.Point(336, 233);
            this.btIncluir.Margin = new System.Windows.Forms.Padding(2);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(114, 35);
            this.btIncluir.TabIndex = 10;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pesquisa:";
            // 
            // textPesquisa
            // 
            this.textPesquisa.Location = new System.Drawing.Point(62, 241);
            this.textPesquisa.Name = "textPesquisa";
            this.textPesquisa.Size = new System.Drawing.Size(242, 20);
            this.textPesquisa.TabIndex = 12;
            this.textPesquisa.TextChanged += new System.EventHandler(this.textPesquisa_TextChanged);
            // 
            // FrmTabNoticias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(695, 277);
            this.Controls.Add(this.textPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.dataGridViewNoticias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmTabNoticias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notícias";
            this.Activated += new System.EventHandler(this.FrmTabNoticias_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTabNoticias_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNoticias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNoticias;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_noticia;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn texto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
    }
}