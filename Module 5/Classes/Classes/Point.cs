#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Classes
{
    class Point
    {
        // Variables
        private int _x;
        private int _y;
        private static int objectCount;

        // Default Constructor
        public Point()
        {
            Console.WriteLine("Default Constructor called");
            objectCount++;
        }

        // Non Default Constructor
        public Point(int x, int y)
        {
            this._x = x;
            this._y = y;
            objectCount++;
        }

        // Method PrintCoords
        public void PrintCoords()
        {
            Console.WriteLine("The point coordenates are x:{0}, y:{1}", this._x, this._y);
        }

        // Method ObjectCount
        public static int ObjectCount()
        {
            return objectCount;
        }
    }
}
