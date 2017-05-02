using SportFitness.model;
using System;
using System.Collections;
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
    public partial class FrmLogs : Form
    {
        public FrmLogs()
        {
            InitializeComponent();
        }

        #region Carrega os dados na dataGrid
        private void FrmLogs_Load(object sender, EventArgs e)
        {
            Logs logs = new Logs();
            dataGridLogs.DataSource = logs.select(" order by l.id_log;");
        }
        #endregion

        #region Carregar os Usuarios e Ações no comboBox
        private void FrmLogs_Activated(object sender, EventArgs e)
        {
            //Carrega os Usuarios no comboBox
            try
            {
                Usuarios usuarios = new Usuarios();
                ArrayList array = usuarios.selectArray("order by nome");
                comboUsuario.DataSource = array;
                comboUsuario.DisplayMember = "nome";
                comboUsuario.ValueMember = "id";
            }
            catch
            {

            }

            //Carrega as ações no comboBox
            try
            {
                Acoes acoes = new Acoes();
                ArrayList array = acoes.selectArray("order by descricao");
                comboAcao.DataSource = array;
                comboAcao.DisplayMember = "descricao";
                comboAcao.ValueMember = "id";
            }
            catch
            {

            }
        }
        #endregion

        #region Botão para realizar a pesquisa
        private void btPesquisa_Click(object sender, EventArgs e)
        {
            Logs logs = new Logs();
            dataGridLogs.DataSource = logs.select("where u.nome like '%" + comboUsuario.Text + "%' and l.data BETWEEN '" + date.Text + "' and  '" + date2.Text + "' and a.descricao like '%" + comboAcao.Text + "%'");
        }
        #endregion

        #region Botão para realizar o reload
        private void btReload_Click(object sender, EventArgs e)
        {
            Logs logs = new Logs();
            dataGridLogs.DataSource = logs.select(" order by l.id_log;");

            this.date.Value = DateTime.Now.Date;
            this.date2.Value = DateTime.Now.Date;
            comboUsuario.SelectedIndex = 0;
            comboAcao.SelectedIndex = 0;
            comboUsuario.Text = "";
            comboAcao.Text = "";
        }
        #endregion

        #region Método para fechar a janela no ESC
        private void FrmLogs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
        #endregion
    }
}
