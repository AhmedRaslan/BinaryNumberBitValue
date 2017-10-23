using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNumberBitValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,bit;
            Restart : Console.Write("Enter a number : ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("--------------------");
                Console.Write("Negative numbers aren't allowed, until now :)");
                Console.ReadKey();
                Console.Clear();
                goto Restart;
            }

            // This converts the number into its binary representation and stores it in the variable "binary"
            string binary = Convert.ToString(num, 2);

            Console.WriteLine("--------------------");
            Console.WriteLine("Number " + num + " binary representation is \" " + binary + " \"\n");
            Console.Write("Now enter the order of bit that you want to know its value : ");
            bit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--------------------");
            if (bit > binary.Length)
            {
                Console.Write("The number you chose consists of " + binary.Length + " bits only, so the value of the bit you chose is definitely 0");
            }
            else
            {
                Console.Write("The value of the bit you chose is " + binary[bit - 1]);
            }
            Console.ReadKey();
        }
    }
}
