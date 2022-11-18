using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioHerencia
{
     class Estudiantes:Persona
    {
        public string curso { get; set; }


        public Estudiantes(string nombre, string apellidos, int id, string EstadoCivil, string curso) : base(nombre, apellidos, id, EstadoCivil)
        {
            this.curso = curso;

        }
        public void imprimir()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Matriculacion de Estudiante");
            Console.WriteLine("");
            Console.WriteLine("El curso asignado es:  " + curso);      
            Console.WriteLine("El nombre del estudiante es: " + nombre + " "  +  apellidos);
            Console.WriteLine("El numero de Identificacion: " + id);
            Console.WriteLine("Su estado civil es de : " + EstadoCivil);
            opcioness();
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------");

        }
        public void opcioness()
        {
            string  options;
            Console.WriteLine("Opciones alternas:");
            Console.WriteLine("Si desea cambiar el curso dijite: 1");
            Console.WriteLine("Si desea cambiar el Estado Civil dijite: 2");
            Console.WriteLine("Si desea salir escriba : salir ");
            options = Console.ReadLine();
            cambio(options);
        }
        public void cambio(string  cambios)
        {

            switch (cambios.ToString())
            {
                case "1":
                    curso_nuevo();
                    break;
                case "2":
                    cambiocivil();
                    break;
                case "salir":
                    Console.WriteLine("....");
                    break;

            }

        }
        public void curso_nuevo()
        {
            string  curso_new;
            Console.WriteLine("Ingrese el nuevo Curso");
            curso_new = Console.ReadLine();
            Console.WriteLine("Curso cambiado exitosamente");
            curso = curso_new;
        }
    }

    }