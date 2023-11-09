using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Parcial
{
    internal interface PromedioInterface
    {
        string MostrarPromedio();
        string MostrarPromedio(double nota1, double nota2, double nota3);
        double CalcularPromedio();
        double CalcularPromedio(double nota1, double nota2, double nota3);
    }
}
