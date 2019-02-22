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
        List<Point> points;

        bool isMousePressed;

        Stopwatch chrono;

        public DrawingCanvas()
        {
            InitializeComponent();

            DoubleBuffered = true;

            _pen = new Pen(Color.Black, 4);

            points = new List<Point>();

            isMousePressed = false;

            chrono = new Stopwatch();
            chrono.Start();

            points.Add(new Point(30, 30));
        }

        private void pnl_canvas_Paint(object sender, PaintEventArgs e)
        {
            if(points.Count > 1)
            {
                e.Graphics.DrawLines(_pen, points.ToArray());
            }
            

            //graph.Dispose();
        }

        private void pnl_canvas_MouseDown(object sender, MouseEventArgs e)
        {
            isMousePressed = true;
        }

        private void pnl_canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (chrono.ElapsedMilliseconds > 20)
            {
                if (isMousePressed)
                {
                    points.Add(e.Location);
                    Refresh();
                }

                chrono.Restart();
            }
        }

        private void pnl_canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if(points.Count > 0)
            {
            }
            isMousePressed = false;
        }
    }
}
