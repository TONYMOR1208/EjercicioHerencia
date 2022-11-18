using System;

namespace EjercicioHerencia
{
     class Program
    {
        static void Main(string[] args)
        {

            Estudiantes stu = new Estudiantes ("Anthony Joel", "Moreira Catagua", 132456, "Soltero", "4A");
            stu.imprimir();


            Empleados empleados = new Empleados("Despacho#10 ", 2017, "Ariel", "Valencia", 131673, "viudo");
            empleados.imprimir();



            PersonalServicio pers = new  PersonalServicio("Decanatosalir", "Julian", "Mendeez", 1315478954, "Casado");
            pers.imprimir();




            Profesores profesores = new Profesores("Arquitectura ", "Joel", "Perez", 1305879446, "soltero");
            profesores.imprimir();
        }
    }
}
