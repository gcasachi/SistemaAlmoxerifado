using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlmoxerifado.CAMADAS.DAL {
    class Conexao {

        public static string getConexao() {
            return @"Data Source=.;Initial Catalog=SISTEMA_ALMOXARIFADO;Integrated Security=True";
        }
    }
}
