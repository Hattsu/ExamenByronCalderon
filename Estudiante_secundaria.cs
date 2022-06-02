using System;

namespace ExamenByronCalderon
{
    class Estudiante_secundaria: Estudiante, IMostrar, IMatricula
    {
        int Nivel_cursado {set; get;}
        int Precio_fijo {set; get;}

        public class Estudiante_primaria(int nivel_cursado, int precio_fijo, string nombre, string apellido, string institucion, int cedula): Base (nombre, apellido, institucion, cedula)
        {
            this.Nivel_cursado = nivel_cursado;
            this.Precio_fijo = precio_fijo;
        }
        public class void Imprimir_datos()
        {
            Console.WriteLine("-----------");
            Console.WriteLine("Ficha: Estudiante secundaria");
            Console.WriteLine("-----------");
            Console.WriteLine("Nombres: "+Nombre);
            Console.WriteLine("Apellido: "+Apellido);
            Console.WriteLine("Nombre de la institucion educativa: "+Nombre_institucion);
            Console.WriteLine("Cedula de identidad: "+Cedula_identidad);
            Console.WriteLine("Nivel cursado: "+Nivel_cursado);
            Console.WriteLine("Precio fijo por matricula $"+Precio_fijo);
            Console.WriteLine("-----------");
        }
        public class void Calcular_matricula()
        {
            //El valor de la matricula se calcula... valor de matricula anual * precio fijo del nivel
            int resultado = 0;
            resultado = Nivel_cursado * Precio_fijo;
            Console.WriteLine("Valor de matricula anual: $"+resultado);
        }
    }
}