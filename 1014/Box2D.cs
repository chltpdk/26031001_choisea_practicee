using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1014
{
    internal class Box2D
    {
        private int width;
        public int height;
        public int Width
        {
            set
            {
                if (value < 0)
                    return;
                Width = value; // set, get에서 사용하는 변수 value
            }
            get
            {
                return Width;
            }
        }
        public int Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                    return;
                Width = value;
            }
        }
    }

    class UseBox
    {
        public void UsigBox()
        {
            Box2D t = new Box2D();

        }
    }
        
}
