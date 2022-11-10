
using WhatAreWeGonnaEat;

string Selection;

//Change variable name to be specefic
var fileName = "Recipies.json";
Console.WriteLine("Hello, please make a selection");
Console.WriteLine("Enter 1 to make your dinner plans!");
Console.WriteLine("Enter 2 to enter in new recipies!");
Console.WriteLine();
Selection = Console.ReadLine();



static void SimpleWrite()
{

}

    switch (Selection)
    {
        case "1":
            Console.WriteLine("What's For Dinner?");
            break;
        case "2":
        Console.WriteLine("How many days are we planning for?");
        var numberofDays = int.Parse(Console.ReadLine());

        Console.WriteLine($"Great, so we need at least {numberofDays} dinner recipies, go ahead and enter the name, and how many people were feeding");
        var recipieList = new List<Recipie>();
        for (int i = 0; i < numberofDays; i++)
        {
            var recipie = new Recipie();
            Console.WriteLine("What's the name of the recipie?");
            Recipie.Name = Console.ReadLine();
            /*
            Recipie myObj = new Recipie();
            myObj.name = Console.ReadLine();
            Console.WriteLine(myObj.name);
            */
            Console.WriteLine("How many people is it serving?");
            Recipie.servingSize = int.Parse(Console.ReadLine());
        }
        
           global::WhatAreWeGonnaEat.JsonFileUtils.SimpleWrite(obj: recipieList, fileName: "Recipies.json");
        

        

        Console.WriteLine("Great! Now, let's get the ingredients (sizes in development ;)");
        Ingredients newObj= new Ingredients();
        newObj.ingredientsname = Console.ReadLine();
        Console.WriteLine(newObj.ingredientsname);

        break;

        case "3":

        Console.WriteLine("I'm ready to eat, I'm done.");

        break;
    }

