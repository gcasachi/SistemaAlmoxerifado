using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlmoxerifado.RELATORIOS {
    public class Funcao {

        public static string diretorioPasta() {
            string pasta = @"C:\Users\gcasa\OneDrive\Ciencias da Computação\2 - Ano\Almir - Linguagem de Programação\1 - Semestre\c#\Relatorios";
            if (!Directory.Exists(pasta)) {
                Directory.CreateDirectory(pasta);
            }
            return pasta;
        }

    }
}
