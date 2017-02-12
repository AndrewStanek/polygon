using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polygon.Models;

namespace Polygon {
  class Program {
    static int option = 0;
    static int polygonPointCount = 0;
    static void Main(string[] args) {
      Console.WriteLine("Polygon surface area calculator.");

      //Main loop of the program
      while (option != 2) {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Calculate polygon surface");
        Console.WriteLine("2. Exit");
        option = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        switch (option) {
          case 1:
            break;
          case 2:
            break;
          default:            
            Console.WriteLine("Unknown operation.");
            break;
        }
      }

    }
  }
}
