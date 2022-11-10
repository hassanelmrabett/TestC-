using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Models
{
    public class Shape
    {
        public string ID { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public int AmountSides { get; set; }
        public float[] Position { get; set; }
        public float Scale { get; set; }
        public float[] Rotation { get; set; }

    }
}
