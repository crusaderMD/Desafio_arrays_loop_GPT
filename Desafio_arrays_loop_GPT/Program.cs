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

            // Procedural
            int[] numeros = new int[1];            
            int quantidade = 0;
            int counter = 0;
            bool valido = true;

            while (valido)
            {
                Console.Write("Deseja inserir quantos números inteiros: ");
                if (int.TryParse(Console.ReadLine(), out quantidade))
                {
                    numeros = new int[quantidade];
                    valido = false;
                }
                else
                {
                    Console.WriteLine("Não foi digitado um número válido");         
                }                
            }

            while (quantidade != counter) {
                Console.Write("Insira o {0}º número: ", counter + 1);
                int numero;

                if(int.TryParse(Console.ReadLine(), out numero))
                {
                    numeros[counter] = numero;
                    counter++;
                }
                else
                {
                    Console.WriteLine("Não foi digitado um número válido");
                }               
            }

            Console.WriteLine();

            int menor = numeros[0];
            int maior = numeros[0];
            for (int i =0; i < numeros.Length; i++)            {
                
                if (numeros[i] != 0)                {
                    
                    if (numeros[i] > maior)
                    {
                        maior = numeros[i];
                    }
                    if (numeros[i] < menor)
                    {
                        menor = numeros[i];
                    }
                }
            }

            Console.WriteLine("O maior número é: {0}", maior);
            Console.WriteLine();          

            Console.WriteLine("O menor número é: {0}", menor);
            Console.WriteLine();

            int soma = 0;            
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }

            double media = numeros.Length > 0 ? (double)soma / numeros.Length : 0;

            Console.WriteLine("A média da soma dos números é: {0}", media);
        }
    }
}
