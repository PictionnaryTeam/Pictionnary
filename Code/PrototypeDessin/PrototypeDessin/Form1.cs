using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypeDessin
{
    public partial class Form1 : Form
    {
        PanelRenderer _renderer;
        DrawingCanvasTemplate _canvas;

        public Form1()
        {
            InitializeComponent();

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            _renderer = new PanelRenderer(panel1);
            timer1.Start();

            _canvas = new DrawingCanvasOneLine();
            _canvas.Location = new Point(10, 10);

            Controls.Add(_canvas);
        }

        /// <summary>
        /// source
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Drawing tmpDrawing = _canvas.GetDrawing();
           _renderer.Render(tmpDrawing, e);
        }
    }
}
