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

namespace SportFitness.View
{
    public partial class FrmCadAvaliacao : Form
    {
        private double imc, sexo;
        private int idade;
        private double calcPG;
        private double calcMassaGorda;
        private double calcMassaMagra;
        private double calcPesoResidual;
        private double calcPesoOsseo1;
        private double calcPesoOsseo2;
        private double calcPesoOsseo3;
        private double calcPesoOsseo4;
        private double punhoM;
        private double joelhoM;
        private double pesoMuscular;

        public FrmCadAvaliacao()
        {
            InitializeComponent();
        }

        #region Lista os Alunos cadastrados no banco de dados no comboBox
        private void FrmCadAvaliacao_Activated(object sender, EventArgs e)
        {
            //Lista os Alunos cadastrados no banco de dados no comboBox
            try
            {
                Alunos alunos = new Alunos();
                ArrayList array = alunos.selectArray("order by nome");
                comboAluno.DataSource = array;
                comboAluno.DisplayMember = "nome";
                comboAluno.ValueMember = "id";
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
            //Verifica se um aluno foi selecionado
            if (comboAluno.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um aluno.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboAluno.Focus();
                return;
            }

            //Verifica se o valor digitado no peso é valido
            try
            {
                double valor = Convert.ToDouble(textPeso.Text.Replace(',', '.'));

                if (valor <= 0)
                {
                    MessageBox.Show("Digite um valor para o peso válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textPeso.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Digite um valor para o peso válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textPeso.Focus();
                return;
            }

            //Verifica se o valor digitado na altura é valido
            try
            {
                double valor = Convert.ToDouble(textAltura.Text.Replace(',', '.'));

                if (valor <= 0)
                {
                    MessageBox.Show("Digite um valor para a altura válida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textAltura.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Digite um valor para a altura válida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textAltura.Focus();
                return;
            }

            //Verifica se o valor digitado na pressão é valido
            try
            {
                int valor = Convert.ToInt16(textPressao.Text);

                if (valor <= 0)
                {
                    MessageBox.Show("Digite um valor para a pressão arterial válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textPressao.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Digite um valor para a pressão arterial válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textPressao.Focus();
                return;
            }

            //Verifica se o valor digitado na pressão minima é valido
            try
            {
                int valor = Convert.ToInt16(textPressaoMinima.Text);

                if (valor <= 0)
                {
                    MessageBox.Show("Digite um valor para a pressão arterial válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textPressaoMinima.Focus();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Digite um valor para a pressão arterial válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textPressaoMinima.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textPeso.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para o peso válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textPeso.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textAltura.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para a altura válida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textAltura.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textPressao.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para a pressão válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textPressao.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textPressaoMinima.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para a pressão válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textPressao.Focus();
                return;
            }

            //Verifica se o campos estão vazios
            if (textImc.Text.Trim().Equals("") && textGordIdeal.Text.Trim().Equals("") && textMassaGorda.Text.Trim().Equals("") && textMassaMagra.Text.Trim().Equals("") && textPesoDesejavel.Text.Trim().Equals("") && textPesoResidual.Text.Trim().Equals("") && textPesoOsseo.Text.Trim().Equals("") && textPesoMuscular.Text.Trim().Equals("") && textGordura.Text.Trim().Equals(""))
            {
                MessageBox.Show("Gerar Avaliação Física.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btGerarAvaliacao.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textTorax.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para o tórax válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textPressao.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textCintura.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para a cintura válida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textPressao.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textCintura.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para a cintura válida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textCintura.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textQuadril.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para o quadril válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textQuadril.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textAbdome.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para o abdome válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textAbdome.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textAntebD.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para o antebraço direito válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textAntebD.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textAntebE.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para o antebraço esquerdo válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textAntebE.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textBracosRelaxadoD.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para o braço relaxado direito válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBracosRelaxadoD.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textBracosRelaxadoE.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para o braço relaxado esquerdo válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBracosRelaxadoE.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textBracoFletidoE.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para o braço fletido esquerdo válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBracoFletidoE.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textBracoFletidoD.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para o braço fletido direito válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBracoFletidoD.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textPunhoD.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para o punho direito válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textPunhoD.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textPunhoE.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para o punho esquerdo válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textPunhoE.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textCoxaProximalD.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para a coxa proximal direita válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textCoxaProximalD.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textCoxaProximalE.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para a coxa proximal esquerda válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textCoxaProximalE.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textCoxaFemuralD.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para a coxa meso-femural direita válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textCoxaFemuralD.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textCoxaFemuralE.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para a coxa meso-femural esquerda válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textCoxaFemuralE.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textCoxaDistalE.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para a coxa distal esquerda válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textCoxaDistalE.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textCoxaDistalD.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para a coxa distal direita válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textCoxaDistalD.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textTornozeloD.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para tornozelo direito válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textTornozeloD.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textTornozeloE.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para tornozelo esquerdo válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textTornozeloE.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textPanturrilhasE.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para panturrilha esquerda válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textPanturrilhasE.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textPanturrilhasD.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para panturrilha direita válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textPanturrilhasD.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textBiacromial.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para bi-acromial válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBiacromial.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textToracicoTransverso.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para Torácico Transverso válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textToracicoTransverso.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textToraxicoAntero.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para Torácico Antero válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textToraxicoAntero.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textBileocristal.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para bi-ileocristal válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBileocristal.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textBitrocanteriano.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para bi-trocanteriano válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBitrocanteriano.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textBiepicondilo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para bi-epicondilo válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBiepicondilo.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textBiestiloide.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para bi-estilóide válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBiestiloide.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textBicondilo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para bi-côndilo femural válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBicondilo.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textBimaleolar.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para bi-maleolar válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBimaleolar.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textSubscapularCut.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para subscapular válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textSubscapularCut.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textTricipalCut.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para tricipal válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textTricipalCut.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textPeitoralCut.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para peitoral válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textPeitoralCut.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textAxilarCut.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para axilar-média válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textAxilarCut.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textSupraCut.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para supra-ilíaca válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textSupraCut.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textCoxaCut.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para coxa das dobras cutâneas válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textCoxaCut.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textAbdominalCut.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um valor para abdominal das dobras cutâneas válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textAbdominalCut.Focus();
                return;
            }
            #endregion

            #region Salvar os dados no Banco de dados
            //Salvar os dados no banco de dados
            try
            {
                Avaliacao avaliacao = new Avaliacao();
                avaliacao.Data = date.Text;
                avaliacao.IdAluno = Convert.ToInt16(comboAluno.SelectedValue);
                avaliacao.Peso = Convert.ToDouble(textPeso.Text.Trim());
                avaliacao.Altura = Convert.ToDouble(textAltura.Text.Trim());
                avaliacao.PressaoArterial = Convert.ToInt16(textPressao.Text.Trim());
                avaliacao.PressaoArterialMinima = Convert.ToInt16(textPressaoMinima.Text.Trim());
                //avaliacao.PercentualGordura = Convert.ToDouble(textGordura.Text.Trim());
                avaliacao.Imc = Convert.ToDouble(textImc.Text.Trim());
                avaliacao.Torax = Convert.ToDouble(textTorax.Text.Trim());
                avaliacao.Cintura = Convert.ToDouble(textCintura.Text.Trim());
                avaliacao.Abdome = Convert.ToDouble(textAbdome.Text.Trim());
                avaliacao.Quadril = Convert.ToDouble(textQuadril.Text.Trim());
                avaliacao.Antebraco_direito = Convert.ToDouble(textAntebE.Text.Trim());
                avaliacao.Antebraco_esquerdo = Convert.ToDouble(textAntebD.Text.Trim());
                avaliacao.BracoRelaxado_direito = Convert.ToDouble(textBracosRelaxadoE.Text.Trim());
                avaliacao.BracoRelaxado_esquerdo = Convert.ToDouble(textBracosRelaxadoD.Text.Trim());
                avaliacao.Coxa_direia = Convert.ToDouble(textCoxaFemuralE.Text.Trim());
                avaliacao.Coxa_esquerda = Convert.ToDouble(textCoxaFemuralD.Text.Trim());
                avaliacao.Panturrilha_direita = Convert.ToDouble(textPanturrilhasE.Text.Trim());
                avaliacao.Panturrilha_esquerda = Convert.ToDouble(textPanturrilhasD.Text.Trim());
                avaliacao.GorduraIdeal = Convert.ToDouble(textGordIdeal.Text.Trim());
                avaliacao.MassaGorda = Convert.ToDouble(textMassaGorda.Text.Trim());
                avaliacao.PesoDesejavel = Convert.ToDouble(textPesoDesejavel.Text.Trim());
                avaliacao.GorduraAtual = Convert.ToDouble(textGordura.Text.Trim());
                avaliacao.MassaMagra = Convert.ToDouble(textMassaMagra.Text.Trim());
                avaliacao.BracoFletido_direito = Convert.ToDouble(textBracoFletidoE.Text.Trim());
                avaliacao.BracoFletido_esquerdo = Convert.ToDouble(textBracoFletidoD.Text.Trim());
                avaliacao.Punho_direito = Convert.ToDouble(textPunhoE.Text.Trim());
                avaliacao.Punho_esquerdo = Convert.ToDouble(textPunhoD.Text.Trim());
                avaliacao.CoxaProximal_direito = Convert.ToDouble(textCoxaProximalE.Text.Trim());
                avaliacao.CoxaProximal_esquerda = Convert.ToDouble(textCoxaProximalD.Text.Trim());
                avaliacao.CoxaDistal_direita = Convert.ToDouble(textCoxaDistalE.Text.Trim());
                avaliacao.CoxaDistal_esquerda = Convert.ToDouble(textCoxaDistalD.Text.Trim());
                avaliacao.Tornozelo_direito = Convert.ToDouble(textTornozeloE.Text.Trim());
                avaliacao.Tornozelo_esquerdo = Convert.ToDouble(textTornozeloD.Text.Trim());
                avaliacao.PesoResidual = Convert.ToDouble(textPesoResidual.Text.Trim());
                avaliacao.PesoMuscular = Convert.ToDouble(textPesoMuscular.Text.Trim());
                avaliacao.PesoOsseo = Convert.ToDouble(textPesoOsseo.Text.Trim());
                avaliacao.BiAcromial = Convert.ToDouble(textBiacromial.Text.Trim());
                avaliacao.ToracicoTransverso = Convert.ToDouble(textToracicoTransverso.Text.Trim());
                avaliacao.ToraxicoAnteroPosterior = Convert.ToDouble(textToraxicoAntero.Text.Trim());
                avaliacao.BiIleocristal = Convert.ToDouble(textBileocristal.Text.Trim());
                avaliacao.BiEpicondiloUmeral = Convert.ToDouble(textBiepicondilo.Text.Trim());
                avaliacao.BiEstiloide = Convert.ToDouble(textBiestiloide.Text.Trim());
                avaliacao.BiCondiloFemural = Convert.ToDouble(textBicondilo.Text.Trim());
                avaliacao.BiTrocanteriano = Convert.ToDouble(textBitrocanteriano.Text.Trim());
                avaliacao.BiMaleolar = Convert.ToDouble(textBimaleolar.Text.Trim());
                avaliacao.Subscapular = Convert.ToDouble(textSubscapularCut.Text.Trim());
                avaliacao.Tricipal = Convert.ToDouble(textTricipalCut.Text.Trim());
                avaliacao.Peitoral = Convert.ToDouble(textPeitoralCut.Text.Trim());
                avaliacao.AxilarMedia = Convert.ToDouble(textAxilarCut.Text.Trim());
                avaliacao.SupraIliaca = Convert.ToDouble(textSupraCut.Text.Trim());
                avaliacao.Coxa = Convert.ToDouble(textCoxaCut.Text.Trim());
                avaliacao.Abdominal = Convert.ToDouble(textAbdominalCut.Text.Trim());
                avaliacao.Observacao = textObservacao.Text.Trim();
                avaliacao.Situacao = true;
                avaliacao.insert();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion

            #region Para registrar os logs do sistema
            Logs logs = new Logs();
            string linha;

            using (StreamReader reader = new StreamReader("user.txt"))
            {
                linha = reader.ReadLine();
            }

            logs.IdUsuario = Convert.ToInt16(linha.ToString());
            logs.IdAcao = 8;
            logs.Data = DateTime.Today.ToString("dd/MM/yyyy");
            logs.Hora = DateTime.Now.ToString("HH:mm");
            logs.insert();
            #endregion

            #region Limpar os componentes
            comboAluno.SelectedIndex = 0;
            this.date.Value = DateTime.Now.Date;
            textPeso.Clear();
            textAltura.Clear();
            textPressao.Clear();
            textPressaoMinima.Clear();
            textGordura.Clear();
            textAbdome.Clear();
            textAntebE.Clear();
            textAntebD.Clear();
            textImc.Clear();
            textGordura.Clear();
            textAbdominalCut.Clear();
            textAxilarCut.Clear();
            textBiacromial.Clear();
            textBicondilo.Clear();
            textBiepicondilo.Clear();
            textBitrocanteriano.Clear();
            textBimaleolar.Clear();
            textCintura.Clear();
            textTorax.Clear();
            textCoxaDistalD.Clear();
            textCoxaDistalE.Clear();
            textCoxaFemuralD.Clear();
            textCoxaFemuralE.Clear();
            textCoxaProximalD.Clear();
            textCoxaProximalE.Clear();
            textCoxaCut.Clear();
            textSubscapularCut.Clear();
            textSupraCut.Clear();
            textQuadril.Clear();
            textPesoDesejavel.Clear();
            textPesoMuscular.Clear();
            textPesoOsseo.Clear();
            textPesoResidual.Clear();
            textMassaGorda.Clear();
            textMassaMagra.Clear();
            textBracosRelaxadoE.Clear();
            textBracosRelaxadoD.Clear();
            textCintura.Clear();
            textTricipalCut.Clear();
            textPanturrilhasD.Clear();
            textPanturrilhasE.Clear();
            textToracicoTransverso.Clear();
            textTornozeloD.Clear();
            textTornozeloE.Clear();
            textPeitoralCut.Clear();
            textBiestiloide.Clear();
            textObservacao.Clear();
            textToraxicoAntero.Clear();
            textBileocristal.Clear();
            textBracoFletidoE.Clear();
            textBracoFletidoD.Clear();
            textGordIdeal.Clear();
            textPunhoE.Clear();
            textPunhoD.Clear();
            textPesoDesejavel.Clear();
            textMassaGorda.Clear();
            textMassaMagra.Clear();
            textPesoResidual.Clear();
            textQuadril.Clear();
            textTorax.Clear();
            comboAluno.Focus();
            #endregion

            this.Close();
        }
        #endregion

        #region Botão para imprimir
        private void btImprimir_Click(object sender, EventArgs e)
        {
            if (comboAluno.SelectedIndex == -1)
            {
                return;
            }

            try
            {
                double valor = Convert.ToDouble(textPeso.Text.Replace(',', '.'));
                double valor2 = Convert.ToDouble(textAltura.Text.Replace(',', '.'));
                int valor3 = Convert.ToInt16(textPressao.Text);
                double valor4 = Convert.ToDouble(textGordura.Text.Replace(',', '.'));

                if (valor <= 0 || valor2 <= 0 || valor3 <= 0 || valor4 <= 0)
                {
                    return;
                }
            }
            catch
            {
                return;
            }

        }
        #endregion

        #region Botão para cancelar
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Método para calculo do peso Residual
        private void pesoResidual()
        {
            try
            {
                double peso = Convert.ToDouble(textPeso.Text);

                if(peso > 0)
                {
                    double pesoResidual = (peso * 24.1) / 100;
                    textPesoResidual.Text = "" + pesoResidual;
                }
            }
            catch
            {

            }
        }
        #endregion

        #region Método para calculo do peso magro
        private void pesoMagro(double pesoGordo)
        {
            double pesoMagro = Convert.ToDouble(textPeso.Text) - pesoGordo;
            textMassaMagra.Text = "" + pesoMagro;
        }
        #endregion

        #region Método para calculo do peso gordo
        private void pesoGordo(int percGordura)
        {
            double pesoGordo = (percGordura * Convert.ToDouble(textPeso.Text)) / 100;
            textMassaGorda.Text = "" + pesoGordo;
            pesoMagro(pesoGordo);
        }
        #endregion

        #region Método para calculo do percentual de gordura
        private void percGordura()
        {
            try
            {
                double peso = Convert.ToDouble(textPeso.Text);

                if (peso > 0)
                {
                    try
                    {
                        double altura = Convert.ToDouble(textAltura.Text);

                        if (altura > 0)
                        {
                            imc = peso / Math.Pow(altura, 2);

                            Alunos aluno = new Alunos();
                            ArrayList idade = aluno.calcIdade(Convert.ToInt16(comboAluno.SelectedValue));
                            double percGordura = (1.20 * imc) + (0.23 * Convert.ToDouble(idade[0])) - (10.8 * sexo) - 5.4;
                            textGordura.Text = "" + Convert.ToInt16(percGordura);
                            pesoGordo(Convert.ToInt16(percGordura));
                        }
                    }
                    catch
                    {

                    }
                }
            }
            catch
            {

            }
        }
        #endregion

        private void textPeso_TextChanged(object sender, EventArgs e)
        {
            pesoResidual();
            percGordura();
        }

        #region Botão para realizar os calculos da avaliação
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // COMO PEGAR AS INFORMAÇÕES DE DATA DO PC
                //string dia = DateTime.Now.Day.ToString();
                //string mes = DateTime.Now.Month.ToString();
                //string ano = DateTime.Now.Year.ToString();


                //Conversão dos campos para double.
                double altura = Convert.ToDouble(textAltura.Text.ToString());
                double peso = Convert.ToDouble(textPeso.Text.ToString());
                double punho = Convert.ToDouble(textBiestiloide.Text.ToString());
                double joelho = Convert.ToDouble(textBicondilo.Text.ToString());

                // Calculo do IMC
                double calcImc = altura * altura;
                double resultadoImc = peso / calcImc;
                textImc.Text = "" + Math.Round(resultadoImc, 2);

                //Calculo do percentual de gordura
                Alunos aluno = new Alunos();
                char sexo1 = 'M';
                string dataNasc;
                //int idade;

                foreach (Alunos alunos in aluno.selectSexo(" WHERE id_aluno = " + comboAluno.SelectedValue))
                {

                    sexo1 = alunos.Sexo;

                }

                foreach (Alunos alunos in aluno.selectDataNasc(" WHERE id_aluno = " + comboAluno.SelectedValue))
                {

                    dataNasc = "/" + alunos.DataNasc;
                    //Console.WriteLine("DATA NASC:  " + data);
                    var palavras = dataNasc.Split('/');
                    var palavra = palavras[3];

                    //Console.WriteLine("DATA NASC:  " + palavra);

                    String ano = DateTime.Now.Year.ToString();
                    int data = Convert.ToInt16(palavra);
                    int anoAtual = Convert.ToInt16(ano);
                    idade = anoAtual - data;

                    Console.WriteLine("IDADE DO ALUNO:  " + idade);
                }

                //Calculo do Percentual de Gordura
                if (sexo1 == 'M')
                {
                    //(1,20 x IMC) + (0,23 x idade) – (10,8 x sexo) – 5.4
                    //os homens devem inserir o valor 1 e as mulheres devem inserir o valor zero.
                    calcPG = (1.20 * Math.Round(resultadoImc, 2)) + (0.23 * idade) - (10.8 * 1) - 5.4;
                    textGordura.Text = "" + Math.Round(calcPG, 2);
                }
                else
                {
                    calcPG = (1.20 * Math.Round(resultadoImc, 2)) + (0.23 * idade) - (10.8 * 0) - 5.4;
                    textGordura.Text = "" + Math.Round(calcPG, 2);
                }

                //Calculo do Peso Ideal
                if (sexo1 == 'M')
                {
                    double calcPI = (72.7 * altura) - 58;
                    textPesoDesejavel.Text = "" + Math.Round(calcPI, 2);
                }
                else
                {
                    double calcPI = (62.1 * altura) - 44.7;
                    textPesoDesejavel.Text = "" + Math.Round(calcPI, 2);
                }

                //Calculo da Massa Gorda
                calcMassaGorda = peso * (Math.Round(calcPG, 2) / 100);
                textMassaGorda.Text = "" + Math.Round(calcMassaGorda, 2);

                //Calculo da Massa Magra
                calcMassaMagra = peso - calcMassaGorda;
                textMassaMagra.Text = "" + Math.Round(calcMassaMagra, 2);

                //Calculo do Peso Residual
                if (sexo1 == 'M')
                {
                    calcPesoResidual = (peso * 24.1) / 100;
                    textPesoResidual.Text = "" + Math.Round(calcPesoResidual, 2);

                    //Calculo do Peso Muscular
                    pesoMuscular = peso - (Math.Round(calcMassaGorda, 2) + Math.Round(calcPesoOsseo3, 2) + Math.Round(calcPesoResidual, 2));
                    textPesoMuscular.Text = "" + Math.Round(pesoMuscular, 2);
                }
                else
                {
                    calcPesoResidual = (peso * 20.9) / 100;
                    textPesoResidual.Text = "" + Math.Round(calcPesoResidual, 2);

                    //Calculo do Peso Muscular
                    pesoMuscular = peso - (Math.Round(calcMassaGorda, 2) + Math.Round(calcPesoOsseo3, 2) + Math.Round(calcPesoResidual, 2));
                    textPesoMuscular.Text = "" + Math.Round(pesoMuscular, 2);
                }

                //Calculo da Gordura Ideal
                if (sexo1 == 'M')
                {
                    if (idade >= 18 && idade <= 25)
                    {
                        textGordIdeal.Text = "" + 16;
                    }
                    else if (idade >= 26 && idade <= 35)
                    {
                        textGordIdeal.Text = "" + 20;
                    }
                    else if (idade >= 36 && idade <= 45)
                    {
                        textGordIdeal.Text = "" + 23;
                    }
                    else if (idade >= 46)
                    {
                        textGordIdeal.Text = "" + 25;
                    }
                }
                else
                {
                    if (idade >= 18 && idade <= 35)
                    {
                        textGordIdeal.Text = "" + 25;
                    }
                    else if (idade >= 36 && idade <= 45)
                    {
                        textGordIdeal.Text = "" + 29;
                    }
                    else if (idade >= 46 && idade <= 55)
                    {
                        textGordIdeal.Text = "" + 31;
                    }
                    else if (idade >= 56)
                    {
                        textGordIdeal.Text = "" + 32;
                    }
                }

                //Calculo do Peso Osseo
                punhoM = punho / 100;
                joelhoM = joelho / 100;
                calcPesoOsseo1 = Math.Pow(altura, 2);
                calcPesoOsseo2 = calcPesoOsseo1 * punhoM * joelhoM * 400;
                calcPesoOsseo3 = 3.02 * Math.Pow(calcPesoOsseo2, 0.712);
                textPesoOsseo.Text = "" + Math.Round(calcPesoOsseo3, 2);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Validação dos componentes de medidas
        private void textPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textPeso.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }

        }

        private void textPeso_TextChanged_1(object sender, EventArgs e)
        {
            if (textPeso.Text.Substring(0) == ",")
                textPeso.Text = "0" + textPeso.Text;
        }

        private void textAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textAltura.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textAltura_TextChanged(object sender, EventArgs e)
        {
            if (textAltura.Text.Substring(0) == ",")
                textAltura.Text = "0" + textAltura.Text;

        }

        private void textPressao_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }

        private void textTorax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textTorax.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textTorax_TextChanged(object sender, EventArgs e)
        {
            if (textTorax.Text.Substring(0) == ",")
                textTorax.Text = "0" + textTorax.Text;

        }

        private void textCintura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textCintura.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textCintura_TextChanged(object sender, EventArgs e)
        {
            if (textCintura.Text.Substring(0) == ",")
                textCintura.Text = "0" + textCintura.Text;
        }

        private void textAbdome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textAbdome.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textAbdome_TextChanged(object sender, EventArgs e)
        {
            if (textAbdome.Text.Substring(0) == ",")
                textAbdome.Text = "0" + textAbdome.Text;
        }

        private void textQuadril_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textQuadril.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textQuadril_TextChanged(object sender, EventArgs e)
        {
            if (textQuadril.Text.Substring(0) == ",")
                textQuadril.Text = "0" + textQuadril.Text;
        }

        private void textAntebE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textAntebE.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textAntebE_TextChanged(object sender, EventArgs e)
        {
            if (textAntebE.Text.Substring(0) == ",")
                textAntebE.Text = "0" + textAntebE.Text;
        }

        private void textAntebD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textAntebD.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textAntebD_TextChanged(object sender, EventArgs e)
        {
            if (textAntebD.Text.Substring(0) == ",")
                textAntebD.Text = "0" + textAntebD.Text;
        }

        private void textBracosRelaxadoE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textBracosRelaxadoE.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textBracosRelaxadoE_TextChanged(object sender, EventArgs e)
        {
            if (textBracosRelaxadoE.Text.Substring(0) == ",")
                textBracosRelaxadoE.Text = "0" + textBracosRelaxadoE.Text;
        }

        private void textBracosRelaxadoD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textBracosRelaxadoD.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textBracosRelaxadoD_TextChanged(object sender, EventArgs e)
        {
            if (textBracosRelaxadoD.Text.Substring(0) == ",")
                textBracosRelaxadoD.Text = "0" + textBracosRelaxadoD.Text;
        }

        private void textBracoFletidoE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textBracoFletidoE.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textBracoFletidoE_TextChanged(object sender, EventArgs e)
        {
            if (textBracoFletidoE.Text.Substring(0) == ",")
                textBracoFletidoE.Text = "0" + textBracoFletidoE.Text;
        }

        private void textBracoFletidoD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textBracoFletidoD.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textBracoFletidoD_TextChanged(object sender, EventArgs e)
        {
            if (textBracoFletidoD.Text.Substring(0) == ",")
                textBracoFletidoD.Text = "0" + textBracoFletidoD.Text;

        }

        private void textPunhoE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textPunhoE.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textPunhoE_TextChanged(object sender, EventArgs e)
        {
            if (textPunhoE.Text.Substring(0) == ",")
                textPunhoE.Text = "0" + textPunhoE.Text;

        }

        private void textPunhoD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textPunhoD.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textPunhoD_TextChanged(object sender, EventArgs e)
        {
            if (textPunhoD.Text.Substring(0) == ",")
                textPunhoD.Text = "0" + textPunhoD.Text;
        }

        private void textCoxaProximalE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textCoxaProximalE.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textCoxaProximalE_TextChanged(object sender, EventArgs e)
        {
            if (textCoxaProximalE.Text.Substring(0) == ",")
                textCoxaProximalE.Text = "0" + textCoxaProximalE.Text;
        }

        private void textCoxaProximalD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textCoxaProximalD.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textCoxaProximalD_TextChanged(object sender, EventArgs e)
        {
            if (textCoxaProximalD.Text.Substring(0) == ",")
                textCoxaProximalD.Text = "0" + textCoxaProximalD.Text;
        }

        private void textCoxaFemuralE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textCoxaFemuralE.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textCoxaFemuralE_TextChanged(object sender, EventArgs e)
        {
            if (textCoxaFemuralE.Text.Substring(0) == ",")
                textCoxaFemuralE.Text = "0" + textCoxaFemuralE.Text;
        }

        private void textCoxaFemuralD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textCoxaFemuralD.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textCoxaFemuralD_TextChanged(object sender, EventArgs e)
        {
            if (textCoxaFemuralD.Text.Substring(0) == ",")
                textCoxaFemuralD.Text = "0" + textCoxaFemuralD.Text;

        }

        private void textCoxaDistalE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textCoxaDistalE.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }

        }

        private void textCoxaDistalE_TextChanged(object sender, EventArgs e)
        {
            if (textCoxaDistalE.Text.Substring(0) == ",")
                textCoxaDistalE.Text = "0" + textCoxaDistalE.Text;
        }

        private void textCoxaDistalD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textCoxaDistalD.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textCoxaDistalD_TextChanged(object sender, EventArgs e)
        {
            if (textCoxaDistalD.Text.Substring(0) == ",")
                textCoxaDistalD.Text = "0" + textCoxaDistalD.Text;

        }

        private void textTornozeloE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textTornozeloE.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textTornozeloE_TextChanged(object sender, EventArgs e)
        {
            if (textTornozeloE.Text.Substring(0) == ",")
                textTornozeloE.Text = "0" + textTornozeloE.Text;
        }

        private void textTornozeloD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textTornozeloD.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textTornozeloD_TextChanged(object sender, EventArgs e)
        {
            if (textTornozeloD.Text.Substring(0) == ",")
                textTornozeloD.Text = "0" + textTornozeloD.Text;

        }

        private void textPanturrilhasE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textPanturrilhasE.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textPanturrilhasE_TextChanged(object sender, EventArgs e)
        {
            if (textPanturrilhasE.Text.Substring(0) == ",")
                textPanturrilhasE.Text = "0" + textPanturrilhasE.Text;
        }

        private void textPanturrilhasD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textPanturrilhasD.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textPanturrilhasD_TextChanged(object sender, EventArgs e)
        {
            if (textPanturrilhasD.Text.Substring(0) == ",")
                textPanturrilhasD.Text = "0" + textPanturrilhasD.Text;

        }

        private void textBiacromial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textBiacromial.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textBiacromial_TextChanged(object sender, EventArgs e)
        {
            if (textBiacromial.Text.Substring(0) == ",")
                textBiacromial.Text = "0" + textBiacromial.Text;
        }

        private void textToracicoTransverso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textToracicoTransverso.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textToracicoTransverso_TextChanged(object sender, EventArgs e)
        {
            if (textToracicoTransverso.Text.Substring(0) == ",")
                textToracicoTransverso.Text = "0" + textToracicoTransverso.Text;
        }

        private void textToraxicoAntero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textToraxicoAntero.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textToraxicoAntero_TextChanged(object sender, EventArgs e)
        {
            if (textToraxicoAntero.Text.Substring(0) == ",")
                textToraxicoAntero.Text = "0" + textToraxicoAntero.Text;
        }

        private void textBileocristal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textBileocristal.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textBileocristal_TextChanged(object sender, EventArgs e)
        {
            if (textBileocristal.Text.Substring(0) == ",")
                textBileocristal.Text = "0" + textBileocristal.Text;
        }

        private void textBitrocanteriano_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textBitrocanteriano.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textBitrocanteriano_TextChanged(object sender, EventArgs e)
        {
            if (textBitrocanteriano.Text.Substring(0) == ",")
                textBitrocanteriano.Text = "0" + textBitrocanteriano.Text;
        }

        private void textBiepicondilo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textBiepicondilo.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textBiepicondilo_TextChanged(object sender, EventArgs e)
        {
            if (textBiepicondilo.Text.Substring(0) == ",")
                textBiepicondilo.Text = "0" + textBiepicondilo.Text;
        }

        private void textBiestiloide_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textBiestiloide.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textBiestiloide_TextChanged(object sender, EventArgs e)
        {
            if (textBiestiloide.Text.Substring(0) == ",")
                textBiestiloide.Text = "0" + textBiestiloide.Text;

        }

        private void textBicondilo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textBicondilo.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textBicondilo_TextChanged(object sender, EventArgs e)
        {
            if (textBicondilo.Text.Substring(0) == ",")
                textBicondilo.Text = "0" + textBicondilo.Text;
        }

        private void textBimaleolar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textBimaleolar.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textBimaleolar_TextChanged(object sender, EventArgs e)
        {
            if (textBimaleolar.Text.Substring(0) == ",")
                textBimaleolar.Text = "0" + textBimaleolar.Text;
        }

        private void textSubscapularCut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textSubscapularCut.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textSubscapularCut_TextChanged(object sender, EventArgs e)
        {
            if (textSubscapularCut.Text.Substring(0) == ",")
                textSubscapularCut.Text = "0" + textSubscapularCut.Text;
        }

        private void textTricipalCut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textTricipalCut.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textTricipalCut_TextChanged(object sender, EventArgs e)
        {
            if (textTricipalCut.Text.Substring(0) == ",")
                textTricipalCut.Text = "0" + textTricipalCut.Text;
        }

        private void textPeitoralCut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textPeitoralCut.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textPeitoralCut_TextChanged(object sender, EventArgs e)
        {
            if (textPeitoralCut.Text.Substring(0) == ",")
                textPeitoralCut.Text = "0" + textPeitoralCut.Text;
        }

        private void textAxilarCut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textAxilarCut.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textAxilarCut_TextChanged(object sender, EventArgs e)
        {
            if (textAxilarCut.Text.Substring(0) == ",")
                textAxilarCut.Text = "0" + textAxilarCut.Text;

        }

        private void textSupraCut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textSupraCut.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }

        }

        private void textSupraCut_TextChanged(object sender, EventArgs e)
        {
            if (textSupraCut.Text.Substring(0) == ",")
                textSupraCut.Text = "0" + textSupraCut.Text;
        }

        private void textCoxaCut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textCoxaCut.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textCoxaCut_TextChanged(object sender, EventArgs e)
        {
            if (textCoxaCut.Text.Substring(0) == ",")
                textCoxaCut.Text = "0" + textCoxaCut.Text;
        }

        private void textAbdominalCut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (textAbdominalCut.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }

        private void textAbdominalCut_TextChanged(object sender, EventArgs e)
        {
            if (textAbdominalCut.Text.Substring(0) == ",")
                textAbdominalCut.Text = "0" + textAbdominalCut.Text;

        }

        private void FrmCadAvaliacao_Load(object sender, EventArgs e)
        {

        }

        private void textPressaoMinima_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número e nem backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
        #endregion

    }
}