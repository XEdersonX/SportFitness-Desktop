namespace SportFitness.View.Report
{
    partial class FrmRelatorioTreinadores
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sportfitnessDataSet = new SportFitness.sportfitnessDataSet();
            this.treinadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treinadoresTableAdapter = new SportFitness.sportfitnessDataSetTableAdapters.treinadoresTableAdapter();
            this.treinadoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sportfitnessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinadoresBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "datasetTreinadores";
            reportDataSource1.Value = this.treinadoresBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SportFitness.Relatorios.RelatorioTreinadores.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(631, 422);
            this.reportViewer1.TabIndex = 0;
            // 
            // sportfitnessDataSet
            // 
            this.sportfitnessDataSet.DataSetName = "sportfitnessDataSet";
            this.sportfitnessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // treinadoresBindingSource
            // 
            this.treinadoresBindingSource.DataMember = "treinadores";
            this.treinadoresBindingSource.DataSource = this.sportfitnessDataSet;
            // 
            // treinadoresTableAdapter
            // 
            this.treinadoresTableAdapter.ClearBeforeFill = true;
            // 
            // treinadoresBindingSource1
            // 
            this.treinadoresBindingSource1.DataMember = "treinadores";
            this.treinadoresBindingSource1.DataSource = this.sportfitnessDataSet;
            // 
            // FrmRelatorioTreinadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 422);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelatorioTreinadores";
            this.Text = "Relatório de Treinadores";
            this.Load += new System.EventHandler(this.FrmRelatorioTreinadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sportfitnessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treinadoresBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private sportfitnessDataSet sportfitnessDataSet;
        private System.Windows.Forms.BindingSource treinadoresBindingSource;
        private sportfitnessDataSetTableAdapters.treinadoresTableAdapter treinadoresTableAdapter;
        private System.Windows.Forms.BindingSource treinadoresBindingSource1;
    }
}