using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace PrototypeDessin
{
    public abstract partial class DrawingCanvasTemplate : UserControl
    {
        // Temps entre chaque rafraichissement du panel
        protected const int TIME_BETWEEN_PANEL_REFRESHES = 10;

        // Temps minimal entre l'ajout de 2 pixels au dessin
        protected const int TIME_BETWEEN_PIXEL_ADDITION = 0;

        protected DrawingGenerator _drawingGenerator;
        protected PanelRenderer _renderer;

        protected System.Windows.Forms.Timer _panelRefreshTimer;
        protected Stopwatch _pixelAddTimer;

        public DrawingCanvasTemplate()
        {
            InitializeComponent();

            _drawingGenerator = new DrawingGenerator();

            _renderer = new PanelRenderer(pnl_canvas);

            _panelRefreshTimer = new System.Windows.Forms.Timer();
            _panelRefreshTimer.Interval = TIME_BETWEEN_PANEL_REFRESHES;
            _panelRefreshTimer.Tick += new EventHandler(TimerRefreshTick);
            _panelRefreshTimer.Start();

            _pixelAddTimer = new Stopwatch();
            _pixelAddTimer.Start();

            _drawingGenerator.SetBrushColor(Color.Black);
            _drawingGenerator.SetBrushSize(4);

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void pnl_canvas_Paint(object sender, PaintEventArgs e)
        {
            _renderer.Render(_drawingGenerator.CurrentDrawing, e);
        }

        private void pnl_canvas_MouseDown(object sender, MouseEventArgs e)
        {
            MousePressed(e.Location);
        }

        protected void ConfirmMouseDown(Point mousePos)
        {
            _drawingGenerator.MouseHasBeenClicked(mousePos);
        }

        protected abstract void MousePressed(Point mousePos);

        private void pnl_canvas_MouseUp(object sender, MouseEventArgs e)
        {
            MouseReleased(e.Location);
        }

        protected void ConfirmMouseUp(Point mousePos)
        {
            _drawingGenerator.MouseHasBeenReleased(mousePos);
        }

        protected abstract void MouseReleased(Point mousePos);

        private void pnl_canvas_MouseMove(object sender, MouseEventArgs e)
        {
            MouseDisplaced(e.Location);
        }

        protected void ConfirmMouseMovement(Point mousePos)
        {
            if (_pixelAddTimer.ElapsedMilliseconds >= TIME_BETWEEN_PIXEL_ADDITION)
            {
                _drawingGenerator.MouseHasBeenMoved(mousePos);
                _pixelAddTimer.Restart();
            }
        }

        protected abstract void MouseDisplaced(Point mousePos);

        private void TimerRefreshTick(object sender, EventArgs e)
        {
            TryToRefresh();
        }

        protected void ConfirmRefresh()
        {
            Invalidate();
        }

        protected abstract void TryToRefresh();

        private void btn_white_Click(object sender, EventArgs e)
        {
            _drawingGenerator.SetBrushColor(Color.White);
        }

        private void btn_black_Click(object sender, EventArgs e)
        {
            _drawingGenerator.SetBrushColor(Color.Black);
        }

        private void btn_blue_Click(object sender, EventArgs e)
        {
            _drawingGenerator.SetBrushColor(Color.Blue);
        }

        private void btn_green_Click(object sender, EventArgs e)
        {
            _drawingGenerator.SetBrushColor(Color.Green);
        }

        private void btn_red_Click(object sender, EventArgs e)
        {
            _drawingGenerator.SetBrushColor(Color.Red);
        }

        private void btn_yellow_Click(object sender, EventArgs e)
        {
            _drawingGenerator.SetBrushColor(Color.Yellow);
        }

        private void nud_brushSize_ValueChanged(object sender, EventArgs e)
        {
            _drawingGenerator.SetBrushSize((int)nud_brushSize.Value);
        }


        public Drawing GetDrawing()
        {
            return _drawingGenerator.Drawing;
        }
    }
}
