namespace backened
{


    class exercise31
    {
        static void Main()
        {


            int N = 5;
            int[,] matrix = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = i + j+10;
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }


            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (j <= i)
                        Console.Write(matrix[i, j] + "\t");
                    else
                        Console.Write("\t");
                }
                Console.WriteLine();
            }

        }





    }
}

