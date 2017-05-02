using SportFitness.model;
using SportFitness.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportFitness
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmLogin frmNovo = new FrmLogin();

            if (frmNovo.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmMenuInicial());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}