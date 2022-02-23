using System.Collections.Generic;
using System.Linq;
using System;
using ToDoList.Models;

namespace ToDoList.UI
{
  public class Program
  {
    public static void Main()
    {

      Console.WriteLine("Do you want to add a new item to your to do list or view your to do list?");
      bool keepGoing = true;
      
      while (keepGoing == true)
      {
        Console.WriteLine("Write 'yes' to add to your list, 'view' to view your list, and 'quit' to close the program");
        string response = Console.ReadLine();
        if (response == "yes") 
        {
          Console.WriteLine("Go ahead and write your new item");
          string toDo = Console.ReadLine();
          Item newEntry = new Item(toDo);
        }
        else if (response == "view")
        {
          List<Item> result = Item.GetAll();
          if (result.Count == 0)
          {
            Console.WriteLine("You haven't added anything to your list yet");
            Console.WriteLine()
          }
          else
          {
            Console.WriteLine("To Do:");
            Console.WriteLine(result);
            foreach (Item thisItem in result)
            {
              Console.WriteLine("To Do: " + thisItem.Description);
            }
          }
        }
        else if (response == "quit")
        {
          keepGoing = false;
        }
        else 
        {
          Console.WriteLine("That was not a valid input. Please try again.");
        }
      }
      Console.WriteLine("Goodbye.");
    }
  }
}