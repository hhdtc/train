using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;
        

        public int Red
        {
            get { 
                return red;
            }
            set {
                if (checkValid(value)) { 
                    red = value;
                }
            }
        }

        public int Green
        {
            get
            {
                return green;
            }
            set
            {
                if (checkValid(value))
                {
                    green = value;
                }
            }
        }

        public int Blue
        {
            get
            {
                return blue;
            }
            set
            {
                if (checkValid(value))
                {
                    blue = value;
                }
            }
        }

        public int Alpha
        {
            get
            {
                return alpha;
            }
            set
            {
                if (checkValid(value))
                {
                    alpha = value;
                }
            }
        }


        private bool checkValid(int c) {
            if (c >= 0 && c <= 255) {
                return true;
            }
            return false;
        }


        public Color(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }

        public Color(int red, int green, int blue, int alpha) {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public double getGrey() { 
            return ((double) Red + (double)Green + (double)Blue)/3;
        }
    }

    internal class Ball {
        public Color Color;
        public int Size = 0;
        private int Counter = 0;

        public Ball(Color color, int size) {
            this.Color = color;
            this.Size = size;
        }

        public void Pop() { 
            this.Size = 0;
        }

        public void Throw() {
            if (this.Size != 0){
                this.Counter += 1;
            }
        }

        public int ThrowCount() { 
            return Counter;
        }

    }
}
