using SportFitness.model;
using SportFitness.View.Alt;
using SportFitness.View.Cad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportFitness.View.Tab
{
    public partial class FrmTabTreinos : Form
    {
        public FrmTabTreinos()
        {
            InitializeComponent();
        }

        #region Botão para Incluir
        private void btIncluir_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmCadTreino)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                FrmCadTreino novoForm;
                novoForm = new FrmCadTreino();
                novoForm.MdiParent = this.ParentForm;
                novoForm.Show();
            }
        }
        #endregion

        #region Carrega os dados na dataGrid
        private void FrmTabTreinos_Activated(object sender, EventArgs e)
        {
            PlanoTreino plano  = new PlanoTreino();
            dataGridViewTreinos.DataSource = plano.selectAll();

        }
        #endregion

        #region Botão para Alterar
        private void btAlterar_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmAltTreino)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                FrmAltTreino novoForm;
                novoForm = new FrmAltTreino(Convert.ToInt16(dataGridViewTreinos.CurrentRow.Cells["id_planoTreino"].Value.ToString()), Convert.ToInt16(dataGridViewTreinos.CurrentRow.Cells["id_fichaTreino"].Value.ToString()), Convert.ToInt16(dataGridViewTreinos.CurrentRow.Cells["idExercicio"].Value.ToString()));
                novoForm.MdiParent = this.ParentForm;
                novoForm.Show();
            }
        }
        #endregion

        #region Método para fechar a janela no ESC
        private void FrmTabTreinos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
        #endregion

        #region Botão para Deletar
        private void btDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resposta = MessageBox.Show("Excluir o Treino '" + dataGridViewTreinos.CurrentRow.Cells[0].Value.ToString() + "' ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    try
                    {
                        PlanoTreino plano = new PlanoTreino();
                        plano.Id = Convert.ToInt16(dataGridViewTreinos.CurrentRow.Cells[0].Value);
                        plano.updateDelete();

                        //Geracao de log
                        Logs logs = new Logs();
                        string linha;

                        using (StreamReader reader = new StreamReader("user.txt"))
                        {
                            linha = reader.ReadLine();
                        }

                        logs.IdUsuario = Convert.ToInt16(linha.ToString());
                        logs.IdAcao = 25;
                        logs.Data = DateTime.Today.ToString("dd/MM/yyyy");
                        logs.Hora = DateTime.Now.ToString("HH:mm");
                        logs.insert();

                        FrmTabTreinos_Activated(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Não há Treinos cadastrados.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Método para realizar uma pesquisa
        private void textPesquisa_TextChanged(object sender, EventArgs e)
        {
            PlanoTreino plano = new PlanoTreino();
            dataGridViewTreinos.DataSource = plano.selectPesquisa(" WHERE planoTreino.situacao = 1 and alunos.nome like '%" + textPesquisa.Text + "%' group by id_planoTreino order by id_planoTreino");
        }
        #endregion
    }
}
