using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade7
{
    class Program
    {
        static void Main(string[] args)
        {
            //7 - Criar um console app conte a quantidade de "a","e","i","o" e "u" dentro de um texto informado
            // pelo usuário.
            var texto = UserText();
            NumeroDeLetras(texto, "a");
            NumeroDeLetras(texto, "e");
            NumeroDeLetras(texto, "i");
            NumeroDeLetras(texto, "o");
            NumeroDeLetras(texto, "u");
            Console.ReadKey();
                    
        }
        /// <summary>
        /// texto do usuario
        /// </summary>
        /// <returns>retorna o texto do usuario em string</returns>
        private static string UserText()
        {
            Console.WriteLine("Informe o texto: ");
            return Console.ReadLine();
        }

        /// <summary>
        /// acha a letra dentro do texto 
        /// </summary>
        /// <param name="texto">texto usado para procurar</param>
        /// <param name="letra">letra que queira ser encontrada</param>
        /// <returns>numero de vezes que essa letra aparece no texto</returns>
        private static int AchaLetra(string texto, string letra)
        {
            var cont = 0;
            var textoLenght = texto.Length;
            for (int i = 0; i < textoLenght; i++)
            {           
                if (texto[i].ToString() == letra)
                    cont++;
            }
            return cont;
        }

        /// <summary>
        /// joga para o console o numero de letras que foi achado no texto
        /// </summary>
        /// <param name="texto">texto do usuario</param>
        /// <param name="letra">letra a ser encontrada</param>
        private static void NumeroDeLetras(string texto, string letra)
        {
            Console.WriteLine($"\r\n Seu texto tem {AchaLetra(texto, letra)} letras '{letra}' ");
        }
        
    }
}
