namespace Pictionnary.Forms
{
    partial class JoinRoomView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoinRoomView));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBoxIPRoom = new System.Windows.Forms.TextBox();
            this.lblIPRoom = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnJoinRoom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(482, 68);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Rejoindre une room";
            // 
            // txtBoxIPRoom
            // 
            this.txtBoxIPRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxIPRoom.Location = new System.Drawing.Point(127, 151);
            this.txtBoxIPRoom.Name = "txtBoxIPRoom";
            this.txtBoxIPRoom.Size = new System.Drawing.Size(244, 20);
            this.txtBoxIPRoom.TabIndex = 9;
            // 
            // lblIPRoom
            // 
            this.lblIPRoom.AutoSize = true;
            this.lblIPRoom.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPRoom.Location = new System.Drawing.Point(148, 127);
            this.lblIPRoom.Name = "lblIPRoom";
            this.lblIPRoom.Size = new System.Drawing.Size(201, 21);
            this.lblIPRoom.TabIndex = 8;
            this.lblIPRoom.Text = "Adresse IP de la room";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPassword.Location = new System.Drawing.Point(127, 251);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(244, 20);
            this.txtBoxPassword.TabIndex = 11;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(186, 227);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(125, 21);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Mot de passe";
            // 
            // btnJoinRoom
            // 
            this.btnJoinRoom.Location = new System.Drawing.Point(190, 329);
            this.btnJoinRoom.Name = "btnJoinRoom";
            this.btnJoinRoom.Size = new System.Drawing.Size(116, 35);
            this.btnJoinRoom.TabIndex = 19;
            this.btnJoinRoom.Text = "Rejoindre";
            this.btnJoinRoom.UseVisualStyleBackColor = true;
            this.btnJoinRoom.Click += new System.EventHandler(this.btnJoinRoom_Click);
            // 
            // JoinRoomView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 390);
            this.Controls.Add(this.btnJoinRoom);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtBoxIPRoom);
            this.Controls.Add(this.lblIPRoom);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JoinRoomView";
            this.Text = "                                                      Rejoindre une room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBoxIPRoom;
        private System.Windows.Forms.Label lblIPRoom;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnJoinRoom;
    }
}