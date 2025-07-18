// Red Bull	    AUT Ausztria	GBR Milton Keynes
// Ferrari	    ITA Olaszország	ITA Maranello
// Mercedes	    GER Németország	GBR Brackley
// Alpine	    FRA Franciaország	GBR Enstone
// McLaren	    GBR Egyesült Királyság	GBR Woking
// Alfa Romeo	SUI Svájc	SUI Hinwil
// Aston Martin	GBR Egyesült Királyság	GBR Silverstone
// Haas	        USA Egyesült Államok	USA Kannapolis
// AlphaTauri	ITA Olaszország	ITA Faenza
// Williams	    GBR Egyesült Királyság	GBR Oxfordshire
// Console.WriteLine("ide jön a szöveg");

// Console.WriteLine("Red Bull");
// Console.WriteLine("Ferrari"); 
// Console.WriteLine("Mercedes");	   
// Console.WriteLine("Alpine");	   
// Console.WriteLine("McLaren");	   
// Console.WriteLine("Alfa Romeo");	
// Console.WriteLine("Aston Martin");
// Console.WriteLine("Haas");	       
// Console.WriteLine("AlphaTauri");
// Console.WriteLine("Williams");  	 

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


