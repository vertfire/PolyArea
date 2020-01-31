using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace PolyArea
{
    /*public class Point
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Point (float x, float y)
        {
            X = x;
            y = y;
        }
    }*/
    public enum PolygonType
    {
        Concave,
        Convex,
    }

    static class PolygonAnalyzer
    {
        internal static PolygonType Classify (Polygon polygon)
        {
            throw new NotImplementedException();
        }

        internal static Vector2[] GetSides(Polygon polygon)
        {
            Vector2[] Sides = new Vector2[polygon.Vertices.Length];
            int index = 0;
            foreach (var vertex in polygon.Vertices)
            {
                Vector2 vectorA = polygon.Vertices[index];
                Vector2 vectorB;
                if (index + 1 == polygon.Vertices.Length)
                {
                    //Loop to start
                    vectorB = polygon.Vertices[0];
                }
                else
                {
                    vectorB = polygon.Vertices[index + 1];
                }
                Sides[index] = vectorB - vectorA;
                index++;
            }
            return Sides;
        }
    }

    public class Polygon
    {
        readonly public Vector2[] Vertices;
        readonly public Vector2[] Sides;
        readonly public PolygonType Type;

        public Polygon (Vector2[] vertices)
        {
            if (vertices.Length < 2)
            {
                Console.WriteLine("A Polygon needs more than 2 vertices");
                throw new IndexOutOfRangeException();
            }
            Vertices = vertices;
            Sides = PolygonAnalyzer.GetSides(this);
            Type = PolygonAnalyzer.Classify(this);
        }

    }
}
