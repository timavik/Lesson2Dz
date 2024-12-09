using System;
using LessonDz2.Models;

namespace LessonDz2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      FirstStructure first = new FirstStructure();

      Console.WriteLine("привет напиши соё имя");
      string name = Console.ReadLine();
      Console.WriteLine("напиши свой возрост");
      string year = Console.ReadLine();
      Console.WriteLine("напиши свой рост в метрах");
      string height = Console.ReadLine();

      first.Name = name;
      first.Year = Convert.ToInt32(year);
      first.Height = Convert.ToDouble(height.Replace('.', ','));
    }
  }
}
