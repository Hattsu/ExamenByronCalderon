using System;

namespace ExamenByronCalderon
{
    class Estudiante
    {
        string Nombre {set; get;}
        string Apellido {set; get;}
        string Nombre_institucion {set; get;}
        int Cedula_identidad {set; get;}

        public class Estudiante (string nombre, string apellido, string institucion, int cedula)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nombre_institucion = institucion;
            this.Cedula_identidad = cedula;
        }
    }
}