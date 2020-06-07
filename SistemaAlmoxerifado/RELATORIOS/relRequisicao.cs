using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAlmoxerifado.RELATORIOS {
    public class relRequisicao {
        
        public static void gerarReqAlmoxarifado() {
            CAMADAS.BLL.Requisicao bllRequisicao = new CAMADAS.BLL.Requisicao();
            List<CAMADAS.MODEL.Requisicao> lstRequisicao = new List<CAMADAS.MODEL.Requisicao>();
            lstRequisicao = bllRequisicao.Select();

            string pasta = Funcao.diretorioPasta();
            string arquivo = pasta + @"\RelatorioRequisicao.html";

            StreamWriter sw = new StreamWriter(arquivo);
            using (sw) {
                sw.WriteLine("<html lang='pt-br'>");
                sw.WriteLine("<head>");

                sw.WriteLine("<meta charset='UTF - 8'>");
                sw.WriteLine("<meta name='viewport' content='width = device - width, initial - scale = 1.0'>");                
                sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css' integrity='sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk' crossorigin='anonymous'>");
                sw.WriteLine("<title>Relatorio Requisição</title>");

                sw.WriteLine("</head>");

                sw.WriteLine("<body>");

                sw.WriteLine("<br><hr border='5px' />");
                sw.WriteLine("<h1> Relatório de Requisições </h1>");
                sw.WriteLine("<hr border='5px' /><br>");

                sw.WriteLine("<table class='table'>");

                sw.WriteLine("<thead class='thead-dark'>");
                sw.WriteLine("<tr align='center'>");

                sw.WriteLine("<th>ID</th>");
                sw.WriteLine("<th>SETOR</th>");
                sw.WriteLine("<th>PRODUTO</th>");
                sw.WriteLine("<th>QUANTIDADE</th>");
                sw.WriteLine("<th>DATA</th>");

                sw.WriteLine("</thead class='thead-dark'>");
                sw.WriteLine("</tr>");

                int cont = 0;
        
                foreach (CAMADAS.MODEL.Requisicao requisicao in lstRequisicao) {
                    sw.WriteLine("<tr align='center'>");

                    sw.WriteLine("<th scope='row'>" + requisicao.id + "</th>");
                    sw.WriteLine("<td>" + requisicao.setor + "</td>");
                    sw.WriteLine("<td>" + requisicao.produto + "</td>");
                    sw.WriteLine("<td>" + requisicao.quantidade + "</td>");
                    sw.WriteLine("<td>" + requisicao.data.ToShortDateString() + "</td>");

                    sw.WriteLine("</tr>");

                    cont++;
                }
                sw.WriteLine("</table>");

                sw.WriteLine("<hr border='5px' /><br>");
                sw.WriteLine("<h5> Quantidade de Requisições Realizadas: " + cont + "</h5>");
                sw.WriteLine("");

                sw.WriteLine("</body>");
                sw.WriteLine("</html>");

            }
            System.Diagnostics.Process.Start(arquivo);
        }
        
    }
}
