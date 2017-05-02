using SportFitness.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportFitness.View
{
    public partial class FrmGraficos : Form
    {

        public FrmGraficos()
        {
            InitializeComponent();
        }

        #region Método para fechar a janela no ESC
        private void FrmGraficos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
        #endregion

        #region Chamada do grafico por Sexo dos Alunos
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            comboAluno.Visible = false;

            try
            {
                webBrowser1.Navigate(@"http://localhost/Graficos/graficoSexos.php");
            }
            catch
            {

            }
        }
        #endregion

        #region Chamada do grafico por Objetivos dos Alunos
        private void radioObjetivo_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            comboAluno.Visible = false;

            try
            {
                webBrowser1.Navigate(@"http://localhost/Graficos/graficoObjetivo.php");
            }
            catch
            {

            }
        }
        #endregion

        #region Chamada do grafico por Treinos dos Treinadores
        private void radioTreinadores_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            comboAluno.Visible = false;

            try
            {
                webBrowser1.Navigate(@"http://localhost/Graficos/graficoTreinadores.php");
            }
            catch
            {

            }
        }
        #endregion

        #region Chamada do grafico por Frequência dos Alunos
        private void radioFrequencia_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Navigate(@"http://localhost/Graficos/graficoFrequencia.php");
            }
            catch
            {

            }
        }
        #endregion

        #region Metodo para start no Apache
        private void FrmGraficos_Load(object sender, EventArgs e)
        {
            //FileInfo fi = new FileInfo("c:\\xampp\\apache\\bin\\httpd.exe");
            //if (fi.Exists)
            //{
            //    Process.Start(fi.FullName);
            //}
            //else
            //{
            //    MessageBox.Show("this isn't Apache installation directory");
            //}

        }
        #endregion

        private void radioResuAvaliacoes_CheckedChanged(object sender, EventArgs e)
        {
            label1.Visible = true;
            comboAluno.Visible = true;

            #region Carregar os alunos no comboBox
            try
            {
                Alunos aluno = new Alunos();
                ArrayList array = aluno.selectArray("order by nome");
                comboAluno.DataSource = array;
                comboAluno.DisplayMember = "nome";
                comboAluno.ValueMember = "id";
            }
            catch
            {

            }
            #endregion

        }

        private void comboAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioResuAvaliacoes.Checked) {
                try
                {
                    webBrowser1.Navigate(@"http://localhost/Graficos/graficoAvaliacao.php?idAluno=" + comboAluno.SelectedValue + "");
                }
                catch
                {

                }
            }

            if (radioAvaliacaoPerimetro.Checked)
            {
                try
                {
                    webBrowser1.Navigate(@"http://localhost/Graficos/graficoAvaliacaoPerimetro.php?idAluno=" + comboAluno.SelectedValue + "");
                }
                catch
                {

                }
            }

            if (radioAvaliacaoDiametro.Checked)
            {
                try
                {
                    webBrowser1.Navigate(@"http://localhost/Graficos/graficoAvaliacaoDiametro.php?idAluno=" + comboAluno.SelectedValue + "");
                }
                catch
                {

                }
            }

            if (radioAvaliacaoDobrasCutaneas.Checked)
            {
                try
                {
                    webBrowser1.Navigate(@"http://localhost/Graficos/graficoAvaliacaoDobrasCutaneas.php?idAluno=" + comboAluno.SelectedValue + "");
                }
                catch
                {

                }
            }

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            label1.Visible = true;
            comboAluno.Visible = true;

            #region Carregar os alunos no comboBox
            try
            {
                Alunos aluno = new Alunos();
                ArrayList array = aluno.selectArray("order by nome");
                comboAluno.DataSource = array;
                comboAluno.DisplayMember = "nome";
                comboAluno.ValueMember = "id";
            }
            catch
            {

            }
            #endregion
        }

        private void radioAvaliacaoDiametro_CheckedChanged(object sender, EventArgs e)
        {

            label1.Visible = true;
            comboAluno.Visible = true;

            #region Carregar os alunos no comboBox
            try
            {
                Alunos aluno = new Alunos();
                ArrayList array = aluno.selectArray("order by nome");
                comboAluno.DataSource = array;
                comboAluno.DisplayMember = "nome";
                comboAluno.ValueMember = "id";
            }
            catch
            {

            }
            #endregion
        }

        private void radioAvaliacaoDobrasCutaneas_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
