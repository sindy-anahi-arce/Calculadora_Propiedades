using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Propiedades
{
    class Operaciones
    {
        //Atributos
        private float num1;
        private float num2;

        //Propiedades
        public float Nume1
        {
            get => num1; set => num1 = value;
        }
        public float Nume2
        {
            get => num2; set => num2 = value;
        }

        //Métodos
        public float suma()
        {
            return (num1 + num2);
        }

        public float resta()
        {
            return (num1 - num2);
        }

        public float multiplicacion()
        {
            return (num1 * num2);
        }

        public float division()
        {
            return (num1 / num2);
        }
    }
}
