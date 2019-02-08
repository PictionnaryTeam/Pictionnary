using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DessinTest
{
    public partial class DrawingCanvas : UserControl
    {
        Pen _pen;
        List<List<Point>> points;

        int activeListIndex;

        bool isMousePressed;

        Stopwatch chrono;

        public DrawingCanvas()
        {
            InitializeComponent();

            _pen = new Pen(Color.Black, 2);

            points = new List<List<Point>>();
            points.Add(new List<Point>());

            isMousePressed = false;

            chrono = new Stopwatch();
            chrono.Start();
        }

        private void pnl_canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics graph = e.Graphics;

            if(points.Count > 1)
            {
                foreach(List<Point> lines in points)
                {
                    //graph.DrawLine(_pen, points[points.Count - 1], points[points.Count - 2]);
                    graph.DrawLines(_pen, lines.ToArray());
                }
            }
            

            graph.Dispose();
        }

        private void pnl_canvas_MouseDown(object sender, MouseEventArgs e)
        {
            isMousePressed = true;
            activeListIndex = points.IndexOf(points[points.Count - 1]);
        }

        private void pnl_canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (chrono.ElapsedMilliseconds > 20)
            {
                if (isMousePressed)
                {
                    points[activeListIndex].Add(e.Location);
                    Refresh();
                }

                chrono.Restart();
            }
        }

        private void pnl_canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if(points.Count > 0)
            {
                points.Remove(points.Last());
            }
            isMousePressed = false;


            points.Add(new List<Point>());
        }
    }
}
