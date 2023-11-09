// See https://aka.ms/new-console-template for more information


using Examen1Parcial;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Ingrese los datos solicitados:");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Numero de Cuenta: ");
            string numeroCuenta = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Nombre de la Clase: ");
            string nombreClase = Console.ReadLine();

            Console.Write("Hora de la Clase: ");
            string horaClase = Console.ReadLine();

            Console.Write("Nombre del Catedratico: ");
            string nombreCatedratico = Console.ReadLine();

            Console.Write("Nota 1: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 3: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            Clase clase = new Clase

            {
                Nombre = nombre,
                NumeroCuenta = numeroCuenta,
                Email = email,
                NombreClase = nombreClase,
                HoraClase = horaClase,
                NombreCatedratico = nombreCatedratico
            };

            Promedio promedio = new Promedio (nota1, nota2, nota3);

            clase.MostrarAlumno();
            Console.WriteLine(promedio.MostrarPromedio());
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}



