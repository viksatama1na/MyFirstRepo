using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            misstake:
            Console.WriteLine("Изберете си опция:");
            Console.WriteLine("1. 1-100");
            Console.WriteLine("2. 1-300");
            Console.WriteLine("3. 1-500");
            Console.WriteLine("4. 1-700");
            Console.WriteLine("5. 1-900");
            Console.WriteLine("6. 1-1500");
            Console.WriteLine("7. Изход");


            int option = int.Parse(Console.ReadLine());


            if (option > 0 && option < 7)
            {
                switch (option)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    case 5:
                        Task5();
                        break;
                    case 6:
                        Task6();
                        break;
                }

                option = int.Parse(Console.ReadLine());
            }
            else if (option == 7)
            {
                Console.WriteLine("Вие излязохте от програмата!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Въвели сте грешна опция отпитайте от ново");
                Console.WriteLine("");
                goto misstake;
            }
            
        }

        static void Task1()
        {
            Random randomNumber = new Random();
            int computerNumber = randomNumber.Next(1, 101);



            Console.WriteLine("Въведете пълно число от 1 до 100");
        wurni:
            int num = int.Parse(Console.ReadLine());
            if (num > 100)
            {
                Console.WriteLine("Вие сте въвели неправилно число");
                Console.WriteLine("Числото което въвеждате трябва да е от 1 до 100");
                goto wurni;
            }
            else if (num < 1)
            {
                Console.WriteLine("Вие сте въвели неправилно число");
                Console.WriteLine("Числото което въвеждате трябва да е от 1 до 100");
                goto wurni;
            }
            else if (num == computerNumber)
            {
                Console.WriteLine("Вие познахте числото");
                
            }
            else if (num > computerNumber)
            {
                Console.WriteLine("Числото което сте въвели е ПО-ГОЛЯМО");
                goto wurni;
            }
            else if (num < computerNumber)
            {
                Console.WriteLine("Чилото което сте въвели е ПО-МАЛКО");
                goto wurni;
            }
        }
        
        static void Task2()
        {
            Random randomNumber = new Random();
            int computerNumber = randomNumber.Next(1, 301);



            Console.WriteLine("Въведете пълно число от 1 до 300");
        wurni:
            int num = int.Parse(Console.ReadLine());
            if (num > 100)
            {
                Console.WriteLine("Вие сте въвели неправилно число");
                Console.WriteLine("Числото което въвеждате трябва да е от 1 до 300");
                goto wurni;
            }
            else if (num < 1)
            {
                Console.WriteLine("Вие сте въвели неправилно число");
                Console.WriteLine("Числото което въвеждате трябва да е от 1 до 300");
                goto wurni;
            }
            else if (num == computerNumber)
            {
                Console.WriteLine("Вие познахте числото");
                goto misstake;
            }
            else if (num > computerNumber)
            {
                Console.WriteLine("Числото което сте въвели е ПО-ГОЛЯМО");
                goto wurni;
            }
            else if (num < computerNumber)
            {
                Console.WriteLine("Чилото което сте въвели е ПО-МАЛКО");
                goto wurni;
            }
        }
        static void Task3()
        {
            Random randomNumber = new Random();
            int computerNumber = randomNumber.Next(1, 501);



            Console.WriteLine("Въведете пълно число от 1 до 500");
        wurni:
            int num = int.Parse(Console.ReadLine());
            if (num > 100)
            {
                Console.WriteLine("Вие сте въвели неправилно число");
                Console.WriteLine("Числото което въвеждате трябва да е от 1 до 500");
                goto wurni;
            }
            else if (num < 1)
            {
                Console.WriteLine("Вие сте въвели неправилно число");
                Console.WriteLine("Числото което въвеждате трябва да е от 1 до 500");
                goto wurni;
            }
            else if (num == computerNumber)
            {
                Console.WriteLine("Вие познахте числото")
            ; goto misstake;
            }
            else if (num > computerNumber)
            {
                Console.WriteLine("Числото което сте въвели е ПО-ГОЛЯМО");
                goto wurni;
            }
            else if (num < computerNumber)
            {
                Console.WriteLine("Чилото което сте въвели е ПО-МАЛКО");
                goto wurni;
            }
        }
        static void Task4()
        {
            Random randomNumber = new Random();
            int computerNumber = randomNumber.Next(1, 701);



            Console.WriteLine("Въведете пълно число от 1 до 700");
        wurni:
            int num = int.Parse(Console.ReadLine());
            if (num > 100)
            {
                Console.WriteLine("Вие сте въвели неправилно число");
                Console.WriteLine("Числото което въвеждате трябва да е от 1 до 1700");
                goto wurni;
            }
            else if (num < 1)
            {
                Console.WriteLine("Вие сте въвели неправилно число");
                Console.WriteLine("Числото което въвеждате трябва да е от 1 до 700");
                goto wurni;
            }
            else if (num == computerNumber)
            {
                Console.WriteLine("Вие познахте числото");
                goto misstake;
            }
            else if (num > computerNumber)
            {
                Console.WriteLine("Числото което сте въвели е ПО-ГОЛЯМО");
                goto wurni;
            }
            else if (num < computerNumber)
            {
                Console.WriteLine("Чилото което сте въвели е ПО-МАЛКО");
                goto wurni;
            }
        }
        static void Task5()
        {
            Random randomNumber = new Random();
            int computerNumber = randomNumber.Next(1, 901);



            Console.WriteLine("Въведете пълно число от 1 до 900");
        wurni:
            int num = int.Parse(Console.ReadLine());
            if (num > 100)
            {
                Console.WriteLine("Вие сте въвели неправилно число");
                Console.WriteLine("Числото което въвеждате трябва да е от 1 до 900");
                goto wurni;
            }
            else if (num < 1)
            {
                Console.WriteLine("Вие сте въвели неправилно число");
                Console.WriteLine("Числото което въвеждате трябва да е от 1 до 900");
                goto wurni;
            }
            else if (num == computerNumber)
            {
                Console.WriteLine("Вие познахте числото");
                goto misstake;
            }
            else if (num > computerNumber)
            {
                Console.WriteLine("Числото което сте въвели е ПО-ГОЛЯМО");
                goto wurni;
            }
            else if (num < computerNumber)
            {
                Console.WriteLine("Чилото което сте въвели е ПО-МАЛКО");
                goto wurni;
            }
        }
        static void Task6()
        {
            Random randomNumber = new Random();
            int computerNumber = randomNumber.Next(1, 1501);



            Console.WriteLine("Въведете пълно число от 1 до 1500");
        wurni:
            int num = int.Parse(Console.ReadLine());
            if (num > 100)
            {
                Console.WriteLine("Вие сте въвели неправилно число");
                Console.WriteLine("Числото което въвеждате трябва да е от 1 до 1500");
                goto wurni;
            }
            else if (num < 1)
            {
                Console.WriteLine("Вие сте въвели неправилно число");
                Console.WriteLine("Числото което въвеждате трябва да е от 1 до 1500");
                goto wurni;
            }
            else if (num == computerNumber)
            {
                Console.WriteLine("Вие познахте числото");
                goto misstake;
            }
            else if (num > computerNumber)
            {
                Console.WriteLine("Числото което сте въвели е ПО-ГОЛЯМО");
                goto wurni;
            }
            else if (num < computerNumber)
            {
                Console.WriteLine("Чилото което сте въвели е ПО-МАЛКО");
                goto wurni;
            }
        }
    }
}