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
    public partial class FrmAltObjetivos : Form
    {
        int id2;

        #region Carrega o dado do objetivo
        public FrmAltObjetivos(int id)
        {
            InitializeComponent();

            Objetivo objetivos = new Objetivo();
            ArrayList array = objetivos.selectArray("where id_objetivo = " + id);

            foreach(Objetivo objetivo in array){
                id2 = objetivo.Id;
                textNome.Text = objetivo.Nome;
            }
        }
        #endregion

        #region Botão para Salvar
        private void btSalvar_Click(object sender, EventArgs e)
        {
            #region Validação do cadastro
            if (textNome.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um objetivo válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textNome.Focus();
                return;
            }
            #endregion

            #region Alterar os dados
            try
            {
                Objetivo obje = new Objetivo();
                obje.Id = Convert.ToInt16(id2);
                obje.Nome = textNome.Text.Trim();

                obje.update();
                MessageBox.Show("Objetivo Alterado com Sucesso.");

                #region Gravar o log
                //Geracao de log
                Logs logs = new Logs();
                string linha;

                using (StreamReader reader = new StreamReader("user.txt"))
                {
                    linha = reader.ReadLine();
                }

                logs.IdUsuario = Convert.ToInt16(linha.ToString());
                logs.IdAcao = 18;
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

        #region Método para fechar a janela no ESC
        private void FrmAltObjetivos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
        #endregion

        #region Botão para Cancelar
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
