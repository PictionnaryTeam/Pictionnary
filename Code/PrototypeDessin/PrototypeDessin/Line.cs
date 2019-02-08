using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PrototypeDessin
{
    class Line
    {
        public Line()
        {
            _pixels = new List<Pixel>();
        }

        public void AddPixel(Pixel p)
        {
            _pixels.Add(p);
        }

        public bool IsAnyPixelContainedIn(int xpos, int ypos, int radius)
        {
            throw new NotImplementedException();
        }

        public List<Pixel> Pixels
        {
            get
            {
                return _pixels;
            }
        }

        public Color LineColor
        {
            get
            {
                return _lineColor;
            }
            set
            {
                _lineColor = value;
            }
        }

        public int BrushSize
        {
            get
            {
                return _brushSize;
            }
            set
            {
                _brushSize = value;
            }
        }

        private List<Pixel> _pixels;
        private Color _lineColor;
        private int _brushSize;
    }
}
