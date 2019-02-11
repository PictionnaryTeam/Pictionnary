namespace Pictionnary.Forms
{
    partial class RoundEnd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFirstPlayerName = new System.Windows.Forms.Label();
            this.lblSecondPlayerName = new System.Windows.Forms.Label();
            this.lblThirdPlayerName = new System.Windows.Forms.Label();
            this.lblFirstPlayerPoints = new System.Windows.Forms.Label();
            this.lblSecondPlayerPoints = new System.Windows.Forms.Label();
            this.lblThirdPlayerPoints = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(153, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Fin de la manche :";
            // 
            // lblFirstPlayerName
            // 
            this.lblFirstPlayerName.AutoSize = true;
            this.lblFirstPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstPlayerName.Location = new System.Drawing.Point(54, 94);
            this.lblFirstPlayerName.Name = "lblFirstPlayerName";
            this.lblFirstPlayerName.Size = new System.Drawing.Size(171, 25);
            this.lblFirstPlayerName.TabIndex = 1;
            this.lblFirstPlayerName.Text = "FirstPlayerName";
            // 
            // lblSecondPlayerName
            // 
            this.lblSecondPlayerName.AutoSize = true;
            this.lblSecondPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondPlayerName.Location = new System.Drawing.Point(23, 153);
            this.lblSecondPlayerName.Name = "lblSecondPlayerName";
            this.lblSecondPlayerName.Size = new System.Drawing.Size(202, 25);
            this.lblSecondPlayerName.TabIndex = 2;
            this.lblSecondPlayerName.Text = "SecondPlayerName";
            // 
            // lblThirdPlayerName
            // 
            this.lblThirdPlayerName.AutoSize = true;
            this.lblThirdPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdPlayerName.Location = new System.Drawing.Point(47, 213);
            this.lblThirdPlayerName.Name = "lblThirdPlayerName";
            this.lblThirdPlayerName.Size = new System.Drawing.Size(178, 25);
            this.lblThirdPlayerName.TabIndex = 3;
            this.lblThirdPlayerName.Text = "ThirdPlayerName";
            // 
            // lblFirstPlayerPoints
            // 
            this.lblFirstPlayerPoints.AutoSize = true;
            this.lblFirstPlayerPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstPlayerPoints.Location = new System.Drawing.Point(250, 94);
            this.lblFirstPlayerPoints.Name = "lblFirstPlayerPoints";
            this.lblFirstPlayerPoints.Size = new System.Drawing.Size(175, 25);
            this.lblFirstPlayerPoints.TabIndex = 4;
            this.lblFirstPlayerPoints.Text = "FirstPlayerPoints";
            // 
            // lblSecondPlayerPoints
            // 
            this.lblSecondPlayerPoints.AutoSize = true;
            this.lblSecondPlayerPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondPlayerPoints.Location = new System.Drawing.Point(250, 153);
            this.lblSecondPlayerPoints.Name = "lblSecondPlayerPoints";
            this.lblSecondPlayerPoints.Size = new System.Drawing.Size(206, 25);
            this.lblSecondPlayerPoints.TabIndex = 5;
            this.lblSecondPlayerPoints.Text = "SecondPlayerPoints";
            // 
            // lblThirdPlayerPoints
            // 
            this.lblThirdPlayerPoints.AutoSize = true;
            this.lblThirdPlayerPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdPlayerPoints.Location = new System.Drawing.Point(250, 213);
            this.lblThirdPlayerPoints.Name = "lblThirdPlayerPoints";
            this.lblThirdPlayerPoints.Size = new System.Drawing.Size(182, 25);
            this.lblThirdPlayerPoints.TabIndex = 6;
            this.lblThirdPlayerPoints.Text = "ThirdPlayerPoints";
            // 
            // RoundEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 357);
            this.Controls.Add(this.lblThirdPlayerPoints);
            this.Controls.Add(this.lblSecondPlayerPoints);
            this.Controls.Add(this.lblFirstPlayerPoints);
            this.Controls.Add(this.lblThirdPlayerName);
            this.Controls.Add(this.lblSecondPlayerName);
            this.Controls.Add(this.lblFirstPlayerName);
            this.Controls.Add(this.lblTitle);
            this.Name = "RoundEnd";
            this.ShowIcon = false;
            this.Text = "RoundEnd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFirstPlayerName;
        private System.Windows.Forms.Label lblSecondPlayerName;
        private System.Windows.Forms.Label lblThirdPlayerName;
        private System.Windows.Forms.Label lblFirstPlayerPoints;
        private System.Windows.Forms.Label lblSecondPlayerPoints;
        private System.Windows.Forms.Label lblThirdPlayerPoints;
    }
}