using SportFitness.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportFitness.View.Alt
{
    public partial class FrmAltNoticias : Form
    {
        int id2;

        #region Carrega os dados das noticias
        public FrmAltNoticias(int id)
        {
            InitializeComponent();

            Noticias noticias = new Noticias();
            ArrayList array = noticias.selectArray("where id_noticia = " + id);

            foreach (Noticias noticia in array)
            {
                id2 = noticia.Id;
                date.Text = noticia.Data;
                textTitulo.Text = noticia.Titulo;
                textTexto.Text = noticia.Texto;
            }
        }
        #endregion

        #region Botão para Salvar
        private void btSalvar_Click(object sender, EventArgs e)
        {
            #region Validação dos componentes do cadastro
            if (date.Text.Trim().Length < 10)
            {
                MessageBox.Show("Digite uma data válida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                date.Focus();
                return;
            }

            if (textTitulo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um título válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textTitulo.Focus();
                return;
            }

            if (textTexto.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um texto válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textTexto.Focus();
                return;
            }
            #endregion

            #region Alterar os dados
            try
            {
                Noticias not = new Noticias();
                not.Id = Convert.ToInt16(id2);
                not.Data = date.Text;
                not.Titulo = textTitulo.Text.Trim();
                not.Texto = textTexto.Text.Trim();
                //not.IdUsuario = 1; //modificar

                //Pega o id do usuário
                string linha;

                using (StreamReader reader = new StreamReader("user.txt"))
                {
                    linha = reader.ReadLine();
                }

                not.IdUsuario = Convert.ToInt16(linha.ToString());
                // Console.WriteLine("USUARIO: " + Convert.ToInt16(linha.ToString()));

                not.update();
                MessageBox.Show("Notícia Alterada com Sucesso.");

                #region Gravar o log
                //Geracao de log
                Logs logs = new Logs();

                logs.IdUsuario = Convert.ToInt16(linha.ToString());
                logs.IdAcao = 13;
                logs.Data = DateTime.Today.ToString("dd/MM/yyyy");
                logs.Hora = DateTime.Now.ToString("HH:mm");
                logs.insert();
                #endregion

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
        }
        #endregion

        #region Botão para Cancelar
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Método para fechar a janela no ESC
        private void FrmAltNoticias_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
        #endregion
    }
}
