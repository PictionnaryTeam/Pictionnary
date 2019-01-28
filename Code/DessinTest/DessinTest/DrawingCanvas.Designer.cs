namespace DessinTest
{
    partial class DrawingCanvas
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_canvas = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl_canvas
            // 
            this.pnl_canvas.Location = new System.Drawing.Point(16, 19);
            this.pnl_canvas.Name = "pnl_canvas";
            this.pnl_canvas.Size = new System.Drawing.Size(642, 389);
            this.pnl_canvas.TabIndex = 0;
            this.pnl_canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_canvas_Paint);
            this.pnl_canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_canvas_MouseDown);
            this.pnl_canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_canvas_MouseMove);
            this.pnl_canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_canvas_MouseUp);
            // 
            // DrawingCanvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_canvas);
            this.DoubleBuffered = true;
            this.Name = "DrawingCanvas";
            this.Size = new System.Drawing.Size(723, 444);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_canvas;
    }
}
