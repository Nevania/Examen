using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Parcial
{
    internal class Promedio  : PromedioInterface

    {
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public Promedio(double nota1, double nota2, double nota3)
        {
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        public string MostrarPromedio()
        {
            return $"El promedio es: {CalcularPromedio()}";
        }

        public string MostrarPromedio(double nota1, double nota2, double nota3)
        {
            return $"El promedio es: {CalcularPromedio(nota1, nota2, nota3)}";
        }

        public double CalcularPromedio()
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }

        public double CalcularPromedio(double nota1, double nota2, double nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }
    }

}

