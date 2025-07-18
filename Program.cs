using Microsoft.VisualBasic;

var list = new string[] {
    "Red Bull",
    "Ferrari",
    "Mercedes",
    "Alpine",
    "McLaren",
    "Alfa Romeo",
    "Aston Martin",
    "Haas",
    "AlphaTauri",
    "Williams",
};

foreach (var item in list)
{
    WriteToConsole(item);
}

void WriteToConsole(string item)
{
    if (item == "Mercedes")
    {
        var itemUpperCase = item.ToUpper();
        Console.WriteLine(itemUpperCase);
    }
    else
    {
        Console.WriteLine(item);
    }
}

