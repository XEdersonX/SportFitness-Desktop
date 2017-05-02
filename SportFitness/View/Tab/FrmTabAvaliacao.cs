using SportFitness.model;
using SportFitness.View.Alt;
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
    public partial class FrmTabAvaliacao : Form
    {
        public FrmTabAvaliacao()
        {
            InitializeComponent();
        }

        #region Carrega os dados para DataGrid
        private void FrmTabAvaliacao_Activated(object sender, EventArgs e)
        {
            Avaliacao avaliacao = new Avaliacao();
            dataGridViewAval.DataSource = avaliacao.select();
        }
        #endregion

        #region Botão para Deletar
        private void btDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resposta = MessageBox.Show("Excluir a Avaliação do Aluno '" + dataGridViewAval.CurrentRow.Cells[5].Value.ToString() + "' ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    try
                    {
                        Avaliacao avaliacao = new Avaliacao();
                        avaliacao.Id = Convert.ToInt16(dataGridViewAval.CurrentRow.Cells[1].Value);
                        avaliacao.updateDelete();

                        //Geracao de log
                        Logs logs = new Logs();
                        string linha;

                        using (StreamReader reader = new StreamReader("user.txt"))
                        {
                            linha = reader.ReadLine();
                        }

                        logs.IdUsuario = Convert.ToInt16(linha.ToString());
                        logs.IdAcao = 26;
                        logs.Data = DateTime.Today.ToString("dd/MM/yyyy");
                        logs.Hora = DateTime.Now.ToString("HH:mm");
                        logs.insert();

                        FrmTabAvaliacao_Activated(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Não há avaliações cadastradas.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (openForm is FrmAltAvaliacoes)
                    {
                        openForm.BringToFront();
                        existe = true;
                    }
                }
                if (!existe)
                {
                    FrmAltAvaliacoes novoForm;
                    //MessageBox.Show("" + Convert.ToInt16(dataGridViewAval.CurrentRow.Cells[0].Value));
                    //MessageBox.Show("" + Convert.ToInt16(dataGridViewAval.CurrentRow.Cells[6].Value));
                    novoForm = new FrmAltAvaliacoes(Convert.ToInt16(dataGridViewAval.CurrentRow.Cells[1].Value), Convert.ToInt16(dataGridViewAval.CurrentRow.Cells[6].Value));
                    novoForm.MdiParent = this.ParentForm;
                    novoForm.Show();
                }
            }
            catch
            {
                MessageBox.Show("Não há avaliações cadastrados.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Botão para Incluir
        private void btIncluir_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmCadAvaliacao)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                FrmCadAvaliacao novoForm;
                novoForm = new FrmCadAvaliacao();
                novoForm.MdiParent = this.ParentForm;
                novoForm.Show();
            }
        }
        #endregion

        #region Método para fechar a janela no ESC
        private void FrmTabAvaliacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
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

        #region Método para realizar pesquisa
        private void textPesquisa_TextChanged(object sender, EventArgs e)
        {
            Avaliacao avaliacao = new Avaliacao();
            dataGridViewAval.DataSource = avaliacao.selectPesquisa("where avaliacoes.situacao = 1 and nome like '%" + textPesquisa.Text + "%'");
        }
        #endregion

    }
}