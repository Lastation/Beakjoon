using System;

class Beakjoon_1002
{
	static void Main()
	{
		// 실행 해야하는 갯수
		int i_case = int.Parse(Console.ReadLine());
		for (int i = 0; i < i_case; i++)
		{
			// 데이터 입력
			string[] s_data = Console.ReadLine().Split();

			// 조규현의 데이터
			int x1 = int.Parse(s_data[0]);
			int y1 = int.Parse(s_data[1]);
			int r1 = int.Parse(s_data[2]);

			// 백승환의 데이터
			int x2 = int.Parse(s_data[3]);
			int y2 = int.Parse(s_data[4]);
			int r2 = int.Parse(s_data[5]);

			// 중심거리 계산
			double f_distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

			// 두 원이 만나지 않을 경우
			// r2 + r1 < d or  r2 - r1 > d
			if (f_distance > r1 + r2 || f_distance < Math.Abs(r1 - r2) && r1 != r2)
				Console.WriteLine(0);

			// 두 원이 한 점에서 만날경우
			// r2 - r1 = d
			else if (f_distance == r1 + r2 || f_distance == Math.Abs(r1 - r2) && r1 != r2)
				Console.WriteLine(1);

			// 두 원이 두 점에서 만날경우
			// r2 - r1 < d < r2 + r1
			else if (f_distance < r1 + r2 && f_distance > Math.Abs(r1 - r2))
				Console.WriteLine(2);

			// 두 원이 겹칠경우
			// r2 = r1 and x1 = x2 and y1 = y2
			else
				Console.WriteLine(-1);
		}
	}
}
