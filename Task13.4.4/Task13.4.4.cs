
class Program
{
    static void WriteDictionary(Dictionary<string, Contact> phoneBook) 
    {
        foreach (var contact in phoneBook)
        {
            Console.WriteLine(contact.Key + " " + contact.Value.PhoneNumber + " " + contact.Value.Email);
        }
        Console.WriteLine();
    }
    static void Main(string[] args) 
    {
        Dictionary<string, Contact> phoneBook = new Dictionary<string, Contact>()
        {
            ["Сергей"] = new Contact(6346263142, "gagwe@mail.com"),
            ["Андрей"] = new Contact(9768457634, "kuyk@mail.com")
        };

        WriteDictionary(phoneBook);

        phoneBook.TryAdd("Никита", new Contact(761421253, "myghopewjp@mail.com"));

        WriteDictionary(phoneBook);

        if (phoneBook.TryGetValue("Никита", out Contact contactToChange))
            contactToChange.PhoneNumber = 511266462;
       
        WriteDictionary(phoneBook);
    }
}