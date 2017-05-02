namespace SportFitness.View
{
    partial class FrmFrequencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFrequencia));
            this.date = new System.Windows.Forms.DateTimePicker();
            this.comboAluno = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btReload = new System.Windows.Forms.Button();
            this.btPesquisa = new System.Windows.Forms.Button();
            this.dataGridFrequencia = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTreino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFrequencia)).BeginInit();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(234, 20);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(98, 20);
            this.date.TabIndex = 89;
            // 
            // comboAluno
            // 
            this.comboAluno.FormattingEnabled = true;
            this.comboAluno.Location = new System.Drawing.Point(47, 20);
            this.comboAluno.Name = "comboAluno";
            this.comboAluno.Size = new System.Drawing.Size(141, 21);
            this.comboAluno.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aluno:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.date2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btReload);
            this.groupBox1.Controls.Add(this.btPesquisa);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.comboAluno);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 50);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // date2
            // 
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date2.Location = new System.Drawing.Point(372, 20);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(98, 20);
            this.date2.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 93;
            this.label4.Text = "entre";
            // 
            // btReload
            // 
            this.btReload.Image = ((System.Drawing.Image)(resources.GetObject("btReload.Image")));
            this.btReload.Location = new System.Drawing.Point(568, 12);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(32, 34);
            this.btReload.TabIndex = 92;
            this.btReload.UseVisualStyleBackColor = true;
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // btPesquisa
            // 
            this.btPesquisa.Location = new System.Drawing.Point(490, 11);
            this.btPesquisa.Name = "btPesquisa";
            this.btPesquisa.Size = new System.Drawing.Size(77, 35);
            this.btPesquisa.TabIndex = 91;
            this.btPesquisa.Text = "Pesquisar";
            this.btPesquisa.UseVisualStyleBackColor = true;
            this.btPesquisa.Click += new System.EventHandler(this.btPesquisa_Click);
            // 
            // dataGridFrequencia
            // 
            this.dataGridFrequencia.AllowUserToAddRows = false;
            this.dataGridFrequencia.AllowUserToDeleteRows = false;
            this.dataGridFrequencia.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridFrequencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFrequencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnTreino,
            this.ColumnData,
            this.ColumnHora});
            this.dataGridFrequencia.Location = new System.Drawing.Point(9, 59);
            this.dataGridFrequencia.Name = "dataGridFrequencia";
            this.dataGridFrequencia.ReadOnly = true;
            this.dataGridFrequencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFrequencia.Size = new System.Drawing.Size(606, 328);
            this.dataGridFrequencia.TabIndex = 3;
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "id_frequencia";
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Width = 65;
            // 
            // ColumnNome
            // 
            this.ColumnNome.DataPropertyName = "nome";
            this.ColumnNome.HeaderText = "Aluno";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Width = 197;
            // 
            // ColumnTreino
            // 
            this.ColumnTreino.DataPropertyName = "nomeFicha";
            this.ColumnTreino.HeaderText = "Treino";
            this.ColumnTreino.Name = "ColumnTreino";
            this.ColumnTreino.ReadOnly = true;
            // 
            // ColumnData
            // 
            this.ColumnData.DataPropertyName = "data";
            this.ColumnData.HeaderText = "Data";
            this.ColumnData.Name = "ColumnData";
            this.ColumnData.ReadOnly = true;
            // 
            // ColumnHora
            // 
            this.ColumnHora.DataPropertyName = "duracao";
            this.ColumnHora.HeaderText = "Tempo de Permanência";
            this.ColumnHora.Name = "ColumnHora";
            this.ColumnHora.ReadOnly = true;
            // 
            // FrmFrequencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(624, 397);
            this.Controls.Add(this.dataGridFrequencia);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "FrmFrequencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frequência";
            this.Load += new System.EventHandler(this.FrmFrequencia_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFrequencia_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFrequencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox comboAluno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btReload;
        private System.Windows.Forms.Button btPesquisa;
        private System.Windows.Forms.DataGridView dataGridFrequencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTreino;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHora;
    }
}