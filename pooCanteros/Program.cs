using System;
using System.Collections.Generic;

namespace pooCanteros
{
    class Program
    {
        static void Main(string[] args)
        {
            Busquedas metodo = new Busquedas();

            ValidacionesYMas validacionesYOtros = new ValidacionesYMas();
 
            Alumno alumno1 = new Alumno("lara", 1, true, new int[] { 8, 8, 8 }, 0);

            Alumno alumno2 = new Alumno("nicole", 2, true, new int[] { 9, 7, 8 }, 0);

            Alumno alumno3 = new Alumno("tomas", 3, false, new int[] { 7, 2, 4 }, 0);

            Alumno alumno4 = new Alumno("walter", 4, true, new int[] { 9, 10, 9 }, 0);

            
            List<Alumno> listaDeAlumnos = new List<Alumno>();

            listaDeAlumnos.Add(alumno1);
            listaDeAlumnos.Add(alumno2);
            listaDeAlumnos.Add(alumno3);
            listaDeAlumnos.Add(alumno4);

            validacionesYOtros.mostrarLista(listaDeAlumnos);

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.Write("Ingrese el nombre de un alumno: " );
            string nombreBuscado = Console.ReadLine().ToLower();
            Alumno alumno= metodo.BuscarNombre(nombreBuscado, listaDeAlumnos);
       
            validacionesYOtros.Validar(alumno);
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------");

            Console.Write("Ingrese el id de un alumno: ");
            int idBuscado = Convert.ToInt32(Console.ReadLine());
            alumno = metodo.BuscarId(idBuscado, listaDeAlumnos);
            validacionesYOtros.Validar(alumno);

            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------------------");

            Console.Write("Las notas son: ");
            validacionesYOtros.MostrarNotas(alumno1);

            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------------------- ");

            alumno = metodo.BuscarNoActivo(false, listaDeAlumnos);
            validacionesYOtros.MostrarAlumnoNoActivo(alumno);

            Console.WriteLine("---------------------------------------------");

            Console.Write("El alumno con promedio mayor a 7 es: ");
            alumno = metodo.BuscarPromedioMayor(listaDeAlumnos);

            validacionesYOtros.MostrarAlumno(alumno);
            Console.WriteLine("---------------------------------------------");

            Console.Write("El alumno con menor promedio es: ");
            alumno = metodo.BuscarPromedioMenor(listaDeAlumnos);
            validacionesYOtros.MostrarAlumno(alumno);

            Console.WriteLine(" ");
      
        }
    }
}
