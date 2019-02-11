﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypeDessin
{
    public partial class DrawingCanvas : UserControl
    {
        DrawingGenerator _drawingGenerator;
        PanelRenderer _renderer;

        Timer _timer;

        public DrawingCanvas()
        {
            InitializeComponent();

            _drawingGenerator = new DrawingGenerator();

            _renderer = new PanelRenderer(pnl_canvas);

            _timer = new Timer();
            _timer.Start();

            _timer.Tick += new EventHandler(timertick);

            _timer.Interval = 100;

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void pnl_canvas_Paint(object sender, PaintEventArgs e)
        {
            _renderer.Render(_drawingGenerator.CurrentDrawing, e);
        }

        private void pnl_canvas_MouseDown(object sender, MouseEventArgs e)
        {
            _drawingGenerator.MouseHasBeenClicked(e.Location);
        }

        private void pnl_canvas_MouseUp(object sender, MouseEventArgs e)
        {
            _drawingGenerator.MouseHasBeenReleased(e.Location);


        }

        private void pnl_canvas_MouseMove(object sender, MouseEventArgs e)
        {
            _drawingGenerator.MouseHasBeenMoved(e.Location);
        }

        private void timertick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void btn_white_Click(object sender, EventArgs e)
        {

        }
    }
}
