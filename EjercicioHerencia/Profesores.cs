using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioHerencia
{
     class Profesores:Persona
    {
        public string Departemanto { get; set; }




        public Profesores(string Departemanto, string nombre, string apellidos, int id, string EstadoCivil) : base(nombre, apellidos, id, EstadoCivil)
        {

           this. Departemanto = Departemanto;
        }


        public void imprimir()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("    Personal de Profesores");
            Console.WriteLine("");
            Console.WriteLine("Departamento Asignado: " + Departemanto);
            Console.WriteLine("");
            Console.WriteLine("NOMBRE:  " + nombre + " " + apellidos);
            Console.WriteLine("Numero de Identificacion: " + id);
            Console.WriteLine("Estado civil es de : " + EstadoCivil);

            Console.WriteLine("");
            opcioness();
            Console.WriteLine("");

            Console.WriteLine("--------------------------------------------");

        }

        public void opcioness()
        {
            String options;
            Console.WriteLine("Opciones alternas:");
            Console.WriteLine("Si desea cambiar el personal utilize Ingrese: 1");
            Console.WriteLine("Si desea cambiar el Estado Civil Ingrese: 2");
            Console.WriteLine("Si desea salir utilize: salir ");
            options = Console.ReadLine();
            cambio(options);
        }
        public void cambio(String cambios)
        {

            switch (cambios.ToString())
            {
                case "1":
                    cambio_de_departamento();
                    break;
                case "2":
                    cambiocivil();
                    break;
                case "salir":
                    Console.WriteLine("....");
                    break;

            }

        }
        public void cambio_de_departamento()
        {
            String departmento_nuevo;
            Console.WriteLine("Ingrese el nuevo departamento");
            departmento_nuevo = Console.ReadLine();
            Console.WriteLine("Departamento cambiado exitosamente");
            Departemanto = departmento_nuevo;
        }
    }
}

