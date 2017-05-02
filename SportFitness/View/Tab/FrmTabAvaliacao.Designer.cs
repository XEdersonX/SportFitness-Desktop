namespace SportFitness.View
{
    partial class FrmTabAvaliacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTabAvaliacao));
            this.btAlterar = new System.Windows.Forms.Button();
            this.btIncluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textPesquisa = new System.Windows.Forms.TextBox();
            this.btDeletar = new System.Windows.Forms.Button();
            this.dataGridViewAval = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAltura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPercGordura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPressaoArterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIdAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAval)).BeginInit();
            this.SuspendLayout();
            // 
            // btAlterar
            // 
            this.btAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btAlterar.Image")));
            this.btAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAlterar.Location = new System.Drawing.Point(459, 236);
            this.btAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(114, 35);
            this.btAlterar.TabIndex = 2;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btIncluir
            // 
            this.btIncluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btIncluir.Image")));
            this.btIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIncluir.Location = new System.Drawing.Point(346, 236);
            this.btIncluir.Margin = new System.Windows.Forms.Padding(2);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(114, 35);
            this.btIncluir.TabIndex = 1;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Pesquisa:";
            // 
            // textPesquisa
            // 
            this.textPesquisa.Location = new System.Drawing.Point(64, 244);
            this.textPesquisa.Margin = new System.Windows.Forms.Padding(2);
            this.textPesquisa.Name = "textPesquisa";
            this.textPesquisa.Size = new System.Drawing.Size(242, 20);
            this.textPesquisa.TabIndex = 0;
            this.textPesquisa.TextChanged += new System.EventHandler(this.textPesquisa_TextChanged);
            // 
            // btDeletar
            // 
            this.btDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btDeletar.Image")));
            this.btDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDeletar.Location = new System.Drawing.Point(572, 236);
            this.btDeletar.Margin = new System.Windows.Forms.Padding(2);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(114, 35);
            this.btDeletar.TabIndex = 3;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // dataGridViewAval
            // 
            this.dataGridViewAval.AllowUserToAddRows = false;
            this.dataGridViewAval.AllowUserToDeleteRows = false;
            this.dataGridViewAval.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewAval.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAval.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnPeso,
            this.ColumnAltura,
            this.ColumnPercGordura,
            this.ColumnPressaoArterial,
            this.ColumnNome,
            this.ColumnIdAluno,
            this.data});
            this.dataGridViewAval.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAval.Name = "dataGridViewAval";
            this.dataGridViewAval.ReadOnly = true;
            this.dataGridViewAval.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAval.Size = new System.Drawing.Size(674, 208);
            this.dataGridViewAval.TabIndex = 15;
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "id_avaliacao";
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            // 
            // ColumnPeso
            // 
            this.ColumnPeso.DataPropertyName = "peso";
            this.ColumnPeso.HeaderText = "Peso";
            this.ColumnPeso.Name = "ColumnPeso";
            this.ColumnPeso.ReadOnly = true;
            this.ColumnPeso.Visible = false;
            // 
            // ColumnAltura
            // 
            this.ColumnAltura.DataPropertyName = "altura";
            this.ColumnAltura.HeaderText = "Altura";
            this.ColumnAltura.Name = "ColumnAltura";
            this.ColumnAltura.ReadOnly = true;
            this.ColumnAltura.Visible = false;
            // 
            // ColumnPercGordura
            // 
            this.ColumnPercGordura.DataPropertyName = "percentualGordura";
            this.ColumnPercGordura.HeaderText = "Gordura Atual";
            this.ColumnPercGordura.Name = "ColumnPercGordura";
            this.ColumnPercGordura.ReadOnly = true;
            this.ColumnPercGordura.Visible = false;
            // 
            // ColumnPressaoArterial
            // 
            this.ColumnPressaoArterial.DataPropertyName = "pressaoArterial";
            this.ColumnPressaoArterial.HeaderText = "Pressao Arterial";
            this.ColumnPressaoArterial.Name = "ColumnPressaoArterial";
            this.ColumnPressaoArterial.ReadOnly = true;
            this.ColumnPressaoArterial.Visible = false;
            // 
            // ColumnNome
            // 
            this.ColumnNome.DataPropertyName = "nome";
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 431;
            // 
            // ColumnIdAluno
            // 
            this.ColumnIdAluno.DataPropertyName = "idAluno";
            this.ColumnIdAluno.HeaderText = "IdAluno";
            this.ColumnIdAluno.Name = "ColumnIdAluno";
            this.ColumnIdAluno.ReadOnly = true;
            this.ColumnIdAluno.Visible = false;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // FrmTabAvaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(699, 277);
            this.Controls.Add(this.dataGridViewAval);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btIncluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPesquisa);
            this.Controls.Add(this.btDeletar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmTabAvaliacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avaliações";
            this.Activated += new System.EventHandler(this.FrmTabAvaliacao_Activated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTabAvaliacao_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPesquisa;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.DataGridView dataGridViewAval;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAltura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPercGordura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPressaoArterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
    }
}