int N = 5;
int[,] matriz = new int[N, N];

Console.WriteLine("Ingrese el orden de la matriz:10");
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        matriz[i, j] = i + j + 10;
    }
}

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        Console.Write(matriz[i, j] + "\t");
    }
    Console.WriteLine();
}


for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        if (j <= i)
            Console.Write(matriz[i, j] + "\t");
        else
            Console.Write("\t");
    }
    Console.WriteLine();
}












