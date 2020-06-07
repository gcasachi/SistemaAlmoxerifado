using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlmoxerifado.CAMADAS.BLL {
    public class Almoxarifado {

        public List<MODEL.Almoxarifado> Select() {
            DAL.Almoxarifado dalAlmoxarifado = new DAL.Almoxarifado();
            return dalAlmoxarifado.Select();
        }

        public List<MODEL.Almoxarifado> SelectByID(int id) {
            DAL.Almoxarifado dalAlmoxarifado = new DAL.Almoxarifado();
            return dalAlmoxarifado.SelectByID(id);
        }

        public List<MODEL.Almoxarifado> SelectByNome(string nome) {
            DAL.Almoxarifado dalAlmoxarifado = new DAL.Almoxarifado();
            return dalAlmoxarifado.SelectByNome(nome);
        }

        public void Insert(MODEL.Almoxarifado almoxarifado) {
            DAL.Almoxarifado dalAlmoxarifado = new DAL.Almoxarifado();
            dalAlmoxarifado.Insert(almoxarifado);
        }

        public void Update(MODEL.Almoxarifado almoxarifado) {
            DAL.Almoxarifado dalAlmoxarifado = new DAL.Almoxarifado();
            dalAlmoxarifado.Update(almoxarifado);
        }

        public void Delete(int idAlmoxarifado) {
            DAL.Almoxarifado dalAlmoxarifado = new DAL.Almoxarifado();
            dalAlmoxarifado.Delete(idAlmoxarifado);
        }
    }
}
