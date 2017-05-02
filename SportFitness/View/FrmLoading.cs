using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportFitness.View
{
    public partial class FrmLoading : Form
    {
        public FrmLoading()
        {
            InitializeComponent();
            timer1.Start(); //Start no time
        }

        #region Método para chamar a janela do menu inicial
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is FrmMenuInicial)
                    {
                        openForm.Opacity = 100;
                        openForm.BringToFront();
                        timer1.Stop();
                        this.Close();
                    }
                }
            }
            catch
            {

            }
        }
        #endregion
    }
}
