using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportFitness.View.Report
{
    public partial class FrmRelatorioAlunos : Form
    {
        public FrmRelatorioAlunos()
        {
            InitializeComponent();
        }

        private void FrmRelatorioAlunos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportfitnessDataSet.alunos' table. You can move, or remove it, as needed.
            this.alunosTableAdapter.Fill(this.sportfitnessDataSet.alunos);

            this.reportViewer1.RefreshReport();
        }
    }
}
