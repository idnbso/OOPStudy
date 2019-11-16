using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPStudy.SequencesDemo
{
    internal class Painters
    {
        private IEnumerable<IPainter> ContainedPainters { get; }

        public Painters(IEnumerable<IPainter> painters)
        {
            this.ContainedPainters = painters;
        }

        /// <summary>
        /// Get all available painters.
        /// 
        /// Mathematcally speaking, GetAvailable() method is closed under the set of all Painters objects...
        /// It is mapping one Painters object into another Painters object.
        /// This also encourages method chaining for easier consuming of the Painters object type.
        /// </summary>
        /// <returns>All available Painters</returns>
        public Painters GetAvailable()
        {
            if (this.ContainedPainters.All(p => p.IsAvailable))
            {
                return this;
            }

            return new Painters(this.ContainedPainters.Where(cp => cp.IsAvailable));
        }

        public IPainter GetCheapestOne(double sqMeters) => this.ContainedPainters.WithMinimum(p => p.EstimateCompensation(sqMeters));

        public IPainter GetFastestOne(double sqMeters) => this.ContainedPainters.WithMinimum(p => p.EstimateTimeToPaint(sqMeters));
    }
}