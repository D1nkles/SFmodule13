using System.Collections;

class Program 
{
    static ArrayList GroupIntString(ArrayList input) 
    {
        ArrayList output = new ArrayList();
        int element1 = 0;
        string element2 = "";
        foreach (var inputElement in input)
        {
            if (inputElement is int) 
            {
                element1 += (int)inputElement;
            }

            if (inputElement is string)
            {
                element2 += inputElement;
            }
        }
        output.Add(element1);
        output.Add(element2);
        return output;
    }
    static void Main(string[] args) 
    {
        ArrayList arrayList = new ArrayList() 
        {
            22, "я абоб", 52, 682, "ус, х", new Exception(), "ехе", 4 
        };

        ArrayList arrayList2 = GroupIntString(arrayList);

        foreach (object element in arrayList2) 
        {
            Console.Write(element + "    ");
        }
    }
}