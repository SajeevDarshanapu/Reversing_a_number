using System;
namespace Hey
{

    public class Hi
    {

        public static void Main(string[] args)
        {




            int num, rem, sum = 0;
            Console.WriteLine("Enter your number");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                rem = num % 10;
                sum = sum * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
    }
}