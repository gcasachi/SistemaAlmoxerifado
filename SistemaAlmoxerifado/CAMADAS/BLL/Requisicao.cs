using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlmoxerifado.CAMADAS.BLL {
    class Requisicao {

        public List<MODEL.Requisicao> Select() {
            DAL.Requisicao dalRequisicao = new DAL.Requisicao();
            return dalRequisicao.Select();
        }

        public void Insert(MODEL.Requisicao requisicao) {
            DAL.Requisicao dalRequisicao = new DAL.Requisicao();
            dalRequisicao.Insert(requisicao);
        }

        public void Update(MODEL.Requisicao requisicao) {
            DAL.Requisicao dalRequisicao = new DAL.Requisicao();
            dalRequisicao.Update(requisicao);
        }

        public void Delete(int idRequisicao) {
            DAL.Requisicao dalRequisicao = new DAL.Requisicao();
            dalRequisicao.Delete(idRequisicao);
        }
    }
}
