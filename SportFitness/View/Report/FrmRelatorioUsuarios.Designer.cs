namespace SportFitness.View.Report
{
    partial class FrmRelatorioUsuarios
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewerUsuari = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sportfitnessDataSet = new SportFitness.sportfitnessDataSet();
            this.usuariosTableAdapter = new SportFitness.sportfitnessDataSetTableAdapters.usuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportfitnessDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerUsuari
            // 
            this.reportViewerUsuari.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dataset_tbUsuario";
            reportDataSource1.Value = this.usuariosBindingSource;
            this.reportViewerUsuari.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerUsuari.LocalReport.ReportEmbeddedResource = "SportFitness.Relatorios.RelatorioUsuarios.rdlc";
            this.reportViewerUsuari.Location = new System.Drawing.Point(0, 0);
            this.reportViewerUsuari.Name = "reportViewerUsuari";
            this.reportViewerUsuari.Size = new System.Drawing.Size(631, 422);
            this.reportViewerUsuari.TabIndex = 0;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.sportfitnessDataSet;
            // 
            // sportfitnessDataSet
            // 
            this.sportfitnessDataSet.DataSetName = "sportfitnessDataSet";
            this.sportfitnessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorioUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 422);
            this.Controls.Add(this.reportViewerUsuari);
            this.Name = "FrmRelatorioUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Usuários";
            this.Load += new System.EventHandler(this.FrmRelatorioUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportfitnessDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerUsuari;
        private sportfitnessDataSet sportfitnessDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private sportfitnessDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
    }
}