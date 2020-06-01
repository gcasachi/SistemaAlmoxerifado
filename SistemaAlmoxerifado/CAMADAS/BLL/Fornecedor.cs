using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlmoxerifado.CAMADAS.BLL {
    public class Fornecedor {
        
        public List<MODEL.Fornecedor> Select() {
            DAL.Fornecedor dalFornecedor = new DAL.Fornecedor();
            return dalFornecedor.Select();
        }

        public MODEL.Fornecedor SelectByID(int idFornecedor) {
            DAL.Fornecedor dalFornecedor = new DAL.Fornecedor();
            return dalFornecedor.SelectByID(idFornecedor);
        }

        public void Insert(MODEL.Fornecedor fornecedor) {
            DAL.Fornecedor dalFornecedor = new DAL.Fornecedor();
            dalFornecedor.Insert(fornecedor);
        }

        public void Update(MODEL.Fornecedor fornecedor) {
            DAL.Fornecedor dalFornecedor = new DAL.Fornecedor();
            dalFornecedor.Update(fornecedor);
        }

        public void Delete(int idFornecedor) {
            DAL.Fornecedor dalFornecedor = new DAL.Fornecedor();
            dalFornecedor.Delete(idFornecedor);
        }
    }
}
