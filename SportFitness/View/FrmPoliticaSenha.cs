using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportFitness.View
{
    public partial class FrmPoliticaSenha : Form
    {
        public FrmPoliticaSenha()
        {
            InitializeComponent();
        }

        #region Método para fechar a janela no ESC
        private void FrmPoliticaSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
        #endregion
    }
}
