using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class ShapesDto
    {
        public CircleDto Circle { get; set; }
        public IList<RectangleDto> Rectangle  { get; set; }
        public TriangleDto Triangle { get; set; }
    }
}
