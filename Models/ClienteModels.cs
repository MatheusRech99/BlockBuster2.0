using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BlockBuster.Repositories;

// ReSharper disable InconsistentNaming

namespace BlockBuster.Models {
    public class ClienteModels {
        [Key] 
        public int ClienteId { get; set; }
        [Required] public string Nome { get; set; }
        [Required] public string DataNascimento { get; set; }
        [Required] public string CPF { get; set; }
        [Required] public int DiasDeDevolucao { get; set; }

        public List<LocacaoModels> Locacoes = new List<LocacaoModels>();

        public ClienteModels() {
        }

        public ClienteModels(string nome, string dataNascimento, string cpf, int diasDeDevolucao) {
            Nome = nome;
            DataNascimento = dataNascimento;
            CPF = cpf;
            DiasDeDevolucao = diasDeDevolucao;
            Locacoes = new List<LocacaoModels>();

            var db = new Context();
            db.Clientes.Add(this);
            db.SaveChanges();
        }

        public static void AtualizarCliente(int clienteid, string nome, string dataNascimento, string cpf, int diasDeDevolucao) {
            var db = new Context();
            try {
                ClienteModels cliente = db.Clientes.First(cliente => cliente.ClienteId == clienteid);
                cliente.Nome = nome;
                cliente.CPF = cpf;
                cliente.DataNascimento = dataNascimento;
                cliente.DiasDeDevolucao = diasDeDevolucao;
                db.SaveChanges();
            } catch {
                throw new ArgumentException();
            }
        }

        public static void DeletarCliente(int clienteid) {
            var db = new Context();
            ClienteModels cliente = db.Clientes.First(cliente => cliente.ClienteId == clienteid);
            db.Remove(cliente);
            db.SaveChanges();     
        }

        public void AtribuirLocacao(LocacaoModels locacao) {
            Locacoes.Add(locacao);
        }

        public static List<ClienteModels> GetCliente() {
            var db = new Context();
            return db.Clientes.ToList();
        }


        public static ClienteModels GetCliente(int clienteId) {
            var db = new Context();
            return (from cliente in db.Clientes
                where cliente.ClienteId == clienteId
                select cliente).First();
        }

        public override string ToString() {
            return $"|-----------------Dados Cliente-------------------------\n" +
                   $"|ID do Cliente: {ClienteId}\n" +
                   $"|Nome do Cliente: {Nome}\n" +
                   $"|Data de Nascimento do Cliente: {DataNascimento}\n" +
                   $"|CPF do Cliente: {CPF}\n" +
                   $"|Dias para devolução do Cliente: {DiasDeDevolucao}\n" +
                   $"|-------------------------------------------------------";
        }
    }
}