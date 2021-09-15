using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pavel_Kai123
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Введите название функции: К(Калькулятор) или Ф(Формула прямоугольного треугольника)");
                char Decision = Convert.ToChar(Console.ReadLine());
                if (Decision == 'К')
                {
                    Console.WriteLine("Введите первое число");
                    double First = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите действие / * + -");
                    char Symbol = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    double Second = Convert.ToDouble(Console.ReadLine());
                    switch (Symbol)
                    {
                        case '+':
                            Console.WriteLine($"{First} + {Second} = {First + Second}");
                            break;
                        case '-':
                            Console.WriteLine($"{First} - {Second} = {First - Second} ");
                            break;
                        case '/':
                            Console.WriteLine($"{First} / {Second} = {First / Second}");
                            break;
                        case '*':
                            Console.WriteLine($"{First} * {Second} = {First * Second}");
                            break;
                    }
                }
                else if (Decision == 'Ф')
                {
                    Console.WriteLine("Введите первое число A");
                    double First = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число B");
                    double Second = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"1/2 * {First} * {Second} = {0.5 * First * Second}");
                }
                else
                {
                    Console.WriteLine("Вы ввели не правильную команду, попробуйте еще раз!");
                }


            }





            /*            int[] MyArr = new int[5];
                        MyArr[0] = 1;
                        MyArr[1] = 2;
                        MyArr[2] = 3;
                        MyArr[3] = 4;
                        MyArr[4] = 5;
                        foreach (int i in MyArr)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine($"{MyArr[4]}{MyArr[3]}{MyArr[2]}{MyArr[1]}{MyArr[0]}");*/




            Console.ReadKey();
        }
    }
}
