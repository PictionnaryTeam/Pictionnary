﻿namespace Pictionnary.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoundEnd));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFirstPlayerName = new System.Windows.Forms.Label();
            this.lblSecondPlayerName = new System.Windows.Forms.Label();
            this.lblThirdPlayerName = new System.Windows.Forms.Label();
            this.lblThirdPlayerPoints = new System.Windows.Forms.Label();
            this.lblSecondPlayerPoints = new System.Windows.Forms.Label();
            this.lblFirstPlayerPoints = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(135, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Fin de la manche :";
            // 
            // lblFirstPlayerName
            // 
            this.lblFirstPlayerName.AutoSize = true;
            this.lblFirstPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstPlayerName.Location = new System.Drawing.Point(22, 87);
            this.lblFirstPlayerName.Name = "lblFirstPlayerName";
            this.lblFirstPlayerName.Size = new System.Drawing.Size(171, 25);
            this.lblFirstPlayerName.TabIndex = 1;
            this.lblFirstPlayerName.Text = "FirstPlayerName";
            // 
            // lblSecondPlayerName
            // 
            this.lblSecondPlayerName.AutoSize = true;
            this.lblSecondPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondPlayerName.Location = new System.Drawing.Point(22, 138);
            this.lblSecondPlayerName.Name = "lblSecondPlayerName";
            this.lblSecondPlayerName.Size = new System.Drawing.Size(202, 25);
            this.lblSecondPlayerName.TabIndex = 2;
            this.lblSecondPlayerName.Text = "SecondPlayerName";
            // 
            // lblThirdPlayerName
            // 
            this.lblThirdPlayerName.AutoSize = true;
            this.lblThirdPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdPlayerName.Location = new System.Drawing.Point(22, 188);
            this.lblThirdPlayerName.Name = "lblThirdPlayerName";
            this.lblThirdPlayerName.Size = new System.Drawing.Size(178, 25);
            this.lblThirdPlayerName.TabIndex = 3;
            this.lblThirdPlayerName.Text = "ThirdPlayerName";
            // 
            // lblThirdPlayerPoints
            // 
            this.lblThirdPlayerPoints.AutoSize = true;
            this.lblThirdPlayerPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdPlayerPoints.Location = new System.Drawing.Point(254, 188);
            this.lblThirdPlayerPoints.Name = "lblThirdPlayerPoints";
            this.lblThirdPlayerPoints.Size = new System.Drawing.Size(182, 25);
            this.lblThirdPlayerPoints.TabIndex = 6;
            this.lblThirdPlayerPoints.Text = "ThirdPlayerPoints";
            // 
            // lblSecondPlayerPoints
            // 
            this.lblSecondPlayerPoints.AutoSize = true;
            this.lblSecondPlayerPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondPlayerPoints.Location = new System.Drawing.Point(254, 138);
            this.lblSecondPlayerPoints.Name = "lblSecondPlayerPoints";
            this.lblSecondPlayerPoints.Size = new System.Drawing.Size(206, 25);
            this.lblSecondPlayerPoints.TabIndex = 5;
            this.lblSecondPlayerPoints.Text = "SecondPlayerPoints";
            // 
            // lblFirstPlayerPoints
            // 
            this.lblFirstPlayerPoints.AutoSize = true;
            this.lblFirstPlayerPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstPlayerPoints.Location = new System.Drawing.Point(254, 87);
            this.lblFirstPlayerPoints.Name = "lblFirstPlayerPoints";
            this.lblFirstPlayerPoints.Size = new System.Drawing.Size(175, 25);
            this.lblFirstPlayerPoints.TabIndex = 4;
            this.lblFirstPlayerPoints.Text = "FirstPlayerPoints";
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(425, 297);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 7;
            this.btnContinue.Text = "Continuer";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // RoundEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 332);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblThirdPlayerPoints);
            this.Controls.Add(this.lblSecondPlayerPoints);
            this.Controls.Add(this.lblFirstPlayerPoints);
            this.Controls.Add(this.lblThirdPlayerName);
            this.Controls.Add(this.lblSecondPlayerName);
            this.Controls.Add(this.lblFirstPlayerName);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RoundEnd";
            this.Text = "RoundEnd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFirstPlayerName;
        private System.Windows.Forms.Label lblSecondPlayerName;
        private System.Windows.Forms.Label lblThirdPlayerName;
        private System.Windows.Forms.Label lblThirdPlayerPoints;
        private System.Windows.Forms.Label lblSecondPlayerPoints;
        private System.Windows.Forms.Label lblFirstPlayerPoints;
        private System.Windows.Forms.Button btnContinue;
    }
}