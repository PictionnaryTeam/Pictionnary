namespace Pictionnary.Forms
{
    partial class GameView
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
            this.components = new System.ComponentModel.Container();
            this.pnlPlayers = new System.Windows.Forms.Panel();
            this.lblChat = new System.Windows.Forms.Label();
            this.tbxChat = new System.Windows.Forms.TextBox();
            this.pnlTimer = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnStopGame = new System.Windows.Forms.Button();
            this.pbxRoomMaster = new System.Windows.Forms.PictureBox();
            this.pnlPlayersPoints = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.pnlPlayers.SuspendLayout();
            this.pnlTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRoomMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPlayers
            // 
            this.pnlPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPlayers.Controls.Add(this.pnlPlayersPoints);
            this.pnlPlayers.Controls.Add(this.pbxRoomMaster);
            this.pnlPlayers.Controls.Add(this.btnStopGame);
            this.pnlPlayers.Location = new System.Drawing.Point(0, 0);
            this.pnlPlayers.Name = "pnlPlayers";
            this.pnlPlayers.Size = new System.Drawing.Size(183, 538);
            this.pnlPlayers.TabIndex = 0;
            // 
            // lblChat
            // 
            this.lblChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChat.Location = new System.Drawing.Point(798, 0);
            this.lblChat.Name = "lblChat";
            this.lblChat.Size = new System.Drawing.Size(185, 579);
            this.lblChat.TabIndex = 1;
            // 
            // tbxChat
            // 
            this.tbxChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxChat.Location = new System.Drawing.Point(798, 578);
            this.tbxChat.Name = "tbxChat";
            this.tbxChat.Size = new System.Drawing.Size(185, 24);
            this.tbxChat.TabIndex = 2;
            // 
            // pnlTimer
            // 
            this.pnlTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTimer.Controls.Add(this.lblTimer);
            this.pnlTimer.Location = new System.Drawing.Point(0, 537);
            this.pnlTimer.Name = "pnlTimer";
            this.pnlTimer.Size = new System.Drawing.Size(183, 65);
            this.pnlTimer.TabIndex = 1;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(52, 21);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(71, 25);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "00:00";
            // 
            // btnStopGame
            // 
            this.btnStopGame.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnStopGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopGame.Location = new System.Drawing.Point(44, 470);
            this.btnStopGame.Name = "btnStopGame";
            this.btnStopGame.Size = new System.Drawing.Size(89, 48);
            this.btnStopGame.TabIndex = 0;
            this.btnStopGame.Text = "Arrêter la partie";
            this.btnStopGame.UseVisualStyleBackColor = false;
            // 
            // pbxRoomMaster
            // 
            this.pbxRoomMaster.Location = new System.Drawing.Point(2, 20);
            this.pbxRoomMaster.Name = "pbxRoomMaster";
            this.pbxRoomMaster.Size = new System.Drawing.Size(20, 20);
            this.pbxRoomMaster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxRoomMaster.TabIndex = 1;
            this.pbxRoomMaster.TabStop = false;
            // 
            // pnlPlayersPoints
            // 
            this.pnlPlayersPoints.Location = new System.Drawing.Point(25, 20);
            this.pnlPlayersPoints.Name = "pnlPlayersPoints";
            this.pnlPlayersPoints.Size = new System.Drawing.Size(151, 115);
            this.pnlPlayersPoints.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "_ _ _ _ _ _ _ _ _";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 602);
            this.Controls.Add(this.lblChat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlTimer);
            this.Controls.Add(this.tbxChat);
            this.Controls.Add(this.pnlPlayers);
            this.Name = "GameView";
            this.Text = "                                                                                 " +
    "                                                             Game view";
            this.pnlPlayers.ResumeLayout(false);
            this.pnlTimer.ResumeLayout(false);
            this.pnlTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRoomMaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlPlayers;
        private System.Windows.Forms.Label lblChat;
        private System.Windows.Forms.TextBox tbxChat;
        private System.Windows.Forms.Panel pnlTimer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnStopGame;
        private System.Windows.Forms.Panel pnlPlayersPoints;
        private System.Windows.Forms.PictureBox pbxRoomMaster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerGame;
    }
}