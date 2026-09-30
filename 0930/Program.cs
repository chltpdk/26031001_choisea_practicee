using System.Xml.Linq;

class Program
    {
    static void Main(string[] args)
    {
        int[] carNumber = new int[10];
        string[] carName = new string[10];
        DateTime[] carTime = new DateTime[10];

        parking[] carparking;

        player player;

        mob[] mObs;

        mob[] mobs;
        mobs = new mob[1000];
            for (int i = 0; i < mobs.Length; ++i)
            {
                mobs[i] = new mob();
                mobs[i].Name = "몹이름 :" + i.ToString();
            }

            for (int i = 0; i < mobs.Length; ++i)
            {
                Console.WriteLine(mobs[i].Name);
            }

                carparking = new parking[100];
                player = new player();
                mObs = new mob[1000];

            System.Random random = new System.Random();//정확히는 이고 시스템 빼두댐

            for (int i = 0; i < 10; ++i)
            {
                //var randValue = random.doubleNext(); 도 가능
                var randValue = random.Next(2, 12 + 1);
                Console.WriteLine(randValue); // Console.WriteLine(double
            }
            //동적할당 - 사용자 정의 , 배열
        }

    //일반화
    List<mob> mobs = new();
       




}



