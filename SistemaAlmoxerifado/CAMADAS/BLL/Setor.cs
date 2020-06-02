using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlmoxerifado.CAMADAS.BLL {
    public class Setor {
        public List<MODEL.Setor> Select() {
            DAL.Setor dalSetor = new DAL.Setor();
            return dalSetor.Select();
        }

        public MODEL.Setor SelectByID(int idSetor) {
            DAL.Setor dalSetor = new DAL.Setor();
            return dalSetor.SelectByID(idSetor);
        }

        public void Insert(MODEL.Setor setor) {
            DAL.Setor dalSetor = new DAL.Setor();
            dalSetor.Insert(setor);
        }

        public void Update(MODEL.Setor setor) {
            DAL.Setor dalSetor = new DAL.Setor();
            dalSetor.Update(setor);
        }

        public void Delete(int idSetor) {
            DAL.Setor dalSetor = new DAL.Setor();
            dalSetor.Delete(idSetor);
        }
    }
}
