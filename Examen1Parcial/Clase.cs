using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Parcial
{
    internal class Clase : Alumno
    {
        public string NombreClase { get; set; }
        public string HoraClase { get; set; }
        public string NombreCatedratico { get; set; }

        public override void MostrarAlumno()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Numero de Cuenta: {NumeroCuenta}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Nombre de la Clase: {NombreClase}");
            Console.WriteLine($"Hora de la Clase: {HoraClase}");
            Console.WriteLine($"Nombre del Catedratico: {NombreCatedratico}");
        }
    }
}

