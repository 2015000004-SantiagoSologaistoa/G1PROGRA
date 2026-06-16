internal class Program
{
    private static void Main(string[] args)
    {
        int[] edadPersona = new int[7];
        int cantidadPersonasMayores = 0;

        for (int i = 0; i < edadPersona.Length; i++)
        {
            Console.Write("Digite la edad: " + (i + 1) + ": ");
            edadPersona[i] = Convert.ToInt32(Console.ReadLine());
            if (edadPersona[i] >= 18)
                cantidadPersonasMayores++;
        }

        //mOSTRAR los datos del arreglo
        Console.Clear();
        Console.Write("Las edades son: ");
        for (int i = 0; i < edadPersona.Length; i++)
        {
            Console.Write(edadPersona[i] + " - ");

        }
        Console.WriteLine("Las personas mayores son: " + cantidadPersonasMayores);
    }
}
