using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string targa, numeri, lettere1, lettera2, temp;
            //int posizione2 = 0;
            double posizione2=0, posizione = 0, valnumeri = 0, valorelettere = 0, temp2 = 0, valorefinale = 0;
            char[] arrayAlfabeto = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            Console.WriteLine("Inserisci targa (LLNNNLL");
            targa = Console.ReadLine();
            //divido la targa nelle sue 3 parti
            numeri = targa.Substring(2, 3);
            lettere1 = targa.Substring(0, 2);
            lettera2 = targa.Substring(5);

            temp = lettere1 + lettera2; //queste sono le prime quattro lettere della targa 
            for (int i = 0; i < numeri.Length; i++)
            {
                valnumeri += (numeri[i] - 'A') * Math.Pow(10, i); // converte la lettera in un numero in base 10, e sottrae alla lettera il valore stesso. 
            }
            for (int i = 0; i < temp.Length; i++)
            {

                posizione2 = Array.IndexOf(arrayAlfabeto, temp[i]);//cerco la posizione del carattere corrente nell'array alfabeto

                if (posizione2 != -1)//Controlla se il carattere è presente nell'array alfabeto. Se il carattere non è presente da -1.
                {
                    temp2 = posizione * Math.Pow(26, i);
                    posizione = temp2 + posizione2;
                }
            }
            valorelettere = posizione * Math.Pow(10, 3);
            valorefinale = valorelettere + valnumeri;//stampo
            Console.WriteLine(valorelettere);

            Console.ReadLine();
        }
    }
}