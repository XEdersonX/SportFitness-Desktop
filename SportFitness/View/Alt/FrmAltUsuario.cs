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
    public partial class FrmAltUsuario : Form
    {

        int id2;

        #region Carrega os dados do Usuário
        public FrmAltUsuario(int id)
        {
            InitializeComponent();

            Usuarios usuarios = new Usuarios();
            ArrayList array = usuarios.selectArray("where id_login = " + id);

            foreach (Usuarios usuario in array)
            {
                id2 = usuario.Id;
                textNome.Text = usuario.Nome;
                //textSenha.Text = usuario.Senha;
                comboTipo.SelectedItem = usuario.IsAdmin;
            }

        }
        #endregion

        #region Botão para Salvar
        private void btSalvar_Click(object sender, EventArgs e)
        {
            #region Validação dos componentes
            if (textNome.Text.Trim().Equals(""))
            {
                MessageBox.Show("Digite um nome válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textNome.Focus();
                return;
            }

            if (comboTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um tipo de usuário válido.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboTipo.Focus();
                return;
            }
            #endregion

            #region Verifica se existe alguma palavra proibida na senha
            //Verifica se existe alguma palavra proibida na senha.
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


            try
            {
                #region Verifica se o nome de usuario já esta sendo utilizado
                Usuarios usuarios = new Usuarios();
                DataTable dt = new DataTable();

                ////Verifica se o nome ja esta sendo utilizado pelo usuario que tas alterando.
                dt = usuarios.select(" where nome = '" + textNome.Text + "'" + " and id_login != " + id2);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Este nome de usuário já esta sendo utilizado.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textNome.Focus();
                    textNome.Clear();
                    return;
                }
                #endregion

                #region Validação da politica de senha
                if (textSenha.Text.Trim().Equals("") && textConfirmeSenha.Text.Trim().Equals(""))
                {
                    usuarios.Id = Convert.ToInt16(id2);
                    usuarios.Nome = textNome.Text.Trim();
                    //usuarios.Senha = getMD5(textSenha.Text.Trim());
                    usuarios.IsAdmin = comboTipo.SelectedItem.ToString();
                    usuarios.updateVerificaSenha();
                }
                else{
                    //Verifica se a senha digitada nos dois campos sao iguais.
                    if (textSenha.Text.Trim() != textConfirmeSenha.Text.Trim())
                    {
                        MessageBox.Show("Senha incorreta.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textConfirmeSenha.Focus();
                        return;
                    }

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

                    #region Alterar os dados
                    usuarios.Id = Convert.ToInt16(id2);
                    usuarios.Nome = textNome.Text.Trim();
                    //Utilização do SALT na senha
                    usuarios.Senha = getMD5(textSenha.Text.Trim() + "1Sport8Fitne55%");
                    usuarios.IsAdmin = comboTipo.SelectedItem.ToString();
                    usuarios.update();
                    #endregion
                }
                MessageBox.Show("Usuário Alterado com Sucesso.");
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
                logs.IdAcao = 12;
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
        }
        #endregion

        #region Métodos para o MD5
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

        #region Botão de Cancelar
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Método para fechar a janela no ESC
        private void FrmAltUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27)) //ESC
            {
                this.Close();
            }
        }
        #endregion

        #region Botão para chamar a politica de senha
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

        #region Método para mostrar a senha do usuário
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

        #region Botão para gerar uma senha
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

        #region Método para verificar a força da senha
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
    }
}