using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variables
            string input = "";
            string message = "";
            int checksum = 0;
            int length = 0;
            //user input
            Console.WriteLine("What is your message?");
            input = Console.ReadLine();
            input = input.ToUpper();

            foreach (char a in input)
            {
                int encode = a;
                checksum += encode;
                encode -= 64;
                message += (encode.ToString()) + "-";
            }

            length = message.Length;
            length -= 1;
            message = message.Remove(length, 1);
            //output
            Console.WriteLine("Your encoded message is " + message);
            Console.WriteLine("Your checksum is " + checksum);
        }
    }
}
