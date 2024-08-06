using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05_08_2024
{
    public class Persona
    {
        public string nombre;
        public int edad;

        public string Nombre
        {
            //get para recuperar un valor
            get { return nombre; }

            //ser para establecer un valor
            set { nombre = value; }

            //crear 2 atributos
        }

        private int num1;
        private int num2;

        public int Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public int Num2
        {
            get { return num2; }
            set { num2 = value; }
        }
    }
}
