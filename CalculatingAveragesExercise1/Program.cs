using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAveragesExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOne, numTwo, numThree, numFour, numFive, numSix, numSeven, numEight, numNine, numTen;
            double sumOfNumbers;
            double averageNumbers;


            Console.WriteLine($"Please enter your first Number. ");
            numOne = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Please enter your Second Number. ");
            numTwo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Please enter your Third Number. ");
            numThree = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Please enter your Fourth Number. ");
            numFour = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Please enter your Fifth Number. ");
            numFive = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Please enter your Sixth Number. ");
            numSix = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Please enter your Seventh Number. ");
            numSeven = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Please enter your Eighth Number. ");
            numEight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Please enter your Ninth Number. ");
            numNine = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Please enter your Tenth Number. ");
            numTen = Convert.ToDouble(Console.ReadLine());

            sumOfNumbers = numOne + numTwo + numThree + numFour + numFive + numSix + numSeven + numEight + numNine + numTen;

            averageNumbers = sumOfNumbers / 10;

            Console.WriteLine($"The Sum of your numbers is : {sumOfNumbers}. ");

            Console.WriteLine($"The Average of your numbers is : {averageNumbers}. ");
        }


    }
}
