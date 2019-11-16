using OOPStudy.BranchingDemo;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPStudy.SequencesDemo
{
    interface IPainter
    {
        bool IsAvailable { get; set; }
        decimal EstimateCompensation(double sqMeters);
        TimeSpan EstimateTimeToPaint(double sqMeters);
    }
}
