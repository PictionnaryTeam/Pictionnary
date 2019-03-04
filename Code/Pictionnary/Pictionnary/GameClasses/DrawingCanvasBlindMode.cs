using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingEditor
{
    class DrawingCanvasBlindMode : DrawingCanvasTemplate
    {
        public DrawingCanvasBlindMode() : base() { }

        protected override void MouseDisplaced(Point mousePos)
        {
            ConfirmMouseMovement(mousePos);
        }

        protected override void MousePressed(Point mousePos)
        {
            ConfirmMouseDown(mousePos);
        }

        protected override void MouseReleased(Point mousePos)
        {
            ConfirmMouseUp(mousePos);
        }

        protected override void TryToRefresh()
        {
        }
    }
}
