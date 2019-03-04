namespace DrawingEditor
{
    partial class DrawingCanvasTemplate
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
            this.btn_black = new System.Windows.Forms.Button();
            this.btn_blue = new System.Windows.Forms.Button();
            this.btn_red = new System.Windows.Forms.Button();
            this.btn_green = new System.Windows.Forms.Button();
            this.btn_yellow = new System.Windows.Forms.Button();
            this.btn_white = new System.Windows.Forms.Button();
            this.nud_brushSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_canvas = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nud_brushSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_black
            // 
            this.btn_black.Location = new System.Drawing.Point(4, 4);
            this.btn_black.Name = "btn_black";
            this.btn_black.Size = new System.Drawing.Size(75, 23);
            this.btn_black.TabIndex = 1;
            this.btn_black.Text = "Noir";
            this.btn_black.UseVisualStyleBackColor = true;
            this.btn_black.Click += new System.EventHandler(this.btn_black_Click);
            // 
            // btn_blue
            // 
            this.btn_blue.Location = new System.Drawing.Point(4, 34);
            this.btn_blue.Name = "btn_blue";
            this.btn_blue.Size = new System.Drawing.Size(75, 23);
            this.btn_blue.TabIndex = 2;
            this.btn_blue.Text = "Bleu";
            this.btn_blue.UseVisualStyleBackColor = true;
            this.btn_blue.Click += new System.EventHandler(this.btn_blue_Click);
            // 
            // btn_red
            // 
            this.btn_red.Location = new System.Drawing.Point(86, 3);
            this.btn_red.Name = "btn_red";
            this.btn_red.Size = new System.Drawing.Size(75, 23);
            this.btn_red.TabIndex = 3;
            this.btn_red.Text = "Rouge";
            this.btn_red.UseVisualStyleBackColor = true;
            this.btn_red.Click += new System.EventHandler(this.btn_red_Click);
            // 
            // btn_green
            // 
            this.btn_green.Location = new System.Drawing.Point(86, 33);
            this.btn_green.Name = "btn_green";
            this.btn_green.Size = new System.Drawing.Size(75, 23);
            this.btn_green.TabIndex = 4;
            this.btn_green.Text = "Vert";
            this.btn_green.UseVisualStyleBackColor = true;
            this.btn_green.Click += new System.EventHandler(this.btn_green_Click);
            // 
            // btn_yellow
            // 
            this.btn_yellow.Location = new System.Drawing.Point(168, 2);
            this.btn_yellow.Name = "btn_yellow";
            this.btn_yellow.Size = new System.Drawing.Size(75, 23);
            this.btn_yellow.TabIndex = 5;
            this.btn_yellow.Text = "Jaune";
            this.btn_yellow.UseVisualStyleBackColor = true;
            this.btn_yellow.Click += new System.EventHandler(this.btn_yellow_Click);
            // 
            // btn_white
            // 
            this.btn_white.Location = new System.Drawing.Point(168, 33);
            this.btn_white.Name = "btn_white";
            this.btn_white.Size = new System.Drawing.Size(110, 23);
            this.btn_white.TabIndex = 6;
            this.btn_white.Text = "Blanc (gomme)";
            this.btn_white.UseVisualStyleBackColor = true;
            this.btn_white.Click += new System.EventHandler(this.btn_white_Click);
            // 
            // nud_brushSize
            // 
            this.nud_brushSize.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nud_brushSize.Location = new System.Drawing.Point(335, 33);
            this.nud_brushSize.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_brushSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_brushSize.Name = "nud_brushSize";
            this.nud_brushSize.Size = new System.Drawing.Size(120, 20);
            this.nud_brushSize.TabIndex = 7;
            this.nud_brushSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nud_brushSize.ValueChanged += new System.EventHandler(this.nud_brushSize_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Taille de la brosse";
            // 
            // pnl_canvas
            // 
            this.pnl_canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_canvas.Location = new System.Drawing.Point(3, 67);
            this.pnl_canvas.Name = "pnl_canvas";
            this.pnl_canvas.Size = new System.Drawing.Size(466, 323);
            this.pnl_canvas.TabIndex = 0;
            this.pnl_canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_canvas_Paint);
            this.pnl_canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_canvas_MouseDown);
            this.pnl_canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_canvas_MouseMove);
            this.pnl_canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_canvas_MouseUp);
            // 
            // DrawingCanvasTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_brushSize);
            this.Controls.Add(this.btn_white);
            this.Controls.Add(this.btn_yellow);
            this.Controls.Add(this.btn_green);
            this.Controls.Add(this.btn_red);
            this.Controls.Add(this.btn_blue);
            this.Controls.Add(this.btn_black);
            this.Controls.Add(this.pnl_canvas);
            this.DoubleBuffered = true;
            this.Name = "DrawingCanvasTemplate";
            this.Size = new System.Drawing.Size(472, 393);
            ((System.ComponentModel.ISupportInitialize)(this.nud_brushSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_black;
        private System.Windows.Forms.Button btn_blue;
        private System.Windows.Forms.Button btn_red;
        private System.Windows.Forms.Button btn_green;
        private System.Windows.Forms.Button btn_yellow;
        private System.Windows.Forms.Button btn_white;
        private System.Windows.Forms.NumericUpDown nud_brushSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_canvas;
    }
}
