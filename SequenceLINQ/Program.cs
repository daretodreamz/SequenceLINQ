using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<ProportionalPainter> painters = new ProportionalPainter[10];
            IPainter painter0 = CompositePainterFactories.CreateCheapestSelector(painters);
            IPainter painter1 = CompositePainterFactories.CreateFastestSelector(painters);
            IPainter painter2 = CompositePainterFactories.CombineProportional(painters);
        }
    }
}
