//class Program
//    {
//    class product : IComparable
//    {
//        public string Name { get; set; }
//        public int Price { get; set; }


//        public override string ToString()
//        {
//            return Name + ": " + Price + "원";
//        }
//        public int CompareTo(object? obj)
//        {
//            return this.Price.CompareTo((obj as product).Price);
//        }
//    }
//        static void Main(string[] args)
//        {
//        List<product> list = new List<product>()
//            {
//                new product() { Name = "고구마", Price = 1500 },
//                new product() { Name = "사과", Price = 2400 },
//                new product() { Name = "바나나", Price = 1000 },
//                new product() { Name = "배", Price = 3000 },
//            };
//        list.Sort();

//        foreach (var item in list)
//            {
//                Console.WriteLine(item);
//            }
//        }
//    }

using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "data.txt";

        while (true)
        {
            string previousContent = "";


            if (File.Exists(filePath))
            {
                previousContent = File.ReadAllText(filePath);
            }


            if (string.IsNullOrEmpty(previousContent))
            {
                Console.WriteLine("파일에 아무 내용도 없습니다");
            }
            else
            {
                Console.WriteLine($"이전에 입력한 내용 : {previousContent}");
            }


            Console.Write(">저장할 문자열을 입력해주세요 :");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                break;
            }

            string newContent = string.IsNullOrEmpty(previousContent)
                ? input
                : $"{previousContent}, {input}";


            File.WriteAllText(filePath, newContent);

            Console.WriteLine("저장했습니다\n");
        }
    }
}