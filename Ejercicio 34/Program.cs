int N = 11;
int[,] matrix = new int[N, N];


for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        if (j >= i && j <= N - i - 1 || j <= i && j >= N - i - 1)
        {
            matrix[i, j] = 2 * i + j;
        }
        else
        {
            matrix[i, j] = 0;
        }
    }
}
Console.WriteLine("Mtriz completa");
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("Reloj de Arena");
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        if (matrix[i, j] == 0)

            Console.Write("\t");
        else
            Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}

