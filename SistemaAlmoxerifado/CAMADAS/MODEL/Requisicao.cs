using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlmoxerifado.CAMADAS.MODEL {
    class Requisicao {

        public int id { get; set; }
        public int setorID { get; set; }
        public string setor{ get; set; }
        public int produtoID { get; set; }
        public string produto { get; set; }
        public int quantidade { get; set; }
        public DateTime data { get; set; }
    }
}
