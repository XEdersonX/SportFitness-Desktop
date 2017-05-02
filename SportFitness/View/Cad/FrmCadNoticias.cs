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

namespace SportFitness.View.Cad
{
    public partial class FrmCadNoticias : Form
    {
        public FrmCadNoticias()
        {
            InitializeComponent();
        }

        #region Botão para salvar os dados
        private void btSalvar_Click(object sender, EventArgs e)
        {
            #region Validação dos componentes da janela
            //Verifica se o componente esta vazio
            if (date.Text.Trim().Length < 10)
            {
                MessageBox.Show("Digite uma data válida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                date.Focus();
                return;
            }

            //Verifica se o componente esta vazio
            if (textTitulo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um título válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textTitulo.Focus();
                return;
            }

            //Verifica se o componente esta vazio
            if (textTexto.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um texto válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textTexto.Focus();
                return;
            }
            #endregion

            #region Salvar os dados
            Noticias not = new Noticias();
            not.Data = date.Text;
            not.Titulo = textTitulo.Text.Trim();
            not.Texto = textTexto.Text.Trim();
            #endregion

            #region Pegar o usuario que esta logado no sistema
            string linha;

            using (StreamReader reader = new StreamReader("user.txt"))
            {
                linha = reader.ReadLine();
            }
            

            not.IdUsuario = Convert.ToInt16(linha.ToString());
           // Console.WriteLine("USUARIO: " + Convert.ToInt16(linha.ToString()));
            not.insert();
            #endregion

            #region Gravar o log
            //Geracao de Log
            Logs logs = new Logs();
            
            logs.IdUsuario = Convert.ToInt16(linha.ToString());
            logs.IdAcao = 4;
            logs.Data = DateTime.Today.ToString("dd/MM/yyyy");
            logs.Hora = DateTime.Now.ToString("HH:mm");
            logs.insert();
            #endregion

            #region Limpar o componentes do sistema
            this.date.Value = DateTime.Now.Date;
            textTitulo.Clear();
            textTexto.Clear();

            date.Focus();
            #endregion

            this.Close();
        }
        #endregion

        #region Botão para cancelar
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Método para fechar a janela no ESC
        private void FrmCadNoticias_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
        #endregion
    }
}
