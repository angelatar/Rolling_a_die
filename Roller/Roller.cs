using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollerNS
{
    /// <summary>
    /// Roller implementation
    /// </summary>
    public class Roller
    {
        /// <summary>
        /// Delegate
        /// </summary>
        /// <param name="index"></param>
        public delegate void RollingResults(int index);

        /// <summary>
        /// Event when die shows two sixes in a row
        /// </summary>
        public event RollingResults TwoSixesInARow;

        /// <summary>
        /// Event when sum of 5 tosses is greater then or equal to 20
        /// </summary>
        public event RollingResults SumOfFiveTosses;

        /// <summary>
        /// Results of tosses
        /// </summary>
        public List<int> Results { private set; get; }

        /// <summary>
        /// CTor
        /// </summary>
        public Roller()
        {
            this.Results = new List<int>();
        }

        /// <summary>
        /// Add elemnts in Results
        /// </summary>
        /// <param name="n"></param>
        public void CollectResults(int n)
        {
            this.Results.Add(n);
        }

        /// <summary>
        /// Print Results
        /// </summary>
        public void PrintResults()
        {
            for (int i = 0; i < this.Results.Count; i++)
            {
                Console.WriteLine(i + " - " + this.Results[i] + "\t");
            }
        }

        /// <summary>
        /// Public tester
        /// </summary>
        public void Test()
        {
            TestSixes();
            TestSum();
        }

        /// <summary>
        /// Test if die shows two sixes in a row
        /// </summary>
        private void TestSixes()
        {
            for (int i = 0; i < this.Results.Count - 1; i++)
            {
                if (this.Results[i] == 6 && this.Results[i + 1] == this.Results[i])
                    this.TwoSixesInARow(i);
            }
        }

        /// <summary>
        /// Test if sum of 5 tosses is greater then or equal to 20
        /// </summary>
        private void TestSum()
        {
            for (int i = 0; i < this.Results.Count - 5; i += 5)
            {
                int sum = 0;
                for (int j = i; j < 5 + i; j++)
                {
                    sum += this.Results[j];
                }
                if (sum >= 20)
                    this.SumOfFiveTosses(i);
            }
        }

    }
}
