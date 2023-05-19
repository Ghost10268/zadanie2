using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 10 чтобы узнать информацию о всех заданиях");
            int number_mission = Convert.ToInt32(Console.ReadLine()); switch (number_mission)
            {
                case 10:
                    Console.WriteLine("1-е задание: Число +-5");
                    Console.WriteLine("2-е задание: Макс число из 3");
                    Console.WriteLine("3-е задание: Сумма только положительных чисел");
                    Console.WriteLine("4-е задание: Удвоить x, если x больше 10");
                    Console.WriteLine("5-е задание: День недели в зависимости от числа"); 
                    Console.WriteLine("6-е задание: Минимальное число большее 200 и делится на 17");
                    Console.WriteLine("7-е задание: 20км на какой день и 100км");
                    Console.WriteLine("8-е задание: Факториал");
                    Console.WriteLine("9-е задание: Натуральное число и его наименьший делитель отличный от 1"); 
                    break;
            }
            Console.WriteLine("Введите номер задания чтобы выполнить его");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1: Console.WriteLine("Введите число");
                    int pervyi_number = int.Parse(Console.ReadLine());
                    if (pervyi_number > 0)
                    {
                        Console.WriteLine(pervyi_number + 5);
                    }
                    else
                    {
                        Console.WriteLine(pervyi_number - 5);
                    }

                    break;
                case 2:
                    Console.WriteLine("Введите первое число");
                    int n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    int n2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите третье число");
                    int n3 = int.Parse(Console.ReadLine());
                    int maxim = n1;
                    if (n2 > maxim)
                    {
                        maxim = n2;
                    }
                    if (n3 > maxim)
                    {
                        maxim = n3;
                    }
                    Console.WriteLine("Наибольшее число из данных" + maxim);
                    break;
                case 3:
                    Console.WriteLine("Введите первое число:"); int n_1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    int n_2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите третье число:"); int n_3 = int.Parse(Console.ReadLine());
                    int sum = 0; if (n_1 > 0)
                    {
                        Console.WriteLine(sum += n_1);
                    }
                    if (n_2 > 0)
                    {
                        Console.WriteLine(sum += n_2);
                    }
                    if (n_3 > 0)
                    {
                        Console.WriteLine(sum += n_3);
                    }
                    else
                    {
                        Console.WriteLine("Все числа отрицательные");
                    }
                    break;
                case 4:
                    Console.WriteLine("Введите x");
                    int x = int.Parse(Console.ReadLine());
                    if (x > 10)
                    {
                        Console.WriteLine($"Удвоенное значение {x * 2}");
                    }
                    else
                    {
                        Console.WriteLine(x);
                    }
                    break;
                case 5:
                    Console.WriteLine("Введите день недели (1-7)");
                    int day_of_week = int.Parse(Console.ReadLine());

                    switch (day_of_week)
                    {
                case 1:
                            Console.WriteLine("понедельник");
                    break;
                        case 2:
                            Console.WriteLine("вторник");
                            break;

                        case 3:
                            Console.WriteLine("среда");
                            break;

                        case 4:
                            Console.WriteLine("четверг");
                            break;

                        case 5:
                            Console.WriteLine("пятница");
                            break;

                        case 6:
                            Console.WriteLine("суббота");
                            break;

                        case 7:
                            Console.WriteLine("воскресенье");
                            break;

                    }
                    break;
                case 6:
                    Console.WriteLine("Вывести наименьшее число больше 200, которое нацело делится на 17");
                    int cifra = 200;
                    int delim = 17;
                    while (true)
                    {
                        if (cifra % delim == 0)
                            break;
                        ++cifra;
                    }
                    Console.WriteLine(cifra);
                    break;
                case 7:
                    double distanc = 10;
                    int days = 1;
                    double distanc2 = 10;
                    while (distanc < 20)
                    {
                        distanc *= 1.05;
                        days++;
                    }
                    Console.WriteLine($"Через {days} дней человек пробежит {distanc:F2} км");

                    while (distanc2 >= 100)
                    {
                        distanc2 += distanc;
                       
                    }
                    Console.WriteLine($" На {distanc2}-й день достигнет общей дистанции в 100 км");
                    break;
                case 8:
                    Console.WriteLine("Введите число чтоб найти факториал");
                    int chislo = int.Parse(Console.ReadLine());
                    int factorial = 1;
                    for (int i = 1; i <= chislo; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine($"Факториал числа {chislo} = {factorial}");
                    break;
                case 9:
                    Console.WriteLine("Вывести натуральное число");
                    int getero_chislo = int.Parse(Console.ReadLine());
                    int delitely = 0;
                    for (int i = 2; i < getero_chislo; i++)
                    {
                        if (getero_chislo % i == 0)
                        {
                            delitely = i;
                            break;
                        }
                    }
                    Console.WriteLine($"Наименьший делитель {getero_chislo} отличный от 1 равен {delitely}");
                    break;
                  
            }
           
           
            Console.ReadKey();
        }
    }
}
