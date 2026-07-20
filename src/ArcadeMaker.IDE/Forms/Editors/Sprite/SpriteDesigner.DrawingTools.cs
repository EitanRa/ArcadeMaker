using System;
using System.Collections.Generic;
using System.Text;
using DrawingOperation = System.Action<System.Drawing.Graphics>;

namespace ArcadeMaker.IDE;

partial class SpriteDesigner
{
    abstract class DrawingTool
    {
        public abstract string Name { get; }
        public abstract bool OnTheMove { get; }

        public DrawingTool()
        {

        }

        public abstract DrawingOperation Draw(Color col1, Color col2, Point p1, Point p2, FillTypes fillType, float thickness);

        protected static Point GetTopLeftCorner(Point p1, Point p2) => new(Math.Min(p2.X, p1.X), Math.Min(p2.Y, p1.Y));
        protected static Size GetShapeSize(Point p1, Point p2) => new(Math.Max(p2.X, p1.X) - Math.Min(p2.X, p1.X), Math.Max(p2.Y, p1.Y) - Math.Min(p2.Y, p1.Y));
    }

    class RectangleDrawer : DrawingTool
    {
        public override string Name => "Rectangle Drawer";
        public override bool OnTheMove => false;

        public override DrawingOperation Draw(Color col1, Color col2, Point p1, Point p2, FillTypes fillType, float thickness) => graphics =>
        {
            Point topLeft = GetTopLeftCorner(p1, p2);
            Size size = GetShapeSize(p1, p2);

            void DrawOutline()
            {
                using Pen pen = new(col1, thickness);
                graphics.DrawRectangle(pen, new Rectangle(topLeft, size));
            }

            if (fillType == FillTypes.Outline)
            {
                DrawOutline();
            }
            else if (fillType == FillTypes.Fill)
            {
                using Pen pen = new(col1);
                graphics.FillRectangle(pen.Brush, new Rectangle(topLeft, size));
            }
            else
            {
                using Pen pen = new(col2);
                graphics.FillRectangle(pen.Brush, new(topLeft.X + 1, topLeft.Y + 1, size.Width - 2, size.Height - 2));
                DrawOutline();
            }
        };
    }

    class EllipseDrawer : DrawingTool
    {
        public override string Name => "Ellipse Drawer";
        public override bool OnTheMove => false;

        public override DrawingOperation Draw(Color col1, Color col2, Point p1, Point p2, FillTypes fillType, float thickness) => graphics =>
        {
            Point topLeft = GetTopLeftCorner(p1, p2);
            Size size = GetShapeSize(p1, p2);

            void DrawOutline()
            {
                using Pen pen = new(col1, thickness);
                graphics.DrawEllipse(pen, new Rectangle(topLeft, size));
            }

            if (fillType == FillTypes.Outline)
            {
                DrawOutline();
            }
            else if (fillType == FillTypes.Fill)
            {
                using Pen pen = new(col1);
                graphics.FillEllipse(pen.Brush, new Rectangle(topLeft, size));
            }
            else
            {
                using Pen pen = new(col2);
                graphics.FillEllipse(pen.Brush, new(topLeft.X + 1, topLeft.Y + 1, size.Width - 2, size.Height - 2));
                DrawOutline();
            }
        };
    }

    class LineDrawer : DrawingTool
    {
        public override string Name => "Line Drawer";
        public override bool OnTheMove => false;

        public override DrawingOperation Draw(Color col1, Color col2, Point p1, Point p2, FillTypes fillType, float thickness) => graphics =>
        {
            using Pen pen = new(col1, thickness);
            graphics.DrawLine(pen, p1, p2);
        };
    }

    class PenTool : DrawingTool
    {
        public override string Name => "Pen";
        public override bool OnTheMove => true;

        public override DrawingOperation Draw(Color col1, Color col2, Point p1, Point p2, FillTypes fillType, float thickness) => graphics =>
        {
             using Pen pen = new(col1, thickness);
             graphics.FillRectangle(pen.Brush, new(p2, new(1, 1)));
        };
    }
}