using System.Windows.Forms;

namespace TronByDoczi
{
    public partial class Form1 : Form
    {

        static int gridSize = 7;

        private Snake snake;
        private Snake player2;
        public Form1()
        {
            InitializeComponent();
            snake = new Snake();
            player2 = new Snake();
            player2.Body[0] = new Point(60, 40);
            player2.Direction = Direction.Left;
            
            string nev_1 = textBox1.Text;
            string nev_2 = textBox1.Text;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    snake.ChangeDirection(Direction.Up);
                    break;
                case Keys.Down:
                    snake.ChangeDirection(Direction.Down);
                    break;
                case Keys.Left:
                    snake.ChangeDirection(Direction.Left);
                    break;
                case Keys.Right:
                    snake.ChangeDirection(Direction.Right);
                    break;
                case Keys.W:
                    player2.ChangeDirection(Direction.Up);
                    break;
                case Keys.S:
                    player2.ChangeDirection(Direction.Down);
                    break;
                case Keys.A:
                    player2.ChangeDirection(Direction.Left);
                    break;
                case Keys.D:
                    player2.ChangeDirection(Direction.Right);
                    break;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
            snakeTrail.Add(new Point(snake.Body[0].X, snake.Body[0].Y));

            
            player2Trail.Add(new Point(player2.Body[0].X, player2.Body[0].Y));

            
            snake.Move();
            
            player2.Move();


            // Snake es player2 utkoztese
            for (int i = 0; i < player2Trail.Count; i++)
            {
                if (snake.Body[0] == player2Trail[i])
                {
                    if (snake.Body[0] == player2.Body[0]) // Head collide utkozes
                    {
                        // Dontetlen
                        timer.Stop();
                        valosIdo.Stop();
                        nyert.Visible = true;
                        nyert.Text = ($"DÖNTETLEN!!!");
                    }
                    else
                    {

                        timer.Stop();
                        valosIdo.Stop();
                        nyert.Visible = true;
                        nyert.Text = ($"{textBox2.Text} nyert!");
                    }
                    return;
                }
            }


            for (int i = 0; i < player2.Body.Count; i++)
            {
                if (snake.Body[0] == player2.Body[i])
                {
                    if (snake.Body[0] == player2.Body[0]) 
                    {
                        // Dontetlen
                        timer.Stop();
                        valosIdo.Stop();
                        nyert.Visible = true;
                        nyert.Text = ($"Döntetlen!!!");
                    }
                    else
                    {
                        return;
                    }
                    return;
                }
            }

            for (int i = 0; i < snakeTrail.Count; i++)
            {
                if (player2.Body[0] == snakeTrail[i])
                {
                    timer.Stop();
                    valosIdo.Stop();
                    nyert.Visible = true;
                    nyert.Text = ($"{textBox1.Text} nyert!");
                    return;
                }
            }

            for (int i = 1; i < snakeTrail.Count; i++)
            {
                if (snake.Body[0] == snakeTrail[i])
                {
                    timer.Stop();
                    valosIdo.Stop();
                    nyert.Visible = true;
                    nyert.Text = ($"{textBox2.Text} nyert!");
                    return;
                }
            }

            for (int i = 1; i < player2Trail.Count; i++)
            {
                if (player2.Body[0] == player2Trail[i])
                {
                    timer.Stop();
                    valosIdo.Stop();
                    nyert.Visible = true;
                    nyert.Text = ($"{textBox1.Text} nyert!");
                    return;
                }
            }
            Rectangle player2Bounds = new Rectangle(
            player2.Body[0].X * gridSize,
            player2.Body[0].Y * gridSize,
            gridSize,
            gridSize
            );

            Rectangle snakeBounds = new Rectangle(
            snake.Body[0].X * gridSize,
            snake.Body[0].Y * gridSize,
            gridSize,
            gridSize
            );

            if (player2Bounds.IntersectsWith(itsOverDude.Bounds))
            {
                timer.Stop();
                valosIdo.Stop();
                nyert.Visible = true;
                nyert.Text = ($"{textBox1.Text} nyert! (kimentél a pályáról!)");
                return;
            }

            if (player2Bounds.IntersectsWith(itsOverDude2.Bounds))
            {
                timer.Stop();
                valosIdo.Stop();
                nyert.Visible = true;
                nyert.Text = ($"{textBox1.Text} nyert! (kimentél a pályáról!)");
                return;
            }

            if (player2Bounds.IntersectsWith(itsOverDude3.Bounds))
            {
                timer.Stop();
                valosIdo.Stop();
                nyert.Visible = true;
                nyert.Text = ($"{textBox1.Text} nyert! (kimentél a pályáról!)");
                return;
            }

            if (player2Bounds.IntersectsWith(itsOverDude4.Bounds))
            {
                timer.Stop();
                valosIdo.Stop();
                nyert.Visible = true;
                nyert.Text = ($"{textBox1.Text} nyert! (kimentél a pályáról!)");
                return;
            }









            if (snakeBounds.IntersectsWith(itsOverDude.Bounds))
            {
                timer.Stop();
                valosIdo.Stop();
                nyert.Visible = true;
                nyert.Text = ($"{textBox2.Text} nyert! (kimentél a pályáról!)");
                return;
            }

            if (snakeBounds.IntersectsWith(itsOverDude2.Bounds))
            {
                timer.Stop();
                valosIdo.Stop();
                nyert.Visible = true;
                nyert.Text = ($"{textBox2.Text} nyert! (kimentél a pályáról!)");
                return;
            }

            if (snakeBounds.IntersectsWith(itsOverDude3.Bounds))
            {
                timer.Stop();
                nyert.Visible = true;
                nyert.Text = ($"{textBox2.Text} nyert! (kimentél a pályáról!)");
                return;
            }

            if (snakeBounds.IntersectsWith(itsOverDude4.Bounds))
            {
                timer.Stop();
                valosIdo.Stop();
                nyert.Visible = true;
                nyert.Text = ($"{textBox2.Text} nyert! (kimentél a pályáról!)");
                return;
            }


            gameArea.Invalidate(); // Game are ujra generalasa
        }
        private List<Point> snakeTrail = new List<Point>();
        private List<Point> player2Trail = new List<Point>();


