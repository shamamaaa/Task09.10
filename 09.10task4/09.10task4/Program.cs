namespace _09._10task4;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Metni daxil edin");
        string sentence = Console.ReadLine();

        Console.WriteLine("Simvolu daxil edin");
        char symbol = Console.ReadKey().KeyChar;
        Console.WriteLine();
        Console.WriteLine("Yekun metn");
        Console.WriteLine(Trim(sentence, symbol));
    }

    public static string TrimStart(string word, char symbol = ' ')
    {
        int first = 0;
        string newtext = "";

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == symbol)
            {
                continue;
            }
            else
            {
                first = i;
                break;
            }
        }

        for (int i = first; i < word.Length; i++)
        {
            newtext += word[i];
        }

        return newtext;
    }
    public static string TrimEnd(string word, char symbol = ' ')
    {
        int last = word.Length - 1;
        string newtext = "";

        for (int i = word.Length - 1; i >= 0; i--)
        {
            if (word[i] == symbol)
            {
                continue;
            }
            else
            {
                last = i;
                break;
            }

        }

        for (int i = 0; i <= last; i++)
        {
            newtext += word[i];
        }
        return newtext;
    }

    public static string Trim(string word, char symbol = ' ')
    {
        string newtext = TrimStart(word, symbol);
        newtext = TrimEnd(newtext, symbol);
        return newtext;
    }

}

