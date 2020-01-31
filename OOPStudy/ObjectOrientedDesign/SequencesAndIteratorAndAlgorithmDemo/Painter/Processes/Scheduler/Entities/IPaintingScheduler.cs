using OOPStudy.SequencesAndIteratorAndAlgorithmDemo.Entities;
using OOPStudy.SequencesDemo;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPStudy.SequencesAndIteratorAndAlgorithmDemo
{
    interface IPaintingScheduler<TPainter> where TPainter : IPainter
    {
        IEnumerable<PaintingTask<TPainter>> Schedule(double sqMeters, IEnumerable<TPainter> painters);
    }
}
