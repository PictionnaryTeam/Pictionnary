using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingEditor
{
    [Serializable]
    public class Drawing
    {
        public Drawing()
        {
            _lines = new List<Line>();
        }

        public void TryToErase(int xpos, int ypos, int radius)
        {
            throw new NotImplementedException();
        }

        public void AddLine(Line newLine)
        {
            _lines.Add(newLine);
        }

        public List<Line> Lines
        {
            get
            {
                return _lines;
            }
            set
            {
                _lines = value;
            }
        }

        private List<Line> _lines;
    }
}
