namespace pooCanteros
{
    public class Alumno
    {
        private string nombre;
        private int id;
        public Alumno()
        {
            Nombre = string.Empty;
        }
        public Alumno(string nombre, int id, bool activo, int[] notas, double promedio)
        {
        
            Nombre = nombre;
            Id = id;
            Activo = activo;
            Notas = notas;
            Promedio = promedio;

        }
        public string Nombre
        {
            get { return nombre; }

            set { nombre = value; }
        }

        public int Id
        {
            get { return id; }

            set { id = value; }
        }

        public bool Activo { set; get; }

        public int[] Notas { set; get; }

        public double Promedio { set; get; }

        /// <summary>
        /// saca el premdio de notas de un alumno.
        /// </summary>
        /// <param name="Notas"> recibo un array con sus notas</param>
        /// <returns></returns>
        public double PromedioTotal(int[] Notas)
        {
            int suma = 0;
            for (int indice = 0; indice < Notas.Length; indice++)
                    suma += Notas[indice];
            double promedio = (double)suma / Notas.Length;

            Promedio = promedio;

            return promedio;
        }


    }
}
