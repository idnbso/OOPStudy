using OOPStudy.BranchingDemo;
using OOPStudy.SequencesAndIteratorDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPStudy.SequencesDemo
{
    class PaintersDemo
    {
        #region Part One - Sequences
        private static IPainter FindCheapestPainter(double sqMeters, IEnumerable<IPainter> painters)
        {
            return painters
                .Where(p => p.IsAvailable)
                .WithMinimum(p => p.EstimateCompensation(sqMeters));
        }

        public static IPainter FindFastestPainter(double sqMeters, IEnumerable<IPainter> painters)
        {
            return painters
                .Where(p => p.IsAvailable)
                .WithMinimum(p => p.EstimateTimeToPaint(sqMeters));
        }

        #endregion

        #region Part Two - Iterator

        private static IPainter FindCheapestPainterFromPainters(double sqMeters, Painters painters) =>
            painters.GetAvailable().GetCheapestOne(sqMeters);

        private static IPainter FindFastestPainterFromPainters(double sqMeters, Painters painters) =>
            painters.GetAvailable().GetFastestOne(sqMeters);

        #endregion

        #region Part Three - Algorithms
        
        /// <summary>
        /// Example of an alogirthm implementation anti-pattern
        ///
        /// Algorithm outline
        /// 1. Each worker paints part of the wall
        /// 2. Calculate time for entire work
        /// 3. Let each painter work that long
        /// 4. Thier total output will be equal to sqMeters
        /// 
        /// Assumption: Painters work at constant speed.
        /// </summary>
        /// <param name="sqMeters"></param>
        /// <param name="painters"></param>
        private static IPainter WorkTogether(double sqMeters, IEnumerable<IPainter> painters)
        {
            TimeSpan totalWorkTime = TimeSpan.FromHours(
                1 /
                painters
                    .Where(p => p.IsAvailable)
                    .Select(p => 1 / p.EstimateTimeToPaint(sqMeters).TotalHours)
                    .Sum());

            decimal totalWorkCost = painters
                .Where(p => p.IsAvailable)
                .Select(p => p.EstimateCompensation(sqMeters) /
                            (decimal)p.EstimateTimeToPaint(sqMeters).TotalHours * (decimal)totalWorkTime.TotalHours)
                .Sum();

            return new ProportionalPainter()
            {
                TimePerSqMeter = TimeSpan.FromHours(totalWorkTime.TotalHours / sqMeters),
                DollarsPerHour = totalWorkCost / (decimal)totalWorkTime.TotalHours
            };
        }

        #endregion

        static void Demo(string[] args)
        {
            double sqMeters = 100d;
            IEnumerable<ProportionalPainter> painters = new ProportionalPainter[10];

            IPainter cheapestPainter = CompositePainterFactories.CreateCheapestSelector(painters);
            Console.WriteLine(cheapestPainter.EstimateCompensation(sqMeters));

            IPainter painter = CompositePainterFactories.CombineProportional(painters);
        }
    }
}
