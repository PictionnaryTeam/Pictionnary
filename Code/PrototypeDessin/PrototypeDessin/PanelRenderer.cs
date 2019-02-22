using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypeDessin
{
    public class PanelRenderer
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
                if(currentLine.Pixels.Count > 1)
                {
                    List<PointF> points = new List<PointF>();
                    foreach (Pixel p in currentLine.Pixels) points.Add(new PointF(p.X, p.Y));

                    paintEventArgs.Graphics.DrawLines(new Pen(currentLine.LineColor, currentLine.BrushSize), points.ToArray());
                }
                else if(currentLine.Pixels.Count > 0)
                {
                    paintEventArgs.Graphics.FillEllipse(new SolidBrush(currentLine.LineColor), new Rectangle(currentLine.Pixels[0].X - currentLine.BrushSize / 2, currentLine.Pixels[0].Y - currentLine.BrushSize / 2, currentLine.BrushSize, currentLine.BrushSize));
                }
            }
        }
    }
}
