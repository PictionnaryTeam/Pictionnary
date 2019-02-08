﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDessin
{
    class Pixel
    {
        public Pixel(int x = 0, int y = 0)
        {
            _x = x;
            _y = y;
        }

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        private int _x;
        private int _y;
    }
}
