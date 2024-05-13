class Program 
{
    static void Main(string[] args) 
    {
        string sentence = "Подсчитайте, сколько уникальных символов в этом предложении, используя HashSet<T>, учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.";
        char[] arr = sentence.ToCharArray();

        HashSet<char> set = new HashSet<char>(arr);
        Console.WriteLine(set.Count);
    }
}