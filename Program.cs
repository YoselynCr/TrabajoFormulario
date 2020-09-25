using System;

namespace Formulario_Basico
{
    class Program
    {
        static void Main(string[] args)
        {
            string n, t, o, c;

            Console.Write("Por favor ingresese su nombre: ");
            n = Console.ReadLine();
            Console.WriteLine(n);

            Console.Write("Telefono: ");
            t = Console.ReadLine();
            Console.WriteLine(t);

            Console.Write("Ocupación: ");
            o = Console.ReadLine();
            Console.WriteLine(o);

            Console.Write("Correo electronico: ");
            c = Console.ReadLine();
            Console.WriteLine(c);
            int e;

            Console.Write("Edad: ");
            e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(e);
            if (e <=18)
            {
                Console.WriteLine("Error en el registro, menor de edad.");
            }
            else
            {
                Console.WriteLine("Registro exitoso.");
            }
            Console.ReadLine()
        }
    }
}
