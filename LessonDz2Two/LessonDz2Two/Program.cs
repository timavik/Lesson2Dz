using LessonDz2Two.Models;
using System;

namespace LessonDz2Two
{
    internal class Program
    {
        static void Main(string[] args)
        {
      FirstStructure first = new FirstStructure();

      //Console.WriteLine("Напишите чило A");
      //var a = Console.ReadLine();
      //Console.WriteLine("Напишите чило B");
      //var b = Console.ReadLine();

      //var a_digit = Console.ToInt32(a);
      //var b_digit = Console.ToInt32(b);
      //var sum_digit = a_digit + b_digit;
      //Console.WriteLine(sum_digit);

      Console.Write("Введите первое число: ");
     double a = Convert.ToDouble(Console.ReadLine());

      Console.Write("Введите второе число: ");
     double b = Convert.ToDouble(Console.ReadLine());

      double sum = a + b;
      double difference = a - b;
      double product = a * b;
      double quotient = a / b;

      Console.WriteLine("Результаты");
      Console.WriteLine("Сумма: {0}", sum);
      Console.WriteLine("Разность: {0}", difference);
      Console.WriteLine("Произведение: {0}", product);
      Console.WriteLine("Частное: {0}", quotient);


    }
    }
}
