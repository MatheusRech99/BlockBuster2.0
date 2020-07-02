using System;
using System.Collections.Generic;
using BlockBuster.Models;

namespace BlockBuster.Controllers {
    public class LocacaoController {
        public static LocacaoModels AdicionarLocacao(ClienteModels cliente) {
            return new LocacaoModels(cliente, DateTime.Now);
        }

        public static DateTime CalcularDataDevolucao(DateTime dtLocacao, ClienteModels cliente) {
            return dtLocacao.AddDays(cliente.DiasDeDevolucao);
        }

        public static LocacaoModels GetLocacaos(int LocacaoId) {
            return LocacaoModels.GetLocacao(LocacaoId);
        }

        public static List<LocacaoModels> GetLocacaos() {
            return LocacaoModels.GetLocacao();
        }
    }
}