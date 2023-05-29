namespace TestGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            StartButton = new Button();
            SnapButton = new Button();
            gameArea = new PictureBox();
            txtScore = new Label();
            txtHS = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)gameArea).BeginInit();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.BackColor = SystemColors.ActiveCaption;
            StartButton.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            StartButton.Location = new Point(815, 12);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(151, 58);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartGame;
            // 
            // SnapButton
            // 
            SnapButton.BackColor = Color.Lime;
            SnapButton.Font = new Font("Showcard Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point);
            SnapButton.Location = new Point(815, 96);
            SnapButton.Name = "SnapButton";
            SnapButton.Size = new Size(151, 58);
            SnapButton.TabIndex = 1;
            SnapButton.Text = "Snap";
            SnapButton.UseVisualStyleBackColor = false;
            SnapButton.Click += TakeSnapShot;
            // 
            // gameArea
            // 
            gameArea.BackColor = SystemColors.ActiveBorder;
            gameArea.Location = new Point(28, 12);
            gameArea.Name = "gameArea";
            gameArea.Size = new Size(781, 820);
            gameArea.TabIndex = 3;
            gameArea.TabStop = false;
            gameArea.Paint += UpdatePictureBoxGraphics;
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.BackColor = SystemColors.ControlDark;
            txtScore.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtScore.Location = new Point(815, 176);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(97, 26);
            txtScore.TabIndex = 4;
            txtScore.Text = "Score: 0";
            // 
            // txtHS
            // 
            txtHS.AutoSize = true;
            txtHS.BackColor = SystemColors.ControlDark;
            txtHS.Font = new Font("Showcard Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtHS.Location = new Point(815, 214);
            txtHS.Name = "txtHS";
            txtHS.Size = new Size(127, 26);
            txtHS.TabIndex = 4;
            txtHS.Text = "HighScore";
            // 
            // gameTimer
            // 
            gameTimer.Interval = 40;
            gameTimer.Tick += GameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 844);
            Controls.Add(txtHS);
            Controls.Add(txtScore);
            Controls.Add(gameArea);
            Controls.Add(SnapButton);
            Controls.Add(StartButton);
            MaximumSize = new Size(1000, 900);
            Name = "Form1";
            Text = "Game";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)gameArea).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private Button SnapButton;
        private PictureBox gameArea;
        private Label txtScore;
        private Label txtHS;
        private System.Windows.Forms.Timer gameTimer;
    }
}