namespace ICT_426_HomeForm
{
    partial class frm_Home
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Alef", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(130, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(310, 74);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Pictionary";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Alef", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(202, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Rejoindre une room existante";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonFormHomeClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Alef", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(202, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(297, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Créer une nouvelle room";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonFormHomeClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ICT_426_HomeForm.Properties.Resources.ImagePencil;
            this.pictureBox1.Location = new System.Drawing.Point(468, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 565);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Home";
            this.Text = "Accueil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}