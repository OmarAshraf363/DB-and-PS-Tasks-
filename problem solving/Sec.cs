using System.Threading.Channels;

namespace Problem_Solving2
{
   
    internal class Program
    {
        static void Capind(string s)
        {
                Console.Write("[");
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    Console.Write($" {i} ");
                }

            }
                Console.Write("]");
        }
        static string[] parse(object[] arr)
        {
            string[] s = new string[arr.Length];
            for (int i = 0;i<arr.Length;i++)
            {
                if (arr[i] is int)
                {
                   s[i]= arr[i].ToString();
                    
                }
            }
           for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is string)
                {
                    s[i] = arr[i].ToString();
                }
            }
            return s ;
        }
       
        static void Highlow(string s)
        {
            char[] chars = s.ToCharArray();


            Console.WriteLine(chars.Max());
            Console.WriteLine(chars.Min());


        }
        static int mirorr(int x)
        {   
            string z = new string (x.ToString().ToCharArray().Reverse().ToArray());
           
            return int.Parse(z);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(mirorr(123));
        }
    }
}
