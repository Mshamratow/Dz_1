using System;
using System.Globalization;
using System.Security.AccessControl;



namespace Lessons
{
    class program
    {
        static void task1()
        {
            Console.WriteLine("Задание №1:\nМир Труд Май");
            Console.WriteLine("Мир\n\tТруд\n\t\tМай\n");
        }
        static void task2()
        {
            Console.WriteLine("Задание №2:\nВведите 2 числа: ");
            string first = Console.ReadLine(),
                   second = Console.ReadLine();
            double firstValue, secondValue, bufferValue;

            if (!double.TryParse(first, out firstValue) || (!double.TryParse(second, out secondValue)))
            {
                Console.WriteLine("Пожалуйста, введите правильно");
            }
            else
            {
                bufferValue = firstValue;
                firstValue = secondValue;
                secondValue = bufferValue;
                Console.WriteLine($"Ваши числа в обратном порядке: {firstValue} {secondValue}\n");
            }
        }
        static void task3()
        {
            Console.Write("Введите радиус окружности: ");
            string inputString = Console.ReadLine();

            if (double.TryParse(inputString, out double radius))
            {
                Console.WriteLine($"Длина окружности равна: {2 * radius * Math.PI}");
                Console.WriteLine($"Площадь окружности равна: {radius * radius * Math.PI}");
            }
            else
            {
                Console.WriteLine("Вы ввели не число!");
            }

        }
        static void task4()
        {
            string inputString = Console.ReadLine();
            if (double.TryParse(inputString, out double x))
            {
                Console.WriteLine(Math.Cos(x));
            }
            else
            {
                Console.WriteLine("Введите правильно");
            }
        }
        static void task5()
        {
            Console.WriteLine("Задание №5:\nВведите коэффициенты квадратного уравнения:");
            double a = double.Parse(Console.ReadLine()),
                   b = double.Parse(Console.ReadLine()),
                   c = double.Parse(Console.ReadLine());
            double discriminant = (Math.Pow(b, 2) - 4 * a * c);
            if (discriminant < 0)
            {
                Console.WriteLine("Квадратное уравнение с данными коэффициентами корней не имеет!\n");
            }
            else if (discriminant == 0)
            {
                Console.WriteLine($"Квадратное уравнение с данными коэффициентами имеет 1 корень = {(-b + Math.Sqrt(discriminant)) / (2 * a)}!\n");
            }
            else
            {
                Console.WriteLine($"Квадратное уравнение с данными коэффициентами имеет 2 кореня = {(-b + Math.Sqrt(discriminant)) / (2 * a)}, {(-b - Math.Sqrt(discriminant)) / (2 * a)}!\n");
            }
        }

        static void task7()
        {
            Console.WriteLine("Задание №7:");
            Random random = new Random();
            Console.WriteLine($"Случайно сгенерированные числа:\n" +
                $"{random.Next(10)}\n" +
                $"{random.Next(100)}\n" +
                $"{random.Next(1000)}\n" +
                $"{random.Next(10000)}\n");
        }
        static void task8()
        {
            Console.WriteLine("Задание №8:\nВведите трехзначное число, которое Вы бы хотели изменить:");
            string value = Console.ReadLine();
            if (value.Length != 3)
            {
                Console.WriteLine("Введите трехзначное число!!!\n");
            }
            else
            {
                uint valueToReverse = uint.Parse(value);
                uint newValue = ((valueToReverse % 10) * 100) + (valueToReverse / 10);
                Console.WriteLine($"Результат выполнения программы: {newValue}\n");
            }
        }
        static void task9()
        {
            Console.WriteLine("Задание №9:\nВведите цену Конфет, Печенья, Яблок за килограмм: ");
            double candiesPrice = double.Parse(Console.ReadLine()),
                   cookiesPrice = double.Parse(Console.ReadLine()),
                   applesPrice = double.Parse(Console.ReadLine());
            Console.WriteLine("Сколько килограмм конфет, печенья и яблок Вы бы хотели приобрести?");
            double candiesWeight = double.Parse(Console.ReadLine()),
                   cookiesWeight = double.Parse(Console.ReadLine()),
                   applesWeight = double.Parse(Console.ReadLine());
            Console.WriteLine("Итоговая сумма корзины будет составлять: " +
                $"{(candiesPrice * candiesWeight) + (cookiesPrice * cookiesWeight) + (applesPrice * applesWeight)}");
        }


        static void Main()
        {
            task1();
            task2();
            task3();
            task4();
            task5();
            task7();
            task8();
            task9();

            Console.ReadKey();
        }

    }

}

