using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numeric = new LinkedList<int>();
            
            Console.Write("Добавьте первый элемент: ");
            numeric.add(int.Parse(Console.ReadLine()));

            for(; ; )
            {
                Console.Clear();
                Console.WriteLine("Выберите действие:\n" +
                    "1 - добавить новый элемент\n" +
                    "2 - удалить элемент с заданным значением\n" +
                    "3 - найти элемент с заданным значением\n" +
                    "4 - вывести элемент с текущим показателем\n" +
                    "5 - вывести количество элементов\n" +
                    "6 - вывести все элементы\n" +
                    "------------\n" +
                    "9 - выход из программы");
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.Write("\nВведите значение: ");
                        numeric.add(int.Parse(Console.ReadLine()));
                        break;
                    case 2:
                        Console.Write("\nВведите значение: ");
                        int num = int.Parse(Console.ReadLine());
                        if (numeric.find(num) != null)
                            numeric.remove(numeric.find(num));
                        else
                        {
                            Console.WriteLine("\nЭлемента с таким значением нет");
                            Console.ReadLine();
                        }                        
                        break;
                    case 3:
                        Console.Write("\nВведите значение: ");
                        numeric.find(int.Parse(Console.ReadLine()));
                        break;
                    case 4:
                        Console.Write("\nЭлемент с текущим показателем: ");
                        numeric.showNode(numeric.now);
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Всего элементов:");
                        Console.WriteLine(numeric.Count);
                        Console.ReadLine();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Все элементы:");
                        numeric.showAll();
                        Console.ReadLine();
                        break;
                    case 9:
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Неправильная команда");
                        Console.ReadLine();
                        break;
                }
                if (a == 9)
                    break;
            }

            Console.Clear();
            Console.ReadLine();
        }
    }
}
