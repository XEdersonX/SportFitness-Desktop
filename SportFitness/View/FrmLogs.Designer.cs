namespace SportFitness.View
{
    partial class FrmLogs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogs));
            this.dataGridLogs = new System.Windows.Forms.DataGridView();
            this.Id_login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btReload = new System.Windows.Forms.Button();
            this.btPesquisa = new System.Windows.Forms.Button();
            this.comboAcao = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.comboUsuario = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLogs)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridLogs
            // 
            this.dataGridLogs.AllowUserToAddRows = false;
            this.dataGridLogs.AllowUserToDeleteRows = false;
            this.dataGridLogs.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_login,
            this.data,
            this.hora,
            this.nome,
            this.descricao});
            this.dataGridLogs.Location = new System.Drawing.Point(12, 59);
            this.dataGridLogs.Name = "dataGridLogs";
            this.dataGridLogs.ReadOnly = true;
            this.dataGridLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLogs.Size = new System.Drawing.Size(860, 363);
            this.dataGridLogs.TabIndex = 0;
            // 
            // Id_login
            // 
            this.Id_login.DataPropertyName = "id_log";
            this.Id_login.HeaderText = "ID";
            this.Id_login.Name = "Id_login";
            this.Id_login.ReadOnly = true;
            this.Id_login.Width = 60;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // hora
            // 
            this.hora.DataPropertyName = "hora";
            this.hora.HeaderText = "Hora";
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Usuário";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 190;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Ação";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 366;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.date2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btReload);
            this.groupBox1.Controls.Add(this.btPesquisa);
            this.groupBox1.Controls.Add(this.comboAcao);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.comboUsuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(860, 50);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // date2
            // 
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date2.Location = new System.Drawing.Point(374, 20);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(98, 20);
            this.date2.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 93;
            this.label4.Text = "entre";
            // 
            // btReload
            // 
            this.btReload.Image = ((System.Drawing.Image)(resources.GetObject("btReload.Image")));
            this.btReload.Location = new System.Drawing.Point(822, 12);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(32, 34);
            this.btReload.TabIndex = 92;
            this.btReload.UseVisualStyleBackColor = true;
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // btPesquisa
            // 
            this.btPesquisa.Location = new System.Drawing.Point(744, 12);
            this.btPesquisa.Name = "btPesquisa";
            this.btPesquisa.Size = new System.Drawing.Size(77, 35);
            this.btPesquisa.TabIndex = 91;
            this.btPesquisa.Text = "Pesquisar";
            this.btPesquisa.UseVisualStyleBackColor = true;
            this.btPesquisa.Click += new System.EventHandler(this.btPesquisa_Click);
            // 
            // comboAcao
            // 
            this.comboAcao.FormattingEnabled = true;
            this.comboAcao.Location = new System.Drawing.Point(530, 20);
            this.comboAcao.Name = "comboAcao";
            this.comboAcao.Size = new System.Drawing.Size(203, 21);
            this.comboAcao.TabIndex = 90;
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(236, 20);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(98, 20);
            this.date.TabIndex = 89;
            // 
            // comboUsuario
            // 
            this.comboUsuario.FormattingEnabled = true;
            this.comboUsuario.Location = new System.Drawing.Point(49, 20);
            this.comboUsuario.Name = "comboUsuario";
            this.comboUsuario.Size = new System.Drawing.Size(141, 21);
            this.comboUsuario.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(496, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ação:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // FrmLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 434);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridLogs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmLogs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logs";
            this.Activated += new System.EventHandler(this.FrmLogs_Activated);
            this.Load += new System.EventHandler(this.FrmLogs_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogs_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLogs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridLogs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPesquisa;
        private System.Windows.Forms.ComboBox comboAcao;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button btReload;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_login;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
    }
}