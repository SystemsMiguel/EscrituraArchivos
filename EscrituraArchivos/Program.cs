using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraArchivos
{
    class Program
    {
        class Alumno 
        {
            public string nombre;
            public byte edad;
            public Alumno(string nombre,byte edad) 
            {
                this.nombre = nombre;
                this.edad = edad;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                StreamWriter sw = new StreamWriter("ejemplo.txt", true);
                Console.Write("Ingrese su nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su edad: ");
                byte edad = byte.Parse(Console.ReadLine());
                Alumno alm = new Alumno(nombre, edad);

                sw.WriteLine(alm.nombre + "" + alm.edad);

                sw.Close();
                Console.WriteLine("Escribiendo");
                Console.ReadLine();
            }
            catch (FormatException e) 
            {
                Console.WriteLine("Datos erronenos");
                Console.WriteLine(e.Message);
            }
        }
    }
}
