using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using BlockBuster.Controllers;
using BlockBuster.Repositories;

namespace BlockBuster.Models {
    public class LocacaoModels {
        [Key]
        public int LocacaoId { get; set; }
        public ClienteModels Cliente { get; set; }

        [ForeignKey("clientes")] 
        public int ClienteId { get; set; }
        [Required]
        public DateTime DataLocacao { get; set; }
        public List<FilmeModels> Filmes = new List<FilmeModels>();

        public LocacaoModels() {
        }

        public LocacaoModels(ClienteModels cliente, DateTime datalocacao) {
            ClienteId = cliente.ClienteId;
            DataLocacao = datalocacao;
            Filmes = new List<FilmeModels>();
            cliente.AtribuirLocacao(this);

            var db = new Context();
            db.Locacoes.Add(this);
            db.SaveChanges();
        }

        public void AdicionarFilmes(FilmeModels filme) {
            var db = new Context();
            FilmeLocacao filmeLocacao = new FilmeLocacao() {
                FilmeId = filme.FilmeId,
                LocacaoId = LocacaoId
            };

            db.FilmeLocacao.Add(filmeLocacao);
            db.SaveChanges();
        }

        public static List<LocacaoModels> GetLocacao() {
            var db = new Context();
            var locacoes = new List<LocacaoModels>();
            foreach (var locacao in db.Locacoes.ToList()) {
                foreach (var filmeId in LocacaoModels.GetFilmesIds(locacao)) {
                    FilmeModels filme = FilmeModels.GetFilme(filmeId);
                    if(filme == null) continue;
                    locacao.Filmes.Add(filme);
                }
                locacao.Cliente = ClienteModels.GetCliente(locacao.ClienteId);
                locacoes.Add(locacao);
            }
            return locacoes;
        }

        public static LocacaoModels GetLocacao(int LocacaoId) {
            var db = new Context();
            return (from locacao in db.Locacoes
                where locacao.LocacaoId == LocacaoId
                select locacao).First();
        }

        public static IEnumerable<int> GetFilmesIds(LocacaoModels locacaoModel) {
            var db = new Context();
            IEnumerable<int> filmes = (from filme in db.FilmeLocacao where filme.LocacaoId == locacaoModel.LocacaoId select filme.FilmeId);
            return filmes;
        }

        public override string ToString() {
            var db = new Context();
            ClienteModels cliente = (
                from client in db.Clientes
                where client.ClienteId == ClienteId
                select client).First();

            String retornar = $" __________Dados Da Locação__________\n" +
                              $"|Cliente {cliente.Nome}\n" +
                              $"|Data da Locação: {DataLocacao}\n" +
                              $"|Data de Devolução: {LocacaoController.CalcularDataDevolucao(DataLocacao, cliente)}\n";

            double total = 0;
            string strFilmes = "";

            IEnumerable<int> filmes =
                from filme in db.FilmeLocacao
                where filme.LocacaoId == LocacaoId
                select filme.FilmeId;
            if (filmes.Count() > 0) {
                foreach (int id in filmes) {
                    FilmeModels filme = FilmeModels.GetFilme(id);
                    strFilmes += $"\n|Id: {filme.FilmeId} - Título: {filme.Titulo}\n";
                    total = filme.Preco;
                }
            }
            else {
                strFilmes += $"Não há filme!";
            }

            retornar += $"|Valor total :{total:C2}\n" +
                        $"|Filmes: " + strFilmes +
                        $"|______________________________________";

            return retornar;
        }
    }
}