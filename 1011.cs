using System;

class Beakjoon_1011
{
    public static int i_sub = 0;

    static void Main()
    {
        // 실행 해야하는 갯수
        int i_count = int.Parse(Console.ReadLine());

        while (i_count > 0)
        {
            //  테스트 케이스 정수 a, b
            string[] s_data = Console.ReadLine().Split();

            int i_x = int.Parse(s_data[0]);
            int i_y = int.Parse(s_data[1]);

            int i_result = i_y - i_x;

            if (i_result > 2)
                i_result = (i_result - 2) / 2;

            Console.WriteLine(i_result);

            i_count--;
        }
    }
}