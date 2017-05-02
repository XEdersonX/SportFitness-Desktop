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
    public partial class FrmAltGrupoMuscular : Form
    {
        int id2;

        public FrmAltGrupoMuscular(int id)
        {
            InitializeComponent();

            #region Carrega os grupos musculares
            GrupoMuscular grupo = new GrupoMuscular();
            ArrayList array = grupo.selectArray("where id_grupoMuscular = " + id);

            foreach (GrupoMuscular grup in array)
            {
                id2 = grup.Id;
                textNome.Text = grup.Nome;
            }
            #endregion
        }

        #region Botão para Salvar
        private void btSalvar_Click(object sender, EventArgs e)
        {
            #region Validação do componente do cadastro
            if (textNome.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um Grupo Muscular válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textNome.Focus();
                return;
            }
            #endregion

            #region Alterar os dados
            try
            {
                GrupoMuscular grup = new GrupoMuscular();
                grup.Id = Convert.ToInt16(id2);
                grup.Nome = textNome.Text.Trim();

                grup.update();
                MessageBox.Show("Grupo Muscular Alterado com Sucesso.");

                #region Gravar o log
                //Geracao de log
                Logs logs = new Logs();
                string linha;

                using (StreamReader reader = new StreamReader("user.txt"))
                {
                    linha = reader.ReadLine();
                }

                logs.IdUsuario = Convert.ToInt16(linha.ToString());
                logs.IdAcao = 19;
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
        private void FrmAltGrupoMuscular_KeyDown(object sender, KeyEventArgs e)
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
