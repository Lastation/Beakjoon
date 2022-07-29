using System;

class Beakjoon_1001
{
    static void Main()
    {
        // 실행 해야하는 갯수
        string[] i_data = Console.ReadLine().Split();

        // A + B 를 출력
        Console.WriteLine(int.Parse(i_data[0]) - int.Parse(i_data[1]));
    }
}