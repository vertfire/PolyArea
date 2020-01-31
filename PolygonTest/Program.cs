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
                    new Vector2(1,1),
                    new Vector2(1,2),
                    new Vector2(2,2),
                    new Vector2(2,1),

                }
                );
            Console.WriteLine("hello");
            foreach (var side in p.Sides)
            {
                Console.WriteLine(side);
            }
        }
    }
}
