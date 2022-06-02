using System;

namespace ExamenByronCalderon
{
    class Estudiante_universitario: Estudiante, IMostrar, IMatricula
    {
        int Cantidad_creditos {set; get;}
        int Precio_creditos {set; get;}

        public class Estudiante_primaria(int cantidad_creditos, int precio_creditos, string nombre, string apellido, string institucion, int cedula): Base (nombre, apellido, institucion, cedula)
        {
            this.Cantidad_creditos = cantidad_creditos;
            this.Precio_creditos = precio_creditos;
        }
        public class void Imprimir_datos()
        {
            Console.WriteLine("-----------");
            Console.WriteLine("Ficha: Estudiante universitario");
            Console.WriteLine("-----------");
            Console.WriteLine("Nombres: "+Nombre);
            Console.WriteLine("Apellido: "+Apellido);
            Console.WriteLine("Nombre de la institucion educativa: "+Nombre_institucion);
            Console.WriteLine("Cedula de identidad: "+Cedula_identidad);
            Console.WriteLine("Cantidad_creditos: "+Cantidad_creditos);
            Console.WriteLine("Precio de creditos: "+Precio_creditos);
            Console.WriteLine("-----------");
        }
        public class void Calcular_matricula()
        {
            //El valor de la matricula se calcula... cantidad de creditos * precio de creditos
            int resultado = 0;
            resultado = Cantidad_creditos * Precio_creditos;
            Console.WriteLine("Valor de matricula anual: $"+resultado);
        }
    }
}