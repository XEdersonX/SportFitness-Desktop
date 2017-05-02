using SportFitness.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportFitness.View
{
    public partial class FrmCadTreinadores : Form
    {
        public FrmCadTreinadores()
        {
            InitializeComponent();
        }

        #region Botão para salvar os dados
        private void btSalvar_Click(object sender, EventArgs e)
        {
            #region Validação dos componentes do sistema
            //Verifica se o componente esta vazio
            if (textNome.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um nome válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textNome.Focus();
                return;
            }

            //Verifica se o componente esta vazio
            if (maskedTextCpf.Text.Trim().Length < 14)
            {
                MessageBox.Show("Digite um cpf válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maskedTextCpf.Focus();
                return;
            }

            //Verifica se o componente esta vazio
            if (dateNasc.Text.Trim().Length < 10)
            {
                MessageBox.Show("Digite uma data de nascimento válida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateNasc.Focus();
                return;
            }

            //Verifica se o componente esta vazio
            if (maskedTextCep.Text.Trim().Length < 9)
            {
                MessageBox.Show("Digite um CEP válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maskedTextCep.Focus();
                return;
            }

            //Verifica se o componente esta vazio
            if (textEndereco.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um endereço válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textEndereco.Focus();
                return;
            }

            //Verifica se o componente esta vazio
            if (textBairro.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um bairro válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBairro.Focus();
                return;
            }

            //Verifica se o componente esta vazio
            if (textEmail.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um email válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textEmail.Focus();
                return;
            }

            #region Verifica se o Email é valido
            string email = textEmail.Text;

            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (rg.IsMatch(email))
            {
                //MessageBox.Show("Email Valido!");
            }
            else
            {
                MessageBox.Show("Email Inválido!");
                textEmail.Focus();
                return;
            }
            #endregion

            #region Validação de CPF
            if (maskedTextCpf.Text == "111,111,111-11")
            {
                MessageBox.Show("CPF INVÁLIDO!");
                maskedTextCpf.Focus();
                return;
            }

            else if (maskedTextCpf.Text == "222,222,222-22")
            {
                MessageBox.Show("CPF INVÁLIDO!");
                maskedTextCpf.Focus();
                return;
            }

            else if (maskedTextCpf.Text == "333,333,333-33")
            {
                MessageBox.Show("CPF INVÁLIDO!");
                maskedTextCpf.Focus();
                return;
            }

            else if (maskedTextCpf.Text == "444,444,444-44")
            {
                MessageBox.Show("CPF INVÁLIDO!");
                maskedTextCpf.Focus();
                return;
            }

            else if (maskedTextCpf.Text == "555,555,555-55")
            {
                MessageBox.Show("CPF INVÁLIDO!");
                maskedTextCpf.Focus();
                return;
            }

            else if (maskedTextCpf.Text == "666,666,666-66")
            {
                MessageBox.Show("CPF INVÁLIDO!");
                maskedTextCpf.Focus();
                return;
            }

            else if (maskedTextCpf.Text == "777,777,777-77")
            {
                MessageBox.Show("CPF INVÁLIDO!");
                maskedTextCpf.Focus();
                return;
            }

            else if (maskedTextCpf.Text == "888,888,888-88")
            {
                MessageBox.Show("CPF INVÁLIDO!");
                maskedTextCpf.Focus();
                return;
            }

            else if (maskedTextCpf.Text == "999,999,999-99")
            {
                MessageBox.Show("CPF INVÁLIDO!");
                maskedTextCpf.Focus();
                return;
            }



            int primeiroDigitoVerif, segundoDigitoVerif, soma = 0, j = 0;
            // Deixar somente os números do documento
            string documento = Regex.Replace(maskedTextCpf.Text, @"[^\d]", "");

            for (int i = 10; i >= 2; i--)
            {
                soma += i * Convert.ToInt16(documento[j].ToString());
                j++;
            }

            primeiroDigitoVerif = 11 - (soma % 11);

            if (primeiroDigitoVerif == 10 || primeiroDigitoVerif == 11)
            {
                primeiroDigitoVerif = 0;
            }

            if (primeiroDigitoVerif != Convert.ToInt16(documento[documento.Length - 2].ToString()))
            {
                MessageBox.Show("CPF INVÁLIDO!");
                maskedTextCpf.Focus();
                return;
            }
            else
            {
                j = 0;
                soma = 0;

                for (int i = 11; i > 2; i--)
                {
                    soma += i * Convert.ToInt16(documento[j].ToString());
                    j++;
                }

                soma += 2 * primeiroDigitoVerif;
                segundoDigitoVerif = 11 - (soma % 11);

                if (segundoDigitoVerif != Convert.ToInt16(documento[documento.Length - 1].ToString()))
                {
                    MessageBox.Show("CPF INVÁLIDO!");
                    maskedTextCpf.Focus();
                    return;
                }
            }
            #endregion

            #region Verifica se o Email ja esta sendo utilizado
            //Verifica se o Email ja esta sendo utilizado
            Treinadores treinador = new Treinadores();
            DataTable dt = new DataTable();

            dt = treinador.selectVerificacaoEmail(" where email = '" + textEmail.Text + "'");

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Este email já esta sendo utilizado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textEmail.Focus();
                textEmail.Clear();
                return;
            }
            #endregion
            #endregion

            #region Salvar os dados
            Treinadores trein = new Treinadores();
            trein.Nome = textNome.Text.Trim();
            trein.Cpf = maskedTextCpf.Text;
            trein.DataNasc = dateNasc.Text;
            trein.Cep = maskedTextCep.Text;
            trein.Endereco = textEndereco.Text.Trim();
            trein.Bairro = textBairro.Text.Trim();
            trein.TelefoneRes = maskedTextTelefoneRes.Text;
            trein.TelefoneCel = maskedTextTelefoneCel.Text;
            trein.Email = textEmail.Text.Trim();
            trein.Observacao = textObservacao.Text.Trim();
            trein.insert();
            #endregion

            #region Gravar o log
            //Geracao de log
            Logs logs = new Logs();
            string linha;

            using (StreamReader reader = new StreamReader("user.txt"))
            {
                linha = reader.ReadLine();
            }

            logs.IdUsuario = Convert.ToInt16(linha.ToString());
            logs.IdAcao = 6;
            logs.Data = DateTime.Today.ToString("dd/MM/yyyy");
            logs.Hora = DateTime.Now.ToString("HH:mm");
            logs.insert();
            #endregion

            #region Limpar os componentes da janela
            textNome.Clear();
            maskedTextCpf.Clear();
            this.dateNasc.Value = DateTime.Now.Date;
            maskedTextCep.Clear();
            textEndereco.Clear();
            textBairro.Clear();
            maskedTextTelefoneRes.Clear();
            maskedTextTelefoneCel.Clear();
            textEmail.Clear();
            textObservacao.Clear();

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
    }
}