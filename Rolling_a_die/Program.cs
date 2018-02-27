using DieNS;
using RollerNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rolling_a_die
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances
            Die die = new Die();
            Roller roller = new Roller();

            // Add menthods to events
            roller.TwoSixesInARow += TwoSixes;
            roller.SumOfFiveTosses += FiveTosses;

            // Rolling a die 50 times
            for (int i = 0; i < 50; i++)
            {
                die.Roll();
                roller.CollectResults(die.CurrentNumber);
            }

            //Test results
            roller.Test();

            // Print Results
            roller.PrintResults();
        }

        /// <summary>
        /// Method for TwoSixesInARow event
        /// </summary>
        /// <param name="index"></param>
        static void TwoSixes(int index)
        {
            Console.WriteLine("Two sixes in a row(inrdex : {0})!", index);
        }

        /// <summary>
        /// Method for SumOfFiveTosses event
        /// </summary>
        /// <param name="index"></param>
        static void FiveTosses(int index)
        {
            Console.WriteLine("Sum of last 5 tosses is greater then or equal to 20(index : {0})!", index);
        }

    }
}

