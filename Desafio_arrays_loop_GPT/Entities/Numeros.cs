using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_arrays_loop_GPT.Entities
{
    public class Numeros
    {
        public int[] Numero { get; private set; }

        public Numeros(int tamanho)
        {
            if (tamanho <= 0)
            {
                throw new ArgumentException("O tamanho do array deve ser maior que zero");
            }
            Numero = new int[tamanho];
        }

        public void InserirNumeros(int numero, int indice)
        {
            if (indice < 0 || indice >= Numero.Length)
            {
                throw new IndexOutOfRangeException("Indice Inválido");
            }

            Numero[indice] = numero;
        }

        public int MaiorNumero()
        {
            if (Numero == null || Numero.Length == 0)
            {
                throw new NullReferenceException("O array não foi inicializado");
            }
            return Numero.Max();
        }

        public int MenorNumero()
        {
            if (Numero == null || Numero.Length == 0)
            {
                throw new NullReferenceException("O array não foi inicializado");
            }
            return Numero.Min();
        }

        public double MediaNumeros()
        {
            if (Numero == null || Numero.Length == 0)
            {
                throw new NullReferenceException("O array não foi inicializado");
            }
            return Numero.Average();
        }
    }
}
