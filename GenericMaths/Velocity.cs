using System;
using System.Numerics;

namespace GenericMaths
{
    internal record struct Velocity (double X, double Y, double Z)
        : IMyAdditionOperators<Velocity, Velocity, Velocity>
    {
        private const double c = 299_792_458; // Speed of light

        //public static Velocity operator checked +(Velocity l, Velocity r)
        //{
        //    Console.WriteLine("checked");

        //    var res = new Velocity(l.X + r.X, l.Y + r.Y, l.Z + r.Z);

        //    if (res.X * res.X + res.Y * res.Y + res.Z * res.Z > c * c)
        //        throw new OverflowException("Speed of light exceeded.");

        //    return res;
        //}

        public static Velocity operator +(Velocity l, Velocity r)
        {
            Console.WriteLine("unchecked");

            return new Velocity(l.X + r.X, l.Y + r.Y, l.Z + r.Z);
        }
    }
}
