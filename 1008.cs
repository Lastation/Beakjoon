using System;

class Beakjoon_1008
{
    static void Main()
    {
        // 실행 해야하는 갯수
        string[] i_data = Console.ReadLine().Split();

        // A / B 를 출력
        Console.WriteLine(double.Parse(i_data[0]) / double.Parse(i_data[1]));
    }
}