using Desafio_arrays_loop_GPT.Entities;
namespace arrayloops    {
    public class Program
    {
        public static void Main(string[] args)
        {
            // Versão Orientada a Objetos usando List<int>
            Numeros numeros = new();
            bool inserirMaisUm = true;            

            try
            {
                Console.WriteLine("Insira abaixo quantos números inteiros desejar:");
                Console.WriteLine();

                while (inserirMaisUm)
                {
                    Console.Write("Insira um número: ");
                    int numero;

                    if (int.TryParse(Console.ReadLine(), out numero))
                    {
                        numeros.InserirNumeros(numero);                        
                    }
                    else
                    {
                        Console.WriteLine("Não foi digitado um número válido");
                    }

                    Console.Write("Deseja inserir mais um número? (S/N): ");
                    inserirMaisUm = Console.ReadLine().ToUpper() == "S";
                }
                Console.WriteLine();

                if (numeros.ListaNumeros.Count == 0)
                {
                    Console.WriteLine("Nenhum número foi inserido na lista!");
                }
                else
                {
                    Console.WriteLine(numeros);
                }   
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
