using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingEditor
{
    class DrawingCanvasOneLine : DrawingCanvasTemplate
    {
        private bool _hasMouseAlreadyBeenPressed;

        public DrawingCanvasOneLine() : base()
        {
            _hasMouseAlreadyBeenPressed = false;
        }

        protected override void MouseDisplaced(Point mousePos)
        {
            ConfirmMouseMovement(mousePos);
        }

        override protected void MousePressed(Point mousePos)
        {
            if(!_hasMouseAlreadyBeenPressed)
            {
                ConfirmMouseDown(mousePos);
                _hasMouseAlreadyBeenPressed = true;
            }
        }

        protected override void MouseReleased(Point mousePos)
        {
            
        }

        protected override void TryToRefresh()
        {
            ConfirmRefresh();
        }
    }
}
