using OOPStudy.SequencesDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPStudy.SequencesAndIteratorDemo
{
    class CompositePainter<TPainter> : IPainter
        where TPainter : IPainter
    {
        protected IEnumerable<TPainter> Painters { get; set; }

        protected Func<double, IEnumerable<TPainter>, IPainter> Reduce { get; set; }

        public bool IsAvailable { get => this.Painters.Any(p => p.IsAvailable); set { this.IsAvailable = value; } }
        
        public CompositePainter(IEnumerable<TPainter> painters,
                                Func<double, IEnumerable<TPainter>, IPainter> reduce) : this(painters)
        {            
            this.Reduce = reduce;
        }

        public CompositePainter(IEnumerable<TPainter> painters)
        {
            this.Painters = painters;
        }

        public decimal EstimateCompensation(double sqMeters) => this.Reduce(sqMeters, this.Painters).EstimateCompensation(sqMeters);

        public TimeSpan EstimateTimeToPaint(double sqMeters) => this.Reduce(sqMeters, this.Painters).EstimateTimeToPaint(sqMeters);
    }
}
