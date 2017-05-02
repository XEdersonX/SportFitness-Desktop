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
    public partial class FrmRelatorioTreinadores : Form
    {
        public FrmRelatorioTreinadores()
        {
            InitializeComponent();
        }

        private void FrmRelatorioTreinadores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportfitnessDataSet.treinadores' table. You can move, or remove it, as needed.
            this.treinadoresTableAdapter.Fill(this.sportfitnessDataSet.treinadores);

            this.reportViewer1.RefreshReport();
        }
    }
}
