using System;
using System.Collections.Generic;
using BlockBuster.Models;

namespace BlockBuster.Controllers {
    public class FilmeController {
        public static void InserirFilme(String titutlo, String sinopse, String dataLancamento, double preco,
            int estoque) {
            DateTime dtLancamento;
            try {
                dtLancamento = Convert.ToDateTime(dataLancamento);
            }
            catch {
                Console.WriteLine("Formato inválido, a data atual será utilizada para completar o Cadastro!");
                dtLancamento = DateTime.Now;
            }

            new FilmeModels(titutlo, sinopse, dataLancamento, preco, estoque);
        }

        public static List<FilmeModels> GetFilmes() {
            return FilmeModels.GetFilmes();
        }

        public static FilmeModels GetFilme(int Filmeid) {
            return FilmeModels.GetFilme(Filmeid);
        }

        public static void AtualizarFilme(int filmeid, string titulo, string sinopse, string dataLancamento, double preco, int estoque) {
            FilmeModels.AtualizarFilme(filmeid, titulo, sinopse, dataLancamento, preco, estoque);
        }

        public static void DeletarFilme(int filmeid) {
            FilmeModels.DeletarFilme(filmeid);
        }
    }
}