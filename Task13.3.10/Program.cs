class Program 
{
    static void Main(string[] args) 
    {
        bool hasNum;
        string sentence = "Подсчитайте, сколько уникальных символов в этом предложении, используя HashSet<T>, учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.";
        char[] arrSentence = sentence.ToCharArray();

        char[] nums = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        char[] marks = { ' ', ',', '.', '!', '?', ';', ':', '-' };

        HashSet<char> set = new HashSet<char>(arrSentence);
        
        hasNum = set.Overlaps(nums);
        if (hasNum)
            Console.WriteLine("В колллекции есть цифры.");
        else
            Console.WriteLine("В коллекции нет цифр.");

        Console.WriteLine($"Всего уникальных символов в предложении {set.Count}");

        set.ExceptWith(marks);
        Console.WriteLine($"Уникальных символов без знаков препинания: {set.Count}");
    }
}