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
    public partial class FrmRelatorioUsuarios : Form
    {
        public FrmRelatorioUsuarios()
        {
            InitializeComponent();
        }

        private void FrmRelatorioUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sportfitnessDataSet.usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.sportfitnessDataSet.usuarios);

            this.reportViewerUsuari.RefreshReport();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.usuariosTableAdapter.FillBy(this.sportfitnessDataSet.usuarios);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
