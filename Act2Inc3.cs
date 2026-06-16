internal class Program
{
    private static void Main(string[] args)
    {
        int[] valores = new int[15];
        Console.WriteLine("Ingresa 15 números");
        for (int i = 0; i < valores.Length; i++)
        {
            Console.Write("Número " + (i + 1) + ": ");
            valores[i] = int.Parse(Console.ReadLine());
        }
        bool tieneRepetidos = false;
        for (int i = 0; i < valores.Length; i++)
        {
            for (int j = i + 1; j < valores.Length; j++)
            {
                if (valores[i] == valores[j])
                {
                    tieneRepetidos = true;
                    break;
                }
            }
            if (tieneRepetidos) break;
        }
        if (tieneRepetidos)
        {
            Console.WriteLine("Si hay al menos un numero repetido");
        }
        else
        {
            Console.WriteLine("No ningun numero repetido");
        }
    }
}