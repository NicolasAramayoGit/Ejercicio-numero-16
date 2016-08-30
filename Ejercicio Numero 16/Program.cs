using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Numero_16
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Consigna.

            /* 
             16. Crear la clase 'Alumno' de acuerdo al siguiente diagrama: 

            Se pide crear 3 instancias de la clase 'Alumno' (3 objetos),
            colocarle nombre, apellido y legajo a cada uno de ellos. 
            Sólo se podrá ingresar las notas (nota1 y nota2) atravéz del método Estudiar.
            El método CalcularFinal deberá colocar la nota del final sólo si las notas
            1 y 2 son mayores o iguales a 4, caso contrario la inicializará con -1.
            Para darle un valor a la nota final utilice el método de instancia Next
            de la clase Ramdom.
            Por último, el método Mostras, expondrá en la consola todos los 
            datos de los alumnos, a excepción de la nota final. Este valor se mostrará
            sólo si es distinto de -1.

            */

            #endregion


            Alumno alumno1 = new Alumno();
            Alumno alumno2 = new Alumno();
            Alumno alumno3 = new Alumno();


            alumno1.nombre = "pepito";
            alumno1.apellido = "perez";
            alumno1.legajo = 1;
            alumno1.Estudiar(4, 4);
            alumno1.CalcularFinal();

            alumno2.nombre = "armando";
            alumno2.apellido = "paredes";
            alumno2.legajo = 2;
            alumno2.Estudiar(8, 10);
            alumno2.CalcularFinal();

            alumno3.nombre = "mauricio";
            alumno3.apellido = "macri";
            alumno3.legajo = 3;
            alumno3.Estudiar(2,2);
            alumno3.CalcularFinal();

            alumno1.Mostrar();
            alumno2.Mostrar();
            alumno3.Mostrar();

        }
    }
}
