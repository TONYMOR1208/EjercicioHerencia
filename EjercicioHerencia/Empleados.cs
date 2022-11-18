using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioHerencia
{
     class Empleados:Persona 
    {

        public string NumeroDespacho { set; get; }
        public int año  { set; get; }


        public Empleados(string NumeroDespacho, int año , string nombre, string apellidos, int id, string EstadoCivil) : base(nombre, apellidos, id, EstadoCivil)
        {
            this.NumeroDespacho = NumeroDespacho;
            this.año = año;
        }
        public void imprimir()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Empleados del trabajo");
            Console.WriteLine("");
            Console.WriteLine("Numero de Despacho: " + NumeroDespacho);
            Console.WriteLine("");
            Console.WriteLine("Año de incorporacion: " + año);
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
            Console.WriteLine("Si desea cambiar el despacho utilize Ingrese: 1");
            Console.WriteLine("Si desea cambiar el Estado Civil Ingrese: 2");
            Console.WriteLine("Si desea salir utilize: salir ");
            options = Console.ReadLine();
            cambio(options);
        }
        public void cambio( string  cambios)
        {

            switch (cambios.ToString())
            {
                case "1":
                    cambio_espacho();
                    break;
                case "2":
                    cambiocivil();
                    break;
                case "salir":
                    Console.WriteLine("....");
                    break;

            }

        }
        public void cambio_espacho()
        {
            string espacho_new;
            Console.WriteLine("Ingrese el nuevo espacho");
            espacho_new = Console.ReadLine();
            Console.WriteLine("Despacho cambiado exitosamente");
            NumeroDespacho = espacho_new;
        }
    }

}

    
