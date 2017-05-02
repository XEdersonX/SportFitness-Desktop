using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace sportFitness
{
    class dbConnection
    {
        public static string Conecta
        {
            get
            {
                string linha, conexao;
                try
                {
                    StreamReader file = new StreamReader("\\SportFitness\\sport.ini");

                    linha = file.ReadLine();

                    int p1 = linha.IndexOf("STR=") + 4;
                    int p2 = linha.Length - 4;
                    conexao = "" + linha.Substring(p1, p2) + "";

                    //return @"Persist Security Info=false;server=localhost;database=SportFitness;uid=root";
                    return conexao;
                }
                catch
                {
                    return "";
                }
            }
        }
    }
}