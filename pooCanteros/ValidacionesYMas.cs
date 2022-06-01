using System;
using System.Collections.Generic;

namespace pooCanteros
{
    public class ValidacionesYMas
    {
        /// <summary>
        /// muestra el nombre de los alumnos, de una lista de alumnos.
        /// </summary>
        /// <param name="listaDeAlumnos"> es una lista de alumnos</param>
        public void mostrarLista(List<Alumno> listaDeAlumnos)
        {
            foreach (Alumno alumno in listaDeAlumnos)
            {
                MostrarAlumno(alumno);
            }
        }

        /// <summary>
        /// valida un alumno mediante el nombre
        /// </summary>
        /// <param name="alumno"> recibo como parametro un objeto de alumno</param>
        public void Validar(Alumno alumno)
        {
            if (alumno.Nombre == string.Empty)
            {
                Console.WriteLine("No se encontro resultado");
                Console.WriteLine("--------------------------------------------");
            }
            else
            {
                Console.Write("Resultado de su búsqueda: " + alumno.Nombre + " " + alumno.Id);
            }

        }

        /// <summary>
        /// imprime las notas de los alumnos junto a su nombre;
        /// </summary>
        /// <param name="alumno">recibo como parametro un objeto de alumno</param>
        public void MostrarNotas( Alumno alumno)
        {
            for (int indice = 0; indice < alumno.Notas.Length; indice++)
            {
                Console.Write(alumno.Notas[indice]);
                if (indice < alumno.Notas.Length - 1)
                    Console.Write(", ");
               
            }
            
        }

        /// <summary>
        /// muestro un alumno, y su nombre, id y promedio.
        /// </summary>
        /// <param name="alumno">recibo como parametro un objeto de alumno</param>
        public void MostrarAlumno(Alumno alumno)
        {
            Console.WriteLine(" ");
            Console.Write("notas: " ); MostrarNotas(alumno);
            Console.WriteLine(   " , nombre: " + alumno.Nombre + " , promedio: " + alumno.Promedio);   
        }

        /// <summary>
        /// muestro un alumno inactivo e imprimo por pantalla su nombre
        /// </summary>
        /// <param name="alumno">recibo como parametro un objeto de alumno</param>
        public void MostrarAlumnoNoActivo(Alumno alumno)
        {
            Console.WriteLine("Alumno No activo: " + alumno.Nombre);
        }

    }
}
