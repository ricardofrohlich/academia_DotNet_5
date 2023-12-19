using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_WinFormsApp_SerializadorJSON
{
    public class Arquivo
    {
        public static string lerArquivo(string dadosArquivo)
        {
            using (var leitor = new StreamReader(dadosArquivo))
            {
                return leitor.ReadToEnd();
            }   
        }
    }
}
