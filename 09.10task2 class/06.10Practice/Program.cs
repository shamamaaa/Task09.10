namespace _06._10Practice;
class Program
{
    static void Main(string[] args)
    {

        Students student1 = AddStudent();
        Students student2 = AddStudent();

        Score(student1);
        Score(student2);
        Console.WriteLine();
        Console.WriteLine("Netice:");
        Console.WriteLine();
        CompareScores(student1, student2);




    }

    public static Students AddStudent()
    {
        Console.WriteLine("Telebenin adini daxil edin.");
        string name = Console.ReadLine();
        byte[] scores = new byte[3];


        for (int i = 0; i < 3; i++)
        {
            Console.Write("{0}. bal daxil et: ", i + 1);
            if (byte.TryParse(Console.ReadLine(), out byte UserInput))
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

        return new(name, scores[0], scores[1], scores[2]);

    }


    public static void CompareScores(Students student1, Students student2)
    {
        int[] student1score = { student1.Point1, student1.Point2, student1.Point3 };
        int[] student2score = { student2.Point1, student2.Point2, student2.Point3 };

        int Xal1 = 0;
        int Xal2 = 0;

        for (int i = 0; i < student1score.Length; i++)
        {
            if (student1score[i] > student2score[i])
            {
                Xal1++;
            }
            else if (student1score[i] < student2score[i])
            {
                Xal2++;
            }
            if (student1score[i] == student2score[i])
            {
                Xal2 = Xal2;
                Xal1 = Xal1;
            }

        }

        Console.WriteLine(student1.Name + " " + Xal1);
        Console.WriteLine(student2.Name + " " + Xal2);
    }

    public static void Score(Students student)
    {
        Console.WriteLine(student.Name+ ": "+ student.Point1 + " " + student.Point2 + " " + student.Point3);

    }

}