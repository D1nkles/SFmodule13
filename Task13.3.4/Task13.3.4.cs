class Program 
{
    static void AddUnique(Contact newContact, List<Contact> phoneBook) 
    {
        bool isUnique = true;
        foreach(Contact contact in phoneBook) 
        {
            if(contact.Name == newContact.Name) 
                isUnique = false;
        }

        if (isUnique) 
            phoneBook.Add(newContact);

        phoneBook.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));

        foreach(Contact contact in phoneBook) 
        {
            Console.WriteLine($"{contact.Name}  {contact.PhoneNumber}  {contact.Email}");
        }
    }
    static void Main(string[] args) 
    {
        List<Contact> phoneBook = new List<Contact>() 
        {
            new Contact("Сергей", 098582916, "gagwe@mail.com"),
            new Contact("Андрей", 62384786, "kuyk@mail.com"),
            new Contact("Олег", 71631612916, "vcmdg@mail.com"),
            new Contact("Роман", 9753531916, "jtyukty@mail.com")
        };

        Contact newContact = new Contact("Григорий", 1416367, "kiuylk@mail.com");

        AddUnique(newContact, phoneBook);
    }
}