using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        //Задача 1. Массив предназначен для хранения значений ростов двенадцати человек.
        //С помощью датчика случайных чисел заполнить массив целыми значениями, лежащими в диапазоне от 163 до 190 включительно.
        //Вывести значения элементов с использованием цикла for. Найти средний рост.
        //static void Height()
        //{
        //    int[] height = new int[12];
        //    Random rnd = new Random();
        //    for (int i = 0; i < height.Length; i++)
        //    {
        //        height[i] = rnd.Next(163,190);
        //        Console.Write($"Рост {i+1} человека = {height[i]}\n");
        //    }
        //    int all = 0;
        //    for (int i = 0; i < height.Length; i++)
        //    {
        //        all = all+height[i];
        //    }
        //    int medium = all / height.Length;
        //    Console.Write($"Средний рост равен {medium}");
        //}

        //static void Main(string[] args)
        //{
        //    Height();
        //    Console.ReadKey();
        //}

        //Задача 2. Заполнить массив из восьми элементов следующими значениями с использованием явной инициализации:
        //первый элемент массива равен 37, второй — 0, третий — 50, четвертый — 46, пятый — 34, шестой — 46, седьмой — 0, восьмой —13.
        //Найти максимальный и минимальный элементы массива.
        //static void Minmax()
        //{
        //    int[] omas = new int [8] {37,0,50,46,34,46,0,-13 };
        //    for (int i=0; i<omas.Length;i++)
        //    {
        //        Console.Write($"{omas[i]}\t");
        //    }
        //    int min = omas.Min();
        //    int max = omas.Max();
        //    Console.Write($"\nМинимальное значение = {min}\tМаксимальное значение = {max}");
        //}
        //static void Main(string[] args)
        //{
        //    Minmax();
        //    Console.ReadKey();
        //}

        //Задача 3. Заполнить одномерный массив с клавиатуры и вывести элементы массива на экран в обратном порядке.
        //static void Reverse()
        //{
        //    int[] omas = new int[5];
        //    for (int i = 0; i < omas.Length; i++)
        //    {
        //        Console.Write($"\nВведите {i+1} значение:");
        //        omas[i] = int.Parse(Console.ReadLine());
        //    }
        //    for (int i = omas.Length-1; i >= 0; i--)
        //    {
        //        Console.Write($"{omas[i]}\t");
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    Reverse();
        //    Console.ReadKey();
        //}

        //Задача 4. Заполнить одномерный массив случайным образом от -5 до 5 целыми числами. Увеличить все элементы в два раза.
        //Вывести новые значения массива с использованием цикла foreach.
        //static void Double()
        //{

        //    int[] omas = new int[6];
        //    Random rnd = new Random();
        //    for (int i = 0; i < omas.Length; i++)
        //    {
        //        omas[i] = rnd.Next(-5, 5);
        //        Console.Write($"omas{i} = {omas[i]}\n");
        //        omas[i] = omas[i] * 2;
        //    }
        //    foreach (int i in omas)
        //    {
        //        Console.Write($"{i}\t");
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    Double();
        //    Console.ReadKey();
        //}

        //Задача 5. В массиве хранятся сведения об оценках 25 учеников по химии.Определить количество неуспевающих по химии учеников.
        static void Marks()
        {
            int a = 0, b = 0, c = 0, d = 0;
            int[] marks = new int[25];
            Random rnd = new Random();
            for (int i=0;i<marks.Length;i++)
            {
                marks[i] = rnd.Next(2, 5+1);
                Console.Write($"{marks[i]}\t");
                if (marks[i] == 2)
                { a++; }
                if (marks[i] == 3)
                { b++; }
                if (marks[i] == 4)
                { c++; }
                if (marks[i] == 5)
                { d++; }
            }
            Console.WriteLine($"\nКоличество двоечников по химии = {a}");
            Console.WriteLine($"Количество троеников по химии = {b}");
            Console.WriteLine($"Количество хорошистов по химии = {c}");
            Console.WriteLine($"Количество отличников по химии = {d}");
        }
        static void Main(string[] args)
        {
            Marks();
            Console.ReadKey();
        }
    }
}
