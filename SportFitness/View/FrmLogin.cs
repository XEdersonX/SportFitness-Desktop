using SportFitness.model;
using SportFitness.View;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportFitness
{
    public partial class FrmLogin : Form
    {
        #region Deleta o arquivo TXT do user
        public FrmLogin()
        {
            InitializeComponent();
            File.Delete(AppDomain.CurrentDomain.BaseDirectory + "\\user.txt");
        }
        #endregion

        #region Botão de Acesso para realizar a Autenticação do Usuário ao sistema
        private void btAcessar_Click(object sender, EventArgs e)
        {
            Usuarios user = new Usuarios();
            DataTable dt = new DataTable();

            //Usando o SALT na senha
            string senha = getMD5(textSenha.Text + "1Sport8Fitne55%");

            try
            {
                dt = user.select(" where nome = '" + textUsuario.Text + "' and senha = '" + senha + "'");

                if (dt.Rows.Count == 1)
                {
                    //Cria os arquivos TXT
                    StreamWriter us = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\user.txt", false);
                    StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\tempAcademia.txt", false);

                    // Verifica se encontrou o usuário (login/senha)
                    if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\tempAcademia.txt"))
                    {
                        try
                        {
                            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "\\tempAcademia.txt", string.Empty);
                            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "\\user.txt", string.Empty);

                        }
                        catch
                        {

                        }
                    }

                    Usuarios usuarios = new Usuarios();
                    //Procura o Usuário no Banco de Dados
                    ArrayList array = usuarios.selectArray(" where nome = '"+ textUsuario.Text +"' and senha = '" + senha + "'");

                    foreach (Usuarios usuario in array)
                    {
                        //Grava o id do usuário no arquivo TXT
                        us.WriteLine(usuario.Id);
                        us.Close(); //Fecha o arquivo texto
                    }


                    sw.WriteLine(getMD5(reverse(textUsuario.Text)));
                    sw.WriteLine(textUsuario.Text);

                    //Usando o SALT na senha
                    sw.WriteLine(getMD5(textSenha.Text + "1Sport8Fitne55%"));
                    sw.WriteLine(getMD5(reverse(textSenha.Text + "1Sport8Fitne55%")));
                    sw.Close(); //Fecha o arquivo texto

                    #region Gravar o log
                    Logs logs = new Logs();
                    string linha;

                    using (StreamReader reader = new StreamReader("user.txt"))
                    {
                        linha = reader.ReadLine();
                    }

                    logs.IdUsuario = Convert.ToInt16(linha.ToString());
                    logs.IdAcao = 1;
                    logs.Data = DateTime.Today.ToString("dd/MM/yyyy");
                    logs.Hora = DateTime.Now.ToString("HH:mm");
                    logs.insert();
                    #endregion

                    FrmLoading loading = new FrmLoading();
                    loading.Show();

                    // Ok, indica usuário válido
                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                  
                }
                else
                {
                    //Exibe a mensagem de erro
                    MessageBox.Show("Erro... Usuário ou senha inválidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textUsuario.Clear();
                    textUsuario.Focus();
                    textSenha.Clear();
                }

            }
            catch
            {
                //Exibe a mensagem de erro
                MessageBox.Show("Erro ao conectar no banco de dados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
        }
        #endregion

        #region Método para inverter uma String
        private string reverse(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        #endregion

        #region Métodos para realizar o MD5
        /*
            Método para gerar uma hash MD5 de uma String
        */
        private string hash(MD5 md5Hash, string input)
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
            string md5;

            using (MD5 md5Hash = MD5.Create())
            {
                return md5 = hash(md5Hash, input);
            }
        }
        #endregion

        #region Botão para Sair
        private void btSair_Click(object sender, EventArgs e)
        {
            //Terminar o processo
            try
            {
                var processes = Process.GetProcessesByName("xampp-control");
                foreach (var p in processes)
                    p.Kill();
            }
            catch (Exception ex)
            {

            }

            this.Close();
        }
        #endregion

        #region Método para realizar do start no mysql e Apache
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //FileInfo fi = new FileInfo("c:\\xampp\\mysql\\bin\\mysqld.exe");
            //if (fi.Exists)
            //{
            //    Process.Start(fi.FullName);
            //}
            //else
            //{
            //    MessageBox.Show("this isn't mysql installation directory");
            //}


            //Tem que ir no xampp e configurar para o mysql e o apache start automaticamente com o xampp minimizado nas config
            FileInfo fie = new FileInfo("c:\\xampp\\xampp-control.exe");
            if (fie.Exists)
            {
                Process.Start(fie.FullName);
            }
            else
            {
                MessageBox.Show("this isn't Apache installation directory");
            }
        }
        #endregion

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Terminar o processo
            try {
                var processes = Process.GetProcessesByName("xampp-control");
                foreach (var p in processes)
                    p.Kill();
            }catch(Exception ex)
            {

            }
        }
    }
}