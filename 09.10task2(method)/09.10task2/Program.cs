namespace _06._10Practice;
class Program
{
    static void Main(string[] args)
    {

        int[] ResadScores = new int[3];
        int[] AydanScores = new int[3];

        Console.WriteLine("Resadin ballari: ");
        AddData(ResadScores);
        Console.WriteLine("Aydanin ballari: ");
        AddData(AydanScores);

        Console.WriteLine();
        Console.WriteLine("Netice: ");
        Console.WriteLine();

        CompareScores(ResadScores, AydanScores);

        Console.WriteLine();

        Console.WriteLine("Resadin derecesi:");
        Score(ResadScores);
        Console.WriteLine("Aydanin derecesi:");
        Score(AydanScores);

    }


    public static void CompareScores(int[] Resadscore, int[] Aydanscore)
    {
        int AydanXal = 0;
        int ResadXal = 0;

        for (int i = 0; i < Resadscore.Length; i++)
        {
            if (Resadscore[i] > Aydanscore[i])
            {
                ResadXal++;
            }
            else if (Resadscore[i] < Aydanscore[i])
            {
                AydanXal++;
            }
            if (Resadscore[i] == Aydanscore[i])
            {
                AydanXal = AydanXal;
                ResadXal = ResadXal;
            }

        }
        Console.WriteLine("Resadin xali: " + ResadXal);
        Console.WriteLine("Aydanin xali: " + AydanXal);
    }

    public static void Score(int[] scores)
    {
        for (int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine("İdman novu {0}: {1}", i + 1, scores[i]);
        }

    }

    public static void AddData(int[] scores)
    {
        for (int i = 0; i < 3; i++)
        {
            Console.Write("{0}. bal daxil et: ", i + 1);
            if (int.TryParse(Console.ReadLine(), out int UserInput))
            {
                if (UserInput >= 0 && UserInput <= 100)
                {
                    scores[i] = UserInput;
                }
                else
                {
                    Console.WriteLine("Yanlis melumat. Bal 0-100 araliginda olmalidir.");
                    i--;
                }
            }
            else
            {
                Console.WriteLine("Yanlis melumat. Bal eded olmalidir.");
                i--;
            }
        }
    }
}
