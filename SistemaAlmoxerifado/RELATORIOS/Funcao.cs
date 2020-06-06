using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlmoxerifado.RELATORIOS {
    public class Funcao {

        public static string diretorioPasta() {
            string pasta = @"";
            if (!Directory.Exists(pasta)) {
                Directory.CreateDirectory(pasta);
            }
            return pasta;
        }

    }
}
