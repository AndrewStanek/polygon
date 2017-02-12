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
            CalculatePolygonArea();
            break;
          case 2:
            break;
          default:            
            Console.WriteLine("Unknown operation.");
            break;
        }
      }
    }

    static void CalculatePolygonArea() {
      List<Point> points = new List<Point>();
      int x = 0;
      int y = 0;
      Console.Write("Number of vertexes: ");
      polygonPointCount = Convert.ToInt32(Console.ReadLine());

      if (polygonPointCount <= 2) {
        Console.WriteLine("Polygon must have at least 3 vertexes.");
        return;
      }

      for (int i = 0; i < polygonPointCount; i++) {
        Console.WriteLine(String.Format("{0} vertex:", i + 1));
        Console.Write("x: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("y: ");
        y = Convert.ToInt32(Console.ReadLine());
        points.Add(new Point(x, y));
      }
      Polygon2D polygon = new Polygon2D(points);
      Console.WriteLine(String.Format("Area of given polygon is: {0}", polygon.SurfaceArea));
    }
  }
}
