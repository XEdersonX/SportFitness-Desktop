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

namespace SportFitness.View.Cad
{
    public partial class FrmCadExercicios : Form
    {
        public FrmCadExercicios()
        {
            InitializeComponent();

            comboGrupoMuscular.SelectedIndex = -1;
        }

        #region Carrega os grupos musculares
        private void FrmCadExercicios_Activated(object sender, EventArgs e)
        {
            try
            {
                GrupoMuscular grupo = new GrupoMuscular();
                ArrayList array = grupo.selectArray("order by nome");
                comboGrupoMuscular.DataSource = array;
                comboGrupoMuscular.DisplayMember = "nome";
                comboGrupoMuscular.ValueMember = "id";
            }
            catch
            {

            }
        }
        #endregion

        #region Botão para salvar os dados
        private void btSalvar_Click(object sender, EventArgs e)
        {
            #region Validação dos componentes da janela do sistema
            //Verifica se o campo esta vazio
            if (comboGrupoMuscular.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um grupo muscular válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboGrupoMuscular.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textNome.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um nome válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textNome.Focus();
                return;
            }
            //MessageBox.Show("grupo " + Convert.ToInt16(comboGrupoMuscular.SelectedValue.ToString()));
            #endregion

            #region Salvar os dados
            Exercicios exe = new Exercicios();
                exe.IdGrupoMuscular = Convert.ToInt16(comboGrupoMuscular.SelectedValue);
                exe.Nome = textNome.Text.Trim();
                exe.insert();
            #endregion

            #region Gravar o log
            Logs logs = new Logs();
            string linha;

            using (StreamReader reader = new StreamReader("user.txt"))
            {
                linha = reader.ReadLine();
            }

            logs.IdUsuario = Convert.ToInt16(linha.ToString());
            logs.IdAcao = 11;
            logs.Data = DateTime.Today.ToString("dd/MM/yyyy");
            logs.Hora = DateTime.Now.ToString("HH:mm");
            logs.insert();
            #endregion

            #region Limpar os componentes do sistema
            comboGrupoMuscular.SelectedIndex = -1;
            textNome.Clear();
            comboGrupoMuscular.Focus();
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
        private void FrmCadExercicios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
        #endregion
    }
}