        private void gameArea_Paint(object sender, PaintEventArgs e)
        {
            // Tisztitas
            e.Graphics.Clear(Color.Black);

            // Elso snake head
            Point head1 = snake.Body[0];
            e.Graphics.FillRectangle(Brushes.Green, head1.X * gridSize, head1.Y * gridSize, gridSize, gridSize);

            // Masodik snake head
            Point head2 = player2.Body[0];
            e.Graphics.FillRectangle(Brushes.Blue, head2.X * gridSize, head2.Y * gridSize, gridSize, gridSize);

            // Elso snake resz
            Pen snakePen = new Pen(Brushes.Green, gridSize);
            for (int i = 1; i < snakeTrail.Count; i++)
            {
                Point start = snakeTrail[i - 1];
                Point end = snakeTrail[i];
                e.Graphics.DrawLine(snakePen, start.X * gridSize + gridSize / 2, start.Y * gridSize + gridSize / 2, end.X * gridSize + gridSize / 2, end.Y * gridSize + gridSize / 2);
            }

            // Masodik snake resz
            Pen player2Pen = new Pen(Brushes.Blue, gridSize);
            for (int i = 1; i < player2Trail.Count; i++)
            {
                Point start = player2Trail[i - 1];
                Point end = player2Trail[i];
                e.Graphics.DrawLine(player2Pen, start.X * gridSize + gridSize / 2, start.Y * gridSize + gridSize / 2, end.X * gridSize + gridSize / 2, end.Y * gridSize + gridSize / 2);
            }





        }

        float masodperc, perc, ora = 0.000f;

        private void valosIdo_Tick(object sender, EventArgs e)
        {
            masodperc = masodperc + 1.00f;
            if (masodperc > 60.00f)
            {
                masodperc = 0.00f;
                perc = perc + 1.00f;
            }
            if (perc > 60.00f)
            {
                perc = 0.00f;
                ora = ora + 1.00f;
            }
            idoT.Text = $"{ora:00}:{perc:00}:{masodperc:00}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Interval = 100;
            timer.Tick += timer_Tick;
            timer.Start();

            button1.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            this.Focus();

            valosIdo.Enabled = true;
        }
    }
}