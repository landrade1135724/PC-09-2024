class Program
{
    static void Main()
    {   
        /* ----------------------------------Ejercicio 1---------------------------------- */
        Console.WriteLine("Ingrese tres de los cuatro valores de la fórmula del movimiento rectilíneo uniformemente variado:");

        double? v0 = null, vf = null, a = null, t = null;

        Console.Write("Velocidad Inicial (m/s): ");
        string input = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(input))
            v0 = double.Parse(input);

        Console.Write("Velocidad Final (m/s): ");
        input = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(input))
            vf = double.Parse(input);

        Console.Write("Aceleración (m/s^2): ");
        input = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(input))
            a = double.Parse(input);

        Console.Write("Tiempo (s): ");
        input = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(input))
            t = double.Parse(input);

        // Comprobar cuál valor falta y calcularlo
        if (v0 == null)
        {
            v0 = vf.Value - a.Value * t.Value;
            Console.WriteLine("La velocidad inicial es: " + v0 + " m/s");
        }
        else if (vf == null)
        {
            vf = v0.Value + a.Value * t.Value;
            Console.WriteLine("La velocidad final es: " + vf + " m/s");
        }
        else if (a == null)
        {
            a = (vf.Value - v0.Value) / t.Value;
            Console.WriteLine("La aceleración es: " + a + " m/s^2");
        }
        else if (t == null)
        {
            t = (vf.Value - v0.Value) / a.Value;
            Console.WriteLine("El tiempo es: " + t + " s");
        }
        else
        {
            Console.WriteLine("No se puede calcular ningún valor porque se han ingresado todos los valores.");
        }

        Console.ReadLine(); // Esperar a que el usuario presione Enter para salir
        
        /* ----------------------------------Ejercicio 2---------------------------------- */
        Console.WriteLine("Luis Andrade - 1135724");

        // Solicitar la cantidad en quetzales
        Console.Write("Ingrese una cantidad entre 0 y 999.99:");
        double cantidad = double.Parse(Console.ReadLine());

        // Convertir la cantidad ingresada a centavos para facilitar los cálculos
        int cantidadCentavos = (int)(cantidad * 100);

        // Calcular billetes y monedas
        int billete100 = cantidadCentavos / 10000;
        cantidadCentavos %= 10000;

        int billete50 = cantidadCentavos / 5000;
        cantidadCentavos %= 5000;

        int billete20 = cantidadCentavos / 2000;
        cantidadCentavos %= 2000;

        int billete10 = cantidadCentavos / 1000;
        cantidadCentavos %= 1000;

        int billete5 = cantidadCentavos / 500;
        cantidadCentavos %= 500;

        int moneda1Quetzal = cantidadCentavos / 100;
        cantidadCentavos %= 100;

        int moneda25Centavos = cantidadCentavos / 25;
        cantidadCentavos %= 25;

        int moneda1Centavo = cantidadCentavos;

        // Mostrar los resultados
        Console.WriteLine("\nBilletes y monedas equivalentes:");

        Console.WriteLine(billete100 + " de Q 100");
        Console.WriteLine(billete50 + " de Q 50");
        Console.WriteLine(billete20 + " de Q 20");
        Console.WriteLine(billete10 + " de Q 10");
        Console.WriteLine(billete5 + " de Q 5");
        Console.WriteLine(moneda1Quetzal + " de Q 1");
        Console.WriteLine(moneda25Centavos + " de 25 centavos");
        Console.WriteLine(moneda1Centavo + " de 1 centavo");

        Console.ReadLine(); // Esperar a que el usuario presione Enter para salir
    }

}