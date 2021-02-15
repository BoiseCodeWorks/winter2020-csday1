// IMPORT
using System;
using System.Collections.Generic;
using System.Threading;
using csharp1.Models;

// file system
namespace csharp1
{
  // Initialized by DotNet at complilation
  class Program
  {
    // this method gets run by `dotnet` run
    static void Main(string[] args)
    {


      Store myStore = new Store("123 Fake St.");

      myStore.addFurniture("Sofa", 300f, 19);
      bool running = true;
      while (running)
      {

        Console.Clear();
        Console.WriteLine(@"
 _       __     __                             __           _____       ____      __  ___           __ 
| |     / /__  / /________  ____ ___  ___     / /_____     / ___/____  / __/___ _/  |/  /___ ______/ /_
| | /| / / _ \/ / ___/ __ \/ __ `__ \/ _ \   / __/ __ \    \__ \/ __ \/ /_/ __ `/ /|_/ / __ `/ ___/ __/
| |/ |/ /  __/ / /__/ /_/ / / / / / /  __/  / /_/ /_/ /   ___/ / /_/ / __/ /_/ / /  / / /_/ / /  / /_  
|__/|__/\___/_/\___/\____/_/ /_/ /_/\___/   \__/\____/   /____/\____/_/  \__,_/_/  /_/\__,_/_/   \__/  
    ");

        Console.WriteLine(@"
press v to view inventory, a to add to inventory or q to quit
    
    ");

        ConsoleKeyInfo choice = Console.ReadKey();
        Console.WriteLine();
        if (choice.Key == ConsoleKey.A)
        {
          Console.Write("name: ");
          string name = Console.ReadLine();
          Console.Write("price: ");
          string strPrice = Console.ReadLine();

          if (float.TryParse(strPrice, out float price) && !myStore.Furniture.ContainsKey(name))
          {
            myStore.addFurniture(name, price, 10);
            Console.WriteLine($"\n name: {name}, price: {price}");
          }
          else
          {
            System.Console.WriteLine("invalid input");
          }


        }
        else if (choice.Key == ConsoleKey.Q)
        {
          running = false;
        }
        else
        {
          System.Console.WriteLine("invalid command");
          Thread.Sleep(1300);
        }
      }




      // Variable declaration
      // NO: let, const; var, explicit typing

      // Implicit typing: The type is determined by the value that is set 
      // var name = "mark";

      // Explicit typing: The type is set by the variable declaration
      // string name;


      // Strings
      // quote type, concatination, interpolation

      // String uses " "
      //   string name = "Mark";
      //   // Single char CAN be ' '
      //   char middleInital = 'R';

      //   // Concat
      //   string lastName = "Ohnsman";
      //string fullName = name + " " + middleInital + " " + lastName;

      // interpolation 
      //   string fullName = @$"
      //   Hello: 
      //   {name} {middleInital}  {lastName}   
      //   ";
      //   Console.WriteLine($"{0} {1}  {2}", name, middleInital, lastName);


      //   // Number
      //   // Whole number + or - Int
      //   int myNum = 1;

      //   // Decimal numbers use Float 'f'
      //   float num = 4.5f;


      // Boolean
      //   if (myNum > 10)
      //   {
      //     // do thing
      //   }
      // NO TRUTHY/FALSY

      //   if (myNum != null)
      //   {

      //   }

      // THERE IS NO UNDEFINDED the app simply will not run
      //   myNum.value;



      // Array / Collections
      // let cats = ['mittens']

      // Arrays have a specified length, it cannot be changed after instantiation
      //   string[] cats = new string[3];
      //   cats[0] = "mittens";
      //   cats[0] = null;

      // List; closer to js arrays
      // Must be instatiated, can add values immediately inside '{}'
      //   List<string> catList = new List<string>()
      //   {
      //       "mittens",
      //       "wiskers"
      //   };

      //   catList.Add("fluffy");
      //   catList.Remove("mittens");

      //   catList.AddRange(cats);

      //   catList.FindLastIndex(cat => cat.Contains("wisk"));

      // loops
      // Lists have Count not Length
      //   for (int i = 0; i < catList.Count; i++)
      //   {
      //     string c = catList[i];
      //     Console.WriteLine(c);
      //   }

      //   catList.ForEach(c => Console.WriteLine(c));

      //   foreach (string c in catList)
      //   {

      //   }


      // Object (dictionary)
      // THERE ARE NO POJO's 

      // dictionary of type key type, value type 
      //   Dictionary<string, int> catAges = new Dictionary<string, int>(){
      //       {"mittens", 5}
      //   };

      //   catAges.Add("wiskers", 6);

      //   catAges.Remove("fluffy");

      //   if (catAges.ContainsKey("fluffy"))
      //   {
      //     // will get runtime error if ran without above check
      //     System.Console.WriteLine(catAges["wiskers"]);
      //   }

      //   foreach (KeyValuePair<string, int> cat in catAges)
      //   {
      //     Console.WriteLine($"Name: {cat.Key} - Age: {cat.Value}");
      //   }


      // Console fun
      //   Console.Clear();

      //   Console.WriteLine("How do you want to be greeted?");
      //   string greeting = Console.ReadLine();
      //   Console.BackgroundColor = ConsoleColor.Black;
      //   Console.ForegroundColor = ConsoleColor.Green;
      //   Console.Clear();
      //   Console.Beep();


      //   System.Console.WriteLine("Well hello " + greeting);
      //   string message = "You are standing outside, there is a white house to the north and a mailbox here, what would you like to do?";

      //   foreach (char c in message)
      //   {
      //     Console.Write(c);
      //     Thread.Sleep(50);
      //   }
      //   string command = Console.ReadLine();


      // Class
    }
  }
}
