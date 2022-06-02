using System;

namespace ExamenByronCalderon
{
    class Program
    {
        //Console.WriteLine(" hi");
        static void Main(string[] args)
        {
            Estudiante_primaria estudiante_primaria = new Estudiante_primaria(100, "Diana Valentina", "Mero Loor", "República", 1324515);
            estudiante_primaria.Imprimir_datos();
            estudiante_primaria.Calcular_matricula();

            Estudiante_secundaria Estudiante_secundaria = new Estudiante_secundaria(5, 20, "Juan Daniel", "Calle Pérez", "4 de Noviembre", 214241);
            Estudiante_secundaria.Imprimir_datos();
            Estudiante_secundaria.Calcular_matricula();
            
            Estudiante_universitario estudiante_universitario = new Estudiante_universitario(20, 7, "Diana Valentina", "Mero Loor", "ULEAM", 12354);
            estudiante_universitario.Imprimir_datos();
            estudiante_universitario.Calcular_matricula();
        } 
    }
}
