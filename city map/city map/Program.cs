using System;
using System.Net;

namespace city_map
{
    internal class Program
    {
        static Random random = new Random();

        static void GenerateRoad(bool[,] roads, int startX, int startY, int direction)
        {
            int width = roads.GetLength(0);
            int height = roads.GetLength(1);

            if (direction == 3)
            {
                for (int y = startY; y <= height - 1; y++)
                {
                    roads[startX, y] = true;
                }
            }
            else if (direction == 0)
            {
                for (int x = startX; x <= width - 1; x++)
                {
                    roads[x, startY] = true;
                }
            }
            else if (direction == 1)
            {
                for (int y = startY; y >= 0; y--)
                {
                    roads[startX, y] = true;
                }
            }
            else if (direction == 2)
            {
                for (int x = startX; x >= 0; x--)
                {
                    roads[x, startY] = true;
                }

            }
        }
        static void GenerateIntersection(bool[,] roads, int x, int y)
        {
            for (int i = 0; i < 4; i++)
            {
                if (random.Next(10) < 7)
                {
                    GenerateRoad(roads, x, y, i);
                }
            }
        }
        static void Main(string[] args)
        {
            bool[,] map = new bool[50, 20];
            int width = map.GetLength(0);
            int height = map.GetLength(1);

            int intersectionsAmount = random.Next(7, 15);
                for (int i = 0; i < intersectionsAmount; i++)
                {
                    GenerateIntersection(map, random.Next(width), random.Next(height));
                }

            for (int y = height - 1; y >= 0; y--)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(map[x, y] ? "#" : " ");
                }
                Console.WriteLine();
            }
        }
    }
}
