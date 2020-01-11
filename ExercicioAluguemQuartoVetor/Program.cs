using System;

namespace ExercicioAluguemQuartoVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            //Declaração da variável vetor do tipo Pensão            
            //Pensao[] vet = new Pensao[n];

            //Correção do professor, criando um vetor com 10 posições
            Pensao[] vet = new Pensao[10];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Entre com o nome do cliente: ");
                string nome = Console.ReadLine();
                Console.Write("Entre com o email do cliente: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                //vet[i] = new Pensao { Nome = nome, Email = email, Quarto = quarto };
                vet[quarto] = new Pensao(nome, email); //passando para o construtor da classe somente os atributos necessários
            }

            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {                
                if (vet[i] != null)
                {
                    //Console.WriteLine(vet[i].Quarto + ": " + vet[i].Nome + ", " + vet[i].Email);
                    Console.WriteLine(i + ": " + vet[i]);
                }
            }
        }
    }
}
