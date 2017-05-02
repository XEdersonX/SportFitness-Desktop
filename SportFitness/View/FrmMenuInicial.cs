using iTextSharp.text;
using iTextSharp.text.pdf;
using SportFitness.model;
using SportFitness.View.Backup;
using SportFitness.View.Report;
using SportFitness.View.Tab;
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
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportFitness.View
{
    public partial class FrmMenuInicial : System.Windows.Forms.Form
    {

        #region Realiza o controle das permissões pelo usuário
        public FrmMenuInicial()
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            Usuarios user = new Usuarios();

            using (MD5 md5 = MD5.Create())
            {
                string caminho = File.ReadLines("tempAcademia.txt").Skip(1).Take(1).First();
                string caminho2 = File.ReadLines("tempAcademia.txt").Skip(2).Take(1).First();

                //Realiza a consulta no banco de dados
                dt = user.select(" where nome = '" + caminho + "' and senha = '" + caminho2 + "' and isAdmin = 'Treinador'");
            }

            //Desativa as funções que nao são permitidas para o Treinador
            if (dt.Rows.Count == 1)
            {
                graToolStripMenuItem.Enabled = false;
                //financeiroToolStripMenuItem.Enabled = false;
                reToolStripMenuItem.Enabled = false;
                funcionariosToolStripMenuItem.Enabled = false;
                frequênciaToolStripMenuItem.Enabled = false;
                usuariosToolStripMenuItem.Enabled = false;
                //noticiasToolStripMenuItem.Enabled = false;
                //btFinanceiro.Enabled = false;
                btFuncionarios.Enabled = false;
                //btNoticias.Enabled = false;
                backupToolStripMenuItem.Enabled = false;
                logsToolStripMenuItem.Enabled = false;
                btFrequencia.Enabled = false;
            }
        }
        #endregion

        private void FrmMenuInicial_Load(object sender, EventArgs e)
        {
            #region Pega a Data do computador
            DateTime dt = DateTime.Now;
            toolData.Text = dt.ToShortDateString();
            #endregion

            #region Deleta o arquivo TXT tempAcademia
            try
            {
                File.Delete(AppDomain.CurrentDomain.BaseDirectory + "\\tempAcademia.txt");
            }
            catch
            {

            }
            #endregion

            #region Muda o fundo do FORM
            MdiClient ctlMDI = (MdiClient)this.Controls[this.Controls.Count - 1];
            ctlMDI.BackColor = Color.White;
            //ISSO MUDA COR DE FUNDO DO FORM MDI PAI PARA BRANCO
            ctlMDI.BackgroundImage = this.BackgroundImage;
            //AQUI COLOCAMOS A IMAGEM DE FUNDO
            //ONDE DIZEMOS Q A IMAGEM DE FUNDO DO NOSSO MDICLIENTE Q É O NÍVEL MAIS BAIXO DOS MDIs
            //É IGUAL A IMAGEM DE FUNDO DO FORMS PAI ASSUMINDO TODAS AS SUAS CONFIGURAÇÕES COMO SUA POSIÇÃO CENTRALIZADA NA TELA
            #endregion

            #region Verifica o ultimo acesso do usuário
            Logs logs = new Logs();
            Usuarios usuarios = new Usuarios();

            string linha;

            using (StreamReader reader = new StreamReader("user.txt"))
            {
                linha = reader.ReadLine();
            }

            int idUsuario = Convert.ToInt16(linha.ToString());

            ArrayList lista = logs.selectArray("where idUsuario = " + idUsuario);
            ArrayList lista2 = logs.selectArrayMaxId("where idUsuario = " + idUsuario + " ORDER BY id_log DESC LIMIT 1,1;");
            ArrayList listaNome = usuarios.selectArray("where id_login = " + idUsuario);

            if (lista.Count >= 2)
            {
                foreach (Logs log in lista2)
                {
                    toolStripStatus.Text = "Ultimo Acesso: " + log.Data + " às " + log.Hora;
                }
            }
            else
            {
                foreach (Usuarios usuario in listaNome)
                {
                    toolStripStatus.Text = "Ultimo Acesso: Bem-Vindo " + usuario.Nome;
                }
            }
            #endregion
        }

        #region ToolStrips
        //Método que chama o form de Alunos
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmTabAlunos)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                FrmTabAlunos novoForm;
                novoForm = new FrmTabAlunos();
                novoForm.MdiParent = this;
                novoForm.Show();
            }
        }

        //private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        //{
        //    Boolean existe = false;
        //    foreach (Form openForm in Application.OpenForms)
        //    {
        //        if (openForm is FrmTabAlunos)
        //        {
        //            openForm.BringToFront();
        //            existe = true;
        //        }
        //    }
        //    if (!existe)
        //    {
        //        FrmTabAlunos novoForm;
        //        novoForm = new FrmTabAlunos();
        //        novoForm.MdiParent = this;
        //        novoForm.Show();
        //    }
        //}

        //Método que chama o form de Treinadores
        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmTabTreinadores)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                FrmTabTreinadores novoForm;
                novoForm = new FrmTabTreinadores();
                novoForm.MdiParent = this;
                novoForm.Show();
            }
        }

        //private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Boolean existe = false;
        //    foreach (Form openForm in Application.OpenForms)
        //    {
        //        if (openForm is FrmTabTreinadores)
        //        {
        //            openForm.BringToFront();
        //            existe = true;
        //        }
        //    }
        //    if (!existe)
        //    {
        //        FrmTabTreinadores novoForm;
        //        novoForm = new FrmTabTreinadores();
        //        novoForm.MdiParent = this;
        //        novoForm.Show();
        //    }
        //}

        //Método que chama o form de Usuários
        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmTabUsuarios)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                FrmTabUsuarios novoForm;
                novoForm = new FrmTabUsuarios();
                novoForm.MdiParent = this;
                novoForm.Show();
            }
        }

        //Método que chama o form de Treinos
        private void treinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmTabTreinos)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                FrmTabTreinos novoForm;
                novoForm = new FrmTabTreinos();
                novoForm.MdiParent = this;
                novoForm.Show();
            }
        }

        //Método que chama o form de Avaliações
        private void avaliaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmTabAvaliacao)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                FrmTabAvaliacao novoForm;
                novoForm = new FrmTabAvaliacao();
                novoForm.MdiParent = this;
                novoForm.Show();
            }
        }

        //Método que chama o form de Objetivos
        private void objetivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmTabObjetivos)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                FrmTabObjetivos novoForm;
                novoForm = new FrmTabObjetivos();
                novoForm.MdiParent = this;
                novoForm.Show();
            }
        }

        //Método que chama o form de Grupo Muscular
        private void gruposMuscularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmTabGrupoMuscular)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                FrmTabGrupoMuscular novoForm;
                novoForm = new FrmTabGrupoMuscular();
                novoForm.MdiParent = this;
                novoForm.Show();
            }
        }

        //Método que chama o form de Notícias
        private void noticiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmTabNoticias)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                FrmTabNoticias novoForm;
                novoForm = new FrmTabNoticias();
                novoForm.MdiParent = this;
                novoForm.Show();
            }
        }

        //Método que chama o form de Exercicios
        private void exerciciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmTabExercicios)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                FrmTabExercicios novoForm;
                novoForm = new FrmTabExercicios();
                novoForm.MdiParent = this;
                novoForm.Show();
            }
        }

        //Método que chama o form dos Graficos
        private void graToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmGraficos)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                FrmGraficos novoForm;
                novoForm = new FrmGraficos();
                novoForm.MdiParent = this;
                novoForm.Show();
            }
        }

        //Método que chama o form do Relatorio
        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmRelatorioUsuarios novaform = new FrmRelatorioUsuarios();
            //novaform.Show();

            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmRelatorioUsuarios)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                FrmRelatorioUsuarios novoForm;
                novoForm = new FrmRelatorioUsuarios();
                novoForm.MdiParent = this;
                novoForm.Show();
            }
        }
        #endregion

        #region Relatórios
        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //StreamWriter wr = new StreamWriter(@"c:\arquivos\relatCarros1.html");
            //wr.WriteLine("<html>");
            //wr.WriteLine("<head>");
            //wr.WriteLine("<meta name='viewport' content='width=device-width, initial-scale=1'>");
            //wr.WriteLine("<meta charset='utf-8'>");
            //wr.WriteLine("<link rel='stylesheet' href='css/bootstrap.min.css'>");
            //wr.WriteLine("<script src='https://ajax.googleapis.com/ajax/libs/jquery/1.12.2/jquery.min.js'></script>");
            //wr.WriteLine("<script src='js/bootstrap.min.js'></script>");
            //wr.WriteLine("<div class='container'>");
            
            //wr.WriteLine("<div class='col-md-6'>");
            //wr.WriteLine("<p>");
            //wr.WriteLine("<img src='img/logo.ico' class='img-responsive' alt='Imagem Responsiva'>");
            
            //wr.WriteLine("<center><h1>Relatório de Alunos</h1></center>");
            //wr.WriteLine("</p>");
            //wr.WriteLine("</div>");
            
            
            //wr.WriteLine("</head>");

            //wr.WriteLine("<div class='table-responsive'>");
            //wr.WriteLine("<table class='table table-hover'>");
            //wr.WriteLine("<thead>");
            //wr.WriteLine("<tr>");
            //wr.WriteLine("<th>Id</th>");
            //wr.WriteLine("<th>Nome</th>");
            //wr.WriteLine("<th>Data Nascimento</th>");
            //wr.WriteLine("<th>CPF</th>");
            //wr.WriteLine("<th>CEP</th>");
            //wr.WriteLine("<th>Endereço</th>");
            //wr.WriteLine("<th>Telefone Res.</th>");
            //wr.WriteLine("<th>Telefone Cel.</th>");
            //wr.WriteLine("<th>Email</th>");
            //wr.WriteLine("<th>Observação</th>");
            //wr.WriteLine("</tr>");
            //wr.WriteLine("</thead>");
            //wr.WriteLine("</tbody>");
            //Alunos alunos = new Alunos();
            //ArrayList arrayAluno = alunos.selectArray();

            //foreach (Alunos aluno in arrayAluno)
            //{
            //    wr.WriteLine("<tr><td>" + aluno.Id + "</td>");
            //    wr.WriteLine("<td>" + aluno.Nome + "</td>");
            //    wr.WriteLine("<td>" + aluno.DataNasc + "</td>");
            //    wr.WriteLine("<td>" + aluno.Cpf + "</td>");
            //    wr.WriteLine("<td>" + aluno.Cep + "</td>");
            //    wr.WriteLine("<td>" + aluno.Endereco + "</td>");
            //    wr.WriteLine("<td>" + aluno.TelefoneRes + "</td>");
            //    wr.WriteLine("<td>" + aluno.TelefoneCel + "</td>");
            //    wr.WriteLine("<td>" + aluno.Email + "</td>");
            //    wr.WriteLine("<td>" + aluno.Observacao + "</td>");
            //    wr.WriteLine("</tr>");
            //}

            //wr.WriteLine("</tbody>");
            //wr.WriteLine("</table>");
            //wr.WriteLine("</div>");
            //wr.WriteLine("</div>");
            //wr.WriteLine("</body>");
            //wr.WriteLine("</html>");

            //wr.Close();

            //// System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", @"c:\arquivos\relatCarros1.html");
            //System.Diagnostics.Process.Start(@"C:\Program Files\Internet Explorer\iexplore.exe", @"c:\arquivos\relatCarros1.html");

        }

        private void funcionáriosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Treinadores funcionarios = new Treinadores();

            //ArrayList listaFunc = funcionarios.selectArray();

            //if (listaFunc.Count > 0)
            //{
            //    DialogResult resposta = MessageBox.Show("Gerar relatório de funcionários cadastrados?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            //    if (resposta == DialogResult.Yes)
            //    {
            //        try
            //        {
            //            Document doc = new Document();

            //            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("RelatórioFunc.pdf", FileMode.Create));

            //            doc.Open();

            //            iTextSharp.text.Font fonteDados = FontFactory.GetFont("Courier");
            //            fonteDados.Size = 10;

            //            int linha = 0;

            //            foreach (Treinadores func in listaFunc)
            //            {
            //                if (linha == 0)
            //                {
            //                    cabecalho(doc, 1);
            //                }

            //                linha++;

            //                doc.Add(new Paragraph("Código......: " + func.Id, fonteDados));
            //                doc.Add(new Paragraph("Nome........: " + func.Nome, fonteDados));
            //                //doc.Add(new Paragraph("Sobrenome...: " + func.Sobrenome, fonteDados));
            //                //doc.Add(new Paragraph("Tipo........: " + func.Tipo, fonteDados));
            //                doc.Add(new Paragraph("Email.......: " + func.Email, fonteDados));
            //                doc.Add(new Paragraph("Telefone Cel: " + func.TelefoneCel, fonteDados));
            //                doc.Add(new Paragraph("CPF.........: " + func.Cpf, fonteDados));
            //                doc.Add(new Paragraph(" ", fonteDados));

            //                if (linha == 5)
            //                {
            //                    linha = 0;
            //                    pageNumber(doc, writer);
            //                }
            //            }

            //            rodape(doc, writer);

            //            doc.Close();

            //            System.Diagnostics.Process.Start("RelatórioFunc.pdf");
            //        }
            //        catch
            //        {

            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Não há funcionários cadastrados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmRelatorioTreinadores)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                FrmRelatorioTreinadores novoForm;
                novoForm = new FrmRelatorioTreinadores();
                novoForm.MdiParent = this;
                novoForm.Show();
            }
        }

        private void financeiroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Matriculas matricula = new Matriculas();

            //ArrayList listaMat = matricula.relFinanceiro(Convert.ToInt16(System.DateTime.Now.ToString("yyyy")));

            //if (listaMat.Count > 0)
            //{
            //    DialogResult resposta = MessageBox.Show("Gerar relatório do financeiro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            //    if (resposta == DialogResult.Yes)
            //    {
            //        try
            //        {
            //            Document doc = new Document();

            //            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("RelatórioRendaMensal" + System.DateTime.Now.ToString("yyyy") + ".pdf", FileMode.Create));

            //            doc.Open();

            //            iTextSharp.text.Font fonteDados = FontFactory.GetFont("Courier");
            //            fonteDados.Size = 10;

            //            cabecalho(doc, 2);
            //            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

            //            for (int i = 0; i < listaMat.Count; i++)
            //            {
            //                doc.Add(new Paragraph("Mês......: " + meses[i], fonteDados));
            //                doc.Add(new Paragraph("Ganhos R$: " + listaMat[i], fonteDados));
            //                //doc.Add(new Paragraph("Alunos...: " + listaMat[i + 1], fonteDados));
            //                doc.Add(new Paragraph(" ", fonteDados));
            //            }

            //            rodape(doc, writer);
            //            doc.Close();

            //            System.Diagnostics.Process.Start("RelatórioRendaMensal" + System.DateTime.Now.ToString("yyyy") + ".pdf");
            //        }
            //        catch
            //        {

            //        }
            //    }
            //}
        }
        #endregion

        #region Configurações dos Relatórios
        private void pageNumber(Document doc, PdfWriter writer)
        {
            iTextSharp.text.Font fonteCab = FontFactory.GetFont("Courier");
            fonteCab.Size = 10;

            int pageN = writer.PageNumber;

            Paragraph cab = new Paragraph("Página " + pageN, fonteCab);
            cab.Alignment = Element.ALIGN_CENTER;
            doc.Add(cab);
        }

        private void cabecalho(Document doc, int num)
        {
            // gera uma nova página
            doc.NewPage();

            // define a fonte a ser utilizada
            iTextSharp.text.Font fonteCab = FontFactory.GetFont("Courier");
            fonteCab.Size = 12;
            fonteCab.SetStyle(2);
            fonteCab.SetColor(5, 0, 125);

            Paragraph cab = new Paragraph("Academia SportFitness", fonteCab);
            cab.Alignment = Element.ALIGN_CENTER;
            doc.Add(cab);

            if (num == 0)
            {
                cab = new Paragraph("Relatório de Alunos Cadastrados", fonteCab);
            }
            else if (num == 1)
            {
                cab = new Paragraph("Relatório de Funcionários Cadastrados", fonteCab);
            }
            else if (num == 2)
            {
                cab = new Paragraph("Relatório do Financeiro (Renda Mensal)", fonteCab);
            }
            cab.Alignment = Element.ALIGN_CENTER;
            doc.Add(cab);

            // muda o tamanho da fonte
            fonteCab.Size = 10;
            fonteCab.SetColor(0, 0, 0);

            cab = new Paragraph(geraTracos(87), fonteCab);
            cab.Alignment = Element.ALIGN_CENTER;
            doc.Add(cab);
        }

        private void rodape(Document doc, PdfWriter writer)
        {
            // define a fonte a ser utilizada
            iTextSharp.text.Font fonteCab = FontFactory.GetFont("Courier");
            fonteCab.Size = 10;

            Paragraph cab = new Paragraph(geraTracos(87), fonteCab);
            cab.Alignment = Element.ALIGN_CENTER;
            doc.Add(cab);
            pageNumber(doc, writer);
        }

        private string geraTracos(int num)
        {
            string tracos = "";

            for (int i = 1; i <= num; i++)
            {
                tracos = tracos + "-";
            }

            return tracos;
        }
        #endregion

        #region Método para o MD5
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

        #region Método para fechar a janela
        private void FrmMenuInicialAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            #region Gravar o Log
            //Geracao do log
            try
            {
                Logs logs = new Logs();
                string linha;

                using (StreamReader reader = new StreamReader("user.txt"))
                {
                    linha = reader.ReadLine();
                }

                logs.IdUsuario = Convert.ToInt16(linha.ToString());
                logs.IdAcao = 2;
                logs.Data = DateTime.Today.ToString("dd/MM/yyyy");
                logs.Hora = DateTime.Now.ToString("HH:mm");
                logs.insert();
            }
            catch
            {

            }
            #endregion

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

            #region Deleta o arquivo TXT tempAcademia
            try
            {
                File.Delete(AppDomain.CurrentDomain.BaseDirectory+"\\tempAcademia.txt");
            }
            catch
            {

            }
            #endregion

            #region Método para realizar do start no mysql
            FileInfo fi = new FileInfo("c:\\xampp\\mysql\\bin\\mysqladmin.exe");
            if (fi.Exists)
            {
                Process.Start(fi.FullName, "--user=root shutdown");
            }
            else
            {
                MessageBox.Show("This isn't mysql installation directory!");
            }
            #endregion

        }
        #endregion

        #region Botão de sair
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region Gravar o log
            Logs logs = new Logs();
            string linha;

            using (StreamReader reader = new StreamReader("user.txt"))
            {
                linha = reader.ReadLine();
            }

            logs.IdUsuario = Convert.ToInt16(linha.ToString());
            logs.IdAcao = 2;
            logs.Data = DateTime.Today.ToString("dd/MM/yyyy");
            logs.Hora = DateTime.Now.ToString("HH:mm");
            logs.insert();
            #endregion

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

            #region Deleta o arquivo TXT user
            File.Delete(AppDomain.CurrentDomain.BaseDirectory + "\\user.txt");
            Application.Exit();
            #endregion
        }
        #endregion

        #region Botão para chamar as notícias
        private void button1_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmTabNoticias)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                FrmTabNoticias novoForm;
                novoForm = new FrmTabNoticias();
                novoForm.MdiParent = this;
                novoForm.Show();
            }
        }
        #endregion

        #region Botão para chamar os Graficos
        private void btGraficos_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmGraficos)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                FrmGraficos novoForm;
                novoForm = new FrmGraficos();
                novoForm.MdiParent = this;
                novoForm.Show();
            }
        }
        #endregion

        #region Exporta os dados das notícias para um TXT
        private void exportarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\noticiasAndroid.txt");

            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\noticiasAndroid.txt"))
            {
                Noticias noticias = new Noticias();
                ArrayList array = noticias.selectArray();

                foreach (Noticias noticia in array)
                {
                    sw.WriteLine(noticia.Id + ";" + noticia.Data + ";" + noticia.Titulo + ";" + noticia.Texto + "#");
                }
                sw.Close();
            }
        }
        #endregion

        #region Chama o form do Backup
        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmBackup)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                FrmBackup novoForm;
                novoForm = new FrmBackup();
                novoForm.MdiParent = this;
                novoForm.Show();
            }
        }
        #endregion

        #region Chama o form dos Logs
        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmLogs)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                FrmLogs novoForm;
                novoForm = new FrmLogs();
                novoForm.MdiParent = this;
                novoForm.Show();
            }
        }
        #endregion

        #region Botão da frequência
        private void button1_Click_1(object sender, EventArgs e)
        {
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmFrequencia)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                FrmFrequencia novoForm;
                novoForm = new FrmFrequencia();
                novoForm.MdiParent = this;
                novoForm.Show();
            }
        }
        #endregion

        #region ToolStrip da frequência
        private void frequênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Boolean existe = false;
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is FrmFrequencia)
                {
                    openForm.BringToFront();
                    existe = true;
                }
            }
            if (!existe)
            {
                FrmFrequencia novoForm;
                novoForm = new FrmFrequencia();
                novoForm.MdiParent = this;
                novoForm.Show();
            }
        }
        #endregion
    }
}