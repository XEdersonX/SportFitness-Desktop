using SportFitness.model;
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

namespace SportFitness.View
{
    public partial class FrmTabTreinadores : Form
    {
        public FrmTabTreinadores()
        {
            InitializeComponent();
        }

        #region Carregar os dados na dataGrid
        private void FrmTabTreinadores_Activated(object sender, EventArgs e)
        {
            Treinadores func = new Treinadores();
            dataGridViewTreinadores.DataSource = func.select();
        }
        #endregion

        #region Botão de Alterar
        private void btAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean existe = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is FrmAltTreinadores)
                    {
                        openForm.BringToFront();
                        existe = true;
                    }
                }
                if (!existe)
                {
                    FrmAltTreinadores novoForm;
                    //MessageBox.Show(""+Convert.ToInt16(dataGridViewTreinadores.CurrentRow.Cells[1].Value));
                    novoForm = new FrmAltTreinadores(Convert.ToInt16(dataGridViewTreinadores.CurrentRow.Cells[0].Value));
                    novoForm.MdiParent = this.ParentForm;
                    novoForm.Show();
                }
            }
            catch
            {

            }
        }
        #endregion

        #region Botão de Incluir
        private void btIncluir_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmCadTreinadores)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                FrmCadTreinadores novoForm;
                novoForm = new FrmCadTreinadores();
                novoForm.MdiParent = this.ParentForm;
                novoForm.Show();
            }
        }
        #endregion

        #region Botão de Deletar
        private void btDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resposta = MessageBox.Show("Excluir o Treinador '" + dataGridViewTreinadores.CurrentRow.Cells[2].Value.ToString() + "' ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    try
                    {
                        Treinadores trein = new Treinadores();
                        trein.Id = Convert.ToInt16(dataGridViewTreinadores.CurrentRow.Cells[1].Value);
                        trein.delete();

                        //Geracao de log
                        Logs logs = new Logs();
                        string linha;

                        using (StreamReader reader = new StreamReader("user.txt"))
                        {
                            linha = reader.ReadLine();
                        }

                        logs.IdUsuario = Convert.ToInt16(linha.ToString());
                        logs.IdAcao = 24;
                        logs.Data = DateTime.Today.ToString("dd/MM/yyyy");
                        logs.Hora = DateTime.Now.ToString("HH:mm");
                        logs.insert();

                        FrmTabTreinadores_Activated(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Não há treinadores cadastrados.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Método para realizar pesquisa
        private void textPesquisa_TextChanged(object sender, EventArgs e)
        {
            Treinadores func = new Treinadores();
            dataGridViewTreinadores.DataSource = func.select("where nome like '%"+textPesquisa.Text+ "%'");
            // dataGridViewTreinadores.DataSource = func.select("where nome like '%"+textPesquisa.Text+ "%' or sobrenome like '%" + textPesquisa.Text + "%'");
        }
        #endregion

        #region Método para fechar a janela no ESC
        private void FrmTabFuncionarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
        #endregion
    }
}