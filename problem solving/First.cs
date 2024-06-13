using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void bud(int[] buds, int budget)
        {
            try
            {
                for (int i = 0; i <= buds.Length - 1; i++)
                {
                    for (int j = 0; j <= buds.Length - 1; j++)
                    {
                        if (buds[i] + buds[j] == budget)
                        {
                            Console.WriteLine($"We founded in ==>, index : {i} , index :{j}");


                        }


                    }







                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }





        }
        static void getBirth()
        {
            int year;
            int month;
            int day;

            do
            {
                Console.WriteLine("please Enter Valid year :");

                year = int.Parse(Console.ReadLine());

            } while (year > 2024 || year <= 1800);
            do
            {
                Console.WriteLine("please Enter Valid month :");

                month = int.Parse(Console.ReadLine());

            } while (month > 12 || month <= 0);

            if (month == 2)
            {
                do
                {

                    Console.WriteLine("please Enter Valid day :");

                    day = int.Parse(Console.ReadLine());

                } while (day > 29 || day <= 0);
            }
            else if (month == 4 || month == 6 || month == 11 || month == 9)
            {
                do
                {

                    Console.WriteLine("please Enter Valid day :");

                    day = int.Parse(Console.ReadLine());

                } while (day > 30 || day <= 0);



            }
            else
            {
                do
                {

                    Console.WriteLine("please Enter Valid day :");

                    day = int.Parse(Console.ReadLine());

                } while (day > 31 || day <= 0);


            }



            Console.WriteLine($"your brithday is :{day}-{month}-{year}");


        }
        static void getarray()
        {
            int[] array = new int[int.Parse(Console.ReadLine())];
            int temp;
            int max;
            int min;


            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"num {i+1} :");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length - 1; i++)
            {

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;



                    }


                }



            }
            max = array[array.Length - 1];
            min = array[0];
            Console.WriteLine("this is your araay");
            for (int i = 0; i < array.Length; i++)
            {

                Console.WriteLine(array[i]);

            }
            Console.WriteLine($"max is {max} and min is {min}");

        }

        static void GetArray(int num, int length)
        {
            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                numbers[i] = num * (i + 1);
            }
            Console.Write("[");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.Write(" ]");

        }

        static void Reverse(string word)
        {

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsLower(word[i]))
                {
                    char.ToUpper(word[i]);
                }
                else
                {
                    char.ToLower(word[i]);
                }
            }
            Console.WriteLine(word);
        }
        static void Main(string[] args)
        {

            getBirth();



        }
    }

}
