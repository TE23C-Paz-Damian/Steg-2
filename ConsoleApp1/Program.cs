using System;

class Program
{
    static void Main(string[] args)
    {
        // Skapa en string-array med namnen på fem olika leksaker
        string[] leksaker = { "Teddybjörn", "Bil", "Docka", "Bilbana", "Fotboll" };

        // Skriv ut leksakerna
        Console.WriteLine("Här är namnen på fem leksaker:");
        foreach (string leksak in leksaker)
        {
            Console.WriteLine(leksak);
        }
    }
}




//* 
class Program
{
    static void Main(string[] args)
    {
        // Skapar en lista med namn på leksaker
        List<string> leksaker = new List<string>
        {
            "Teddybjörn",
            "Lego",
            "Docka",
            "Bilbana",
            "Fotboll"
        };

        // Skriver ut varje leksak med en foreach-loop
        Console.WriteLine("Foreach-loop:");
        foreach (string leksak in leksaker)
        {
            Console.WriteLine(leksak);
        }
    }
}


//*
class Program
{
    static void Main(string[] args)
    {
        // Skapar en lista med namn på fem klasskamrater
        List<string> klasskamrater = new List<string>
        {
            "Wing",
            "Georgios",
            "Mustafa",
            "Romeo",
            "Vincent"
        };

        // Skriver ut namnen på klasskamraterna
        Console.WriteLine("Mina klasskamrater:");
        foreach (string klasskamrat in klasskamrater)
        {
            Console.WriteLine(klasskamrat);
        }
    }
}

//*

using System;

class Program
{
    static void Main(string[] args)
    {
        // Skapar en array med fem heltalsvärden mellan 0 och 10
        int[] värden = { 3, 7, 1, 9, 5 };

        // Skriver ut värdena
        Console.WriteLine("Värden i arrayen:");
        foreach (int värde in värden)
        {
            Console.WriteLine(värde);
        }
    }
}



//*
class Program
{
    static void Main(string[] args)
    {
        // Lista med klasskamrater
        List<string> klasskamrater = new List<string> { "Wing", "Georgios", "Mustafa", "Romeo", "Vincent" };

        // Lista med leksaker
        List<string> leksaker = new List<string> { "Teddybjörn", "Lego", "Docka", "Bilbana", "Fotboll" };

        // Array med betyg
        int[] betyg = { 5, 8, 7, 6, 9 };

        // For-loop som skriver ut "Pelle ger Teddybjörn betyget 5" osv.
        for (int i = 0; i < klasskamrater.Count; i++)
        {
            Console.WriteLine($"{klasskamrater[i]} ger {leksaker[i]} betyget {betyg[i]}.");
        }
    }
}


//*
class Program
{
    static void Main(string[] args)
    {
        // Skapar en tom string-lista som heter "cities"
        List<string> cities = new List<string>();

        // Skriver ut ett meddelande för att visa att listan är skapad
        Console.WriteLine("Den tomma listan 'cities' har skapats.");
    }
}

//*
class Program
{
    static void Main(string[] args)
    {
        // Skapar en tom string-lista som heter "cities"
        List<string> cities = new List<string>();

        string input;

        // Startar loopen
        while (true)
        {
            // Frågar användaren om en stad
            Console.Write("Skriv in en stad (eller skriv 'exit' för att avsluta): ");
            input = Console.ReadLine();

            // Om användaren skriver "exit", avsluta loopen
            if (input.ToLower() == "exit")
            {
                break;
            }

            // Lägg till staden i listan
            cities.Add(input);
        }

        // Skriver ut alla städer som lagts till i listan
        Console.WriteLine("\nStäder som du har lagt till:");
        foreach (string city in cities)
        {
            Console.WriteLine(city);
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        // 
        List<string> cities = new List<string>();

        string input;

        // 
        while (true)
        {
            // 
            Console.Write("Skriv in en stad (eller skriv 'exit' för att avsluta): ");
            input = Console.ReadLine();

            // 
            if (input.ToLower() == "exit")
            {
                break;
            }

            // 
            cities.Add(input);
        }

        // 
        Console.WriteLine("\nStäder som du har lagt till:");
        foreach (string city in cities)
        {
            Console.WriteLine(city);
        }
    }
}