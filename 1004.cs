using System;

class Beakjoon_1004
{
    static void Main()
    {
        // 실행 해야하는 갯수
        int i_case = int.Parse(Console.ReadLine());

        while (i_case > 0)
        {
            // 출발점과 도착점의 데이터
            string[] s_data = Console.ReadLine().Split();

            // 출발점 데이터
            int x1 = int.Parse(s_data[0]);
            int y1 = int.Parse(s_data[1]);

            // 도착점 데이터
            int x2 = int.Parse(s_data[2]);
            int y2 = int.Parse(s_data[3]);

            // 행성계 진입/이탈 횟수
            int result = 0;

            // 행성계의 중점과 반지름 데이터 갯수
            int i_dataCount = int.Parse(Console.ReadLine());
            while (i_dataCount > 0)
            {
                // 행성계의 중점과 반지름 데이터
                s_data = Console.ReadLine().Split();
                int cx = int.Parse(s_data[0]);
                int cy = int.Parse(s_data[1]);
                int cr = int.Parse(s_data[2]);

                // 출발점이 행성계 안에 존재하는지 판별
                double distance1 = MathF.Pow(cx - x1, 2) + MathF.Pow(cy - y1, 2);
                bool check1 = distance1 > MathF.Pow(cr, 2) ? false : true;

                // 도착점이 행성계 안에 존재하는지 판별
                double distance2 = MathF.Pow(cx - x2, 2) + MathF.Pow(cy - y2, 2);
                bool check2 = distance2 > MathF.Pow(cr, 2) ? false : true;

                // 만약 서로 값이 다르다면 진입/이탈 횟수 증가
                result = check1 != check2 ? result + 1 : result;

                i_dataCount -= 1;
            }
            Console.WriteLine(result);

            i_case -= 1;
        }
    }
}