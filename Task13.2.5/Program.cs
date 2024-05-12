using System.Collections;

class Program 
{
    static void Main(string[] args)
    {
        var months = new[]
        {
            "Jan", "Feb", "Mar", "Apr", "May" , "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
        };

        var numbers = new[]
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
        };

        ArrayList arrList = new ArrayList();
        for (int i = 0; i < months.Length && i < numbers.Length ; i++) 
        {
            arrList.Add(months[i]);
            arrList.Add(numbers[i]);
        }

        foreach (object element in arrList) 
        {
            Console.Write($"{element} ");
        }
        
    }
}