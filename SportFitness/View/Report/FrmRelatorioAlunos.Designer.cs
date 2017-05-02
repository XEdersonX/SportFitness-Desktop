namespace SportFitness.View.Report
{
    partial class FrmRelatorioAlunos
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
            this.sportfitnessDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunosTableAdapter = new SportFitness.sportfitnessDataSetTableAdapters.alunosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sportfitnessDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportfitnessDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "datasetAlunos";
            reportDataSource1.Value = this.alunosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SportFitness.Relatorios.RelatorioAlunos.rdlc";
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
            // sportfitnessDataSetBindingSource
            // 
            this.sportfitnessDataSetBindingSource.DataSource = this.sportfitnessDataSet;
            this.sportfitnessDataSetBindingSource.Position = 0;
            // 
            // alunosBindingSource
            // 
            this.alunosBindingSource.DataMember = "alunos";
            this.alunosBindingSource.DataSource = this.sportfitnessDataSet;
            // 
            // alunosTableAdapter
            // 
            this.alunosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelatorioAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 422);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelatorioAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRelatorioAlunos";
            this.Load += new System.EventHandler(this.FrmRelatorioAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sportfitnessDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sportfitnessDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private sportfitnessDataSet sportfitnessDataSet;
        private System.Windows.Forms.BindingSource sportfitnessDataSetBindingSource;
        private System.Windows.Forms.BindingSource alunosBindingSource;
        private sportfitnessDataSetTableAdapters.alunosTableAdapter alunosTableAdapter;
    }
}