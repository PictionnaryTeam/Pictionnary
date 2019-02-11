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
    /// <summary>
    /// Génère un dessin en fonction des actions qui se produisent (souris cliquée, bougée, etc...)
    /// </summary>
    class DrawingGenerator
    {
        Drawing _drawing;
        bool _isMouseClicked;

        int _currentBrushSize;
        Color _currentBrushColor;

        public DrawingGenerator()
        {
            _isMouseClicked = false;
            _drawing = new Drawing();
        }

        public void SetBrushSize(int newSize)
        {
            _currentBrushSize = newSize;
        }

        public void SetBrushColor(Color newColor)
        {
            _currentBrushColor = newColor;
        }

        /// <summary>
        /// Informe le générateur que la souris a été cliquée
        /// </summary>
        public void MouseHasBeenClicked(Point mousePos)
        {
            _isMouseClicked = true;
            _drawing.AddLine(new Line());
            _drawing.Lines[_drawing.Lines.Count - 1].BrushSize = _currentBrushSize;
            _drawing.Lines[_drawing.Lines.Count - 1].LineColor = _currentBrushColor;
        }

        /// <summary>
        /// Informe le générateur que la souris a été relâchée
        /// </summary>
        public void MouseHasBeenReleased(Point mousePos)
        {
            _isMouseClicked = false;
        }

        public void MouseHasBeenMoved(Point mousePos)
        {
            if(_isMouseClicked)
            {
                _drawing.Lines[_drawing.Lines.Count - 1].AddPixel(new Pixel(mousePos.X, mousePos.Y));
            }
        }

        public Drawing CurrentDrawing
        {
            get
            {
                return _drawing;
            }
        }
    }
}
