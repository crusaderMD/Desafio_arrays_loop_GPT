using Desafio_arrays_loop_GPT.Entities;
namespace arrayloops    {
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Crie um programa que:
            Peça ao usuário 5 números inteiros e armazene-os em um array.
            Depois, percorra o array e mostre:
            O maior número.
            O menor número.
            A média dos números.
            Extra: Permita ao usuário escolher quantos números ele quer inserir.
            */

            // Versão Orientada a Objetos
            Numeros numeros = new(1);
            bool valido = false;
            int quantidade = 0;
            int counter = 0;
            int maior = 0;
            int menor = 0;
            double media = 0;

            try
            {
                while (!valido)
                {
                    Console.Write("Deseja inserir quantos números inteiros: ");
                    if (int.TryParse(Console.ReadLine(), out quantidade))
                    {
                        numeros = new Numeros(quantidade);
                        valido = true;
                    }
                    else
                    {
                        Console.WriteLine("Não foi digitado um número válido");
                    }
                }

                while (quantidade != counter)
                {
                    Console.Write("Insira o {0}º número: ", counter + 1);
                    int numero;

                    if (int.TryParse(Console.ReadLine(), out numero))
                    {
                        numeros.InserirNumeros(numero, counter);
                        counter++;
                    }
                    else
                    {
                        Console.WriteLine("Não foi digitado um número válido");
                    }
                }
                Console.WriteLine();

                maior = numeros.MaiorNumero();
                menor = numeros.MenorNumero();

                Console.WriteLine("O número maior é: {0}", maior);
                Console.WriteLine();

                Console.WriteLine("O número menor é: {0}", menor);
                Console.WriteLine();

                media = numeros.MediaNumeros();

                Console.WriteLine("A média dos números é: {0}", media);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
