using System;
using System.Collections.Generic;
using System.Text;

namespace ArcadeMaker.Core.Math.Shapes;

public abstract class Shape
{
    public double X { get; set; }
    public double Y { get; set; }
    public int OriginX { get; set; }
    public int OriginY { get; set; }

    /// <summary>
    /// The angle in degrees.
    /// </summary>
    public double Angle { get; set; }
}