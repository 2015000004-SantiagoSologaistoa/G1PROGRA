internal class Program
{
    private static void Main(string[] args)
    {
        int[] numeros = new int[8];
        Console.WriteLine("Ingrese 8 numeros: ");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Número " + (i + 1) + ": ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int numeroMayor = numeros[0];
        int posicionMayor = 0;

        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > numeroMayor)
            {
                numeroMayor = numeros[i];
                posicionMayor = i;
            }
        }
        Console.WriteLine("El número mayor es: " + numeroMayor);
        Console.WriteLine("Se encuentra en la posición: " + posicionMayor);
    }
}
