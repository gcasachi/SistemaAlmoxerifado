using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlmoxerifado.RELATORIOS {
    class relAlmoxarifado {

        public static void gerarReqAlmoxarifado() {
            CAMADAS.BLL.Almoxarifado bllAlmo = new CAMADAS.BLL.Almoxarifado();
            List<CAMADAS.MODEL.Almoxarifado> lstAlmoxarifado = new List<CAMADAS.MODEL.Almoxarifado>();
            lstAlmoxarifado = bllAlmo.Select();

            string pasta = Funcao.diretorioPasta();
            string arquivo = pasta + @"\RelatorioAlmoxarifado.html";

            StreamWriter sw = new StreamWriter(arquivo);
            using (sw) {
                sw.WriteLine("<html lang='pt-br'>");
                sw.WriteLine("<head>");

                sw.WriteLine("<meta charset='UTF - 8'>");
                sw.WriteLine("<meta name='viewport' content='width = device - width, initial - scale = 1.0'>");
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css' integrity='sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk' crossorigin='anonymous'>");
                sw.WriteLine("<title>Relatorio Almoxarifado</title>");

                sw.WriteLine("</head>");

                sw.WriteLine("<body>");

                sw.WriteLine("<br><hr border='5px' />");
                sw.WriteLine("<h1> Relatório do Almoxarifado </h1>");
                sw.WriteLine("<hr border='5px' /><br>");                

                sw.WriteLine("<table class='table'>");                

                sw.WriteLine("<thead class='thead-dark'>");
                sw.WriteLine("<tr align='center'>");

                sw.WriteLine("<th>ID</th>");
                sw.WriteLine("<th>FORNECEDOR</th>");
                sw.WriteLine("<th>PRODUTO</th>");
                sw.WriteLine("<th>QUANTIDADE</th>");                     

                sw.WriteLine("</thead class='thead-dark'>");
                sw.WriteLine("</tr>");


                foreach (CAMADAS.MODEL.Almoxarifado almoxarifado in lstAlmoxarifado) {
                    sw.WriteLine("<tr align='center'>");

                    sw.WriteLine("<th scope='row'>" + almoxarifado.id + "</th>");
                    sw.WriteLine("<td>" + almoxarifado.fornecedor + "</td>");
                    sw.WriteLine("<td>" + almoxarifado.nome + "</td>");
                    sw.WriteLine("<td>" + almoxarifado.quantidade + "</td>");

                    sw.WriteLine("</tr>");
                }                
                sw.WriteLine("</table>");

                sw.WriteLine("");
                sw.WriteLine("");


                sw.WriteLine("</body>");
                sw.WriteLine("</html>");

            }
            System.Diagnostics.Process.Start(arquivo);
        }

    }
}
