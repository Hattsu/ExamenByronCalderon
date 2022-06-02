using System;

namespace ExamenByronCalderon
{
    class Estudiante_primaria:Estudiante, IMostrar, IMatricula
    {
        int Valor_anual {set; get;}

        public class Estudiante_primaria(int valor_anual, string nombre, string apellido, string institucion, int cedula): Base (nombre, apellido, institucion, cedula)
        {
            this.Valor_anual = valor_anual;
        }
        public class void Imprimir_datos()
        {
            Console.WriteLine("-----------");
            Console.WriteLine("Ficha: Estudiante primaria");
            Console.WriteLine("-----------");
            Console.WriteLine("Nombres: "+Nombre);
            Console.WriteLine("Apellido: "+Apellido);
            Console.WriteLine("Nombre de la institucion educativa: "+Nombre_institucion);
            Console.WriteLine("Cedula de identidad: "+Cedula_identidad);
        }
        public class void Calcular_matricula()
        {
            // Ya que es un valor fijo no se realizará ningún calculo para alterar el valor
            Console.WriteLine("Valor de la matricula anual: $"+Valor_anual);
        }
    }
}