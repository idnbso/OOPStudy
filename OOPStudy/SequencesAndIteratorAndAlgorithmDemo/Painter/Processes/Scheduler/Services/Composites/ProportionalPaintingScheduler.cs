using OOPStudy.SequencesAndIteratorAndAlgorithmDemo.Entities;
using OOPStudy.SequencesAndIteratorDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPStudy.SequencesAndIteratorAndAlgorithmDemo.Processes
{
    class ProportionalPaintingScheduler : IPaintingScheduler<ProportionalPainter>
    {
        public IEnumerable<PaintingTask<ProportionalPainter>> Schedule(double sqMeters, IEnumerable<ProportionalPainter> painters)
        {
            IEnumerable<Tuple<ProportionalPainter, double>> velocities = painters
                .Select(p => Tuple.Create(p, sqMeters / p.EstimateTimeToPaint(sqMeters).TotalHours))
                .ToList();

            double totalVelocity = velocities.Sum(t => t.Item2);

            IEnumerable<PaintingTask<ProportionalPainter>> schedule = velocities
                .Select(t => new PaintingTask<ProportionalPainter>(
                        t.Item1,
                        sqMeters*t.Item2/totalVelocity
                    ))
                .ToList();

            return schedule;
        }
    }
}
