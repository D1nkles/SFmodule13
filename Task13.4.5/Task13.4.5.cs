using System.Diagnostics;

class Program
{
    static void WriteDictionary(SortedDictionary<string, Contact> phoneBook)
    {
        foreach (var contact in phoneBook)
        {
            Console.WriteLine(contact.Key + " " + contact.Value.PhoneNumber + " " + contact.Value.Email);
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        SortedDictionary<string, Contact> phoneBook = new SortedDictionary<string, Contact>()
        {
            ["Сергей"] = new Contact(6346263142, "gagwe@mail.com"),
            ["Андрей"] = new Contact(9768457634, "kuyk@mail.com")
        };

        WriteDictionary(phoneBook);
        
        Stopwatch sw = Stopwatch.StartNew();
        phoneBook.TryAdd("Никита", new Contact(761421253, "myghopewjp@mail.com"));
        sw.Stop();
        Console.WriteLine(sw.Elapsed.TotalMilliseconds);
        WriteDictionary(phoneBook);

        if (phoneBook.TryGetValue("Никита", out Contact contactToChange))
            contactToChange.PhoneNumber = 511266462;

        WriteDictionary(phoneBook);
    }
}