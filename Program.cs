Console.Clear();
System.Console.WriteLine("Выберите задачу:");
System.Console.WriteLine();
System.Console.WriteLine("1 - Задача 47. Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.");
System.Console.WriteLine();
System.Console.WriteLine("2 - Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,");
System.Console.WriteLine("и возвращает значение этого элемента или же указание, что такого элемента нет.");
System.Console.WriteLine();
System.Console.WriteLine("3 - Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
int TaskIndex = int.Parse(Console.ReadLine());
System.Console.WriteLine();
switch (TaskIndex)
{
    case 1:
        static void Task1()
        {
            double[,] Array = new double[3, 4];
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Array[i, j] = new Random().NextDouble() * ((10) - (-10)) + (-10);
                    Array[i, j] = Math.Round(Array[i, j], 1);
                }
            }

            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    System.Console.Write(Array[i, j] + " ");
                }
                System.Console.WriteLine();
            }
        }
        Task1();
        break;
    case 2:
        static void Task2()
        {
            int[,] Array = {{1,4,7,2},
                            {5,9,2,3},
                            {8,4,2,4}};


            System.Console.Write("Введите число чтобы узнать есть ли оно в массиве:");
            int number = int.Parse(Console.ReadLine());
            int NoNumber = 0;
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    if (Array[i, j] == number)
                    {
                        System.Console.WriteLine($"Число {number} Находится в массиве на строке {i + 1} в {j + 1} столбце.");
                        NoNumber = 1;
                    }
                }
            }
            if (NoNumber == 0) { System.Console.WriteLine("Такого числа в массиве нет"); }
        }
        Task2();
        break;
    case 3:
        static void Task3()
        {
            int[,] Array = {{1, 3, 7, 8},
                            {0, 13, 4, 28},
                            {9, 11, 2, 4}};

            double[] Mid = new double[Array.GetLength(1)];
            
            
            for (int m = 0; m < Mid.Length; m++)
            {
                
                for (int i = 0; i < Array.GetLength(0); i++)
                {                 
                    Mid[m] = Mid[m] + Array[i,m];
                }
                Mid[m] = Mid[m] / Array.GetLength(0);
                Mid[m] = Math.Round(Mid[m], 2);
                
            }
            System.Console.Write("Средние арифметические всех столбцов массива - ");
            for (int i = 0; i < Mid.Length; i++)
            {
                System.Console.Write(Mid[i] + " ");
            }
        }
        Task3();
        break;
    default:
        System.Console.WriteLine("Такой задачи нет"); break;
}
