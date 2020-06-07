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

        public List<MODEL.Requisicao> SelectByID(int id) {
            DAL.Requisicao dalRequisicao = new DAL.Requisicao();
            return dalRequisicao.SelectByID(id);
        }

        public List<MODEL.Requisicao> SelectByNome(List<MODEL.Almoxarifado> listaAlmoxarifado) {
            DAL.Requisicao dalRequisicao = new DAL.Requisicao();
            return dalRequisicao.SelectByNome(listaAlmoxarifado);
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
