using System;
using ArcadeMaker.Core.Models;
using MonoGame.Extended;
using Microsoft.Xna.Framework;
using ArcadeMaker.Core.Runtime;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ArcadeMaker.Engines.MonoGame.Core.Runtime;

sealed class GameObject : ArcadeMaker.Core.Runtime.Instance
{
    //private static int idCounter = 0;
    //public int Id { get; } = idCounter++;
    //public CollisionShape2D Shape { get; }

    public GameObject(List<ArcadeMaker.Core.Resources.Sprite> spritesList, ObjectModel model) : base(spritesList, model)
    {
        //Shape = new(new OrientedBoundingBox2D());
    }

    public static GameObject Ctor(List<ArcadeMaker.Core.Resources.Sprite> spritesList, ObjectModel model) => new(spritesList, model);

    public override bool WouldIntersectAt(double x, double y, double angle, Instance other)
    {
        if (other == this || Sprite is null || other.Sprite is null)
            return false;
        return GetCollisionShape(x, y, angle).Intersects(((GameObject)other).GetCollisionShape());
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private CollisionShape2D GetCollisionShape(double x, double y, double angle)
    {
        if (Sprite is null)
            return default;

        //Vector2 halfExtents = new((Sprite.Mask.Right - Sprite.Mask.Left) / 2f, (Sprite.Mask.Bottom - Sprite.Mask.Top) / 2f);
        //Vector2 center = new
        //(
        //    (float)x - Sprite.OriginX + halfExtents.X,
        //    (float)y - Sprite.OriginY + halfExtents.Y
        //);
        //new OrientedBoundingBox2D(,);
        //return new(OrientedBoundingBox2D.CreateFromRotation
        //(
        //    center,
        //    (float)ArcadeMaker.Core.Math.Formulas.DegreesToRadians(angle),
        //    halfExtents
        //));

        float xscale = (float)ImageXScale.Value!.Number, yscale = (float)ImageYScale.Value!.Number;
        Vector2 size = new(Sprite.Mask.Right + 1 - Sprite.Mask.Left, Sprite.Mask.Bottom + 1 - Sprite.Mask.Top);
        int originX = Sprite.OriginX, originY = Sprite.OriginY;
        if (xscale < 0)
        {
            xscale *= -1;
            originX = (int)size.X - originX - 1;
        }
        if (yscale < 0)
        {
            yscale *= -1;
            originY = (int)size.Y - originY - 1;
        }
        Vector2 position = new(
            (float)x - originX,
            (float)y - originY);
        float rotation = MathHelper.ToRadians((float)angle);
        Vector2 scale = new(xscale, yscale);

        // define single origin point (relative to the unscaled size)
        Vector2 origin = new(originX, originY);

        // find the vector pointing from the origin to the unscaled geometric center
        Vector2 localOffsetFromOriginToCenter = (size / 2f) - origin;

        // scale that offset vector
        Vector2 scaledOffset = localOffsetFromOriginToCenter * scale;

        // rotate that offset vector so it spins alongside the object
        Vector2 rotatedOffset = Vector2.Transform(scaledOffset, Matrix.CreateRotationZ(rotation));

        // calculate the final true world center
        // since 'position' is where the origin is, adding the rotated offset gives us the exact center
        Vector2 worldCenter = position + rotatedOffset;

        // calculate the remaining OBB constructor arguments
        Vector2 axisX = new((float)Math.Cos(rotation), (float)Math.Sin(rotation));
        Vector2 axisY = new(-(float)Math.Sin(rotation), (float)Math.Cos(rotation));
        Vector2 halfExtents = (size / 2f) * scale;

        return new(new OrientedBoundingBox2D(worldCenter, axisX, axisY, halfExtents));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private CollisionShape2D GetCollisionShape() => GetCollisionShape(X.Value!.Number, Y.Value!.Number, ImageAngle.Value!.Number);
}
