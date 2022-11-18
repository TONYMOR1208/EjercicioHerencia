using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioHerencia
{
     class Persona
    {

        public string nombre { set; get; }
        public string apellidos { set; get; }
        public int id { set; get; }
        public string EstadoCivil { set; get; }


        public Persona(string nombre, string apellidos, int id, string EstadoCivil)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.id = id;
            this. EstadoCivil = EstadoCivil;
        }
        public void cambiocivil()
        {
            string  nuevo_civil;
            do
            {
                Console.WriteLine("Inserte el nuevo Estado Civil");
                Console.WriteLine("- Soltero ");
                Console.WriteLine("- Casado ");
                Console.WriteLine("- Viudo ");

                nuevo_civil = Console.ReadLine();

                if (nuevo_civil == "Soltero" || nuevo_civil == "soltero")
                {
                    EstadoCivil = nuevo_civil;
                    Console.WriteLine("El cambio se realizo con exito");
                }
                else if (nuevo_civil == "Casado" || nuevo_civil == "casado")
                {
                    EstadoCivil = nuevo_civil;
                    Console.WriteLine("El cambio se realizo con exito");
                }
                else if (nuevo_civil == "Viudo" || nuevo_civil == "viudo" )
                {
                    EstadoCivil = nuevo_civil;
                    Console.WriteLine("El cambio se realizo con exito");
                }
                else
                {
                    Console.WriteLine("El estado civil ingresado es  Incorrecto");
                    Console.WriteLine("Inserte el nuevo Estado Civil");
                    Console.WriteLine("- Soltero ");
                    Console.WriteLine("- Casado ");
                    Console.WriteLine("- Viudo ");
                    nuevo_civil = Console.ReadLine();
                    Console.WriteLine("El cambio se realizo con exito");

                }
            } while (nuevo_civil != null && nuevo_civil == "Soltero" && nuevo_civil == "Casado" && nuevo_civil == "Viudo");
        }

    }
}


