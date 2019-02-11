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
                foreach (Pixel currentPixel in currentLine.Pixels)
                {
                    paintEventArgs.Graphics.DrawEllipse(new Pen(currentLine.LineColor), currentPixel.X, currentPixel.Y, currentLine.BrushSize, currentLine.BrushSize);
                }

                /*for(int i = 0; i < lines.Count; ++i)
                    {

                    }*/
                }
            }
    }
}
