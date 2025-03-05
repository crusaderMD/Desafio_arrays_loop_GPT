using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_arrays_loop_GPT.Entities
{
    public class Numeros
    {
        public List<int> ListaNumeros { get; private set; }

        public Numeros()
        {
            ListaNumeros = new();
        }

        public void InserirNumeros(int numero)
        {          
            ListaNumeros.Add(numero);
        }

        public int MaiorNumero()
        {
            if (ListaNumeros.Count == 0)
            {
                throw new InvalidOperationException("A lista está vazia.");
            }
            return ListaNumeros.Max();
        }

        public int MenorNumero()
        {
            if (ListaNumeros.Count == 0)
            {
                throw new InvalidOperationException("A lista está vazia.");
            }
            return ListaNumeros.Min();
        }

        public double MediaNumeros()
        {
            if (ListaNumeros.Count == 0)
            {
                throw new InvalidOperationException("A lista está vazia.");
            }
            return ListaNumeros.Average();
        }

        public override string ToString()
        {
            return $"Resultados:\n - Maior: {MaiorNumero()}\n - Menor: {MenorNumero()}\n - Média: {MediaNumeros():F2}";
        }
    }
}
