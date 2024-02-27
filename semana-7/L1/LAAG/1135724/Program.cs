class Program
{
    static void Main(string[] args)
    {
        //Ejercicio 1
        Console.WriteLine("Mi segundo programa");

        // Declaración de variables
        string sNombre, sEdad, sCarrera, sCarne;

        // Solicitar al usuario los datos ingresados
        Console.Write("Ingrese su nombre: ");
        sNombre = Console.ReadLine();

        Console.Write("Ingrese su edad: ");
        sEdad = Console.ReadLine();

        Console.Write("Ingrese su carrera: ");
        sCarrera = Console.ReadLine();

        Console.Write("Ingrese su Carne: ");
        sCarne = Console.ReadLine();

        // Mostrar los datos ingresados
        Console.WriteLine("Su nombre es " + sNombre);

        Console.WriteLine("Su edad es " + sEdad);

        Console.WriteLine("Su carrera es " + sCarrera);

        Console.WriteLine("Su carne es " + sCarne);

        Console.ReadKey();
    }
   
}

