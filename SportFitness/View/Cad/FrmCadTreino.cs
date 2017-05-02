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
    public partial class FrmCadTreino : Form
    {
        private int idAluno, idTreinador, idObjetivo, verificaClose = 0;
        private int count;

        #region Limpar os componentes
        public FrmCadTreino()
        {
            InitializeComponent();

            comboAluno.SelectedIndex = -1;
            comboTreinador.SelectedIndex = -1;
            comboObjetivo.SelectedIndex = -1;
            comboGrupoMuscular.SelectedIndex = -1;
            comboExercicio.SelectedIndex = -1;
            comboNomeFicha.SelectedIndex = -1;
            FichaDetalhe ficha = new FichaDetalhe();
            count = ficha.getIdFichaDetalhe()+1;
        }
        #endregion

        #region Carregar os dados
        private void FrmCadTreino_Activated(object sender, EventArgs e)
        {
            #region Carregar os alunos no comboBox
            try
            {
                Alunos aluno = new Alunos();
                ArrayList array = aluno.selectArray("order by nome");
                comboAluno.DataSource = array;
                comboAluno.DisplayMember = "nome";
                comboAluno.ValueMember = "id";
            }
            catch
            {

            }
            #endregion

            #region Carregar os treinadores no comboBox
            try
            {
                Treinadores treinador = new Treinadores();
                ArrayList array = treinador.selectArray("order by nome");
                comboTreinador.DataSource = array;
                comboTreinador.DisplayMember = "nome";
                comboTreinador.ValueMember = "id";
            }
            catch
            {

            }
            #endregion

            #region Carregar os objetivos no comboBox
            try
            {
                Objetivo objetivo = new Objetivo();
                ArrayList array = objetivo.selectArray("order by nome");
                comboObjetivo.DataSource = array;
                comboObjetivo.DisplayMember = "nome";
                comboObjetivo.ValueMember = "id";
            }
            catch
            {

            }
            #endregion

            #region Carrega os grupos musculares no comboBox
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
            #endregion

            comboAluno.SelectedValue = idAluno;
            comboTreinador.SelectedValue = idTreinador;
            comboObjetivo.SelectedValue = idObjetivo;
        }
        #endregion

        #region Botão para salvar
        private void btSalvar_Click(object sender, EventArgs e)
        {
            verificaClose = 1;
            #region Validação dos componentes da janela
            //Verifica se componente esta vazio
            if (comboAluno.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um aluno.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboAluno.Focus();
                return;
            }

            //Verifica se componente esta vazio
            if (comboTreinador.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Treinador.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboTreinador.Focus();
                return;
            }

            //Verifica se componente esta vazio
            if (comboObjetivo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um objetivo.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboObjetivo.Focus();
                return;
            }

            //Verifica se componente esta vazio
            if (dateInicio.Text.Trim().Length < 10)
            {
                MessageBox.Show("Digite uma data válida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateInicio.Focus();
                return;
            }

            //Verifica se componente esta vazio
            if (maskedVezesSemana.Text.Trim().Length < 1)
            {
                MessageBox.Show("Digite uma quantidade de vezes na semana válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maskedVezesSemana.Focus();
                return;
            }

            ////Verifica se componente esta vazio
            //if (comboNomeFicha.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Digite um nome para ficha válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    comboNomeFicha.Focus();
            //    return;
            //}

            //Verifica se componente esta vazio
            if (dataGridExercicios.RowCount == 0)
            {
                MessageBox.Show("Insira algum exercício no treino.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboGrupoMuscular.Focus();
                return;
            }
            #endregion

           
            this.Close();
            

            #region Gravar o log
            //Geracao de log
            Logs logs = new Logs();
            string linha;

            using (StreamReader reader = new StreamReader("user.txt"))
            {
                linha = reader.ReadLine();
            }

            logs.IdUsuario = Convert.ToInt16(linha.ToString());
            logs.IdAcao = 7;
            logs.Data = DateTime.Today.ToString("dd/MM/yyyy");
            logs.Hora = DateTime.Now.ToString("HH:mm");
            logs.insert();
            #endregion

            #region Limpar os componentes do sistema
            this.dateInicio.Value = DateTime.Now.Date;
            comboNomeFicha.SelectedIndex = -1;
            comboAluno.Focus();
            comboAluno.SelectedIndex = -1;
            comboTreinador.SelectedIndex = -1;
            comboObjetivo.SelectedIndex = -1;
            maskedVezesSemana.Clear();
            comboGrupoMuscular.SelectedIndex = -1;
            comboExercicio.SelectedIndex = -1;
            numericSeries.Value = 0;
            numericRepeticoes.Value = 0;
            numericCarga.Value = 0;
            //dataGridExercicios.Rows.Clear();
            this.Close();
            #endregion

        }
        #endregion

        #region Botão para adicionar na dataGrid
        private void adicionar_Click(object sender, EventArgs e)
        {
            #region Validação dos componentes
            //Verifica se componente esta vazio
            if (comboGrupoMuscular.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um grupo muscular.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboObjetivo.Focus();
                return;
            }

            //Verifica se componente esta vazio
            if (comboExercicio.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um exercício.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboObjetivo.Focus();
                return;
            }

            //Verifica se componente esta vazio
            if (numericSeries.Value.Equals("") || numericSeries.Value == 0)
            {
                MessageBox.Show("Digite um número de série válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numericSeries.Focus();
                return;
            }

            //Verifica se componente esta vazio
            if (numericRepeticoes.Value.Equals("") || numericRepeticoes.Value == 0)
            {
                MessageBox.Show("Digite um número de repetições válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numericRepeticoes.Focus();
                return;
            }

            //Verifica se componente esta vazio
            if (numericCarga.Value.Equals(""))
            {
                MessageBox.Show("Digite um número de carga válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                numericCarga.Focus();
                return;
            }
            #endregion

            #region Verifica se o nome da ficha de treino ja esta sendo utilizada
            //Verifica se o nome da ficha de treino ja esta sendo utilizada
            FichaDetalhe fichaD = new FichaDetalhe();
            DataTable dt = new DataTable();

            dt = fichaD.verificaTreino(" where d.idExercicio = " + comboExercicio.SelectedValue + " and f.nomeFicha = '" + comboFichaAluno.Text.ToString() + "' and p.idAluno = " + comboAluno.SelectedValue + " and f.situacao = 1 and p.situacao = 1;");
            //MessageBox.Show(""+ comboExercicio.SelectedValue + "" + comboFichaAluno.Text.ToString() + "" + comboAluno.SelectedValue);
            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("Esta ficha de treino já possui este exercício.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboGrupoMuscular.Focus();
                //comboNomeFicha.SelectedIndex = -1;
                return;
            }
            #endregion

            #region Adiciona na dataGrid 
            //dataGridExercicios.Rows.Add(count, comboGrupoMuscular.Text, comboExercicio.Text, numericSeries.Value, numericRepeticoes.Value, numericCarga.Value, comboExercicio.SelectedValue, comboFichaAluno.SelectedValue);
            //count++;
            FichaDetalhe detalhe = new FichaDetalhe();

           
                detalhe.IdFichaTreino = Convert.ToInt16(comboFichaAluno.SelectedValue);
                detalhe.IdExercicio = Convert.ToInt16(comboExercicio.SelectedValue);
                detalhe.Series = Convert.ToInt16(numericSeries.Value);
                detalhe.Repeticoes = Convert.ToInt16(numericRepeticoes.Value);
                detalhe.Carga = Convert.ToInt16(numericCarga.Value);
                detalhe.insert();
                #endregion

                #region Limpar os componentes
                comboGrupoMuscular.SelectedIndex = -1;
            comboExercicio.SelectedIndex = -1;
            numericSeries.Value = 0;
            numericRepeticoes.Value = 0;
            numericCarga.Value = 0;
            comboGrupoMuscular.Focus();
            #endregion

            try
            {
                int n = Convert.ToInt16(comboFichaAluno.SelectedValue);
                if (n > 0)
                {
                    // MessageBox.Show("" + comboFichaAluno.SelectedValue);
                    FichaDetalhe fichaDet = new FichaDetalhe();
                    dataGridExercicios.DataSource = fichaDet.select(" where f.idFichaTreino=" + comboFichaAluno.SelectedValue);
                }
                else
                {

                }
            }
            catch (Exception ex)
            {

            }

        }
        #endregion

        #region Botão para deletar os dados
        private void deletar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridExercicios.SelectedRows)
            {
                try
                {
                    FichaDetalhe fichaDet = new FichaDetalhe();
                    fichaDet.Id = Convert.ToInt16(dataGridExercicios.CurrentRow.Cells[0].Value);
                    fichaDet.delete();
                    dataGridExercicios.Rows.Remove(row);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region Botão para cancelar
        private void btCancelar_Click(object sender, EventArgs e)
        {
            
               
             try
             {
                FichaTreino fichas = new FichaTreino();
                int id;
                id = fichas.getIdPlanoTreino();

                if (id > 0) {
                    PlanoTreino plano = new PlanoTreino();
                    plano.Id = Convert.ToInt16(id);
                    plano.updateDelete();

                    FichaTreino ficha = new FichaTreino();
                    ficha.IdPlanoTreino = Convert.ToInt16(id);
                    ficha.updateDelete();
                }

            }
              catch (Exception ex)
              {
              MessageBox.Show(ex.Message);
              }

            this.Close();

        }
        #endregion

        #region Botão para fechar a janela pelo ESC
        private void FrmCadTreino_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (comboAluno.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um aluno.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboAluno.Focus();
                return;
            }

            //Verifica se componente esta vazio
            if (comboTreinador.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Treinador.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboTreinador.Focus();
                return;
            }

            //Verifica se componente esta vazio
            if (comboObjetivo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um objetivo.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboObjetivo.Focus();
                return;
            }

            //Verifica se componente esta vazio
            if (dateInicio.Text.Trim().Length < 10)
            {
                MessageBox.Show("Digite uma data válida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateInicio.Focus();
                return;
            }

            //Verifica se componente esta vazio
            if (maskedVezesSemana.Text.Trim().Length < 1)
            {
                MessageBox.Show("Digite uma quantidade de vezes na semana válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maskedVezesSemana.Focus();
                return;
            }

            //Verifica se o numero de vezes da semana é maior que 7
            if (Convert.ToInt16(maskedVezesSemana.Text) > 7)
            {
                MessageBox.Show("O número de vezes na semana não pode ser maior que 7.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maskedVezesSemana.Focus();
                return;
            }

            #region Verifica se o nome do aluno ja esta sendo utilizada
            //Verifica se o nome da ficha de treino ja esta sendo utilizada
            PlanoTreino planoD = new PlanoTreino();
            DataTable dt = new DataTable();

            dt = planoD.verificacaoNomeAluno(" where idAluno = " + comboAluno.SelectedValue + " and situacao = 1;");
            
            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("Este aluno já possui uma ficha de treino.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboAluno.Focus();
                //comboNomeFicha.SelectedIndex = -1;
                return;
            }
            #endregion

            groupBoxDados.Enabled = false;
            groupBoxNovaFicha.Enabled = true;
            comboNomeFicha.Focus();

            PlanoTreino plano = new PlanoTreino();
            plano.IdAluno = Convert.ToInt16(comboAluno.SelectedValue);
            plano.IdTreinador = Convert.ToInt16(comboTreinador.SelectedValue);
            plano.IdObjetivo = Convert.ToInt16(comboObjetivo.SelectedValue);
            plano.DataInicio = dateInicio.Text.Trim();
            plano.VezesSemana = Convert.ToInt16(maskedVezesSemana.Text.Trim());
            plano.Situacao = true;
            plano.insert();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            //Verifica se componente esta vazio
            if (maskedVezesSemana.Text.Trim().Length < 1)
            {
                MessageBox.Show("Digite uma quantidade de vezes na semana válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maskedVezesSemana.Focus();
                return;
            }

            //Verifica se componente esta vazio
            if (comboNomeFicha.SelectedIndex == -1)
            {
                MessageBox.Show("Digite um nome para ficha válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboNomeFicha.Focus();
                return;
            }

            #region Verifica se o nome da ficha de treino ja esta sendo utilizada
            //Verifica se o nome da ficha de treino ja esta sendo utilizada
            PlanoTreino planos = new PlanoTreino();
            DataTable dt = new DataTable();

            dt = planos.verificacaoNomeTreino(" where p.idAluno = " + comboAluno.SelectedValue + " and f.nomeFicha = '" + comboNomeFicha.SelectedItem.ToString() + "' and p.situacao = 1 and f.situacao = 1;");

            if (dt.Rows.Count >= 1)
            {
                MessageBox.Show("Este nome da ficha já esta sendo utilizado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboNomeFicha.Focus();
                //comboNomeFicha.SelectedIndex = -1;
                return;
            }
            #endregion

            FichaTreino ficha = new FichaTreino();
            int id;
            id = ficha.getIdPlanoTreino();
            
            ficha.IdPlanoTreino = id;
            ficha.NomeFicha = Convert.ToChar(comboNomeFicha.SelectedItem.ToString());
            ficha.NumeroTreinosRealizados = 0;
            ficha.Situacao = true;
            //MessageBox.Show("" + id);
            ficha.insert();

            groupBoxFichasAluno.Enabled = true;
            groupBoxListaExercicios.Enabled = true;
            groupBoxFichaDetalhe.Enabled = true;
            comboNomeFicha.SelectedIndex = -1;
            carregarFichas();

        }
        #endregion

        private void carregarFichas()
        {
            #region Carregar as Fichas no comboBox
            try
            {
                FichaTreino ficha = new FichaTreino();
                ArrayList array = ficha.selectArray1(Convert.ToString(ficha.getIdPlanoTreino()));
                comboFichaAluno.DataSource = array;
                comboFichaAluno.DisplayMember = "nomeFicha";
                comboFichaAluno.ValueMember = "id";
            }
            catch
            {

            }
            #endregion
        }

        private void comboFichaAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                int n = Convert.ToInt16(comboFichaAluno.SelectedValue);
                if (n > 0) {
                   // MessageBox.Show("" + comboFichaAluno.SelectedValue);
                    FichaDetalhe fichaDet = new FichaDetalhe();
                    dataGridExercicios.DataSource = fichaDet.select(" where f.idFichaTreino=" + comboFichaAluno.SelectedValue);
                }
                else
                {

                }
            }
            catch (Exception ex)
            {

            }
        }

        private void FrmCadTreino_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (verificaClose == 0) {
                try
                {
                    FichaTreino fichas = new FichaTreino();
                    int id;
                    id = fichas.getIdPlanoTreino();
                    if (id > 0)
                    {

                        PlanoTreino plano = new PlanoTreino();
                        plano.Id = Convert.ToInt16(id);
                        plano.updateDelete();

                        FichaTreino ficha = new FichaTreino();
                        ficha.IdPlanoTreino = Convert.ToInt16(id);
                        ficha.updateDelete();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            //this.Close();
        }

        private void FrmCadTreino_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        #region Botão para cancelar a inclusão de Edexercicos
        private void cancelar_Click(object sender, EventArgs e)
        {
            comboGrupoMuscular.SelectedIndex = -1;
            comboExercicio.SelectedIndex = -1;
            numericSeries.Value = 0;
            numericRepeticoes.Value = 0;
            numericCarga.Value = 0;
            comboGrupoMuscular.Focus();

        }
        #endregion

        #region Carregar os grupos musculares no comboBox
        private void comboGrupoMuscular_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Exercicios exercicio = new Exercicios();
                ArrayList array = exercicio.selectArray("where idGrupoMuscular = " + comboGrupoMuscular.SelectedValue);
                comboExercicio.DataSource = array;
                comboExercicio.DisplayMember = "nome";
                comboExercicio.ValueMember = "id";
            }
            catch
            {

            }
        }
        #endregion
    }
}
