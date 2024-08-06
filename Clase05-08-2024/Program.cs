using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05_08_2024
{
    internal class Program
    {
        /*Que es la herencia?
         * la herencia me permite crear clases nuevas a opartirt de una clse base. 
         * A demás, me permite heredar atributos y métodos.
         *
         *
         *Modificador de Acceos
         *Private: Cuando los atributos y métodos están marcados con el modificador de acceso privado 
         *solo puede ser accedidio desde la propia clase que la declara
         *
         
         
         */
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            //Establecer valor
            persona.Nombre = "Marcelo";
            //Valor recuperado
            string nombre = persona.Nombre;

            persona.Num1 = 5;
            persona.Num2 = 16;

            int suma = persona.Num1 + persona.Num2;

            Console.WriteLine($"La suma es: {suma}");
            Console.ReadKey();

        }
    }
}
