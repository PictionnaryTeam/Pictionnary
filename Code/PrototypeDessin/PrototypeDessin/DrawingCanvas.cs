using System;
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

        public DrawingCanvas()
        {
            InitializeComponent();

            _drawingGenerator = new DrawingGenerator();

            _renderer = new PanelRenderer(pnl_canvas);
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
            Refresh();
        }

        private void pnl_canvas_MouseMove(object sender, MouseEventArgs e)
        {
            _drawingGenerator.MouseHasBeenMoved(e.Location);
            Refresh();
        }

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
    }
}
