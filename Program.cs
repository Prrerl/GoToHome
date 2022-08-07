namespace CSharpLessons
{
    class MyProgram
    {
        private const string Task_1_Text = "Задача 25: Напишите цикл, \n который принимает на вход два числа (A и B) \n и возводит число A в натуральную степень B.";
        private const string Task_2_Text = "Задача 27: Напишите программу, \n которая принимает на вход число и выдаёт сумму цифр в числе.";
        private const string Task_3_Text = "Задача 29: Напишите программу, \n которая задаёт массив из 8 элементов и выводит их на экран.";

        private static int Task_1()
        {
            Console.Write("Введите число A: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            int B = Convert.ToInt32(Console.ReadLine());
            int result = A;

            for(int i = 1; i < B; i++)
            {
                result *= A;
            }
            return result;
        }

        private static int Task_2()
        {
            Console.Write("Введите число: ");
            string number = Console.ReadLine();
            int result;

            if (int.TryParse(number, out result))
            {
                result = 0;
                for (int i = 0; i < number.Length; i++)
                {
                    result += number[i] - '0';
                }
            }
            return result;
        }

        private static void Task_3()
        {
            const int arraySize = 8;
            string[] array = new string[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine($"Введите элемент массива №{i + 1}: ", i);
                array[i] = Console.ReadLine();
            }
            Console.WriteLine();

            Console.WriteLine("Массив: ");
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write(array[i] + (i == arraySize - 1 ? ".\n" : ", "));
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите номер задачи: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Boolean IsOutOfLoop = true;

            do
            {
                IsOutOfLoop = true;
                switch (N)
                {
                    case 1:
                        Console.WriteLine(Task_1_Text + "\n");
                        Console.WriteLine("Результат: " + Task_1().ToString());
                        break;
                    case 2:
                        Console.WriteLine(Task_2_Text + "\n");
                        Console.WriteLine("Результат: " + Task_2().ToString());
                        break;
                    case 3:
                        Console.WriteLine(Task_3_Text + "\n");
                        Task_3();
                        break;
                    default:
                        Console.WriteLine("Нет такой задачи!: \n");
                        IsOutOfLoop = false;
                        break;
                }
            } while (IsOutOfLoop == false);
        }
    }
}