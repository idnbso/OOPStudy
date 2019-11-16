using OOPStudy.SequencesAndIteratorAndAlgorithmDemo;
using OOPStudy.SequencesAndIteratorAndAlgorithmDemo.Processes;
using OOPStudy.SequencesDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPStudy.SequencesAndIteratorDemo
{
    static class CompositePainterFactories
    {
        public static IPainter CreateCheapestSelector(IEnumerable<IPainter> painters) =>
            new CompositePainter<IPainter>(painters,
                (sqMeters, sequence) => new Painters(sequence).GetAvailable().GetCheapestOne(sqMeters));

        public static IPainter CreateFastestSelector(IEnumerable<IPainter> painters) =>
            new CompositePainter<IPainter>(painters,
                (sqMeters, sequence) => new Painters(sequence).GetAvailable().GetFastestOne(sqMeters));

        public static IPainter CombineProportional(IEnumerable<ProportionalPainter> painters) =>
            new CombiningPainter<ProportionalPainter>(/* What to combine */ painters, /* How to combine */ new ProportionalPaintingScheduler());
    }
}
