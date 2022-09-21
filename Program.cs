using System.Globalization;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в калькулятор!");

            bool check = (true);

            do
            {
                Console.WriteLine("Введите номер операции:\r\n1. Сложить 2 числа\r\n2. Вычесть первое из второго\r\n3. Перемножить два числа\r\n4. Разделить первое на второе\r\n5. Возвести в степень N первое число\r\n6. Найти квадратный корень из числа\r\n7. Найти 1 процент от числа\r\n8. Найти факториал из числа\r\n9. Выйти из программы\r\n");

                string input = Console.ReadLine();
                int choice = Convert.ToInt32(input);

                if (choice == 1)
                {
                    Console.WriteLine("Введите два числа - ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());

                    int c = a + b;

                    Console.WriteLine("Результат = " + c + "\r\n");
                }

                else if (choice == 2)
                {
                    Console.WriteLine("Введите два числа - ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());

                    int c = b - a;

                    Console.WriteLine("Результат = " + c + "\r\n");
                }

                else if (choice == 3)
                {
                    Console.WriteLine("Введите два числа - ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());

                    int c = a * b;

                    Console.WriteLine("Результат = " + c + "\r\n");
                }

                else if (choice == 4)
                {
                    Console.WriteLine("Введите два числа - ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    double b = Convert.ToDouble(Console.ReadLine());

                    double c = a / b;

                    Console.WriteLine("Результат = " + c + "\r\n");
                }

                else if (choice == 5)
                {
                    Console.WriteLine("Введите два числа - ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int n = Convert.ToInt32(Console.ReadLine());
                    int c = a;

                    for (int j = 1; j < n; j++)
                    {
                        c = c * a;
                    }

                    Console.WriteLine("Результат = " + c + "\r\n");
                }

                else  if (choice == 6)
                {
                    Console.WriteLine("Введите одно число - ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    double x = 1;

                    while (Math.Pow(x, 2) < a)
                    {
                        x += 1;
                    }

                    int n = 1;

                    while (n <= 10)
                    {
                        x = 0.5 * (x + a / x);
                        n += 1;
                    }

                    Console.WriteLine("Результат = " + Math.Round(x, 10) + "\r\n");
                }

                else if (choice == 7)
                {
                    Console.WriteLine("Введите одно число - ");
                    double a = Convert.ToDouble(Console.ReadLine());

                    double c = a / 100;

                    Console.WriteLine("Результат = " + c + "\r\n");
                }

                else if (choice == 8)
                {
                    Console.WriteLine("Введите одно число - ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    int a = 1;
                    
                    for (int i = 2; i <= n; i++)
                    {
                        a = a * i;
                    }

                    Console.WriteLine("Результат = " + a + "\r\n");
                }
                
                else if (choice == 9)
                {
                    check = false;
                }

                else
                {
                    Console.WriteLine("Ошибка - введено некорректное значение операции\r\n");
                }
            }
            while (check == true);
        }
    }
}