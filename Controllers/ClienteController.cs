using System;
using System.Collections.Generic;
using BlockBuster.Models;

namespace BlockBuster.Controllers {
    public class ClienteController {
        public static void InserirCliente(string nome, string dataNascimento, string cpf, int diasdeDevolucao) {
            DateTime dtNascimento;
            try {
                dtNascimento = Convert.ToDateTime(dataNascimento);
            }
            catch {
                Console.WriteLine("Formato inválido, a data atual será utilizada para completar o Cadastro!");
                dtNascimento = DateTime.Now;
            }

            new ClienteModels(nome, dataNascimento, cpf, diasdeDevolucao);
        }

        public static ClienteModels GetCliente(int ClienteId) {
            return ClienteModels.GetCliente(ClienteId);
        }

        public static List<ClienteModels> GetCliente() {
            return ClienteModels.GetCliente();
        }

        public static void AtualizarCliente(int clienteid, string nome,string dataNascimento, string cpf, int diasDeDevolucao) {
            
            ClienteModels.AtualizarCliente(clienteid, nome, dataNascimento, cpf, diasDeDevolucao);
        }

        public static void DeletarCliente(int clienteid) {
            ClienteModels.DeletarCliente(clienteid);
        }
    }
}