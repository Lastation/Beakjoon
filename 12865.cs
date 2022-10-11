using System;

class Beakjoon_12865
{
    public static int i_sub = 0;

    static void Main()
    {
        // 물품의 수와 버틸 수 있는 무게 입력
        string[] i_data = Console.ReadLine().Split();

        int count = int.Parse(i_data[0]);
        int weight = int.Parse(i_data[1]);

        int[,] array = new int[101, 100001];
        int[] W = new int[101];
        int[] V = new int[101];

        for (int i = 1; i <= count; i++)
        {
            i_data = Console.ReadLine().Split();
            W[i] = int.Parse(i_data[0]);
            V[i] = int.Parse(i_data[1]);
        }

        for (int i = 1; i <= count; i++)
        {
            for (int j = 1; j <= weight; j++)
            {
                // 버틸수 있는 무게가 물품의 무게보다 크다면
                if (j - W[i] >= 0)
                    array[i, j] = array[i - 1, j] > array[i - 1, j - W[i]] + V[i] ? array[i - 1, j] : array[i - 1, j - W[i]] + V[i];
                else
                    array[i, j] = array[i - 1, j];
            }
        }

        Console.WriteLine(array[count, weight]);
    }
}