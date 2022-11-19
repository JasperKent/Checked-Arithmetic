using GenericMaths;
using System;

try
{
    checked
    {
        var v1 = new Velocity(200_000_000, 0, 0);
        var v2 = new Velocity(150_000_000, 0, 0);

        Console.WriteLine(v1 + v2);
    }

}
catch (Exception ex)
{
    Console.WriteLine($"{ex.GetType().Name}: {ex.Message}");
}