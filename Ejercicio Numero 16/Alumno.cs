using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Numero_16
{
    class Alumno
    {
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;


        public void Estudiar(byte notaUno, byte notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        }

        public void CalcularFinal()
        {
            if (this._nota1 >= 4 && this._nota2 >= 4)
            {
                Random objRamdom = new Random();
                this._notaFinal = objRamdom.Next(1,10);
            }
            else
            {
                _notaFinal = -1;
            }
        }

        public void Mostrar()
        {
            Console.WriteLine("Datos alumno: ");
            Console.WriteLine("=====================");
            Console.WriteLine("nombre: "+ this.nombre);
            Console.WriteLine("apellido: " + this.apellido);
            Console.WriteLine("legajo: " + this.legajo);
            Console.WriteLine("nota1: " + this._nota1);
            Console.WriteLine("nota2: " + this._nota2);

            if (_notaFinal != -1)
            {
                Console.WriteLine("notafinal: " + this._notaFinal);
            }
        }

    }
}
