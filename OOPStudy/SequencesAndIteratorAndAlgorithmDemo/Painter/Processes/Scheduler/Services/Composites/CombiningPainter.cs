using OOPStudy.SequencesAndIteratorDemo;
using OOPStudy.SequencesDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPStudy.SequencesAndIteratorAndAlgorithmDemo
{
    class CombiningPainter<TPainter> : CompositePainter<TPainter>
        where TPainter : IPainter
    {
        private IPaintingScheduler<TPainter> Scheduler { get; }

        public CombiningPainter(IEnumerable<TPainter> painters, IPaintingScheduler<TPainter> scheduler)
            : base(painters)
        {
            base.Reduce = this.Combine;
            this.Scheduler = scheduler;
        }

        private IPainter Combine(double sqMeters, IEnumerable<TPainter> painters)
        {
            var availablePainters = painters.Where(painter => painter.IsAvailable);

            var schedule = this.Scheduler.Schedule(sqMeters, availablePainters);

            var totalWorkTime = schedule.Max(task => task.Painter.EstimateTimeToPaint(task.SquareMeters));

            var totalWorkCost = schedule.Sum(task => task.Painter.EstimateCompensation(task.SquareMeters));

            return new ProportionalPainter()
            {
                TimePerSqMeter = TimeSpan.FromHours(totalWorkTime.TotalHours / sqMeters),
                DollarsPerHour = totalWorkCost / (decimal)totalWorkTime.TotalHours
            };
        }
    }
}
