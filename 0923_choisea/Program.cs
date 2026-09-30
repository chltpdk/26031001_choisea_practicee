using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        //16번
        Console.WriteLine("1 ~ 100 짝수 출력");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        //17번
        Console.WriteLine("0 ~ 10 While 작성");
        var start = 0;
        while (start <= 10)
        {
            Console.WriteLine(i);
            ++start;
        }

        //18번
        Console.WriteLine("1 ~ 100 홀수 출력");
        int i = 1;
        do
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
            i++;
        } while (i <= 10);

        //19번
        Console.WriteLine("세모 별 탑 출력");
        for (int i = 1; i <= 15; i += 2)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        //20번
        Console.WriteLine("가장 작은 수와 가장 큰수 출력");

        int max = int.MinValue;
        int min = int.MaxValue;

        for (int i = 1; i <= 5; i++)
        {
            Console.Write("숫자를 입력해주세요: ");
            int num = int.Parse(Console.ReadLine());

 
            if (num > max)
            {
                max = num;
            }

            if (num < min)
            {
                min = num;
            }
        }

        Console.WriteLine($"가장 큰 수: {max}");
        Console.WriteLine($"가장 작은 수: {min}");
    }
}

