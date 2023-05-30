using System.ComponentModel.DataAnnotations;

namespace TestGame
{
    public partial class Form1 : Form
    {
        // Using a list makes it possible to add the Snake Parts in order. We want the head to be index 0 and body index 1.
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();

        // Variables to store the data of the scores and the max W&H of the gameArea
        int maxWidth;
        int maxHeight;

        int score;
        int highScore;

        // Random generater to place the Food on different places
        Random random = new Random();

        // Since all of these variables are Bools, we can write them like this instead of seperate lines of code.
        bool goLeft, goRight, goDown, goUp;


        public Form1()
        {
            InitializeComponent();

            new Settings();
        }

        // Here we register the input of a player and match it with the corresponding value.
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Right && Settings.directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = true;
            }



        }

        // This happens after we Release the key. So a new input can be added.
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Left)
                {
                    goDown = false;
                }
                if (e.KeyCode == Keys.Right)
                {
                    goRight = false;
                }
                if (e.KeyCode == Keys.Up)
                {
                    goUp = false;
                }
                if (e.KeyCode == Keys.Down)
                {
                    goDown = false;
                }
            }
        }
    // This method starts the game
        private void StartGame(object sender, EventArgs e)
        {
                RestartGame();
        }

     // This method allowes you to create a Screenshot of your performance
        private void TakeSnapShot(object sender, EventArgs e)
        {

        }

        // This has to do with the updating of the game. Based on the timer
        private void GameTimerEvent(object sender, EventArgs e)
        {
            if (goLeft)
            {
                Settings.directions = "left";
            }
            if (goRight)
            {
                Settings.directions = "right";
            }
            if (goDown)
            {
                Settings.directions = "down";
            }
            if (goUp) 
            {
                Settings.directions = "up;";

            }

            for (int i = Snake.Count -1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].Y++;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                    }
                    
                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = maxWidth;
                    } 
                    if (Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    } 
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    } 
                    if (Snake[i].Y < maxHeight)
                    {
                        Snake[i].Y = 0;
                    }


                }



            }

        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            Brush snakeColour;

            for (int i = 0; i< Snake.Count; i++)
            {
                if ( i == 0 )
                {

                    snakeColour = Brushes.Black;
                }
                else
                {

                    snakeColour= Brushes.DarkGreen;
                }

                canvas.FillEllipse(snakeColour, new Rectangle(
                        Snake[i].X * Settings.Width,
                        Snake[i].Y * Settings.Height,
                        Settings.Width, Settings.Height
                    ));
            }

            canvas.FillEllipse(Brushes.DarkRed, new Rectangle(
            food.X * Settings.Width,
            food.Y * Settings.Height,
            Settings.Width, Settings.Height
            ));



        }

        private void RestartGame()
        {               // I dont rlly know what this is supposed to be. bit this has to do with the "Painting" of the map/game
            maxWidth = picCanvas.Width / Settings.Width - 1;

            Snake.Clear();

            StartButton.Enabled = false;   
            SnapButton.Enabled = false; 

            score = 0;
            txtScore.Text = "Score:" + score;

            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head); // List count from 0 making the head the first index

            for (int i = 0; i < 10; i++)
            {

                Circle body = new Circle();
                Snake.Add(body);

            }

            food = new Circle() { X = random.Next(2, maxWidth),Y = random.Next(2, maxHeight) };
            
            gameTimer.Start();

        }

        private void EatFood()
        {


        }

        private void GameOver()
        {


        }



    }
}