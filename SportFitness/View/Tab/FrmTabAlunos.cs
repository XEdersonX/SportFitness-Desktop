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
    public partial class FrmTabAlunos : Form
    {
        public FrmTabAlunos()
        {
            InitializeComponent();
        }

        #region Carrega os dados para DataGrid
        private void FrmTabAlunos_Activated(object sender, EventArgs e)
        {
            Alunos alunos = new Alunos();
            dataGridViewAlunos.DataSource = alunos.select();

        }
        #endregion

        #region Botão para Alterar
        private void butAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean existe = false;
                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is FrmAltAlunos)
                    {
                        openForm.BringToFront();
                        existe = true;
                    }
                }
                if (!existe)
                {
                    FrmAltAlunos novoForm;
                    //MessageBox.Show(""+Convert.ToInt16(dataGridViewAlunos.CurrentRow.Cells[10].Value.ToString()));
                    novoForm = new FrmAltAlunos(Convert.ToInt16(dataGridViewAlunos.CurrentRow.Cells[0].Value), Convert.ToInt16(dataGridViewAlunos.CurrentRow.Cells[8].Value), Convert.ToInt16(dataGridViewAlunos.CurrentRow.Cells[16].Value)-1);
                //7 15
                    novoForm.MdiParent = this.ParentForm;
                    novoForm.Show();
                }
            }
            catch
            {
                MessageBox.Show("Não há alunos cadastrados.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion

        #region Botão para Incluir
        private void butIncluir_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmCadAlunos)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                FrmCadAlunos novoForm;
                novoForm = new FrmCadAlunos();
                novoForm.MdiParent = this.ParentForm;
                novoForm.Show();
            }
        }
        #endregion

        #region Botão para Deletar
        private void btDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resposta = MessageBox.Show("Excluir o Aluno '" + dataGridViewAlunos.CurrentRow.Cells[1].Value.ToString() + "' ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    try
                    {
                        Alunos alunos = new Alunos();
                        alunos.Id = Convert.ToInt16(dataGridViewAlunos.CurrentRow.Cells[0].Value);
                        alunos.delete();

                        //Geracao de log
                        Logs logs = new Logs();
                        string linha;

                        using (StreamReader reader = new StreamReader("user.txt"))
                        {
                            linha = reader.ReadLine();
                        }

                        logs.IdUsuario = Convert.ToInt16(linha.ToString());
                        logs.IdAcao = 23;
                        logs.Data = DateTime.Today.ToString("dd/MM/yyyy");
                        logs.Hora = DateTime.Now.ToString("HH:mm");
                        logs.insert();

                        FrmTabAlunos_Activated(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Não há alunos cadastrados.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Método para realizar pesquisa
        private void textPesquisa_TextChanged(object sender, EventArgs e)
        {
            Alunos alunos = new Alunos();
            dataGridViewAlunos.DataSource = alunos.selectPesquisa("where nome like '%" + textPesquisa.Text + "%'");
        }
        #endregion

        #region Metodo para fechar a janela no ESC
        private void FrmTabClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if(Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
        #endregion

    }
}