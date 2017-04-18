﻿using System;

namespace BridgePatternDemo
{
    public class RedCircle : IDrawAPI
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing Circle[ color: red, radius: "
                              + radius + ", x: " + x + ", " + y + "]");
        }
    }
}