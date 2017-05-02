using SportFitness.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportFitness.View
{
    public partial class FrmCadAlunos : Form
    {
        public FrmCadAlunos()
        {
            InitializeComponent();

            comboEstado.SelectedIndex = -1;
            comboCidade.SelectedIndex = -1;
        }

        #region Botão para salvar os dados
        private void btSalvar_Click(object sender, EventArgs e)
        {
            #region Validação dos componentes da janela do sistema
            //Verifica se o campo esta vazio
            if (textNome.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um nome válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textNome.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (maskedTextCpf.Text.Trim().Length < 14)
            {
                MessageBox.Show("Digite um cpf válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maskedTextCpf.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (dateNasc.Text.Trim().Length < 10)
            {
                MessageBox.Show("Digite uma data de nascimento válida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateNasc.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (comboEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um estado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboEstado.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (comboCidade.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma cidade.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboEstado.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (maskedTextCep.Text.Trim().Length < 9)
            {
                MessageBox.Show("Digite um CEP válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                maskedTextCpf.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textBairro.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um nome válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBairro.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textEndereco.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um endereço válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textEndereco.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textSenha.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite uma senha válida.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textEndereco.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textConfirmeSenha.Text.Trim().Equals(""))
            {
                MessageBox.Show("Confirme sua senha.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textConfirmeSenha.Focus();
                return;
            }

            //Verifica se a senhas digitas são diferentes
            if (textSenha.Text.Trim() != textConfirmeSenha.Text.Trim())
            {
                MessageBox.Show("Senha incorreta.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textConfirmeSenha.Focus();
                return;
            }

            //Verifica o tamanho de caracteres da senha
            if (textSenha.Text.Length < 5)
            {
                MessageBox.Show("Senha muito fraca.");
                textSenha.Focus();
                return;
            }

            //Verifica o tamanho de caracteres da senha
            if (textConfirmeSenha.Text.Length < 5)
            {
                MessageBox.Show("Senha muito fraca.");
                textConfirmeSenha.Focus();
                return;
            }

            //Verifica se o campo esta vazio
            if (textEmail.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um email válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textEmail.Focus();
                return;
            }

            #region Validação de Email
            //Validação de email
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
            //Verifica se o Cpf é invalido
            if (maskedTextCpf.Text == "111,111,111-11")
            {
                MessageBox.Show("CPF INVÁLIDO!");
                maskedTextCpf.Focus();
                return;
            }

            //Verifica se o Cpf é invalido
            else if (maskedTextCpf.Text == "222,222,222-22")
            {
                MessageBox.Show("CPF INVÁLIDO!");
                maskedTextCpf.Focus();
                return;
            }

            //Verifica se o Cpf é invalido
            else if (maskedTextCpf.Text == "333,333,333-33")
            {
                MessageBox.Show("CPF INVÁLIDO!");
                maskedTextCpf.Focus();
                return;
            }

            //Verifica se o Cpf é invalido
            else if (maskedTextCpf.Text == "444,444,444-44")
            {
                MessageBox.Show("CPF INVÁLIDO!");
                maskedTextCpf.Focus();
                return;
            }

            //Verifica se o Cpf é invalido
            else if (maskedTextCpf.Text == "555,555,555-55")
            {
                MessageBox.Show("CPF INVÁLIDO!");
                maskedTextCpf.Focus();
                return;
            }

            //Verifica se o Cpf é invalido
            else if (maskedTextCpf.Text == "666,666,666-66")
            {
                MessageBox.Show("CPF INVÁLIDO!");
                maskedTextCpf.Focus();
                return;
            }

            //Verifica se o Cpf é invalido
            else if (maskedTextCpf.Text == "777,777,777-77")
            {
                MessageBox.Show("CPF INVÁLIDO!");
                maskedTextCpf.Focus();
                return;
            }

            //Verifica se o Cpf é invalido
            else if (maskedTextCpf.Text == "888,888,888-88")
            {
                MessageBox.Show("CPF INVÁLIDO!");
                maskedTextCpf.Focus();
                return;
            }

            //Verifica se o Cpf é invalido
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

            //Verifica o tamanho da senha, pra ela ter no minimo 6 caracteres.
            if (textSenha.Text.Length < 6)
            {
                MessageBox.Show("Senha muito fraca.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textSenha.Focus();
                return;
            }

            //Verifica o tamanho da senha, pra ela ter no máximo 12 caracteres.
            if (textSenha.Text.Length > 12)
            {
                MessageBox.Show("A Senha pode ter no máximo 12 caracteres.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textSenha.Focus();
                return;
            }

            //Verifica o tamanho da senha, pra ela ter no minimo 6 caracteres.
            if (textConfirmeSenha.Text.Length < 6)
            {
                MessageBox.Show("Senha muito fraca.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textConfirmeSenha.Focus();
                return;
            }

            //Verifica o tamanho da senha, pra ela ter no máximo 12 caracteres.
            if (textConfirmeSenha.Text.Length > 12)
            {
                MessageBox.Show("A Senha pode ter no máximo 12 caracteres.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textConfirmeSenha.Focus();
                return;
            }

            var regexEsp = new Regex("^[a-zA-Z0-9 ]*$");
            //Verificar se existe pelo menos um número ou caracter especial digitado na senha.
            if (!textSenha.Text.Any(c => char.IsDigit(c)) && regexEsp.IsMatch(textSenha.Text))
            {
                MessageBox.Show("Senha muito fraca. Tem que ter pelo menos um número ou caracter especial digitado na senha.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textConfirmeSenha.Focus();
                return;
            }

            //Verificar se existe pelo menos um número ou caracter especial digitado na senha.
            if (!textConfirmeSenha.Text.Any(c => char.IsDigit(c)) && regexEsp.IsMatch(textConfirmeSenha.Text))
            {
                MessageBox.Show("Senha muito fraca. Tem que ter pelo menos um número ou caracter especial digitado na senha.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textConfirmeSenha.Focus();
                return;
            }

            //Verifica se existe pelo menos uma letra maiúscula.
            if (!textSenha.Text.Any(c => char.IsUpper(c)))
            {
                MessageBox.Show("Senha muito fraca. Tem que ter pelo menos um caracter maiúsculo na senha.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textSenha.Focus();
                return;
            }

            //Verifica se existe pelo menos uma letra maiúscula.
            if (!textConfirmeSenha.Text.Any(c => char.IsUpper(c)))
            {
                MessageBox.Show("Senha muito fraca. Tem que ter pelo menos um caracter maiúsculo na senha.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textConfirmeSenha.Focus();
                return;
            }

            //Verifica se existe pelo menos um caracter minúsculo.
            if (!textSenha.Text.Any(c => char.IsLower(c)))
            {
                MessageBox.Show("Senha muito fraca. Tem que ter pelo menos um caracter minúsculo na senha.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textSenha.Focus();
                return;
            }

            //Verifica se existe pelo menos um caracter minúsculo.
            if (!textConfirmeSenha.Text.Any(c => char.IsLower(c)))
            {
                MessageBox.Show("Senha muito fraca. Tem que ter pelo menos um caracter minúsculo na senha.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textConfirmeSenha.Focus();
                return;
            }

            #region Verifica se existe palavras proibidas na senha.
            //Verifica se existe palavras proibidas na senha.
            PalavrasProibidas palavra = new PalavrasProibidas();
            DataTable dts = new DataTable();

            dts = palavra.select(" where nome like '%" + textSenha.Text + "%'");

            if (dts.Rows.Count == 1)
            {
                MessageBox.Show("Esta senha possui uma palavra proibida pelo sistema. Por favor escolha outra senha.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textSenha.Focus();
                return;
            }
            #endregion

            #region Verifica se o Email ja esta sendo utilizado.
            //Verifica se o email ja esta sendo utilizado.
            Alunos aluno = new Alunos();
            DataTable dt = new DataTable();

            dt = aluno.selectVerificacaoEmail(" where email = '" + textEmail.Text + "'");

            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Este email já esta sendo utilizado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textEmail.Focus();
                textEmail.Clear();
                return;
            }
            #endregion

            #endregion

            #region Salvar os dados no Banco de Dados
            try
            {

                Alunos alunos = new Alunos();
                alunos.Nome = textNome.Text.Trim();
                alunos.Cpf = maskedTextCpf.Text;
                alunos.DataNasc = dateNasc.Text;
                alunos.Cep = maskedTextCep.Text;
                alunos.Endereco = textEndereco.Text.Trim();
                alunos.Bairro = textBairro.Text.Trim();
                alunos.TelefoneRes = maskedTextTelefoneRes.Text;
                alunos.TelefoneCel = maskedTextTelefoneCel.Text;
                alunos.Email = textEmail.Text.Trim();
                alunos.Observacao = textObservacao.Text.Trim();
                //alunos.IdCidade = comboEstado.SelectedItem.ToString();
                alunos.IdCidade = Convert.ToInt16(comboCidade.SelectedValue.ToString());
                //alunos.IdCidade = 1;

                // Comando para gravar o sexo do aluno
                if (this.radioMasc.Checked == true)
                {
                    alunos.Sexo = Convert.ToChar('M');
                }
                else
                {
                    alunos.Sexo = Convert.ToChar('F');
                }

                #region Pega o usuario que ta logado no sistema
                //Pega o usuario que ta logado no sistema
                string linha;

                using (StreamReader reader = new StreamReader("user.txt"))
                {
                    linha = reader.ReadLine();
                }
                #endregion

                alunos.IdUsuario = Convert.ToInt16(linha.ToString());
               // Console.WriteLine("USUARIO: " + Convert.ToInt16(linha.ToString()));
                alunos.Senha = getMD5(textSenha.Text.Trim() + "1Sport8Fitne55%");
                alunos.insert();

                #region Gravar o log
                //Gravacao do log
                Logs logs = new Logs();

                logs.IdUsuario = Convert.ToInt16(linha.ToString());
                logs.IdAcao = 5;
                logs.Data = DateTime.Today.ToString("dd/MM/yyyy");
                logs.Hora = DateTime.Now.ToString("HH:mm");
                logs.insert();
                #endregion

                #region Limpar os componentes
                this.dateNasc.Value = DateTime.Now.Date;
                textNome.Clear();
                maskedTextCpf.Clear();
                maskedTextCep.Clear();
                textBairro.Clear();
                comboEstado.SelectedIndex = -1;
                comboCidade.SelectedIndex = -1;
                textEndereco.Clear();
                maskedTextTelefoneRes.Clear();
                maskedTextTelefoneCel.Clear();
                textEmail.Clear();
                textSenha.Clear();
                textObservacao.Clear();
                textConfirmeSenha.Clear();
                textNome.Focus();
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            #endregion
            this.Close();
        }
        #endregion

        #region Métodos do MD5
        private string decrypt(MD5 md5Hash, string input)
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        private string getMD5(string input)
        {
            string hash;

            using (MD5 md5Hash = MD5.Create())
            {
                return hash = decrypt(md5Hash, input);
            }
        }
        #endregion

        #region Botão para cancelar
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Carrega as cidades no comboBox
        private void comboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cidades cidades = new Cidades();
                ArrayList array = cidades.selectArray("where idEstado = " + Convert.ToInt16(comboEstado.SelectedIndex+1) + " order by nome");
                comboCidade.DataSource = array;
                comboCidade.DisplayMember = "nome";
                //comboCidade.ValueMember = "idEstado";
                comboCidade.ValueMember = "id";
            }
            catch
            {

            }
        }
        #endregion

        #region Carrega os estados no comboBox
        private void FrmCadAlunos_Activated(object sender, EventArgs e)
        {
            try
            {
                Estados estados = new Estados();
                comboEstado.DataSource = estados.selectArray("order by sigla");
                comboEstado.DisplayMember = "sigla";
                comboEstado.ValueMember = "id_estado";
            }
            catch
            {

            }
        }
        #endregion

        #region Botão para gerar uma senha aleatoria no sistema
        private void btGerarSenha_Click(object sender, EventArgs e)
        {

            Random r = new Random();
            int strNumeroaleatorio;

            strNumeroaleatorio = r.Next(0, 2000);

            //Um vetor com senhas para serem geradas
            string[] nome = new string[] {
                "Password"+strNumeroaleatorio,
                "Qwerty"+strNumeroaleatorio,
                "Asdfgh"+strNumeroaleatorio,
                "ZXcvbnm"+strNumeroaleatorio,
                "Qazwsx"+strNumeroaleatorio,
                "BLinker"+strNumeroaleatorio,
                "Matrix"+strNumeroaleatorio,
                "Hello"+strNumeroaleatorio,
                "Mestre"+strNumeroaleatorio,
                "Welcome"+strNumeroaleatorio,
                "Futebol"+strNumeroaleatorio,
                "Mustang"+strNumeroaleatorio,
                "Fatec5"+strNumeroaleatorio,
                "SUnshine"+strNumeroaleatorio,
                "WshopX"+strNumeroaleatorio,
                "Apple8"+strNumeroaleatorio,
                "Carro9"+strNumeroaleatorio,
                "Sombra7"+strNumeroaleatorio,
                "SFwork"+strNumeroaleatorio,
                "DApeople"+strNumeroaleatorio,
                "Smartz"+strNumeroaleatorio,
                "News09"+strNumeroaleatorio,
                "Photo1"+strNumeroaleatorio,
                "Magazine"+strNumeroaleatorio,
                "Online03"+strNumeroaleatorio,
                "Icloud"+strNumeroaleatorio,
                "IclouD"+strNumeroaleatorio,
                "Etimes"+strNumeroaleatorio,
                "Water3"+strNumeroaleatorio,
                "dowN0"+strNumeroaleatorio,
                "Know0"+strNumeroaleatorio,
                "plAce0"+strNumeroaleatorio,
                "Xmade0"+strNumeroaleatorio,
                "Awhere1"+strNumeroaleatorio,
                "Bcame15"+strNumeroaleatorio,
                "Goodx35"+strNumeroaleatorio,
                "Through"+strNumeroaleatorio,
                "GCause0"+strNumeroaleatorio,
                "91beforE"+strNumeroaleatorio,
                "Small02"+strNumeroaleatorio,
                "Reads1"+strNumeroaleatorio,
                "Follow3"+strNumeroaleatorio,
                "Picture4"+strNumeroaleatorio,
                "World1"+strNumeroaleatorio,
                "Build0"+strNumeroaleatorio,
                "Should2"+strNumeroaleatorio,
                "Country1"+strNumeroaleatorio,
                "School0"+strNumeroaleatorio,
                "Study0"+strNumeroaleatorio,
                "Plant8"+strNumeroaleatorio,
                "Learn3"+strNumeroaleatorio,
                "Between0"+strNumeroaleatorio,
                "Together"+strNumeroaleatorio,
                "Zbegin"+strNumeroaleatorio,
                "AlwayS"+strNumeroaleatorio,
                "Letter"+strNumeroaleatorio,
                "Second"+strNumeroaleatorio,
                "RooM0"+strNumeroaleatorio,
                "MOuntain"+strNumeroaleatorio,
                "ABove"+strNumeroaleatorio,
                "Direct"+strNumeroaleatorio,
                "Black5"+strNumeroaleatorio,
                "SHort"+strNumeroaleatorio,
                "Wind1"+strNumeroaleatorio,
                "Happen"+strNumeroaleatorio,
                "SHips"+strNumeroaleatorio,
                "HalfP"+strNumeroaleatorio,
                "Piece"+strNumeroaleatorio,
                "wholE"+strNumeroaleatorio,
                "Space"+strNumeroaleatorio,
                "During"+strNumeroaleatorio,
                "Remember"+strNumeroaleatorio,
                "Listen"+strNumeroaleatorio,
                "Travel"+strNumeroaleatorio,
                "severaL"+strNumeroaleatorio,
                "Toward"+strNumeroaleatorio,
                "centeR"+strNumeroaleatorio,
                "Money"+strNumeroaleatorio,
                "Power"+strNumeroaleatorio,
                "Certain"+strNumeroaleatorio,
                "Machine"+strNumeroaleatorio,
                "Dark2"+strNumeroaleatorio,
                "Noun"+strNumeroaleatorio,
                "Field"+strNumeroaleatorio,
                "Beauty"+strNumeroaleatorio,
                "Drive"+strNumeroaleatorio,
                "Stood"+strNumeroaleatorio,
                "Front"+strNumeroaleatorio,
                "Green"+strNumeroaleatorio,
                "Quick"+strNumeroaleatorio,
                "Develop"+strNumeroaleatorio,
                "Strong"+strNumeroaleatorio,
                "Clear"+strNumeroaleatorio,
                "Street"+strNumeroaleatorio,
                "StayR"+strNumeroaleatorio,
                "Object"+strNumeroaleatorio,
                "Decide"+strNumeroaleatorio
            };

            int posicao = r.Next(nome.Length);

            string _nome = nome[posicao];

            textSenha.Text = _nome;
            textConfirmeSenha.Text = _nome;
        }
        #endregion

        #region CheckBox para mostrar a senha para usuario
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Mostrar a senha para usuario
            if (checkBox1.Checked)
            {
                textSenha.PasswordChar = '\u0000';
                textConfirmeSenha.PasswordChar = '\u0000';
            }
            else
            {
                textSenha.PasswordChar = '*';
                textConfirmeSenha.PasswordChar = '*';
            }
        }
        #endregion

        #region Verifica a força da senha
        private void textSenha_TextChanged(object sender, EventArgs e)
        {
            //Verifica se tem algo digitado no campo
            if ((textSenha.TextLength) > 0)
            {


            }
            else
            {
                labStatus.Text = "";
                return;
            }

            //Verifica o tamanho da senha
            if (textSenha.Text.Length < 6)
            {
                labStatus.Text = "Fraca";
                labStatus.ForeColor = Color.Yellow;
                return;
            }

            //Verifica o tamanho da senha
            if (textSenha.Text.Length > 12)
            {
                labStatus.Text = "Inaceitavel";
                labStatus.ForeColor = Color.Red;
                return;
            }

            //Verifica se existe pelo menos uma letra maiúscula.
            if (!textSenha.Text.Any(c => char.IsUpper(c)))
            {
                labStatus.Text = "Fraca";
                labStatus.ForeColor = Color.Yellow;
                return;
            }

            //Verifica se existe pelo menos um caracter minúsculo.
            if (!textSenha.Text.Any(c => char.IsLower(c)))
            {
                labStatus.Text = "Fraca";
                labStatus.ForeColor = Color.Yellow;
                return;
            }

            //Verifica se tem numero, letra maiuscula, minuscula na senha
            if (!textSenha.Text.Any(c => char.IsUpper(c)) || !textSenha.Text.Any(c => char.IsLower(c)) || !textSenha.Text.Any(c => char.IsDigit(c)) || !textSenha.Text.Any(c => char.IsSymbol(c)))
            {
                labStatus.Text = "Forte";
                labStatus.ForeColor = Color.Green;
                return;
            }
            else
            {
                labStatus.Text = "Segura";
                labStatus.ForeColor = Color.Blue;
                return;
            }
        }
        #endregion

        #region Botão para abrir a politica de senha
        private void button1_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmPoliticaSenha)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                FrmPoliticaSenha novoForm;
                novoForm = new FrmPoliticaSenha();
                novoForm.MdiParent = this.ParentForm;
                novoForm.Show();
            }
        }
        #endregion
    }
}