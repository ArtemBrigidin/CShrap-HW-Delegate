class Program
{
    public delegate int dSum(int a, int b);
    static int Sum(int a, int b)
    {
        return a + b;
    }

    public delegate string dToUp(string str);
    static string ToUp(string str)
    {
        string newStr = str.ToUpper();
        return newStr;
    }

    public delegate List<int> dEvenArray(List<int> numbers);
    static List<int> EvenArray(List<int> numbers)
    {
        return numbers.Where(num => num % 2 == 0).ToList();
    }

    delegate int dTotalLength(List<string> strings);
    static int TotalLength(List<string> strings)
    {
        return strings.Sum(str => str.Length);
    }

    delegate double dAverage(List<int> numbers);
    static double Average(List<int> numbers)
    {
        if (numbers.Count == 0)
        {
            return 0.0;
        }
        return numbers.Average();
    }

    delegate List<string> dChangeCase(List<string> strings);
    static List<string> ChangeCase(List<string> strings)
    {
        return strings.Select(str => char.ToUpper(str[0]) + str.Substring(1).ToLower()).ToList();
    }

    delegate List<string> dUpperWords(List<string> words);
    static List<string> UpperWords(List<string> words)
    {
        return words.Where(word => word.All(char.IsUpper)).ToList();
    }

    static void Main(string[] args)
    {
        dSum sum = Sum;
        Console.WriteLine(sum(1,2));

        dToUp up = ToUp;
        Console.WriteLine(up("test"));

        dEvenArray even = EvenArray;
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
        Console.WriteLine("Четные числа: " + string.Join(", ", even(numbers)));

        dTotalLength totalLength = TotalLength;
        List<string> strings = new List<string> { "abc", "defg", "hi" };
        Console.WriteLine("Общая длина строк: " + totalLength(strings));

        dAverage average = Average;
        List<int> numList = new List<int> { 1, 2, 3, 4, 5 };
        Console.WriteLine("Среднее арифметическое: " + average(numList));

        dChangeCase changeCase = ChangeCase;
        List<string> strList = new List<string> { "привет", "мир", "123" };
        Console.WriteLine("Строки с измененным регистром: " + string.Join(", ", changeCase(strList)));

        dUpperWords upperWords = UpperWords;
        List<string> wordList = new List<string> { "HELLO", "WORLD", "hello", "world" };
        Console.WriteLine("Слова в верхнем регистре: " + string.Join(", ", upperWords(wordList)));
    }
}