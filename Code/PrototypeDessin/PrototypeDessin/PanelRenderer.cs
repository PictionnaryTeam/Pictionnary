using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypeDessin
{
    class PanelRenderer
    {
        Panel panelRendered;

        public PanelRenderer(Panel panelRendered)
        {
            this.panelRendered = panelRendered;
        }

        public void Render(Drawing drawingToRender, PaintEventArgs paintEventArgs)
        {
            List<Line> lines = drawingToRender.Lines;
            foreach (Line currentLine in lines)
            {
                /*foreach (Pixel currentPixel in currentLine.Pixels)
                {
                    paintEventArgs.Graphics.DrawEllipse(new Pen(currentLine.LineColor), currentPixel.X, currentPixel.Y, currentLine.BrushSize, currentLine.BrushSize);
                }*/

                /*for(int i = 0; i < lines.Count; ++i)
                    {

                    }*/

                //int tempX = 0;
                //int tempY = 0;
                //bool isFirstLine = true;

                //foreach (Pixel currentPixel in currentLine.Pixels)
                //{
                //    if (isFirstLine)
                //    {
                //        tempX = currentPixel.X;
                //        tempY = currentPixel.Y;
                //        isFirstLine = false;
                //    }

                //    paintEventArgs.Graphics.DrawLine(new Pen(currentLine.LineColor, currentLine.BrushSize), tempX, tempY, currentPixel.X, currentPixel.Y);
                //    tempX = currentPixel.X;
                //    tempY = currentPixel.Y;
                //}

                List<PointF> points = new List<PointF>();
                foreach (Pixel p in currentLine.Pixels) points.Add(new PointF(p.X, p.Y));

                paintEventArgs.Graphics.DrawLines(new Pen(currentLine.LineColor, currentLine.BrushSize), points.ToArray());
            }
        }
    }
}
