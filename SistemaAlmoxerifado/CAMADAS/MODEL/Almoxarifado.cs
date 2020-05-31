using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlmoxerifado.CAMADAS.MODEL {
    public class Almoxarifado {

        public int id { get; set; }
        public int fornecedorID { get; set; }
        public string nome { get; set; }
        public int quantidade { get; set; }
    }
}
