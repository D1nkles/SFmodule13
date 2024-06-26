﻿class Program 
{
    static void Main(string[] args) 
    {
        bool hasNum;
        char[] nums = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        char[] marks = { ' ', ',', '.', '!', '?', ';', ':', '-' };

        while (true) 
        {
            Console.WriteLine("Введите любой текст: ");
            string sentence = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(sentence)) 
            { 
                char[] arrSentence = sentence.ToCharArray();
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
            else  
                Console.WriteLine("Вы ввели пустую строку"); 
        }
    }
}