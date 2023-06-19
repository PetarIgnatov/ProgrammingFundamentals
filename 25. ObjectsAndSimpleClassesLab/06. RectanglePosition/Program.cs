﻿using System;
using System.Linq;

namespace _06._RectanglePosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstRectArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondRectArgs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Rectangle firstRect = new Rectangle
            {
                Left = firstRectArgs[0],
                Top = firstRectArgs[1],
                Width = firstRectArgs[2],
                Height = firstRectArgs[3]

            };
            Rectangle secondRect = new Rectangle
            {
                Left = secondRectArgs[0],
                Top = secondRectArgs[1],
                Width = secondRectArgs[2],
                Height = secondRectArgs[3]

            };

            if (firstRect.IsInside(secondRect))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        class Rectangle
        {
            public int Top { get; set; }
            public int Left { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            public int Botom
            {
                get
                {
                    return Top + Height;
                }
            }
            public int Right
            {
                get
                {
                    return Left + Width;
                }
            }

            public bool IsInside(Rectangle other)
            {
                return Top >= other.Top && Left >= other.Left && Botom <= other.Botom
                    && Right <= other.Right;
            }
        }
    }
}