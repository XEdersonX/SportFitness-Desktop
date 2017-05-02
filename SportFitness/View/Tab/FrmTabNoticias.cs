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
    public partial class FrmTabNoticias : Form
    {
        public FrmTabNoticias()
        {
            InitializeComponent();
        }

        #region Carregar os dados na dataGrid
        private void FrmTabNoticias_Activated(object sender, EventArgs e)
        {
            Noticias noticia = new Noticias();
            dataGridViewNoticias.DataSource = noticia.select();
        }
        #endregion

        #region Botão de Incluir
        private void btIncluir_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmCadNoticias)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                FrmCadNoticias novoForm;
                novoForm = new FrmCadNoticias();
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
                    if (openForm is FrmAltNoticias)
                    {
                        openForm.BringToFront();
                        existe = true;
                    }
                }
                if (!existe)
                {
                    FrmAltNoticias novoForm;
                    //MessageBox.Show(""+Convert.ToInt16(dataGridViewObjetivos.CurrentRow.Cells[1].Value));
                    novoForm = new FrmAltNoticias(Convert.ToInt16(dataGridViewNoticias.CurrentRow.Cells[0].Value));
                    novoForm.MdiParent = this.ParentForm;
                    novoForm.Show();
                }
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Não há notícias cadastrados.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Botão de Deletar
        private void btDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resposta = MessageBox.Show("Excluir a notícia '" + dataGridViewNoticias.CurrentRow.Cells[2].Value.ToString() + "' ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resposta == DialogResult.Yes)
                {
                    try
                    {
                        Noticias noticias = new Noticias();
                        noticias.Id = Convert.ToInt16(dataGridViewNoticias.CurrentRow.Cells[0].Value);
                        noticias.delete();

                        //Geracao de log
                        Logs logs = new Logs();
                        string linha;

                        using (StreamReader reader = new StreamReader("user.txt"))
                        {
                            linha = reader.ReadLine();
                        }

                        logs.IdUsuario = Convert.ToInt16(linha.ToString());
                        logs.IdAcao = 22;
                        logs.Data = DateTime.Today.ToString("dd/MM/yyyy");
                        logs.Hora = DateTime.Now.ToString("HH:mm");
                        logs.insert();

                        FrmTabNoticias_Activated(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Não há notícias cadastrados.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region Método para realizar pesquisa
        private void textPesquisa_TextChanged(object sender, EventArgs e)
        {
            Noticias not = new Noticias();
            dataGridViewNoticias.DataSource = not.select("where titulo like '%" + textPesquisa.Text + "%'");
        }
        #endregion

        #region Método para fechar a janela no ESC
        private void FrmTabNoticias_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
        #endregion
    }
}
