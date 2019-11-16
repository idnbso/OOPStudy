using OOPStudy.BranchingDemo;
using OOPStudy.SequencesDemo;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPStudy.SequencesAndIteratorDemo
{
    /// <summary>
    /// A proportional painter is working at constant speed.
    /// </summary>
    class ProportionalPainter : IPainter
    {
        public TimeSpan TimePerSqMeter { get; set; }
        public decimal DollarsPerHour { get; set; }

        public bool IsAvailable { get { return true; } set { IsAvailable = value; } }

        public TimeSpan EstimateTimeToPaint(double sqMeters) => TimeSpan.FromHours(this.TimePerSqMeter.TotalHours * sqMeters);

        public decimal EstimateCompensation(double sqMeters) => (decimal)this.EstimateTimeToPaint(sqMeters).TotalHours * this.DollarsPerHour;
    }
}
