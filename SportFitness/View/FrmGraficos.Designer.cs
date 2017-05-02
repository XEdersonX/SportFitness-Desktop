namespace SportFitness.View
{
    partial class FrmGraficos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioAvaliacaoPerimetro = new System.Windows.Forms.RadioButton();
            this.radioResuAvaliacoes = new System.Windows.Forms.RadioButton();
            this.radioFrequencia = new System.Windows.Forms.RadioButton();
            this.radioTreinadores = new System.Windows.Forms.RadioButton();
            this.radioObjetivo = new System.Windows.Forms.RadioButton();
            this.radioSexo = new System.Windows.Forms.RadioButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.comboAluno = new System.Windows.Forms.ComboBox();
            this.radioAvaliacaoDiametro = new System.Windows.Forms.RadioButton();
            this.radioAvaliacaoDobrasCutaneas = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 74);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioAvaliacaoDobrasCutaneas);
            this.groupBox1.Controls.Add(this.radioAvaliacaoDiametro);
            this.groupBox1.Controls.Add(this.radioAvaliacaoPerimetro);
            this.groupBox1.Controls.Add(this.radioResuAvaliacoes);
            this.groupBox1.Controls.Add(this.radioFrequencia);
            this.groupBox1.Controls.Add(this.radioTreinadores);
            this.groupBox1.Controls.Add(this.radioObjetivo);
            this.groupBox1.Controls.Add(this.radioSexo);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1008, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos";
            // 
            // radioAvaliacaoPerimetro
            // 
            this.radioAvaliacaoPerimetro.AutoSize = true;
            this.radioAvaliacaoPerimetro.Location = new System.Drawing.Point(807, 19);
            this.radioAvaliacaoPerimetro.Name = "radioAvaliacaoPerimetro";
            this.radioAvaliacaoPerimetro.Size = new System.Drawing.Size(191, 17);
            this.radioAvaliacaoPerimetro.TabIndex = 5;
            this.radioAvaliacaoPerimetro.TabStop = true;
            this.radioAvaliacaoPerimetro.Text = " Avaliações Físicas dos Perímetros";
            this.radioAvaliacaoPerimetro.UseVisualStyleBackColor = true;
            this.radioAvaliacaoPerimetro.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // radioResuAvaliacoes
            // 
            this.radioResuAvaliacoes.AutoSize = true;
            this.radioResuAvaliacoes.Location = new System.Drawing.Point(565, 19);
            this.radioResuAvaliacoes.Name = "radioResuAvaliacoes";
            this.radioResuAvaliacoes.Size = new System.Drawing.Size(227, 17);
            this.radioResuAvaliacoes.TabIndex = 4;
            this.radioResuAvaliacoes.TabStop = true;
            this.radioResuAvaliacoes.Text = "Resultados das Últimas Avaliações Físicas";
            this.radioResuAvaliacoes.UseVisualStyleBackColor = true;
            this.radioResuAvaliacoes.CheckedChanged += new System.EventHandler(this.radioResuAvaliacoes_CheckedChanged);
            // 
            // radioFrequencia
            // 
            this.radioFrequencia.AutoSize = true;
            this.radioFrequencia.Location = new System.Drawing.Point(419, 19);
            this.radioFrequencia.Name = "radioFrequencia";
            this.radioFrequencia.Size = new System.Drawing.Size(131, 17);
            this.radioFrequencia.TabIndex = 3;
            this.radioFrequencia.TabStop = true;
            this.radioFrequencia.Text = "Alunos por Frequência";
            this.radioFrequencia.UseVisualStyleBackColor = true;
            this.radioFrequencia.CheckedChanged += new System.EventHandler(this.radioFrequencia_CheckedChanged);
            // 
            // radioTreinadores
            // 
            this.radioTreinadores.AutoSize = true;
            this.radioTreinadores.Location = new System.Drawing.Point(269, 19);
            this.radioTreinadores.Name = "radioTreinadores";
            this.radioTreinadores.Size = new System.Drawing.Size(137, 17);
            this.radioTreinadores.TabIndex = 2;
            this.radioTreinadores.TabStop = true;
            this.radioTreinadores.Text = "Treinadores por Treinos";
            this.radioTreinadores.UseVisualStyleBackColor = true;
            this.radioTreinadores.CheckedChanged += new System.EventHandler(this.radioTreinadores_CheckedChanged);
            // 
            // radioObjetivo
            // 
            this.radioObjetivo.AutoSize = true;
            this.radioObjetivo.Location = new System.Drawing.Point(130, 19);
            this.radioObjetivo.Name = "radioObjetivo";
            this.radioObjetivo.Size = new System.Drawing.Size(122, 17);
            this.radioObjetivo.TabIndex = 1;
            this.radioObjetivo.TabStop = true;
            this.radioObjetivo.Text = "Alunos por Objetivos";
            this.radioObjetivo.UseVisualStyleBackColor = true;
            this.radioObjetivo.CheckedChanged += new System.EventHandler(this.radioObjetivo_CheckedChanged);
            // 
            // radioSexo
            // 
            this.radioSexo.AutoSize = true;
            this.radioSexo.Location = new System.Drawing.Point(10, 19);
            this.radioSexo.Name = "radioSexo";
            this.radioSexo.Size = new System.Drawing.Size(104, 17);
            this.radioSexo.TabIndex = 0;
            this.radioSexo.TabStop = true;
            this.radioSexo.Text = "Sexo dos Alunos";
            this.radioSexo.UseVisualStyleBackColor = true;
            this.radioSexo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(1, 103);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1012, 436);
            this.webBrowser1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aluno:";
            this.label1.Visible = false;
            // 
            // comboAluno
            // 
            this.comboAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAluno.FormattingEnabled = true;
            this.comboAluno.Location = new System.Drawing.Point(40, 76);
            this.comboAluno.Name = "comboAluno";
            this.comboAluno.Size = new System.Drawing.Size(361, 21);
            this.comboAluno.TabIndex = 3;
            this.comboAluno.Visible = false;
            this.comboAluno.SelectedIndexChanged += new System.EventHandler(this.comboAluno_SelectedIndexChanged);
            // 
            // radioAvaliacaoDiametro
            // 
            this.radioAvaliacaoDiametro.AutoSize = true;
            this.radioAvaliacaoDiametro.Location = new System.Drawing.Point(10, 42);
            this.radioAvaliacaoDiametro.Name = "radioAvaliacaoDiametro";
            this.radioAvaliacaoDiametro.Size = new System.Drawing.Size(184, 17);
            this.radioAvaliacaoDiametro.TabIndex = 6;
            this.radioAvaliacaoDiametro.TabStop = true;
            this.radioAvaliacaoDiametro.Text = "Avaliações Físicas dos Diâmetros\r\n";
            this.radioAvaliacaoDiametro.UseVisualStyleBackColor = true;
            this.radioAvaliacaoDiametro.CheckedChanged += new System.EventHandler(this.radioAvaliacaoDiametro_CheckedChanged);
            // 
            // radioAvaliacaoDobrasCutaneas
            // 
            this.radioAvaliacaoDobrasCutaneas.AutoSize = true;
            this.radioAvaliacaoDobrasCutaneas.Location = new System.Drawing.Point(208, 42);
            this.radioAvaliacaoDobrasCutaneas.Name = "radioAvaliacaoDobrasCutaneas";
            this.radioAvaliacaoDobrasCutaneas.Size = new System.Drawing.Size(219, 17);
            this.radioAvaliacaoDobrasCutaneas.TabIndex = 7;
            this.radioAvaliacaoDobrasCutaneas.TabStop = true;
            this.radioAvaliacaoDobrasCutaneas.Text = "Avaliações Físicas das Dobras Cutâneas\r\n";
            this.radioAvaliacaoDobrasCutaneas.UseVisualStyleBackColor = true;
            this.radioAvaliacaoDobrasCutaneas.CheckedChanged += new System.EventHandler(this.radioAvaliacaoDobrasCutaneas_CheckedChanged);
            // 
            // FrmGraficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1012, 540);
            this.Controls.Add(this.comboAluno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "FrmGraficos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gráficos";
            this.Load += new System.EventHandler(this.FrmGraficos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGraficos_KeyDown);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioSexo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.RadioButton radioTreinadores;
        private System.Windows.Forms.RadioButton radioObjetivo;
        private System.Windows.Forms.RadioButton radioFrequencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboAluno;
        private System.Windows.Forms.RadioButton radioResuAvaliacoes;
        private System.Windows.Forms.RadioButton radioAvaliacaoPerimetro;
        private System.Windows.Forms.RadioButton radioAvaliacaoDiametro;
        private System.Windows.Forms.RadioButton radioAvaliacaoDobrasCutaneas;
    }
}