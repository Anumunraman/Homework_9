namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            void Zadacha64()
            {
               /*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N, кратные трём.*/
                Console.WriteLine("Enter M number: ");
                int M = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter N number: ");
                int N = Convert.ToInt32(Console.ReadLine());
                Recursion(M, N);

                void Recursion(int M, int N)
                {
                    if (M >  N) return;
                    if (M % 3 == 0)
                    {
                        Console.Write(M + " ");
                    } 
                    M++;
                    Recursion(M, N);
                }
                
            
            }

            void Zadacha66()
            {
                /* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.*/
                Console.WriteLine("Enter M number: ");
                int M = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter N number: ");
                int N = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                Recursion(M, N);
                Console.WriteLine(sum);

                void Recursion(int M, int N)
                {
                    if (M > N) return;
                    sum += M;
                    M++;
                    Recursion(M, N);
                }
            }
            Zadacha66();

            
        }
        static void FillArray(int[,] array)
        {
            Random random = new Random();
            int rows = array.GetLength(0);
            int colums = array.GetLength(1);
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < colums; j++)
                {
                    array[i, j]=random.Next(0,100);
                }
            }
        }
        static void PrintArray(int[,] array)
        {
            Console.WriteLine();
            Console.WriteLine("Вывод массива: ");
            int rows = array.GetLength(0);
            int colums = array.GetLength(1);
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < colums; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}




 