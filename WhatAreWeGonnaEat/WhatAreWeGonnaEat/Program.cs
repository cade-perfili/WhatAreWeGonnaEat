
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WhatAreWeGonnaEat;

string Selection;

//Change variable name to be specefic
var fileName = "Recipies.json";
Console.WriteLine("Hello, please make a selection");
Console.WriteLine("Enter 1 to make your dinner plans!");
Console.WriteLine("Enter 2 to enter in new recipies!");
Console.WriteLine();
Selection = Console.ReadLine();


    switch (Selection)
    {
        case "1":
            Console.WriteLine("What's For Dinner?");
            break;
        case "2":
        Console.WriteLine("How many days are we planning for?");
        var numberofDays = int.Parse(Console.ReadLine());

        Console.WriteLine($"Great, so we need at least {numberofDays} dinner recipies, go ahead and enter the name, and how many people were feeding");
        Console.WriteLine("");
        var recipieList = new List<Recipie>();
        for (int i = 0; i < numberofDays; i++)
        {
            var recipie = new Recipie();
            Console.WriteLine("What's the name of the recipie?");
            recipie.Name = Console.ReadLine();
            /*
            Recipie myObj = new Recipie();
            myObj.name = Console.ReadLine();
            Console.WriteLine(myObj.name);
            */ 
            
            Console.WriteLine("How many people is it serving?");
            int getSize;
            while (true)
            {
               if (int.TryParse(Console.ReadLine(), out getSize))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input for serving size, needs to be a number. Try again");
                }

            }
         recipie.servingSize = getSize;
            recipieList.Add(recipie);
            Console.WriteLine("");
        }
        Console.WriteLine($"Great, you've added your recipies");

        foreach (Recipie recipie in recipieList)
        {
            

            var Json = JsonConvert.SerializeObject(recipieList);
            global::WhatAreWeGonnaEat.JsonFileUtils.PrettyWrite(Json, "Recipies.Json");
            //global::WhatAreWeGonnaEat.JsonFileUtils.SimpleWrite(recipieList, "Recipies.Json");
        }

        Console.WriteLine("Now, let's get the ingredients (sizes in development;)");
        

        break;

        case "3":

        Console.WriteLine("I'm ready to eat, I'm done.");

        break;
    }

