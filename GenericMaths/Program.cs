using GenericMaths;
using System;
using System.Linq;

try
{
    var velocities = new Velocity[]
    {
        new Velocity(100_000_000, 0, 0),
        new Velocity(150_000_000, 0, 0)
    };

    Console.WriteLine(velocities.Sum());
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.GetType().Name}: {ex.Message}");
}