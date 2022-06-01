using System.Collections.Generic;

namespace pooCanteros
{
    public class Busquedas
    {
        /// <summary>
        /// busca alumnos por el nombre.
        /// </summary>
        /// <param name="nombreEncontrado">nombre a buscar</param>
        /// <param name="listaDeAlumnos">es una lista de alumnos</param>
        /// <returns></returns>
        public Alumno BuscarNombre(string nombreEncontrado, List<Alumno> listaDeAlumnos)
        {

            for (int indice = 0; indice < listaDeAlumnos.Count; indice++)
            {
                if (listaDeAlumnos[indice].Nombre == nombreEncontrado)
                {
                    return listaDeAlumnos[indice];
                }

            }

            return new Alumno();
        }

        /// <summary>
        /// busca alumnos por el id
        /// </summary>
        /// <param name="idEncontrado">es el id a buscar</param>
        /// <param name="listaDeAlumnos">es una lista de alumnos</param>
        /// <returns></returns>
        public Alumno BuscarId(int idEncontrado, List<Alumno> listaDeAlumnos)
        {
            for (int indice = 0; indice < listaDeAlumnos.Count; indice++)
            {
                if (listaDeAlumnos[indice].Id == idEncontrado)
                {
                    return listaDeAlumnos[indice];
                }

            }

            return new Alumno();
        }

        /// <summary>
        /// busca el primer alumno que no este activo.
        /// </summary>
        /// <param name="noActivo"> identificador de no activo</param>
        /// <param name="listaDeAlumnos">es una lista de alumnos</param>
        /// <returns></returns>
        public Alumno BuscarNoActivo(bool noActivo, List<Alumno> listaDeAlumnos)
        {
            for (int indice = 0; indice < listaDeAlumnos.Count; indice++)
            {
                if (listaDeAlumnos[indice].Activo == noActivo)
                {
                    return listaDeAlumnos[indice];
                }

            }

            return new Alumno();
        }

        /// <summary>
        /// trae el primer alumno con  promedio mayor a 7
        /// </summary>
        /// <param name="listaDeAlumnos"> es una lista de alumnos</param>
        /// <returns></returns>
        public Alumno BuscarPromedioMayor(List<Alumno> listaDeAlumnos)
        {
            foreach (Alumno alumno in listaDeAlumnos)
            {
                if (alumno.PromedioTotal(alumno.Notas) > 7)
                {
                       return alumno;
                }

            }

            return new Alumno();
        }

        /// <summary>
        /// trae el primer alumno con  promedio menor a 7
        /// </summary>
        /// <param name="listaDeAlumnos">es una lista de alumnos</param>
        /// <returns></returns>
        public Alumno BuscarPromedioMenor(List<Alumno> listaDeAlumnos)
        {
            foreach (Alumno alumno in listaDeAlumnos)
            {
                if (alumno.PromedioTotal(alumno.Notas) < 7)
                {
                    return alumno;
                }

            }

            return new Alumno();
        }
    }
}
