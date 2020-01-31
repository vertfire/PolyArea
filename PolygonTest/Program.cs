using System;
using System.Numerics;
using PolyArea;

namespace PolygonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Polygon p = new Polygon(
                new Vector2[]
                {
                    new Vector2(0,0),
                    new Vector2(0,1),
                    new Vector2(1,1),
                    new Vector2(1,0),

                }
                );
            Console.WriteLine(p.Sides);
        }
    }
}
