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
    public partial class FrmCadGrupoMuscular : Form
    {
        public FrmCadGrupoMuscular()
        {
            InitializeComponent();
        }

        #region Botão para salvar os dados
        private void btSalvar_Click(object sender, EventArgs e)
        {
            #region Validação dos componentes da janela
            //Verifica se o componente esta vazio
            if (textNome.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um objetivo válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textNome.Focus();
                return;
            }
            #endregion

            #region Salvar os dados
            GrupoMuscular grupo = new GrupoMuscular();
            grupo.Nome = textNome.Text.Trim();
            grupo.insert();
            #endregion

            #region Gravar o log
            //Gravacao do log de grupo muscular
            Logs logs = new Logs();
            string linha;

            using (StreamReader reader = new StreamReader("user.txt"))
            {
                linha = reader.ReadLine();
            }

            logs.IdUsuario = Convert.ToInt16(linha.ToString());
            logs.IdAcao = 10;
            logs.Data = DateTime.Today.ToString("dd/MM/yyyy");
            logs.Hora = DateTime.Now.ToString("HH:mm");
            logs.insert();
            #endregion

            #region Limpar os componentes ja janela
            textNome.Clear();
            textNome.Focus();
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
        private void FrmCadGrupoMuscular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
        #endregion
    }
}
