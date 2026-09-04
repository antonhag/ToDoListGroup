namespace ToDoListGroup;

class Program
{
    
    
    static void Main(string[] args)
    {
        List<string> uppgifter = new List<string>();
        
        Console.Write("Skriv in den uppgiften du vill lägga till: ");
        var uppgift = Console.ReadLine();
        
        uppgifter.Add(uppgift);
        
        Console.WriteLine($"Uppgiften {uppgift} har lagts till.");


        for (int i = 0; i < uppgifter.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {uppgifter[i]}");
        }
        
    }
}