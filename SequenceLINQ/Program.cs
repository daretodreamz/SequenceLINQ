using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceLINQ
{
    class Program
    {
        ////////    private static IPainter FindCheapestPainter(double sqMeters, Painters painters) =>
        ////////        painters.GetAvailable().GetCheapestOne(sqMeters);
        ////////    {
        ////////        return
        ////////             painters
        ////////             .Where(painter => painter.IsAvailable)
        ////////             //.OrderBy(painter => painter.EstimateCompensation(sqMeters))
        ////////             //.FirstOrDefault();
        ////////             .WithMinimum(painter => painter.EstimateCompensation(sqMeters));
        ////////    }
        ////////private static IPainter FindFastestPainter(double sqMeters, Painters painters) =>
        ////////    painters.GetAvailable().GetFastestOne(sqMeters);
        ////////    {
        ////////        return
        ////////             painters
        ////////             .Where(painter => painter.IsAvailable)
        ////////             .WithMinimum(painter => painter.EstimateTimeToPaint(sqMeters));
        ////////    }


        static void Main(string[] args)
        {
            IEnumerable<ProportionalPainter> painters = new ProportionalPainter[10];
            IPainter painter0 = CompositePainterFactories.CreateCheapestSelector(painters);
            IPainter painter1 = CompositePainterFactories.CreateCheapestSelector(painters);
            IPainter painter2 = CompositePainterFactories.CreateGroup(painters);
        }
    }
}
