using System;
using System.Collections.Generic;
using System.Text;

namespace BoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get => this.length;
            private set 
            {
                this.IsInvalidSide(value, nameof(Length));
                this.length = value;
            }
        }
        public double Width
        {
            get => this.width;
            private set
            {
                this.IsInvalidSide(value, nameof(Width));
                this.width = value;
            }
        }
        public double Height
        {
            get => this.height;
            private set
            {
                this.IsInvalidSide(value, nameof(Height));
                this.height = value;
            }
        }

        public double Volume()
        {
            return this.Width * this.Length * this.Height;
        }

        public double LateralSurfaceArea()
        {
            return (2 * this.Length * this.Height)
                + (2 * this.Width * this.Height);
        }

        public double SurfaceArea()
        {
            return (2 * this.Length * this.Width)
                + (2 * this.Length * this.Height)
                + (2 * this.Width * this.Height);
        }

        private void IsInvalidSide(double value, string side)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{side} cannot be zero or negative.");
            }
            
        }

        

    }
}
