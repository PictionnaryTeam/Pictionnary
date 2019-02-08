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
        List<Line> drawingToRender;

        public PanelRenderer(Panel panelRendered, List<Line> drawingToRender)
        {
            this.panelRendered = panelRendered;
            this.drawingToRender = drawingToRender;
        }

        public void Render()
        {
            foreach (Line currentLine in drawingToRender)
            {
                foreach (Pixel currentPixel in currentLine.Pixels)
                {
                    panelRendered.CreateGraphics().DrawEllipse(new Pen(currentLine.LineColor), currentPixel.X, currentPixel.Y, currentLine.BrushSize, currentLine.BrushSize);
                }
            }
        }
    }
}
