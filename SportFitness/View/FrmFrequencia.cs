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
    public partial class FrmFrequencia : Form
    {
        public FrmFrequencia()
        {
            InitializeComponent();
        }

        private void FrmFrequencia_Load(object sender, EventArgs e)
        {
            #region Carregar os dados na dataGrid
            Frequencia frequencia = new Frequencia();
            dataGridFrequencia.DataSource = frequencia.select();
            #endregion

            #region Carregar os alunos no comboBox
            //Lista os Alunos cadastrados no banco de dados no comboBox
            try
            {
                Alunos alunos = new Alunos();
                ArrayList array = alunos.selectArray("order by nome");
                comboAluno.DataSource = array;
                comboAluno.DisplayMember = "nome";
                comboAluno.ValueMember = "id";
            }
            catch
            {

            }
            #endregion
        }

        #region Metodo do Botão de realizar a pesquisa
        private void btPesquisa_Click(object sender, EventArgs e)
        {
            Frequencia frequencia = new Frequencia();
            dataGridFrequencia.DataSource = frequencia.selectPesquisa("where a.nome like '%" + comboAluno.Text + "%' and f.data BETWEEN '" + date.Text + "' and  '" + date2.Text + "'");
        }
        #endregion

        #region Metodo do Botão de fazer atualizar os dados da dataGrid
        private void btReload_Click(object sender, EventArgs e)
        {
            Frequencia frequencia = new Frequencia();
            dataGridFrequencia.DataSource = frequencia.select();

            this.date.Value = DateTime.Now.Date;
            this.date2.Value = DateTime.Now.Date;
            comboAluno.SelectedIndex = 0;
            
            comboAluno.Text = "";
          
        }
        #endregion

        #region Metodo para fechar a janela no ESC
        private void FrmFrequencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
        #endregion
    }
}
