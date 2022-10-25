using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Line
    {
        public Point Start, End;

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }
    }
}
