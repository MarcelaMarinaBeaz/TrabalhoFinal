using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoFinal._03_Entidades;

namespace FrontEnd
{
    public class Sistema
    {
        public void InicializarSistema()
        {
            List<Joias> joias = new List<Joias>();
            int resposta = -1;

            while (resposta != 0)
            {
                Console.WriteLine("\n=== Sistema de Gestão de Joias ===");
                Console.WriteLine("1. Cadastrar uma nova joia");
                Console.WriteLine("2. Listar todas as joias");
                Console.WriteLine("3. Pesquisar joias por nome");
                Console.WriteLine("4. Remover uma joia");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out resposta))
                {
                    Console.WriteLine("Opção inválida! Por favor, tente novamente.");
                    continue;
                }

                switch (resposta)
                {
                    case 1:
                        CadastrarJoia(joias);
                        break;
                    case 2:
                        ListarJoias(joias);
                        break;
                    case 3:
                        PesquisarJoia(joias);
                        break;
                    case 4:
                        RemoverJoia(joias);
                        break;
                    case 0:
                        Console.WriteLine("Saindo do sistema...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Por favor, escolha uma opção válida.");
                        break;
                }
            }
        }

        public void CadastrarJoia(List<Joias> joias)
        {
            Console.Write("\nDigite o nome da joia: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o valor da joia: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal valor))
            {
                Console.WriteLine("Valor inválido! Cadastro cancelado.");
                return;
            }

            joias.Add(new Joias { Nome = nome, Valor = valor });
            Console.WriteLine("Joia cadastrada com sucesso!");
        }

        public void ListarJoias(List<Joias> joias)
        {
            Console.WriteLine("\n=== Lista de Joias ===");
            if (joias.Count == 0)
            {
                Console.WriteLine("Nenhuma joia cadastrada.");
                return;
            }

            foreach (var joia in joias)
            {
                Console.WriteLine($"- {joia.Nome}: R$ {joia.Valor:F2}");
            }
        }

        public void PesquisarJoia(List<Joias> joias)
        {
            Console.Write("\nDigite o nome da joia para pesquisar: ");
            string nome = Console.ReadLine();

            var resultados = joias.Where(j => j.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase)).ToList();

            if (resultados.Count == 0)
            {
                Console.WriteLine("Nenhuma joia encontrada com esse nome.");
            }
            else
            {
                Console.WriteLine("\n=== Resultados da Pesquisa ===");
                foreach (var joia in resultados)
                {
                    Console.WriteLine($"- {joia.Nome}: R$ {joia.Valor:F2}");
                }
            }
        }

        public void RemoverJoia(List<Joias> joias)
        {
            Console.Write("\nDigite o nome da joia para remover: ");
            string nome = Console.ReadLine();

            var joia = joias.FirstOrDefault(j => j.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

            if (joia == null)
            {
                Console.WriteLine("Joia não encontrada.");
            }
            else
            {
                joias.Remove(joia);
                Console.WriteLine("Joia removida com sucesso!");
            }
        }

       
       

    }
}