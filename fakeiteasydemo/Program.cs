using System;

namespace fakeiteasydemo
{
	class Program
	{
		static void Main(string[] args)
		{
            int year, denominator;
            double princamt, rate;
            Console.Write("Enter The Loan Amount : ");
            princamt = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter The Number of Years : ");
            year = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the Rate Of Interest : ");
            rate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Denominator value : ");
            denominator = Convert.ToInt32(Console.ReadLine());

            SimpleInterest interestCalc = new SimpleInterest();
            Console.WriteLine("Total Amount : {0}", interestCalc.calculateInterest(princamt, year, rate, denominator));
            Console.ReadLine();
        }
	}
}
