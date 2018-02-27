using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieNS
{
    /// <summary>
    /// Die implementation
    /// </summary>
    public class Die
    {
        /// <summary>
        /// Random numer generator
        /// </summary>
        private Random r;

        /// <summary>
        /// Tossed number
        /// </summary>
        public int CurrentNumber
        {
            private set;
            get;
        }

        /// <summary>
        /// Ctor
        /// </summary>
        public Die()
        {
            this.r = new Random();
            // Generates random number from 1 to 6
            this.CurrentNumber = this.r.Next(1, 7);
        }

        /// <summary>
        /// Rolling a die
        /// </summary>
        public void Roll()
        {
            this.CurrentNumber = this.r.Next(1, 7);
        }
    }
}
