
using WhatAreWeGonnaEat;

string Selection;

//Change variable name to be specefic
var fileName = "Recipies.json";
Console.WriteLine("Hello, please make a selection");
Console.WriteLine("Enter 1 to make your dinner plans!");
Console.WriteLine("Enter 2 to enter in a new recipie!");
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

        Console.WriteLine("What's the name of the recipie?");
        Recipie myObj = new Recipie();
        myObj.name = Console.ReadLine();
        Console.WriteLine(myObj.name);
        global::WhatAreWeGonnaEat.JsonFileUtils.SimpleWrite(myObj.name, "Recipies.json");
        

        Console.WriteLine("Great! Now, let's get the ingredients (sizes in development ;)");
        Ingredients newObj= new Ingredients();
        newObj.ingredientsname = Console.ReadLine();
        Console.WriteLine(newObj.ingredientsname);

        break;

        case "3":

            Console.WriteLine("Not eating something anymore? Let's get rid of it.");
        break;

        case "4":

        Console.WriteLine("Need to change a recipie?");
        break;

        case "5":

        Console.WriteLine("I'm ready to eat, I'm done.");

        break;
    }

