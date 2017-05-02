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
    public partial class FrmTabGrupoMuscular : Form
    {
        public FrmTabGrupoMuscular()
        {
            InitializeComponent();
        }

        #region Carregar os dados na dataGrid
        private void FrmTabGrupoMuscular_Activated(object sender, EventArgs e)
        {
            GrupoMuscular grupo = new GrupoMuscular();
            dataGridViewGrupoMuscular.DataSource = grupo.select();
        }
        #endregion

        #region Botão para Incluir
        private void btIncluir_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmCadGrupoMuscular)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                FrmCadGrupoMuscular novoForm;
                novoForm = new FrmCadGrupoMuscular();
                novoForm.MdiParent = this.ParentForm;
                novoForm.Show();
            }
        }
        #endregion

        #region Botão para Alterar
        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean existe = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is FrmAltGrupoMuscular)
                    {
                        openForm.BringToFront();
                        existe = true;
                    }
                }
                if (!existe)
                {
                    FrmAltGrupoMuscular novoForm;
                    //MessageBox.Show(""+Convert.ToInt16(dataGridViewTreinadores.CurrentRow.Cells[1].Value));
                    novoForm = new FrmAltGrupoMuscular(Convert.ToInt16(dataGridViewGrupoMuscular.CurrentRow.Cells[0].Value));
                    novoForm.MdiParent = this.ParentForm;
                    novoForm.Show();
                }
            }
            catch
            {

            }
        }
        #endregion

        #region Método para realizar pesquisa
        private void textPesquisa_TextChanged(object sender, EventArgs e)
        {
            GrupoMuscular grupo = new GrupoMuscular();
            dataGridViewGrupoMuscular.DataSource = grupo.select("where nome like '%" + textPesquisa.Text + "%'");
            // dataGridViewTreinadores.DataSource = func.select("where nome like '%"+textPesquisa.Text+ "%' or sobrenome like '%" + textPesquisa.Text + "%'");
        }
        #endregion

        #region Botão para Deletar
        private void btDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resposta = MessageBox.Show("Excluir o Grupo Muscular '" + dataGridViewGrupoMuscular.CurrentRow.Cells[1].Value.ToString() + "' ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    try
                    {
                        GrupoMuscular grupo = new GrupoMuscular();
                        grupo.Id = Convert.ToInt16(dataGridViewGrupoMuscular.CurrentRow.Cells[0].Value);
                        grupo.delete();

                        //Geracao de log
                        Logs logs = new Logs();
                        string linha;

                        using (StreamReader reader = new StreamReader("user.txt"))
                        {
                            linha = reader.ReadLine();
                        }

                        logs.IdUsuario = Convert.ToInt16(linha.ToString());
                        logs.IdAcao = 28;
                        logs.Data = DateTime.Today.ToString("dd/MM/yyyy");
                        logs.Hora = DateTime.Now.ToString("HH:mm");
                        logs.insert();

                        FrmTabGrupoMuscular_Activated(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Não há Grupos Musculares cadastrados.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Métodos para fechar a janela no ESC
        private void FrmTabGrupoMuscular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }

        private void FrmTabFuncionarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion
    }
}
