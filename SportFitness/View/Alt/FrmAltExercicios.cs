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
    public partial class FrmAltExercicios : Form
    {
        int id2, idGrupoMuscular;

        public FrmAltExercicios(int id, int grupoMuscular)
        {
            InitializeComponent();

            idGrupoMuscular = grupoMuscular;

            #region Carrega os dados dos exercicios
            Exercicios exercicios = new Exercicios();
            ArrayList array = exercicios.selectArray("where id_exercicio = " + id);

            foreach (Exercicios exercicio in array)
            {
                id2 = exercicio.Id;
                //comboGrupoMuscular.SelectedItem = exercicio.IdGrupoMuscular;
                textNome.Text = exercicio.Nome;
            }
            //MessageBox.Show("" + comboGrupoMuscular.SelectedValue);
            comboGrupoMuscular.SelectedValue = grupoMuscular;
            #endregion
        }

        #region Método para fechar a janela no ESC
        private void FrmAltExercicios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
        #endregion

        private void FrmAltExercicios_Load(object sender, EventArgs e)
        {
            #region Carrega os exercicios
            try
            {
                GrupoMuscular grupos = new GrupoMuscular();
                comboGrupoMuscular.DataSource = grupos.selectArray("order by nome");
                comboGrupoMuscular.DisplayMember = "nome";
                comboGrupoMuscular.ValueMember = "id";
            }
            catch
            {

            }
            comboGrupoMuscular.SelectedValue = idGrupoMuscular;
            #endregion
        }

        #region Botão para Cancelar
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Botão para Salvar
        private void btSalvar_Click(object sender, EventArgs e)
        {
            #region Alterar os dados
            try
            {
                Exercicios exe = new Exercicios();
                exe.Id = Convert.ToInt16(id2);
                exe.IdGrupoMuscular = Convert.ToInt16(comboGrupoMuscular.SelectedValue);
                exe.Nome = textNome.Text.Trim();
                
                exe.update();
                MessageBox.Show("Exercício Alterado com Sucesso.");

                #region Gravar o log
                //Geracao de log
                Logs logs = new Logs();
                string linha;

                using (StreamReader reader = new StreamReader("user.txt"))
                {
                    linha = reader.ReadLine();
                }

                logs.IdUsuario = Convert.ToInt16(linha.ToString());
                logs.IdAcao = 20;
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
    }
}
