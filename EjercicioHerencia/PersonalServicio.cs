using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioHerencia
{
     class PersonalServicio:Persona
    {
        public string SeccionAsignado { get; set; }


        public PersonalServicio(string SeccionAsignado, string nombre, string apellidos, int id, string EstadoCivil)
            : base(nombre, apellidos, id, EstadoCivil)
        {

            this.SeccionAsignado = SeccionAsignado;
        }

        public void imprimir()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("    Personal del trabajo");
            Console.WriteLine("");
            Console.WriteLine("Seccion Asignada: " + SeccionAsignado);
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
            Console.WriteLine("Si desea trasladar de seccion  Ingrese: 1");
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
                    cambio_de_personal();
                    break;
                case "2":
                    cambiocivil();
                    break;
                case "salir":
                    Console.WriteLine("....");
                    break;

            }

        }
        public void cambio_de_personal()
        {
            String translado_nuevo;
            Console.WriteLine("Ingrese el nuevo translado de seccion");
            translado_nuevo = Console.ReadLine();
            Console.WriteLine("seccion cambiado exitosamente");
            SeccionAsignado = translado_nuevo;
        }
    }

}


