namespace Pictionnary.Forms
{
    partial class CreateRoomView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateRoomView));
            this.pnlMainPanel = new System.Windows.Forms.Panel();
            this.btnCreateRoom = new System.Windows.Forms.Button();
            this.lbl_ParamGame = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkcomboboxThemes = new CheckComboBox.CheckComboBoxControl();
            this.chkBoxInversedMouse = new System.Windows.Forms.CheckBox();
            this.chkBoxContinuedWrite = new System.Windows.Forms.CheckBox();
            this.chkBoxBlind = new System.Windows.Forms.CheckBox();
            this.chkBoxClues = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numUpDownTimeLimit = new System.Windows.Forms.NumericUpDown();
            this.cmbBoxGameDifficulty = new System.Windows.Forms.ComboBox();
            this.lbl_GameTime = new System.Windows.Forms.Label();
            this.lblGameDifficulty = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblParamRoom = new System.Windows.Forms.Label();
            this.pnlConfigRoom = new System.Windows.Forms.Panel();
            this.chkBoxGamesLimit = new System.Windows.Forms.CheckBox();
            this.numUpDownGamesLimit = new System.Windows.Forms.NumericUpDown();
            this.numUpDownLimitPlayers = new System.Windows.Forms.NumericUpDown();
            this.lblPlayersLimit = new System.Windows.Forms.Label();
            this.txtBoxRoomPassword = new System.Windows.Forms.TextBox();
            this.lblRoomPassword = new System.Windows.Forms.Label();
            this.txtBoxRoomName = new System.Windows.Forms.TextBox();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.lblMiddleLine = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlWhiteSpace = new System.Windows.Forms.Panel();
            this.pnlMainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTimeLimit)).BeginInit();
            this.pnlConfigRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownGamesLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownLimitPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainPanel
            // 
            this.pnlMainPanel.Controls.Add(this.btnCreateRoom);
            this.pnlMainPanel.Controls.Add(this.lbl_ParamGame);
            this.pnlMainPanel.Controls.Add(this.panel1);
            this.pnlMainPanel.Controls.Add(this.lblParamRoom);
            this.pnlMainPanel.Controls.Add(this.pnlConfigRoom);
            this.pnlMainPanel.Controls.Add(this.lblMiddleLine);
            this.pnlMainPanel.Controls.Add(this.lblTitle);
            this.pnlMainPanel.Location = new System.Drawing.Point(1, 28);
            this.pnlMainPanel.Name = "pnlMainPanel";
            this.pnlMainPanel.Size = new System.Drawing.Size(601, 537);
            this.pnlMainPanel.TabIndex = 3;
            // 
            // btnCreateRoom
            // 
            this.btnCreateRoom.Location = new System.Drawing.Point(234, 477);
            this.btnCreateRoom.Name = "btnCreateRoom";
            this.btnCreateRoom.Size = new System.Drawing.Size(116, 35);
            this.btnCreateRoom.TabIndex = 18;
            this.btnCreateRoom.Text = "Créer";
            this.btnCreateRoom.UseVisualStyleBackColor = true;
            this.btnCreateRoom.Click += new System.EventHandler(this.btnCreateRoom_Click);
            // 
            // lbl_ParamGame
            // 
            this.lbl_ParamGame.AutoSize = true;
            this.lbl_ParamGame.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ParamGame.Location = new System.Drawing.Point(346, 86);
            this.lbl_ParamGame.Name = "lbl_ParamGame";
            this.lbl_ParamGame.Size = new System.Drawing.Size(206, 21);
            this.lbl_ParamGame.TabIndex = 17;
            this.lbl_ParamGame.Text = "Paramètres de la partie";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chkcomboboxThemes);
            this.panel1.Controls.Add(this.chkBoxInversedMouse);
            this.panel1.Controls.Add(this.chkBoxContinuedWrite);
            this.panel1.Controls.Add(this.chkBoxBlind);
            this.panel1.Controls.Add(this.chkBoxClues);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numUpDownTimeLimit);
            this.panel1.Controls.Add(this.cmbBoxGameDifficulty);
            this.panel1.Controls.Add(this.lbl_GameTime);
            this.panel1.Controls.Add(this.lblGameDifficulty);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(326, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 350);
            this.panel1.TabIndex = 16;
            // 
            // chkcomboboxThemes
            // 
            this.chkcomboboxThemes.Drop = null;
            this.chkcomboboxThemes.ItemText = "items";
            this.chkcomboboxThemes.Location = new System.Drawing.Point(7, 40);
            this.chkcomboboxThemes.Name = "chkcomboboxThemes";
            this.chkcomboboxThemes.PlaceholderText = "Veuillez choissir au moins un thème";
            this.chkcomboboxThemes.Size = new System.Drawing.Size(205, 19);
            this.chkcomboboxThemes.TabIndex = 19;
            this.chkcomboboxThemes.TextMode = CheckComboBox.CheckComboBoxTextMode.Items;
            // 
            // chkBoxInversedMouse
            // 
            this.chkBoxInversedMouse.AutoSize = true;
            this.chkBoxInversedMouse.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxInversedMouse.Location = new System.Drawing.Point(23, 324);
            this.chkBoxInversedMouse.Name = "chkBoxInversedMouse";
            this.chkBoxInversedMouse.Size = new System.Drawing.Size(114, 19);
            this.chkBoxInversedMouse.TabIndex = 19;
            this.chkBoxInversedMouse.Text = "Souris inversée";
            this.chkBoxInversedMouse.UseVisualStyleBackColor = true;
            // 
            // chkBoxContinuedWrite
            // 
            this.chkBoxContinuedWrite.AutoSize = true;
            this.chkBoxContinuedWrite.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxContinuedWrite.Location = new System.Drawing.Point(23, 299);
            this.chkBoxContinuedWrite.Name = "chkBoxContinuedWrite";
            this.chkBoxContinuedWrite.Size = new System.Drawing.Size(97, 19);
            this.chkBoxContinuedWrite.TabIndex = 18;
            this.chkBoxContinuedWrite.Text = "Traît continu";
            this.chkBoxContinuedWrite.UseVisualStyleBackColor = true;
            // 
            // chkBoxBlind
            // 
            this.chkBoxBlind.AutoSize = true;
            this.chkBoxBlind.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxBlind.Location = new System.Drawing.Point(23, 274);
            this.chkBoxBlind.Name = "chkBoxBlind";
            this.chkBoxBlind.Size = new System.Drawing.Size(71, 19);
            this.chkBoxBlind.TabIndex = 17;
            this.chkBoxBlind.Text = "Aveugle";
            this.chkBoxBlind.UseVisualStyleBackColor = true;
            // 
            // chkBoxClues
            // 
            this.chkBoxClues.AutoSize = true;
            this.chkBoxClues.Font = new System.Drawing.Font("Liberation Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxClues.Location = new System.Drawing.Point(23, 249);
            this.chkBoxClues.Name = "chkBoxClues";
            this.chkBoxClues.Size = new System.Drawing.Size(67, 19);
            this.chkBoxClues.TabIndex = 16;
            this.chkBoxClues.Text = "Indices";
            this.chkBoxClues.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Bonus :";
            // 
            // numUpDownTimeLimit
            // 
            this.numUpDownTimeLimit.Location = new System.Drawing.Point(7, 181);
            this.numUpDownTimeLimit.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDownTimeLimit.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUpDownTimeLimit.Name = "numUpDownTimeLimit";
            this.numUpDownTimeLimit.Size = new System.Drawing.Size(60, 20);
            this.numUpDownTimeLimit.TabIndex = 15;
            this.numUpDownTimeLimit.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // cmbBoxGameDifficulty
            // 
            this.cmbBoxGameDifficulty.FormattingEnabled = true;
            this.cmbBoxGameDifficulty.Items.AddRange(new object[] {
            "Facile",
            "Moyen",
            "Difficile"});
            this.cmbBoxGameDifficulty.Location = new System.Drawing.Point(7, 107);
            this.cmbBoxGameDifficulty.Name = "cmbBoxGameDifficulty";
            this.cmbBoxGameDifficulty.Size = new System.Drawing.Size(205, 21);
            this.cmbBoxGameDifficulty.TabIndex = 14;
            // 
            // lbl_GameTime
            // 
            this.lbl_GameTime.AutoSize = true;
            this.lbl_GameTime.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GameTime.Location = new System.Drawing.Point(3, 157);
            this.lbl_GameTime.Name = "lbl_GameTime";
            this.lbl_GameTime.Size = new System.Drawing.Size(117, 21);
            this.lbl_GameTime.TabIndex = 10;
            this.lbl_GameTime.Text = "Temps limite";
            // 
            // lblGameDifficulty
            // 
            this.lblGameDifficulty.AutoSize = true;
            this.lblGameDifficulty.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameDifficulty.Location = new System.Drawing.Point(3, 82);
            this.lblGameDifficulty.Name = "lblGameDifficulty";
            this.lblGameDifficulty.Size = new System.Drawing.Size(84, 21);
            this.lblGameDifficulty.TabIndex = 8;
            this.lblGameDifficulty.Text = "Difficulté";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thèmes";
            // 
            // lblParamRoom
            // 
            this.lblParamRoom.AutoSize = true;
            this.lblParamRoom.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParamRoom.Location = new System.Drawing.Point(32, 86);
            this.lblParamRoom.Name = "lblParamRoom";
            this.lblParamRoom.Size = new System.Drawing.Size(198, 21);
            this.lblParamRoom.TabIndex = 5;
            this.lblParamRoom.Text = "Paramètres de la salle";
            // 
            // pnlConfigRoom
            // 
            this.pnlConfigRoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConfigRoom.Controls.Add(this.chkBoxGamesLimit);
            this.pnlConfigRoom.Controls.Add(this.numUpDownGamesLimit);
            this.pnlConfigRoom.Controls.Add(this.numUpDownLimitPlayers);
            this.pnlConfigRoom.Controls.Add(this.lblPlayersLimit);
            this.pnlConfigRoom.Controls.Add(this.txtBoxRoomPassword);
            this.pnlConfigRoom.Controls.Add(this.lblRoomPassword);
            this.pnlConfigRoom.Controls.Add(this.txtBoxRoomName);
            this.pnlConfigRoom.Controls.Add(this.lblRoomName);
            this.pnlConfigRoom.Location = new System.Drawing.Point(12, 112);
            this.pnlConfigRoom.Name = "pnlConfigRoom";
            this.pnlConfigRoom.Size = new System.Drawing.Size(257, 350);
            this.pnlConfigRoom.TabIndex = 4;
            // 
            // chkBoxGamesLimit
            // 
            this.chkBoxGamesLimit.AutoSize = true;
            this.chkBoxGamesLimit.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxGamesLimit.Location = new System.Drawing.Point(23, 219);
            this.chkBoxGamesLimit.Name = "chkBoxGamesLimit";
            this.chkBoxGamesLimit.Size = new System.Drawing.Size(169, 25);
            this.chkBoxGamesLimit.TabIndex = 15;
            this.chkBoxGamesLimit.Text = "Limite de parties";
            this.chkBoxGamesLimit.UseVisualStyleBackColor = true;
            // 
            // numUpDownGamesLimit
            // 
            this.numUpDownGamesLimit.Location = new System.Drawing.Point(40, 250);
            this.numUpDownGamesLimit.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numUpDownGamesLimit.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUpDownGamesLimit.Name = "numUpDownGamesLimit";
            this.numUpDownGamesLimit.Size = new System.Drawing.Size(60, 20);
            this.numUpDownGamesLimit.TabIndex = 14;
            this.numUpDownGamesLimit.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numUpDownLimitPlayers
            // 
            this.numUpDownLimitPlayers.Location = new System.Drawing.Point(7, 181);
            this.numUpDownLimitPlayers.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numUpDownLimitPlayers.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numUpDownLimitPlayers.Name = "numUpDownLimitPlayers";
            this.numUpDownLimitPlayers.Size = new System.Drawing.Size(60, 20);
            this.numUpDownLimitPlayers.TabIndex = 12;
            this.numUpDownLimitPlayers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblPlayersLimit
            // 
            this.lblPlayersLimit.AutoSize = true;
            this.lblPlayersLimit.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayersLimit.Location = new System.Drawing.Point(3, 157);
            this.lblPlayersLimit.Name = "lblPlayersLimit";
            this.lblPlayersLimit.Size = new System.Drawing.Size(155, 21);
            this.lblPlayersLimit.TabIndex = 10;
            this.lblPlayersLimit.Text = "Limite de joueurs";
            // 
            // txtBoxRoomPassword
            // 
            this.txtBoxRoomPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxRoomPassword.Location = new System.Drawing.Point(7, 107);
            this.txtBoxRoomPassword.Name = "txtBoxRoomPassword";
            this.txtBoxRoomPassword.Size = new System.Drawing.Size(210, 20);
            this.txtBoxRoomPassword.TabIndex = 9;
            // 
            // lblRoomPassword
            // 
            this.lblRoomPassword.AutoSize = true;
            this.lblRoomPassword.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomPassword.Location = new System.Drawing.Point(3, 82);
            this.lblRoomPassword.Name = "lblRoomPassword";
            this.lblRoomPassword.Size = new System.Drawing.Size(209, 21);
            this.lblRoomPassword.TabIndex = 8;
            this.lblRoomPassword.Text = "Mot de passe (optionel)";
            // 
            // txtBoxRoomName
            // 
            this.txtBoxRoomName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxRoomName.Location = new System.Drawing.Point(7, 39);
            this.txtBoxRoomName.Name = "txtBoxRoomName";
            this.txtBoxRoomName.Size = new System.Drawing.Size(210, 20);
            this.txtBoxRoomName.TabIndex = 7;
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("Liberation Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomName.Location = new System.Drawing.Point(3, 14);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(145, 21);
            this.lblRoomName.TabIndex = 6;
            this.lblRoomName.Text = "Nom de la room";
            // 
            // lblMiddleLine
            // 
            this.lblMiddleLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMiddleLine.Location = new System.Drawing.Point(287, 86);
            this.lblMiddleLine.Name = "lblMiddleLine";
            this.lblMiddleLine.Size = new System.Drawing.Size(10, 375);
            this.lblMiddleLine.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(102, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(386, 68);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Créer une room";
            // 
            // pnlWhiteSpace
            // 
            this.pnlWhiteSpace.BackColor = System.Drawing.Color.White;
            this.pnlWhiteSpace.Location = new System.Drawing.Point(1, -2);
            this.pnlWhiteSpace.Name = "pnlWhiteSpace";
            this.pnlWhiteSpace.Size = new System.Drawing.Size(598, 48);
            this.pnlWhiteSpace.TabIndex = 4;
            // 
            // CreateRoomView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 562);
            this.Controls.Add(this.pnlWhiteSpace);
            this.Controls.Add(this.pnlMainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateRoomView";
            this.Text = "                                                                    CreateRoomVie" +
    "w";
            this.pnlMainPanel.ResumeLayout(false);
            this.pnlMainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownTimeLimit)).EndInit();
            this.pnlConfigRoom.ResumeLayout(false);
            this.pnlConfigRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownGamesLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownLimitPlayers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlWhiteSpace;
        private System.Windows.Forms.Panel pnlConfigRoom;
        private System.Windows.Forms.Label lblMiddleLine;
        private System.Windows.Forms.Label lblParamRoom;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.TextBox txtBoxRoomName;
        private System.Windows.Forms.TextBox txtBoxRoomPassword;
        private System.Windows.Forms.Label lblRoomPassword;
        private System.Windows.Forms.Label lblPlayersLimit;
        private System.Windows.Forms.NumericUpDown numUpDownLimitPlayers;
        private System.Windows.Forms.NumericUpDown numUpDownGamesLimit;
        private System.Windows.Forms.CheckBox chkBoxGamesLimit;
        private System.Windows.Forms.Label lbl_ParamGame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_GameTime;
        private System.Windows.Forms.Label lblGameDifficulty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBoxGameDifficulty;
        private System.Windows.Forms.NumericUpDown numUpDownTimeLimit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBoxBlind;
        private System.Windows.Forms.CheckBox chkBoxClues;
        private System.Windows.Forms.CheckBox chkBoxInversedMouse;
        private System.Windows.Forms.CheckBox chkBoxContinuedWrite;
        private System.Windows.Forms.Button btnCreateRoom;
        private CheckComboBox.CheckComboBoxControl chkcomboboxThemes;
    }
}