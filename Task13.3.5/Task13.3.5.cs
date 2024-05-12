using System.Collections;

class Program 
{
    static void GetMissingMonths(List<string> months, ArrayList missing) 
    {
        List<string> missingList = new List<string>();
        missing.RemoveRange(0, 4);
        foreach (string month in missing) 
        {
            missingList.Add(month);
        }
        months.AddRange(missingList);
        foreach (string month in months) 
        {
            Console.Write($"{month} ");
        }
        
    }
    static void Main(string[] args) 
    {
        var months = new List<string>()
        {
            "Jan", "Feb", "Mar", "Apr", "May"
        };

        var missing = new ArrayList()
        {
            1, 2, 3, 5, "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
        };

        GetMissingMonths(months, missing);
    }
}