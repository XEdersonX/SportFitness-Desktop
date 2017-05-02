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
    public partial class FrmTabExercicios : Form
    {
        public FrmTabExercicios()
        {
            InitializeComponent();
        }

        #region Carrega os dados para DataGrid
        private void FrmTabExercicios_Activated(object sender, EventArgs e)
        {
            Exercicios exercicios = new Exercicios();
            dataGridViewExercicios.DataSource = exercicios.select();
        }
        #endregion

        #region Botão para Incluir
        private void btIncluir_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmCadExercicios)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                FrmCadExercicios novoForm;
                novoForm = new FrmCadExercicios();
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
                DialogResult resposta = MessageBox.Show("Excluir o exercício '" + dataGridViewExercicios.CurrentRow.Cells[2].Value.ToString() + "' ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    try
                    {
                        Exercicios exercicios = new Exercicios();
                        exercicios.Id = Convert.ToInt16(dataGridViewExercicios.CurrentRow.Cells[0].Value);
                        exercicios.delete();

                        //Geracao de log
                        Logs logs = new Logs();
                        string linha;

                        using (StreamReader reader = new StreamReader("user.txt"))
                        {
                            linha = reader.ReadLine();
                        }

                        logs.IdUsuario = Convert.ToInt16(linha.ToString());
                        logs.IdAcao = 29;
                        logs.Data = DateTime.Today.ToString("dd/MM/yyyy");
                        logs.Hora = DateTime.Now.ToString("HH:mm");
                        logs.insert();

                        FrmTabExercicios_Activated(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Não há Objetivos cadastrados.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Método para realizar uma pesquisa
        private void textPesquisa_TextChanged(object sender, EventArgs e)
        {
            Exercicios exe = new Exercicios();
            dataGridViewExercicios.DataSource = exe.selectPesquisa("where exercicios.nome like '%" + textPesquisa.Text + "%'");
        }
        #endregion

        #region Método para fechar a janela no ESC
        private void FrmTabExercicios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
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
                    if (openForm is FrmAltExercicios)
                    {
                        openForm.BringToFront();
                        existe = true;
                    }
                }
                if (!existe)
                {
                    FrmAltExercicios novoForm;
                    //MessageBox.Show(""+dataGridViewExercicios.CurrentRow.Cells[3].Value);
                    novoForm = new FrmAltExercicios(Convert.ToInt16(dataGridViewExercicios.CurrentRow.Cells[0].Value), Convert.ToInt16(dataGridViewExercicios.CurrentRow.Cells[3].Value));
                    novoForm.MdiParent = this.ParentForm;
                    novoForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
    }
}
