namespace _09._10task3;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Metn daxil edin");
        string sentence = Console.ReadLine();

        Console.WriteLine("Evvelki hal: " + sentence);
        Console.WriteLine();

        Console.WriteLine("Sonraki hali: ");
        SplitText(sentence);
    }

    public static void SplitText(string sentence)
    {

        string[] words = new string [0];
        string temp = "";

        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i]==' ' || sentence[i]== ',' || i == sentence.Length-1)
            {
                Array.Resize(ref words, words.Length + 1);
                if (i == sentence.Length - 1)
                {
                    temp += sentence[i];
                }
                words[words.Length-1] = temp;
                temp = "";
           
            }
            else
            {

                temp += sentence[i];

            }
        }

        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine(words[i]);
        }
    }


}

