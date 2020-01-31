using OOPStudy.SequencesDemo;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPStudy.SequencesAndIteratorAndAlgorithmDemo.Entities
{
    class PaintingTask<TPainter> where TPainter : IPainter
    {
        public TPainter Painter { get; }
        public double SquareMeters { get; }

        public PaintingTask(TPainter painter, double sqMeters)
        {
            this.Painter = painter;
            this.SquareMeters = sqMeters;
        }
    }
}
