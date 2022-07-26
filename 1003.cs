using System;

class Beakjoon_1003
{
	static void Main()
	{
		// 실행 해야하는 갯수
		int i_case = int.Parse(Console.ReadLine());

		for (int i = 0; i < i_case; i++)
		{
			// 데이터 입력
			int i_data = int.Parse(Console.ReadLine());

			int i_result = 1;
			int i_prev = 1;

			// fibonacci(0)
			if (i_data == 0)
				Console.WriteLine("1 0");

			// fibonacci(1)
			else if (i_data == 1)
				Console.WriteLine("0 1");

			// fibonacci(n)
			else
			{
				// 갯수 구하기
				for (int j = 2; j < i_data; j++)
				{                   
					// 이전의 값을 더해서 표시
					i_result += i_prev;

					// 이전 값을 저장
					i_prev = i_result - i_prev;
				}
				Console.WriteLine(i_prev + " " + i_result);
			}
		}
	}
}