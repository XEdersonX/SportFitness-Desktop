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
    public partial class FrmTabObjetivos : Form
    {
        public FrmTabObjetivos()
        {
            InitializeComponent();
        }

        #region Carregar os dados na dataGrid
        private void FrmTabObjetivos_Activated(object sender, EventArgs e)
        {
            Objetivo objetivos = new Objetivo();
            dataGridViewObjetivos.DataSource = objetivos.select();
        }
        #endregion

        #region Botão de Incluir
        private void btIncluir_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmCadObjetivos)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                FrmCadObjetivos novoForm;
                novoForm = new FrmCadObjetivos();
                novoForm.MdiParent = this.ParentForm;
                novoForm.Show();
            }
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
                    if (openForm is FrmAltObjetivos)
                    {
                        openForm.BringToFront();
                        existe = true;
                    }
                }
                if (!existe)
                {
                    FrmAltObjetivos novoForm;
                    //MessageBox.Show(""+Convert.ToInt16(dataGridViewObjetivos.CurrentRow.Cells[1].Value));
                    novoForm = new FrmAltObjetivos(Convert.ToInt16(dataGridViewObjetivos.CurrentRow.Cells[0].Value));
                    novoForm.MdiParent = this.ParentForm;
                    novoForm.Show();
                }
            }
            catch
            {

            }  
            
        }
        #endregion

        #region Botão de Deletar
        private void btDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resposta = MessageBox.Show("Excluir o Objetivo '" + dataGridViewObjetivos.CurrentRow.Cells[1].Value.ToString() + "' ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    try
                    {
                        Objetivo objetivos = new Objetivo();
                        objetivos.Id = Convert.ToInt16(dataGridViewObjetivos.CurrentRow.Cells[0].Value);
                        objetivos.delete();

                        //Geracao de log
                        Logs logs = new Logs();
                        string linha;

                        using (StreamReader reader = new StreamReader("user.txt"))
                        {
                            linha = reader.ReadLine();
                        }

                        logs.IdUsuario = Convert.ToInt16(linha.ToString());
                        logs.IdAcao = 27;
                        logs.Data = DateTime.Today.ToString("dd/MM/yyyy");
                        logs.Hora = DateTime.Now.ToString("HH:mm");
                        logs.insert();

                        FrmTabObjetivos_Activated(sender, e);
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

        #region Método de realizar pesquisa
        private void textPesquisa_TextChanged(object sender, EventArgs e)
        {
            Objetivo obj = new Objetivo();
            dataGridViewObjetivos.DataSource = obj.select("where nome like '%" + textPesquisa.Text + "%'");
        }
        #endregion

        #region Método de fechar a janela no ESC
        private void FrmTabObjetivos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
        #endregion
    }
}
